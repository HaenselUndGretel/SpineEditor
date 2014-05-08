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
	public partial class EditorForm : Form
	{
		EditorScene mScene;

		public EditorForm()
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
			mScene.mSpine.ChangeDrawScaling((float)numericUpDownZoom.Value);
		}

		private void buttonBrowse_Click(object sender, EventArgs e)
		{
			folderBrowser.ShowDialog();
			EngineSettings.DefaultPathSpine = folderBrowser.SelectedPath;
			if (EngineSettings.DefaultPathSpine != "")
				mScene.ReloadFolder();
		}

		private void folderBrowser_HelpRequest(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
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
			listBoxFadingTo.SelectedIndex = listBoxFadingFrom.SelectedIndex;
			mScene.StartAnimation(listBoxFadingFrom.SelectedItem.ToString(), listBoxFadingTo.SelectedItem.ToString());
		}

		private void listBoxFadingTo_SelectedIndexChanged(object sender, EventArgs e)
		{
			listBoxFadingFrom.SelectedIndex = listBoxFadingTo.SelectedIndex;
			mScene.StartAnimation(listBoxFadingFrom.SelectedItem.ToString(), listBoxFadingTo.SelectedItem.ToString());
		}

		private void progressBarAnimation_Click(object sender, EventArgs e)
		{

		}
	}
}
