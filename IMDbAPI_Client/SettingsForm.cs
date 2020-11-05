using IMDbAPI_Client.UserControls;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace IMDbAPI_Client
{
    public partial class SettingsForm : MetroForm
    {
        public SettingsForm()
        {
            InitializeComponent();
            txtRemoveSiteName.Text = Properties.Settings.Default.RemoveSites;
            chkUseProxy.Checked = Properties.Settings.Default.UseProxy;
            txtProxyServer.Text = Properties.Settings.Default.ProxyServer;
            txtProxyUsername.Text = Properties.Settings.Default.ProxyUsername;
            txtProxyPassword.Text = Properties.Settings.Default.ProxyPassword;
            chkUseProxy_CheckedChanged(null, null);

            ddlTheme.DataSource = Enum.GetValues(typeof(MetroThemeStyle));
            ddlTheme.SelectedItem = Properties.Settings.Default.Theme;
            ddlStyle.DataSource = Enum.GetValues(typeof(MetroColorStyle));
            ddlStyle.SelectedItem = Properties.Settings.Default.Style;

            _settingsUC = new Step3_SettingsUC();
            _settingsUC.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            tabOptions.Controls.Add(_settingsUC);
        }

        private Step3_SettingsUC _settingsUC;

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            Theme = metroStyleManager1.Theme = Properties.Settings.Default.Theme;
            Style = metroStyleManager1.Style = Properties.Settings.Default.Style;

            ddlTheme.SelectedIndexChanged += DdlTheme_SelectedIndexChanged;
            ddlStyle.SelectedIndexChanged += DdlTheme_SelectedIndexChanged;
            DdlTheme_SelectedIndexChanged(null, null);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            _settingsUC.SaveSettings();

            Properties.Settings.Default.RemoveSites = txtRemoveSiteName.Text;
            Properties.Settings.Default.ProxyServer = txtProxyServer.Text;
            Properties.Settings.Default.ProxyUsername = txtProxyUsername.Text;
            Properties.Settings.Default.ProxyPassword = txtProxyPassword.Text;

            Properties.Settings.Default.Theme = (MetroThemeStyle)Enum.Parse(typeof(MetroThemeStyle), ddlTheme.Text);
            Properties.Settings.Default.Style = (MetroColorStyle)Enum.Parse(typeof(MetroColorStyle), ddlStyle.Text);

            Properties.Settings.Default.Save();

            DialogResult = DialogResult.OK;
            Close();
        }

        private void DdlTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Theme
            string colorName = "White";
            switch (ddlTheme.Text)
            {
                case "Default": colorName = "White"; break;
                case "Light": colorName = "White"; break;
                case "Dark": colorName = "Black"; break;
            }
            pnlStyleViewer.BackColor = Color.FromName(colorName);

            // Style
            colorName = ddlStyle.Text;
            if (colorName == "Default" || colorName == "Blue")
                colorName = "SkyBlue";
            lblStyleTitle.ForeColor = Color.FromName(colorName);
            lblStyleContent.ForeColor = Color.FromName(colorName);
        }

        private void chkUseProxy_CheckedChanged(object sender, EventArgs e)
        {
            lblProxyServer.Enabled =
                txtProxyServer.Enabled =
                lblProxyUsername.Enabled =
                txtProxyUsername.Enabled =
                lblProxyPassword.Enabled =
                txtProxyPassword.Enabled = chkUseProxy.Checked;
        }
    }
}
