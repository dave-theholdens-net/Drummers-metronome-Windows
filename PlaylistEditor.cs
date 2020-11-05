using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Drummers_metronome_Windows
{
    public partial class PlaylistEditor : Form
    {
        #region Fields / Properties
        public PlayList MyPlayList {get; set; }
        public string FileURL = "TestList.dat";
        #endregion

        #region Constructors
        public PlaylistEditor()
        {
            InitializeComponent();
            MyPlayList = new PlayList(FileURL);
        }
        public PlaylistEditor(string fileURL)
        {
            InitializeComponent();
            FileURL = fileURL;
            MyPlayList = new PlayList(FileURL);
            LoadScreen();
        }
        #endregion

        #region Event handlers
        private void btnSave_Click(object sender, System.EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog
            {
                Filter = "Setlist files (*.dat)|*.dat|All files (*.*)|*.*",
                FileName = FileURL,
                RestoreDirectory = true
            };

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                MyPlayList.Save(saveFileDialog1.FileName);
        }
        #endregion

        #region Methods
        private void LoadScreen()
        {
            txtName.Text = MyPlayList.Name;
            txtDescription.Text = MyPlayList.Description;
            txtGroup.Text = MyPlayList.Group;

            dgvSongs.AutoGenerateColumns = false;
            DataGridViewColumn col = new DataGridViewColumn
            {
                DataPropertyName = "Title",   
                HeaderText = "Title",
                CellTemplate = new DataGridViewTextBoxCell()
            };
            dgvSongs.Columns.Add(col);
            col = new DataGridViewColumn
            {
                DataPropertyName = "CountIn",
                HeaderText = "Count In",
                CellTemplate = new DataGridViewTextBoxCell()
            };
            dgvSongs.Columns.Add(col);
            col = new DataGridViewColumn
            {
                DataPropertyName = "BeatsPerMeasure",
                HeaderText = "Beats per Measure",
                CellTemplate = new DataGridViewTextBoxCell()
            };
            dgvSongs.Columns.Add(col);
            col = new DataGridViewColumn
            {
                DataPropertyName = "Tempo",
                HeaderText = "Tempo",
                CellTemplate = new DataGridViewTextBoxCell()
            };
            dgvSongs.Columns.Add(col);

            MyPlayList.Songs.Sort();
            dgvSongs.DataSource = MyPlayList.Songs;
        }
        #endregion

        private void dgvSongs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            PlaylistEntry ple = MyPlayList.Songs.ElementAt(e.RowIndex);
            PlayListItemEditor plie = new PlayListItemEditor(ple);
            plie.Show();            
        }
    }
}
