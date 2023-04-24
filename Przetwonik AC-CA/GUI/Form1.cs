using System.IO;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Zadanie 4, Pawe� Stus, Andrzej Szlaski";
        }

        // utworzenie potrzebnych z klas i zmiennej
        string pathToSound = String.Empty;
        SoundManager soundManager = new SoundManager();
        FileManager fileManager = new FileManager();

        //Po naci�ni�ciu przycisku gdy ustawiono kwantyzacje, pr�bkowanie i �cie�k� zaczyna nagrywa�
        private void RecordButton_Click(object sender, EventArgs e)
        {
            if (RecordButton.Text == "Nagraj")
            {
                if (QuantizationSet.Text != String.Empty && SamplingSet.Text != String.Empty)
                {
                    try
                    {
                        CommsSet.Text = "Rozpocz�to nagrywania, naci�nij ponownie przycisk aby je zako�czy�";
                        soundManager.StartRecording(Convert.ToInt32(SamplingSet.Text), Convert.ToInt32(QuantizationSet.Text), FileName.Text); //Rozpocz�cia nagrywania dla ustawionych parametr�w
                        RecordButton.Text = "Stop";                                                                                           //Zmiana przycisku na stop
                        pathToSound = FileName.Text;                                                                                          //Ustawienie �cie�ki do otworzenia na nagrany plik
                        PlayButton.Enabled = true;                                                                                            //Odblokowanie przycisku odtworzenia
                    }
                    catch
                    {
                        CommsSet.Text = "Nie wybrano nazwy pliku lub jest ona niepoprwana";
                    }
                }
                else
                {
                    CommsSet.Text = "Nie ustawiono cz�stotliwo�ci pr�bkowania i kwantyzacji lub s� one niepoprawne";
                }
            }
            else
            {
                soundManager.StopRecording();                       //zako�czenie nagrywania
                CommsSet.Text = "Przerwano nagrywanie";
                RecordButton.Text = "Nagraj";                       //Zmiana przycsku na nagrywanie
            }
        }

        //Przycisk ustawiaj�cy �cie�k� do pliku do odtworzenia przez dialog z u�ytkownikiem
        private void LoadButton_Click(object sender, EventArgs e)
        {
            CommsSet.Text = String.Empty;
            pathToSound = fileManager.GetSoundPath();   //funckja dialogu z u�ytkownikiem
            if (pathToSound != String.Empty)
            {
                CommsSet.Text = "Poprawnie za�adowano plik";
                PlayButton.Enabled = true;              //odblkowanie przyckisku odtworzenia
            }
            else
            {
                CommsSet.Text = "Nie wybrano prawid�owego pliku";
            }

        }

        //Przycisk odtwarzaj�cy dziwi�k
        private void PlayButton_Click(object sender, EventArgs e)
        {
            CommsSet.Text = String.Empty;
            try
            {
                soundManager.PlaySound(pathToSound);            //Odtworznia dzi�ku
                CommsSet.Text = "Odtworzono wybrany plik";
            }
            catch
            {
                CommsSet.Text = "Nie wybrano jeszcze pliku do odtworzenia";
            }
        }

        //Funckja obliczj�ca SNR po wpisaniu kwantyzacji i pr�bkowania ze wzoru 20log(2^n), gdzie n to kwantyzacja (8, 16, 24, 32)
        private void SamplingSet_TextChanged(object sender, EventArgs e)
        {
            CommsSet.Text = String.Empty;
            try
            {
                SNRSet.Text = Convert.ToString(20 * Math.Log(Math.Pow(2, Convert.ToDouble(QuantizationSet.Text))));
                CommsSet.Text = "Obliczono SNR";
            }
            catch
            {
                SNRSet.Text = String.Empty;
            }
        }

        //Funckja obliczj�ca SNR po wpisaniu kwantyzacji i pr�bkowania ze wzoru 20log(2^n), gdzie n to kwantyzacja (8, 16, 24, 32)
        private void QuantizationSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            CommsSet.Text = String.Empty;
            try
            {
                SNRSet.Text = Convert.ToString(20 * Math.Log(Math.Pow(2, Convert.ToDouble(QuantizationSet.Text))));
                CommsSet.Text = "Obliczono SNR";
            }
            catch
            {
                SNRSet.Text = String.Empty;
            }
        }
    }
}