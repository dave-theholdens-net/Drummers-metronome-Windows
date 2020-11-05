namespace Drummers_metronome_Windows
{
    partial class PlayListItemEditor
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
            this.lblPosition = new System.Windows.Forms.Label();
            this.txtPosition = new System.Windows.Forms.NumericUpDown();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtCountIn = new System.Windows.Forms.NumericUpDown();
            this.lblCountIn = new System.Windows.Forms.Label();
            this.txtBeatsPerMeasure = new System.Windows.Forms.NumericUpDown();
            this.lblBeatsPerMeasure = new System.Windows.Forms.Label();
            this.lblSong = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pbAlbumArt = new System.Windows.Forms.PictureBox();
            this.lblBackingTrack = new System.Windows.Forms.Label();
            this.btnBackingTrack = new System.Windows.Forms.Button();
            this.txtTempo = new System.Windows.Forms.NumericUpDown();
            this.lblTempo = new System.Windows.Forms.Label();
            this.btnChart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddPageTurn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCountIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBeatsPerMeasure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlbumArt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTempo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(7, 11);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(44, 13);
            this.lblPosition.TabIndex = 0;
            this.lblPosition.Text = "Position";
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(57, 8);
            this.txtPosition.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(40, 20);
            this.txtPosition.TabIndex = 2;
            this.txtPosition.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(121, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Title";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(154, 8);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(180, 20);
            this.txtTitle.TabIndex = 4;
            // 
            // txtCountIn
            // 
            this.txtCountIn.Location = new System.Drawing.Point(410, 8);
            this.txtCountIn.Name = "txtCountIn";
            this.txtCountIn.Size = new System.Drawing.Size(40, 20);
            this.txtCountIn.TabIndex = 6;
            // 
            // lblCountIn
            // 
            this.lblCountIn.AutoSize = true;
            this.lblCountIn.Location = new System.Drawing.Point(360, 11);
            this.lblCountIn.Name = "lblCountIn";
            this.lblCountIn.Size = new System.Drawing.Size(46, 13);
            this.lblCountIn.TabIndex = 5;
            this.lblCountIn.Text = "Count in";
            // 
            // txtBeatsPerMeasure
            // 
            this.txtBeatsPerMeasure.Location = new System.Drawing.Point(583, 8);
            this.txtBeatsPerMeasure.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtBeatsPerMeasure.Name = "txtBeatsPerMeasure";
            this.txtBeatsPerMeasure.Size = new System.Drawing.Size(40, 20);
            this.txtBeatsPerMeasure.TabIndex = 8;
            this.txtBeatsPerMeasure.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblBeatsPerMeasure
            // 
            this.lblBeatsPerMeasure.AutoSize = true;
            this.lblBeatsPerMeasure.Location = new System.Drawing.Point(481, 11);
            this.lblBeatsPerMeasure.Name = "lblBeatsPerMeasure";
            this.lblBeatsPerMeasure.Size = new System.Drawing.Size(96, 13);
            this.lblBeatsPerMeasure.TabIndex = 7;
            this.lblBeatsPerMeasure.Text = "Beats per Measure";
            // 
            // lblSong
            // 
            this.lblSong.AutoSize = true;
            this.lblSong.Location = new System.Drawing.Point(7, 38);
            this.lblSong.Name = "lblSong";
            this.lblSong.Size = new System.Drawing.Size(32, 13);
            this.lblSong.TabIndex = 9;
            this.lblSong.Text = "Song";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(57, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Choose file";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pbAlbumArt
            // 
            this.pbAlbumArt.Location = new System.Drawing.Point(12, 63);
            this.pbAlbumArt.Name = "pbAlbumArt";
            this.pbAlbumArt.Size = new System.Drawing.Size(250, 250);
            this.pbAlbumArt.TabIndex = 11;
            this.pbAlbumArt.TabStop = false;
            // 
            // lblBackingTrack
            // 
            this.lblBackingTrack.AutoSize = true;
            this.lblBackingTrack.Location = new System.Drawing.Point(189, 38);
            this.lblBackingTrack.Name = "lblBackingTrack";
            this.lblBackingTrack.Size = new System.Drawing.Size(73, 13);
            this.lblBackingTrack.TabIndex = 12;
            this.lblBackingTrack.Text = "Backing track";
            // 
            // btnBackingTrack
            // 
            this.btnBackingTrack.Location = new System.Drawing.Point(268, 33);
            this.btnBackingTrack.Name = "btnBackingTrack";
            this.btnBackingTrack.Size = new System.Drawing.Size(75, 23);
            this.btnBackingTrack.TabIndex = 13;
            this.btnBackingTrack.Text = "Choose file";
            this.btnBackingTrack.UseVisualStyleBackColor = true;
            // 
            // txtTempo
            // 
            this.txtTempo.Location = new System.Drawing.Point(694, 8);
            this.txtTempo.Maximum = new decimal(new int[] {
            299,
            0,
            0,
            0});
            this.txtTempo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.Size = new System.Drawing.Size(40, 20);
            this.txtTempo.TabIndex = 15;
            this.txtTempo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Location = new System.Drawing.Point(644, 11);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(40, 13);
            this.lblTempo.TabIndex = 14;
            this.lblTempo.Text = "Tempo";
            // 
            // btnChart
            // 
            this.btnChart.Location = new System.Drawing.Point(526, 33);
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(75, 23);
            this.btnChart.TabIndex = 17;
            this.btnChart.Text = "Choose file";
            this.btnChart.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(447, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Chart / Score";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(268, 92);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(466, 221);
            this.txtNotes.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Notes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(447, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Page Turns";
            // 
            // btnAddPageTurn
            // 
            this.btnAddPageTurn.Location = new System.Drawing.Point(526, 59);
            this.btnAddPageTurn.Name = "btnAddPageTurn";
            this.btnAddPageTurn.Size = new System.Drawing.Size(20, 20);
            this.btnAddPageTurn.TabIndex = 21;
            this.btnAddPageTurn.Text = "+";
            this.btnAddPageTurn.UseVisualStyleBackColor = true;
            // 
            // PlayListItemEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 321);
            this.Controls.Add(this.btnAddPageTurn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnChart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTempo);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.btnBackingTrack);
            this.Controls.Add(this.lblBackingTrack);
            this.Controls.Add(this.pbAlbumArt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblSong);
            this.Controls.Add(this.txtBeatsPerMeasure);
            this.Controls.Add(this.lblBeatsPerMeasure);
            this.Controls.Add(this.txtCountIn);
            this.Controls.Add(this.lblCountIn);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.lblPosition);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PlayListItemEditor";
            this.Text = "PlayListItemEditor";
            ((System.ComponentModel.ISupportInitialize)(this.txtPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCountIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBeatsPerMeasure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlbumArt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTempo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.NumericUpDown txtPosition;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.NumericUpDown txtCountIn;
        private System.Windows.Forms.Label lblCountIn;
        private System.Windows.Forms.NumericUpDown txtBeatsPerMeasure;
        private System.Windows.Forms.Label lblBeatsPerMeasure;
        private System.Windows.Forms.Label lblSong;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pbAlbumArt;
        private System.Windows.Forms.Label lblBackingTrack;
        private System.Windows.Forms.Button btnBackingTrack;
        private System.Windows.Forms.NumericUpDown txtTempo;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.Button btnChart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddPageTurn;
    }
}