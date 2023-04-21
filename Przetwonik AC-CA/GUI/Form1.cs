using System.IO;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Zadanie 4, Pawe³ Stus, Andrzej Szlaski";
        }

        string pathToSound = String.Empty;
        SoundManager soundManager = new SoundManager();
        FileManager fileManager = new FileManager();

        private void RecordButton_Click(object sender, EventArgs e)
        {
            if (RecordButton.Text == "Nagraj")
            {
                try
                {
                    CommsSet.Text = "Rozpoczêto nagrywania, naciœnij ponownie przycisk aby je zakoñczyæ";
                    soundManager.StartRecording(Convert.ToInt32(SamplingSet.Text), FileName.Text);
                    RecordButton.Text = "Stop";
                    pathToSound = FileName.Text;
                    PlayButton.Enabled = true;
                }
                catch
                {
                    CommsSet.Text = "Nie wybrano nazwy pliku lub jest ona niepoprwana";
                }
            }
            else
            {
                soundManager.StopRecording();
                CommsSet.Text = "Przerwano nagrywanie";
                RecordButton.Text = "Nagraj";
            }
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            CommsSet.Text = String.Empty;
            pathToSound = fileManager.GetSoundPath();
            if (pathToSound != String.Empty)
            {
                CommsSet.Text = "Poprawnie za³adowano plik";
                PlayButton.Enabled = true;
            }
            else
            {
                CommsSet.Text = "Nie wybrano prawid³owego pliku";
            }

        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            CommsSet.Text = String.Empty;
            try
            {
                soundManager.PlaySound(pathToSound);
                CommsSet.Text = "Odtworzono wybrany plik";
            }
            catch
            {
                CommsSet.Text = "Nie wybrano jeszcze pliku do odtworzenia";
            }
        }

        private void SamplingSet_TextChanged(object sender, EventArgs e)
        {
            CommsSet.Text = String.Empty;
            try
            {
                SNRSet.Text = Convert.ToString(20 * Math.Log(Convert.ToDouble(SamplingSet.Text) / Math.Pow(2, Convert.ToDouble(QuantizationSet.Text))));
                CommsSet.Text = "Obliczono SNR";
            }
            catch
            {
                SNRSet.Text = String.Empty;
            }
        }

        private void QuantizationSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            CommsSet.Text = String.Empty;
            try
            {
                SNRSet.Text = Convert.ToString(20 * Math.Log(Convert.ToDouble(SamplingSet.Text) / Math.Pow(2, Convert.ToDouble(QuantizationSet.Text))));
                CommsSet.Text = "Obliczono SNR";
            }
            catch
            {
                SNRSet.Text = String.Empty;
            }
        }
    }
}