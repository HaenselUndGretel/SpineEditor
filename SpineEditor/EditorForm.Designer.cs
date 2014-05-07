namespace SpineEditor
{
	partial class EditorForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.listBoxSkeletons = new System.Windows.Forms.ListBox();
			this.numericUpDownZoom = new System.Windows.Forms.NumericUpDown();
			this.labelZoom = new System.Windows.Forms.Label();
			this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
			this.buttonBrowse = new System.Windows.Forms.Button();
			this.groupBoxView = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownZoom)).BeginInit();
			this.groupBoxView.SuspendLayout();
			this.SuspendLayout();
			// 
			// listBoxSkeletons
			// 
			this.listBoxSkeletons.FormattingEnabled = true;
			this.listBoxSkeletons.Location = new System.Drawing.Point(12, 41);
			this.listBoxSkeletons.Name = "listBoxSkeletons";
			this.listBoxSkeletons.Size = new System.Drawing.Size(156, 212);
			this.listBoxSkeletons.TabIndex = 0;
			this.listBoxSkeletons.SelectedIndexChanged += new System.EventHandler(this.listBoxSkeletons_SelectedIndexChanged);
			// 
			// numericUpDownZoom
			// 
			this.numericUpDownZoom.DecimalPlaces = 1;
			this.numericUpDownZoom.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.numericUpDownZoom.Location = new System.Drawing.Point(6, 19);
			this.numericUpDownZoom.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            65536});
			this.numericUpDownZoom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.numericUpDownZoom.Name = "numericUpDownZoom";
			this.numericUpDownZoom.Size = new System.Drawing.Size(68, 20);
			this.numericUpDownZoom.TabIndex = 1;
			this.numericUpDownZoom.Value = new decimal(new int[] {
            10,
            0,
            0,
            65536});
			// 
			// labelZoom
			// 
			this.labelZoom.AutoSize = true;
			this.labelZoom.Location = new System.Drawing.Point(80, 21);
			this.labelZoom.Name = "labelZoom";
			this.labelZoom.Size = new System.Drawing.Size(34, 13);
			this.labelZoom.TabIndex = 2;
			this.labelZoom.Tag = "";
			this.labelZoom.Text = "Zoom";
			this.labelZoom.Click += new System.EventHandler(this.labelZoom_Click);
			// 
			// folderBrowser
			// 
			this.folderBrowser.Description = "Folder with Spine Data.";
			this.folderBrowser.ShowNewFolderButton = false;
			this.folderBrowser.HelpRequest += new System.EventHandler(this.folderBrowser_HelpRequest);
			// 
			// buttonBrowse
			// 
			this.buttonBrowse.Location = new System.Drawing.Point(12, 12);
			this.buttonBrowse.Name = "buttonBrowse";
			this.buttonBrowse.Size = new System.Drawing.Size(60, 23);
			this.buttonBrowse.TabIndex = 3;
			this.buttonBrowse.Text = "Browse";
			this.buttonBrowse.UseVisualStyleBackColor = true;
			this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
			// 
			// groupBoxView
			// 
			this.groupBoxView.Controls.Add(this.labelZoom);
			this.groupBoxView.Controls.Add(this.numericUpDownZoom);
			this.groupBoxView.Location = new System.Drawing.Point(754, 466);
			this.groupBoxView.Name = "groupBoxView";
			this.groupBoxView.Size = new System.Drawing.Size(121, 100);
			this.groupBoxView.TabIndex = 4;
			this.groupBoxView.TabStop = false;
			this.groupBoxView.Text = "View";
			// 
			// EditorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(887, 578);
			this.Controls.Add(this.groupBoxView);
			this.Controls.Add(this.buttonBrowse);
			this.Controls.Add(this.listBoxSkeletons);
			this.Name = "EditorForm";
			this.Text = "EditorForm";
			this.Load += new System.EventHandler(this.EditorForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownZoom)).EndInit();
			this.groupBoxView.ResumeLayout(false);
			this.groupBoxView.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label labelZoom;
		private System.Windows.Forms.Button buttonBrowse;
		public System.Windows.Forms.FolderBrowserDialog folderBrowser;
		private System.Windows.Forms.GroupBox groupBoxView;
		public System.Windows.Forms.ListBox listBoxSkeletons;
		private System.Windows.Forms.NumericUpDown numericUpDownZoom;
	}
}