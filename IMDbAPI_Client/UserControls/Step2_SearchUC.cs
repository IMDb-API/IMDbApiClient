using IMDbApiLib;
using IMDbApiLib.Models;
using MetroFramework;
using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMDbAPI_Client.UserControls
{
    public partial class Step2_SearchUC : MetroUserControl
    {
        public Step2_SearchUC()
        {
            InitializeComponent();

            string apiKey = Properties.Settings.Default.ApiKey;
            if (Properties.Settings.Default.UseProxy)
                _apiLib = new ApiLib(apiKey,
                    Properties.Settings.Default.ProxyAddress,
                    Properties.Settings.Default.ProxyUsername,
                    Properties.Settings.Default.ProxyPassword);
            else
                _apiLib = new ApiLib(apiKey);
        }

        private readonly ApiLib _apiLib;

        public string Title => "Step II: Search Title";

        public List<GridData> GridDataItems
        {
            get
            {
                var items = new List<GridData>();
                foreach (DataGridViewRow r in dgv.Rows)
                {
                    if (Convert.ToBoolean(r.Cells["SelectColumn"].Value))
                        items.Add(new GridData(
                            Convert.ToBoolean(r.Cells["SelectColumn"].Value),
                            r.Cells["FolderColumn"].Value.ToString(),
                            r.Cells["FullTitleColumn"].Value.ToString(),
                            r.Cells["OriginalTitleColumn"].Value.ToString(),
                            r.Cells["IdColumn"].Value.ToString()
                            ));
                }
                return items;
            }
        }

        public delegate void ReadyDelegate();
        public event ReadyDelegate OnReady;

        protected override async void OnLoad(EventArgs e)
        {
            Theme = metroStyleManager1.Theme = Properties.Settings.Default.Theme;
            Style = metroStyleManager1.Style = Properties.Settings.Default.Style;

            string colorName = Style.ToString();
            if (colorName == "Default")
                colorName = "Blue";
            FolderColumn.LinkColor = FolderColumn.VisitedLinkColor = Color.FromName(colorName);

            var items = new List<GridData>();
            var dirs = new List<DirectoryInfo>();
            // MOVE
            if (Properties.Settings.Default.OperationType == OperationType.Movies)
            {
                string dir = Properties.Settings.Default.MoviesDirectory;
                var dinfo = new DirectoryInfo(dir);
                foreach (var fi in dinfo.GetFiles())
                {
                    // Create Folder
                    string nameOnly = fi.Name.Replace(fi.Extension, "");
                    nameOnly = Utils.RemoveDlSiteName(nameOnly, Properties.Settings.Default.RemoveSites);
                    string newFolder = $"{dir}\\{nameOnly}";
                    Directory.CreateDirectory(newFolder);

                    // Moving File
                    fi.MoveTo($"{newFolder}\\{nameOnly}{fi.Extension}");
                }

                dirs = new DirectoryInfo(dir).GetDirectories().Where(dx => !dx.Name.StartsWith("0")).ToList();
            }
            else if (Properties.Settings.Default.OperationType == OperationType.MovieFile)
            {
                string file = Properties.Settings.Default.MovieFile;
                var fi = new FileInfo(file);
                // Create Folder
                string nameOnly = fi.Name.Replace(fi.Extension, "");
                nameOnly = Utils.RemoveDlSiteName(nameOnly, Properties.Settings.Default.RemoveSites);
                string newFolder = $"{fi.Directory.FullName}\\{nameOnly}";
                Directory.CreateDirectory(newFolder);

                // Moving File
                fi.MoveTo($"{newFolder}\\{nameOnly}{fi.Extension}");

                dirs.Add(fi.Directory);
            }
            // ADD To GridData
            foreach (var di in dirs)
            {
                var data = await _apiLib.SearchMovieAsync(di.Name);
                if (!string.IsNullOrEmpty(data.ErrorMessage))
                {
                    MetroMessageBox.Show(this, data.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    OnReady?.Invoke();
                    return;
                }

                if (data.Results != null && data.Results.Count == 1)
                {
                    var result = data.Results.First();
                    var titleData = await _apiLib.TitleAsync(result.Id);
                    items.Add(new GridData(true, di.Name, titleData.FullTitle, titleData.OriginalTitle, titleData.Id));
                }
                else
                {
                    var searchForm = new SearchForm(data);
                    if (searchForm.ShowDialog() == DialogResult.OK)
                    {
                        var result = searchForm.Result;
                        var titleData = await _apiLib.TitleAsync(result.Id);
                        if (string.IsNullOrEmpty(titleData.ErrorMessage))
                            items.Add(new GridData(true, di.Name, titleData.FullTitle, titleData.OriginalTitle, titleData.Id));
                        else
                        {
                            MetroMessageBox.Show(this, data.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            OnReady?.Invoke();
                            return;
                        }
                    }
                    else
                    {
                        // Not add
                    }
                }
                dgv.DataSource = new List<GridData>(items);
            }

            await Task.Delay(100);
            InfoColumn.Text = "info...";
            InfoColumn.UseColumnTextForButtonValue = true;
            SearchAgainColumn.Text = "search again";
            SearchAgainColumn.UseColumnTextForButtonValue = true;

            dgv.DataSource = new List<GridData>(items);
            OnReady?.Invoke();
            base.OnLoad(e);
        }

        public string InvalidMessage
        {
            get
            {
                if (dgv.Rows.Count == 0)
                    return "Items is empty";

                bool hastSelect = false;
                foreach (DataGridViewRow r in dgv.Rows)
                    if (Convert.ToBoolean(r.Cells["SelectColumn"].Value))
                        hastSelect = true;
                if (!hastSelect)
                    return "Items is empty";

                return string.Empty;
            }
        }

        private async void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv.Columns["FolderColumn"].Index)
            {
                if (dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    string query = dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    query = query.Replace(" [NoSUB]", "");
                    query = query.Replace(" [NOSUB]", "");
                    query = query.Replace(" ", "+");
                    query = query.Replace("&", "+and+");
                    query += "+imdb";
                    System.Diagnostics.Process.Start($"https://www.google.com/search?q={query}");
                }
            }

            if (e.ColumnIndex == 0)
            {
                string id = dgv.Rows[e.RowIndex].Cells[nameof(IdColumn)].Value.ToString();
                if (string.IsNullOrEmpty(id))
                    return;

                new MoreInfoForm(id).ShowDialog();
            }

            if (e.ColumnIndex == 1)
            {
                string id = dgv.Rows[e.RowIndex].Cells[nameof(IdColumn)].Value.ToString();
                if (string.IsNullOrEmpty(id))
                    return;

                string folder = dgv.Rows[e.RowIndex].Cells[nameof(FolderColumn)].Value.ToString();

                var searchdata = new SearchData()
                {
                    Expression = folder,
                    SearchType = "Movie"
                };
                var searchForm = new SearchForm(searchdata);
                if (searchForm.ShowDialog() == DialogResult.OK)
                {
                    var result = searchForm.Result;
                    var titleData = await _apiLib.TitleAsync(result.Id);
                    if (string.IsNullOrEmpty(titleData.ErrorMessage))
                    {
                        dgv.Rows[e.RowIndex].Cells[nameof(IdColumn)].Value = titleData.Id;
                        dgv.Rows[e.RowIndex].Cells[nameof(FullTitleColumn)].Value = titleData.FullTitle;
                        dgv.Rows[e.RowIndex].Cells[nameof(OriginalTitleColumn)].Value = titleData.OriginalTitle;
                    }
                }
            }

        }
    }
}
