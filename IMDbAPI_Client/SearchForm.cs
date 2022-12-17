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
    public partial class SearchForm : MetroForm
    {
        public SearchForm(SearchData searchData)
        {
            InitializeComponent();

            txtExpression.Text = searchData.Expression;

            rbMovie.Checked = Properties.Settings.Default.OperationType == OperationType.Movies;
            rbSeriesTV.Checked = Properties.Settings.Default.OperationType == OperationType.TVSeries;
            _searchData = searchData;

            string apiKey = Properties.Settings.Default.ApiKey;
            if (Properties.Settings.Default.UseProxy)
            {
                _apiLib = new ApiLib(apiKey,
                    Properties.Settings.Default.ProxyAddress,
                    Properties.Settings.Default.ProxyUsername,
                    Properties.Settings.Default.ProxyPassword);
            }
            else
            {
                _apiLib = new ApiLib(apiKey);
            }
        }

        private readonly ApiLib _apiLib;
        private SearchData _searchData;
        private List<MovieResult> _results
        {
            get
            {
                var rs = new List<MovieResult>();
                if (_searchData != null && _searchData.Results != null && _searchData.Results.Count > 0)
                {
                    foreach (var r in _searchData.Results)
                    {
                        rs.Add(new MovieResult(r.Id, $"{r.Title} {r.Description}"));
                    }
                }
                return rs;
            }
        }

        public SearchResult Result
        {
            get
            {
                var item = _searchData.Results.FirstOrDefault(rx => rx.Id == lbResults.SelectedValue.ToString());
                return item;
            }
        }

        public class MovieResult
        {
            public MovieResult(string id, string title)
            {
                Id = id;
                Title = title;
            }

            public string Id { get; set; }
            public string Title { set; get; }
        }

        public string Id => lbResults.SelectedValue.ToString();

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtExpression.Text.Trim()))
                return;

            EnableControlls(false);
            picPoster.Image = null;
            SearchData data;
            if (rbMovie.Checked)
                data = await _apiLib.SearchMovieAsync(txtExpression.Text.Trim());
            else
                data = await _apiLib.SearchSeriesAsync(txtExpression.Text.Trim());

            _searchData = data;
            if (!string.IsNullOrEmpty(data.ErrorMessage))
            {
                MetroMessageBox.Show(this, data.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EnableControlls(true);
                return;
            }

            FillListBox();
            EnableControlls(true);
        }

        private void EnableControlls(bool enabled)
        {
            Controls.Cast<Control>().Where(cx
                => cx.Name != toolbarUserControl1.Name
                && cx.Name != lblWaiting.Name
                && cx.Name != spinnerWaiting.Name
                && cx.Name != rbMovie.Name
                && cx.Name != rbSeriesTV.Name)
                .ToList().ForEach(cx => cx.Enabled = enabled);

            lblWaiting.Visible = spinnerWaiting.Visible = !enabled;
        }

        private void FillListBox()
        {
            lbResults.DisplayMember = "Title";
            lbResults.ValueMember = "Id";
            lbResults.DataSource = _results;
            if (_results != null && _results.Count > 0)
            {
                lbResults.SelectedIndex = 0;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (lbResults.SelectedIndex == -1)
            {
                MetroMessageBox.Show(this, "Please select a result", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnIMDb_Click(object sender, EventArgs e)
        {
            if (lbResults.SelectedIndex == -1)
            {
                MetroMessageBox.Show(this, "Please select a result", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            System.Diagnostics.Process.Start("https://imdb-api.com/title/" + Id);
        }

        private void txtExpression_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = btnSearch;
        }

        private async void lbSearchMovie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbResults.SelectedIndex == -1)
            {
                picPoster.Image = null;
                return;
            }

            var item = _searchData.Results.FirstOrDefault(rx => rx.Id == lbResults.SelectedValue.ToString());

            if (item is null || string.IsNullOrEmpty(item.Image) || item.Image.Contains("nopicture.jpg"))
            {
                picPoster.Image = Properties.Resources.PictureNotAvailable;
                return;
            }

            EnableControlls(false);
            picPoster.Image = null;
            if (Properties.Settings.Default.ClientOptions.ResizeImagesAndPosters)
            {
                var imageBytes = await _apiLib.ResizeImageBytesAsync("224x308", item.Image);
                picPoster.Image = ClientUtils.BytesToImage(imageBytes);
            }
            else
            {
                using (var webClient = new WebClient())
                {
                    picPoster.Image = ClientUtils.BytesToImage(await webClient.DownloadDataTaskAsync(item.Image));
                }
            }
            EnableControlls(true);
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            Theme = metroStyleManager1.Theme = Properties.Settings.Default.Theme;
            Style = metroStyleManager1.Style = Properties.Settings.Default.Style;

            FillListBox();
        }

        private void picPoster_Click(object sender, EventArgs e)
        {
            if (lbResults.SelectedIndex == -1)
            {
                MetroMessageBox.Show(this, "Please select a result", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            new MoreInfoForm(lbResults.SelectedValue.ToString()).ShowDialog();
        }

        private void btnMoreInfo_Click(object sender, EventArgs e)
        {
            picPoster_Click(null, null);
        }
    }
}
