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
			this.checkBoxLockView = new System.Windows.Forms.CheckBox();
			this.labelPositionY = new System.Windows.Forms.Label();
			this.labelPositionX = new System.Windows.Forms.Label();
			this.numericUpDownPositionY = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownPositionX = new System.Windows.Forms.NumericUpDown();
			this.listBoxFadingFrom = new System.Windows.Forms.ListBox();
			this.listBoxFadingTo = new System.Windows.Forms.ListBox();
			this.labelFadingFrom = new System.Windows.Forms.Label();
			this.labelFadingTo = new System.Windows.Forms.Label();
			this.groupBoxFading = new System.Windows.Forms.GroupBox();
			this.groupBoxSkeleton = new System.Windows.Forms.GroupBox();
			this.progressBarAnimation = new System.Windows.Forms.ProgressBar();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownZoom)).BeginInit();
			this.groupBoxView.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownPositionY)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownPositionX)).BeginInit();
			this.groupBoxFading.SuspendLayout();
			this.groupBoxSkeleton.SuspendLayout();
			this.SuspendLayout();
			// 
			// listBoxSkeletons
			// 
			this.listBoxSkeletons.FormattingEnabled = true;
			this.listBoxSkeletons.Location = new System.Drawing.Point(6, 19);
			this.listBoxSkeletons.Name = "listBoxSkeletons";
			this.listBoxSkeletons.Size = new System.Drawing.Size(156, 303);
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
			this.buttonBrowse.Location = new System.Drawing.Point(54, 328);
			this.buttonBrowse.Name = "buttonBrowse";
			this.buttonBrowse.Size = new System.Drawing.Size(60, 23);
			this.buttonBrowse.TabIndex = 3;
			this.buttonBrowse.Text = "Browse";
			this.buttonBrowse.UseVisualStyleBackColor = true;
			this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
			// 
			// groupBoxView
			// 
			this.groupBoxView.Controls.Add(this.checkBoxLockView);
			this.groupBoxView.Controls.Add(this.labelPositionY);
			this.groupBoxView.Controls.Add(this.labelPositionX);
			this.groupBoxView.Controls.Add(this.numericUpDownPositionY);
			this.groupBoxView.Controls.Add(this.numericUpDownPositionX);
			this.groupBoxView.Controls.Add(this.labelZoom);
			this.groupBoxView.Controls.Add(this.numericUpDownZoom);
			this.groupBoxView.Location = new System.Drawing.Point(12, 379);
			this.groupBoxView.Name = "groupBoxView";
			this.groupBoxView.Size = new System.Drawing.Size(156, 122);
			this.groupBoxView.TabIndex = 4;
			this.groupBoxView.TabStop = false;
			this.groupBoxView.Text = "View";
			// 
			// checkBoxLockView
			// 
			this.checkBoxLockView.AutoSize = true;
			this.checkBoxLockView.Checked = true;
			this.checkBoxLockView.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxLockView.Location = new System.Drawing.Point(38, 99);
			this.checkBoxLockView.Name = "checkBoxLockView";
			this.checkBoxLockView.Size = new System.Drawing.Size(76, 17);
			this.checkBoxLockView.TabIndex = 7;
			this.checkBoxLockView.Text = "Lock View";
			this.checkBoxLockView.UseVisualStyleBackColor = true;
			// 
			// labelPositionY
			// 
			this.labelPositionY.AutoSize = true;
			this.labelPositionY.Location = new System.Drawing.Point(80, 75);
			this.labelPositionY.Name = "labelPositionY";
			this.labelPositionY.Size = new System.Drawing.Size(51, 13);
			this.labelPositionY.TabIndex = 6;
			this.labelPositionY.Text = "PositionY";
			// 
			// labelPositionX
			// 
			this.labelPositionX.AutoSize = true;
			this.labelPositionX.Location = new System.Drawing.Point(80, 48);
			this.labelPositionX.Name = "labelPositionX";
			this.labelPositionX.Size = new System.Drawing.Size(51, 13);
			this.labelPositionX.TabIndex = 5;
			this.labelPositionX.Text = "PositionX";
			// 
			// numericUpDownPositionY
			// 
			this.numericUpDownPositionY.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.numericUpDownPositionY.Location = new System.Drawing.Point(7, 73);
			this.numericUpDownPositionY.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
			this.numericUpDownPositionY.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            -2147483648});
			this.numericUpDownPositionY.Name = "numericUpDownPositionY";
			this.numericUpDownPositionY.Size = new System.Drawing.Size(67, 20);
			this.numericUpDownPositionY.TabIndex = 4;
			this.numericUpDownPositionY.ValueChanged += new System.EventHandler(this.numericUpDownPositionY_ValueChanged);
			// 
			// numericUpDownPositionX
			// 
			this.numericUpDownPositionX.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.numericUpDownPositionX.Location = new System.Drawing.Point(7, 46);
			this.numericUpDownPositionX.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
			this.numericUpDownPositionX.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            -2147483648});
			this.numericUpDownPositionX.Name = "numericUpDownPositionX";
			this.numericUpDownPositionX.Size = new System.Drawing.Size(67, 20);
			this.numericUpDownPositionX.TabIndex = 3;
			this.numericUpDownPositionX.ValueChanged += new System.EventHandler(this.numericUpDownPositionX_ValueChanged);
			// 
			// listBoxFadingFrom
			// 
			this.listBoxFadingFrom.FormattingEnabled = true;
			this.listBoxFadingFrom.Location = new System.Drawing.Point(7, 20);
			this.listBoxFadingFrom.Name = "listBoxFadingFrom";
			this.listBoxFadingFrom.Size = new System.Drawing.Size(121, 446);
			this.listBoxFadingFrom.TabIndex = 5;
			this.listBoxFadingFrom.SelectedIndexChanged += new System.EventHandler(this.listBoxFadingFrom_SelectedIndexChanged);
			// 
			// listBoxFadingTo
			// 
			this.listBoxFadingTo.FormattingEnabled = true;
			this.listBoxFadingTo.Location = new System.Drawing.Point(134, 19);
			this.listBoxFadingTo.Name = "listBoxFadingTo";
			this.listBoxFadingTo.Size = new System.Drawing.Size(120, 446);
			this.listBoxFadingTo.TabIndex = 8;
			this.listBoxFadingTo.SelectedIndexChanged += new System.EventHandler(this.listBoxFadingTo_SelectedIndexChanged);
			// 
			// labelFadingFrom
			// 
			this.labelFadingFrom.AutoSize = true;
			this.labelFadingFrom.Location = new System.Drawing.Point(52, 470);
			this.labelFadingFrom.Name = "labelFadingFrom";
			this.labelFadingFrom.Size = new System.Drawing.Size(30, 13);
			this.labelFadingFrom.TabIndex = 9;
			this.labelFadingFrom.Text = "From";
			// 
			// labelFadingTo
			// 
			this.labelFadingTo.AutoSize = true;
			this.labelFadingTo.Location = new System.Drawing.Point(181, 470);
			this.labelFadingTo.Name = "labelFadingTo";
			this.labelFadingTo.Size = new System.Drawing.Size(20, 13);
			this.labelFadingTo.TabIndex = 10;
			this.labelFadingTo.Text = "To";
			// 
			// groupBoxFading
			// 
			this.groupBoxFading.Controls.Add(this.listBoxFadingFrom);
			this.groupBoxFading.Controls.Add(this.labelFadingTo);
			this.groupBoxFading.Controls.Add(this.listBoxFadingTo);
			this.groupBoxFading.Controls.Add(this.labelFadingFrom);
			this.groupBoxFading.Location = new System.Drawing.Point(180, 12);
			this.groupBoxFading.Name = "groupBoxFading";
			this.groupBoxFading.Size = new System.Drawing.Size(349, 489);
			this.groupBoxFading.TabIndex = 11;
			this.groupBoxFading.TabStop = false;
			this.groupBoxFading.Text = "Fading";
			// 
			// groupBoxSkeleton
			// 
			this.groupBoxSkeleton.Controls.Add(this.listBoxSkeletons);
			this.groupBoxSkeleton.Controls.Add(this.buttonBrowse);
			this.groupBoxSkeleton.Location = new System.Drawing.Point(4, 12);
			this.groupBoxSkeleton.Name = "groupBoxSkeleton";
			this.groupBoxSkeleton.Size = new System.Drawing.Size(170, 362);
			this.groupBoxSkeleton.TabIndex = 12;
			this.groupBoxSkeleton.TabStop = false;
			this.groupBoxSkeleton.Text = "Skeleton";
			// 
			// progressBarAnimation
			// 
			this.progressBarAnimation.Location = new System.Drawing.Point(10, 507);
			this.progressBarAnimation.Name = "progressBarAnimation";
			this.progressBarAnimation.Size = new System.Drawing.Size(519, 23);
			this.progressBarAnimation.TabIndex = 13;
			this.progressBarAnimation.Click += new System.EventHandler(this.progressBarAnimation_Click);
			// 
			// EditorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.YellowGreen;
			this.ClientSize = new System.Drawing.Size(533, 535);
			this.Controls.Add(this.progressBarAnimation);
			this.Controls.Add(this.groupBoxSkeleton);
			this.Controls.Add(this.groupBoxFading);
			this.Controls.Add(this.groupBoxView);
			this.Name = "EditorForm";
			this.Text = "EditorForm";
			this.Load += new System.EventHandler(this.EditorForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownZoom)).EndInit();
			this.groupBoxView.ResumeLayout(false);
			this.groupBoxView.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownPositionY)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownPositionX)).EndInit();
			this.groupBoxFading.ResumeLayout(false);
			this.groupBoxFading.PerformLayout();
			this.groupBoxSkeleton.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label labelZoom;
		private System.Windows.Forms.Button buttonBrowse;
		public System.Windows.Forms.FolderBrowserDialog folderBrowser;
		private System.Windows.Forms.GroupBox groupBoxView;
		public System.Windows.Forms.ListBox listBoxSkeletons;
		private System.Windows.Forms.Label labelPositionY;
		private System.Windows.Forms.Label labelPositionX;
		public System.Windows.Forms.NumericUpDown numericUpDownPositionY;
		public System.Windows.Forms.NumericUpDown numericUpDownPositionX;
		public System.Windows.Forms.CheckBox checkBoxLockView;
		public System.Windows.Forms.NumericUpDown numericUpDownZoom;
		public System.Windows.Forms.ListBox listBoxFadingFrom;
		public System.Windows.Forms.ListBox listBoxFadingTo;
		private System.Windows.Forms.Label labelFadingFrom;
		private System.Windows.Forms.Label labelFadingTo;
		private System.Windows.Forms.GroupBox groupBoxFading;
		private System.Windows.Forms.GroupBox groupBoxSkeleton;
		public System.Windows.Forms.ProgressBar progressBarAnimation;
	}
}