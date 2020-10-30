using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;


namespace Drummers_metronome_Windows
{
    public class PlaylistEntry : IDisposable
    {
        #region Fields / Properties
        private int id;
        public int Id {
            get { return id; }
            set {
                if (value > 0)
                    id = value;
                else
                    throw new ValueOutOfRangeException();
            }
        }

        private int playListId;
        public int PlayListId {
            get { return playListId; }
            set {
                if (value > 0)
                    playListId = value;
                else
                    throw new ValueOutOfRangeException();
            }
        }

        private int ordinalPosition;
        public int OrdinalPosition {
            get { return ordinalPosition; }
            set {
                if (value > 0)
                    ordinalPosition = value;
                else
                    throw new ValueOutOfRangeException();

            }
        }

        private string title;
        public string Title {
            get { return title; }
            set
            {
                if (string.IsNullOrEmpty(value) == false)
                    title = value;
                else
                    throw new ValueOutOfRangeException();

            }
        }

        private int countIn;
        public int CountIn {
            get { return countIn; }
            set
            {
                if (value > 0)
                    countIn = value;
                else
                    throw new ValueOutOfRangeException();

            }
        }

        private int beatsPerMeasure;
        public int BeatsPerMeasure {
            get { return beatsPerMeasure; }
            set
            {
                if (value > 0)
                    beatsPerMeasure = value;
                else
                    throw new ValueOutOfRangeException();

            }
        }

        private int tempo;
        public int Tempo {
            get { return tempo; }
            set
            {
                if (value > 0 && value <= 300)
                    tempo = value;
                else
                    throw new ValueOutOfRangeException();

            }
        }
        public string SongFileURL { get; set; }
        public string BackingTracksURL { get; set; }
        public string ChartURL { get; set; }
        public string Notes { get; set; }
        #endregion

        #region Constructors / Destructors
        public PlaylistEntry() { }

        public void Dispose() { }
        #endregion

        #region Exceptions
        public class ValueOutOfRangeException : Exception
        {

        }
        #endregion
    }

    public class PlayList : List<PlaylistEntry>
    {
        #region Fields / Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Group { get; set; }
        public string FileURL { get; set; }
        #endregion

        #region Constructors
        public PlayList()
        {

        }
        public PlayList(string fileURL)
        {
            FileURL = fileURL;
            Load();
        }
        #endregion

        #region Methods
        public void Load()
        {
            Clear();

            // open JSON file and deserialize
            if(File.Exists(FileURL))
                try
                {
                    AddRange(JsonConvert.DeserializeObject<List<PlaylistEntry>>(File.ReadAllText(FileURL)));
                } catch(JsonException je)
                {
                    throw new SerializationException("Unable to deserialize playlist file.",je);
                } catch(IOException ioe)
                {
                    throw new FileReadException(string.Format("Unable to read playlist file {0}", FileURL), ioe);
                }

            else
                throw new FileNotFoundException(string.Format("Unable to read playlist file {0}",FileURL));
        }

        public void Save(string fileURL)
        {
            FileURL = fileURL;
            // open JSON file and overwrite contents
            try
            {
                File.WriteAllText(FileURL, JsonConvert.SerializeObject(this));
            } catch(JsonException je)
            {
                throw new SerializationException("Unable to serialize playlist file.", je);
            }
            catch (IOException ioe)
            {
                throw new FileReadException(string.Format("Unable to write playlist file {0}", FileURL), ioe);
            }
        }
        #endregion

        #region Exceptions
        public class FileNotFoundException : Exception
        {
            public FileNotFoundException(string msg) : base(msg) { }
        }
        public class FileReadException : Exception
        {
            public FileReadException(string msg) : base(msg) { }
            public FileReadException(string msg, Exception innerException) : base(msg, innerException) { }
        }
        public class SerializationException : Exception
        {
            public SerializationException(string msg, Exception innerException) : base(msg, innerException) { }
        }
        #endregion

    }
}
