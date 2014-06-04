using KryptonEngine;
using KryptonEngine.SceneManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SpineEditor
{
	public partial class SpineEditor : Form
	{
		EditorScene mScene;

		public SpineEditor()
		{
			InitializeComponent();
			mScene = (EditorScene)SceneManager.CurrentScene;
		}

		private void EditorForm_Load(object sender, EventArgs e)
		{

		}

		private void listBoxSkeletons_SelectedIndexChanged(object sender, EventArgs e)
		{
			mScene.LoadNewSpineObject(listBoxSkeletons.SelectedItem.ToString());
		}

		private void labelZoom_Click(object sender, EventArgs e)
		{
			
		}

		private void buttonBrowse_Click(object sender, EventArgs e)
		{
			Browse();
		}

		public void Browse()
		{
			folderBrowser.ShowDialog();
			EngineSettings.DefaultPathSpine = folderBrowser.SelectedPath;
			if (EngineSettings.DefaultPathSpine != "")
				mScene.ReloadFolder();
		}

		private void folderBrowser_HelpRequest(object sender, EventArgs e)
		{
			
		}

		private void numericUpDownPositionX_ValueChanged(object sender, EventArgs e)
		{
			mScene.ChangeSpinePosition();
		}

		private void numericUpDownPositionY_ValueChanged(object sender, EventArgs e)
		{
			mScene.ChangeSpinePosition();
		}

		private void listBoxFadingFrom_SelectedIndexChanged(object sender, EventArgs e)
		{
			mScene.mPlaying = false;
			mScene.UpdateAnimationList();
		}

		private void listBoxFadingTo_SelectedIndexChanged(object sender, EventArgs e)
		{
			mScene.RefreshFading();
			mScene.StartAnimation(listBoxFadingFrom.SelectedItem.ToString());
		}

		private void numericUpDownSpeed_ValueChanged(object sender, EventArgs e)
		{
			mScene.ChangeSpeed();
		}

		private void numericUpDownZoom_ValueChanged(object sender, EventArgs e)
		{
			
		}

		private void buttonLoop_Click(object sender, EventArgs e)
		{
			mScene.StartAnimation(listBoxFadingFrom.SelectedItem.ToString());
		}

		private void buttonFade_Click(object sender, EventArgs e)
		{
			mScene.StartFading(listBoxFadingTo.SelectedItem.ToString());
		}

		private void buttonScaling_Click(object sender, EventArgs e)
		{
			mScene.ApplyScaling((float)numericUpDownScaling.Value);
		}

		private void buttonResetView_Click(object sender, EventArgs e)
		{
			mScene.ResetView();
		}

		private void buttonFading_Click(object sender, EventArgs e)
		{
			mScene.ApplyFading();
		}
	}
}
