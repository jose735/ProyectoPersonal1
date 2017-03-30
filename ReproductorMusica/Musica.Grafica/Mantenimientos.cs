using Musica.Entidades;
using Musica.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Musica.Grafica
{
    public partial class Mantenimientos : Form
    {
        InterpreteLogica il= new InterpreteLogica();
        AlbumLogica al= new AlbumLogica();
        CancionLogica cl= new CancionLogica();
        public String ruta = "";
        public Mantenimientos()
        {
            InitializeComponent();
        }

        private void tcMantenimientos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tcMantenimientos.SelectedIndex == 0)
            {
                epAlbum.Clear();
                refrescarAlbum();
            }

            if (tcMantenimientos.SelectedIndex == 1)
            {
                epCancion.Clear();
                refrescarComboAlbum();
                refrescarComboInterprete();
                refrescarCancion();
            }

            if (tcMantenimientos.SelectedIndex == 2)
            {
                epInterprete.Clear();
                refrescarInterprete();
            }
        }

        private void Mantenimientos_Load(object sender, EventArgs e)
        {
            dgvAlbum.AutoGenerateColumns = false;
            dgvCancion.AutoGenerateColumns = false;
            dgvInterprete.AutoGenerateColumns = false;
            epAlbum.Clear();
            epCancion.Clear();
            epInterprete.Clear();
            refrescarAlbum();
            refrescarComboAlbum();
            refrescarInterprete();
            refrescarComboInterprete();
            refrescarCancion();
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

        private void btnInsertarAlbum_Click(object sender, EventArgs e)
        {
            if (txtNombreAlbum.Text == "")
            {
                epAlbum.SetError(txtNombreAlbum, "No se permite dejar en blanco este campo, es obligatorio");
            }
            else
            {
                epAlbum.Clear();

                if (al.existe(txtNombreAlbum.Text) == true)
                {
                    lblConfirmacionAlbum.ForeColor = Color.Red;
                    lblConfirmacionAlbum.Text = "El album ya existe, regitre otro";
                }
                else
                {
                    Album a = new Album();
                    a.descripcion = txtNombreAlbum.Text;

                    al.InsertarAlbum(a);
                    refrescarAlbum();
                }
            }
        }

        private void btnInsertarInterprete_Click(object sender, EventArgs e)
        {
            if (txtNombreInterprete.Text == "")
            {
                epAlbum.SetError(txtNombreInterprete, "No se permite dejar en blanco este campo, es obligatorio");
            }
            else
            {
                epInterprete.Clear();

                if (il.existe(txtNombreInterprete.Text) == true)
                {
                    lblConfirmacionInterprete.ForeColor = Color.Red;
                    lblConfirmacionInterprete.Text = "El interprete ya existe, regitre otro";
                }
                else
                {
                    Interprete i = new Interprete();
                    i.descripcion = txtNombreInterprete.Text;

                    il.InsertarInterprete(i);
                    refrescarInterprete();
                }
            }
        }

        private void btnGuardarArchivo_Click(object sender, EventArgs e)
        {
            if (txtNombreCancion.Text == "")
            {
                epCancion.SetError(txtNombreCancion, "No se permite dejar en blanco este campo, es obligatorio");
            }
            else
            {
                epCancion.Clear();
                ruta = "";
                sfdArchivo.Filter = "Archivo mp3(*.mp3)|*.mp3 |Archivo mp4(*.mp4)|*.mp4|Archivo avi(*.avi)|*.avi|Todos los archivos|*.*";
                sfdArchivo.FilterIndex = 1;
                sfdArchivo.InitialDirectory = @"C:\Users\solbe\Source\Repos\ProyectoPersonal1\ReproductorMusica\Musica.Grafica\Musicas y Videos";
                sfdArchivo.FileName = txtNombreCancion.Text;
                sfdArchivo.RestoreDirectory = true;

                try
                {
                    if (sfdArchivo.ShowDialog() == DialogResult.OK)
                    {
                        ruta = sfdArchivo.FileName;
                        Stream fileStream = sfdArchivo.OpenFile();
                        StreamWriter sw = new StreamWriter(fileStream);

                        sw.Write(txtNombreCancion.Text);
                        sw.Close();
                        fileStream.Close();

                        lblConfirmacion.ForeColor = Color.Green;
                        lblConfirmacion.Text = "Archivo guardado";
                    }
                }
                catch (Exception)
                {
                    lblConfirmacion.ForeColor = Color.Red;
                    lblConfirmacion.Text = "Error al guardar el archivo";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnInsertarCancion_Click(object sender, EventArgs e)
        {
            if (validarCamposCancion() == false)
            {
                if (cl.existe(txtNombreCancion.Text, Convert.ToInt32(cboAlbum.SelectedValue), Convert.ToInt32(cboInterprete.SelectedValue)) == true)
                {
                    lblConfirmacionCancion.ForeColor = Color.Red;
                    lblConfirmacionCancion.Text = "La canción ya existe, regitre otro";
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
                epCancion.SetError(txtNombreCancion, "No se permite dejar en blanco este campo, es obligatorio");
            }

            if (txtNombreRutaArchivo.Text == "")
            {
                ind = true;
                epCancion.SetError(txtNombreRutaArchivo, "No se permite dejar en blanco este campo, es obligatorio");
            }

            return ind;
        }

        private void btnAbrirArchivo_Click(object sender, EventArgs e)
        {
            ofdArchivo.Filter = "Archivo mp3(*.mp3)|*.mp3 |Archivo mp4(*.mp4)|*.mp4|Archivo avi(*.avi)|*.avi|Todos los archivos|*.*";
            ofdArchivo.FilterIndex = 1;
            ofdArchivo.RestoreDirectory = true;

            try
            {
                if (ofdArchivo.ShowDialog() == DialogResult.OK)
                {
                    txtNombreRutaArchivo.Text = ofdArchivo.FileName;
                }
            }
            catch (Exception)
            {
                lblConfirmacion.ForeColor = Color.Red;
                lblConfirmacion.Text = "Error al abrir el archivo";
            }
        }
    }
}
