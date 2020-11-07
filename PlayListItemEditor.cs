using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Drummers_metronome_Windows
{
    public partial class PlayListItemEditor : Form
    {
        #region Fields / Properties
        public readonly PlaylistEntry MyPlayListEntry;
        #endregion

        #region Constructors

        public PlayListItemEditor()
        {
            InitializeComponent();
        }
        public PlayListItemEditor(PlaylistEntry playListEntry)
        {
            InitializeComponent();
            MyPlayListEntry = playListEntry;
            BindScreenControls();
        }
        #endregion

        #region Methods
        private void BindScreenControls()
        {
            if (MyPlayListEntry != null)
            {                
                txtPosition.DataBindings.Add("Text", MyPlayListEntry, "OrdinalPosition");
                txtTitle.DataBindings.Add("Text", MyPlayListEntry, "Title");
                txtCountIn.DataBindings.Add("Text", MyPlayListEntry, "CountIn");
                txtBeatsPerMeasure.DataBindings.Add("Text", MyPlayListEntry, "BeatsPerMeasure");
                txtTempo.DataBindings.Add("Text", MyPlayListEntry, "Tempo");
                txtNotes.DataBindings.Add("Text", MyPlayListEntry, "Notes");
                if(string.IsNullOrWhiteSpace(MyPlayListEntry.SongFileURL) == true)
                {                   
                    pbAlbumArt.Visible = true;
                } else
                {
                    pbAlbumArt.Visible = false;
                }

            }
        }

        private Image LoadCoverArt()
        {
            using (WebClient webClient = new WebClient())
            {
                byte[] data = webClient.DownloadData("https://fbcdn-sphotos-h-a.akamaihd.net/hphotos-ak-xpf1/v/t34.0-12/10555140_10201501435212873_1318258071_n.jpg?oh=97ebc03895b7acee9aebbde7d6b002bf&oe=53C9ABB0&__gda__=1405685729_110e04e71d9");

                using (MemoryStream mem = new MemoryStream(data))
                {
                    return Image.FromStream(mem);
                }

            }
        }
        #endregion

        private void PlayListItemEditor_FormClosed(object sender, FormClosedEventArgs e)
        {
            string test = "";
        }

        private void PlayListItemEditor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}
