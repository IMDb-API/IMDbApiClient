namespace IMDbAPI_Client.UserControls
{
    partial class Step3_SettingsUC
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
            this.chkReport = new MetroFramework.Controls.MetroCheckBox();
            this.chkPosters = new MetroFramework.Controls.MetroCheckBox();
            this.chkImages = new MetroFramework.Controls.MetroCheckBox();
            this.chkTrailer = new MetroFramework.Controls.MetroCheckBox();
            this.grpReport = new System.Windows.Forms.GroupBox();
            this.chkReport_Ratings = new MetroFramework.Controls.MetroCheckBox();
            this.chkReport_Wikipedia = new MetroFramework.Controls.MetroCheckBox();
            this.chkReport_FullCast = new MetroFramework.Controls.MetroCheckBox();
            this.chkReport_FullActor = new MetroFramework.Controls.MetroCheckBox();
            this.grpImages = new System.Windows.Forms.GroupBox();
            this.rbImages_Full = new MetroFramework.Controls.MetroRadioButton();
            this.rbImages_Short = new MetroFramework.Controls.MetroRadioButton();
            this.ddlPlotLanguage = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.chkExternalSites = new MetroFramework.Controls.MetroCheckBox();
            this.rbPosters_EnglishOnly = new MetroFramework.Controls.MetroRadioButton();
            this.rbPosters_AllLanguages = new MetroFramework.Controls.MetroRadioButton();
            this.grpPosters = new System.Windows.Forms.GroupBox();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.chkResizeImagesAndPosters = new MetroFramework.Controls.MetroCheckBox();
            this.grpReport.SuspendLayout();
            this.grpImages.SuspendLayout();
            this.grpPosters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // chkReport
            // 
            this.chkReport.AutoSize = true;
            this.chkReport.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkReport.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.chkReport.Location = new System.Drawing.Point(61, 72);
            this.chkReport.Name = "chkReport";
            this.chkReport.Size = new System.Drawing.Size(71, 19);
            this.chkReport.TabIndex = 2;
            this.chkReport.Text = "Report";
            this.chkReport.UseSelectable = true;
            this.chkReport.UseStyleColors = true;
            this.chkReport.CheckedChanged += new System.EventHandler(this.chkReport_CheckedChanged);
            // 
            // chkPosters
            // 
            this.chkPosters.AutoSize = true;
            this.chkPosters.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkPosters.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.chkPosters.Location = new System.Drawing.Point(441, 192);
            this.chkPosters.Name = "chkPosters";
            this.chkPosters.Size = new System.Drawing.Size(74, 19);
            this.chkPosters.TabIndex = 4;
            this.chkPosters.Text = "Posters";
            this.chkPosters.UseSelectable = true;
            this.chkPosters.UseStyleColors = true;
            this.chkPosters.CheckedChanged += new System.EventHandler(this.chkPosters_CheckedChanged);
            // 
            // chkImages
            // 
            this.chkImages.AutoSize = true;
            this.chkImages.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkImages.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.chkImages.Location = new System.Drawing.Point(61, 192);
            this.chkImages.Name = "chkImages";
            this.chkImages.Size = new System.Drawing.Size(73, 19);
            this.chkImages.TabIndex = 3;
            this.chkImages.Text = "Images";
            this.chkImages.UseSelectable = true;
            this.chkImages.UseStyleColors = true;
            this.chkImages.CheckedChanged += new System.EventHandler(this.chkImages_CheckedChanged);
            // 
            // chkTrailer
            // 
            this.chkTrailer.AutoSize = true;
            this.chkTrailer.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkTrailer.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.chkTrailer.Location = new System.Drawing.Point(61, 317);
            this.chkTrailer.Name = "chkTrailer";
            this.chkTrailer.Size = new System.Drawing.Size(68, 19);
            this.chkTrailer.TabIndex = 5;
            this.chkTrailer.Text = "Trailer";
            this.chkTrailer.UseSelectable = true;
            this.chkTrailer.UseStyleColors = true;
            // 
            // grpReport
            // 
            this.grpReport.BackColor = System.Drawing.Color.Transparent;
            this.grpReport.Controls.Add(this.chkReport_Ratings);
            this.grpReport.Controls.Add(this.chkReport_Wikipedia);
            this.grpReport.Controls.Add(this.chkReport_FullCast);
            this.grpReport.Controls.Add(this.chkReport_FullActor);
            this.grpReport.Location = new System.Drawing.Point(61, 100);
            this.grpReport.Name = "grpReport";
            this.grpReport.Size = new System.Drawing.Size(740, 70);
            this.grpReport.TabIndex = 3;
            this.grpReport.TabStop = false;
            this.grpReport.Text = "Report Options";
            // 
            // chkReport_Ratings
            // 
            this.chkReport_Ratings.AutoSize = true;
            this.chkReport_Ratings.Location = new System.Drawing.Point(44, 33);
            this.chkReport_Ratings.Name = "chkReport_Ratings";
            this.chkReport_Ratings.Size = new System.Drawing.Size(62, 15);
            this.chkReport_Ratings.TabIndex = 0;
            this.chkReport_Ratings.Text = "Ratings";
            this.chkReport_Ratings.UseSelectable = true;
            // 
            // chkReport_Wikipedia
            // 
            this.chkReport_Wikipedia.AutoSize = true;
            this.chkReport_Wikipedia.Location = new System.Drawing.Point(530, 33);
            this.chkReport_Wikipedia.Name = "chkReport_Wikipedia";
            this.chkReport_Wikipedia.Size = new System.Drawing.Size(99, 15);
            this.chkReport_Wikipedia.TabIndex = 3;
            this.chkReport_Wikipedia.Text = "Wikipedia Plot";
            this.chkReport_Wikipedia.UseSelectable = true;
            // 
            // chkReport_FullCast
            // 
            this.chkReport_FullCast.AutoSize = true;
            this.chkReport_FullCast.Location = new System.Drawing.Point(368, 33);
            this.chkReport_FullCast.Name = "chkReport_FullCast";
            this.chkReport_FullCast.Size = new System.Drawing.Size(68, 15);
            this.chkReport_FullCast.TabIndex = 2;
            this.chkReport_FullCast.Text = "Full Cast";
            this.chkReport_FullCast.UseSelectable = true;
            // 
            // chkReport_FullActor
            // 
            this.chkReport_FullActor.AutoSize = true;
            this.chkReport_FullActor.Location = new System.Drawing.Point(200, 33);
            this.chkReport_FullActor.Name = "chkReport_FullActor";
            this.chkReport_FullActor.Size = new System.Drawing.Size(74, 15);
            this.chkReport_FullActor.TabIndex = 1;
            this.chkReport_FullActor.Text = "Full Actor";
            this.chkReport_FullActor.UseSelectable = true;
            // 
            // grpImages
            // 
            this.grpImages.BackColor = System.Drawing.Color.Transparent;
            this.grpImages.Controls.Add(this.rbImages_Full);
            this.grpImages.Controls.Add(this.rbImages_Short);
            this.grpImages.Location = new System.Drawing.Point(63, 222);
            this.grpImages.Name = "grpImages";
            this.grpImages.Size = new System.Drawing.Size(360, 70);
            this.grpImages.TabIndex = 9;
            this.grpImages.TabStop = false;
            this.grpImages.Text = "Images Options";
            // 
            // rbImages_Full
            // 
            this.rbImages_Full.AutoSize = true;
            this.rbImages_Full.Location = new System.Drawing.Point(153, 33);
            this.rbImages_Full.Name = "rbImages_Full";
            this.rbImages_Full.Size = new System.Drawing.Size(42, 15);
            this.rbImages_Full.TabIndex = 1;
            this.rbImages_Full.Text = "Full";
            this.rbImages_Full.UseSelectable = true;
            // 
            // rbImages_Short
            // 
            this.rbImages_Short.AutoSize = true;
            this.rbImages_Short.Checked = true;
            this.rbImages_Short.Location = new System.Drawing.Point(42, 33);
            this.rbImages_Short.Name = "rbImages_Short";
            this.rbImages_Short.Size = new System.Drawing.Size(51, 15);
            this.rbImages_Short.TabIndex = 0;
            this.rbImages_Short.TabStop = true;
            this.rbImages_Short.Text = "Short";
            this.rbImages_Short.UseSelectable = true;
            // 
            // ddlPlotLanguage
            // 
            this.ddlPlotLanguage.FormattingEnabled = true;
            this.ddlPlotLanguage.ItemHeight = 23;
            this.ddlPlotLanguage.Location = new System.Drawing.Point(172, 27);
            this.ddlPlotLanguage.Name = "ddlPlotLanguage";
            this.ddlPlotLanguage.Size = new System.Drawing.Size(128, 29);
            this.ddlPlotLanguage.TabIndex = 1;
            this.ddlPlotLanguage.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(61, 30);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(105, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Plot Language";
            this.metroLabel1.UseStyleColors = true;
            // 
            // chkExternalSites
            // 
            this.chkExternalSites.AutoSize = true;
            this.chkExternalSites.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkExternalSites.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.chkExternalSites.Location = new System.Drawing.Point(235, 317);
            this.chkExternalSites.Name = "chkExternalSites";
            this.chkExternalSites.Size = new System.Drawing.Size(145, 19);
            this.chkExternalSites.TabIndex = 6;
            this.chkExternalSites.Text = "External Site Links";
            this.chkExternalSites.UseSelectable = true;
            this.chkExternalSites.UseStyleColors = true;
            // 
            // rbPosters_EnglishOnly
            // 
            this.rbPosters_EnglishOnly.AutoSize = true;
            this.rbPosters_EnglishOnly.Location = new System.Drawing.Point(174, 33);
            this.rbPosters_EnglishOnly.Name = "rbPosters_EnglishOnly";
            this.rbPosters_EnglishOnly.Size = new System.Drawing.Size(89, 15);
            this.rbPosters_EnglishOnly.TabIndex = 1;
            this.rbPosters_EnglishOnly.Text = "English Only";
            this.rbPosters_EnglishOnly.UseSelectable = true;
            // 
            // rbPosters_AllLanguages
            // 
            this.rbPosters_AllLanguages.AutoSize = true;
            this.rbPosters_AllLanguages.Checked = true;
            this.rbPosters_AllLanguages.Location = new System.Drawing.Point(44, 33);
            this.rbPosters_AllLanguages.Name = "rbPosters_AllLanguages";
            this.rbPosters_AllLanguages.Size = new System.Drawing.Size(97, 15);
            this.rbPosters_AllLanguages.TabIndex = 0;
            this.rbPosters_AllLanguages.TabStop = true;
            this.rbPosters_AllLanguages.Text = "All Languages";
            this.rbPosters_AllLanguages.UseSelectable = true;
            // 
            // grpPosters
            // 
            this.grpPosters.BackColor = System.Drawing.Color.Transparent;
            this.grpPosters.Controls.Add(this.rbPosters_AllLanguages);
            this.grpPosters.Controls.Add(this.rbPosters_EnglishOnly);
            this.grpPosters.Location = new System.Drawing.Point(441, 220);
            this.grpPosters.Name = "grpPosters";
            this.grpPosters.Size = new System.Drawing.Size(360, 70);
            this.grpPosters.TabIndex = 5;
            this.grpPosters.TabStop = false;
            this.grpPosters.Text = "Posters Options";
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // chkResizeImagesAndPosters
            // 
            this.chkResizeImagesAndPosters.AutoSize = true;
            this.chkResizeImagesAndPosters.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkResizeImagesAndPosters.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.chkResizeImagesAndPosters.Location = new System.Drawing.Point(441, 317);
            this.chkResizeImagesAndPosters.Name = "chkResizeImagesAndPosters";
            this.chkResizeImagesAndPosters.Size = new System.Drawing.Size(272, 19);
            this.chkResizeImagesAndPosters.TabIndex = 6;
            this.chkResizeImagesAndPosters.Text = "Resize Images and Posters (GUI only)";
            this.chkResizeImagesAndPosters.UseSelectable = true;
            this.chkResizeImagesAndPosters.UseStyleColors = true;
            // 
            // Step3_SettingsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpPosters);
            this.Controls.Add(this.chkResizeImagesAndPosters);
            this.Controls.Add(this.chkExternalSites);
            this.Controls.Add(this.ddlPlotLanguage);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.grpImages);
            this.Controls.Add(this.grpReport);
            this.Controls.Add(this.chkTrailer);
            this.Controls.Add(this.chkImages);
            this.Controls.Add(this.chkPosters);
            this.Controls.Add(this.chkReport);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Step3_SettingsUC";
            this.Size = new System.Drawing.Size(870, 440);
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.grpReport.ResumeLayout(false);
            this.grpReport.PerformLayout();
            this.grpImages.ResumeLayout(false);
            this.grpImages.PerformLayout();
            this.grpPosters.ResumeLayout(false);
            this.grpPosters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroCheckBox chkReport;
        private MetroFramework.Controls.MetroCheckBox chkPosters;
        private MetroFramework.Controls.MetroCheckBox chkImages;
        private MetroFramework.Controls.MetroCheckBox chkTrailer;
        private System.Windows.Forms.GroupBox grpReport;
        private MetroFramework.Controls.MetroCheckBox chkReport_Wikipedia;
        private MetroFramework.Controls.MetroCheckBox chkReport_FullCast;
        private MetroFramework.Controls.MetroCheckBox chkReport_FullActor;
        private System.Windows.Forms.GroupBox grpImages;
        private MetroFramework.Controls.MetroRadioButton rbImages_Full;
        private MetroFramework.Controls.MetroRadioButton rbImages_Short;
        private MetroFramework.Controls.MetroComboBox ddlPlotLanguage;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroCheckBox chkExternalSites;
        private MetroFramework.Controls.MetroRadioButton rbPosters_EnglishOnly;
        private MetroFramework.Controls.MetroRadioButton rbPosters_AllLanguages;
        private System.Windows.Forms.GroupBox grpPosters;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroCheckBox chkReport_Ratings;
        private MetroFramework.Controls.MetroCheckBox chkResizeImagesAndPosters;
    }
}
