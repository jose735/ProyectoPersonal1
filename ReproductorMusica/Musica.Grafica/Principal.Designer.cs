namespace Musica.Grafica
{
    partial class Principal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rdbInterprete = new System.Windows.Forms.RadioButton();
            this.rdbAlbum = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboFiltro = new System.Windows.Forms.ComboBox();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.dgvCanciones = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.wmpReproductor = new AxWMPLib.AxWindowsMediaPlayer();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNombreCancion = new System.Windows.Forms.Label();
            this.lblInterprete = new System.Windows.Forms.Label();
            this.lblAlbum = new System.Windows.Forms.Label();
            this.colNombreCancion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombreInterprete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombreAlbum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRutaAcceso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnIniciarReproductor = new System.Windows.Forms.Button();
            this.btnBuscarCanciones = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCanciones)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmpReproductor)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(893, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuracionToolStripMenuItem});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // configuracionToolStripMenuItem
            // 
            this.configuracionToolStripMenuItem.Name = "configuracionToolStripMenuItem";
            this.configuracionToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.configuracionToolStripMenuItem.Text = "Configuracion";
            this.configuracionToolStripMenuItem.Click += new System.EventHandler(this.configuracionToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // rdbInterprete
            // 
            this.rdbInterprete.AutoSize = true;
            this.rdbInterprete.Location = new System.Drawing.Point(15, 32);
            this.rdbInterprete.Name = "rdbInterprete";
            this.rdbInterprete.Size = new System.Drawing.Size(87, 19);
            this.rdbInterprete.TabIndex = 0;
            this.rdbInterprete.TabStop = true;
            this.rdbInterprete.Text = "Interprete";
            this.rdbInterprete.UseVisualStyleBackColor = true;
            this.rdbInterprete.CheckedChanged += new System.EventHandler(this.rdbInterprete_CheckedChanged);
            // 
            // rdbAlbum
            // 
            this.rdbAlbum.AutoSize = true;
            this.rdbAlbum.Location = new System.Drawing.Point(119, 32);
            this.rdbAlbum.Name = "rdbAlbum";
            this.rdbAlbum.Size = new System.Drawing.Size(65, 19);
            this.rdbAlbum.TabIndex = 1;
            this.rdbAlbum.TabStop = true;
            this.rdbAlbum.Text = "Album";
            this.rdbAlbum.UseVisualStyleBackColor = true;
            this.rdbAlbum.CheckedChanged += new System.EventHandler(this.rdbAlbum_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscarCanciones);
            this.groupBox1.Controls.Add(this.lblBusqueda);
            this.groupBox1.Controls.Add(this.cboFiltro);
            this.groupBox1.Controls.Add(this.rdbInterprete);
            this.groupBox1.Controls.Add(this.rdbAlbum);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 161);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda por";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblAlbum);
            this.groupBox2.Controls.Add(this.lblInterprete);
            this.groupBox2.Controls.Add(this.lblNombreCancion);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(11, 262);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 178);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de la canción";
            // 
            // cboFiltro
            // 
            this.cboFiltro.FormattingEnabled = true;
            this.cboFiltro.Location = new System.Drawing.Point(15, 82);
            this.cboFiltro.Name = "cboFiltro";
            this.cboFiltro.Size = new System.Drawing.Size(121, 23);
            this.cboFiltro.TabIndex = 4;
            this.cboFiltro.SelectedIndexChanged += new System.EventHandler(this.cboFiltro_SelectedIndexChanged);
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Location = new System.Drawing.Point(12, 64);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(34, 15);
            this.lblBusqueda.TabIndex = 4;
            this.lblBusqueda.Text = "vvdv";
            // 
            // dgvCanciones
            // 
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCanciones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvCanciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCanciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCanciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvCanciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCanciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNombreCancion,
            this.colNombreInterprete,
            this.colNombreAlbum,
            this.colRutaAcceso});
            this.dgvCanciones.Location = new System.Drawing.Point(217, 38);
            this.dgvCanciones.Name = "dgvCanciones";
            this.dgvCanciones.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCanciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvCanciones.RowHeadersVisible = false;
            this.dgvCanciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCanciones.Size = new System.Drawing.Size(664, 150);
            this.dgvCanciones.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.wmpReproductor);
            this.panel1.Location = new System.Drawing.Point(336, 194);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 246);
            this.panel1.TabIndex = 5;
            // 
            // wmpReproductor
            // 
            this.wmpReproductor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wmpReproductor.Enabled = true;
            this.wmpReproductor.Location = new System.Drawing.Point(0, 0);
            this.wmpReproductor.Name = "wmpReproductor";
            this.wmpReproductor.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpReproductor.OcxState")));
            this.wmpReproductor.Size = new System.Drawing.Size(545, 246);
            this.wmpReproductor.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Interprete";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Album";
            // 
            // lblNombreCancion
            // 
            this.lblNombreCancion.AutoSize = true;
            this.lblNombreCancion.Location = new System.Drawing.Point(84, 45);
            this.lblNombreCancion.Name = "lblNombreCancion";
            this.lblNombreCancion.Size = new System.Drawing.Size(0, 15);
            this.lblNombreCancion.TabIndex = 3;
            // 
            // lblInterprete
            // 
            this.lblInterprete.AutoSize = true;
            this.lblInterprete.Location = new System.Drawing.Point(99, 87);
            this.lblInterprete.Name = "lblInterprete";
            this.lblInterprete.Size = new System.Drawing.Size(0, 15);
            this.lblInterprete.TabIndex = 4;
            // 
            // lblAlbum
            // 
            this.lblAlbum.AutoSize = true;
            this.lblAlbum.Location = new System.Drawing.Point(77, 125);
            this.lblAlbum.Name = "lblAlbum";
            this.lblAlbum.Size = new System.Drawing.Size(0, 15);
            this.lblAlbum.TabIndex = 5;
            // 
            // colNombreCancion
            // 
            this.colNombreCancion.DataPropertyName = "nombreCancion";
            this.colNombreCancion.HeaderText = "Nombre de la canción";
            this.colNombreCancion.Name = "colNombreCancion";
            this.colNombreCancion.ReadOnly = true;
            // 
            // colNombreInterprete
            // 
            this.colNombreInterprete.DataPropertyName = "nombreInterprete";
            this.colNombreInterprete.HeaderText = "Nombre del Interprete";
            this.colNombreInterprete.Name = "colNombreInterprete";
            this.colNombreInterprete.ReadOnly = true;
            // 
            // colNombreAlbum
            // 
            this.colNombreAlbum.DataPropertyName = "nombreAlbum";
            this.colNombreAlbum.HeaderText = "Nombre del album";
            this.colNombreAlbum.Name = "colNombreAlbum";
            this.colNombreAlbum.ReadOnly = true;
            // 
            // colRutaAcceso
            // 
            this.colRutaAcceso.DataPropertyName = "rutaCancion";
            this.colRutaAcceso.HeaderText = "Ruta de acceso";
            this.colRutaAcceso.Name = "colRutaAcceso";
            this.colRutaAcceso.ReadOnly = true;
            // 
            // btnIniciarReproductor
            // 
            this.btnIniciarReproductor.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarReproductor.Location = new System.Drawing.Point(27, 218);
            this.btnIniciarReproductor.Name = "btnIniciarReproductor";
            this.btnIniciarReproductor.Size = new System.Drawing.Size(202, 23);
            this.btnIniciarReproductor.TabIndex = 6;
            this.btnIniciarReproductor.Text = "Iniciar Reproducción";
            this.btnIniciarReproductor.UseVisualStyleBackColor = true;
            this.btnIniciarReproductor.Click += new System.EventHandler(this.btnIniciarReproductor_Click);
            // 
            // btnBuscarCanciones
            // 
            this.btnBuscarCanciones.Location = new System.Drawing.Point(15, 121);
            this.btnBuscarCanciones.Name = "btnBuscarCanciones";
            this.btnBuscarCanciones.Size = new System.Drawing.Size(121, 23);
            this.btnBuscarCanciones.TabIndex = 7;
            this.btnBuscarCanciones.Text = "Buscar";
            this.btnBuscarCanciones.UseVisualStyleBackColor = true;
            this.btnBuscarCanciones.Click += new System.EventHandler(this.btnBuscarCanciones_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 452);
            this.Controls.Add(this.btnIniciarReproductor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvCanciones);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCanciones)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wmpReproductor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.RadioButton rdbInterprete;
        private System.Windows.Forms.RadioButton rdbAlbum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.ComboBox cboFiltro;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBuscarCanciones;
        private System.Windows.Forms.Label lblAlbum;
        private System.Windows.Forms.Label lblInterprete;
        private System.Windows.Forms.Label lblNombreCancion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCanciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreCancion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreInterprete;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreAlbum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRutaAcceso;
        private System.Windows.Forms.Panel panel1;
        private AxWMPLib.AxWindowsMediaPlayer wmpReproductor;
        private System.Windows.Forms.Button btnIniciarReproductor;
    }
}