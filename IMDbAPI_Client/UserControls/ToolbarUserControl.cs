using MetroFramework.Controls;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace IMDbAPI_Client.UserControls
{
    public partial class ToolbarUserControl : MetroUserControl
    {
        public ToolbarUserControl()
        {
            InitializeComponent();

            MinimzeButton = true;
        }

        [DefaultValue(true)]
        public bool MinimzeButton
        {
            set => btnToolMinimize.Visible = value;
            get => btnToolMinimize.Visible;
        }

        private void btnToolExit_Click(object sender, EventArgs e)
        {
            if (ParentForm.GetType() == typeof(MainForm))
                Application.Exit();
            else
                ParentForm.Close();
        }

        private void btnToolMinimize_Click(object sender, EventArgs e)
        {
            ParentForm.WindowState = FormWindowState.Minimized;
        }

        protected override void OnLoad(EventArgs e)
        {
            Theme = metroStyleManager1.Theme = Properties.Settings.Default.Theme;
            Style = metroStyleManager1.Style = Properties.Settings.Default.Style;

            if (ParentForm.GetType() != typeof(MainForm))
                metroToolTip1.SetToolTip(btnToolExit, "Close");

            base.OnLoad(e);
        }
    }
}
