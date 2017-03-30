namespace Musica.Grafica
{
    partial class Mantenimientos
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
            this.tcMantenimientos = new System.Windows.Forms.TabControl();
            this.tpAlbum = new System.Windows.Forms.TabPage();
            this.lblConfirmacionAlbum = new System.Windows.Forms.Label();
            this.dgvAlbum = new System.Windows.Forms.DataGridView();
            this.colIdAlbum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripcionAlbum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnInsertarAlbum = new System.Windows.Forms.Button();
            this.txtNombreAlbum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tpCancion = new System.Windows.Forms.TabPage();
            this.lblConfirmacionCancion = new System.Windows.Forms.Label();
            this.lblConfirmacion = new System.Windows.Forms.Label();
            this.btnAbrirArchivo = new System.Windows.Forms.Button();
            this.btnInsertarCancion = new System.Windows.Forms.Button();
            this.dgvCancion = new System.Windows.Forms.DataGridView();
            this.btnGuardarArchivo = new System.Windows.Forms.Button();
            this.cboInterprete = new System.Windows.Forms.ComboBox();
            this.cboAlbum = new System.Windows.Forms.ComboBox();
            this.txtNombreRutaArchivo = new System.Windows.Forms.TextBox();
            this.txtNombreCancion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tpInterprete = new System.Windows.Forms.TabPage();
            this.lblConfirmacionInterprete = new System.Windows.Forms.Label();
            this.txtNombreInterprete = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInsertarInterprete = new System.Windows.Forms.Button();
            this.dgvInterprete = new System.Windows.Forms.DataGridView();
            this.epAlbum = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCancion = new System.Windows.Forms.ErrorProvider(this.components);
            this.epInterprete = new System.Windows.Forms.ErrorProvider(this.components);
            this.sfdArchivo = new System.Windows.Forms.SaveFileDialog();
            this.ofdArchivo = new System.Windows.Forms.OpenFileDialog();
            this.colIdInterprete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombreInterprete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdCancion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombreCancion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInterprete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAlbum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRuta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcMantenimientos.SuspendLayout();
            this.tpAlbum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbum)).BeginInit();
            this.tpCancion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCancion)).BeginInit();
            this.tpInterprete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInterprete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epAlbum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCancion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epInterprete)).BeginInit();
            this.SuspendLayout();
            // 
            // tcMantenimientos
            // 
            this.tcMantenimientos.Controls.Add(this.tpAlbum);
            this.tcMantenimientos.Controls.Add(this.tpCancion);
            this.tcMantenimientos.Controls.Add(this.tpInterprete);
            this.tcMantenimientos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMantenimientos.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcMantenimientos.Location = new System.Drawing.Point(0, 0);
            this.tcMantenimientos.Name = "tcMantenimientos";
            this.tcMantenimientos.SelectedIndex = 0;
            this.tcMantenimientos.Size = new System.Drawing.Size(664, 394);
            this.tcMantenimientos.TabIndex = 0;
            this.tcMantenimientos.SelectedIndexChanged += new System.EventHandler(this.tcMantenimientos_SelectedIndexChanged);
            // 
            // tpAlbum
            // 
            this.tpAlbum.BackColor = System.Drawing.SystemColors.Control;
            this.tpAlbum.Controls.Add(this.lblConfirmacionAlbum);
            this.tpAlbum.Controls.Add(this.dgvAlbum);
            this.tpAlbum.Controls.Add(this.btnInsertarAlbum);
            this.tpAlbum.Controls.Add(this.txtNombreAlbum);
            this.tpAlbum.Controls.Add(this.label1);
            this.tpAlbum.Location = new System.Drawing.Point(4, 24);
            this.tpAlbum.Name = "tpAlbum";
            this.tpAlbum.Padding = new System.Windows.Forms.Padding(3);
            this.tpAlbum.Size = new System.Drawing.Size(656, 366);
            this.tpAlbum.TabIndex = 0;
            this.tpAlbum.Text = "Conf. de Album";
            this.tpAlbum.ToolTipText = "Configuracion de los albumes registrados";
            // 
            // lblConfirmacionAlbum
            // 
            this.lblConfirmacionAlbum.AutoSize = true;
            this.lblConfirmacionAlbum.Location = new System.Drawing.Point(241, 123);
            this.lblConfirmacionAlbum.Name = "lblConfirmacionAlbum";
            this.lblConfirmacionAlbum.Size = new System.Drawing.Size(0, 15);
            this.lblConfirmacionAlbum.TabIndex = 4;
            // 
            // dgvAlbum
            // 
            this.dgvAlbum.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAlbum.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAlbum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlbum.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdAlbum,
            this.colDescripcionAlbum});
            this.dgvAlbum.Location = new System.Drawing.Point(98, 148);
            this.dgvAlbum.Name = "dgvAlbum";
            this.dgvAlbum.ReadOnly = true;
            this.dgvAlbum.RowHeadersVisible = false;
            this.dgvAlbum.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlbum.Size = new System.Drawing.Size(471, 150);
            this.dgvAlbum.TabIndex = 3;
            // 
            // colIdAlbum
            // 
            this.colIdAlbum.DataPropertyName = "idAlbum";
            this.colIdAlbum.HeaderText = "N° de Album";
            this.colIdAlbum.Name = "colIdAlbum";
            this.colIdAlbum.ReadOnly = true;
            // 
            // colDescripcionAlbum
            // 
            this.colDescripcionAlbum.DataPropertyName = "descripcion";
            this.colDescripcionAlbum.HeaderText = "Nombre del Album";
            this.colDescripcionAlbum.Name = "colDescripcionAlbum";
            this.colDescripcionAlbum.ReadOnly = true;
            // 
            // btnInsertarAlbum
            // 
            this.btnInsertarAlbum.Location = new System.Drawing.Point(98, 119);
            this.btnInsertarAlbum.Name = "btnInsertarAlbum";
            this.btnInsertarAlbum.Size = new System.Drawing.Size(137, 23);
            this.btnInsertarAlbum.TabIndex = 2;
            this.btnInsertarAlbum.Text = "Nuevo Album";
            this.btnInsertarAlbum.UseVisualStyleBackColor = true;
            this.btnInsertarAlbum.Click += new System.EventHandler(this.btnInsertarAlbum_Click);
            // 
            // txtNombreAlbum
            // 
            this.txtNombreAlbum.Location = new System.Drawing.Point(148, 23);
            this.txtNombreAlbum.Name = "txtNombreAlbum";
            this.txtNombreAlbum.Size = new System.Drawing.Size(143, 23);
            this.txtNombreAlbum.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del album";
            // 
            // tpCancion
            // 
            this.tpCancion.BackColor = System.Drawing.SystemColors.Control;
            this.tpCancion.Controls.Add(this.lblConfirmacionCancion);
            this.tpCancion.Controls.Add(this.lblConfirmacion);
            this.tpCancion.Controls.Add(this.btnAbrirArchivo);
            this.tpCancion.Controls.Add(this.btnInsertarCancion);
            this.tpCancion.Controls.Add(this.dgvCancion);
            this.tpCancion.Controls.Add(this.btnGuardarArchivo);
            this.tpCancion.Controls.Add(this.cboInterprete);
            this.tpCancion.Controls.Add(this.cboAlbum);
            this.tpCancion.Controls.Add(this.txtNombreRutaArchivo);
            this.tpCancion.Controls.Add(this.txtNombreCancion);
            this.tpCancion.Controls.Add(this.label6);
            this.tpCancion.Controls.Add(this.label5);
            this.tpCancion.Controls.Add(this.label4);
            this.tpCancion.Controls.Add(this.label3);
            this.tpCancion.Location = new System.Drawing.Point(4, 24);
            this.tpCancion.Name = "tpCancion";
            this.tpCancion.Padding = new System.Windows.Forms.Padding(3);
            this.tpCancion.Size = new System.Drawing.Size(656, 366);
            this.tpCancion.TabIndex = 1;
            this.tpCancion.Text = "Conf. de Canción";
            this.tpCancion.ToolTipText = "Configuración de las canciones registradas";
            // 
            // lblConfirmacionCancion
            // 
            this.lblConfirmacionCancion.AutoSize = true;
            this.lblConfirmacionCancion.Location = new System.Drawing.Point(166, 168);
            this.lblConfirmacionCancion.Name = "lblConfirmacionCancion";
            this.lblConfirmacionCancion.Size = new System.Drawing.Size(0, 15);
            this.lblConfirmacionCancion.TabIndex = 14;
            // 
            // lblConfirmacion
            // 
            this.lblConfirmacion.AutoSize = true;
            this.lblConfirmacion.Location = new System.Drawing.Point(403, 60);
            this.lblConfirmacion.Name = "lblConfirmacion";
            this.lblConfirmacion.Size = new System.Drawing.Size(0, 15);
            this.lblConfirmacion.TabIndex = 13;
            // 
            // btnAbrirArchivo
            // 
            this.btnAbrirArchivo.Location = new System.Drawing.Point(206, 86);
            this.btnAbrirArchivo.Name = "btnAbrirArchivo";
            this.btnAbrirArchivo.Size = new System.Drawing.Size(166, 23);
            this.btnAbrirArchivo.TabIndex = 12;
            this.btnAbrirArchivo.Text = "Abrir audio / video";
            this.btnAbrirArchivo.UseVisualStyleBackColor = true;
            this.btnAbrirArchivo.Click += new System.EventHandler(this.btnAbrirArchivo_Click);
            // 
            // btnInsertarCancion
            // 
            this.btnInsertarCancion.Location = new System.Drawing.Point(29, 164);
            this.btnInsertarCancion.Name = "btnInsertarCancion";
            this.btnInsertarCancion.Size = new System.Drawing.Size(131, 23);
            this.btnInsertarCancion.TabIndex = 11;
            this.btnInsertarCancion.Text = "Nueva Canción";
            this.btnInsertarCancion.UseVisualStyleBackColor = true;
            this.btnInsertarCancion.Click += new System.EventHandler(this.btnInsertarCancion_Click);
            // 
            // dgvCancion
            // 
            this.dgvCancion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCancion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCancion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCancion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdCancion,
            this.colNombreCancion,
            this.colInterprete,
            this.colAlbum,
            this.colRuta});
            this.dgvCancion.Location = new System.Drawing.Point(20, 193);
            this.dgvCancion.Name = "dgvCancion";
            this.dgvCancion.ReadOnly = true;
            this.dgvCancion.RowHeadersVisible = false;
            this.dgvCancion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCancion.Size = new System.Drawing.Size(614, 150);
            this.dgvCancion.TabIndex = 10;
            // 
            // btnGuardarArchivo
            // 
            this.btnGuardarArchivo.Location = new System.Drawing.Point(378, 86);
            this.btnGuardarArchivo.Name = "btnGuardarArchivo";
            this.btnGuardarArchivo.Size = new System.Drawing.Size(175, 23);
            this.btnGuardarArchivo.TabIndex = 8;
            this.btnGuardarArchivo.Text = "Guardar audio / video";
            this.btnGuardarArchivo.UseVisualStyleBackColor = true;
            this.btnGuardarArchivo.Click += new System.EventHandler(this.btnGuardarArchivo_Click);
            // 
            // cboInterprete
            // 
            this.cboInterprete.FormattingEnabled = true;
            this.cboInterprete.Location = new System.Drawing.Point(367, 123);
            this.cboInterprete.Name = "cboInterprete";
            this.cboInterprete.Size = new System.Drawing.Size(121, 23);
            this.cboInterprete.TabIndex = 7;
            // 
            // cboAlbum
            // 
            this.cboAlbum.FormattingEnabled = true;
            this.cboAlbum.Location = new System.Drawing.Point(79, 123);
            this.cboAlbum.Name = "cboAlbum";
            this.cboAlbum.Size = new System.Drawing.Size(121, 23);
            this.cboAlbum.TabIndex = 6;
            // 
            // txtNombreRutaArchivo
            // 
            this.txtNombreRutaArchivo.Location = new System.Drawing.Point(206, 57);
            this.txtNombreRutaArchivo.Name = "txtNombreRutaArchivo";
            this.txtNombreRutaArchivo.Size = new System.Drawing.Size(191, 23);
            this.txtNombreRutaArchivo.TabIndex = 5;
            // 
            // txtNombreCancion
            // 
            this.txtNombreCancion.Location = new System.Drawing.Point(177, 18);
            this.txtNombreCancion.Name = "txtNombreCancion";
            this.txtNombreCancion.Size = new System.Drawing.Size(184, 23);
            this.txtNombreCancion.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Archivo de audio y/o video";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nombre de la canción";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Album";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Interprete";
            // 
            // tpInterprete
            // 
            this.tpInterprete.BackColor = System.Drawing.SystemColors.Control;
            this.tpInterprete.Controls.Add(this.lblConfirmacionInterprete);
            this.tpInterprete.Controls.Add(this.txtNombreInterprete);
            this.tpInterprete.Controls.Add(this.label2);
            this.tpInterprete.Controls.Add(this.btnInsertarInterprete);
            this.tpInterprete.Controls.Add(this.dgvInterprete);
            this.tpInterprete.Location = new System.Drawing.Point(4, 24);
            this.tpInterprete.Name = "tpInterprete";
            this.tpInterprete.Padding = new System.Windows.Forms.Padding(3);
            this.tpInterprete.Size = new System.Drawing.Size(656, 366);
            this.tpInterprete.TabIndex = 2;
            this.tpInterprete.Text = "Conf. de Interprete";
            this.tpInterprete.ToolTipText = "Configuración de los interpretes Registrados";
            // 
            // lblConfirmacionInterprete
            // 
            this.lblConfirmacionInterprete.AutoSize = true;
            this.lblConfirmacionInterprete.Location = new System.Drawing.Point(211, 122);
            this.lblConfirmacionInterprete.Name = "lblConfirmacionInterprete";
            this.lblConfirmacionInterprete.Size = new System.Drawing.Size(0, 15);
            this.lblConfirmacionInterprete.TabIndex = 4;
            // 
            // txtNombreInterprete
            // 
            this.txtNombreInterprete.Location = new System.Drawing.Point(167, 21);
            this.txtNombreInterprete.Name = "txtNombreInterprete";
            this.txtNombreInterprete.Size = new System.Drawing.Size(169, 23);
            this.txtNombreInterprete.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre del Interprete";
            // 
            // btnInsertarInterprete
            // 
            this.btnInsertarInterprete.Location = new System.Drawing.Point(73, 118);
            this.btnInsertarInterprete.Name = "btnInsertarInterprete";
            this.btnInsertarInterprete.Size = new System.Drawing.Size(132, 23);
            this.btnInsertarInterprete.TabIndex = 1;
            this.btnInsertarInterprete.Text = "Nuevo Interprete";
            this.btnInsertarInterprete.UseVisualStyleBackColor = true;
            this.btnInsertarInterprete.Click += new System.EventHandler(this.btnInsertarInterprete_Click);
            // 
            // dgvInterprete
            // 
            this.dgvInterprete.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInterprete.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvInterprete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInterprete.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdInterprete,
            this.colNombreInterprete});
            this.dgvInterprete.Location = new System.Drawing.Point(73, 147);
            this.dgvInterprete.Name = "dgvInterprete";
            this.dgvInterprete.ReadOnly = true;
            this.dgvInterprete.RowHeadersVisible = false;
            this.dgvInterprete.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInterprete.Size = new System.Drawing.Size(490, 150);
            this.dgvInterprete.TabIndex = 0;
            // 
            // epAlbum
            // 
            this.epAlbum.ContainerControl = this;
            // 
            // epCancion
            // 
            this.epCancion.ContainerControl = this;
            // 
            // epInterprete
            // 
            this.epInterprete.ContainerControl = this;
            // 
            // sfdArchivo
            // 
            this.sfdArchivo.Title = "Guardar Archivo de Audio y/o Video";
            // 
            // ofdArchivo
            // 
            this.ofdArchivo.FileName = "openFileDialog1";
            this.ofdArchivo.Title = "Escojer el archivo de audio o video";
            // 
            // colIdInterprete
            // 
            this.colIdInterprete.DataPropertyName = "idInterprete";
            this.colIdInterprete.HeaderText = "N° de Interprete";
            this.colIdInterprete.Name = "colIdInterprete";
            this.colIdInterprete.ReadOnly = true;
            // 
            // colNombreInterprete
            // 
            this.colNombreInterprete.DataPropertyName = "descripcion";
            this.colNombreInterprete.HeaderText = "Nombre del Interprete";
            this.colNombreInterprete.Name = "colNombreInterprete";
            this.colNombreInterprete.ReadOnly = true;
            // 
            // colIdCancion
            // 
            this.colIdCancion.DataPropertyName = "idCancion";
            this.colIdCancion.HeaderText = "N° de Cancion";
            this.colIdCancion.Name = "colIdCancion";
            this.colIdCancion.ReadOnly = true;
            // 
            // colNombreCancion
            // 
            this.colNombreCancion.DataPropertyName = "nombreCancion";
            this.colNombreCancion.HeaderText = "Nombre de la Canción";
            this.colNombreCancion.Name = "colNombreCancion";
            this.colNombreCancion.ReadOnly = true;
            // 
            // colInterprete
            // 
            this.colInterprete.DataPropertyName = "nombreInterprete";
            this.colInterprete.HeaderText = "Interprete";
            this.colInterprete.Name = "colInterprete";
            this.colInterprete.ReadOnly = true;
            // 
            // colAlbum
            // 
            this.colAlbum.DataPropertyName = "nombreAlbum";
            this.colAlbum.HeaderText = "Album";
            this.colAlbum.Name = "colAlbum";
            this.colAlbum.ReadOnly = true;
            // 
            // colRuta
            // 
            this.colRuta.DataPropertyName = "rutaCancion";
            this.colRuta.HeaderText = "Ruta de Acceso";
            this.colRuta.Name = "colRuta";
            this.colRuta.ReadOnly = true;
            // 
            // Mantenimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 394);
            this.Controls.Add(this.tcMantenimientos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Mantenimientos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuración de Album, Canción e Interprete";
            this.Load += new System.EventHandler(this.Mantenimientos_Load);
            this.tcMantenimientos.ResumeLayout(false);
            this.tpAlbum.ResumeLayout(false);
            this.tpAlbum.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbum)).EndInit();
            this.tpCancion.ResumeLayout(false);
            this.tpCancion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCancion)).EndInit();
            this.tpInterprete.ResumeLayout(false);
            this.tpInterprete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInterprete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epAlbum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCancion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epInterprete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMantenimientos;
        private System.Windows.Forms.TabPage tpAlbum;
        private System.Windows.Forms.TabPage tpCancion;
        private System.Windows.Forms.TabPage tpInterprete;
        private System.Windows.Forms.DataGridView dgvAlbum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdAlbum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcionAlbum;
        private System.Windows.Forms.Button btnInsertarAlbum;
        private System.Windows.Forms.TextBox txtNombreAlbum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardarArchivo;
        private System.Windows.Forms.ComboBox cboInterprete;
        private System.Windows.Forms.ComboBox cboAlbum;
        private System.Windows.Forms.TextBox txtNombreRutaArchivo;
        private System.Windows.Forms.TextBox txtNombreCancion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreInterprete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInsertarInterprete;
        private System.Windows.Forms.DataGridView dgvInterprete;
        private System.Windows.Forms.DataGridView dgvCancion;
        private System.Windows.Forms.Button btnInsertarCancion;
        private System.Windows.Forms.ErrorProvider epAlbum;
        private System.Windows.Forms.ErrorProvider epCancion;
        private System.Windows.Forms.ErrorProvider epInterprete;
        private System.Windows.Forms.SaveFileDialog sfdArchivo;
        private System.Windows.Forms.Button btnAbrirArchivo;
        private System.Windows.Forms.OpenFileDialog ofdArchivo;
        private System.Windows.Forms.Label lblConfirmacion;
        private System.Windows.Forms.Label lblConfirmacionAlbum;
        private System.Windows.Forms.Label lblConfirmacionInterprete;
        private System.Windows.Forms.Label lblConfirmacionCancion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdInterprete;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreInterprete;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdCancion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreCancion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInterprete;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAlbum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRuta;
    }
}