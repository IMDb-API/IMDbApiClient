namespace IMDbAPI_Client.UserControls
{
    partial class Step4_DownloadUC
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
            this.progressTotal = new MetroFramework.Controls.MetroProgressBar();
            this.progressCurrentJob = new MetroFramework.Controls.MetroProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalProgress = new System.Windows.Forms.Label();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            this.ddlWhenDone = new MetroFramework.Controls.MetroComboBox();
            this.lblWhenDone = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // progressTotal
            // 
            this.progressTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressTotal.HideProgressText = false;
            this.progressTotal.Location = new System.Drawing.Point(65, 69);
            this.progressTotal.Name = "progressTotal";
            this.progressTotal.Size = new System.Drawing.Size(751, 72);
            this.progressTotal.TabIndex = 4;
            // 
            // progressCurrentJob
            // 
            this.progressCurrentJob.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressCurrentJob.HideProgressText = false;
            this.progressCurrentJob.Location = new System.Drawing.Point(65, 196);
            this.progressCurrentJob.Name = "progressCurrentJob";
            this.progressCurrentJob.Size = new System.Drawing.Size(751, 72);
            this.progressCurrentJob.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "TOTAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "CURRENT";
            // 
            // lblTotalProgress
            // 
            this.lblTotalProgress.AutoSize = true;
            this.lblTotalProgress.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProgress.Location = new System.Drawing.Point(179, 45);
            this.lblTotalProgress.Name = "lblTotalProgress";
            this.lblTotalProgress.Size = new System.Drawing.Size(24, 19);
            this.lblTotalProgress.TabIndex = 7;
            this.lblTotalProgress.Text = "...";
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrent.Location = new System.Drawing.Point(179, 172);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(24, 19);
            this.lblCurrent.TabIndex = 9;
            this.lblCurrent.Text = "...";
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(77)))), ((int)(((byte)(95)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(77)))), ((int)(((byte)(65)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(697, 323);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 46);
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Text = "&CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ddlWhenDone
            // 
            this.ddlWhenDone.FormattingEnabled = true;
            this.ddlWhenDone.ItemHeight = 23;
            this.ddlWhenDone.Items.AddRange(new object[] {
            "Keep PC Running",
            "Shutdown [On Successfull]",
            "Shutdown [Anyway]"});
            this.ddlWhenDone.Location = new System.Drawing.Point(65, 340);
            this.ddlWhenDone.Name = "ddlWhenDone";
            this.ddlWhenDone.Size = new System.Drawing.Size(206, 29);
            this.ddlWhenDone.TabIndex = 30;
            this.ddlWhenDone.UseSelectable = true;
            // 
            // lblWhenDone
            // 
            this.lblWhenDone.AutoSize = true;
            this.lblWhenDone.BackColor = System.Drawing.Color.Transparent;
            this.lblWhenDone.Location = new System.Drawing.Point(62, 319);
            this.lblWhenDone.Name = "lblWhenDone";
            this.lblWhenDone.Size = new System.Drawing.Size(73, 16);
            this.lblWhenDone.TabIndex = 31;
            this.lblWhenDone.Text = "When done";
            // 
            // Step4_DownloadUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblWhenDone);
            this.Controls.Add(this.ddlWhenDone);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblCurrent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTotalProgress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressCurrentJob);
            this.Controls.Add(this.progressTotal);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Step4_DownloadUC";
            this.Size = new System.Drawing.Size(870, 414);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroProgressBar progressTotal;
        private MetroFramework.Controls.MetroProgressBar progressCurrentJob;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalProgress;
        private System.Windows.Forms.Label lblCurrent;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private System.Windows.Forms.Button btnCancel;
        private MetroFramework.Controls.MetroComboBox ddlWhenDone;
        private System.Windows.Forms.Label lblWhenDone;
    }
}
