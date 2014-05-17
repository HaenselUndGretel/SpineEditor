namespace SpineEditor
{
	partial class SpineEditor
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
			this.buttonResetView = new System.Windows.Forms.Button();
			this.labelSpeed = new System.Windows.Forms.Label();
			this.numericUpDownSpeed = new System.Windows.Forms.NumericUpDown();
			this.checkBoxLockView = new System.Windows.Forms.CheckBox();
			this.labelPositionY = new System.Windows.Forms.Label();
			this.labelPositionX = new System.Windows.Forms.Label();
			this.numericUpDownPositionY = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownPositionX = new System.Windows.Forms.NumericUpDown();
			this.listBoxFadingFrom = new System.Windows.Forms.ListBox();
			this.listBoxFadingTo = new System.Windows.Forms.ListBox();
			this.labelFadingFrom = new System.Windows.Forms.Label();
			this.labelFadingTo = new System.Windows.Forms.Label();
			this.groupBoxAnimationMix = new System.Windows.Forms.GroupBox();
			this.groupBoxFading = new System.Windows.Forms.GroupBox();
			this.numericUpDownFading = new System.Windows.Forms.NumericUpDown();
			this.buttonFading = new System.Windows.Forms.Button();
			this.labelDown = new System.Windows.Forms.Label();
			this.labelUp = new System.Windows.Forms.Label();
			this.groupBoxAnimation = new System.Windows.Forms.GroupBox();
			this.buttonLoop = new System.Windows.Forms.Button();
			this.buttonFade = new System.Windows.Forms.Button();
			this.groupBoxSkeleton = new System.Windows.Forms.GroupBox();
			this.groupBoxScaling = new System.Windows.Forms.GroupBox();
			this.buttonScaling = new System.Windows.Forms.Button();
			this.numericUpDownScaling = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownZoom)).BeginInit();
			this.groupBoxView.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownPositionY)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownPositionX)).BeginInit();
			this.groupBoxAnimationMix.SuspendLayout();
			this.groupBoxFading.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownFading)).BeginInit();
			this.groupBoxAnimation.SuspendLayout();
			this.groupBoxSkeleton.SuspendLayout();
			this.groupBoxScaling.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownScaling)).BeginInit();
			this.SuspendLayout();
			// 
			// listBoxSkeletons
			// 
			this.listBoxSkeletons.BackColor = System.Drawing.Color.WhiteSmoke;
			this.listBoxSkeletons.FormattingEnabled = true;
			this.listBoxSkeletons.ItemHeight = 17;
			this.listBoxSkeletons.Location = new System.Drawing.Point(6, 53);
			this.listBoxSkeletons.Name = "listBoxSkeletons";
			this.listBoxSkeletons.Size = new System.Drawing.Size(156, 395);
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
			this.numericUpDownZoom.Location = new System.Drawing.Point(61, 18);
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
			this.numericUpDownZoom.Size = new System.Drawing.Size(68, 22);
			this.numericUpDownZoom.TabIndex = 1;
			this.numericUpDownZoom.Value = new decimal(new int[] {
            10,
            0,
            0,
            65536});
			this.numericUpDownZoom.ValueChanged += new System.EventHandler(this.numericUpDownZoom_ValueChanged);
			// 
			// labelZoom
			// 
			this.labelZoom.AutoSize = true;
			this.labelZoom.Location = new System.Drawing.Point(11, 22);
			this.labelZoom.Name = "labelZoom";
			this.labelZoom.Size = new System.Drawing.Size(41, 17);
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
			this.buttonBrowse.BackColor = System.Drawing.Color.Gold;
			this.buttonBrowse.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonBrowse.Location = new System.Drawing.Point(66, 19);
			this.buttonBrowse.Name = "buttonBrowse";
			this.buttonBrowse.Size = new System.Drawing.Size(96, 28);
			this.buttonBrowse.TabIndex = 3;
			this.buttonBrowse.Text = "Browse (F3)";
			this.buttonBrowse.UseVisualStyleBackColor = false;
			this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
			// 
			// groupBoxView
			// 
			this.groupBoxView.BackColor = System.Drawing.Color.CornflowerBlue;
			this.groupBoxView.Controls.Add(this.buttonResetView);
			this.groupBoxView.Controls.Add(this.labelSpeed);
			this.groupBoxView.Controls.Add(this.numericUpDownSpeed);
			this.groupBoxView.Controls.Add(this.checkBoxLockView);
			this.groupBoxView.Controls.Add(this.labelPositionY);
			this.groupBoxView.Controls.Add(this.labelPositionX);
			this.groupBoxView.Controls.Add(this.numericUpDownPositionY);
			this.groupBoxView.Controls.Add(this.numericUpDownPositionX);
			this.groupBoxView.Controls.Add(this.labelZoom);
			this.groupBoxView.Controls.Add(this.numericUpDownZoom);
			this.groupBoxView.Location = new System.Drawing.Point(6, 478);
			this.groupBoxView.Name = "groupBoxView";
			this.groupBoxView.Size = new System.Drawing.Size(392, 74);
			this.groupBoxView.TabIndex = 4;
			this.groupBoxView.TabStop = false;
			this.groupBoxView.Text = "View";
			// 
			// buttonResetView
			// 
			this.buttonResetView.BackColor = System.Drawing.Color.Silver;
			this.buttonResetView.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonResetView.Location = new System.Drawing.Point(297, 40);
			this.buttonResetView.Name = "buttonResetView";
			this.buttonResetView.Size = new System.Drawing.Size(89, 28);
			this.buttonResetView.TabIndex = 10;
			this.buttonResetView.Text = "Reset";
			this.buttonResetView.UseVisualStyleBackColor = false;
			this.buttonResetView.Click += new System.EventHandler(this.buttonResetView_Click);
			// 
			// labelSpeed
			// 
			this.labelSpeed.AutoSize = true;
			this.labelSpeed.Location = new System.Drawing.Point(8, 48);
			this.labelSpeed.Name = "labelSpeed";
			this.labelSpeed.Size = new System.Drawing.Size(47, 17);
			this.labelSpeed.TabIndex = 9;
			this.labelSpeed.Text = "Speed";
			// 
			// numericUpDownSpeed
			// 
			this.numericUpDownSpeed.DecimalPlaces = 1;
			this.numericUpDownSpeed.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.numericUpDownSpeed.Location = new System.Drawing.Point(61, 46);
			this.numericUpDownSpeed.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            65536});
			this.numericUpDownSpeed.Name = "numericUpDownSpeed";
			this.numericUpDownSpeed.Size = new System.Drawing.Size(68, 22);
			this.numericUpDownSpeed.TabIndex = 8;
			this.numericUpDownSpeed.Value = new decimal(new int[] {
            10,
            0,
            0,
            65536});
			this.numericUpDownSpeed.ValueChanged += new System.EventHandler(this.numericUpDownSpeed_ValueChanged);
			// 
			// checkBoxLockView
			// 
			this.checkBoxLockView.AutoSize = true;
			this.checkBoxLockView.Checked = true;
			this.checkBoxLockView.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxLockView.Location = new System.Drawing.Point(297, 14);
			this.checkBoxLockView.Name = "checkBoxLockView";
			this.checkBoxLockView.Size = new System.Drawing.Size(88, 21);
			this.checkBoxLockView.TabIndex = 7;
			this.checkBoxLockView.Text = "Lock View";
			this.checkBoxLockView.UseVisualStyleBackColor = true;
			// 
			// labelPositionY
			// 
			this.labelPositionY.AutoSize = true;
			this.labelPositionY.Location = new System.Drawing.Point(140, 49);
			this.labelPositionY.Name = "labelPositionY";
			this.labelPositionY.Size = new System.Drawing.Size(61, 17);
			this.labelPositionY.TabIndex = 6;
			this.labelPositionY.Text = "PositionY";
			// 
			// labelPositionX
			// 
			this.labelPositionX.AutoSize = true;
			this.labelPositionX.Location = new System.Drawing.Point(140, 20);
			this.labelPositionX.Name = "labelPositionX";
			this.labelPositionX.Size = new System.Drawing.Size(61, 17);
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
			this.numericUpDownPositionY.Location = new System.Drawing.Point(205, 46);
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
			this.numericUpDownPositionY.Size = new System.Drawing.Size(67, 22);
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
			this.numericUpDownPositionX.Location = new System.Drawing.Point(205, 17);
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
			this.numericUpDownPositionX.Size = new System.Drawing.Size(67, 22);
			this.numericUpDownPositionX.TabIndex = 3;
			this.numericUpDownPositionX.ValueChanged += new System.EventHandler(this.numericUpDownPositionX_ValueChanged);
			// 
			// listBoxFadingFrom
			// 
			this.listBoxFadingFrom.BackColor = System.Drawing.Color.White;
			this.listBoxFadingFrom.FormattingEnabled = true;
			this.listBoxFadingFrom.ItemHeight = 17;
			this.listBoxFadingFrom.Location = new System.Drawing.Point(7, 20);
			this.listBoxFadingFrom.Name = "listBoxFadingFrom";
			this.listBoxFadingFrom.Size = new System.Drawing.Size(121, 429);
			this.listBoxFadingFrom.TabIndex = 5;
			this.listBoxFadingFrom.SelectedIndexChanged += new System.EventHandler(this.listBoxFadingFrom_SelectedIndexChanged);
			// 
			// listBoxFadingTo
			// 
			this.listBoxFadingTo.BackColor = System.Drawing.Color.White;
			this.listBoxFadingTo.FormattingEnabled = true;
			this.listBoxFadingTo.ItemHeight = 17;
			this.listBoxFadingTo.Location = new System.Drawing.Point(134, 19);
			this.listBoxFadingTo.Name = "listBoxFadingTo";
			this.listBoxFadingTo.Size = new System.Drawing.Size(120, 429);
			this.listBoxFadingTo.TabIndex = 8;
			this.listBoxFadingTo.SelectedIndexChanged += new System.EventHandler(this.listBoxFadingTo_SelectedIndexChanged);
			// 
			// labelFadingFrom
			// 
			this.labelFadingFrom.AutoSize = true;
			this.labelFadingFrom.Location = new System.Drawing.Point(52, 456);
			this.labelFadingFrom.Name = "labelFadingFrom";
			this.labelFadingFrom.Size = new System.Drawing.Size(37, 17);
			this.labelFadingFrom.TabIndex = 9;
			this.labelFadingFrom.Text = "From";
			// 
			// labelFadingTo
			// 
			this.labelFadingTo.AutoSize = true;
			this.labelFadingTo.Location = new System.Drawing.Point(183, 456);
			this.labelFadingTo.Name = "labelFadingTo";
			this.labelFadingTo.Size = new System.Drawing.Size(21, 17);
			this.labelFadingTo.TabIndex = 10;
			this.labelFadingTo.Text = "To";
			// 
			// groupBoxAnimationMix
			// 
			this.groupBoxAnimationMix.BackColor = System.Drawing.Color.Gainsboro;
			this.groupBoxAnimationMix.Controls.Add(this.groupBoxFading);
			this.groupBoxAnimationMix.Controls.Add(this.groupBoxAnimation);
			this.groupBoxAnimationMix.Controls.Add(this.groupBoxView);
			this.groupBoxAnimationMix.Controls.Add(this.listBoxFadingFrom);
			this.groupBoxAnimationMix.Controls.Add(this.labelFadingTo);
			this.groupBoxAnimationMix.Controls.Add(this.listBoxFadingTo);
			this.groupBoxAnimationMix.Controls.Add(this.labelFadingFrom);
			this.groupBoxAnimationMix.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBoxAnimationMix.Location = new System.Drawing.Point(180, 12);
			this.groupBoxAnimationMix.Name = "groupBoxAnimationMix";
			this.groupBoxAnimationMix.Size = new System.Drawing.Size(404, 558);
			this.groupBoxAnimationMix.TabIndex = 11;
			this.groupBoxAnimationMix.TabStop = false;
			this.groupBoxAnimationMix.Text = "AnimationMix";
			// 
			// groupBoxFading
			// 
			this.groupBoxFading.BackColor = System.Drawing.Color.Transparent;
			this.groupBoxFading.Controls.Add(this.numericUpDownFading);
			this.groupBoxFading.Controls.Add(this.buttonFading);
			this.groupBoxFading.Controls.Add(this.labelDown);
			this.groupBoxFading.Controls.Add(this.labelUp);
			this.groupBoxFading.Location = new System.Drawing.Point(259, 53);
			this.groupBoxFading.Name = "groupBoxFading";
			this.groupBoxFading.Size = new System.Drawing.Size(139, 146);
			this.groupBoxFading.TabIndex = 22;
			this.groupBoxFading.TabStop = false;
			this.groupBoxFading.Text = "Fading";
			// 
			// numericUpDownFading
			// 
			this.numericUpDownFading.DecimalPlaces = 1;
			this.numericUpDownFading.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.numericUpDownFading.Location = new System.Drawing.Point(22, 21);
			this.numericUpDownFading.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            65536});
			this.numericUpDownFading.Name = "numericUpDownFading";
			this.numericUpDownFading.Size = new System.Drawing.Size(92, 22);
			this.numericUpDownFading.TabIndex = 17;
			this.numericUpDownFading.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
			// 
			// buttonFading
			// 
			this.buttonFading.BackColor = System.Drawing.Color.Coral;
			this.buttonFading.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonFading.Location = new System.Drawing.Point(7, 91);
			this.buttonFading.Name = "buttonFading";
			this.buttonFading.Size = new System.Drawing.Size(124, 46);
			this.buttonFading.TabIndex = 21;
			this.buttonFading.Text = "Apply (F9)";
			this.buttonFading.UseVisualStyleBackColor = false;
			this.buttonFading.Click += new System.EventHandler(this.buttonFading_Click);
			// 
			// labelDown
			// 
			this.labelDown.AutoSize = true;
			this.labelDown.Location = new System.Drawing.Point(42, 67);
			this.labelDown.Name = "labelDown";
			this.labelDown.Size = new System.Drawing.Size(61, 17);
			this.labelDown.TabIndex = 20;
			this.labelDown.Text = "Down: F7";
			// 
			// labelUp
			// 
			this.labelUp.AutoSize = true;
			this.labelUp.Location = new System.Drawing.Point(41, 53);
			this.labelUp.Name = "labelUp";
			this.labelUp.Size = new System.Drawing.Size(58, 17);
			this.labelUp.TabIndex = 19;
			this.labelUp.Text = "Up:      F8";
			// 
			// groupBoxAnimation
			// 
			this.groupBoxAnimation.Controls.Add(this.buttonLoop);
			this.groupBoxAnimation.Controls.Add(this.buttonFade);
			this.groupBoxAnimation.Location = new System.Drawing.Point(259, 348);
			this.groupBoxAnimation.Name = "groupBoxAnimation";
			this.groupBoxAnimation.Size = new System.Drawing.Size(139, 107);
			this.groupBoxAnimation.TabIndex = 15;
			this.groupBoxAnimation.TabStop = false;
			this.groupBoxAnimation.Text = "Animation";
			// 
			// buttonLoop
			// 
			this.buttonLoop.BackColor = System.Drawing.Color.SkyBlue;
			this.buttonLoop.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonLoop.Location = new System.Drawing.Point(7, 19);
			this.buttonLoop.Name = "buttonLoop";
			this.buttonLoop.Size = new System.Drawing.Size(124, 45);
			this.buttonLoop.TabIndex = 13;
			this.buttonLoop.Text = "Start Loop (F5)";
			this.buttonLoop.UseVisualStyleBackColor = false;
			this.buttonLoop.Click += new System.EventHandler(this.buttonLoop_Click);
			// 
			// buttonFade
			// 
			this.buttonFade.BackColor = System.Drawing.Color.SkyBlue;
			this.buttonFade.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonFade.Location = new System.Drawing.Point(7, 70);
			this.buttonFade.Name = "buttonFade";
			this.buttonFade.Size = new System.Drawing.Size(124, 25);
			this.buttonFade.TabIndex = 14;
			this.buttonFade.Text = "Fade (F6)";
			this.buttonFade.UseVisualStyleBackColor = false;
			this.buttonFade.Click += new System.EventHandler(this.buttonFade_Click);
			// 
			// groupBoxSkeleton
			// 
			this.groupBoxSkeleton.BackColor = System.Drawing.Color.OrangeRed;
			this.groupBoxSkeleton.Controls.Add(this.groupBoxScaling);
			this.groupBoxSkeleton.Controls.Add(this.listBoxSkeletons);
			this.groupBoxSkeleton.Controls.Add(this.buttonBrowse);
			this.groupBoxSkeleton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBoxSkeleton.Location = new System.Drawing.Point(4, 12);
			this.groupBoxSkeleton.Name = "groupBoxSkeleton";
			this.groupBoxSkeleton.Size = new System.Drawing.Size(170, 558);
			this.groupBoxSkeleton.TabIndex = 12;
			this.groupBoxSkeleton.TabStop = false;
			this.groupBoxSkeleton.Text = "Skeleton";
			// 
			// groupBoxScaling
			// 
			this.groupBoxScaling.BackColor = System.Drawing.Color.OrangeRed;
			this.groupBoxScaling.Controls.Add(this.buttonScaling);
			this.groupBoxScaling.Controls.Add(this.numericUpDownScaling);
			this.groupBoxScaling.Location = new System.Drawing.Point(6, 465);
			this.groupBoxScaling.Name = "groupBoxScaling";
			this.groupBoxScaling.Size = new System.Drawing.Size(158, 87);
			this.groupBoxScaling.TabIndex = 16;
			this.groupBoxScaling.TabStop = false;
			this.groupBoxScaling.Text = "Scaling";
			// 
			// buttonScaling
			// 
			this.buttonScaling.BackColor = System.Drawing.Color.Coral;
			this.buttonScaling.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonScaling.Location = new System.Drawing.Point(6, 45);
			this.buttonScaling.Name = "buttonScaling";
			this.buttonScaling.Size = new System.Drawing.Size(146, 36);
			this.buttonScaling.TabIndex = 1;
			this.buttonScaling.Text = "Apply (F4)";
			this.buttonScaling.UseVisualStyleBackColor = false;
			this.buttonScaling.Click += new System.EventHandler(this.buttonScaling_Click);
			// 
			// numericUpDownScaling
			// 
			this.numericUpDownScaling.DecimalPlaces = 1;
			this.numericUpDownScaling.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.numericUpDownScaling.Location = new System.Drawing.Point(68, 16);
			this.numericUpDownScaling.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            65536});
			this.numericUpDownScaling.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.numericUpDownScaling.Name = "numericUpDownScaling";
			this.numericUpDownScaling.Size = new System.Drawing.Size(84, 22);
			this.numericUpDownScaling.TabIndex = 0;
			this.numericUpDownScaling.Value = new decimal(new int[] {
            10,
            0,
            0,
            65536});
			// 
			// SpineEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DimGray;
			this.ClientSize = new System.Drawing.Size(588, 574);
			this.ControlBox = false;
			this.Controls.Add(this.groupBoxSkeleton);
			this.Controls.Add(this.groupBoxAnimationMix);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "SpineEditor";
			this.Text = "SpineEditor [Editor]";
			this.Load += new System.EventHandler(this.EditorForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownZoom)).EndInit();
			this.groupBoxView.ResumeLayout(false);
			this.groupBoxView.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownPositionY)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownPositionX)).EndInit();
			this.groupBoxAnimationMix.ResumeLayout(false);
			this.groupBoxAnimationMix.PerformLayout();
			this.groupBoxFading.ResumeLayout(false);
			this.groupBoxFading.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownFading)).EndInit();
			this.groupBoxAnimation.ResumeLayout(false);
			this.groupBoxSkeleton.ResumeLayout(false);
			this.groupBoxScaling.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownScaling)).EndInit();
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
		private System.Windows.Forms.GroupBox groupBoxAnimationMix;
		private System.Windows.Forms.GroupBox groupBoxSkeleton;
		private System.Windows.Forms.Label labelSpeed;
		public System.Windows.Forms.Button buttonLoop;
		public System.Windows.Forms.Button buttonFade;
		public System.Windows.Forms.NumericUpDown numericUpDownSpeed;
		private System.Windows.Forms.GroupBox groupBoxAnimation;
		public System.Windows.Forms.GroupBox groupBoxScaling;
		private System.Windows.Forms.Button buttonScaling;
		public System.Windows.Forms.NumericUpDown numericUpDownScaling;
		private System.Windows.Forms.Button buttonResetView;
		public System.Windows.Forms.NumericUpDown numericUpDownFading;
		private System.Windows.Forms.Button buttonFading;
		private System.Windows.Forms.Label labelDown;
		private System.Windows.Forms.Label labelUp;
		private System.Windows.Forms.GroupBox groupBoxFading;
	}
}