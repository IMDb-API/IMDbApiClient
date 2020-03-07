namespace IMDbAPI_Client.UserControls
{
    partial class PingItemUserControl
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
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.lnkUrl = new MetroFramework.Controls.MetroLink();
            this.picPassed = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPassed)).BeginInit();
            this.SuspendLayout();
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // lnkUrl
            // 
            this.lnkUrl.Location = new System.Drawing.Point(3, 7);
            this.lnkUrl.Name = "lnkUrl";
            this.lnkUrl.Size = new System.Drawing.Size(323, 23);
            this.lnkUrl.TabIndex = 0;
            this.lnkUrl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkUrl.UseSelectable = true;
            // 
            // picPassed
            // 
            this.picPassed.Location = new System.Drawing.Point(332, 2);
            this.picPassed.Name = "picPassed";
            this.picPassed.Size = new System.Drawing.Size(45, 34);
            this.picPassed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPassed.TabIndex = 1;
            this.picPassed.TabStop = false;
            // 
            // PingItemUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picPassed);
            this.Controls.Add(this.lnkUrl);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PingItemUserControl";
            this.Size = new System.Drawing.Size(383, 38);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPassed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private MetroFramework.Controls.MetroLink lnkUrl;
        private System.Windows.Forms.PictureBox picPassed;
    }
}
