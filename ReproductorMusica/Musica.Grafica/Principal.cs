using Musica.Entidades;
using Musica.Logica;
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
        AlbumLogica al = new AlbumLogica();
        InterpreteLogica il = new InterpreteLogica();
        CancionLogica cl = new CancionLogica();
        public Principal()
        {
            InitializeComponent();
        }

        private void configuracionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimientos m = new Mantenimientos();
            m.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            dgvCanciones.AutoGenerateColumns = false;
        }

        private void rdbInterprete_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbInterprete.Checked == true)
            {
                lblBusqueda.Text = "Interprete";
                cboFiltro.DataSource = il.ObtenerTodosInterprete();
                cboFiltro.ValueMember = "idInterprete";
                cboFiltro.DisplayMember = "descripcion";
            }
        }

        private void rdbAlbum_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAlbum.Checked == true)
            {
                lblBusqueda.Text = "Album";
                cboFiltro.DataSource = al.ObtenerTodosAlbum();
                cboFiltro.ValueMember = "idAlbum";
                cboFiltro.DisplayMember = "descripcion";
            }
        }

        private void cboFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscarCanciones_Click(object sender, EventArgs e)
        {
            if (rdbInterprete.Checked == true)
            {
                Interprete i = (Interprete) cboFiltro.SelectedItem;
                dgvCanciones.DataSource = cl.ObtenerPorInterpreteCancion(i.idInterprete);
            }

            if (rdbAlbum.Checked == true)
            {
                Album a = (Album) cboFiltro.SelectedItem;
                dgvCanciones.DataSource = cl.ObtenerPorAlbumCancion(a.idAlbum);
            }
        }

        private void btnIniciarReproductor_Click(object sender, EventArgs e)
        {
            Cancion c= (Cancion)dgvCanciones.Rows[dgvCanciones.SelectedRows[0].Index].DataBoundItem;
            wmpReproductor.URL = c.rutaCancion;
        }
    }
}
