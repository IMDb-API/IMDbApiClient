namespace IMDbAPI_Client.UserControls
{
    partial class Step1_InitUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.rbMovies = new MetroFramework.Controls.MetroRadioButton();
            this.rbSeriesTV = new MetroFramework.Controls.MetroRadioButton();
            this.txtMoviesDir = new MetroFramework.Controls.MetroTextBox();
            this.lblMoviesDir = new MetroFramework.Controls.MetroLabel();
            this.txtApiKey = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lnkRegister = new MetroFramework.Controls.MetroLink();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.txtSeriesTvDir = new MetroFramework.Controls.MetroTextBox();
            this.lblSeriesTvDir = new MetroFramework.Controls.MetroLabel();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.rbMovieFile = new MetroFramework.Controls.MetroRadioButton();
            this.btnSearchSeriesTV = new MetroFramework.Controls.MetroButton();
            this.lblSeriesTvID = new MetroFramework.Controls.MetroLabel();
            this.txtSeriesTvID = new MetroFramework.Controls.MetroTextBox();
            this.btnMoreInfo = new MetroFramework.Controls.MetroButton();
            this.lblMovieFile = new MetroFramework.Controls.MetroLabel();
            this.txtMovieFile = new MetroFramework.Controls.MetroTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // rbMovies
            // 
            this.rbMovies.AutoSize = true;
            this.rbMovies.Checked = true;
            this.rbMovies.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.rbMovies.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.rbMovies.Location = new System.Drawing.Point(70, 173);
            this.rbMovies.Name = "rbMovies";
            this.rbMovies.Size = new System.Drawing.Size(179, 25);
            this.rbMovies.TabIndex = 3;
            this.rbMovies.TabStop = true;
            this.rbMovies.Text = "Movies (Multiple)";
            this.metroToolTip1.SetToolTip(this.rbMovies, "Multiple Movies");
            this.rbMovies.UseSelectable = true;
            this.rbMovies.UseStyleColors = true;
            this.rbMovies.CheckedChanged += new System.EventHandler(this.rbAll_CheckedChanged);
            // 
            // rbSeriesTV
            // 
            this.rbSeriesTV.AutoSize = true;
            this.rbSeriesTV.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.rbSeriesTV.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.rbSeriesTV.Location = new System.Drawing.Point(70, 268);
            this.rbSeriesTV.Name = "rbSeriesTV";
            this.rbSeriesTV.Size = new System.Drawing.Size(178, 25);
            this.rbSeriesTV.TabIndex = 6;
            this.rbSeriesTV.Text = "Series TV (Single)";
            this.metroToolTip1.SetToolTip(this.rbSeriesTV, "Single Series TV");
            this.rbSeriesTV.UseSelectable = true;
            this.rbSeriesTV.UseStyleColors = true;
            this.rbSeriesTV.CheckedChanged += new System.EventHandler(this.rbAll_CheckedChanged);
            // 
            // txtMoviesDir
            // 
            this.txtMoviesDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtMoviesDir.CustomButton.Image = null;
            this.txtMoviesDir.CustomButton.Location = new System.Drawing.Point(672, 2);
            this.txtMoviesDir.CustomButton.Name = "";
            this.txtMoviesDir.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txtMoviesDir.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMoviesDir.CustomButton.TabIndex = 1;
            this.txtMoviesDir.CustomButton.Text = "...";
            this.txtMoviesDir.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMoviesDir.CustomButton.UseSelectable = true;
            this.txtMoviesDir.Lines = new string[0];
            this.txtMoviesDir.Location = new System.Drawing.Point(95, 229);
            this.txtMoviesDir.MaxLength = 32767;
            this.txtMoviesDir.Name = "txtMoviesDir";
            this.txtMoviesDir.PasswordChar = '\0';
            this.txtMoviesDir.WaterMark = "Movies Directory ex: D:\\...\\New Movies";
            this.txtMoviesDir.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMoviesDir.SelectedText = "";
            this.txtMoviesDir.SelectionLength = 0;
            this.txtMoviesDir.SelectionStart = 0;
            this.txtMoviesDir.ShortcutsEnabled = true;
            this.txtMoviesDir.ShowButton = true;
            this.txtMoviesDir.ShowClearButton = true;
            this.txtMoviesDir.Size = new System.Drawing.Size(694, 24);
            this.txtMoviesDir.TabIndex = 5;
            this.txtMoviesDir.UseSelectable = true;
            this.txtMoviesDir.UseStyleColors = true;
            this.txtMoviesDir.WaterMark = "Movies Directory ex: D:\\...\\New Movies";
            this.txtMoviesDir.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMoviesDir.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtMoviesDir.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.txtMoviesDir_ButtonClick);
            // 
            // lblMoviesDir
            // 
            this.lblMoviesDir.AutoSize = true;
            this.lblMoviesDir.Location = new System.Drawing.Point(95, 203);
            this.lblMoviesDir.Name = "lblMoviesDir";
            this.lblMoviesDir.Size = new System.Drawing.Size(108, 19);
            this.lblMoviesDir.TabIndex = 4;
            this.lblMoviesDir.Text = "Movies Directory";
            this.lblMoviesDir.UseStyleColors = true;
            // 
            // txtApiKey
            // 
            this.txtApiKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtApiKey.CustomButton.Image = global::IMDbAPI_Client.Properties.Resources.ViewSmall;
            this.txtApiKey.CustomButton.Location = new System.Drawing.Point(177, 2);
            this.txtApiKey.CustomButton.Name = "";
            this.txtApiKey.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txtApiKey.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtApiKey.CustomButton.TabIndex = 1;
            this.txtApiKey.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtApiKey.CustomButton.UseSelectable = true;
            this.txtApiKey.Lines = new string[0];
            this.txtApiKey.Location = new System.Drawing.Point(590, 43);
            this.txtApiKey.MaxLength = 32767;
            this.txtApiKey.Name = "txtApiKey";
            this.txtApiKey.PasswordChar = '\0';
            this.txtApiKey.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtApiKey.SelectedText = "";
            this.txtApiKey.SelectionLength = 0;
            this.txtApiKey.SelectionStart = 0;
            this.txtApiKey.ShortcutsEnabled = true;
            this.txtApiKey.ShowButton = true;
            this.txtApiKey.Size = new System.Drawing.Size(199, 24);
            this.txtApiKey.TabIndex = 1;
            this.txtApiKey.UseSelectable = true;
            this.txtApiKey.UseStyleColors = true;
            this.txtApiKey.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtApiKey.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtApiKey.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.txtApiKey_ButtonClick);
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(590, 17);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(53, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "API Key";
            this.metroLabel2.UseStyleColors = true;
            // 
            // lnkRegister
            // 
            this.lnkRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkRegister.Location = new System.Drawing.Point(590, 74);
            this.lnkRegister.Name = "lnkRegister";
            this.lnkRegister.Size = new System.Drawing.Size(199, 24);
            this.lnkRegister.TabIndex = 2;
            this.lnkRegister.Text = "Free registeration to get API Key";
            this.lnkRegister.UseSelectable = true;
            this.lnkRegister.Click += new System.EventHandler(this.lnkRegister_Click);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // txtSeriesTvDir
            // 
            this.txtSeriesTvDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtSeriesTvDir.CustomButton.Image = null;
            this.txtSeriesTvDir.CustomButton.Location = new System.Drawing.Point(672, 2);
            this.txtSeriesTvDir.CustomButton.Name = "";
            this.txtSeriesTvDir.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txtSeriesTvDir.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSeriesTvDir.CustomButton.TabIndex = 1;
            this.txtSeriesTvDir.CustomButton.Text = "...";
            this.txtSeriesTvDir.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSeriesTvDir.CustomButton.UseSelectable = true;
            this.txtSeriesTvDir.Enabled = false;
            this.txtSeriesTvDir.Lines = new string[0];
            this.txtSeriesTvDir.Location = new System.Drawing.Point(95, 324);
            this.txtSeriesTvDir.MaxLength = 32767;
            this.txtSeriesTvDir.Name = "txtSeriesTvDir";
            this.txtSeriesTvDir.PasswordChar = '\0';
            this.txtSeriesTvDir.WaterMark = "Series TV Directory ex: D:\\...\\Series TVs";
            this.txtSeriesTvDir.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSeriesTvDir.SelectedText = "";
            this.txtSeriesTvDir.SelectionLength = 0;
            this.txtSeriesTvDir.SelectionStart = 0;
            this.txtSeriesTvDir.ShortcutsEnabled = true;
            this.txtSeriesTvDir.ShowButton = true;
            this.txtSeriesTvDir.ShowClearButton = true;
            this.txtSeriesTvDir.Size = new System.Drawing.Size(694, 24);
            this.txtSeriesTvDir.TabIndex = 8;
            this.txtSeriesTvDir.UseSelectable = true;
            this.txtSeriesTvDir.UseStyleColors = true;
            this.txtSeriesTvDir.WaterMark = "Series TV Directory ex: D:\\...\\Series TVs";
            this.txtSeriesTvDir.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSeriesTvDir.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSeriesTvDir.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.txtSeriesTvDir_ButtonClick);
            // 
            // lblSeriesTvDir
            // 
            this.lblSeriesTvDir.AutoSize = true;
            this.lblSeriesTvDir.Enabled = false;
            this.lblSeriesTvDir.Location = new System.Drawing.Point(95, 298);
            this.lblSeriesTvDir.Name = "lblSeriesTvDir";
            this.lblSeriesTvDir.Size = new System.Drawing.Size(108, 19);
            this.lblSeriesTvDir.TabIndex = 7;
            this.lblSeriesTvDir.Text = "Output Directory";
            this.lblSeriesTvDir.UseStyleColors = true;
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // rbMovieFile
            // 
            this.rbMovieFile.AutoSize = true;
            this.rbMovieFile.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.rbMovieFile.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.rbMovieFile.Location = new System.Drawing.Point(70, 73);
            this.rbMovieFile.Name = "rbMovieFile";
            this.rbMovieFile.Size = new System.Drawing.Size(152, 25);
            this.rbMovieFile.TabIndex = 13;
            this.rbMovieFile.Text = "Movie (Single)";
            this.metroToolTip1.SetToolTip(this.rbMovieFile, "Single Movie");
            this.rbMovieFile.UseSelectable = true;
            this.rbMovieFile.UseStyleColors = true;
            this.rbMovieFile.CheckedChanged += new System.EventHandler(this.rbAll_CheckedChanged);
            // 
            // btnSearchSeriesTV
            // 
            this.btnSearchSeriesTV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchSeriesTV.Enabled = false;
            this.btnSearchSeriesTV.Location = new System.Drawing.Point(583, 380);
            this.btnSearchSeriesTV.Name = "btnSearchSeriesTV";
            this.btnSearchSeriesTV.Size = new System.Drawing.Size(206, 24);
            this.btnSearchSeriesTV.TabIndex = 9;
            this.btnSearchSeriesTV.Text = "Search for Series TV IMDb ID";
            this.btnSearchSeriesTV.UseSelectable = true;
            this.btnSearchSeriesTV.Click += new System.EventHandler(this.btnSearchSeriesTV_Click);
            // 
            // lblSeriesTvID
            // 
            this.lblSeriesTvID.AutoSize = true;
            this.lblSeriesTvID.Enabled = false;
            this.lblSeriesTvID.Location = new System.Drawing.Point(95, 355);
            this.lblSeriesTvID.Name = "lblSeriesTvID";
            this.lblSeriesTvID.Size = new System.Drawing.Size(114, 19);
            this.lblSeriesTvID.TabIndex = 10;
            this.lblSeriesTvID.Text = "Series TV IMDb ID";
            this.lblSeriesTvID.UseStyleColors = true;
            // 
            // txtSeriesTvID
            // 
            this.txtSeriesTvID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtSeriesTvID.CustomButton.Image = null;
            this.txtSeriesTvID.CustomButton.Location = new System.Drawing.Point(321, 2);
            this.txtSeriesTvID.CustomButton.Name = "";
            this.txtSeriesTvID.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txtSeriesTvID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSeriesTvID.CustomButton.TabIndex = 1;
            this.txtSeriesTvID.CustomButton.Text = "...";
            this.txtSeriesTvID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSeriesTvID.CustomButton.UseSelectable = true;
            this.txtSeriesTvID.Enabled = false;
            this.txtSeriesTvID.Lines = new string[0];
            this.txtSeriesTvID.Location = new System.Drawing.Point(95, 380);
            this.txtSeriesTvID.MaxLength = 32767;
            this.txtSeriesTvID.Name = "txtSeriesTvID";
            this.txtSeriesTvID.PasswordChar = '\0';
            this.txtSeriesTvID.WaterMark = "ex: tt0411008";
            this.txtSeriesTvID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSeriesTvID.SelectedText = "";
            this.txtSeriesTvID.SelectionLength = 0;
            this.txtSeriesTvID.SelectionStart = 0;
            this.txtSeriesTvID.ShortcutsEnabled = true;
            this.txtSeriesTvID.ShowButton = true;
            this.txtSeriesTvID.ShowClearButton = true;
            this.txtSeriesTvID.Size = new System.Drawing.Size(343, 24);
            this.txtSeriesTvID.TabIndex = 11;
            this.txtSeriesTvID.UseSelectable = true;
            this.txtSeriesTvID.UseStyleColors = true;
            this.txtSeriesTvID.WaterMark = "ex: tt0411008";
            this.txtSeriesTvID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSeriesTvID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnMoreInfo
            // 
            this.btnMoreInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoreInfo.Enabled = false;
            this.btnMoreInfo.Location = new System.Drawing.Point(444, 380);
            this.btnMoreInfo.Name = "btnMoreInfo";
            this.btnMoreInfo.Size = new System.Drawing.Size(133, 24);
            this.btnMoreInfo.TabIndex = 12;
            this.btnMoreInfo.Text = "More Info...";
            this.btnMoreInfo.UseSelectable = true;
            this.btnMoreInfo.Click += new System.EventHandler(this.btnMoreInfo_Click);
            // 
            // lblMovieFile
            // 
            this.lblMovieFile.AutoSize = true;
            this.lblMovieFile.Enabled = false;
            this.lblMovieFile.Location = new System.Drawing.Point(95, 103);
            this.lblMovieFile.Name = "lblMovieFile";
            this.lblMovieFile.Size = new System.Drawing.Size(69, 19);
            this.lblMovieFile.TabIndex = 14;
            this.lblMovieFile.Text = "Movie File";
            this.lblMovieFile.UseStyleColors = true;
            // 
            // txtMovieFile
            // 
            this.txtMovieFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtMovieFile.CustomButton.Image = null;
            this.txtMovieFile.CustomButton.Location = new System.Drawing.Point(672, 2);
            this.txtMovieFile.CustomButton.Name = "";
            this.txtMovieFile.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txtMovieFile.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMovieFile.CustomButton.TabIndex = 1;
            this.txtMovieFile.CustomButton.Text = "...";
            this.txtMovieFile.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMovieFile.CustomButton.UseSelectable = true;
            this.txtMovieFile.Enabled = false;
            this.txtMovieFile.Lines = new string[0];
            this.txtMovieFile.Location = new System.Drawing.Point(95, 129);
            this.txtMovieFile.MaxLength = 32767;
            this.txtMovieFile.Name = "txtMovieFile";
            this.txtMovieFile.PasswordChar = '\0';
            this.txtMovieFile.WaterMark = "Movie File ex: D:\\...\\Leon The Professional.mkv";
            this.txtMovieFile.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMovieFile.SelectedText = "";
            this.txtMovieFile.SelectionLength = 0;
            this.txtMovieFile.SelectionStart = 0;
            this.txtMovieFile.ShortcutsEnabled = true;
            this.txtMovieFile.ShowButton = true;
            this.txtMovieFile.ShowClearButton = true;
            this.txtMovieFile.Size = new System.Drawing.Size(694, 24);
            this.txtMovieFile.TabIndex = 15;
            this.txtMovieFile.UseSelectable = true;
            this.txtMovieFile.UseStyleColors = true;
            this.txtMovieFile.WaterMark = "Movie File ex: D:\\...\\Leon The Professional.mkv";
            this.txtMovieFile.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMovieFile.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtMovieFile.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.txtMovieFile_ButtonClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Movie files|*.mkv;*.avi;*.mp4;*.mpeg;*.wmv;*.m4a;*.m4v;*.f4a;*.m4b;*.m4r;*.f4b;*." +
    "mov;*.3gp;*.ogg;*.webm;*.flv;*.ts;*.vob|All files|*.*";
            // 
            // Step1_InitUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblMovieFile);
            this.Controls.Add(this.txtMovieFile);
            this.Controls.Add(this.rbMovieFile);
            this.Controls.Add(this.btnMoreInfo);
            this.Controls.Add(this.lblSeriesTvID);
            this.Controls.Add(this.txtSeriesTvID);
            this.Controls.Add(this.btnSearchSeriesTV);
            this.Controls.Add(this.lblSeriesTvDir);
            this.Controls.Add(this.txtSeriesTvDir);
            this.Controls.Add(this.lnkRegister);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtApiKey);
            this.Controls.Add(this.lblMoviesDir);
            this.Controls.Add(this.txtMoviesDir);
            this.Controls.Add(this.rbSeriesTV);
            this.Controls.Add(this.rbMovies);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Step1_InitUC";
            this.Size = new System.Drawing.Size(870, 440);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private MetroFramework.Controls.MetroRadioButton rbMovies;
        private MetroFramework.Controls.MetroRadioButton rbSeriesTV;
        private MetroFramework.Controls.MetroTextBox txtMoviesDir;
        private MetroFramework.Controls.MetroLabel lblMoviesDir;
        private MetroFramework.Controls.MetroTextBox txtApiKey;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLink lnkRegister;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroTextBox txtSeriesTvDir;
        private MetroFramework.Controls.MetroLabel lblSeriesTvDir;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private MetroFramework.Controls.MetroButton btnSearchSeriesTV;
        private MetroFramework.Controls.MetroLabel lblSeriesTvID;
        private MetroFramework.Controls.MetroTextBox txtSeriesTvID;
        private MetroFramework.Controls.MetroButton btnMoreInfo;
        private MetroFramework.Controls.MetroLabel lblMovieFile;
        private MetroFramework.Controls.MetroTextBox txtMovieFile;
        private MetroFramework.Controls.MetroRadioButton rbMovieFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
