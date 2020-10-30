using Drummers_metronome_Windows.Properties;
using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace Drummers_metronome_Windows
{
    public partial class MetronomeHost : Form
    {
        #region Fields / Properties
        private readonly OutputDeviceList outputDevices;
        private OutputDevice playbackDevice;
        private bool AccentFirstBeat;
        private int CurrentBeat = 0;
        private int TotalBeats = 0;
        private int CurrentMeasure = 0;
        private bool IsCountingIn = true;
        private bool IsRunning = false;

        public int TimerValue
        {
            get { return decimal.ToInt32(Math.Floor((decimal)1000 / (_tempo / 60))); }
        }

        private int _countin = 4;        
        public int CountIn
        {
            get { return _countin; }
            set
            {
                if (value < 0 || value > 16) throw new CountInOutOfRangeException("Requested count-in of " + value.ToString() + " is not between 0 and 16."); ;                
                _countin = value;
            }
        }

        private int _beatsPerMeasure = 4;
        public int BeatsPerMeasure
        {
            get { return _beatsPerMeasure; }
            set 
            {
                if (value < 2 || value > 16) throw new BeatsPerMeasureOutOfRangeException("Requested beats per measure of " + value.ToString() + " is not between 2 and 16."); ;
                _beatsPerMeasure = value; 
            }
        }

        private int _tempo = 120;
        public int Tempo
        {
            get { return _tempo; }
            set 
            {
                if (value < 30 || value > 300) throw new TempoOutOfRangeException("Requested tempo of " + value.ToString() + " is not between 30 and 300.");  ;
                _tempo = value; 
            }
        }

        #endregion

        #region Constructors
        public MetronomeHost()
        {
            InitializeComponent();
            try
            {
                outputDevices = new OutputDeviceList();
                SetDefaults();
                PopulateForm();
            }
            catch(Exception e)
            {
                HandleException(e);
                Application.Exit();
            }

        }

        #endregion

        #region Methods
        private void HandleException(Exception e)
        {
            MessageBox.Show(
                "An exception has occurred and the metronome must shut down." + Environment.NewLine
                + " Debug information:" + Environment.NewLine
                + e.Message + Environment.NewLine
                + e.StackTrace, "Fatal error");
        }
        private void PopulateForm()
        {
            // Fill in input form fields
            txtTempo.Text = Tempo.ToString();
            txtBeatsPerMeasure.Text = BeatsPerMeasure.ToString();
            txtCountIn.Text = _countin.ToString();
            cbAccentFirstBeat.Checked = AccentFirstBeat;
            cboPlaybackDevice.ValueMember = "DeviceNumber";
            cboPlaybackDevice.DisplayMember = "DeviceName";
            cboPlaybackDevice.DataSource = outputDevices;
            if (playbackDevice != null || outputDevices.Exists(x => x.DeviceName == playbackDevice.DeviceName))
                cboPlaybackDevice.SelectedItem  = playbackDevice;

            // Set up beat box control
            bbc1.NumberOfBoxes = BeatsPerMeasure;
            bbc1.AccentFirstBeat = AccentFirstBeat;
            bbc1.PlaybackDevice = playbackDevice;
        }
        private void SetDefaults() 
        {
            var s = new Settings();
            try
            {
                Tempo = s.DefaultTempo;
                BeatsPerMeasure = s.DefaultBeatsPerMeasure;
                CountIn = s.DefaultCountIn;
                playbackDevice = outputDevices.Find(x => x.DeviceName == s.DefaultPlaybackDevice);
                AccentFirstBeat = s.DefaultAccentFirstBeat;
            }
            catch(Exception e)
            {
                // Do nothing, rely on hard-coded defaults
            }
        }
        private void UpdateDefaults()
        {
            var s = new Settings();
            try
            {
                s.DefaultTempo = Tempo;
                s.DefaultBeatsPerMeasure = BeatsPerMeasure;
                s.DefaultCountIn = CountIn;
                s.DefaultPlaybackDevice = playbackDevice.DeviceName;
                s.DefaultAccentFirstBeat = AccentFirstBeat;
                s.Save();
            }
            catch (Exception e)
            {
                // Do nothing, rely on hard-coded defaults
            }

        }

        #endregion

        #region Event Handlers

        #region Background worker events
        private void bgwRunCounting_DoWork(object sender, DoWorkEventArgs e)
        {
            // Get the BackgroundWorker that raised this event.
            BackgroundWorker worker = sender as BackgroundWorker;
            while (e.Cancel == false)
            {
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                }
                else
                {
                    // Determine if count-in has been reached
                    if (++TotalBeats > CountIn)
                        IsCountingIn = false;

                    // Determine if end of measure reached
                    if (++CurrentBeat > BeatsPerMeasure)
                    {
                        CurrentBeat = 1;
                        if (IsCountingIn == false)
                            CurrentMeasure++;
                    }

                    WorkProgressState workState = new WorkProgressState
                    {
                        CurrentBeat = CurrentBeat,
                        CurrentMeasure = CurrentMeasure
                    };
                    worker.ReportProgress(CurrentBeat / BeatsPerMeasure, workState);
                    Thread.Sleep(TimerValue);
                }
            }
        }
        private void bgwRunCounting_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            WorkProgressState prog = (WorkProgressState)e.UserState;
            if (prog != null)
            {
                bbc1.Beat(prog.CurrentBeat);
                ucCounterDisplay.Beat(prog);
                if (prog.CurrentBeat == 1 && prog.CurrentMeasure == 1)
                {
                    if (bgwRunTimer.IsBusy == false)
                        bgwRunTimer.RunWorkerAsync();
                }
            }
        }
        private void bgwRunTimer_DoWork(object sender, DoWorkEventArgs e)
        {
            int minutes = 0;
            int seconds = 0;

            // Get the BackgroundWorker that raised this event.
            BackgroundWorker worker = sender as BackgroundWorker;
            while (e.Cancel == false)
            {
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                }
                else
                {
                    // Increment counters
                    seconds++;
                    if(seconds > 59)
                    {
                        minutes++;
                        seconds = 0;
                    }

                    // Update timer display    
                    TimerProgressState prog = new TimerProgressState
                    {
                        Seconds = seconds,
                        Minutes = minutes
                    };
                    worker.ReportProgress(0, prog);                    

                    Thread.Sleep(1000);
                }
            }
        }
        private void bgwRunTimer_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            TimerProgressState prog = (TimerProgressState)e.UserState;
            if (prog != null)
                ucCounterDisplay.Tick(prog);
        }
        #endregion

        #region Form control events
        #region Metronome Actions
        private void btnStart_Click(object sender, EventArgs e)
        {
            if(bgwRunCounting.IsBusy == false) 
                bgwRunCounting.RunWorkerAsync();
            IsRunning = true;
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            bgwRunCounting.CancelAsync();
            bgwRunTimer.CancelAsync();
            IsRunning = false;
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            bgwRunCounting.CancelAsync();
            bgwRunTimer.CancelAsync();
            CurrentBeat = 0;
            TotalBeats = 0;
            CurrentMeasure = 0;
            IsCountingIn = true;
            bbc1.CurrentBeat = 0;
            bbc1.Render();
            ucCounterDisplay.Reset();
        }
        private void btnSetDefaults_Click(object sender, EventArgs e)
        {
            UpdateDefaults();
        }
        private void MetronomeHost_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                if (IsRunning == true) {
                    bgwRunCounting.CancelAsync();
                    IsRunning = false;
                } else {
                    if (bgwRunCounting.IsBusy == false)
                        bgwRunCounting.RunWorkerAsync();
                    IsRunning = true;
                }
        }
        #endregion

        #region Input form
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Enter))
            {
                SendKeys.Send("{TAB}");
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }       
        private void txtTempo_Leave(object sender, EventArgs e)
        {
            int t;
            if (Int32.TryParse(txtTempo.Text, out t))
            {
                try
                {
                    Tempo = t;
                }
                catch (TempoOutOfRangeException rangex)
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;
                    result = MessageBox.Show(rangex.Message, "Invalid Tempo", buttons);
                    TextBox tb = (TextBox)sender;
                    tb.Undo();
                }
            }
        }
        private void txtCountIn_Leave(object sender, EventArgs e)
        {
            int t;
            if (Int32.TryParse(txtCountIn.Text, out t))
            {
                try
                {
                    CountIn = t;
                }
                catch (CountInOutOfRangeException rangex)
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;
                    result = MessageBox.Show(rangex.Message, "Invalid Count-in", buttons);
                }
            }
        }
        private void txtBeatsPerMeasure_Leave(object sender, EventArgs e)
        {
            int t;
            if (Int32.TryParse(txtBeatsPerMeasure.Text, out t))
            {
                try
                {
                    BeatsPerMeasure = t;
                    bbc1.SetNumberOfBoxes(t, IsRunning);
                }
                catch (BeatsPerMeasureOutOfRangeException rangex)
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;
                    result = MessageBox.Show(rangex.Message, "Invalid Beats-per-measure", buttons);
                }
            }
        }
        private void cboPlaybackDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox) sender;
            playbackDevice = (OutputDevice)cb.SelectedItem;
            bbc1.PlaybackDevice = playbackDevice;
        }
        private void tbVolume_ValueChanged(object sender, EventArgs e)
        {
            float vol = (float)tbVolume.Value / 100;
            bbc1.Volume = vol;
        }
        private void cbAccentFirstBeat_CheckedChanged(object sender, EventArgs e)
        {
            AccentFirstBeat = cbAccentFirstBeat.Checked;
            bbc1.AccentFirstBeat = AccentFirstBeat;

        }
        #endregion

        #endregion

        #endregion

        #region Exceptions
        public class TempoOutOfRangeException : Exception
        {
            public TempoOutOfRangeException(string msg)
                 : base(msg)
            {
            }
        }
        public class BeatsPerMeasureOutOfRangeException : Exception
        {
            public BeatsPerMeasureOutOfRangeException(string msg)
                 : base(msg)
            {
            }
        }
        public class CountInOutOfRangeException : Exception
        {
            public CountInOutOfRangeException(string msg)
                 : base(msg)
            {
            }
        }
        #endregion

        #region Classes
        public class WorkProgressState
        {
            public int CurrentBeat;
            public int CurrentMeasure;
        }
        public class TimerProgressState
        {
            public int Seconds;
            public int Minutes;
        }

        #endregion

    }
}
