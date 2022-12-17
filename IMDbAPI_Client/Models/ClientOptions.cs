using IMDbApiLib.Models;
using System.Collections.Generic;
using System.Text;

namespace IMDbAPI_Client
{
    public class ClientOptions
    {
        // Default values
        public ClientOptions()
        {
            PlotLanguage = Language.en;
            Report_Ratings = true;
            Posters = true;
            Posters_EnglishOnly = true;
            Report = true;
            Images_Short = true;
        }

        public Language PlotLanguage { get; set; }


        public bool Report { get; set; }
        public bool Report_Ratings { get; set; }
        public bool Report_FullActor { get; set; }
        public bool Report_FullCast { get; set; }
        public bool Report_Wikipedia { get; set; }


        public bool Posters { get; set; }
        public bool Posters_AllLanguages { get; set; }
        public bool Posters_EnglishOnly { get; set; }


        public bool Images { get; set; }
        public bool Images_Short { get; set; }
        public bool Images_Full { get; set; }


        public bool Trailer { get; set; }

        public bool ExternalSites { get; set; }

        public bool ResizeImagesAndPosters { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            var lst = new List<string>();
            if (Report)
            {
                if (Report_Ratings)
                    lst.Add("Ratings");
                if (Report_FullActor)
                    lst.Add("FullActor");
                if (Report_FullCast)
                    lst.Add("FullCast");
                if (Report_Wikipedia)
                    lst.Add("Wikipedia");
            }

            if (Posters)
                lst.Add("Posters");
            if (Images)
                lst.Add("Images");
            if (Trailer)
                lst.Add("Trailer");
            sb.Append(string.Join(",", lst));

            return sb.ToString();
        }

        public string ReportOptionsString
        {
            get
            {
                string reportOptions = "";
                if (Report)
                {
                    if (Report_Ratings)
                        reportOptions += ",Ratings";
                    if (Report_FullActor)
                        reportOptions += ",FullActor";
                    if (Report_FullCast)
                        reportOptions += ",FullCast";
                    if (Report_Wikipedia)
                        reportOptions += ",Wikipedia";
                }

                return reportOptions;
            }

        }
    }
}
