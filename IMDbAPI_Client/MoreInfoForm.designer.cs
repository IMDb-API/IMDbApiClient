namespace IMDbAPI_Client
{
    partial class MoreInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoreInfoForm));
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.lblFullTitle = new MetroFramework.Controls.MetroLabel();
            this.lblOriginalTitle = new MetroFramework.Controls.MetroLabel();
            this.lblCreatorsTitle = new MetroFramework.Controls.MetroLabel();
            this.txtPlot = new MetroFramework.Controls.MetroTextBox();
            this.lblCreators = new MetroFramework.Controls.MetroLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.picPoster = new System.Windows.Forms.PictureBox();
            this.btnIMDb = new System.Windows.Forms.Button();
            this.lblWaiting = new System.Windows.Forms.Label();
            this.spinnerWaiting = new MetroFramework.Controls.MetroProgressSpinner();
            this.toolbarUserControl1 = new IMDbAPI_Client.UserControls.ToolbarUserControl();
            this.lblCountry = new MetroFramework.Controls.MetroLabel();
            this.lblCountryTitle = new MetroFramework.Controls.MetroLabel();
            this.lblCompany = new MetroFramework.Controls.MetroLabel();
            this.lblCompanyTitle = new MetroFramework.Controls.MetroLabel();
            this.lblGenre = new MetroFramework.Controls.MetroLabel();
            this.lblGenreTitle = new MetroFramework.Controls.MetroLabel();
            this.lblRuntime = new MetroFramework.Controls.MetroLabel();
            this.lblRuntimeTitle = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).BeginInit();
            this.SuspendLayout();
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // lblFullTitle
            // 
            this.lblFullTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFullTitle.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblFullTitle.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblFullTitle.Location = new System.Drawing.Point(253, 64);
            this.lblFullTitle.Name = "lblFullTitle";
            this.lblFullTitle.Size = new System.Drawing.Size(483, 24);
            this.lblFullTitle.TabIndex = 10;
            this.lblFullTitle.UseStyleColors = true;
            // 
            // lblOriginalTitle
            // 
            this.lblOriginalTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOriginalTitle.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblOriginalTitle.Location = new System.Drawing.Point(253, 96);
            this.lblOriginalTitle.Name = "lblOriginalTitle";
            this.lblOriginalTitle.Size = new System.Drawing.Size(483, 21);
            this.lblOriginalTitle.TabIndex = 11;
            // 
            // lblCreatorsTitle
            // 
            this.lblCreatorsTitle.AutoSize = true;
            this.lblCreatorsTitle.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblCreatorsTitle.Location = new System.Drawing.Point(253, 291);
            this.lblCreatorsTitle.Name = "lblCreatorsTitle";
            this.lblCreatorsTitle.Size = new System.Drawing.Size(66, 19);
            this.lblCreatorsTitle.TabIndex = 12;
            this.lblCreatorsTitle.Text = "Creators";
            this.lblCreatorsTitle.UseStyleColors = true;
            this.lblCreatorsTitle.Visible = false;
            // 
            // txtPlot
            // 
            this.txtPlot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtPlot.CustomButton.Image = null;
            this.txtPlot.CustomButton.Location = new System.Drawing.Point(473, 2);
            this.txtPlot.CustomButton.Name = "";
            this.txtPlot.CustomButton.Size = new System.Drawing.Size(159, 159);
            this.txtPlot.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPlot.CustomButton.TabIndex = 1;
            this.txtPlot.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPlot.CustomButton.UseSelectable = true;
            this.txtPlot.CustomButton.Visible = false;
            this.txtPlot.Lines = new string[0];
            this.txtPlot.Location = new System.Drawing.Point(253, 122);
            this.txtPlot.MaxLength = 32767;
            this.txtPlot.Multiline = true;
            this.txtPlot.Name = "txtPlot";
            this.txtPlot.PasswordChar = '\0';
            this.txtPlot.ReadOnly = true;
            this.txtPlot.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPlot.SelectedText = "";
            this.txtPlot.SelectionLength = 0;
            this.txtPlot.SelectionStart = 0;
            this.txtPlot.ShortcutsEnabled = true;
            this.txtPlot.Size = new System.Drawing.Size(635, 164);
            this.txtPlot.TabIndex = 14;
            this.txtPlot.UseSelectable = true;
            this.txtPlot.Visible = false;
            this.txtPlot.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPlot.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblCreators
            // 
            this.lblCreators.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCreators.Location = new System.Drawing.Point(325, 291);
            this.lblCreators.Name = "lblCreators";
            this.lblCreators.Size = new System.Drawing.Size(563, 19);
            this.lblCreators.TabIndex = 15;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(23, 382);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(865, 214);
            this.flowLayoutPanel1.TabIndex = 20;
            // 
            // picPoster
            // 
            this.picPoster.Location = new System.Drawing.Point(23, 64);
            this.picPoster.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picPoster.Name = "picPoster";
            this.picPoster.Size = new System.Drawing.Size(224, 308);
            this.picPoster.TabIndex = 9;
            this.picPoster.TabStop = false;
            // 
            // btnIMDb
            // 
            this.btnIMDb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIMDb.FlatAppearance.BorderSize = 0;
            this.btnIMDb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIMDb.Image = global::IMDbAPI_Client.Properties.Resources.IMDb;
            this.btnIMDb.Location = new System.Drawing.Point(812, 64);
            this.btnIMDb.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnIMDb.Name = "btnIMDb";
            this.btnIMDb.Size = new System.Drawing.Size(76, 53);
            this.btnIMDb.TabIndex = 22;
            this.btnIMDb.TabStop = false;
            this.btnIMDb.UseVisualStyleBackColor = true;
            this.btnIMDb.Click += new System.EventHandler(this.btnIMDb_Click);
            // 
            // lblWaiting
            // 
            this.lblWaiting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWaiting.AutoSize = true;
            this.lblWaiting.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaiting.ForeColor = System.Drawing.Color.Crimson;
            this.lblWaiting.Location = new System.Drawing.Point(756, 28);
            this.lblWaiting.Name = "lblWaiting";
            this.lblWaiting.Size = new System.Drawing.Size(82, 21);
            this.lblWaiting.TabIndex = 23;
            this.lblWaiting.Text = "Waiting...";
            this.lblWaiting.Visible = false;
            // 
            // spinnerWaiting
            // 
            this.spinnerWaiting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.spinnerWaiting.Location = new System.Drawing.Point(737, 31);
            this.spinnerWaiting.Maximum = 100;
            this.spinnerWaiting.Name = "spinnerWaiting";
            this.spinnerWaiting.Size = new System.Drawing.Size(16, 16);
            this.spinnerWaiting.Style = MetroFramework.MetroColorStyle.Red;
            this.spinnerWaiting.TabIndex = 24;
            this.spinnerWaiting.UseCustomForeColor = true;
            this.spinnerWaiting.UseSelectable = true;
            this.spinnerWaiting.Value = 100;
            this.spinnerWaiting.Visible = false;
            // 
            // toolbarUserControl1
            // 
            this.toolbarUserControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toolbarUserControl1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolbarUserControl1.Location = new System.Drawing.Point(849, 9);
            this.toolbarUserControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.toolbarUserControl1.MinimzeButton = false;
            this.toolbarUserControl1.Name = "toolbarUserControl1";
            this.toolbarUserControl1.Size = new System.Drawing.Size(54, 58);
            this.toolbarUserControl1.TabIndex = 21;
            this.toolbarUserControl1.UseSelectable = true;
            // 
            // lblCountry
            // 
            this.lblCountry.Location = new System.Drawing.Point(325, 314);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(181, 19);
            this.lblCountry.TabIndex = 26;
            // 
            // lblCountryTitle
            // 
            this.lblCountryTitle.AutoSize = true;
            this.lblCountryTitle.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblCountryTitle.Location = new System.Drawing.Point(253, 314);
            this.lblCountryTitle.Name = "lblCountryTitle";
            this.lblCountryTitle.Size = new System.Drawing.Size(63, 19);
            this.lblCountryTitle.TabIndex = 25;
            this.lblCountryTitle.Text = "Country";
            this.lblCountryTitle.UseStyleColors = true;
            this.lblCountryTitle.Visible = false;
            // 
            // lblCompany
            // 
            this.lblCompany.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCompany.Location = new System.Drawing.Point(591, 314);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(297, 19);
            this.lblCompany.TabIndex = 30;
            // 
            // lblCompanyTitle
            // 
            this.lblCompanyTitle.AutoSize = true;
            this.lblCompanyTitle.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblCompanyTitle.Location = new System.Drawing.Point(512, 314);
            this.lblCompanyTitle.Name = "lblCompanyTitle";
            this.lblCompanyTitle.Size = new System.Drawing.Size(73, 19);
            this.lblCompanyTitle.TabIndex = 29;
            this.lblCompanyTitle.Text = "Company";
            this.lblCompanyTitle.UseStyleColors = true;
            this.lblCompanyTitle.Visible = false;
            // 
            // lblGenre
            // 
            this.lblGenre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGenre.Location = new System.Drawing.Point(591, 337);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(297, 19);
            this.lblGenre.TabIndex = 34;
            // 
            // lblGenreTitle
            // 
            this.lblGenreTitle.AutoSize = true;
            this.lblGenreTitle.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblGenreTitle.Location = new System.Drawing.Point(512, 337);
            this.lblGenreTitle.Name = "lblGenreTitle";
            this.lblGenreTitle.Size = new System.Drawing.Size(49, 19);
            this.lblGenreTitle.TabIndex = 33;
            this.lblGenreTitle.Text = "Genre";
            this.lblGenreTitle.UseStyleColors = true;
            this.lblGenreTitle.Visible = false;
            // 
            // lblRuntime
            // 
            this.lblRuntime.Location = new System.Drawing.Point(325, 337);
            this.lblRuntime.Name = "lblRuntime";
            this.lblRuntime.Size = new System.Drawing.Size(181, 19);
            this.lblRuntime.TabIndex = 32;
            // 
            // lblRuntimeTitle
            // 
            this.lblRuntimeTitle.AutoSize = true;
            this.lblRuntimeTitle.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblRuntimeTitle.Location = new System.Drawing.Point(253, 337);
            this.lblRuntimeTitle.Name = "lblRuntimeTitle";
            this.lblRuntimeTitle.Size = new System.Drawing.Size(64, 19);
            this.lblRuntimeTitle.TabIndex = 31;
            this.lblRuntimeTitle.Text = "Runtime";
            this.lblRuntimeTitle.UseStyleColors = true;
            this.lblRuntimeTitle.Visible = false;
            // 
            // MoreInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 619);
            this.ControlBox = false;
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblGenreTitle);
            this.Controls.Add(this.lblRuntime);
            this.Controls.Add(this.lblRuntimeTitle);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.lblCompanyTitle);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblCountryTitle);
            this.Controls.Add(this.spinnerWaiting);
            this.Controls.Add(this.lblWaiting);
            this.Controls.Add(this.btnIMDb);
            this.Controls.Add(this.toolbarUserControl1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lblCreators);
            this.Controls.Add(this.txtPlot);
            this.Controls.Add(this.lblCreatorsTitle);
            this.Controls.Add(this.lblOriginalTitle);
            this.Controls.Add(this.lblFullTitle);
            this.Controls.Add(this.picPoster);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(911, 619);
            this.Name = "MoreInfoForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MoreInfoForm_Load);
            this.Shown += new System.EventHandler(this.MoreInfoForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private System.Windows.Forms.PictureBox picPoster;
        private MetroFramework.Controls.MetroLabel lblFullTitle;
        private MetroFramework.Controls.MetroLabel lblCreatorsTitle;
        private MetroFramework.Controls.MetroLabel lblOriginalTitle;
        private MetroFramework.Controls.MetroTextBox txtPlot;
        private MetroFramework.Controls.MetroLabel lblCreators;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private UserControls.ToolbarUserControl toolbarUserControl1;
        private System.Windows.Forms.Button btnIMDb;
        private System.Windows.Forms.Label lblWaiting;
        private MetroFramework.Controls.MetroProgressSpinner spinnerWaiting;
        private MetroFramework.Controls.MetroLabel lblCountry;
        private MetroFramework.Controls.MetroLabel lblCountryTitle;
        private MetroFramework.Controls.MetroLabel lblCompany;
        private MetroFramework.Controls.MetroLabel lblCompanyTitle;
        private MetroFramework.Controls.MetroLabel lblGenre;
        private MetroFramework.Controls.MetroLabel lblGenreTitle;
        private MetroFramework.Controls.MetroLabel lblRuntime;
        private MetroFramework.Controls.MetroLabel lblRuntimeTitle;
    }
}