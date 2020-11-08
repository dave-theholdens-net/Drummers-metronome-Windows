namespace Drummers_metronome_Windows
{
    partial class PlaylistEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvSongs = new System.Windows.Forms.DataGridView();
            this.contextMenuStripSongs = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemContextAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemContextRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemContextMoveUp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemContextMoveDown = new System.Windows.Forms.ToolStripMenuItem();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblGroup = new System.Windows.Forms.Label();
            this.txtGroup = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.menuStripPlaylistEditor = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemPlaylist = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemPlaylistItems = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAddSong = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemRemoveSong = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongs)).BeginInit();
            this.contextMenuStripSongs.SuspendLayout();
            this.menuStripPlaylistEditor.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSongs
            // 
            this.dgvSongs.AllowDrop = true;
            this.dgvSongs.AllowUserToAddRows = false;
            this.dgvSongs.AllowUserToDeleteRows = false;
            this.dgvSongs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSongs.CausesValidation = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSongs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSongs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSongs.ContextMenuStrip = this.contextMenuStripSongs;
            this.dgvSongs.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dgvSongs.Location = new System.Drawing.Point(178, 12);
            this.dgvSongs.MultiSelect = false;
            this.dgvSongs.Name = "dgvSongs";
            this.dgvSongs.ReadOnly = true;
            this.dgvSongs.RowHeadersVisible = false;
            this.dgvSongs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvSongs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSongs.Size = new System.Drawing.Size(844, 542);
            this.dgvSongs.TabIndex = 0;
            this.dgvSongs.DragDrop += new System.Windows.Forms.DragEventHandler(this.dgvSongs_DragDrop);
            this.dgvSongs.DragOver += new System.Windows.Forms.DragEventHandler(this.dgvSongs_DragOver);
            this.dgvSongs.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvSongs_KeyDown);
            this.dgvSongs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvSongs_KeyPress);
            this.dgvSongs.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvSongs_MouseDown);
            this.dgvSongs.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dgvSongs_MouseMove);
            // 
            // contextMenuStripSongs
            // 
            this.contextMenuStripSongs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemContextAdd,
            this.toolStripMenuItemContextRemove,
            this.toolStripMenuItemContextMoveUp,
            this.toolStripMenuItemContextMoveDown});
            this.contextMenuStripSongs.Name = "contextMenuStripSongs";
            this.contextMenuStripSongs.Size = new System.Drawing.Size(189, 92);
            this.contextMenuStripSongs.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripSongs_Opening);
            // 
            // toolStripMenuItemContextAdd
            // 
            this.toolStripMenuItemContextAdd.Name = "toolStripMenuItemContextAdd";
            this.toolStripMenuItemContextAdd.Size = new System.Drawing.Size(188, 22);
            this.toolStripMenuItemContextAdd.Text = "Add a song here";
            this.toolStripMenuItemContextAdd.Click += new System.EventHandler(this.toolStripMenuItemContextAdd_Click);
            // 
            // toolStripMenuItemContextRemove
            // 
            this.toolStripMenuItemContextRemove.Name = "toolStripMenuItemContextRemove";
            this.toolStripMenuItemContextRemove.Size = new System.Drawing.Size(188, 22);
            this.toolStripMenuItemContextRemove.Text = "Remove this song";
            this.toolStripMenuItemContextRemove.Click += new System.EventHandler(this.toolStripMenuItemContextRemove_Click);
            // 
            // toolStripMenuItemContextMoveUp
            // 
            this.toolStripMenuItemContextMoveUp.Name = "toolStripMenuItemContextMoveUp";
            this.toolStripMenuItemContextMoveUp.Size = new System.Drawing.Size(188, 22);
            this.toolStripMenuItemContextMoveUp.Text = "Move this song up";
            // 
            // toolStripMenuItemContextMoveDown
            // 
            this.toolStripMenuItemContextMoveDown.Name = "toolStripMenuItemContextMoveDown";
            this.toolStripMenuItemContextMoveDown.Size = new System.Drawing.Size(188, 22);
            this.toolStripMenuItemContextMoveDown.Text = "Move this song down";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 46);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(160, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(12, 93);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(12, 109);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(160, 51);
            this.txtDescription.TabIndex = 3;
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Location = new System.Drawing.Point(13, 181);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(36, 13);
            this.lblGroup.TabIndex = 6;
            this.lblGroup.Text = "Group";
            // 
            // txtGroup
            // 
            this.txtGroup.Location = new System.Drawing.Point(12, 197);
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.Size = new System.Drawing.Size(160, 20);
            this.txtGroup.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 260);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dlgSave
            // 
            this.dlgSave.DefaultExt = "dat";
            this.dlgSave.Title = "Save Set List";
            // 
            // menuStripPlaylistEditor
            // 
            this.menuStripPlaylistEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemPlaylist,
            this.toolStripMenuItemPlaylistItems});
            this.menuStripPlaylistEditor.Location = new System.Drawing.Point(0, 0);
            this.menuStripPlaylistEditor.Name = "menuStripPlaylistEditor";
            this.menuStripPlaylistEditor.Size = new System.Drawing.Size(1034, 24);
            this.menuStripPlaylistEditor.TabIndex = 8;
            this.menuStripPlaylistEditor.Text = "Playlist";
            // 
            // toolStripMenuItemPlaylist
            // 
            this.toolStripMenuItemPlaylist.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.toolStripMenuItemPlaylist.Name = "toolStripMenuItemPlaylist";
            this.toolStripMenuItemPlaylist.Size = new System.Drawing.Size(56, 20);
            this.toolStripMenuItemPlaylist.Text = "Playlist";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(217, 22);
            this.toolStripMenuItem1.Text = "Make a new playlist";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(217, 22);
            this.toolStripMenuItem2.Text = "Remove this playlist";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(217, 22);
            this.toolStripMenuItem3.Text = "Make a copy of this playlist";
            // 
            // toolStripMenuItemPlaylistItems
            // 
            this.toolStripMenuItemPlaylistItems.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAddSong,
            this.toolStripMenuItemRemoveSong});
            this.toolStripMenuItemPlaylistItems.Name = "toolStripMenuItemPlaylistItems";
            this.toolStripMenuItemPlaylistItems.Size = new System.Drawing.Size(51, 20);
            this.toolStripMenuItemPlaylistItems.Text = "Songs";
            // 
            // toolStripMenuItemAddSong
            // 
            this.toolStripMenuItemAddSong.Name = "toolStripMenuItemAddSong";
            this.toolStripMenuItemAddSong.Size = new System.Drawing.Size(246, 22);
            this.toolStripMenuItemAddSong.Text = "Add a song to this playlist";
            this.toolStripMenuItemAddSong.Click += new System.EventHandler(this.toolStripMenuItemAddSong_Click);
            // 
            // toolStripMenuItemRemoveSong
            // 
            this.toolStripMenuItemRemoveSong.Name = "toolStripMenuItemRemoveSong";
            this.toolStripMenuItemRemoveSong.Size = new System.Drawing.Size(246, 22);
            this.toolStripMenuItemRemoveSong.Text = "Remove a song from this playlist";
            this.toolStripMenuItemRemoveSong.Click += new System.EventHandler(this.toolStripMenuItemRemoveSong_Click);
            // 
            // PlaylistEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 566);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblGroup);
            this.Controls.Add(this.txtGroup);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.dgvSongs);
            this.Controls.Add(this.menuStripPlaylistEditor);
            this.MainMenuStrip = this.menuStripPlaylistEditor;
            this.Name = "PlaylistEditor";
            this.ShowIcon = false;
            this.Text = "Playlist Editor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongs)).EndInit();
            this.contextMenuStripSongs.ResumeLayout(false);
            this.menuStripPlaylistEditor.ResumeLayout(false);
            this.menuStripPlaylistEditor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSongs;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.TextBox txtGroup;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.SaveFileDialog dlgSave;
        private System.Windows.Forms.MenuStrip menuStripPlaylistEditor;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPlaylist;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPlaylistItems;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAddSong;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRemoveSong;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripSongs;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemContextAdd;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemContextRemove;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemContextMoveUp;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemContextMoveDown;
    }
}