
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Drummers_metronome_Windows
{
    #region Default color constants
    static class Constants
    {
        public const string _ACTIVE_COLOR = "OrangeRed";
        public const string _INACTIVE_COLOR = "Snow";
    }
    #endregion

    public partial class BeatBoxControl : UserControl
    {


        #region Fields / Properties

        public int CurrentBeat = 1;
        public bool AccentFirstBeat = true;
        public Color ActiveColor = Color.FromName(Constants._ACTIVE_COLOR);
        public Color InactiveColor = Color.FromName(Constants._INACTIVE_COLOR);

        private int _gutter = 10;
        public int Gutter
        {
            get { return _gutter; }
            set
            {
                _gutter = value;
                MyBeatBoxList.Gutter = value;
            }
        }

        private int _numberOfBoxes = 4;
        public int NumberOfBoxes
        {
            get { return _numberOfBoxes; }
            set { 
                _numberOfBoxes = value;
                MyBeatBoxList.BeatsPerMeasure = value;
            }
        }

        private float _volume = 0.5F;
        public float Volume
        {
            get { return _volume; }
            set { 
                if(value < 1.0F && value >=0.0F) 
                    _volume = value;
                if (myBeepMaker != null)
                    myBeepMaker.Volume = value;
            }
        }

        private OutputDevice _playbackDevice;
        public OutputDevice PlaybackDevice
        {
            get { return _playbackDevice; }
            set {
                _playbackDevice = value;
                if(myBeepMaker != null)
                    myBeepMaker.Dispose();
                if(_playbackDevice != null)
                    myBeepMaker = new BeepMaker(_playbackDevice);
            }
        }

        private Graphics _myGraphics = null;
        private Graphics MyGraphics
        {
            get {
                if (_myGraphics == null)
                {
                    _myGraphics = this.CreateGraphics();
                }
                return _myGraphics;
            }
        }

        public BeatBoxList MyBeatBoxList;
        private BeepMaker myBeepMaker;

        #endregion

        #region Constructors
        public BeatBoxControl()
        {
            InitializeComponent();

            if (PlaybackDevice == null)
                PlaybackDevice = new OutputDeviceList().FirstOrDefault();

            MyBeatBoxList = new BeatBoxList(this.Width, this.Height, this.Top, this.Left, Gutter, NumberOfBoxes);
        }
        #endregion

        #region Methods

        public void Beat(int currentBeat)
        {
            CurrentBeat = currentBeat;
            Render();

            // Sound metronome tick
            if (myBeepMaker != null)
            {
                if (CurrentBeat == 1 & AccentFirstBeat == true)
                    myBeepMaker.MakeAccentSound();
                else
                    myBeepMaker.MakeBeatSound();
            }
        }

        public void Render()
        {
            // Repaint background blank
            MyGraphics.Clear(this.BackColor);

            // Signal each box to render itself
            foreach (BeatBox b in MyBeatBoxList)
            {
                int ndx = MyBeatBoxList.IndexOf(b);
                b.IsActive = (ndx + 1 == CurrentBeat ? true : false);
                b.Render(MyGraphics);
            }
        }

        public void SetNumberOfBoxes(int numberOfBoxes, bool updateDisplay)
        {
            NumberOfBoxes = numberOfBoxes;
            MyBeatBoxList.MakeBars();
            if (updateDisplay == true)
            {
                Render();
            }
        }

        public void SetGutter(int gutter, bool updateDisplay)
        {
            Gutter = gutter ;
            MyBeatBoxList.MakeBars();
            if (updateDisplay == true)
            {
                Render();
            }
        }
        #endregion
    }

    public class BeatBoxList : List<BeatBox>
    {
        int ControlWidth;
        int ControlHeight;
        int ControlTop;
        int ControlLeft;
        public int Gutter;
        public int BeatsPerMeasure;
        public Color ActiveColor = Color.FromName(Constants._ACTIVE_COLOR);
        public Color InactiveColor = Color.FromName(Constants._INACTIVE_COLOR);

        #region Constructors
        public BeatBoxList()
        {

        }
        public BeatBoxList(int width, int height, int top, int left, int gutter, int beatsPerMeasure)
        {
            ControlWidth = width;
            ControlHeight = height;
            ControlTop = top;
            ControlLeft = left;
            Gutter = gutter;
            BeatsPerMeasure = beatsPerMeasure;
            MakeBars();
        }
        #endregion

        #region Methods
        public void MakeBars()
        {
            Clear();

            for (int x = 0; x < BeatsPerMeasure; x++)
            {
                BeatBox newBeatBox = new BeatBox
                {
                    Top = ControlTop,
                    Width = (ControlWidth / BeatsPerMeasure),
                    Left = ControlLeft + (ControlWidth / BeatsPerMeasure) * x,
                    Height = ControlHeight,
                    GutterWidth = Gutter
                };
                Add(newBeatBox);
            }
        }
        #endregion
    }

    public class BeatBox
    {
        #region Fields / Properties
        public int Height = 200;
        public int Width = 200;
        public int Left = 0;
        public int Top = 0;
        public int GutterWidth = 10;
        public bool IsActive = false;
        public Color ActiveColor = Color.FromName(Constants._ACTIVE_COLOR);
        public Color InactiveColor = Color.FromName(Constants._INACTIVE_COLOR);

        public int BarHeight
        {
            get { return Height - GutterWidth * 2; }
        }
        public int BarWidth
        {
            get { return Width - GutterWidth; }
        }
        public int BarTop
        {
            get { return Top + GutterWidth; }
        }
        public int BarLeft
        {
            get { return Left + GutterWidth; }
        }
        #endregion

        #region Constructors
        public BeatBox()
        {

        }
        #endregion

        #region Methods
        public void Render(Graphics g)
        {
            if (g != null)
            {
                System.Drawing.SolidBrush myBrush;

                if (IsActive)
                    myBrush = new System.Drawing.SolidBrush(ActiveColor);
                else
                    myBrush = new System.Drawing.SolidBrush(InactiveColor);

                var r = new Rectangle(
                                BarLeft,
                                BarTop,
                                BarWidth,
                                BarHeight);

                g.FillRectangle(myBrush, r);
                myBrush.Dispose();
            }

        }
        #endregion

    }
}
