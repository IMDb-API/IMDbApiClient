using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace IMDbAPI_Client
{
    public partial class SelectSeasonForm : MetroForm
    {
        public SelectSeasonForm(string fullTitle, List<string> seasons)
        {
            InitializeComponent();

            this.Text = fullTitle;

            seasons.Insert(0, "All");
            ddlSeasons.DataSource = seasons;
        }

        public int? SeasonNumber
        {
            get
            {
                if (string.IsNullOrEmpty(ddlSeasons.Text) || ddlSeasons.Text == "All")
                    return null;

                return Convert.ToInt32(ddlSeasons.Text);
            }
        }

        private void SelectSeasonForm_Load(object sender, EventArgs e)
        {
            Theme = metroStyleManager1.Theme = Properties.Settings.Default.Theme;
            Style = metroStyleManager1.Style = Properties.Settings.Default.Style;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ddlSeasons.Text))
                return;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
