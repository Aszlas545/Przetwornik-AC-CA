using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    internal class FileManager
    {
        //Funckja realizująca dialog z użytkowniek aby znaleźć plik wav
        public string GetSoundPath()
        {
            OpenFileDialog dialog = new OpenFileDialog();       //utworzenia dialogu
            dialog.Filter = "Wav Files (*.wav)|*.wav";          //filtr na pliki wav
            dialog.FilterIndex = 1;

         if (dialog.ShowDialog() == DialogResult.OK)            //jeżeli dialog zakończył się prawidłowo zwraca string ze ścieżką w przeciwnym razie pusty string   
             return dialog.FileName;            
         else
             return string.Empty; 
        }
    }
}
