using MetroFramework.Controls;
using System.Drawing;

namespace IMDbAPI_Client.UserControls
{
    public partial class CastUserControl : MetroUserControl
    {
        public CastUserControl()
        {
            InitializeComponent();
        }

        public Image CastImage
        {
            set => picCastImage.Image = value;
        }

        public string CastName
        {
            set => lblCastName.Text = value;
        }

        public string CastAsCharacter
        {
            set => lblCastAsCharacter.Text = value;
        }
    }
}
