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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreInterprete = new System.Windows.Forms.TextBox();
            this.txtNombreAlbum = new System.Windows.Forms.TextBox();
            this.btnInsertarInterprete = new System.Windows.Forms.Button();
            this.btnInsertarAlbum = new System.Windows.Forms.Button();
            this.dgvInterprete = new System.Windows.Forms.DataGridView();
            this.dgvAlbum = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombreCancion = new System.Windows.Forms.TextBox();
            this.btnSeleccionaCancion = new System.Windows.Forms.Button();
            this.cboInterprete = new System.Windows.Forms.ComboBox();
            this.cboAlbum = new System.Windows.Forms.ComboBox();
            this.btnInsertarCancion = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.dgvCancion = new System.Windows.Forms.DataGridView();
            this.colIdInterprete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombreInterprete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdAlbum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombreAlbum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdCancion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombreCancion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInterprete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAlbum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRutaCancion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInterprete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCancion)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvInterprete);
            this.groupBox1.Controls.Add(this.btnInsertarInterprete);
            this.groupBox1.Controls.Add(this.txtNombreInterprete);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(515, 204);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Interprete";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvAlbum);
            this.groupBox2.Controls.Add(this.btnInsertarAlbum);
            this.groupBox2.Controls.Add(this.txtNombreAlbum);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(533, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(509, 204);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Album";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvCancion);
            this.groupBox3.Controls.Add(this.lblMensaje);
            this.groupBox3.Controls.Add(this.btnInsertarCancion);
            this.groupBox3.Controls.Add(this.cboAlbum);
            this.groupBox3.Controls.Add(this.cboInterprete);
            this.groupBox3.Controls.Add(this.btnSeleccionaCancion);
            this.groupBox3.Controls.Add(this.txtNombreCancion);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 222);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1030, 244);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Canción";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del interprete";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre del album";
            // 
            // txtNombreInterprete
            // 
            this.txtNombreInterprete.Location = new System.Drawing.Point(163, 28);
            this.txtNombreInterprete.Name = "txtNombreInterprete";
            this.txtNombreInterprete.Size = new System.Drawing.Size(100, 23);
            this.txtNombreInterprete.TabIndex = 1;
            // 
            // txtNombreAlbum
            // 
            this.txtNombreAlbum.Location = new System.Drawing.Point(143, 28);
            this.txtNombreAlbum.Name = "txtNombreAlbum";
            this.txtNombreAlbum.Size = new System.Drawing.Size(100, 23);
            this.txtNombreAlbum.TabIndex = 1;
            // 
            // btnInsertarInterprete
            // 
            this.btnInsertarInterprete.Location = new System.Drawing.Point(269, 28);
            this.btnInsertarInterprete.Name = "btnInsertarInterprete";
            this.btnInsertarInterprete.Size = new System.Drawing.Size(136, 23);
            this.btnInsertarInterprete.TabIndex = 2;
            this.btnInsertarInterprete.Text = "Nuevo Interprete";
            this.btnInsertarInterprete.UseVisualStyleBackColor = true;
            this.btnInsertarInterprete.Click += new System.EventHandler(this.btnInsertarInterprete_Click);
            // 
            // btnInsertarAlbum
            // 
            this.btnInsertarAlbum.Location = new System.Drawing.Point(249, 28);
            this.btnInsertarAlbum.Name = "btnInsertarAlbum";
            this.btnInsertarAlbum.Size = new System.Drawing.Size(120, 23);
            this.btnInsertarAlbum.TabIndex = 2;
            this.btnInsertarAlbum.Text = "Nuevo Album";
            this.btnInsertarAlbum.UseVisualStyleBackColor = true;
            this.btnInsertarAlbum.Click += new System.EventHandler(this.btnInsertarAlbum_Click);
            // 
            // dgvInterprete
            // 
            this.dgvInterprete.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInterprete.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvInterprete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInterprete.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdInterprete,
            this.colNombreInterprete});
            this.dgvInterprete.Location = new System.Drawing.Point(84, 57);
            this.dgvInterprete.MultiSelect = false;
            this.dgvInterprete.Name = "dgvInterprete";
            this.dgvInterprete.ReadOnly = true;
            this.dgvInterprete.RowHeadersVisible = false;
            this.dgvInterprete.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInterprete.Size = new System.Drawing.Size(321, 141);
            this.dgvInterprete.TabIndex = 0;
            // 
            // dgvAlbum
            // 
            this.dgvAlbum.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAlbum.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAlbum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlbum.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdAlbum,
            this.colNombreAlbum});
            this.dgvAlbum.Location = new System.Drawing.Point(84, 57);
            this.dgvAlbum.MultiSelect = false;
            this.dgvAlbum.Name = "dgvAlbum";
            this.dgvAlbum.ReadOnly = true;
            this.dgvAlbum.RowHeadersVisible = false;
            this.dgvAlbum.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlbum.Size = new System.Drawing.Size(321, 141);
            this.dgvAlbum.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre de la canción";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Album";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Interprete";
            // 
            // txtNombreCancion
            // 
            this.txtNombreCancion.Location = new System.Drawing.Point(167, 29);
            this.txtNombreCancion.Name = "txtNombreCancion";
            this.txtNombreCancion.Size = new System.Drawing.Size(148, 23);
            this.txtNombreCancion.TabIndex = 3;
            // 
            // btnSeleccionaCancion
            // 
            this.btnSeleccionaCancion.Location = new System.Drawing.Point(9, 58);
            this.btnSeleccionaCancion.Name = "btnSeleccionaCancion";
            this.btnSeleccionaCancion.Size = new System.Drawing.Size(270, 23);
            this.btnSeleccionaCancion.TabIndex = 4;
            this.btnSeleccionaCancion.Text = "Selecciona archivo de audio o video";
            this.btnSeleccionaCancion.UseVisualStyleBackColor = true;
            this.btnSeleccionaCancion.Click += new System.EventHandler(this.btnSeleccionaCancion_Click);
            // 
            // cboInterprete
            // 
            this.cboInterprete.FormattingEnabled = true;
            this.cboInterprete.Location = new System.Drawing.Point(6, 120);
            this.cboInterprete.Name = "cboInterprete";
            this.cboInterprete.Size = new System.Drawing.Size(121, 25);
            this.cboInterprete.TabIndex = 5;
            // 
            // cboAlbum
            // 
            this.cboAlbum.FormattingEnabled = true;
            this.cboAlbum.Location = new System.Drawing.Point(193, 120);
            this.cboAlbum.Name = "cboAlbum";
            this.cboAlbum.Size = new System.Drawing.Size(121, 25);
            this.cboAlbum.TabIndex = 6;
            // 
            // btnInsertarCancion
            // 
            this.btnInsertarCancion.Location = new System.Drawing.Point(6, 165);
            this.btnInsertarCancion.Name = "btnInsertarCancion";
            this.btnInsertarCancion.Size = new System.Drawing.Size(151, 23);
            this.btnInsertarCancion.TabIndex = 7;
            this.btnInsertarCancion.Text = "Nueva Canción";
            this.btnInsertarCancion.UseVisualStyleBackColor = true;
            this.btnInsertarCancion.Click += new System.EventHandler(this.btnInsertarCancion_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(6, 208);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 17);
            this.lblMensaje.TabIndex = 8;
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
            this.colRutaCancion});
            this.dgvCancion.Location = new System.Drawing.Point(521, 22);
            this.dgvCancion.MultiSelect = false;
            this.dgvCancion.Name = "dgvCancion";
            this.dgvCancion.ReadOnly = true;
            this.dgvCancion.RowHeadersVisible = false;
            this.dgvCancion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCancion.Size = new System.Drawing.Size(503, 216);
            this.dgvCancion.TabIndex = 9;
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
            // colIdAlbum
            // 
            this.colIdAlbum.DataPropertyName = "idAlbum";
            this.colIdAlbum.HeaderText = "N° de Album";
            this.colIdAlbum.Name = "colIdAlbum";
            this.colIdAlbum.ReadOnly = true;
            // 
            // colNombreAlbum
            // 
            this.colNombreAlbum.DataPropertyName = "descripcion";
            this.colNombreAlbum.HeaderText = "Nombre del Album";
            this.colNombreAlbum.Name = "colNombreAlbum";
            this.colNombreAlbum.ReadOnly = true;
            // 
            // colIdCancion
            // 
            this.colIdCancion.DataPropertyName = "idCancion";
            this.colIdCancion.HeaderText = "N° de Canción";
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
            // colRutaCancion
            // 
            this.colRutaCancion.DataPropertyName = "rutaCancion";
            this.colRutaCancion.HeaderText = "Ruta de acceso";
            this.colRutaCancion.Name = "colRutaCancion";
            this.colRutaCancion.ReadOnly = true;
            // 
            // Mantenimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 478);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Mantenimientos";
            this.Text = "Mantenimientos";
            this.Load += new System.EventHandler(this.Mantenimientos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInterprete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCancion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnInsertarInterprete;
        private System.Windows.Forms.TextBox txtNombreInterprete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInsertarAlbum;
        private System.Windows.Forms.TextBox txtNombreAlbum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvInterprete;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdInterprete;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreInterprete;
        private System.Windows.Forms.DataGridView dgvAlbum;
        private System.Windows.Forms.DataGridView dgvCancion;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnInsertarCancion;
        private System.Windows.Forms.ComboBox cboAlbum;
        private System.Windows.Forms.ComboBox cboInterprete;
        private System.Windows.Forms.Button btnSeleccionaCancion;
        private System.Windows.Forms.TextBox txtNombreCancion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdAlbum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreAlbum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdCancion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreCancion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInterprete;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAlbum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRutaCancion;
    }
}