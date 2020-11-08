using System.Drawing;
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
        private BindingSource DataSource = new BindingSource();
        private Rectangle dragBoxFromMouseDown;
        private int rowIndexFromMouseDown;
        private int rowIndexOfItemUnderMouseToDrop;
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
            DataSource.DataSource = MyPlayList.Songs;
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
            if(dgvSongs.RowCount > 0)
            {
                // disable move song up option if selected row is at top of list
                toolStripMenuItemContextMoveUp.Enabled = (dgvSongs.CurrentRow.Index > 0);

                // disable move song down if selected row is at the bottom of the list
                toolStripMenuItemContextMoveDown.Enabled = (dgvSongs.CurrentRow.Index < (dgvSongs.Rows.Count - 1));
            } 
            else
            {
                toolStripMenuItemContextMoveUp.Enabled = true;
                toolStripMenuItemContextMoveDown.Enabled = true;
            }
        }
        private void toolStripMenuItemContextAdd_Click(object sender, System.EventArgs e)
        {
            AddEntryToList();
        }
        private void toolStripMenuItemAddSong_Click(object sender, System.EventArgs e)
        {
            AddEntryToList();
        }
        private void toolStripMenuItemRemoveSong_Click(object sender, System.EventArgs e)
        {
            RemoveEntryFromList();
        }
        private void toolStripMenuItemContextRemove_Click(object sender, System.EventArgs e)
        {
            RemoveEntryFromList();
        }
        #region drag and drop support
        private void dgvSongs_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                // If the mouse moves outside the rectangle, start the drag.
                if (dragBoxFromMouseDown != Rectangle.Empty &&
                !dragBoxFromMouseDown.Contains(e.X, e.Y))
                {
                    // Proceed with the drag and drop, passing in the list item.                    
                    DragDropEffects dropEffect = dgvSongs.DoDragDrop(
                          dgvSongs.Rows[rowIndexFromMouseDown],
                          DragDropEffects.Move);
                }
            }
        }
        private void dgvSongs_MouseDown(object sender, MouseEventArgs e)
        {
            // Get the index of the item the mouse is below.
            rowIndexFromMouseDown = dgvSongs.HitTest(e.X, e.Y).RowIndex;

            if (rowIndexFromMouseDown != -1)
            {
                // Remember the point where the mouse down occurred. 
                // The DragSize indicates the size that the mouse can move 
                // before a drag event should be started.                
                Size dragSize = SystemInformation.DragSize;

                // Create a rectangle using the DragSize, with the mouse position being
                // at the center of the rectangle.
                dragBoxFromMouseDown = new Rectangle(
                          new Point(
                            e.X - (dragSize.Width / 2),
                            e.Y - (dragSize.Height / 2)),
                      dragSize);
            }
            else
                // Reset the rectangle if the mouse is not over an item in the ListBox.
                dragBoxFromMouseDown = Rectangle.Empty;
        }
        private void dgvSongs_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }
        private void dgvSongs_DragDrop(object sender, DragEventArgs e)
        {
            // The mouse locations are relative to the screen, so they must be 
            // converted to client coordinates.
            Point clientPoint = dgvSongs.PointToClient(new Point(e.X, e.Y));

            // Get the row index of the item the mouse is below. 
            rowIndexOfItemUnderMouseToDrop = dgvSongs.HitTest(clientPoint.X, clientPoint.Y).RowIndex;

            // If the drag operation was a move then update ordinal positions.
            if (e.Effect == DragDropEffects.Move)
            {
                PlaylistEntry sourceItem = (PlaylistEntry)dgvSongs.Rows[rowIndexFromMouseDown].DataBoundItem;
                PlaylistEntry targetItem = (PlaylistEntry)dgvSongs.Rows[rowIndexOfItemUnderMouseToDrop].DataBoundItem;
                int temp = sourceItem.OrdinalPosition;
                sourceItem.OrdinalPosition = targetItem.OrdinalPosition;
                targetItem.OrdinalPosition = temp;
                DataSource.ResetBindings(false);
            }
        }
        #endregion
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
            dgvSongs.DataSource = DataSource;
            DataSource.ResetBindings(true);            
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
        private void AddEntryToList()
        {
            // find the largest ID in the list
            int newId = 0;

            // find the ordinal position of the currently selected grid row
            int insertIndex = -1;
            if (dgvSongs.CurrentRow != null)
                insertIndex = dgvSongs.CurrentRow.Index;

            // increase the ordinal position of all rows underneath
            if(MyPlayList.Songs != null)
                MyPlayList.Songs.ForEach(u => {
                    if (u.OrdinalPosition > (insertIndex + 1))
                        u.OrdinalPosition += 1;
                    if (newId < u.Id)
                        newId = u.Id;
                });

            // create new entry for the list
            PlaylistEntry ple = new PlaylistEntry()
            {
                OrdinalPosition = insertIndex + 2,
                Title = "New song",
                Id = (newId + 1),
                CountIn = 4,
                BeatsPerMeasure = 4,
                Tempo = 60
            };

            // insert into list
            MyPlayList.Songs.Add(ple);
            MyPlayList.Songs.Sort();

            // force update of data grid
            DataSource.ResetBindings(true);

            // Open new song in editor
            dgvSongs.Rows[insertIndex].Selected = true;
            OpenEditor(insertIndex);

        }
        private void RemoveEntryFromList()
        {
            // find the ordinal position of the currently selected grid row and use it to find data object
            int ndx = dgvSongs.CurrentRow.Index;
            PlaylistEntry remove = (PlaylistEntry)dgvSongs.Rows[ndx].DataBoundItem;

            // remove song from list and refresh data grid
            MyPlayList.Songs.Remove(remove);
            DataSource.ResetBindings(true);
        }
        #endregion
   }
}
