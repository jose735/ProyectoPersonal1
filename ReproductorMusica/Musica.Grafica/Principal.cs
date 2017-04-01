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
        InterpreteLogica il = new InterpreteLogica();
        AlbumLogica al = new AlbumLogica();
        CancionLogica cl = new CancionLogica();
        public String ruta = "";

        public Principal()
        {
            InitializeComponent();
        }

        public void refrescarComboAlbum()
        {
            cboAlbum.DataSource = al.ObtenerTodosAlbum();
            cboAlbum.ValueMember = "idAlbum";
            cboAlbum.DisplayMember = "descripcion";
            cboAlbum.SelectedIndex = -1;
        }

        public void refrescarComboInterprete()
        {
            cboInterprete.DataSource = il.ObtenerTodosInterprete();
            cboInterprete.ValueMember = "idInterprete";
            cboInterprete.DisplayMember = "descripcion";
            cboInterprete.SelectedIndex = -1;
        }

        private void configuraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimientos m = new Mantenimientos();
            m.ShowDialog();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            refrescarComboAlbum();
            refrescarComboInterprete();
        }

        private void btnBuscarCancion_Click(object sender, EventArgs e)
        {
            if (txtNombreCancion.Text != "")
            {
                cargaBotonesSeleccion(txtNombreCancion.Text, 0, 1);
            }

            if (cboAlbum.SelectedIndex != -1)
            {
                cargaBotonesSeleccion("", Convert.ToInt32(cboAlbum.SelectedValue), 2);
            }

            if (cboInterprete.SelectedIndex != -1)
            {
                cargaBotonesSeleccion("", Convert.ToInt32(cboInterprete.SelectedValue), 3);
            }
        }

        public void cargaBotonesSeleccion(String nombre, int id, int opcion)
        {
            switch (opcion)
            {
                case 1:
                    int cont = 0;
                    for (int i = 0; i < cl.ObtenerPorNombreCancion(nombre).Count; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            cont++;
                            Button boton = new Button();
                            boton.Width = 100;
                            boton.Height = 50;
                            boton.Location = new Point(j * 125, i * 70);
                            boton.Name = "btn" + cont;
                            boton.Text = cl.ObtenerPorNombreCancion(nombre).ElementAt(cont - 1).nombreCancion;
                            boton.Click += new EventHandler(this.btnBoton_Click);
                            pnlBotones.Controls.Add(boton);
                            if (cont == cl.ObtenerPorNombreCancion(nombre).Count)
                            {
                                break;
                            }
                        }
                        if (cont == cl.ObtenerPorNombreCancion(nombre).Count)
                        {
                            break;
                        }
                    }
                    break;
                case 2:
                    int cont1 = 0;
                    for (int i = 0; i < cl.ObtenerPorAlbumCancion(id).Count; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            cont1++;
                            Button boton = new Button();
                            boton.Width = 100;
                            boton.Height = 50;
                            boton.Location = new Point(j * 125, i * 70);
                            boton.Name = "btn" + cont1;
                            boton.Text = cl.ObtenerPorAlbumCancion(id).ElementAt(cont1 - 1).nombreCancion;
                            boton.Click += new EventHandler(this.btnBoton_Click);
                            pnlBotones.Controls.Add(boton);
                            if (cont1 == cl.ObtenerPorAlbumCancion(id).Count)
                            {
                                break;
                            }
                        }
                        if (cont1 == cl.ObtenerPorAlbumCancion(id).Count)
                        {
                            break;
                        }
                    }
                    break;
                case 3:
                    int cont2 = 0;
                    for (int i = 0; i < cl.ObtenerPorInterpreteCancion(id).Count; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            cont2++;
                            Button boton = new Button();
                            boton.Width = 100;
                            boton.Height = 50;
                            boton.Location = new Point(j * 125, i * 70);
                            boton.Name = "btn" + cont2;
                            boton.Font = new Font("Century Gothic", 8);
                            boton.Text = cl.ObtenerPorInterpreteCancion(id).ElementAt(cont2 - 1).nombreCancion;
                            boton.Click += new EventHandler(this.btnBoton_Click);
                            pnlBotones.Controls.Add(boton);
                            if (cont2 == cl.ObtenerPorInterpreteCancion(id).Count)
                            {
                                break;
                            }
                        }
                        if (cont2 == cl.ObtenerPorInterpreteCancion(id).Count)
                        {
                            break;
                        }
                    }
                    break;
            }
        }

        void btnBoton_Click(Object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            Cancion c = cl.ObtenerPorNombreCancion(clickedButton.Text).ElementAt(0);
            lblNumeroCancion.Text = c.idCancion.ToString();
            lblNombreCancion.Text = c.nombreCancion;
            lblInterprete.Text = c.nombreInterprete;
            lblAlbum.Text = c.nombreAlbum;
            ruta = c.rutaCancion;
            wmpReproductor.URL = ruta;
        }
    }
}
