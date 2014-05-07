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

namespace SpineEditor
{
	class EditorScene : Scene
	{
		#region Properties

		public SpineObject mSpine;
		public string mDataPath = Environment.CurrentDirectory;

		public float mZoom;

		protected KeyboardState mKeyboardStateOld;
		protected KeyboardState mKeyboardState;

		protected EditorForm mEditorForm;

		XmlSerializer mSerializer;

		public Dictionary<String, SpineData.SpineDataSettings> mRessourcen;

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
			if (mSpine != null)
				mSpine.Update();
		}

		public override void Draw()
		{
			DrawBackground();
			if (mSpine != null)
				mSpine.Draw(mSpriteBatch);
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

		public void ReloadFolder()
		{
			mRessourcen.Clear();
			mEditorForm.listBoxSkeletons.Items.Clear();
			StreamReader reader;
			StreamWriter file;
			DirectoryInfo pathInfo = new DirectoryInfo(mDataPath);
			foreach (FileInfo f in pathInfo.GetFiles()) //Enthaltene Files durchgehen
			{
				if (f.Name.EndsWith(".json")) //.sData Files heraus filtern
				{
					string TmpSkeletonName = f.Name.Remove(f.Name.Length - ".json".Length);
					if (!File.Exists(mDataPath + "\\" + TmpSkeletonName + ".settings"))
					{
						SpineData.SpineDataSettings DefaultSettings = new SpineData.SpineDataSettings();
						DefaultSettings.Scaling = 1.0f;
						file = new StreamWriter(mDataPath + "\\" + TmpSkeletonName + ".settings");
						mSerializer.Serialize(file, DefaultSettings);
						file.Close();
					}
					reader = new StreamReader(mDataPath + "\\" + TmpSkeletonName + ".settings");
					SpineData.SpineDataSettings settings = (SpineData.SpineDataSettings)mSerializer.Deserialize(reader); //sData File in SpineData Object umwandeln
					reader.Close();
					mRessourcen.Add(TmpSkeletonName, settings);
				}
			}
			mEditorForm.listBoxSkeletons.Items.AddRange(mRessourcen.Keys.ToArray());
		}

		public void SaveData()
		{
			StreamWriter file = new StreamWriter(mDataPath + mEditorForm.listBoxSkeletons.SelectedItem.ToString() + ".settings");
			mSerializer.Serialize(file, SpineDataManager.Instance.GetElementByString(mSpine.Name));
			file.Close();
		}

		#endregion

	}
}
