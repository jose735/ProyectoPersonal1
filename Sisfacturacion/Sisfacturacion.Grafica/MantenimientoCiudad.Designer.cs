namespace Sisfacturacion.Grafica
{
    partial class MantenimientoCiudad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigoCiudad = new System.Windows.Forms.TextBox();
            this.txtNombreCiudad = new System.Windows.Forms.TextBox();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.btnInsertarCiudad = new System.Windows.Forms.Button();
            this.btnModificarCiudad = new System.Windows.Forms.Button();
            this.btnMostrarEstado = new System.Windows.Forms.Button();
            this.btnMenuPrincipal = new System.Windows.Forms.Button();
            this.btnEliminarCiudad = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.dgvCiudades = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbCarga = new System.Windows.Forms.ProgressBar();
            this.tiempoCarga = new System.Windows.Forms.Timer(this.components);
            this.lblPorcentaje = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCiudades)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código de ciudad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(317, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre de la ciudad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(137, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estado / mostrar por";
            // 
            // txtCodigoCiudad
            // 
            this.txtCodigoCiudad.Location = new System.Drawing.Point(140, 37);
            this.txtCodigoCiudad.Name = "txtCodigoCiudad";
            this.txtCodigoCiudad.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoCiudad.TabIndex = 3;
            // 
            // txtNombreCiudad
            // 
            this.txtNombreCiudad.Location = new System.Drawing.Point(444, 37);
            this.txtNombreCiudad.Name = "txtNombreCiudad";
            this.txtNombreCiudad.Size = new System.Drawing.Size(100, 20);
            this.txtNombreCiudad.TabIndex = 4;
            // 
            // cboEstado
            // 
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(270, 79);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(121, 21);
            this.cboEstado.TabIndex = 5;
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.BackgroundImage = global::Sisfacturacion.Grafica.Properties.Resources.Limpiar;
            this.btnLimpiarCampos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpiarCampos.Location = new System.Drawing.Point(34, 115);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(74, 59);
            this.btnLimpiarCampos.TabIndex = 6;
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // btnInsertarCiudad
            // 
            this.btnInsertarCiudad.BackgroundImage = global::Sisfacturacion.Grafica.Properties.Resources.Nuevo;
            this.btnInsertarCiudad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInsertarCiudad.Location = new System.Drawing.Point(174, 115);
            this.btnInsertarCiudad.Name = "btnInsertarCiudad";
            this.btnInsertarCiudad.Size = new System.Drawing.Size(73, 59);
            this.btnInsertarCiudad.TabIndex = 7;
            this.btnInsertarCiudad.UseVisualStyleBackColor = true;
            this.btnInsertarCiudad.Click += new System.EventHandler(this.btnInsertarCiudad_Click);
            // 
            // btnModificarCiudad
            // 
            this.btnModificarCiudad.BackgroundImage = global::Sisfacturacion.Grafica.Properties.Resources.Editar;
            this.btnModificarCiudad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificarCiudad.Location = new System.Drawing.Point(309, 115);
            this.btnModificarCiudad.Name = "btnModificarCiudad";
            this.btnModificarCiudad.Size = new System.Drawing.Size(71, 59);
            this.btnModificarCiudad.TabIndex = 8;
            this.btnModificarCiudad.UseVisualStyleBackColor = true;
            this.btnModificarCiudad.Click += new System.EventHandler(this.btnModificarCiudad_Click);
            // 
            // btnMostrarEstado
            // 
            this.btnMostrarEstado.BackgroundImage = global::Sisfacturacion.Grafica.Properties.Resources.Buscar;
            this.btnMostrarEstado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMostrarEstado.Location = new System.Drawing.Point(397, 70);
            this.btnMostrarEstado.Name = "btnMostrarEstado";
            this.btnMostrarEstado.Size = new System.Drawing.Size(51, 39);
            this.btnMostrarEstado.TabIndex = 9;
            this.btnMostrarEstado.UseVisualStyleBackColor = true;
            this.btnMostrarEstado.Click += new System.EventHandler(this.btnMostrarEstado_Click);
            // 
            // btnMenuPrincipal
            // 
            this.btnMenuPrincipal.BackgroundImage = global::Sisfacturacion.Grafica.Properties.Resources.Volver;
            this.btnMenuPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenuPrincipal.Location = new System.Drawing.Point(509, 417);
            this.btnMenuPrincipal.Name = "btnMenuPrincipal";
            this.btnMenuPrincipal.Size = new System.Drawing.Size(58, 45);
            this.btnMenuPrincipal.TabIndex = 11;
            this.btnMenuPrincipal.UseVisualStyleBackColor = true;
            this.btnMenuPrincipal.Click += new System.EventHandler(this.btnMenuPrincipal_Click);
            // 
            // btnEliminarCiudad
            // 
            this.btnEliminarCiudad.BackgroundImage = global::Sisfacturacion.Grafica.Properties.Resources.Eliminar;
            this.btnEliminarCiudad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminarCiudad.Location = new System.Drawing.Point(444, 115);
            this.btnEliminarCiudad.Name = "btnEliminarCiudad";
            this.btnEliminarCiudad.Size = new System.Drawing.Size(65, 59);
            this.btnEliminarCiudad.TabIndex = 12;
            this.btnEliminarCiudad.UseVisualStyleBackColor = true;
            this.btnEliminarCiudad.Click += new System.EventHandler(this.btnEliminarCiudad_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(16, 404);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 13);
            this.lblMensaje.TabIndex = 13;
            // 
            // dgvCiudades
            // 
            this.dgvCiudades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCiudades.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCiudades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCiudades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colDescripcion,
            this.colEstado});
            this.dgvCiudades.Location = new System.Drawing.Point(38, 196);
            this.dgvCiudades.Name = "dgvCiudades";
            this.dgvCiudades.ReadOnly = true;
            this.dgvCiudades.RowHeadersVisible = false;
            this.dgvCiudades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCiudades.Size = new System.Drawing.Size(506, 150);
            this.dgvCiudades.TabIndex = 14;
            this.dgvCiudades.SelectionChanged += new System.EventHandler(this.dgvCiudades_SelectionChanged);
            // 
            // colCodigo
            // 
            this.colCodigo.DataPropertyName = "idCiudad";
            this.colCodigo.HeaderText = "Código de ciudad";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            // 
            // colDescripcion
            // 
            this.colDescripcion.DataPropertyName = "descripcion";
            this.colDescripcion.HeaderText = "Nombre de la ciudad";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.ReadOnly = true;
            // 
            // colEstado
            // 
            this.colEstado.DataPropertyName = "nombreEstado";
            this.colEstado.HeaderText = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
            // 
            // pbCarga
            // 
            this.pbCarga.Location = new System.Drawing.Point(89, 352);
            this.pbCarga.Name = "pbCarga";
            this.pbCarga.Size = new System.Drawing.Size(404, 23);
            this.pbCarga.TabIndex = 15;
            // 
            // tiempoCarga
            // 
            this.tiempoCarga.Tick += new System.EventHandler(this.tiempoCarga_Tick);
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.Location = new System.Drawing.Point(164, 378);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(0, 13);
            this.lblPorcentaje.TabIndex = 16;
            // 
            // MantenimientoCiudad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 474);
            this.Controls.Add(this.lblPorcentaje);
            this.Controls.Add(this.pbCarga);
            this.Controls.Add(this.dgvCiudades);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnEliminarCiudad);
            this.Controls.Add(this.btnMenuPrincipal);
            this.Controls.Add(this.btnMostrarEstado);
            this.Controls.Add(this.btnModificarCiudad);
            this.Controls.Add(this.btnInsertarCiudad);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.txtNombreCiudad);
            this.Controls.Add(this.txtCodigoCiudad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MantenimientoCiudad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Ciudad";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MantenimientoCiudad_FormClosed);
            this.Load += new System.EventHandler(this.MantenimientoCiudad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCiudades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigoCiudad;
        private System.Windows.Forms.TextBox txtNombreCiudad;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Button btnInsertarCiudad;
        private System.Windows.Forms.Button btnModificarCiudad;
        private System.Windows.Forms.Button btnMostrarEstado;
        private System.Windows.Forms.Button btnMenuPrincipal;
        private System.Windows.Forms.Button btnEliminarCiudad;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.DataGridView dgvCiudades;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.ProgressBar pbCarga;
        private System.Windows.Forms.Timer tiempoCarga;
        private System.Windows.Forms.Label lblPorcentaje;
    }
}