using IMDbApiLib;
using IMDbApiLib.Models;
using MetroFramework.Controls;
using System;
using System.IO;
using System.Windows.Forms;

namespace IMDbAPI_Client.UserControls
{
    public partial class Step1_InitUC : MetroUserControl
    {
        public Step1_InitUC()
        {
            InitializeComponent();

            MovieType = Properties.Settings.Default.OperationType;
            MovieFile = Properties.Settings.Default.MovieFile;
            MoviesDirectory = Properties.Settings.Default.MoviesDirectory;
            SeriesTvDirectory = Properties.Settings.Default.SeriesTvDirectory;
            SeriesTvID = Properties.Settings.Default.SeriesTvID;

            txtApiKey.Text = Properties.Settings.Default.ApiKey;
            txtApiKey.UseSystemPasswordChar = true;

            string apiKey = Properties.Settings.Default.ApiKey;
            _apiLib = new ApiLib(apiKey);
        }

        private readonly ApiLib _apiLib;

        public string Title => "Step I: Init";

        public OperationType MovieType
        {
            set
            {
                rbMovieFile.Checked = value == OperationType.MovieFile;
                rbMovies.Checked = value == OperationType.Movies;
                rbSeriesTV.Checked = value == OperationType.TVSeries;
            }
            get
            {
                if (rbMovieFile.Checked)
                    return OperationType.MovieFile;
                else if (rbMovies.Checked)
                    return OperationType.Movies;
                else
                    return OperationType.TVSeries;
            }
        }

        public string MovieFile
        {
            set => txtMovieFile.Text = value;
            get => txtMovieFile.Text;
        }

        public string MoviesDirectory
        {
            set => txtMoviesDir.Text = value;
            get => txtMoviesDir.Text;
        }

        public string SeriesTvDirectory
        {
            set => txtSeriesTvDir.Text = value;
            get => txtSeriesTvDir.Text;
        }

        public string SeriesTvID
        {
            set => txtSeriesTvID.Text = value;
            get => txtSeriesTvID.Text;
        }

        public void SaveSettings()
        {
            Properties.Settings.Default.OperationType = MovieType;
            Properties.Settings.Default.MovieFile = MovieFile;
            Properties.Settings.Default.MoviesDirectory = MoviesDirectory;
            Properties.Settings.Default.SeriesTvDirectory = SeriesTvDirectory;
            Properties.Settings.Default.SeriesTvID = SeriesTvID;

            Properties.Settings.Default.ApiKey = txtApiKey.Text;

            Properties.Settings.Default.Save();
        }

        public string InvalidMessage
        {
            get
            {
                if (string.IsNullOrEmpty(txtApiKey.Text))
                    return "API Key requied.";

                if (rbMovieFile.Checked)
                {
                    if (string.IsNullOrEmpty(txtMovieFile.Text))
                        return "Movie file requied.";

                    if (!File.Exists(txtMovieFile.Text))
                        return "Movie file not exists.";
                }
                else if (rbMovies.Checked)
                {
                    if (string.IsNullOrEmpty(txtMoviesDir.Text))
                        return "Movies directory requied.";

                    if (!Directory.Exists(txtMoviesDir.Text))
                        return "Movies directory not exists.";
                }
                else if (rbSeriesTV.Checked)
                {
                    if (string.IsNullOrEmpty(txtSeriesTvDir.Text))
                        return "Series TV directory requied.";

                    if (!Directory.Exists(txtSeriesTvDir.Text))
                        return "Series TV directory not exists.";

                    if (string.IsNullOrEmpty(txtSeriesTvID.Text))
                        return "Series TV IMDb Id requied.";

                    if (!txtSeriesTvID.Text.StartsWith("tt"))
                        return "Invalid  Series TV IMdb Id (ex: tt1234567).";
                }

                return string.Empty;
            }
        }

        private void txtMoviesDir_ButtonClick(object sender, EventArgs e)
        {
            if (Directory.Exists(txtMoviesDir.Text))
                folderBrowserDialog1.SelectedPath = txtMoviesDir.Text;

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                txtMoviesDir.Text = folderBrowserDialog1.SelectedPath;
        }

        private void txtSeriesTvDir_ButtonClick(object sender, EventArgs e)
        {
            if (Directory.Exists(txtSeriesTvDir.Text))
                folderBrowserDialog1.SelectedPath = txtSeriesTvDir.Text;

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                txtSeriesTvDir.Text = folderBrowserDialog1.SelectedPath;
        }

        private void lnkRegister_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start($"{_apiLib.BaseUrl}/Identity/Account/Register");
        }

        private void txtApiKey_ButtonClick(object sender, EventArgs e)
        {
            txtApiKey.UseSystemPasswordChar = !txtApiKey.UseSystemPasswordChar;
        }

        private void rbAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMovieFile.Checked)
            {
                EnabledControls(true, lblMovieFile, txtMovieFile);
                EnabledControls(false, lblMoviesDir, txtMoviesDir);
                EnabledControls(false, lblSeriesTvDir, txtSeriesTvDir, lblSeriesTvID, txtSeriesTvID, btnSearchSeriesTV, btnMoreInfo);
            }
            else if (rbMovies.Checked)
            {
                EnabledControls(false, lblMovieFile, txtMovieFile);
                EnabledControls(true, lblMoviesDir, txtMoviesDir);
                EnabledControls(false, lblSeriesTvDir, txtSeriesTvDir, lblSeriesTvID, txtSeriesTvID, btnSearchSeriesTV, btnMoreInfo);
            }
            else if (rbSeriesTV.Checked)
            {
                EnabledControls(false, lblMovieFile, txtMovieFile);
                EnabledControls(false, lblMoviesDir, txtMoviesDir);
                EnabledControls(true, lblSeriesTvDir, txtSeriesTvDir, lblSeriesTvID, txtSeriesTvID, btnSearchSeriesTV, btnMoreInfo);
            }
        }

        private void EnabledControls(bool enabled, params Control[] controls)
        {
            foreach (var c in controls)
                c.Enabled = enabled;
        }

        protected override void OnLoad(EventArgs e)
        {
            Theme = metroStyleManager1.Theme = Properties.Settings.Default.Theme;
            Style = metroStyleManager1.Style = Properties.Settings.Default.Style;

            base.OnLoad(e);
        }

        private void btnSearchSeriesTV_Click(object sender, EventArgs e)
        {
            SaveSettings();
            var data = new SearchData()
            {
                Expression = txtSeriesTvID.Text,
                SearchType = "Series"
            };

            var searchForm = new SearchForm(data);
            if (searchForm.ShowDialog() == DialogResult.OK)
            {
                txtSeriesTvID.Text = searchForm.Result.Id;
            }
        }

        private void btnMoreInfo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSeriesTvID.Text) || !txtSeriesTvID.Text.StartsWith("tt"))
                return;

            new MoreInfoForm(txtSeriesTvID.Text).ShowDialog();
        }

        private void txtMovieFile_ButtonClick(object sender, EventArgs e)
        {
            if (Directory.Exists(txtMoviesDir.Text))
                openFileDialog1.InitialDirectory = txtMoviesDir.Text;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtMovieFile.Text = openFileDialog1.FileName;
            }
        }
    }
}
