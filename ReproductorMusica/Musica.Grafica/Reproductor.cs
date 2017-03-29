using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Musica.Grafica
{
    public partial class Reproductor : Form
    {
        public Reproductor()
        {
            InitializeComponent();
        }

        private void btnAbrirReroductor_Click(object sender, EventArgs e)
        {
            ofdReproductor= new OpenFileDialog();
            ofdReproductor.Title = "Abrir archivo de música y video";
            ofdReproductor.Filter = "Archivo mp3 (*.mp3)|*.mp3|Archivo mp4 (*.mp4)|*.mp4|Archivo avi (*.avi)|*.avi";
            ofdReproductor.FilterIndex = 1;

            try
            {
                if (ofdReproductor.ShowDialog() == DialogResult.OK)
                {
                    wmpReproductor.URL = ofdReproductor.FileName;
                }
            }
            catch (Exception)
            {

                return;
            }
        }
    }
}
