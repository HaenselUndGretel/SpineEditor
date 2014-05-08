using KryptonEngine.SceneManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using KryptonEngine;
using KryptonEngine.Entities;
using KryptonEngine.Pools;
using Microsoft.Xna.Framework.Input;
using KryptonEngine.Manager;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using Spine;

namespace SpineEditor
{
	class EditorScene : Scene
	{
		#region Properties

		public SpineObject mSpine;

		protected KeyboardState mKeyboardStateOld;
		protected KeyboardState mKeyboardState;

		protected EditorForm mEditorForm;

		XmlSerializer mSerializer;

		public Dictionary<String, SpineData.SpineDataSettings> mRessourcen;

		private string mA;
		private string mB;
		private bool mPlaying;
		private bool mPlayingA;
		private double mPlayingTimer;

		#endregion

		#region Constructor

		public EditorScene(string pSceneName)
			:base(pSceneName)
		{
			mClearColor = Color.Blue;
		}

		#endregion

		#region Override Methods

		public override void Initialize()
		{
			EngineSettings.DefaultPathSpine = Environment.CurrentDirectory;
			mEditorForm = new EditorForm();
			mEditorForm.Show();
			mSerializer = new XmlSerializer(typeof(SpineData.SpineDataSettings));
			mRessourcen = new Dictionary<string, SpineData.SpineDataSettings>();
		}

		public override void LoadContent()
		{

		}

		public override void Update()
		{
			if (mSpine != null && mPlaying)
				UpdateAnimation();
			if (mEditorForm.listBoxSkeletons.SelectedItem == null)
			{
				mSpine = null;
			}
		}

		public override void Draw()
		{
			DrawBackground();
			if (mSpine != null)
				mSpine.Draw(mSpriteBatch, Vector2.Zero);
			DrawOnScene();
		}

		#endregion

		#region Methods

		public void HandleInput()
		{
			mKeyboardState = mKeyboardStateOld;
			mKeyboardStateOld = Keyboard.GetState();
			//if (mKeyboardState.IsKeyDown(Microsoft.Xna.Framework.Input.Keys.F1) && mKeyboardStateOld.IsKeyUp(Microsoft.Xna.Framework.Input.Keys.F1))
				
			//if (mKeyboardState.IsKeyDown(Microsoft.Xna.Framework.Input.Keys.F2) && mKeyboardStateOld.IsKeyUp(Microsoft.Xna.Framework.Input.Keys.F2))
				
			//if (mKeyboardState.IsKeyDown(Microsoft.Xna.Framework.Input.Keys.F3) && mKeyboardStateOld.IsKeyUp(Microsoft.Xna.Framework.Input.Keys.F3))
				
			//if (mKeyboardState.IsKeyDown(Microsoft.Xna.Framework.Input.Keys.F4) && mKeyboardStateOld.IsKeyUp(Microsoft.Xna.Framework.Input.Keys.F4))
				

			//if (mKeyboardState.IsKeyDown(Microsoft.Xna.Framework.Input.Keys.F5) && mKeyboardStateOld.IsKeyUp(Microsoft.Xna.Framework.Input.Keys.F5))
				
			//if (mKeyboardState.IsKeyDown(Microsoft.Xna.Framework.Input.Keys.F6) && mKeyboardStateOld.IsKeyUp(Microsoft.Xna.Framework.Input.Keys.F6))
				
			//if (mKeyboardState.IsKeyDown(Microsoft.Xna.Framework.Input.Keys.F7) && mKeyboardStateOld.IsKeyUp(Microsoft.Xna.Framework.Input.Keys.F7))
				
		}

		public void StartAnimation(string pA, string pB)
		{
			mA = pA;
			mB = pB;
			mSpine.AnimationState.SetAnimation(0, mA, true);
			mPlayingA = true;
			mPlayingTimer = EngineSettings.Time.TotalGameTime.Milliseconds;
			mPlaying = true;
			
		}

		public void UpdateAnimation()
		{
			if (EngineSettings.Time.TotalGameTime.Milliseconds > mPlayingTimer + mSpine.AnimationState.GetCurrent(0).Animation.Duration * 2000)
			{
				if (mPlayingA)
				{
					mSpine.AnimationState.SetAnimation(0, mB, true);
					mPlayingA = !mPlayingA;
				}
				else
				{
					mPlaying = false;
				}
			}
			mSpine.Update();
			int TmpProgress = (int)(100 * ((EngineSettings.Time.TotalGameTime.Milliseconds - mPlayingTimer) / (double)(mSpine.AnimationState.GetCurrent(0).Animation.Duration * 2000)));
			if (TmpProgress > 0)
				mEditorForm.progressBarAnimation.Value = TmpProgress;
		}

		public void LoadNewSpineObject(string pSkeletonName)
		{
			mPlaying = false;
			mEditorForm.listBoxFadingFrom.Items.Clear();
			mEditorForm.listBoxFadingTo.Items.Clear();
			mEditorForm.listBoxFadingFrom.ClearSelected();
			mEditorForm.listBoxFadingTo.ClearSelected();
			SpineDataManager.Instance.Unload();
			SpineDataManager.Instance.LoadContent();
			mSpine = new SpineObject(pSkeletonName);
			mSpine.Load();
			if (!mEditorForm.checkBoxLockView.Checked)
			{
				mEditorForm.numericUpDownPositionX.Value = 0;
				mEditorForm.numericUpDownPositionY.Value = 0;
				mEditorForm.numericUpDownZoom.Value = 1;
			}
			ChangeSpinePosition();
			List<string> TmpFadingListOutputFrom = new List<string>();
			List<string> TmpFadingListOutputTo = new List<string>();
			foreach (SpineData.AnimationMix animMix in SpineDataManager.Instance.GetElementByString(pSkeletonName).settings.AnimationFading)
			{
				TmpFadingListOutputFrom.Add( animMix.From.ToString());
				TmpFadingListOutputTo.Add(animMix.To.ToString());
			}
			mEditorForm.listBoxFadingFrom.Items.AddRange(TmpFadingListOutputFrom.ToArray());
			mEditorForm.listBoxFadingTo.Items.AddRange(TmpFadingListOutputTo.ToArray());
			mSpine.AnimationState.SetAnimation(0, TmpFadingListOutputFrom[0], true);
		}

		public void ChangeSpinePosition()
		{
			mSpine.PositionX = EngineSettings.VirtualResWidth / 2 + (int)mEditorForm.numericUpDownPositionX.Value;
			mSpine.PositionY = EngineSettings.VirtualResHeight / 2 + 200 - (int)mEditorForm.numericUpDownPositionY.Value;
		}

		public void ReloadFolder()
		{
			mPlaying = false;
			mEditorForm.listBoxFadingFrom.Items.Clear();
			mEditorForm.listBoxFadingTo.Items.Clear();
			mEditorForm.listBoxFadingFrom.ClearSelected();
			mEditorForm.listBoxFadingTo.ClearSelected();
			mRessourcen.Clear();
			mEditorForm.listBoxSkeletons.Items.Clear();
			StreamReader reader;
			StreamWriter file;
			DirectoryInfo pathInfo = new DirectoryInfo(EngineSettings.DefaultPathSpine);
			foreach (FileInfo f in pathInfo.GetFiles()) //Enthaltene Files durchgehen
			{
				if (f.Name.EndsWith(".json")) //.sData Files heraus filtern
				{
					string TmpSkeletonName = f.Name.Remove(f.Name.Length - ".json".Length);
					if (!File.Exists(EngineSettings.DefaultPathSpine + "\\" + TmpSkeletonName + ".settings"))
					{
						SpineData.SpineDataSettings DefaultSettings = new SpineData.SpineDataSettings();
						DefaultSettings.Scaling = 1.0f;
						DefaultSettings.AnimationFading = GetAnimationMixes(TmpSkeletonName, 0.2f);
						file = new StreamWriter(EngineSettings.DefaultPathSpine + "\\" + TmpSkeletonName + ".settings");
						mSerializer.Serialize(file, DefaultSettings);
						file.Close();
					}
					reader = new StreamReader(EngineSettings.DefaultPathSpine + "\\" + TmpSkeletonName + ".settings");
					SpineData.SpineDataSettings settings = (SpineData.SpineDataSettings)mSerializer.Deserialize(reader); //sData File in SpineData Object umwandeln
					reader.Close();
					mRessourcen.Add(TmpSkeletonName, settings);
				}
			}
			mEditorForm.listBoxSkeletons.Items.AddRange(mRessourcen.Keys.ToArray());
		}

		public void SaveData()
		{
			StreamWriter file = new StreamWriter(EngineSettings.DefaultPathSpine + mEditorForm.listBoxSkeletons.SelectedItem.ToString() + ".settings");
			mSerializer.Serialize(file, SpineDataManager.Instance.GetElementByString(mSpine.Name));
			file.Close();
		}

		public List<SpineData.AnimationMix> GetAnimationMixes(string pSkeletonName, float pDefaultFading)
		{
			List<SpineData.AnimationMix> TmpAnimationMixes = new List<SpineData.AnimationMix>();
			List<Animation> TmpAnimationList = new SkeletonJson(new Atlas(EngineSettings.DefaultPathSpine + "\\" + pSkeletonName + ".atlas", new XnaTextureLoader(EngineSettings.Graphics.GraphicsDevice))).ReadSkeletonData(EngineSettings.DefaultPathSpine + "\\" + pSkeletonName + ".json").Animations;
			foreach (Animation a in TmpAnimationList)
			{
				foreach (Animation b in TmpAnimationList)
				{
					if (b.Name != a.Name)
						TmpAnimationMixes.Add(new SpineData.AnimationMix(a.Name, b.Name, pDefaultFading));
				}
			}
			return TmpAnimationMixes;
		}

		#endregion

	}
}
