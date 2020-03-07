namespace IMDbAPI_Client.UserControls
{
    partial class CastUserControl
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
            this.lblCastName = new MetroFramework.Controls.MetroLabel();
            this.lblCastAsCharacter = new MetroFramework.Controls.MetroLabel();
            this.picCastImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCastImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCastName
            // 
            this.lblCastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCastName.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblCastName.Location = new System.Drawing.Point(3, 147);
            this.lblCastName.Name = "lblCastName";
            this.lblCastName.Size = new System.Drawing.Size(130, 19);
            this.lblCastName.TabIndex = 16;
            this.lblCastName.Text = "-";
            this.lblCastName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblCastName.UseStyleColors = true;
            // 
            // lblCastAsCharacter
            // 
            this.lblCastAsCharacter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCastAsCharacter.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblCastAsCharacter.Location = new System.Drawing.Point(3, 169);
            this.lblCastAsCharacter.Name = "lblCastAsCharacter";
            this.lblCastAsCharacter.Size = new System.Drawing.Size(130, 21);
            this.lblCastAsCharacter.TabIndex = 17;
            this.lblCastAsCharacter.Text = "-";
            this.lblCastAsCharacter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picCastImage
            // 
            this.picCastImage.Location = new System.Drawing.Point(22, 12);
            this.picCastImage.Name = "picCastImage";
            this.picCastImage.Size = new System.Drawing.Size(96, 132);
            this.picCastImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCastImage.TabIndex = 15;
            this.picCastImage.TabStop = false;
            // 
            // CastUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCastName);
            this.Controls.Add(this.lblCastAsCharacter);
            this.Controls.Add(this.picCastImage);
            this.Name = "CastUserControl";
            this.Size = new System.Drawing.Size(136, 205);
            ((System.ComponentModel.ISupportInitialize)(this.picCastImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblCastName;
        private MetroFramework.Controls.MetroLabel lblCastAsCharacter;
        private System.Windows.Forms.PictureBox picCastImage;
    }
}
