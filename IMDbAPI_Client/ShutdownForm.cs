using IMDbApiLib;
using MetroFramework.Forms;
using System;
using System.Windows.Forms;

namespace IMDbAPI_Client
{
    public partial class ShutdownForm : MetroForm
    {
        public ShutdownForm()
        {
            InitializeComponent();
        }

        private int _counter;

        private void ShutdownForm_Load(object sender, EventArgs e)
        {
            Theme = metroStyleManager1.Theme = Properties.Settings.Default.Theme;
            Style = metroStyleManager1.Style = Properties.Settings.Default.Style;

            _counter = progress.Maximum = progress.Value = 60;
        }

        private void ShutdownForm_Shown(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_counter > 0)
            {
                progress.Value = _counter;
                lblShutdownTitle.Text = $"Shutting down PC after {_counter} seconds...";
                _counter--;
            }

            if (_counter <= 0)
            {
                progress.Value = 0;
                lblShutdownTitle.Text = $"Shutting down...";
                timer1.Enabled = false;
                Utils.Shutdown();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;

            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
