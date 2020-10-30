namespace Drummers_metronome_Windows
{
    partial class MetronomeHost
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
            OutputDevice outputDevice1 = new OutputDevice();
            this.pnlControlPanel = new System.Windows.Forms.Panel();
            this.ucCounterDisplay = new Drummers_metronome_Windows.CounterControl();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSetDefaults = new System.Windows.Forms.Button();
            this.cbAccentFirstBeat = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbVolume = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.cboPlaybackDevice = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBeatsPerMeasure = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCountIn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTempo = new System.Windows.Forms.TextBox();
            this.bgwRunCounting = new System.ComponentModel.BackgroundWorker();
            this.bgwRunTimer = new System.ComponentModel.BackgroundWorker();
            this.bbc1 = new Drummers_metronome_Windows.BeatBoxControl();
            this.pnlControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlControlPanel
            // 
            this.pnlControlPanel.Controls.Add(this.ucCounterDisplay);
            this.pnlControlPanel.Controls.Add(this.btnReset);
            this.pnlControlPanel.Controls.Add(this.btnSetDefaults);
            this.pnlControlPanel.Controls.Add(this.cbAccentFirstBeat);
            this.pnlControlPanel.Controls.Add(this.label8);
            this.pnlControlPanel.Controls.Add(this.tbVolume);
            this.pnlControlPanel.Controls.Add(this.label7);
            this.pnlControlPanel.Controls.Add(this.cboPlaybackDevice);
            this.pnlControlPanel.Controls.Add(this.label4);
            this.pnlControlPanel.Controls.Add(this.txtBeatsPerMeasure);
            this.pnlControlPanel.Controls.Add(this.label3);
            this.pnlControlPanel.Controls.Add(this.txtCountIn);
            this.pnlControlPanel.Controls.Add(this.label2);
            this.pnlControlPanel.Controls.Add(this.btnStop);
            this.pnlControlPanel.Controls.Add(this.btnStart);
            this.pnlControlPanel.Controls.Add(this.label1);
            this.pnlControlPanel.Controls.Add(this.txtTempo);
            this.pnlControlPanel.Location = new System.Drawing.Point(1, 1);
            this.pnlControlPanel.Name = "pnlControlPanel";
            this.pnlControlPanel.Size = new System.Drawing.Size(677, 192);
            this.pnlControlPanel.TabIndex = 0;
            // 
            // ucCounterDisplay
            // 
            this.ucCounterDisplay.Location = new System.Drawing.Point(402, 19);
            this.ucCounterDisplay.Name = "ucCounterDisplay";
            this.ucCounterDisplay.Size = new System.Drawing.Size(181, 169);
            this.ucCounterDisplay.TabIndex = 21;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(589, 144);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 35);
            this.btnReset.TabIndex = 20;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSetDefaults
            // 
            this.btnSetDefaults.Location = new System.Drawing.Point(257, 144);
            this.btnSetDefaults.Name = "btnSetDefaults";
            this.btnSetDefaults.Size = new System.Drawing.Size(75, 23);
            this.btnSetDefaults.TabIndex = 18;
            this.btnSetDefaults.Text = "Set defaults";
            this.btnSetDefaults.UseVisualStyleBackColor = true;
            this.btnSetDefaults.Click += new System.EventHandler(this.btnSetDefaults_Click);
            // 
            // cbAccentFirstBeat
            // 
            this.cbAccentFirstBeat.AutoSize = true;
            this.cbAccentFirstBeat.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbAccentFirstBeat.Location = new System.Drawing.Point(229, 26);
            this.cbAccentFirstBeat.Name = "cbAccentFirstBeat";
            this.cbAccentFirstBeat.Size = new System.Drawing.Size(103, 17);
            this.cbAccentFirstBeat.TabIndex = 17;
            this.cbAccentFirstBeat.Text = "Accent first beat";
            this.cbAccentFirstBeat.UseVisualStyleBackColor = true;
            this.cbAccentFirstBeat.CheckedChanged += new System.EventHandler(this.cbAccentFirstBeat_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Volume";
            // 
            // tbVolume
            // 
            this.tbVolume.AutoSize = false;
            this.tbVolume.Location = new System.Drawing.Point(69, 140);
            this.tbVolume.Maximum = 100;
            this.tbVolume.Name = "tbVolume";
            this.tbVolume.Size = new System.Drawing.Size(182, 45);
            this.tbVolume.TabIndex = 15;
            this.tbVolume.TickFrequency = 10;
            this.tbVolume.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbVolume.Value = 50;
            this.tbVolume.ValueChanged += new System.EventHandler(this.tbVolume_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Playback device";
            // 
            // cboPlaybackDevice
            // 
            this.cboPlaybackDevice.FormattingEnabled = true;
            this.cboPlaybackDevice.Location = new System.Drawing.Point(119, 113);
            this.cboPlaybackDevice.Name = "cboPlaybackDevice";
            this.cboPlaybackDevice.Size = new System.Drawing.Size(213, 21);
            this.cboPlaybackDevice.TabIndex = 13;
            this.cboPlaybackDevice.SelectedIndexChanged += new System.EventHandler(this.cboPlaybackDevice_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Beats per measure";
            // 
            // txtBeatsPerMeasure
            // 
            this.txtBeatsPerMeasure.AcceptsReturn = true;
            this.txtBeatsPerMeasure.Location = new System.Drawing.Point(149, 52);
            this.txtBeatsPerMeasure.Name = "txtBeatsPerMeasure";
            this.txtBeatsPerMeasure.Size = new System.Drawing.Size(30, 20);
            this.txtBeatsPerMeasure.TabIndex = 2;
            this.txtBeatsPerMeasure.Leave += new System.EventHandler(this.txtBeatsPerMeasure_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "beats";
            // 
            // txtCountIn
            // 
            this.txtCountIn.AcceptsReturn = true;
            this.txtCountIn.Location = new System.Drawing.Point(149, 81);
            this.txtCountIn.Name = "txtCountIn";
            this.txtCountIn.Size = new System.Drawing.Size(30, 20);
            this.txtCountIn.TabIndex = 3;
            this.txtCountIn.Leave += new System.EventHandler(this.txtCountIn_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Count in";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(589, 91);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 35);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(589, 37);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 35);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tempo";
            // 
            // txtTempo
            // 
            this.txtTempo.Location = new System.Drawing.Point(139, 24);
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.Size = new System.Drawing.Size(40, 20);
            this.txtTempo.TabIndex = 0;
            this.txtTempo.WordWrap = false;
            this.txtTempo.Leave += new System.EventHandler(this.txtTempo_Leave);
            // 
            // bgwRunCounting
            // 
            this.bgwRunCounting.WorkerReportsProgress = true;
            this.bgwRunCounting.WorkerSupportsCancellation = true;
            this.bgwRunCounting.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwRunCounting_DoWork);
            this.bgwRunCounting.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwRunCounting_ProgressChanged);
            // 
            // bgwRunTimer
            // 
            this.bgwRunTimer.WorkerReportsProgress = true;
            this.bgwRunTimer.WorkerSupportsCancellation = true;
            this.bgwRunTimer.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwRunTimer_DoWork);
            this.bgwRunTimer.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwRunTimer_ProgressChanged);
            // 
            // bbc1
            // 
            this.bbc1.Gutter = 10;
            this.bbc1.Location = new System.Drawing.Point(1, 204);
            this.bbc1.Name = "bbc1";
            this.bbc1.NumberOfBoxes = 4;
            outputDevice1.DeviceName = "Microsoft Sound Mapper";
            outputDevice1.DeviceNumber = 0;
            this.bbc1.PlaybackDevice = outputDevice1;
            this.bbc1.Size = new System.Drawing.Size(677, 150);
            this.bbc1.TabIndex = 1;
            this.bbc1.Volume = 0.5F;
            // 
            // MetronomeHost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 354);
            this.Controls.Add(this.bbc1);
            this.Controls.Add(this.pnlControlPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MetronomeHost";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Drummers Metronone";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MetronomeHost_KeyDown);
            this.pnlControlPanel.ResumeLayout(false);
            this.pnlControlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlControlPanel;
        private System.ComponentModel.BackgroundWorker bgwRunCounting;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTempo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCountIn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBeatsPerMeasure;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboPlaybackDevice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar tbVolume;
        private System.Windows.Forms.CheckBox cbAccentFirstBeat;
        private System.Windows.Forms.Button btnSetDefaults;
        private BeatBoxControl bbc1;
        private System.Windows.Forms.Button btnReset;
        private System.ComponentModel.BackgroundWorker bgwRunTimer;
        private CounterControl ucCounterDisplay;
    }
}

