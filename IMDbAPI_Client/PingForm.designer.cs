namespace IMDbAPI_Client
{
    partial class PingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PingForm));
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.lblFullTitle = new MetroFramework.Controls.MetroLabel();
            this.lblOriginalTitle = new MetroFramework.Controls.MetroLabel();
            this.lblWaiting = new System.Windows.Forms.Label();
            this.spinnerWaiting = new MetroFramework.Controls.MetroProgressSpinner();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.toolbarUserControl1 = new IMDbAPI_Client.UserControls.ToolbarUserControl();
            this.lblMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
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
            this.lblFullTitle.Size = new System.Drawing.Size(26, 24);
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
            this.lblOriginalTitle.Size = new System.Drawing.Size(26, 21);
            this.lblOriginalTitle.TabIndex = 11;
            // 
            // lblWaiting
            // 
            this.lblWaiting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWaiting.AutoSize = true;
            this.lblWaiting.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaiting.ForeColor = System.Drawing.Color.Crimson;
            this.lblWaiting.Location = new System.Drawing.Point(299, 28);
            this.lblWaiting.Name = "lblWaiting";
            this.lblWaiting.Size = new System.Drawing.Size(82, 21);
            this.lblWaiting.TabIndex = 23;
            this.lblWaiting.Text = "Waiting...";
            this.lblWaiting.Visible = false;
            // 
            // spinnerWaiting
            // 
            this.spinnerWaiting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.spinnerWaiting.Location = new System.Drawing.Point(280, 31);
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
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(312, 446);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 49);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "&CLOSE";
            this.btnCancel.UseCustomBackColor = true;
            this.btnCancel.UseCustomForeColor = true;
            this.btnCancel.UseSelectable = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(23, 64);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(408, 376);
            this.flowLayoutPanel1.TabIndex = 26;
            // 
            // toolbarUserControl1
            // 
            this.toolbarUserControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toolbarUserControl1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolbarUserControl1.Location = new System.Drawing.Point(392, 9);
            this.toolbarUserControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.toolbarUserControl1.MinimzeButton = false;
            this.toolbarUserControl1.Name = "toolbarUserControl1";
            this.toolbarUserControl1.Size = new System.Drawing.Size(54, 58);
            this.toolbarUserControl1.TabIndex = 21;
            this.toolbarUserControl1.UseSelectable = true;
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(23, 446);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(283, 19);
            this.lblMessage.TabIndex = 28;
            this.lblMessage.Text = "...";
            // 
            // PingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(454, 518);
            this.ControlBox = false;
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.spinnerWaiting);
            this.Controls.Add(this.lblWaiting);
            this.Controls.Add(this.toolbarUserControl1);
            this.Controls.Add(this.lblOriginalTitle);
            this.Controls.Add(this.lblFullTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PingForm";
            this.Text = "Ping...";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.PingForm_Load);
            this.Shown += new System.EventHandler(this.PingForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroLabel lblFullTitle;
        private MetroFramework.Controls.MetroLabel lblOriginalTitle;
        private UserControls.ToolbarUserControl toolbarUserControl1;
        private System.Windows.Forms.Label lblWaiting;
        private MetroFramework.Controls.MetroProgressSpinner spinnerWaiting;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroButton btnCancel;
        private System.Windows.Forms.Label lblMessage;
    }
}