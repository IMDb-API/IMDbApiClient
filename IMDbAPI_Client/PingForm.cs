using IMDbAPI_Client.UserControls;
using IMDbApiLib;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IMDbAPI_Client
{
    public partial class PingForm : MetroForm
    {
        public PingForm()
        {
            InitializeComponent();
        }

        private void PingForm_Load(object sender, EventArgs e)
        {
            Theme = metroStyleManager1.Theme = Properties.Settings.Default.Theme;
            Style = metroStyleManager1.Style = Properties.Settings.Default.Style;
        }

        private async void PingForm_Shown(object sender, EventArgs e)
        {
            ActiveControl = null;
            EnableControlls(false);

            var servers = new List<string>()
            {
                "tv-api.com",
                "imdb.com",
                "wikipedia.org",
                "themoviedb.org",
                "youtube.com",
                //"subscene.com",
                //"rottentomatoes.com",
                //"www.metacritic.com",
                //"www.tv.com",
                //"thetvdb.com",
                //"filmaffinity.com",
                //"boxofficemojo.com",
            };

            int passedCount = 0;
            flowLayoutPanel1.Controls.Clear();
            foreach (string server in servers)
            {
                bool passed = await ApiUtils.PingAsync(server);

                if (passed) passedCount++;

                var itemUC = new PingItemUserControl(server, passed);
                flowLayoutPanel1.Controls.Add(itemUC);
            }


            bool success = passedCount == servers.Count;
            lblMessage.ForeColor = success ? Color.Green : Color.Crimson;

            var msg = new StringBuilder();
            msg.Append($"Passed: {passedCount} of {servers.Count}");
            if (success)
                msg.Append(" (successs)");
            else
                msg.Append(" (Please use VPN)");

            lblMessage.Text = msg.ToString();

            EnableControlls(true);
        }

        private void EnableControlls(bool enabled)
        {
            Controls.Cast<Control>().Where(cx
                => cx.Name != toolbarUserControl1.Name
                && cx.Name != lblWaiting.Name
                && cx.Name != spinnerWaiting.Name)
                .ToList().ForEach(cx => cx.Enabled = enabled);

            lblWaiting.Visible = spinnerWaiting.Visible = !enabled;
        }
    }
}
