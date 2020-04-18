using IMDbAPI_Client.UserControls;
using IMDbApiLib;
using IMDbApiLib.Models;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace IMDbAPI_Client
{
    public partial class MoreInfoForm : MetroForm
    {
        public MoreInfoForm(string id)
        {
            InitializeComponent();
            _id = id;

            string apiKey = Properties.Settings.Default.ApiKey;
            _apiLib = new ApiLib(apiKey);
        }

        private readonly ApiLib _apiLib;
        private readonly string _id;

        private void MoreInfoForm_Load(object sender, EventArgs e)
        {
            Theme = metroStyleManager1.Theme = Properties.Settings.Default.Theme;
            Style = metroStyleManager1.Style = Properties.Settings.Default.Style;
        }

        private async void MoreInfoForm_Shown(object sender, EventArgs e)
        {
            ActiveControl = null;
            EnableControlls(false);
            var data = await _apiLib.TitleAsync(_id);
            if (!string.IsNullOrEmpty(data.ErrorMessage))
            {
                MetroMessageBox.Show(this, data.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EnableControlls(true);
                return;
            }
            this.Text = data.Title;
            lblFullTitle.Text = data.FullTitle;
            lblOriginalTitle.Text = data.OriginalTitle;
            if (string.IsNullOrEmpty(lblOriginalTitle.Text))
                lblOriginalTitle.Visible = false;
            if (string.IsNullOrEmpty(data.PlotLocal))
                txtPlot.Text = data.Plot;
            else
            {
                txtPlot.Text = data.PlotLocal;
                if (data.PlotLocalIsRtl)
                    txtPlot.RightToLeft = RightToLeft.Yes;
            }

            var creators = new List<StarShort>();
            if (data.DirectorList != null)
                creators.AddRange(data.DirectorList);
            if (data.WriterList != null)
                creators.AddRange(data.WriterList);
            if (data.TvSeriesInfo != null && !string.IsNullOrEmpty(data.TvSeriesInfo.Creators))
                creators.AddRange(data.TvSeriesInfo.CreatorList);

            txtPlot.Visible = lblCreatorsTitle.Visible = lblCountryTitle.Visible = lblCompanyTitle.Visible = lblRuntimeTitle.Visible = lblGenreTitle.Visible = true;

            lblCreators.Text = string.Join(", ", creators.Select(cx => cx.Name).Distinct());
            lblCountry.Text = string.Join(", ", data.CountryList.Select(cx => cx.Key));
            lblCompany.Text = data.Companies;
            lblRuntime.Text = data.RuntimeStr;
            lblGenre.Text = string.Join(", ", data.GenreList.Select(cx => cx.Key));

            data.Image = data.Image.Replace("/original/", "/224x308/");
            using (var wc = new WebClient())
                picPoster.Image = Utils.BytesToImage(await wc.DownloadDataTaskAsync(data.Image));

            foreach (var act in data.ActorList.Take(6))
            {
                var uc = new CastUserControl();
                act.Image = act.Image.Replace("/original/", "/96x132/");
                using (var wc = new WebClient())
                    uc.CastImage = Utils.BytesToImage(await wc.DownloadDataTaskAsync(act.Image));
                uc.CastName = act.Name;
                uc.CastAsCharacter = act.AsCharacter;

                flowLayoutPanel1.Controls.Add(uc);
            }
            EnableControlls(true);
        }

        private void EnableControlls(bool enabled)
        {
            btnIMDb.Enabled = enabled;
            lblWaiting.Visible = spinnerWaiting.Visible = !enabled;
        }

        private void btnIMDb_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://imdb-api.com/title/" + _id);
        }
    }
}
