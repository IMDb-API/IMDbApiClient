using IMDbApiLib;
using IMDbApiLib.Models;
using MetroFramework;
using MetroFramework.Controls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace IMDbAPI_Client.UserControls
{
    public partial class Step3_SettingsUC : MetroUserControl
    {
        public Step3_SettingsUC()
        {
            InitializeComponent();

            if (Properties.Settings.Default.ClientOptions is null)
            {
                Properties.Settings.Default.ClientOptions = new ClientOptions();
                Properties.Settings.Default.Save();
            }

            #region Languages
            ddlPlotLanguage.DataSource = new BindingSource(Utils.Languages, null);
            ddlPlotLanguage.DisplayMember = "Key";
            ddlPlotLanguage.ValueMember = "Value";
            #endregion

            Options = Properties.Settings.Default.ClientOptions;
        }

        public ClientOptions Options
        {
            set
            {
                ddlPlotLanguage.SelectedValue = value.PlotLanguage.ToString().ToLower();

                chkPosters.Checked = value.Posters;
                rbPosters_AllLanguages.Checked = value.Posters_AllLanguages;
                rbPosters_EnglishOnly.Checked = value.Posters_EnglishOnly;

                chkReport.Checked = value.Report;
                chkReport_Ratings.Checked = value.Report_Ratings;
                chkReport_FullActor.Checked = value.Report_FullActor;
                chkReport_FullCast.Checked = value.Report_FullCast;
                chkReport_Wikipedia.Checked = value.Report_Wikipedia;

                chkImages.Checked = value.Images;
                rbImages_Short.Checked = value.Images_Short;
                rbImages_Full.Checked = value.Images_Full;

                chkTrailer.Checked = value.Trailer;

                chkExternalSites.Checked = value.ExternalSites;
                chkResizeImagesAndPosters.Checked = value.ResizeImagesAndPosters;

                chkPosters_CheckedChanged(null, null);
                chkReport_CheckedChanged(null, null);
                chkImages_CheckedChanged(null, null);
            }
            get
            {
                var opt = new ClientOptions();
                opt.PlotLanguage = (Language)Enum.Parse(typeof(Language), ddlPlotLanguage.SelectedValue.ToString(), true);
                opt.Posters = chkPosters.Checked;
                opt.Posters_AllLanguages = rbPosters_AllLanguages.Checked;
                opt.Posters_EnglishOnly = rbPosters_EnglishOnly.Checked;
                opt.Report = chkReport.Checked;
                opt.Report_Ratings = chkReport_Ratings.Checked;
                opt.Report_FullActor = chkReport_FullActor.Checked;
                opt.Report_FullCast = chkReport_FullCast.Checked;
                opt.Report_Wikipedia = chkReport_Wikipedia.Checked;
                opt.Images = chkImages.Checked;
                opt.Images_Short = rbImages_Short.Checked;
                opt.Images_Full = rbImages_Full.Checked;
                opt.Trailer = chkTrailer.Checked;
                opt.ExternalSites = chkExternalSites.Checked;
                opt.ResizeImagesAndPosters = chkResizeImagesAndPosters.Checked;

                return opt;
            }
        }

        public string Title => "Step III: Settings";

        private void chkReport_CheckedChanged(object sender, EventArgs e)
        {
            grpReport.Enabled = chkReport.Checked;
        }

        private void chkImages_CheckedChanged(object sender, EventArgs e)
        {
            grpImages.Enabled = chkImages.Checked;
        }

        private void chkPosters_CheckedChanged(object sender, EventArgs e)
        {
            grpPosters.Enabled = chkPosters.Checked;
        }

        public void SaveSettings()
        {
            Properties.Settings.Default.ClientOptions = Options;
            Properties.Settings.Default.Save();
        }

        protected override void OnLoad(EventArgs e)
        {
            Theme = metroStyleManager1.Theme = Properties.Settings.Default.Theme;
            Style = metroStyleManager1.Style = Properties.Settings.Default.Style;

            if (Theme == MetroThemeStyle.Dark)
                grpReport.ForeColor = grpPosters.ForeColor = grpImages.ForeColor = Color.Silver;
            else
                grpReport.ForeColor = grpPosters.ForeColor = grpImages.ForeColor = Color.Black;

            base.OnLoad(e);
        }

        public string InvalidMessage
        {
            get
            {
                if (!chkReport.Checked && !chkPosters.Checked && !chkImages.Checked && !chkTrailer.Checked && !chkExternalSites.Checked)
                    return "Please choose one or more items to download";

                return string.Empty;
            }
        }
    }
}
