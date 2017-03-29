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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void configuracionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimientos m = new Mantenimientos();
            m.ShowDialog();
        }
    }
}
