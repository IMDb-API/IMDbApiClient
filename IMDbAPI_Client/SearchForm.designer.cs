namespace IMDbAPI_Client
{
    partial class SearchForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            this.txtExpression = new MetroFramework.Controls.MetroTextBox();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.rbMovie = new MetroFramework.Controls.MetroRadioButton();
            this.rbSeriesTV = new MetroFramework.Controls.MetroRadioButton();
            this.lbResults = new System.Windows.Forms.ListBox();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.lblWaiting = new System.Windows.Forms.Label();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.picPoster = new System.Windows.Forms.PictureBox();
            this.toolbarUserControl1 = new IMDbAPI_Client.UserControls.ToolbarUserControl();
            this.spinnerWaiting = new MetroFramework.Controls.MetroProgressSpinner();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnOK = new MetroFramework.Controls.MetroButton();
            this.btnMoreInfo = new MetroFramework.Controls.MetroButton();
            this.btnIMDb = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).BeginInit();
            this.SuspendLayout();
            // 
            // txtExpression
            // 
            this.txtExpression.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtExpression.CustomButton.Image = null;
            this.txtExpression.CustomButton.Location = new System.Drawing.Point(719, 2);
            this.txtExpression.CustomButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtExpression.CustomButton.Name = "";
            this.txtExpression.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtExpression.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtExpression.CustomButton.TabIndex = 1;
            this.txtExpression.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtExpression.CustomButton.UseSelectable = true;
            this.txtExpression.CustomButton.Visible = false;
            this.txtExpression.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtExpression.Lines = new string[0];
            this.txtExpression.Location = new System.Drawing.Point(27, 98);
            this.txtExpression.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtExpression.MaxLength = 32767;
            this.txtExpression.Name = "txtExpression";
            this.txtExpression.PasswordChar = '\0';
            this.txtExpression.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtExpression.SelectedText = "";
            this.txtExpression.SelectionLength = 0;
            this.txtExpression.SelectionStart = 0;
            this.txtExpression.ShortcutsEnabled = true;
            this.txtExpression.ShowClearButton = true;
            this.txtExpression.Size = new System.Drawing.Size(747, 30);
            this.txtExpression.TabIndex = 4;
            this.txtExpression.UseSelectable = true;
            this.txtExpression.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtExpression.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtExpression.Enter += new System.EventHandler(this.txtExpression_Enter);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(780, 98);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(87, 30);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "&SEARCH";
            this.btnSearch.UseSelectable = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // rbMovie
            // 
            this.rbMovie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbMovie.AutoSize = true;
            this.rbMovie.Checked = true;
            this.rbMovie.Enabled = false;
            this.rbMovie.Location = new System.Drawing.Point(630, 70);
            this.rbMovie.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbMovie.Name = "rbMovie";
            this.rbMovie.Size = new System.Drawing.Size(56, 15);
            this.rbMovie.TabIndex = 2;
            this.rbMovie.TabStop = true;
            this.rbMovie.Text = "Movie";
            this.rbMovie.UseSelectable = true;
            // 
            // rbSeriesTV
            // 
            this.rbSeriesTV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbSeriesTV.AutoSize = true;
            this.rbSeriesTV.Enabled = false;
            this.rbSeriesTV.Location = new System.Drawing.Point(705, 70);
            this.rbSeriesTV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbSeriesTV.Name = "rbSeriesTV";
            this.rbSeriesTV.Size = new System.Drawing.Size(69, 15);
            this.rbSeriesTV.TabIndex = 3;
            this.rbSeriesTV.Text = "Series TV";
            this.rbSeriesTV.UseSelectable = true;
            // 
            // lbResults
            // 
            this.lbResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbResults.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResults.FormattingEnabled = true;
            this.lbResults.ItemHeight = 19;
            this.lbResults.Location = new System.Drawing.Point(27, 143);
            this.lbResults.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbResults.Name = "lbResults";
            this.lbResults.Size = new System.Drawing.Size(610, 327);
            this.lbResults.TabIndex = 6;
            this.lbResults.SelectedIndexChanged += new System.EventHandler(this.lbSearchMovie_SelectedIndexChanged);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // lblWaiting
            // 
            this.lblWaiting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWaiting.AutoSize = true;
            this.lblWaiting.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaiting.ForeColor = System.Drawing.Color.Crimson;
            this.lblWaiting.Location = new System.Drawing.Point(740, 30);
            this.lblWaiting.Name = "lblWaiting";
            this.lblWaiting.Size = new System.Drawing.Size(82, 21);
            this.lblWaiting.TabIndex = 1;
            this.lblWaiting.Text = "Waiting...";
            this.lblWaiting.Visible = false;
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // picPoster
            // 
            this.picPoster.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picPoster.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPoster.Location = new System.Drawing.Point(643, 143);
            this.picPoster.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picPoster.Name = "picPoster";
            this.picPoster.Size = new System.Drawing.Size(224, 327);
            this.picPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPoster.TabIndex = 8;
            this.picPoster.TabStop = false;
            this.metroToolTip1.SetToolTip(this.picPoster, "More Info...");
            this.picPoster.Click += new System.EventHandler(this.picPoster_Click);
            // 
            // toolbarUserControl1
            // 
            this.toolbarUserControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toolbarUserControl1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolbarUserControl1.Location = new System.Drawing.Point(833, 10);
            this.toolbarUserControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.toolbarUserControl1.MinimzeButton = false;
            this.toolbarUserControl1.Name = "toolbarUserControl1";
            this.toolbarUserControl1.Size = new System.Drawing.Size(51, 62);
            this.toolbarUserControl1.TabIndex = 2;
            this.toolbarUserControl1.UseSelectable = true;
            // 
            // spinnerWaiting
            // 
            this.spinnerWaiting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.spinnerWaiting.Location = new System.Drawing.Point(721, 32);
            this.spinnerWaiting.Maximum = 100;
            this.spinnerWaiting.Name = "spinnerWaiting";
            this.spinnerWaiting.Size = new System.Drawing.Size(16, 17);
            this.spinnerWaiting.Style = MetroFramework.MetroColorStyle.Red;
            this.spinnerWaiting.TabIndex = 0;
            this.spinnerWaiting.UseCustomForeColor = true;
            this.spinnerWaiting.UseSelectable = true;
            this.spinnerWaiting.Value = 100;
            this.spinnerWaiting.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(623, 496);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 49);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "&CANCEL";
            this.btnCancel.UseCustomBackColor = true;
            this.btnCancel.UseCustomForeColor = true;
            this.btnCancel.UseSelectable = true;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(748, 496);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(119, 49);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "&OK";
            this.btnOK.UseCustomBackColor = true;
            this.btnOK.UseCustomForeColor = true;
            this.btnOK.UseSelectable = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnMoreInfo
            // 
            this.btnMoreInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMoreInfo.Location = new System.Drawing.Point(26, 496);
            this.btnMoreInfo.Name = "btnMoreInfo";
            this.btnMoreInfo.Size = new System.Drawing.Size(119, 49);
            this.btnMoreInfo.TabIndex = 27;
            this.btnMoreInfo.Text = "&INFO...";
            this.btnMoreInfo.UseSelectable = true;
            this.btnMoreInfo.Click += new System.EventHandler(this.btnMoreInfo_Click);
            // 
            // btnIMDb
            // 
            this.btnIMDb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnIMDb.Location = new System.Drawing.Point(151, 496);
            this.btnIMDb.Name = "btnIMDb";
            this.btnIMDb.Size = new System.Drawing.Size(119, 49);
            this.btnIMDb.TabIndex = 9;
            this.btnIMDb.Text = "&IMDb";
            this.btnIMDb.UseSelectable = true;
            this.btnIMDb.Click += new System.EventHandler(this.btnIMDb_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(892, 575);
            this.ControlBox = false;
            this.Controls.Add(this.btnIMDb);
            this.Controls.Add(this.btnMoreInfo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.spinnerWaiting);
            this.Controls.Add(this.toolbarUserControl1);
            this.Controls.Add(this.lblWaiting);
            this.Controls.Add(this.lbResults);
            this.Controls.Add(this.rbSeriesTV);
            this.Controls.Add(this.rbMovie);
            this.Controls.Add(this.picPoster);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtExpression);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(892, 575);
            this.Name = "SearchForm";
            this.Padding = new System.Windows.Forms.Padding(23, 79, 23, 27);
            this.Text = "Search";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtExpression;
        private MetroFramework.Controls.MetroButton btnSearch;
        private System.Windows.Forms.PictureBox picPoster;
        private MetroFramework.Controls.MetroRadioButton rbMovie;
        private MetroFramework.Controls.MetroRadioButton rbSeriesTV;
        private System.Windows.Forms.ListBox lbResults;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private System.Windows.Forms.Label lblWaiting;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private UserControls.ToolbarUserControl toolbarUserControl1;
        private MetroFramework.Controls.MetroProgressSpinner spinnerWaiting;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton btnOK;
        private MetroFramework.Controls.MetroButton btnMoreInfo;
        private MetroFramework.Controls.MetroButton btnIMDb;
    }
}