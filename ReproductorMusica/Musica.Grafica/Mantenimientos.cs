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
    public partial class Mantenimientos : Form
    {
        InterpreteLogica il = new InterpreteLogica();
        AlbumLogica al = new AlbumLogica();
        CancionLogica cl = new CancionLogica();
        public String ruta = "";

        public Mantenimientos()
        {
            InitializeComponent();
        }

        public void refrescarAlbum()
        {
            dgvAlbum.DataSource = al.ObtenerTodosAlbum();
        }

        public void refrescarComboAlbum()
        {
            cboAlbum.DataSource = al.ObtenerTodosAlbum();
            cboAlbum.ValueMember = "idAlbum";
            cboAlbum.DisplayMember = "descripcion";
        }

        public void refrescarInterprete()
        {
            dgvInterprete.DataSource = il.ObtenerTodosInterprete();
        }

        public void refrescarComboInterprete()
        {
            cboInterprete.DataSource = il.ObtenerTodosInterprete();
            cboInterprete.ValueMember = "idInterprete";
            cboInterprete.DisplayMember = "descripcion";
        }

        public void refrescarCancion()
        {
            dgvCancion.DataSource = cl.ObtenerTodosCancion();
        }

        private void Mantenimientos_Load(object sender, EventArgs e)
        {
            dgvAlbum.AutoGenerateColumns = false;
            dgvCancion.AutoGenerateColumns = false;
            dgvInterprete.AutoGenerateColumns = false;
            refrescarAlbum();
            refrescarComboAlbum();
            refrescarInterprete();
            refrescarComboInterprete();
            refrescarCancion();
        }

        private void btnInsertarInterprete_Click(object sender, EventArgs e)
        {
            if (txtNombreInterprete.Text == "")
            {
                lblMensaje.ForeColor = Color.Red;
                lblMensaje.Text = "No se permite dejar en blanco este campo, es obligatorio";
            }
            else
            {
                lblMensaje.Text = "";

                if (il.existe(txtNombreInterprete.Text) == true)
                {
                    lblMensaje.ForeColor = Color.Red;
                    lblMensaje.Text = "El interprete ya existe, regitre otro";
                }
                else
                {
                    lblMensaje.Text = "";
                    Interprete i = new Interprete();
                    i.descripcion = txtNombreInterprete.Text;

                    il.InsertarInterprete(i);
                    refrescarInterprete();
                    refrescarComboInterprete();
                }
            }
        }

        private void btnInsertarAlbum_Click(object sender, EventArgs e)
        {
            if (txtNombreAlbum.Text == "")
            {
                lblMensaje.ForeColor = Color.Red;
                lblMensaje.Text = "No se permite dejar en blanco este campo, es obligatorio";
            }
            else
            {
                lblMensaje.Text = "";

                if (al.existe(txtNombreAlbum.Text) == true)
                {
                    lblMensaje.ForeColor = Color.Red;
                    lblMensaje.Text = "El album ya existe, regitre otro";
                }
                else
                {
                    lblMensaje.Text = "";
                    Album a = new Album();
                    a.descripcion = txtNombreAlbum.Text;

                    al.InsertarAlbum(a);
                    refrescarAlbum();
                    refrescarComboAlbum();
                }
            }
        }

        private void btnSeleccionaCancion_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Elige la canción";
            ofd.Filter = "Archivo mp3(*.mp3)|*.mp3 |Archivo mp4(*.mp4)|*.mp4|Archivo avi(*.avi)|*.avi|Todos los archivos|*.*";
            ofd.FilterIndex = 1;
            ofd.InitialDirectory = @"C:\Users\solbe\Source\Repos\ProyectoPersonal1\ReproductorMusica\Musica.Grafica\Musicas y Videos";
            ofd.RestoreDirectory = true;

            try
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    ruta = ofd.FileName;
                    lblMensaje.ForeColor = Color.Green;
                    lblMensaje.Text = "Archivo guardado";
                }
            }
            catch (Exception)
            {
                lblMensaje.ForeColor = Color.Red;
                lblMensaje.Text = "Error al abrir el archivo";
            }
        }

        private void btnInsertarCancion_Click(object sender, EventArgs e)
        {
            if (validarCamposCancion() == false)
            {
                if (cl.existe(txtNombreCancion.Text, Convert.ToInt32(cboAlbum.SelectedValue), Convert.ToInt32(cboInterprete.SelectedValue)) == true)
                {
                    lblMensaje.ForeColor = Color.Red;
                    lblMensaje.Text = "La canción ya existe, regitre otro";
                }
                else
                {
                    Cancion c = new Cancion();
                    c.nombreCancion = txtNombreCancion.Text;
                    c.rutaCancion = ruta;
                    c.idAlbum = Convert.ToInt32(cboAlbum.SelectedValue);
                    c.idInterprete = Convert.ToInt32(cboInterprete.SelectedValue);

                    cl.InsertarCancion(c);
                    refrescarCancion();
                }
            }
        }

        public Boolean validarCamposCancion()
        {
            Boolean ind = false;

            if (txtNombreCancion.Text == "")
            {
                ind = true;
                lblMensaje.ForeColor = Color.Red;
                lblMensaje.Text = "No se permite dejar en blanco este campo, es obligatorio";
            }

            return ind;
        }
    }
}
