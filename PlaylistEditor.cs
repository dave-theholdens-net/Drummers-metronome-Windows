﻿using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        private void dgvSongs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenEditor(e.RowIndex);
        }
        private void dgvSongs_KeyDown(object sender, KeyEventArgs e)
        {
            // ENTER key opens the editor
            if (e.KeyCode == Keys.Enter)
            {
                DataGridView songs = (DataGridView)sender;                
                OpenEditor(songs.CurrentRow.Index);
                e.Handled = true;
            }
        }
        private void dgvSongs_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        void onEditorClose(object sender, FormClosedEventArgs e)
        {
            // read in values from editor data object and update data store
            UpdateSetListFromEditor(sender);
        }
        private void contextMenuStripSongs_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // disable move song up option if selected row is at top of list
            toolStripMenuItemContextMoveUp.Enabled = (dgvSongs.CurrentRow.Index > 0);

            // disable move song down if selected row is at the bottom of the list
            toolStripMenuItemContextMoveDown.Enabled = (dgvSongs.CurrentRow.Index < (dgvSongs.Rows.Count - 1));
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
        private Point CalculatePopupPosition(int rowIndex, int controlHeight)
        {
            int VerticalPadding = 5;
            int y;
            Rectangle listRect = dgvSongs.Bounds;
            Rectangle rowRect = dgvSongs.GetRowDisplayRectangle(rowIndex, true);

            if ((rowRect.Bottom + VerticalPadding + controlHeight) > listRect.Bottom)
                // no room underneath so display above
                y = rowRect.Top - (VerticalPadding + Height);
            else
                // display underneath
                y = rowRect.Bottom + VerticalPadding;

            // Have to map result to screen coordinate position instead of client coordinates
            return this.PointToScreen(new Point(rowRect.X, y));
        }
        private void OpenEditor(int rowIndex)
        {
            PlaylistEntry ple = MyPlayList.Songs.ElementAt(rowIndex);
            if (ple != null)
            {
                // clone a copy of the play list entry for the editor screen to work with
                PlaylistEntry clonePle = Newtonsoft.Json.JsonConvert.DeserializeObject<PlaylistEntry>(Newtonsoft.Json.JsonConvert.SerializeObject(ple));
                PlayListItemEditor plie = new PlayListItemEditor(clonePle);
                plie.FormClosed += onEditorClose;

                // Set editor window position and display it
                plie.Location = CalculatePopupPosition(rowIndex, plie.Height);
                plie.Left = plie.Location.X + dgvSongs.Location.X;
                plie.Top = plie.Location.Y + dgvSongs.Location.Y;
                plie.Show();
            }
        }
        private void UpdateSetListFromEditor(object sender)
        {
            // update playlist item and write any changes to disk
            PlayListItemEditor plie = (PlayListItemEditor)sender;
            PlaylistEntry ple = plie.MyPlayListEntry;
            if (ple != null)
            {
                var x = MyPlayList.Songs.First(i => i.Id == ple.Id);
                if (x != null)
                {
                    if(ple.PropertiesMatch(x) == false)
                    {
                        var ndx = MyPlayList.Songs.IndexOf(x);
                        var resortRequired = (ple.OrdinalPosition == x.OrdinalPosition);
                        if (ndx > -1)
                        {
                            MyPlayList.Songs[ndx] = ple;
                            MyPlayList.Save(FileURL);
                        }   
                        if(resortRequired)
                        {
                            MyPlayList.Songs.Sort();
                            dgvSongs.Refresh();
                        }
                    }
                }
            }

        }
        #endregion
    }
}
