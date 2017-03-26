namespace Sisfacturacion.Grafica
{
    partial class MantenimientoPromociones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenimientoPromociones));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvPromociones = new System.Windows.Forms.DataGridView();
            this.colCodigoProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombreProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPorcentaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstadoProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.nudPorcentaje = new System.Windows.Forms.NumericUpDown();
            this.btnMostrarEstado = new System.Windows.Forms.Button();
            this.btnEliminarPromocion = new System.Windows.Forms.Button();
            this.btnMenuPrincipal = new System.Windows.Forms.Button();
            this.btnModificarPromocion = new System.Windows.Forms.Button();
            this.btnInsertarPromocion = new System.Windows.Forms.Button();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.tiempoCarga = new System.Windows.Forms.Timer(this.components);
            this.hpAyuda = new System.Windows.Forms.HelpProvider();
            this.tltAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.pbCarga = new System.Windows.Forms.ProgressBar();
            this.lblPorcentaje = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromociones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPorcentaje)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Porcentaje de descuento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(166, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Estado / Mostrar por";
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.BackColor = System.Drawing.Color.Transparent;
            this.lblMensaje.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(15, 655);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 13);
            this.lblMensaje.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(219, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "%";
            // 
            // dgvProductos
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colNombre,
            this.colCantidad,
            this.colPrecio,
            this.colEstado});
            this.dgvProductos.Location = new System.Drawing.Point(6, 19);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(590, 150);
            this.dgvProductos.TabIndex = 4;
            // 
            // colCodigo
            // 
            this.colCodigo.DataPropertyName = "idProducto";
            this.colCodigo.HeaderText = "Código de producto";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            // 
            // colNombre
            // 
            this.colNombre.DataPropertyName = "nombre";
            this.colNombre.HeaderText = "Nombre de producto";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            // 
            // colCantidad
            // 
            this.colCantidad.DataPropertyName = "cantidad";
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.ReadOnly = true;
            // 
            // colPrecio
            // 
            this.colPrecio.DataPropertyName = "precio";
            this.colPrecio.HeaderText = "Precio";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.ReadOnly = true;
            // 
            // colEstado
            // 
            this.colEstado.DataPropertyName = "nombreEstado";
            this.colEstado.HeaderText = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dgvProductos);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 192);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista productos";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dgvPromociones);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 398);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(608, 186);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Productos con promociones";
            // 
            // dgvPromociones
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPromociones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPromociones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPromociones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPromociones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPromociones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigoProd,
            this.colNombreProd,
            this.colPorcentaje,
            this.colEstadoProd});
            this.dgvPromociones.Location = new System.Drawing.Point(6, 32);
            this.dgvPromociones.Name = "dgvPromociones";
            this.dgvPromociones.ReadOnly = true;
            this.dgvPromociones.RowHeadersVisible = false;
            this.dgvPromociones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPromociones.Size = new System.Drawing.Size(596, 133);
            this.dgvPromociones.TabIndex = 7;
            this.dgvPromociones.SelectionChanged += new System.EventHandler(this.dgvPromociones_SelectionChanged);
            // 
            // colCodigoProd
            // 
            this.colCodigoProd.DataPropertyName = "idProducto";
            this.colCodigoProd.HeaderText = "Código de producto";
            this.colCodigoProd.Name = "colCodigoProd";
            this.colCodigoProd.ReadOnly = true;
            // 
            // colNombreProd
            // 
            this.colNombreProd.DataPropertyName = "nombreProducto";
            this.colNombreProd.HeaderText = "Nombre de producto";
            this.colNombreProd.Name = "colNombreProd";
            this.colNombreProd.ReadOnly = true;
            // 
            // colPorcentaje
            // 
            this.colPorcentaje.DataPropertyName = "porcentajeDescuento";
            this.colPorcentaje.HeaderText = "Descuento";
            this.colPorcentaje.Name = "colPorcentaje";
            this.colPorcentaje.ReadOnly = true;
            // 
            // colEstadoProd
            // 
            this.colEstadoProd.DataPropertyName = "nombreEstado";
            this.colEstadoProd.HeaderText = "Estado";
            this.colEstadoProd.Name = "colEstadoProd";
            this.colEstadoProd.ReadOnly = true;
            // 
            // cboEstado
            // 
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(299, 271);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(121, 21);
            this.cboEstado.TabIndex = 13;
            // 
            // nudPorcentaje
            // 
            this.nudPorcentaje.Location = new System.Drawing.Point(165, 29);
            this.nudPorcentaje.Name = "nudPorcentaje";
            this.nudPorcentaje.Size = new System.Drawing.Size(48, 20);
            this.nudPorcentaje.TabIndex = 14;
            // 
            // btnMostrarEstado
            // 
            this.btnMostrarEstado.BackgroundImage = global::Sisfacturacion.Grafica.Properties.Resources.Buscar;
            this.btnMostrarEstado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMostrarEstado.Location = new System.Drawing.Point(428, 259);
            this.btnMostrarEstado.Name = "btnMostrarEstado";
            this.btnMostrarEstado.Size = new System.Drawing.Size(53, 43);
            this.btnMostrarEstado.TabIndex = 12;
            this.btnMostrarEstado.UseVisualStyleBackColor = true;
            this.btnMostrarEstado.Click += new System.EventHandler(this.btnMostrarEstado_Click);
            // 
            // btnEliminarPromocion
            // 
            this.btnEliminarPromocion.BackgroundImage = global::Sisfacturacion.Grafica.Properties.Resources.Eliminar;
            this.btnEliminarPromocion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminarPromocion.Location = new System.Drawing.Point(428, 318);
            this.btnEliminarPromocion.Name = "btnEliminarPromocion";
            this.btnEliminarPromocion.Size = new System.Drawing.Size(70, 61);
            this.btnEliminarPromocion.TabIndex = 11;
            this.btnEliminarPromocion.UseVisualStyleBackColor = true;
            this.btnEliminarPromocion.Click += new System.EventHandler(this.btnEliminarPromocion_Click);
            // 
            // btnMenuPrincipal
            // 
            this.btnMenuPrincipal.BackgroundImage = global::Sisfacturacion.Grafica.Properties.Resources.Volver;
            this.btnMenuPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenuPrincipal.Location = new System.Drawing.Point(571, 632);
            this.btnMenuPrincipal.Name = "btnMenuPrincipal";
            this.btnMenuPrincipal.Size = new System.Drawing.Size(52, 41);
            this.btnMenuPrincipal.TabIndex = 10;
            this.btnMenuPrincipal.UseVisualStyleBackColor = true;
            this.btnMenuPrincipal.Click += new System.EventHandler(this.btnMenuPrincipal_Click);
            // 
            // btnModificarPromocion
            // 
            this.btnModificarPromocion.BackgroundImage = global::Sisfacturacion.Grafica.Properties.Resources.Editar;
            this.btnModificarPromocion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificarPromocion.Location = new System.Drawing.Point(325, 318);
            this.btnModificarPromocion.Name = "btnModificarPromocion";
            this.btnModificarPromocion.Size = new System.Drawing.Size(73, 61);
            this.btnModificarPromocion.TabIndex = 9;
            this.btnModificarPromocion.UseVisualStyleBackColor = true;
            this.btnModificarPromocion.Click += new System.EventHandler(this.btnModificarPromocion_Click);
            // 
            // btnInsertarPromocion
            // 
            this.btnInsertarPromocion.BackgroundImage = global::Sisfacturacion.Grafica.Properties.Resources.Nuevo;
            this.btnInsertarPromocion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInsertarPromocion.Location = new System.Drawing.Point(221, 318);
            this.btnInsertarPromocion.Name = "btnInsertarPromocion";
            this.btnInsertarPromocion.Size = new System.Drawing.Size(74, 61);
            this.btnInsertarPromocion.TabIndex = 8;
            this.btnInsertarPromocion.UseVisualStyleBackColor = true;
            this.btnInsertarPromocion.Click += new System.EventHandler(this.btnInsertarPromocion_Click);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.BackgroundImage = global::Sisfacturacion.Grafica.Properties.Resources.Limpiar;
            this.btnLimpiarCampos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpiarCampos.Location = new System.Drawing.Point(123, 318);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(70, 61);
            this.btnLimpiarCampos.TabIndex = 7;
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // tiempoCarga
            // 
            this.tiempoCarga.Tick += new System.EventHandler(this.tiempoCarga_Tick);
            // 
            // pbCarga
            // 
            this.pbCarga.Location = new System.Drawing.Point(127, 590);
            this.pbCarga.Name = "pbCarga";
            this.pbCarga.Size = new System.Drawing.Size(371, 23);
            this.pbCarga.TabIndex = 15;
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.BackColor = System.Drawing.Color.Transparent;
            this.lblPorcentaje.Location = new System.Drawing.Point(178, 616);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(0, 13);
            this.lblPorcentaje.TabIndex = 16;
            // 
            // MantenimientoPromociones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sisfacturacion.Grafica.Properties.Resources.Mantenimientos_Referentes_a_Articulos;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(635, 685);
            this.Controls.Add(this.lblPorcentaje);
            this.Controls.Add(this.pbCarga);
            this.Controls.Add(this.nudPorcentaje);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.btnMostrarEstado);
            this.Controls.Add(this.btnEliminarPromocion);
            this.Controls.Add(this.btnMenuPrincipal);
            this.Controls.Add(this.btnModificarPromocion);
            this.Controls.Add(this.btnInsertarPromocion);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MantenimientoPromociones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de promociones";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MantenimientoPromociones_FormClosed);
            this.Load += new System.EventHandler(this.MantenimientoPromociones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromociones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPorcentaje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvPromociones;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Button btnInsertarPromocion;
        private System.Windows.Forms.Button btnModificarPromocion;
        private System.Windows.Forms.Button btnMenuPrincipal;
        private System.Windows.Forms.Button btnEliminarPromocion;
        private System.Windows.Forms.Button btnMostrarEstado;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.NumericUpDown nudPorcentaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigoProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPorcentaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstadoProd;
        private System.Windows.Forms.Timer tiempoCarga;
        private System.Windows.Forms.HelpProvider hpAyuda;
        private System.Windows.Forms.ToolTip tltAyuda;
        private System.Windows.Forms.ProgressBar pbCarga;
        private System.Windows.Forms.Label lblPorcentaje;
    }
}