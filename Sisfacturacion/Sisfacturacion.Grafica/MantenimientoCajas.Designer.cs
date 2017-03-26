namespace Sisfacturacion.Grafica
{
    partial class MantenimientoCajas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenimientoCajas));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cboUsuarios = new System.Windows.Forms.ComboBox();
            this.dgvCajas = new System.Windows.Forms.DataGridView();
            this.colDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPersonaCaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.btnInsertarCaja = new System.Windows.Forms.Button();
            this.btnModificarCaja = new System.Windows.Forms.Button();
            this.btnEliminarCaja = new System.Windows.Forms.Button();
            this.btnMenuPrincipal = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.btnMostrarEstado = new System.Windows.Forms.Button();
            this.pbCarga = new System.Windows.Forms.ProgressBar();
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.tiempoCarga = new System.Windows.Forms.Timer(this.components);
            this.hpAyuda = new System.Windows.Forms.HelpProvider();
            this.tltAyuda = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCajas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de caja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(284, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Persona en caja";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(124, 29);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(123, 20);
            this.txtDescripcion.TabIndex = 2;
            // 
            // cboUsuarios
            // 
            this.cboUsuarios.FormattingEnabled = true;
            this.cboUsuarios.Location = new System.Drawing.Point(387, 29);
            this.cboUsuarios.Name = "cboUsuarios";
            this.cboUsuarios.Size = new System.Drawing.Size(175, 21);
            this.cboUsuarios.TabIndex = 3;
            // 
            // dgvCajas
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCajas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCajas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCajas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCajas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCajas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCajas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDescripcion,
            this.colPersonaCaja,
            this.colEstado});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCajas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCajas.Location = new System.Drawing.Point(43, 212);
            this.dgvCajas.Name = "dgvCajas";
            this.dgvCajas.ReadOnly = true;
            this.dgvCajas.RowHeadersVisible = false;
            this.dgvCajas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCajas.Size = new System.Drawing.Size(506, 150);
            this.dgvCajas.TabIndex = 4;
            this.dgvCajas.SelectionChanged += new System.EventHandler(this.dgvCajas_SelectionChanged);
            // 
            // colDescripcion
            // 
            this.colDescripcion.DataPropertyName = "descripcion";
            this.colDescripcion.HeaderText = "Nombre de caja";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.ReadOnly = true;
            // 
            // colPersonaCaja
            // 
            this.colPersonaCaja.DataPropertyName = "nombreCompleto";
            this.colPersonaCaja.HeaderText = "Persona en caja";
            this.colPersonaCaja.Name = "colPersonaCaja";
            this.colPersonaCaja.ReadOnly = true;
            // 
            // colEstado
            // 
            this.colEstado.DataPropertyName = "nombreEstado";
            this.colEstado.HeaderText = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.BackgroundImage = global::Sisfacturacion.Grafica.Properties.Resources.Limpiar;
            this.btnLimpiarCampos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpiarCampos.Location = new System.Drawing.Point(109, 134);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(73, 61);
            this.btnLimpiarCampos.TabIndex = 5;
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // btnInsertarCaja
            // 
            this.btnInsertarCaja.BackgroundImage = global::Sisfacturacion.Grafica.Properties.Resources.Nuevo;
            this.btnInsertarCaja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInsertarCaja.Location = new System.Drawing.Point(208, 134);
            this.btnInsertarCaja.Name = "btnInsertarCaja";
            this.btnInsertarCaja.Size = new System.Drawing.Size(80, 61);
            this.btnInsertarCaja.TabIndex = 6;
            this.btnInsertarCaja.UseVisualStyleBackColor = true;
            this.btnInsertarCaja.Click += new System.EventHandler(this.btnInsertarCaja_Click);
            // 
            // btnModificarCaja
            // 
            this.btnModificarCaja.BackgroundImage = global::Sisfacturacion.Grafica.Properties.Resources.Editar;
            this.btnModificarCaja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificarCaja.Location = new System.Drawing.Point(314, 134);
            this.btnModificarCaja.Name = "btnModificarCaja";
            this.btnModificarCaja.Size = new System.Drawing.Size(79, 61);
            this.btnModificarCaja.TabIndex = 7;
            this.btnModificarCaja.UseVisualStyleBackColor = true;
            this.btnModificarCaja.Click += new System.EventHandler(this.btnModificarCaja_Click);
            // 
            // btnEliminarCaja
            // 
            this.btnEliminarCaja.BackgroundImage = global::Sisfacturacion.Grafica.Properties.Resources.Eliminar;
            this.btnEliminarCaja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminarCaja.Location = new System.Drawing.Point(419, 134);
            this.btnEliminarCaja.Name = "btnEliminarCaja";
            this.btnEliminarCaja.Size = new System.Drawing.Size(76, 61);
            this.btnEliminarCaja.TabIndex = 8;
            this.btnEliminarCaja.UseVisualStyleBackColor = true;
            this.btnEliminarCaja.Click += new System.EventHandler(this.btnEliminarCaja_Click);
            // 
            // btnMenuPrincipal
            // 
            this.btnMenuPrincipal.BackgroundImage = global::Sisfacturacion.Grafica.Properties.Resources.Volver;
            this.btnMenuPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenuPrincipal.Location = new System.Drawing.Point(528, 458);
            this.btnMenuPrincipal.Name = "btnMenuPrincipal";
            this.btnMenuPrincipal.Size = new System.Drawing.Size(54, 44);
            this.btnMenuPrincipal.TabIndex = 9;
            this.btnMenuPrincipal.UseVisualStyleBackColor = true;
            this.btnMenuPrincipal.Click += new System.EventHandler(this.btnMenuPrincipal_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.BackColor = System.Drawing.Color.Transparent;
            this.lblMensaje.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(27, 475);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 13);
            this.lblMensaje.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(148, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Estado / mostrar por";
            // 
            // cboEstado
            // 
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(281, 73);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(121, 21);
            this.cboEstado.TabIndex = 12;
            // 
            // btnMostrarEstado
            // 
            this.btnMostrarEstado.BackgroundImage = global::Sisfacturacion.Grafica.Properties.Resources.Buscar;
            this.btnMostrarEstado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMostrarEstado.Location = new System.Drawing.Point(408, 62);
            this.btnMostrarEstado.Name = "btnMostrarEstado";
            this.btnMostrarEstado.Size = new System.Drawing.Size(55, 40);
            this.btnMostrarEstado.TabIndex = 13;
            this.btnMostrarEstado.UseVisualStyleBackColor = true;
            this.btnMostrarEstado.Click += new System.EventHandler(this.btnMostrarEstado_Click);
            // 
            // pbCarga
            // 
            this.pbCarga.Location = new System.Drawing.Point(109, 368);
            this.pbCarga.Name = "pbCarga";
            this.pbCarga.Size = new System.Drawing.Size(386, 23);
            this.pbCarga.TabIndex = 14;
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.BackColor = System.Drawing.Color.Transparent;
            this.lblPorcentaje.Location = new System.Drawing.Point(188, 394);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(0, 13);
            this.lblPorcentaje.TabIndex = 15;
            // 
            // tiempoCarga
            // 
            this.tiempoCarga.Tick += new System.EventHandler(this.tiempoCarga_Tick);
            // 
            // MantenimientoCajas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sisfacturacion.Grafica.Properties.Resources.Mantenimientos_Referentes_a_Personal_y_Clientes;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(594, 514);
            this.Controls.Add(this.lblPorcentaje);
            this.Controls.Add(this.pbCarga);
            this.Controls.Add(this.btnMostrarEstado);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnMenuPrincipal);
            this.Controls.Add(this.btnEliminarCaja);
            this.Controls.Add(this.btnModificarCaja);
            this.Controls.Add(this.btnInsertarCaja);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.dgvCajas);
            this.Controls.Add(this.cboUsuarios);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MantenimientoCajas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Cajas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MantenimientoCajas_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MantenimientoCajas_FormClosed);
            this.Load += new System.EventHandler(this.MantenimientoCajas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCajas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.ComboBox cboUsuarios;
        private System.Windows.Forms.DataGridView dgvCajas;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Button btnInsertarCaja;
        private System.Windows.Forms.Button btnModificarCaja;
        private System.Windows.Forms.Button btnEliminarCaja;
        private System.Windows.Forms.Button btnMenuPrincipal;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPersonaCaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Button btnMostrarEstado;
        private System.Windows.Forms.ProgressBar pbCarga;
        private System.Windows.Forms.Label lblPorcentaje;
        private System.Windows.Forms.Timer tiempoCarga;
        private System.Windows.Forms.HelpProvider hpAyuda;
        private System.Windows.Forms.ToolTip tltAyuda;
    }
}