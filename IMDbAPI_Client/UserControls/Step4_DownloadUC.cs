using IMDbApiLib;
using IMDbApiLib.Models;
using MetroFramework;
using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMDbAPI_Client.UserControls
{
    public partial class Step4_DownloadUC : MetroUserControl
    {
        public Step4_DownloadUC(List<GridData> gridDataItems)
        {
            InitializeComponent();

            ddlWhenDone.SelectedIndex = 0;
            _gridDataItems = gridDataItems;

            string apiKey = Properties.Settings.Default.ApiKey;
            if (Properties.Settings.Default.UseProxy)
                _apiLib = new ApiLib(apiKey,
                    Properties.Settings.Default.ProxyAddress,
                    Properties.Settings.Default.ProxyUsername,
                    Properties.Settings.Default.ProxyPassword);
            else
                _apiLib = new ApiLib(apiKey);

            _clientOptions = Properties.Settings.Default.ClientOptions;
        }

        private readonly ApiLib _apiLib;
        private readonly ClientOptions _clientOptions;

        public string Title => "Step IV: Downloading...";

        private readonly List<GridData> _gridDataItems;

        public delegate void CancelDelegate();
        public event CancelDelegate OnCanceled;

        private CancellationTokenSource _cancellationTokenSource;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnCancel.Text = "Cancelling...";
            btnCancel.Enabled = false;
            _cancellationTokenSource.Cancel();
        }

        private void Canceled()
        {
            btnCancel.Enabled = false;
            btnCancel.Visible = false;
            lblTotalProgress.Text = lblCurrent.Text = "canceled";
            progressTotal.Value = progressCurrentJob.Value = 0;

            OnCanceled?.Invoke();

            if (ddlWhenDone.Text == "Shutdown [On Successfull]")
                new ShutdownForm().ShowDialog();
        }

        protected override async void OnLoad(EventArgs e)
        {
            Theme = metroStyleManager1.Theme = Properties.Settings.Default.Theme;
            Style = metroStyleManager1.Style = Properties.Settings.Default.Style;

            if (Theme == MetroThemeStyle.Dark)
                lblTotalProgress.ForeColor = lblCurrent.ForeColor = label1.ForeColor = label2.ForeColor = lblWhenDone.ForeColor = Color.Silver;
            else
                lblTotalProgress.ForeColor = lblCurrent.ForeColor = label1.ForeColor = label2.ForeColor = lblWhenDone.ForeColor = Color.FromArgb(64, 64, 64);

            _cancellationTokenSource = new CancellationTokenSource();
            await DownloadAsync(_cancellationTokenSource.Token);

            base.OnLoad(e);
        }

        private async Task DownloadAsync(CancellationToken cancellationToken)
        {
            try
            {
                string workingDir = Properties.Settings.Default.MoviesDirectory;
                if (Properties.Settings.Default.OperationType == OperationType.MovieFile)
                {
                    string file = Properties.Settings.Default.MovieFile;
                    workingDir = new FileInfo(file).Directory.FullName;
                }
                else if (Properties.Settings.Default.OperationType == OperationType.TVSeries)
                {
                    workingDir = Properties.Settings.Default.SeriesTvDirectory;

                    string sDir = Path.Combine(workingDir, _gridDataItems.First().FullTitle);
                    if (!Directory.Exists(sDir))
                        Directory.CreateDirectory(sDir);
                }

                int totalIndex = 1;
                foreach (var item in _gridDataItems)
                {
                    ReportTotal(item.FullTitle, totalIndex, _gridDataItems.Count, cancellationToken.IsCancellationRequested);
                    ReportCurrent("Retrieve data from server", 1, 1, cancellationToken.IsCancellationRequested);

                    // TITLE
                    var data = await _apiLib.TitleAsync(item.Id, _clientOptions.PlotLanguage, _clientOptions.ToString());
                    if (!string.IsNullOrEmpty(data.ErrorMessage))
                    {
                        Canceled();
                        MetroMessageBox.Show(this, data.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    ReportTotal(data.FullTitle, totalIndex, _gridDataItems.Count, cancellationToken.IsCancellationRequested);

                    // RENAME
                    string srcDir = Path.Combine(workingDir, item.Folder);
                    string movieRootDir = Path.Combine(workingDir, Utils.RenameToPhisicalName(data.FullTitle));
                    if (srcDir != movieRootDir)
                    {
                        if (!Directory.Exists(movieRootDir))
                            Directory.Move(srcDir, movieRootDir);
                        else
                            Directory.Delete(srcDir, true);

                    }
                    ReportCurrent("...", 1, 1, cancellationToken.IsCancellationRequested);

                    // SUBTITLE
                    if (_clientOptions.Subtitles)
                    {
                        int? seasonNumber = null;
                        if (Properties.Settings.Default.OperationType == OperationType.TVSeries
                            && data.TvSeriesInfo != null
                            && data.TvSeriesInfo.Seasons != null
                            && data.TvSeriesInfo.Seasons.Count > 1)
                        {
                            var snForm = new SelectSeasonForm(data.FullTitle, data.TvSeriesInfo.Seasons);
                            if (snForm.ShowDialog() == DialogResult.OK)
                                seasonNumber = snForm.SeasonNumber;
                        }

                        ReportCurrent("Subtitles", 1, 1, cancellationToken.IsCancellationRequested);

                        var subtitleData = await _apiLib.SubtitleDataAsync(data.Id, _clientOptions.Subtitles_Language, seasonNumber);

                        await _apiLib.DownloadSubtitleAsync(
                            movieRootDir,
                            subtitleData,
                            new ProgressData(progress => ReportCurrent("Subtitles", progress.Current, progress.Total, cancellationToken.IsCancellationRequested)),
                            cancellationToken);

                        ReportCurrent("...", 1, 1, cancellationToken.IsCancellationRequested);
                    }

                    // REPORTS
                    if (_clientOptions.Report)
                    {
                        ReportCurrent("Report", 1, 1, cancellationToken.IsCancellationRequested);
                        string filePath = Path.Combine(movieRootDir, $"{item.Id}.png");
                        await _apiLib.DownloadReportAsync(
                            item.Id,
                            filePath,
                            _clientOptions.PlotLanguage,
                            _clientOptions.ReportOptionsString,
                            new ProgressData(progress => ReportCurrent("Report", progress.Current, progress.Total, cancellationToken.IsCancellationRequested, true)),
                            cancellationToken
                            );
                        ReportCurrent("...", 1, 1, cancellationToken.IsCancellationRequested);
                    }


                    // POSTERS
                    if (_clientOptions.Posters && data.Posters != null)
                    {
                        int index = 1;
                        if (_clientOptions.Posters_EnglishOnly) // Posters_EnglishOnly
                            data.Posters.Posters = data.Posters.Posters.Where(px => px.Language == "en").ToList();

                        int total = data.Posters.Posters.Count + data.Posters.Backdrops.Count;
                        int current = 1;

                        string dir = Path.Combine(movieRootDir, "Posters");
                        if (!Directory.Exists(dir) && total > 0)
                            Directory.CreateDirectory(dir);

                        ReportCurrent("Posters", current, total, cancellationToken.IsCancellationRequested);

                        // if themoviedb.org is filter in your country! (work, but slow)
                        if (!await Utils.PingAsync("themoviedb.org"))
                        {
                            data.Posters.Posters.ForEach(p => p.Link = p.Link.Replace("/posters/", "/posters-stream/").Replace("/posters/", "/posters-stream/"));
                            data.Posters.Backdrops.ForEach(p => p.Link = p.Link.Replace("/posters/", "/posters-stream/").Replace("/posters/", "/posters-stream/"));
                        }

                        foreach (var p in data.Posters.Posters)
                        {
                            ReportCurrent("Posters", current, total, cancellationToken.IsCancellationRequested);
                            string filePath = Path.Combine(dir, $"{item.Id}-{index.ToString("000")}.jpg");
                            await Utils.DownloadFileAsync(filePath, p.Link, null, _apiLib.WebProxy);
                            current++;
                            index++;
                        }
                        foreach (var p in data.Posters.Backdrops)
                        {
                            ReportCurrent("Posters", current, total, cancellationToken.IsCancellationRequested);
                            string filePath = Path.Combine(dir, $"{item.Id}-{index.ToString("000")}.jpg");
                            await Utils.DownloadFileAsync(filePath, p.Link, null, _apiLib.WebProxy);
                            current++;
                            index++;
                        }
                        ReportCurrent("...", 1, 1, cancellationToken.IsCancellationRequested);
                    }

                    // IMAGES
                    if (_clientOptions.Images)
                    {
                        ReportCurrent("Images", 1, 1, cancellationToken.IsCancellationRequested);
                        var images = new List<ImageDataDetail>();
                        if (data.Images != null && data.Images.Items != null && _clientOptions.Images_Short)
                        {
                            images = data.Images.Items;
                        }
                        else // options.Image_Full
                        {
                            var imageData = await _apiLib.ImagesAsync(item.Id, "Full");
                            if (string.IsNullOrEmpty(imageData.ErrorMessage))
                                images = imageData.Items;
                        }

                        int total = images.Count;
                        int currentIndex = 1;
                        ReportCurrent("Images", currentIndex, total, cancellationToken.IsCancellationRequested);

                        string dir = Path.Combine(movieRootDir, "Images");
                        if (!Directory.Exists(dir) && total > 0)
                            Directory.CreateDirectory(dir);
                        foreach (var img in images)
                        {
                            ReportCurrent("Images", currentIndex, total, cancellationToken.IsCancellationRequested);
                            string filePath = Path.Combine(dir, $"{Utils.RenameToPhisicalName(img.Title)}.jpg");
                            string url = img.Image;
                            await Utils.DownloadImageAsync(filePath, url, _apiLib.WebProxy);
                            currentIndex++;
                        }

                        Utils.RemoveDuplicatedFiles(dir);
                        ReportCurrent("...", 1, 1, cancellationToken.IsCancellationRequested);
                    }

                    // TRAILER
                    if (_clientOptions.Trailer)
                    {
                        ReportCurrent("Trailer", 1, 1, cancellationToken.IsCancellationRequested);

                        var youtubeTrailerData = await _apiLib.YouTubeTrailerAsync(item.Id);
                        if (string.IsNullOrEmpty(youtubeTrailerData.ErrorMessage))
                        {
                            var youtubeData = await _apiLib.YouTubeAsync(youtubeTrailerData.VideoId);

                            if (string.IsNullOrEmpty(youtubeData.ErrorMessage))
                            {
                                var video = youtubeData.Videos.FirstOrDefault();
                                var trailerBytes = await Utils.DownloadDataAsync(
                                    video.Url,
                                    new ProgressData(progress => ReportCurrent($"Trailer", progress.Current, progress.Total, cancellationToken.IsCancellationRequested, true)),
                                    cancellationToken,
                                    _apiLib.WebProxy);

                                if (trailerBytes != null)
                                {
                                    string dir = Path.Combine(movieRootDir, "Trailer");
                                    if (!Directory.Exists(dir))
                                        Directory.CreateDirectory(dir);

                                    string filePath = Path.Combine(dir, $"{Utils.RenameToPhisicalName(youtubeData.Title).Trim()} - {video.Quality}.{video.Extension}");

                                    await Task.Run(() => File.WriteAllBytes(filePath, trailerBytes));
                                }
                            }
                        }

                        ReportCurrent("...", 1, 1, cancellationToken.IsCancellationRequested);
                    }

                    // EXTERNAL SITES
                    if (_clientOptions.ExternalSites)
                    {
                        ReportCurrent("External Sites", 1, 1, cancellationToken.IsCancellationRequested);

                        string dir = Path.Combine(movieRootDir, "External Sites");
                        if (!Directory.Exists(dir))
                            Directory.CreateDirectory(dir);

                        // IMDb-API
                        {
                            string filePath = Path.Combine(dir, $"{item.Id} on IMDb-API.url");
                            string content = $"[InternetShortcut]";
                            content += Environment.NewLine;
                            content += $"URL=https://imdb-api.com/title/{item.Id}";
                            File.WriteAllText(filePath, content);
                        }

                        // IMDb
                        {
                            string filePath = Path.Combine(dir, $"{item.Id} on IMDb.url");
                            string content = $"[InternetShortcut]";
                            content += Environment.NewLine;
                            content += $"URL=https://www.imdb.com/title/{item.Id}";
                            File.WriteAllText(filePath, content);
                        }

                        var externalSiteData = await _apiLib.ExternalSitesAsync(item.Id);
                        if (string.IsNullOrEmpty(externalSiteData.ErrorMessage))
                        {
                            // TheMovieDb
                            Utils.CreateUrlShortcut(dir, $"{item.Id} on TheMovieDb.url", externalSiteData.TheMovieDb?.Url);

                            // RottenTomatoes
                            Utils.CreateUrlShortcut(dir, $"{item.Id} on RottenTomatoes.url", externalSiteData.RottenTomatoes?.Url);

                            // Metacritic
                            Utils.CreateUrlShortcut(dir, $"{item.Id} on Metacritic.url", externalSiteData.Metacritic?.Url);

                            // Netflix
                            Utils.CreateUrlShortcut(dir, $"{item.Id} on Netflix.url", externalSiteData.Netflix?.Url);

                            // BoxOfficeMojo
                            Utils.CreateUrlShortcut(dir, $"{item.Id} on BoxOfficeMojo.url", externalSiteData.BoxOfficeMojo?.Url);

                            // TheTVDB
                            Utils.CreateUrlShortcut(dir, $"{item.Id} on TheTVDB.url", externalSiteData.TheTVDB?.Url);

                            // TV_com
                            Utils.CreateUrlShortcut(dir, $"{item.Id} on TV_com.url", externalSiteData.TV_com?.Url);

                            // FilmAffinity
                            Utils.CreateUrlShortcut(dir, $"{item.Id} on FilmAffinity.url", externalSiteData.FilmAffinity?.Url);

                            // Wikipedia (en)
                            if (externalSiteData.WikipediaUrls != null)
                            {
                                var enWiki = externalSiteData.WikipediaUrls.FirstOrDefault(wx => wx.Language == "en");
                                Utils.CreateUrlShortcut(dir, $"{item.Id} on Wikipedia [en].url", enWiki?.Url);

                                if (_clientOptions.PlotLanguage != Language.en)
                                {
                                    var plotLangWiki = externalSiteData.WikipediaUrls.FirstOrDefault(wx => wx.Language == _clientOptions.PlotLanguage.ToString().ToLower());
                                    Utils.CreateUrlShortcut(dir, $"{item.Id} on Wikipedia [{_clientOptions.PlotLanguage.ToString().ToLower()}].url", plotLangWiki?.Url);
                                }
                            }
                        }

                        // ACTORS
                        string actorDir = Path.Combine(dir, "Actors");
                        if (!Directory.Exists(actorDir))
                            Directory.CreateDirectory(actorDir);
                        foreach (var actor in data.ActorList)
                        {
                            string filePath = Path.Combine(actorDir, $"{Utils.RenameToPhisicalName(actor.Name)} [{actor.Id}].url");
                            string content = $"[InternetShortcut]";
                            content += Environment.NewLine;
                            content += $"URL=https://imdb-api.com/name/{actor.Id}";
                            File.WriteAllText(filePath, content);
                        }
                    }

                    // Progress
                    ReportTotal(data.FullTitle, totalIndex, _gridDataItems.Count, cancellationToken.IsCancellationRequested);
                    totalIndex++;

                    ReportCurrent("...", 1, 1, cancellationToken.IsCancellationRequested);
                }

                btnCancel.Visible = false;
                lblTotalProgress.Text = lblCurrent.Text = "done";
                progressTotal.Value = progressCurrentJob.Value = 100;
                OnCanceled?.Invoke();

                if (ddlWhenDone.Text == "Shutdown [On Successfull]" || ddlWhenDone.Text == "Shutdown [Anyway]")
                    new ShutdownForm().ShowDialog();
            }
            catch (TaskCanceledException ex)
            {
                Canceled();
                if (ddlWhenDone.Text == "Shutdown [Anyway]")
                    new ShutdownForm().ShowDialog();
                else
                    MetroMessageBox.Show(this, ex.Message, "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                Canceled();
                if (ddlWhenDone.Text == "Shutdown [Anyway]")
                    new ShutdownForm().ShowDialog();
                else
                    MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReportTotal(string title, int current, int maximum, bool IsCancellationRequested)
        {
            if (IsCancellationRequested)
                throw new TaskCanceledException("Operation canceled by user.");

            lblTotalProgress.Text = $"{title} ({current} / {maximum})";
            progressTotal.Value = Utils.Percentage(current - 1, maximum);
        }

        private void ReportCurrent(string title, long current, long maximum, bool IsCancellationRequested, bool isFileSize = false)
        {
            try
            {
                if (IsCancellationRequested)
                    throw new TaskCanceledException("Operation canceled by user.");

                if (title == "..." || (current == 1 && maximum == 1))
                {
                    lblCurrent.Text = $"{title}";
                    progressCurrentJob.Value = 0;
                }
                else
                {
                    if (isFileSize)
                    {
                        string postfix = $" / {maximum}";
                        decimal currentDec = current;
                        decimal maximumDec = maximum;
                        currentDec = currentDec / 1024 / 1024;
                        if (maximum == -1 || maximum == 0)
                        {
                            postfix = $" MB downloaded";
                        }
                        else
                        {
                            maximumDec = maximumDec / 1024 / 1024;
                            postfix = $" / {maximumDec.ToString("N2")} MB";
                        }

                        lblCurrent.Text = $"{title} ({currentDec.ToString("N2")}{postfix})";
                    }
                    else
                    {
                        lblCurrent.Text = $"{title} ({current} / {maximum})";
                    }

                    if (maximum == -1 || maximum == 0)
                        progressCurrentJob.Value = 0;
                    else
                        progressCurrentJob.Value = Utils.Percentage(current - 1, maximum);
                }
            }
            catch (TaskCanceledException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
