namespace IMDbAPI_Client.UserControls
{
    partial class ToolbarUserControl
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
            this.btnToolMinimize = new System.Windows.Forms.Button();
            this.btnToolExit = new System.Windows.Forms.Button();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // btnToolMinimize
            // 
            this.btnToolMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToolMinimize.FlatAppearance.BorderSize = 0;
            this.btnToolMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToolMinimize.Image = global::IMDbAPI_Client.Properties.Resources.Minimize;
            this.btnToolMinimize.Location = new System.Drawing.Point(6, 4);
            this.btnToolMinimize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnToolMinimize.Name = "btnToolMinimize";
            this.btnToolMinimize.Size = new System.Drawing.Size(47, 52);
            this.btnToolMinimize.TabIndex = 5;
            this.btnToolMinimize.TabStop = false;
            this.metroToolTip1.SetToolTip(this.btnToolMinimize, "Minimize");
            this.btnToolMinimize.UseVisualStyleBackColor = true;
            this.btnToolMinimize.Click += new System.EventHandler(this.btnToolMinimize_Click);
            // 
            // btnToolExit
            // 
            this.btnToolExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToolExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnToolExit.FlatAppearance.BorderSize = 0;
            this.btnToolExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToolExit.Image = global::IMDbAPI_Client.Properties.Resources.Exit;
            this.btnToolExit.Location = new System.Drawing.Point(57, 4);
            this.btnToolExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnToolExit.Name = "btnToolExit";
            this.btnToolExit.Size = new System.Drawing.Size(47, 52);
            this.btnToolExit.TabIndex = 4;
            this.btnToolExit.TabStop = false;
            this.metroToolTip1.SetToolTip(this.btnToolExit, "Exit");
            this.btnToolExit.UseVisualStyleBackColor = true;
            this.btnToolExit.Click += new System.EventHandler(this.btnToolExit_Click);
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // ToolbarUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnToolMinimize);
            this.Controls.Add(this.btnToolExit);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ToolbarUserControl";
            this.Size = new System.Drawing.Size(108, 62);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnToolMinimize;
        private System.Windows.Forms.Button btnToolExit;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
    }
}
