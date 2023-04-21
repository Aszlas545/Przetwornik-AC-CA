using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    internal class FileManager
    {
        public string GetSoundPath()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Wav Files (*.wav)|*.wav";
            dialog.FilterIndex = 1;
            dialog.Multiselect = true;

         if (dialog.ShowDialog() == DialogResult.OK)                 
             return dialog.FileName;            
         else
             return string.Empty; 
        }
    }
}
