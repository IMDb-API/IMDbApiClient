using IMDbAPI_Client.UserControls;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace IMDbAPI_Client
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            var fileVersionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
            var version = new Version(fileVersionInfo.ProductVersion);
            _version = btnVersion.Text = $"v{version.ToString(3)}";
        }


        private string _version;
        private List<GridData> _gridDataItems;

        private UserControl _currentUC;
        private UserControl CurrentUC
        {
            set
            {
                _currentUC = value;
                OpenUserControl(_currentUC);
            }
            get => _currentUC;
        }

        private void OpenUserControl(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            pnlUserControl.Controls.Clear();
            pnlUserControl.Controls.Add(uc);
        }

        private void EnabledButton(Button button, bool enabled, string text = null)
        {
            button.Enabled = enabled;
            if (!string.IsNullOrEmpty(text))
                button.Text = text;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Theme = metroStyleManager1.Theme = Properties.Settings.Default.Theme;
            Style = metroStyleManager1.Style = Properties.Settings.Default.Style;

            var uc = new Step1_InitUC();
            lblTitle.Text = uc.Title;
            CurrentUC = uc;
            _gridDataItems = new List<GridData>();

            EnabledButton(btnSettings, true);
            EnabledButton(btnPrevious, false);
            EnabledButton(btnNext, true, "&NEXT");
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            if (new SettingsForm().ShowDialog() == DialogResult.OK)
            {
                Theme = metroStyleManager1.Theme = (_currentUC as MetroUserControl).Theme = (toolbarUserControl1 as MetroUserControl).Theme = Properties.Settings.Default.Theme;
                Style = metroStyleManager1.Style = (_currentUC as MetroUserControl).Style = (toolbarUserControl1 as MetroUserControl).Style = Properties.Settings.Default.Style;
                Refresh();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (CurrentUC.GetType() == typeof(Step1_InitUC))
            {
                // Nothing

                EnabledButton(btnSettings, true);
                EnabledButton(btnPrevious, false);
                EnabledButton(btnNext, true, "&NEXT");
            }
            else if (CurrentUC.GetType() == typeof(Step2_SearchUC))
            {
                var uc = CurrentUC as Step2_SearchUC;
                _gridDataItems = uc.GridDataItems;

                var cUC = new Step1_InitUC();
                lblTitle.Text = cUC.Title;
                CurrentUC = cUC;

                EnabledButton(btnSettings, true);
                EnabledButton(btnPrevious, false);
                EnabledButton(btnNext, true, "&NEXT");
            }
            else if (CurrentUC.GetType() == typeof(Step3_SettingsUC))
            {
                var uc = CurrentUC as Step3_SettingsUC;
                uc.SaveSettings();

                if (Properties.Settings.Default.OperationType == OperationType.Movies || Properties.Settings.Default.OperationType == OperationType.MovieFile)
                {
                    ShowLoading(true);
                    var cUC = new Step2_SearchUC();
                    lblTitle.Text = cUC.Title;
                    CurrentUC = cUC;
                    cUC.OnReady += delegate
                    {
                        ShowLoading(false);
                    };

                    EnabledButton(btnSettings, false);
                    EnabledButton(btnPrevious, true);
                    EnabledButton(btnNext, true, "&NEXT");
                }
                else
                {
                    var cUC = new Step1_InitUC();
                    lblTitle.Text = cUC.Title;
                    CurrentUC = cUC;

                    EnabledButton(btnSettings, true);
                    EnabledButton(btnPrevious, false);
                    EnabledButton(btnNext, true, "&NEXT");
                }
            }
            else if (CurrentUC.GetType() == typeof(Step4_DownloadUC))
            {
                var cUC = new Step3_SettingsUC();
                lblTitle.Text = cUC.Title;
                CurrentUC = cUC;

                EnabledButton(btnSettings, false);
                EnabledButton(btnPrevious, true);
                EnabledButton(btnPing, true);
                EnabledButton(btnNext, true, "&NEXT");
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (CurrentUC.GetType() == typeof(Step1_InitUC))
            {
                var uc = CurrentUC as Step1_InitUC;
                if (!string.IsNullOrEmpty(uc.InvalidMessage))
                {
                    MetroMessageBox.Show(this, uc.InvalidMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                uc.SaveSettings();

                if (Properties.Settings.Default.OperationType == OperationType.Movies || Properties.Settings.Default.OperationType == OperationType.MovieFile)
                {
                    ShowLoading(true);
                    var cUC = new Step2_SearchUC();
                    lblTitle.Text = cUC.Title;
                    CurrentUC = cUC;
                    cUC.OnReady += delegate
                    {
                        ShowLoading(false);
                    };
                }
                else if (Properties.Settings.Default.OperationType == OperationType.TVSeries)
                {
                    _gridDataItems = new List<GridData>();
                    string sID = Properties.Settings.Default.SeriesTvID;
                    _gridDataItems.Add(new GridData(true, sID, sID, sID, sID));

                    var cUC = new Step3_SettingsUC();
                    lblTitle.Text = cUC.Title;
                    CurrentUC = cUC;
                }
                EnabledButton(btnSettings, false);
                EnabledButton(btnPrevious, true);
                EnabledButton(btnNext, true, "&NEXT");
            }
            else if (CurrentUC.GetType() == typeof(Step2_SearchUC))
            {
                var uc = CurrentUC as Step2_SearchUC;
                if (!string.IsNullOrEmpty(uc.InvalidMessage))
                {
                    MetroMessageBox.Show(this, uc.InvalidMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                _gridDataItems = uc.GridDataItems;

                var cUC = new Step3_SettingsUC();
                lblTitle.Text = cUC.Title;
                CurrentUC = cUC;

                EnabledButton(btnSettings, false);
                EnabledButton(btnPrevious, true);
                EnabledButton(btnNext, true, "&NEXT");
            }
            else if (CurrentUC.GetType() == typeof(Step3_SettingsUC))
            {
                var uc = CurrentUC as Step3_SettingsUC;
                if (!string.IsNullOrEmpty(uc.InvalidMessage))
                {
                    MetroMessageBox.Show(this, uc.InvalidMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                uc.SaveSettings();

                if (_gridDataItems is null || _gridDataItems.Count == 0)
                {
                    MetroMessageBox.Show(this, "Data is nulled", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                lblWaiting.Visible = spinnerWaiting.Visible = true;
                var cUC = new Step4_DownloadUC(_gridDataItems);
                lblTitle.Text = cUC.Title;
                CurrentUC = cUC;
                cUC.OnCanceled += delegate
                {
                    lblWaiting.Visible = spinnerWaiting.Visible = false;
                    EnabledButton(btnSettings, false);
                    EnabledButton(btnPrevious, true);
                    EnabledButton(btnNext, true, "&FINISH");
                };

                EnabledButton(btnSettings, false);
                EnabledButton(btnPrevious, false);
                EnabledButton(btnPing, false);
                EnabledButton(btnNext, false, "&FINISH");
            }
            else if (CurrentUC.GetType() == typeof(Step4_DownloadUC))
            {
                // Finish
                Application.Exit();
            }
        }

        private void ShowLoading(bool show)
        {
            pnlCommands.Enabled = !show;
            pnlUserControl.Enabled = !show;

            lblWaiting.Visible = spinnerWaiting.Visible = show;
        }

        private void btnPing_Click(object sender, EventArgs e)
        {
            new PingForm().ShowDialog();
        }

        private void btnVersion_Click(object sender, EventArgs e)
        {
            string url = "https://tv-api.com/client";
            var ps = new ProcessStartInfo(url)
            {
                UseShellExecute = true,
                Verb = "open"
            };
            Process.Start(ps);
        }

        private void btnVersion_MouseEnter(object sender, EventArgs e)
        {
            btnVersion.Text = "CHECK FOR UPDATE";
        }

        private void btnVersion_MouseLeave(object sender, EventArgs e)
        {
            btnVersion.Text = _version;
        }
    }
}
