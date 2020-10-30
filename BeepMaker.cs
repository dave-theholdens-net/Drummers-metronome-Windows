using NAudio.Wave;
using System;

namespace Drummers_metronome_Windows
{
    public class BeepMaker : IDisposable
    {
        #region Fields / Properties
        private WaveOutEvent _beatPlayer;
        private WaveOutEvent _accentPlayer;
        private WaveFileReader _beatReader;
        private WaveFileReader _accentReader;
        private OutputDevice _playbackDevice;
        private float _volume = 0.5F;
        public float Volume
        {
            get { return _volume; }
            set
            {
                if (value >= 0.0F & value <= 1.0F)
                {
                    _volume = value;
                    _beatPlayer.Volume = _volume;
                    _accentPlayer.Volume = _volume;
                }
            }
        }
        #endregion

        #region Constructors
        public BeepMaker(OutputDevice outputConfiguration)
        {
            SetPlaybackDevice(_playbackDevice);
            LoadSounds();
        }
        #endregion

        #region Methods
        private void LoadSounds()
        {
            if (_accentPlayer != null) _accentPlayer.Dispose();
            if (_beatPlayer != null) _beatPlayer.Dispose();

            _accentReader = new WaveFileReader(new RawSourceWaveStream(Properties.Resources.HighTone, new WaveFormat()));
            _accentPlayer = new WaveOutEvent();
            _accentPlayer.DesiredLatency = 50;
            _accentPlayer.Volume = 0.5F;
            _accentPlayer.Init(_accentReader);

            _beatReader = new WaveFileReader(new RawSourceWaveStream(Properties.Resources.LowTone, new WaveFormat()));
            _beatPlayer = new WaveOutEvent();
            _beatPlayer.DesiredLatency = 50;
            _beatPlayer.Volume = 0.5F;
            _beatPlayer.Init(_beatReader);

        }
        private void SetPlaybackDevice(OutputDevice playbackDevice)
        {
            if(playbackDevice != null)
            {
                _playbackDevice = playbackDevice;
                _beatPlayer.DeviceNumber = _playbackDevice.DeviceNumber;
                _accentPlayer.DeviceNumber = _playbackDevice.DeviceNumber;
            }
        }
        public void MakeBeatSound()
        {
            if(_beatPlayer != null)
            {
                // Stop any current playbacks to prevent overlapping at higher tempos
                if (_beatPlayer.PlaybackState == PlaybackState.Playing)
                    _beatPlayer.Stop();
                _beatReader.Position = 0;
                _beatPlayer.Play();
            }
        }
        public void MakeAccentSound()
        {
            if (_accentPlayer != null)
            {
                // Stop any current playbacks to prevent overlapping at higher tempos
                if (_accentPlayer.PlaybackState == PlaybackState.Playing)
                    _accentPlayer.Stop();
                _accentReader.Position = 0;
                _accentPlayer.Play();
            }
        }
        #endregion

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _accentPlayer.Dispose();
                    _accentPlayer.Dispose();
                    _beatPlayer.Dispose();
                    _beatPlayer.Dispose();
                }

                disposedValue = true;
            }
        }
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
        }
        #endregion
    }
}
