namespace IMDbAPI_Client
{
    public class GridData
    {
        public GridData()
        {

        }

        public GridData(bool select, string folder, string fullTitle, string originalTitle, string id)
        {
            Select = select;
            Folder = folder;
            FullTitle = fullTitle;
            OriginalTitle = originalTitle;
            Id = id;
        }

        public bool Select { get; set; }
        public string Folder { get; set; }
        public string FullTitle { get; set; }
        public string OriginalTitle { get; set; }
        public string Id { get; set; }
    }
}
