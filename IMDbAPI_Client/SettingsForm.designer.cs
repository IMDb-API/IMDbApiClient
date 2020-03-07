namespace IMDbAPI_Client
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabRemoveSiteName = new MetroFramework.Controls.MetroTabPage();
            this.txtRemoveSiteName = new MetroFramework.Controls.MetroTextBox();
            this.tabOptions = new MetroFramework.Controls.MetroTabPage();
            this.tabOthers = new MetroFramework.Controls.MetroTabPage();
            this.pnlStyleViewer = new System.Windows.Forms.Panel();
            this.lblStyleContent = new System.Windows.Forms.Label();
            this.lblStyleTitle = new System.Windows.Forms.Label();
            this.ddlStyle = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.ddlTheme = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.toolbarUserControl1 = new IMDbAPI_Client.UserControls.ToolbarUserControl();
            this.btnOK = new MetroFramework.Controls.MetroButton();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.metroTabControl1.SuspendLayout();
            this.tabRemoveSiteName.SuspendLayout();
            this.tabOthers.SuspendLayout();
            this.pnlStyleViewer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTabControl1.Controls.Add(this.tabOptions);
            this.metroTabControl1.Controls.Add(this.tabRemoveSiteName);
            this.metroTabControl1.Controls.Add(this.tabOthers);
            this.metroTabControl1.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.metroTabControl1.FontWeight = MetroFramework.MetroTabControlWeight.Regular;
            this.metroTabControl1.Location = new System.Drawing.Point(27, 83);
            this.metroTabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(878, 513);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            this.metroTabControl1.UseStyleColors = true;
            // 
            // tabRemoveSiteName
            // 
            this.tabRemoveSiteName.Controls.Add(this.txtRemoveSiteName);
            this.tabRemoveSiteName.HorizontalScrollbarBarColor = true;
            this.tabRemoveSiteName.HorizontalScrollbarHighlightOnWheel = false;
            this.tabRemoveSiteName.HorizontalScrollbarSize = 2;
            this.tabRemoveSiteName.Location = new System.Drawing.Point(4, 44);
            this.tabRemoveSiteName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabRemoveSiteName.Name = "tabRemoveSiteName";
            this.tabRemoveSiteName.Size = new System.Drawing.Size(870, 465);
            this.tabRemoveSiteName.TabIndex = 1;
            this.tabRemoveSiteName.Text = "Remove site name from filename";
            this.tabRemoveSiteName.VerticalScrollbarBarColor = true;
            this.tabRemoveSiteName.VerticalScrollbarHighlightOnWheel = false;
            this.tabRemoveSiteName.VerticalScrollbarSize = 3;
            // 
            // txtRemoveSiteName
            // 
            this.txtRemoveSiteName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtRemoveSiteName.CustomButton.Image = null;
            this.txtRemoveSiteName.CustomButton.Location = new System.Drawing.Point(434, 2);
            this.txtRemoveSiteName.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRemoveSiteName.CustomButton.Name = "";
            this.txtRemoveSiteName.CustomButton.Size = new System.Drawing.Size(417, 417);
            this.txtRemoveSiteName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRemoveSiteName.CustomButton.TabIndex = 1;
            this.txtRemoveSiteName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRemoveSiteName.CustomButton.UseSelectable = true;
            this.txtRemoveSiteName.CustomButton.Visible = false;
            this.txtRemoveSiteName.Lines = new string[0];
            this.txtRemoveSiteName.Location = new System.Drawing.Point(7, 7);
            this.txtRemoveSiteName.MaxLength = 32767;
            this.txtRemoveSiteName.Multiline = true;
            this.txtRemoveSiteName.Name = "txtRemoveSiteName";
            this.txtRemoveSiteName.PasswordChar = '\0';
            this.txtRemoveSiteName.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtRemoveSiteName.SelectedText = "";
            this.txtRemoveSiteName.SelectionLength = 0;
            this.txtRemoveSiteName.SelectionStart = 0;
            this.txtRemoveSiteName.ShortcutsEnabled = true;
            this.txtRemoveSiteName.Size = new System.Drawing.Size(854, 422);
            this.txtRemoveSiteName.TabIndex = 2;
            this.txtRemoveSiteName.UseSelectable = true;
            this.txtRemoveSiteName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRemoveSiteName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tabOptions
            // 
            this.tabOptions.HorizontalScrollbarBarColor = true;
            this.tabOptions.HorizontalScrollbarHighlightOnWheel = false;
            this.tabOptions.HorizontalScrollbarSize = 2;
            this.tabOptions.Location = new System.Drawing.Point(4, 44);
            this.tabOptions.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabOptions.Name = "tabOptions";
            this.tabOptions.Size = new System.Drawing.Size(870, 465);
            this.tabOptions.TabIndex = 0;
            this.tabOptions.Text = "Options";
            this.tabOptions.VerticalScrollbarBarColor = true;
            this.tabOptions.VerticalScrollbarHighlightOnWheel = false;
            this.tabOptions.VerticalScrollbarSize = 3;
            // 
            // tabOthers
            // 
            this.tabOthers.Controls.Add(this.pnlStyleViewer);
            this.tabOthers.Controls.Add(this.ddlStyle);
            this.tabOthers.Controls.Add(this.metroLabel2);
            this.tabOthers.Controls.Add(this.ddlTheme);
            this.tabOthers.Controls.Add(this.metroLabel1);
            this.tabOthers.HorizontalScrollbarBarColor = true;
            this.tabOthers.HorizontalScrollbarHighlightOnWheel = false;
            this.tabOthers.HorizontalScrollbarSize = 2;
            this.tabOthers.Location = new System.Drawing.Point(4, 44);
            this.tabOthers.Name = "tabOthers";
            this.tabOthers.Size = new System.Drawing.Size(870, 465);
            this.tabOthers.TabIndex = 2;
            this.tabOthers.Text = "Others";
            this.tabOthers.VerticalScrollbarBarColor = true;
            this.tabOthers.VerticalScrollbarHighlightOnWheel = false;
            this.tabOthers.VerticalScrollbarSize = 3;
            // 
            // pnlStyleViewer
            // 
            this.pnlStyleViewer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlStyleViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStyleViewer.Controls.Add(this.lblStyleContent);
            this.pnlStyleViewer.Controls.Add(this.lblStyleTitle);
            this.pnlStyleViewer.Location = new System.Drawing.Point(331, 75);
            this.pnlStyleViewer.Name = "pnlStyleViewer";
            this.pnlStyleViewer.Size = new System.Drawing.Size(456, 248);
            this.pnlStyleViewer.TabIndex = 16;
            // 
            // lblStyleContent
            // 
            this.lblStyleContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStyleContent.Location = new System.Drawing.Point(23, 52);
            this.lblStyleContent.Name = "lblStyleContent";
            this.lblStyleContent.Size = new System.Drawing.Size(403, 167);
            this.lblStyleContent.TabIndex = 1;
            this.lblStyleContent.Text = resources.GetString("lblStyleContent.Text");
            // 
            // lblStyleTitle
            // 
            this.lblStyleTitle.AutoSize = true;
            this.lblStyleTitle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStyleTitle.Location = new System.Drawing.Point(23, 14);
            this.lblStyleTitle.Name = "lblStyleTitle";
            this.lblStyleTitle.Size = new System.Drawing.Size(138, 19);
            this.lblStyleTitle.TabIndex = 0;
            this.lblStyleTitle.Text = "Title of Content";
            // 
            // ddlStyle
            // 
            this.ddlStyle.FormattingEnabled = true;
            this.ddlStyle.ItemHeight = 23;
            this.ddlStyle.Location = new System.Drawing.Point(104, 239);
            this.ddlStyle.Name = "ddlStyle";
            this.ddlStyle.Size = new System.Drawing.Size(151, 29);
            this.ddlStyle.TabIndex = 15;
            this.ddlStyle.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(104, 214);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(42, 19);
            this.metroLabel2.TabIndex = 14;
            this.metroLabel2.Text = "Style";
            this.metroLabel2.UseStyleColors = true;
            // 
            // ddlTheme
            // 
            this.ddlTheme.FormattingEnabled = true;
            this.ddlTheme.ItemHeight = 23;
            this.ddlTheme.Location = new System.Drawing.Point(104, 134);
            this.ddlTheme.Name = "ddlTheme";
            this.ddlTheme.Size = new System.Drawing.Size(151, 29);
            this.ddlTheme.TabIndex = 13;
            this.ddlTheme.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(104, 108);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(54, 19);
            this.metroLabel1.TabIndex = 12;
            this.metroLabel1.Text = "Theme";
            this.metroLabel1.UseStyleColors = true;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // toolbarUserControl1
            // 
            this.toolbarUserControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toolbarUserControl1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolbarUserControl1.Location = new System.Drawing.Point(814, 10);
            this.toolbarUserControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.toolbarUserControl1.MinimzeButton = false;
            this.toolbarUserControl1.Name = "toolbarUserControl1";
            this.toolbarUserControl1.Size = new System.Drawing.Size(108, 62);
            this.toolbarUserControl1.TabIndex = 22;
            this.toolbarUserControl1.UseSelectable = true;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(779, 599);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(119, 49);
            this.btnOK.TabIndex = 23;
            this.btnOK.Text = "&OK";
            this.btnOK.UseCustomBackColor = true;
            this.btnOK.UseCustomForeColor = true;
            this.btnOK.UseSelectable = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(654, 599);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 49);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "&CANCEL";
            this.btnCancel.UseCustomBackColor = true;
            this.btnCancel.UseCustomForeColor = true;
            this.btnCancel.UseSelectable = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(931, 679);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.toolbarUserControl1);
            this.Controls.Add(this.metroTabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(931, 679);
            this.Name = "SettingsForm";
            this.Padding = new System.Windows.Forms.Padding(23, 79, 23, 27);
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.tabRemoveSiteName.ResumeLayout(false);
            this.tabOthers.ResumeLayout(false);
            this.tabOthers.PerformLayout();
            this.pnlStyleViewer.ResumeLayout(false);
            this.pnlStyleViewer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage tabOptions;
        private MetroFramework.Controls.MetroTabPage tabRemoveSiteName;
        private MetroFramework.Controls.MetroTextBox txtRemoveSiteName;
        private MetroFramework.Controls.MetroTabPage tabOthers;
        private MetroFramework.Controls.MetroComboBox ddlTheme;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox ddlStyle;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private UserControls.ToolbarUserControl toolbarUserControl1;
        private System.Windows.Forms.Panel pnlStyleViewer;
        private System.Windows.Forms.Label lblStyleContent;
        private System.Windows.Forms.Label lblStyleTitle;
        private MetroFramework.Controls.MetroButton btnOK;
        private MetroFramework.Controls.MetroButton btnCancel;
    }
}