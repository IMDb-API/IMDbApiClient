namespace IMDbAPI_Client
{
    partial class ShutdownForm
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
            this.progress = new MetroFramework.Controls.MetroProgressBar();
            this.lblShutdownTitle = new MetroFramework.Controls.MetroLabel();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // progress
            // 
            this.progress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progress.Location = new System.Drawing.Point(35, 130);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(751, 76);
            this.progress.TabIndex = 7;
            // 
            // lblShutdownTitle
            // 
            this.lblShutdownTitle.AutoSize = true;
            this.lblShutdownTitle.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblShutdownTitle.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblShutdownTitle.Location = new System.Drawing.Point(35, 97);
            this.lblShutdownTitle.Name = "lblShutdownTitle";
            this.lblShutdownTitle.Size = new System.Drawing.Size(303, 25);
            this.lblShutdownTitle.TabIndex = 8;
            this.lblShutdownTitle.Text = "Shutting down PC after 60 seconds...";
            this.lblShutdownTitle.UseStyleColors = true;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(77)))), ((int)(((byte)(95)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(77)))), ((int)(((byte)(65)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(667, 238);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 49);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "&CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ShutdownForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(822, 317);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblShutdownTitle);
            this.Controls.Add(this.progress);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(822, 317);
            this.Name = "ShutdownForm";
            this.Padding = new System.Windows.Forms.Padding(23, 79, 23, 27);
            this.Resizable = false;
            this.Text = "Shutting down...";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ShutdownForm_Load);
            this.Shown += new System.EventHandler(this.ShutdownForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroProgressBar progress;
        private MetroFramework.Controls.MetroLabel lblShutdownTitle;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Timer timer1;
    }
}