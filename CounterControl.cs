using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Text;
using static Drummers_metronome_Windows.MetronomeHost;

namespace Drummers_metronome_Windows
{
    public partial class CounterControl : UserControl
    {
        #region Variables for dot matrix font
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
            IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);
        private readonly PrivateFontCollection fonts = new PrivateFontCollection();
        Font segFont;
        #endregion

        #region Constructors
        public CounterControl()
        {
            InitializeComponent();
            SetUpCustomFont();
            lblBeat.Font = segFont;
            lblMeasure.Font = segFont;
            lblTime.Font = segFont;
        }
        #endregion

        #region Methods
        public void Tick(TimerProgressState tps)
        {
            if (tps != null)
                lblTime.Text = string.Format("{0}:{1}", tps.Minutes, tps.Seconds.ToString("D2"));
        }
        public void Beat(WorkProgressState prog)
        {            
            if (prog != null)
            {
                lblBeat.Text = prog.CurrentBeat.ToString();
                if (prog.CurrentBeat == 1)
                    lblMeasure.Text = prog.CurrentMeasure.ToString();
            }
        }
        public void Reset()
        {
            lblBeat.Text = "0";
            lblMeasure.Text = "0";
            lblTime.Text = "0:00";
        }
        private void SetUpCustomFont()
        {
            byte[] fontData = Properties.Resources.Square_Dot_Matrix_Font;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.Square_Dot_Matrix_Font.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.Square_Dot_Matrix_Font.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            segFont = new Font(fonts.Families[0], 32.0F);

        }
        #endregion
    }
}
