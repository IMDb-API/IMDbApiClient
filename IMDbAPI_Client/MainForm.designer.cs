namespace IMDbAPI_Client
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlCommands = new MetroFramework.Controls.MetroPanel();
            this.btnPing = new MetroFramework.Controls.MetroButton();
            this.btnSettings = new MetroFramework.Controls.MetroButton();
            this.btnPrevious = new MetroFramework.Controls.MetroButton();
            this.btnNext = new MetroFramework.Controls.MetroButton();
            this.pnlUserControl = new MetroFramework.Controls.MetroPanel();
            this.lblTitle = new MetroFramework.Controls.MetroLabel();
            this.lblWaiting = new System.Windows.Forms.Label();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.spinnerWaiting = new MetroFramework.Controls.MetroProgressSpinner();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnVersion = new MetroFramework.Controls.MetroButton();
            this.toolbarUserControl1 = new IMDbAPI_Client.UserControls.ToolbarUserControl();
            this.pnlCommands.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCommands
            // 
            this.pnlCommands.Controls.Add(this.btnVersion);
            this.pnlCommands.Controls.Add(this.btnPing);
            this.pnlCommands.Controls.Add(this.btnSettings);
            this.pnlCommands.Controls.Add(this.btnPrevious);
            this.pnlCommands.Controls.Add(this.btnNext);
            this.pnlCommands.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlCommands.HorizontalScrollbarBarColor = true;
            this.pnlCommands.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlCommands.HorizontalScrollbarSize = 11;
            this.pnlCommands.Location = new System.Drawing.Point(23, 518);
            this.pnlCommands.Name = "pnlCommands";
            this.pnlCommands.Size = new System.Drawing.Size(870, 72);
            this.pnlCommands.TabIndex = 0;
            this.pnlCommands.VerticalScrollbarBarColor = true;
            this.pnlCommands.VerticalScrollbarHighlightOnWheel = false;
            this.pnlCommands.VerticalScrollbarSize = 10;
            // 
            // btnPing
            // 
            this.btnPing.Location = new System.Drawing.Point(141, 12);
            this.btnPing.Name = "btnPing";
            this.btnPing.Size = new System.Drawing.Size(119, 49);
            this.btnPing.TabIndex = 2;
            this.btnPing.Text = "&PING";
            this.btnPing.UseSelectable = true;
            this.btnPing.Click += new System.EventHandler(this.btnPing_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(16, 12);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(119, 49);
            this.btnSettings.TabIndex = 2;
            this.btnSettings.Text = "&SETTINGS";
            this.btnSettings.UseSelectable = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrevious.Location = new System.Drawing.Point(610, 12);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(119, 49);
            this.btnPrevious.TabIndex = 0;
            this.btnPrevious.Text = "&PREVIOUS";
            this.btnPrevious.UseSelectable = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Location = new System.Drawing.Point(735, 12);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(119, 49);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "&NEXT";
            this.btnNext.UseSelectable = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // pnlUserControl
            // 
            this.pnlUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUserControl.HorizontalScrollbarBarColor = true;
            this.pnlUserControl.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlUserControl.HorizontalScrollbarSize = 11;
            this.pnlUserControl.Location = new System.Drawing.Point(23, 79);
            this.pnlUserControl.Name = "pnlUserControl";
            this.pnlUserControl.Size = new System.Drawing.Size(870, 439);
            this.pnlUserControl.TabIndex = 1;
            this.pnlUserControl.VerticalScrollbarBarColor = true;
            this.pnlUserControl.VerticalScrollbarHighlightOnWheel = false;
            this.pnlUserControl.VerticalScrollbarSize = 10;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTitle.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblTitle.Location = new System.Drawing.Point(201, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(478, 41);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Step";
            this.lblTitle.UseStyleColors = true;
            // 
            // lblWaiting
            // 
            this.lblWaiting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWaiting.AutoSize = true;
            this.lblWaiting.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaiting.ForeColor = System.Drawing.Color.Crimson;
            this.lblWaiting.Location = new System.Drawing.Point(707, 30);
            this.lblWaiting.Name = "lblWaiting";
            this.lblWaiting.Size = new System.Drawing.Size(82, 21);
            this.lblWaiting.TabIndex = 5;
            this.lblWaiting.Text = "Waiting...";
            this.lblWaiting.Visible = false;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // spinnerWaiting
            // 
            this.spinnerWaiting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.spinnerWaiting.Location = new System.Drawing.Point(688, 32);
            this.spinnerWaiting.Maximum = 100;
            this.spinnerWaiting.Name = "spinnerWaiting";
            this.spinnerWaiting.Size = new System.Drawing.Size(16, 17);
            this.spinnerWaiting.Style = MetroFramework.MetroColorStyle.Red;
            this.spinnerWaiting.TabIndex = 8;
            this.spinnerWaiting.UseCustomForeColor = true;
            this.spinnerWaiting.UseSelectable = true;
            this.spinnerWaiting.Value = 100;
            this.spinnerWaiting.Visible = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.Location = new System.Drawing.Point(23, 55);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(184, 15);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "A free client app for IMDb-API.com";
            // 
            // btnVersion
            // 
            this.btnVersion.Location = new System.Drawing.Point(266, 12);
            this.btnVersion.Name = "btnVersion";
            this.btnVersion.Size = new System.Drawing.Size(119, 49);
            this.btnVersion.TabIndex = 3;
            this.btnVersion.Text = "v0.0";
            this.btnVersion.UseSelectable = true;
            this.btnVersion.Click += new System.EventHandler(this.btnVersion_Click);
            this.btnVersion.MouseEnter += new System.EventHandler(this.btnVersion_MouseEnter);
            this.btnVersion.MouseLeave += new System.EventHandler(this.btnVersion_MouseLeave);
            // 
            // toolbarUserControl1
            // 
            this.toolbarUserControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toolbarUserControl1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolbarUserControl1.Location = new System.Drawing.Point(800, 10);
            this.toolbarUserControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.toolbarUserControl1.Name = "toolbarUserControl1";
            this.toolbarUserControl1.Size = new System.Drawing.Size(108, 62);
            this.toolbarUserControl1.TabIndex = 6;
            this.toolbarUserControl1.UseSelectable = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 617);
            this.ControlBox = false;
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.spinnerWaiting);
            this.Controls.Add(this.lblWaiting);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.toolbarUserControl1);
            this.Controls.Add(this.pnlUserControl);
            this.Controls.Add(this.pnlCommands);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(916, 617);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(23, 79, 23, 27);
            this.Text = "IMDb API Client";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlCommands.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroPanel pnlCommands;
        private MetroFramework.Controls.MetroPanel pnlUserControl;
        private MetroFramework.Controls.MetroButton btnNext;
        private MetroFramework.Controls.MetroButton btnPrevious;
        private MetroFramework.Controls.MetroButton btnSettings;
        private UserControls.ToolbarUserControl toolbarUserControl1;
        private MetroFramework.Controls.MetroLabel lblTitle;
        private System.Windows.Forms.Label lblWaiting;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroProgressSpinner spinnerWaiting;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnPing;
        private MetroFramework.Controls.MetroButton btnVersion;
    }
}