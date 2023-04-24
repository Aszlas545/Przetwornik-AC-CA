using System.Media;
using VisioForge.Libs.NAudio.Wave;

namespace GUI
{
    internal class SoundManager
    {
        public WaveIn waveSource = null;                            //Klasa reprezentująca urządzenie nagrywające
        public WaveFileWriter waveFile = null;                      //Klasa zapisuąca do pliku

        public void PlaySound(string path)
        {
            SoundPlayer player = new SoundPlayer(path);             //Klasa odtwarzącja dzwięk z bilioteki System.Media
            player.Play();                                          //Odtworzenie dzięku
        }

        public void StartRecording(int sampling, int quantization, string path)
        {
            waveSource = new WaveIn();                                                                      //Stworzenia urządzenia brakującego bazowo brane to z systemu o indeskie 0 (domyślne)
            waveSource.WaveFormat = new WaveFormat(sampling, quantization, 2);                              //Stworzenia formatu wav o określonych parametrach kwantyzacji i próbkowania

            waveSource.DataAvailable += new EventHandler<WaveInEventArgs>(waveSource_DataAvailable);        //Event dopisujący dane gdy coś mówimy
            waveSource.RecordingStopped += new EventHandler<StoppedEventArgs>(waveSource_RecordingStopped); //Event disposujący klasy po zakończeniu nagrywania

            waveFile = new WaveFileWriter(@path, waveSource.WaveFormat);                                    //Utworzenia pliku w zadanej ścieżce i zapisywanie tam formatu utworzenego wcześniej

            waveSource.StartRecording();
        }

        public void StopRecording()                                                                         //Zakończenie nagrywania po którym wykona się waveSource_RecordingStopped
        {
            waveSource.StopRecording();
        }

        void waveSource_DataAvailable(object sender, WaveInEventArgs e)                                     //Funckja dopsisująca dane do pliku i czyszcząca bufor aby się nie przepełnił
        {
            if (waveFile != null)
            {
                waveFile.Write(e.Buffer, 0, e.BytesRecorded);                                               //dopisywanie 
                waveFile.Flush();                                                                           //czyszczenie buffora
            }
        }

        void waveSource_RecordingStopped(object sender, StoppedEventArgs e)
        {
            if (waveSource != null)
            {
                waveSource.Dispose();                                                                       //Pozbycie się źródła nagrywania
                waveSource = null;
            }

            if (waveFile != null)
            {
                waveFile.Dispose();                                                                         //Pozbycie się klasy zapisującej do pliku
                waveFile = null;
            }
        }
    }
}
