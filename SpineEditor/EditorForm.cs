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

		}

		private void labelZoom_Click(object sender, EventArgs e)
		{
			mScene.mSpine.ChangeDrawScaling((float)numericUpDownZoom.Value);
		}

		private void buttonBrowse_Click(object sender, EventArgs e)
		{
			folderBrowser.ShowDialog();
			mScene.mDataPath = folderBrowser.SelectedPath;
			mScene.ReloadFolder();
		}

		private void folderBrowser_HelpRequest(object sender, EventArgs e)
		{

		}
	}
}
