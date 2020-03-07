using MetroFramework.Controls;
using System;
using System.Diagnostics;

namespace IMDbAPI_Client.UserControls
{
    public partial class PingItemUserControl : MetroUserControl
    {
        public PingItemUserControl()
        {
            InitializeComponent();

            Url = "";
            Passed = false;
        }

        public PingItemUserControl(string url, bool passed)
        {
            InitializeComponent();

            Url = url;
            Passed = passed;
        }

        public string Url
        {
            set
            {
                lnkUrl.Text = value;
                lnkUrl.Click += (sx, ox) => Process.Start($"https://{value}");
            }
            get => lnkUrl.Text;
        }

        private bool _passed;
        public bool Passed
        {
            set
            {
                _passed = value;
                picPassed.Image = value ? Properties.Resources.OK : Properties.Resources.Cancel;
            }
            get => _passed;
        }

        protected override void OnLoad(EventArgs e)
        {
            Theme = metroStyleManager1.Theme = Properties.Settings.Default.Theme;
            Style = metroStyleManager1.Style = Properties.Settings.Default.Style;

            base.OnLoad(e);
        }
    }
}
