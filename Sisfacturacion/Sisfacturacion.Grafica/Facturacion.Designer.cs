namespace Sisfacturacion.Grafica
{
    partial class Facturacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtTelefonoCliente = new System.Windows.Forms.TextBox();
            this.txtDireccionCliente = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.dgvProductosDetalle = new System.Windows.Forms.DataGridView();
            this.colNombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidadProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cboTipoPago = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtNombreCaja = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtImpuesto = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnCancelarFactura = new System.Windows.Forms.Button();
            this.btnFinalizarFactura = new System.Windows.Forms.Button();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnRegistrarCliente = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosDetalle)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRegistrarCliente);
            this.groupBox1.Controls.Add(this.btnBuscarCliente);
            this.groupBox1.Controls.Add(this.txtDireccionCliente);
            this.groupBox1.Controls.Add(this.txtTelefonoCliente);
            this.groupBox1.Controls.Add(this.txtNombreCliente);
            this.groupBox1.Controls.Add(this.txtIdentificacion);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 175);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número de identificación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Teléfono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dirección";
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Location = new System.Drawing.Point(180, 34);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(100, 20);
            this.txtIdentificacion.TabIndex = 4;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(144, 67);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(234, 20);
            this.txtNombreCliente.TabIndex = 5;
            // 
            // txtTelefonoCliente
            // 
            this.txtTelefonoCliente.Location = new System.Drawing.Point(84, 99);
            this.txtTelefonoCliente.Name = "txtTelefonoCliente";
            this.txtTelefonoCliente.Size = new System.Drawing.Size(100, 20);
            this.txtTelefonoCliente.TabIndex = 6;
            // 
            // txtDireccionCliente
            // 
            this.txtDireccionCliente.Location = new System.Drawing.Point(90, 131);
            this.txtDireccionCliente.Name = "txtDireccionCliente";
            this.txtDireccionCliente.Size = new System.Drawing.Size(288, 20);
            this.txtDireccionCliente.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvProductosDetalle);
            this.groupBox2.Controls.Add(this.btnAgregarProducto);
            this.groupBox2.Controls.Add(this.txtNombreProducto);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnBuscarProducto);
            this.groupBox2.Controls.Add(this.txtCodigoProducto);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(412, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(521, 327);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Producto y detalles";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Código de producto";
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.Location = new System.Drawing.Point(143, 34);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoProducto.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Nombre del producto";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(149, 67);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(175, 20);
            this.txtNombreProducto.TabIndex = 4;
            // 
            // dgvProductosDetalle
            // 
            this.dgvProductosDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductosDetalle.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProductosDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNombreProducto,
            this.colCantidadProducto,
            this.colPrecioProducto});
            this.dgvProductosDetalle.Location = new System.Drawing.Point(25, 153);
            this.dgvProductosDetalle.Name = "dgvProductosDetalle";
            this.dgvProductosDetalle.ReadOnly = true;
            this.dgvProductosDetalle.RowHeadersVisible = false;
            this.dgvProductosDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductosDetalle.Size = new System.Drawing.Size(472, 150);
            this.dgvProductosDetalle.TabIndex = 6;
            // 
            // colNombreProducto
            // 
            this.colNombreProducto.HeaderText = "Producto";
            this.colNombreProducto.Name = "colNombreProducto";
            this.colNombreProducto.ReadOnly = true;
            // 
            // colCantidadProducto
            // 
            this.colCantidadProducto.HeaderText = "Cantidad";
            this.colCantidadProducto.Name = "colCantidadProducto";
            this.colCantidadProducto.ReadOnly = true;
            // 
            // colPrecioProducto
            // 
            this.colPrecioProducto.HeaderText = "Precio";
            this.colPrecioProducto.Name = "colPrecioProducto";
            this.colPrecioProducto.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cboTipoPago);
            this.groupBox3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 193);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(174, 81);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tipo de pago";
            // 
            // cboTipoPago
            // 
            this.cboTipoPago.FormattingEnabled = true;
            this.cboTipoPago.Location = new System.Drawing.Point(26, 32);
            this.cboTipoPago.Name = "cboTipoPago";
            this.cboTipoPago.Size = new System.Drawing.Size(121, 21);
            this.cboTipoPago.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtNombreCaja);
            this.groupBox4.Location = new System.Drawing.Point(244, 193);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(162, 81);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Caja";
            // 
            // txtNombreCaja
            // 
            this.txtNombreCaja.Location = new System.Drawing.Point(31, 31);
            this.txtNombreCaja.Name = "txtNombreCaja";
            this.txtNombreCaja.Size = new System.Drawing.Size(100, 20);
            this.txtNombreCaja.TabIndex = 4;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtTotal);
            this.groupBox5.Controls.Add(this.txtImpuesto);
            this.groupBox5.Controls.Add(this.txtSubtotal);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(12, 345);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(398, 152);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Datos de la factura";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Subtotal";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(209, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Impuesto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 37);
            this.label9.TabIndex = 2;
            this.label9.Text = "Total";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(85, 31);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubtotal.TabIndex = 3;
            // 
            // txtImpuesto
            // 
            this.txtImpuesto.Location = new System.Drawing.Point(270, 31);
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.Size = new System.Drawing.Size(100, 20);
            this.txtImpuesto.TabIndex = 4;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(133, 81);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(237, 45);
            this.txtTotal.TabIndex = 5;
            // 
            // btnCancelarFactura
            // 
            this.btnCancelarFactura.BackgroundImage = global::Sisfacturacion.Grafica.Properties.Resources.Volver;
            this.btnCancelarFactura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelarFactura.Location = new System.Drawing.Point(837, 407);
            this.btnCancelarFactura.Name = "btnCancelarFactura";
            this.btnCancelarFactura.Size = new System.Drawing.Size(96, 90);
            this.btnCancelarFactura.TabIndex = 6;
            this.btnCancelarFactura.UseVisualStyleBackColor = true;
            // 
            // btnFinalizarFactura
            // 
            this.btnFinalizarFactura.BackgroundImage = global::Sisfacturacion.Grafica.Properties.Resources.Facturar;
            this.btnFinalizarFactura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFinalizarFactura.Location = new System.Drawing.Point(683, 407);
            this.btnFinalizarFactura.Name = "btnFinalizarFactura";
            this.btnFinalizarFactura.Size = new System.Drawing.Size(126, 90);
            this.btnFinalizarFactura.TabIndex = 5;
            this.btnFinalizarFactura.UseVisualStyleBackColor = true;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.BackgroundImage = global::Sisfacturacion.Grafica.Properties.Resources.Agregar_Producto;
            this.btnAgregarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarProducto.Location = new System.Drawing.Point(25, 97);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(64, 50);
            this.btnAgregarProducto.TabIndex = 5;
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.BackgroundImage = global::Sisfacturacion.Grafica.Properties.Resources.Buscar;
            this.btnBuscarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarProducto.Location = new System.Drawing.Point(249, 32);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(35, 23);
            this.btnBuscarProducto.TabIndex = 2;
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackgroundImage = global::Sisfacturacion.Grafica.Properties.Resources.Buscar;
            this.btnBuscarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarCliente.Location = new System.Drawing.Point(286, 32);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(36, 23);
            this.btnBuscarCliente.TabIndex = 8;
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(12, 518);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 13);
            this.lblMensaje.TabIndex = 7;
            // 
            // btnRegistrarCliente
            // 
            this.btnRegistrarCliente.BackgroundImage = global::Sisfacturacion.Grafica.Properties.Resources.Nuevo;
            this.btnRegistrarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegistrarCliente.Location = new System.Drawing.Point(323, 32);
            this.btnRegistrarCliente.Name = "btnRegistrarCliente";
            this.btnRegistrarCliente.Size = new System.Drawing.Size(40, 23);
            this.btnRegistrarCliente.TabIndex = 8;
            this.btnRegistrarCliente.UseVisualStyleBackColor = true;
            this.btnRegistrarCliente.Click += new System.EventHandler(this.btnRegistrarCliente_Click);
            // 
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 552);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnCancelarFactura);
            this.Controls.Add(this.btnFinalizarFactura);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Facturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compra de productos y facturación";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Facturacion_FormClosed);
            this.Load += new System.EventHandler(this.Facturacion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosDetalle)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.TextBox txtDireccionCliente;
        private System.Windows.Forms.TextBox txtTelefonoCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvProductosDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidadProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioProducto;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cboTipoPago;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtNombreCaja;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtImpuesto;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnFinalizarFactura;
        private System.Windows.Forms.Button btnCancelarFactura;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnRegistrarCliente;
    }
}