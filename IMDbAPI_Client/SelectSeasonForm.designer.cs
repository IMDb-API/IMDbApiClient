namespace IMDbAPI_Client
{
    partial class SelectSeasonForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectSeasonForm));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.ddlSeasons = new MetroFramework.Controls.MetroComboBox();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.toolbarUserControl1 = new IMDbAPI_Client.UserControls.ToolbarUserControl();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnOK = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(29, 117);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(242, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Download Subtitles for Season";
            this.metroLabel1.UseStyleColors = true;
            // 
            // ddlSeasons
            // 
            this.ddlSeasons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ddlSeasons.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.ddlSeasons.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.ddlSeasons.FormattingEnabled = true;
            this.ddlSeasons.ItemHeight = 29;
            this.ddlSeasons.Location = new System.Drawing.Point(277, 112);
            this.ddlSeasons.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ddlSeasons.Name = "ddlSeasons";
            this.ddlSeasons.Size = new System.Drawing.Size(188, 35);
            this.ddlSeasons.TabIndex = 1;
            this.ddlSeasons.UseSelectable = true;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // toolbarUserControl1
            // 
            this.toolbarUserControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toolbarUserControl1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolbarUserControl1.Location = new System.Drawing.Point(378, 10);
            this.toolbarUserControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.toolbarUserControl1.MinimzeButton = false;
            this.toolbarUserControl1.Name = "toolbarUserControl1";
            this.toolbarUserControl1.Size = new System.Drawing.Size(108, 62);
            this.toolbarUserControl1.TabIndex = 23;
            this.toolbarUserControl1.UseSelectable = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(221, 198);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 49);
            this.btnCancel.TabIndex = 26;
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
            this.btnOK.Location = new System.Drawing.Point(346, 198);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(119, 49);
            this.btnOK.TabIndex = 25;
            this.btnOK.Text = "&OK";
            this.btnOK.UseCustomBackColor = true;
            this.btnOK.UseCustomForeColor = true;
            this.btnOK.UseSelectable = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // SelectSeasonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(493, 276);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.toolbarUserControl1);
            this.Controls.Add(this.ddlSeasons);
            this.Controls.Add(this.metroLabel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(493, 276);
            this.Name = "SelectSeasonForm";
            this.Padding = new System.Windows.Forms.Padding(23, 79, 23, 27);
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SelectSeasonForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox ddlSeasons;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private UserControls.ToolbarUserControl toolbarUserControl1;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton btnOK;
    }
}