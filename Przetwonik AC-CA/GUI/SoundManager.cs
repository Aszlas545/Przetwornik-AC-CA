using System.Media;
using VisioForge.Libs.NAudio.Wave;

namespace GUI
{
    internal class SoundManager
    {
        public WaveIn waveSource = null;
        public WaveFileWriter waveFile = null;

        public void PlaySound(string path)
        {
            SoundPlayer player = new SoundPlayer(path);
            player.Play();
        }

        public void StartRecording(int sampling, string path)
        {
            waveSource = new WaveIn();
            waveSource.WaveFormat = new WaveFormat(sampling, 1);

            waveSource.DataAvailable += new EventHandler<WaveInEventArgs>(waveSource_DataAvailable);
            waveSource.RecordingStopped += new EventHandler<StoppedEventArgs>(waveSource_RecordingStopped);

            waveFile = new WaveFileWriter(@path, waveSource.WaveFormat);

            waveSource.StartRecording();
        }

        public void StopRecording() 
        {
            waveSource.StopRecording();
        }

        void waveSource_DataAvailable(object sender, WaveInEventArgs e)
        {
            if (waveFile != null)
            {
                waveFile.Write(e.Buffer, 0, e.BytesRecorded);
                waveFile.Flush();
            }
        }

        void waveSource_RecordingStopped(object sender, StoppedEventArgs e)
        {
            if (waveSource != null)
            {
                waveSource.Dispose();
                waveSource = null;
            }

            if (waveFile != null)
            {
                waveFile.Dispose();
                waveFile = null;
            }
        }
    }
}
