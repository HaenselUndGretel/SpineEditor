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
using KryptonEngine.Controls;

namespace SpineEditor
{
	class EditorScene : Scene
	{
		#region Properties

		public SpineObject mSpine;
		Vector2 mPosition;

		protected KeyboardState mKeyboardStateOld;
		protected KeyboardState mKeyboardState;

		protected SpineEditor mEditorForm;

		XmlSerializer mSerializer;

		public Dictionary<String, SpineData.SpineDataSettings> mRessourcen;

		public bool mPlaying;

		#endregion

		#region Constructor

		public EditorScene(string pSceneName)
			:base(pSceneName)
		{
			mClearColor = Color.DimGray;
		}

		#endregion

		#region Override Methods

		public override void Initialize()
		{
			EngineSettings.DefaultPathSpine = Environment.CurrentDirectory;
			mEditorForm = new SpineEditor();
			mEditorForm.Show();
			mSerializer = new XmlSerializer(typeof(SpineData.SpineDataSettings));
			mRessourcen = new Dictionary<string, SpineData.SpineDataSettings>();
		}

		public override void LoadContent()
		{

		}

		public override void Update()
		{
			HandleInput();
			if (mSpine != null && mPlaying)
			{
				mSpine.Update();	
			}

			if (mEditorForm.listBoxSkeletons.SelectedItem == null)
			{
				mSpine = null;
			}
		}

		public override void Draw()
		{
			DrawBackground();
			if (mSpine != null)
			{
				EngineSettings.SpineRenderer.Effect.View = Matrix.CreateScale((float)mEditorForm.numericUpDownZoom.Value) * Matrix.CreateTranslation(mPosition.X, mPosition.Y, 0f);
				mSpine.Draw(mSpriteBatch, Vector2.Zero);
			}
			DrawOnScene();
		}

		#endregion

		#region Methods

		#region Input

		/// <summary>
		/// Reagiert auf Tastatureingaben.
		/// </summary>
		public void HandleInput()
		{
			mKeyboardState = mKeyboardStateOld;
			mKeyboardStateOld = Keyboard.GetState();
			//if (mKeyboardState.IsKeyDown(Microsoft.Xna.Framework.Input.Keys.F1) && mKeyboardStateOld.IsKeyUp(Microsoft.Xna.Framework.Input.Keys.F1))
				
			//if (mKeyboardState.IsKeyDown(Microsoft.Xna.Framework.Input.Keys.F2) && mKeyboardStateOld.IsKeyUp(Microsoft.Xna.Framework.Input.Keys.F2))

			if (mKeyboardState.IsKeyDown(Microsoft.Xna.Framework.Input.Keys.F3) && mKeyboardStateOld.IsKeyUp(Microsoft.Xna.Framework.Input.Keys.F3))
				mEditorForm.Browse();
			if (mSpine != null)
			{
				if (mKeyboardState.IsKeyDown(Microsoft.Xna.Framework.Input.Keys.F4) && mKeyboardStateOld.IsKeyUp(Microsoft.Xna.Framework.Input.Keys.F4))
					ApplyScaling((float)mEditorForm.numericUpDownScaling.Value);

				if (mKeyboardState.IsKeyDown(Microsoft.Xna.Framework.Input.Keys.F5) && mKeyboardStateOld.IsKeyUp(Microsoft.Xna.Framework.Input.Keys.F5))
					StartAnimation(mEditorForm.listBoxFadingFrom.SelectedItem.ToString());

				if (mKeyboardState.IsKeyDown(Microsoft.Xna.Framework.Input.Keys.F6) && mKeyboardStateOld.IsKeyUp(Microsoft.Xna.Framework.Input.Keys.F6))
					StartFading(mEditorForm.listBoxFadingTo.SelectedItem.ToString());

				if (mKeyboardState.IsKeyDown(Microsoft.Xna.Framework.Input.Keys.F7) && mKeyboardStateOld.IsKeyUp(Microsoft.Xna.Framework.Input.Keys.F7))
					mEditorForm.numericUpDownFading.Value -= mEditorForm.numericUpDownFading.Increment;

				if (mKeyboardState.IsKeyDown(Microsoft.Xna.Framework.Input.Keys.F8) && mKeyboardStateOld.IsKeyUp(Microsoft.Xna.Framework.Input.Keys.F8))
					mEditorForm.numericUpDownFading.Value += mEditorForm.numericUpDownFading.Increment;

				if (mKeyboardState.IsKeyDown(Microsoft.Xna.Framework.Input.Keys.F9) && mKeyboardStateOld.IsKeyUp(Microsoft.Xna.Framework.Input.Keys.F9))
					ApplyFading();
			}
		}

		#endregion

		public bool CompleteSelection(int pLevel)
		{
			if (pLevel > 0 && mEditorForm.listBoxSkeletons.SelectedItem == null)
				return false;
			if (pLevel > 1 && mEditorForm.listBoxFadingFrom.SelectedItem == null)
				return false;
			if (pLevel > 2 && mEditorForm.listBoxFadingTo.SelectedItem == null)
				return false;
			return true;
		}

		#region Control Fading

		public void ApplyFading()
		{
			if (!CompleteSelection(3))
				return;
			string TmpSkeletonName = mEditorForm.listBoxSkeletons.SelectedItem.ToString();
			string From = mEditorForm.listBoxFadingFrom.SelectedItem.ToString();
			string To = mEditorForm.listBoxFadingTo.SelectedItem.ToString();
			float Fading = (float)mEditorForm.numericUpDownFading.Value;
			foreach (SpineData.AnimationMix animMix in SpineDataManager.Instance.GetElementByString(TmpSkeletonName).settings.AnimationFading)
			{
				if (animMix.From == From && animMix.To == To)
				{
					animMix.Fading = Fading;
					break;
				}
			}
			int TmpFromFocus = mEditorForm.listBoxFadingFrom.SelectedIndex;
			int TmpToFocus = mEditorForm.listBoxFadingTo.SelectedIndex;
			SaveData();
			LoadNewSpineObject(TmpSkeletonName);
			mEditorForm.listBoxFadingFrom.SelectedIndex = TmpFromFocus;
			mEditorForm.listBoxFadingTo.SelectedIndex = TmpToFocus;
		}

		public void RefreshFading()
		{
			foreach (SpineData.AnimationMix animMix in SpineDataManager.Instance.GetElementByString(mEditorForm.listBoxSkeletons.SelectedItem.ToString()).settings.AnimationFading)
			{
				if (animMix.From == mEditorForm.listBoxFadingFrom.SelectedItem.ToString() && animMix.To == mEditorForm.listBoxFadingTo.SelectedItem.ToString())
				{
					mEditorForm.numericUpDownFading.Value = (decimal)animMix.Fading;
					return;
				}
			}
		}


		#endregion

		#region Control Scaling

		public void ApplyScaling(float pScaling)
		{
			if (!CompleteSelection(1))
				return;
			string TmpSkeletonName = mEditorForm.listBoxSkeletons.SelectedItem.ToString();
			SpineDataManager.Instance.GetElementByString(TmpSkeletonName).settings.Scaling = pScaling;
			SaveData();
			int TmpFromFocus = mEditorForm.listBoxFadingFrom.SelectedIndex;
			int TmpToFocus = mEditorForm.listBoxFadingTo.SelectedIndex;
			LoadNewSpineObject(TmpSkeletonName);
			mEditorForm.listBoxFadingFrom.SelectedIndex = TmpFromFocus;
			mEditorForm.listBoxFadingTo.SelectedIndex = TmpToFocus;
		}

		#endregion

		#region Control Animation

		/// <summary>
		/// Startet den From-AnimationsLoop.
		/// </summary>
		public void StartAnimation(string pAnimation)
		{
			if (!CompleteSelection(2))
				return;
			if (mSpine != null)
			{
				mSpine.AnimationState.ClearTracks();
				mSpine.Skeleton.SetSlotsToSetupPose();
				mSpine.AnimationState.SetAnimation(0, pAnimation, true);
				mPlaying = true;
			}
		}

		/// <summary>
		/// Startet das Fading zur entsprechenden To-Animation.
		/// </summary>
		public void StartFading(string pAnimation)
		{
			if (!CompleteSelection(3))
				return;
			if (mSpine != null)
				mSpine.AnimationState.SetAnimation(0, pAnimation, false);
		}

		#endregion

		#region Control View

		/// <summary>
		/// Setzt das SpineObject neu relativ zur Standardposition.
		/// </summary>
		public void ChangeSpinePosition()
		{
			if (mSpine != null)
			{
				mPosition.X = EngineSettings.VirtualResWidth / 2 + (int)mEditorForm.numericUpDownPositionX.Value;
				mPosition.Y = EngineSettings.VirtualResHeight / 2 + 200 - (int)mEditorForm.numericUpDownPositionY.Value;
			}
		}

		/// <summary>
		/// Ändert die TimeScale des SpineObjects.
		/// </summary>
		public void ChangeSpeed()
		{
			if (mSpine != null)
				mSpine.AnimationState.TimeScale = (float)mEditorForm.numericUpDownSpeed.Value;
		}

		#endregion

		#region React To From-/To-ListBoxes

		/// <summary>
		/// Lädt die To-AnimationList
		/// </summary>
		public void UpdateAnimationList()
		{
			List<string> TmpFadingListOutputTo = new List<string>();
			foreach (SpineData.AnimationMix animMix in SpineDataManager.Instance.GetElementByString(mEditorForm.listBoxSkeletons.SelectedItem.ToString()).settings.AnimationFading)
			{
				if (mEditorForm.listBoxFadingFrom.SelectedItem.ToString() == animMix.From.ToString())
					TmpFadingListOutputTo.Add(animMix.To.ToString());
			}
			mEditorForm.listBoxFadingTo.Items.Clear();
			mEditorForm.listBoxFadingTo.Items.AddRange(TmpFadingListOutputTo.ToArray());
		}

		#endregion

		#region React To Skeleton-ListBox / (Re)LoadSpineObject / ResetView

		/// <summary>
		/// Läd das SpineObject neu.
		/// </summary>
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
			List<string> TmpFadingListOutputFrom = new List<string>();
			foreach (SpineData.AnimationMix animMix in SpineDataManager.Instance.GetElementByString(pSkeletonName).settings.AnimationFading)
			{
				if (!TmpFadingListOutputFrom.Contains(animMix.From.ToString()))
					TmpFadingListOutputFrom.Add(animMix.From.ToString());
			}
			mEditorForm.listBoxFadingFrom.Items.AddRange(TmpFadingListOutputFrom.ToArray());
			mEditorForm.numericUpDownScaling.Value = (decimal)SpineDataManager.Instance.GetElementByString(pSkeletonName).settings.Scaling;
			if (!mEditorForm.checkBoxLockView.Checked)
			{
				ResetView();
			}
			ApplyView();
		}

		public void ResetView()
		{
			mEditorForm.numericUpDownPositionX.Value = 0;
			mEditorForm.numericUpDownPositionY.Value = 0;
			mEditorForm.numericUpDownZoom.Value = 1;
			mEditorForm.numericUpDownSpeed.Value = 1;
			ApplyView();
		}

		public void ApplyView()
		{
			if (mSpine != null)
			{
				ChangeSpinePosition();
				ChangeSpeed();
			}
		}

		#endregion

		#region React To Browse

		/// <summary>
		/// Läd den Ordner am DataPath neu.
		/// </summary>
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

		#endregion

		#region Load Helper & Save

		/// <summary>
		/// List aus Skeleton Files mit möglichen FadingSettings.
		/// </summary>
		/// <param name="pDefaultFading">Fading mit dem die Settings am Anfang gefüllt werden.</param>
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

		/// <summary>
		/// Speichert die Settings.
		/// </summary>
		public void SaveData()
		{
			if (!CompleteSelection(1))
				return;
			string TmpSkeletonName = mEditorForm.listBoxSkeletons.SelectedItem.ToString();
			StreamWriter file = new StreamWriter(EngineSettings.DefaultPathSpine + "\\" + TmpSkeletonName + ".settings");
			mSerializer.Serialize(file, SpineDataManager.Instance.GetElementByString(TmpSkeletonName).settings);
			file.Close();
		}

		#endregion

		#endregion

	}
}
