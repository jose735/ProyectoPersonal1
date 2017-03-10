namespace Sisfacturacion.Grafica
{
    partial class MantenimientoProveedores
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtNombreRepartidor = new System.Windows.Forms.TextBox();
            this.cboCiudad = new System.Windows.Forms.ComboBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.btnInsertarProveedor = new System.Windows.Forms.Button();
            this.btnModificarProveedor = new System.Windows.Forms.Button();
            this.btnEliminarProveedor = new System.Windows.Forms.Button();
            this.btnMostrarEstado = new System.Windows.Forms.Button();
            this.btnMenuPrincipal = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRepartidor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCiudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código de proveedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(408, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del proveedor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Repartidor encargado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(439, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ciudad de Proveniencia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Direccion del proveedor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Teléfono del proveedor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(283, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Estado / Mostrar por";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(153, 24);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(138, 20);
            this.txtCodigo.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(541, 24);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(175, 20);
            this.txtNombre.TabIndex = 8;
            // 
            // txtNombreRepartidor
            // 
            this.txtNombreRepartidor.Location = new System.Drawing.Point(159, 65);
            this.txtNombreRepartidor.Name = "txtNombreRepartidor";
            this.txtNombreRepartidor.Size = new System.Drawing.Size(172, 20);
            this.txtNombreRepartidor.TabIndex = 9;
            // 
            // cboCiudad
            // 
            this.cboCiudad.FormattingEnabled = true;
            this.cboCiudad.Location = new System.Drawing.Point(584, 65);
            this.cboCiudad.Name = "cboCiudad";
            this.cboCiudad.Size = new System.Drawing.Size(121, 21);
            this.cboCiudad.TabIndex = 10;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(177, 108);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(401, 20);
            this.txtDireccion.TabIndex = 11;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(177, 148);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(154, 20);
            this.txtTelefono.TabIndex = 12;
            // 
            // cboEstado
            // 
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(416, 188);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(121, 21);
            this.cboEstado.TabIndex = 13;
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProveedores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colNombre,
            this.colRepartidor,
            this.colCiudad,
            this.colDireccion,
            this.colProveedor,
            this.colEstado});
            this.dgvProveedores.Location = new System.Drawing.Point(29, 290);
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.ReadOnly = true;
            this.dgvProveedores.RowHeadersVisible = false;
            this.dgvProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProveedores.Size = new System.Drawing.Size(759, 150);
            this.dgvProveedores.TabIndex = 14;
            this.dgvProveedores.SelectionChanged += new System.EventHandler(this.dgvProveedores_SelectionChanged);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Location = new System.Drawing.Point(108, 242);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(111, 23);
            this.btnLimpiarCampos.TabIndex = 15;
            this.btnLimpiarCampos.Text = "Limpiar campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // btnInsertarProveedor
            // 
            this.btnInsertarProveedor.Location = new System.Drawing.Point(255, 242);
            this.btnInsertarProveedor.Name = "btnInsertarProveedor";
            this.btnInsertarProveedor.Size = new System.Drawing.Size(114, 23);
            this.btnInsertarProveedor.TabIndex = 16;
            this.btnInsertarProveedor.Text = "Nuevo proveedor";
            this.btnInsertarProveedor.UseVisualStyleBackColor = true;
            this.btnInsertarProveedor.Click += new System.EventHandler(this.btnInsertarProveedor_Click);
            // 
            // btnModificarProveedor
            // 
            this.btnModificarProveedor.Location = new System.Drawing.Point(404, 242);
            this.btnModificarProveedor.Name = "btnModificarProveedor";
            this.btnModificarProveedor.Size = new System.Drawing.Size(134, 23);
            this.btnModificarProveedor.TabIndex = 17;
            this.btnModificarProveedor.Text = "Modificar proveedor";
            this.btnModificarProveedor.UseVisualStyleBackColor = true;
            this.btnModificarProveedor.Click += new System.EventHandler(this.btnModificarProveedor_Click);
            // 
            // btnEliminarProveedor
            // 
            this.btnEliminarProveedor.Location = new System.Drawing.Point(575, 242);
            this.btnEliminarProveedor.Name = "btnEliminarProveedor";
            this.btnEliminarProveedor.Size = new System.Drawing.Size(128, 23);
            this.btnEliminarProveedor.TabIndex = 18;
            this.btnEliminarProveedor.Text = "Eliminar proveedor";
            this.btnEliminarProveedor.UseVisualStyleBackColor = true;
            this.btnEliminarProveedor.Click += new System.EventHandler(this.btnEliminarProveedor_Click);
            // 
            // btnMostrarEstado
            // 
            this.btnMostrarEstado.Location = new System.Drawing.Point(543, 186);
            this.btnMostrarEstado.Name = "btnMostrarEstado";
            this.btnMostrarEstado.Size = new System.Drawing.Size(75, 23);
            this.btnMostrarEstado.TabIndex = 19;
            this.btnMostrarEstado.Text = "Mostrar";
            this.btnMostrarEstado.UseVisualStyleBackColor = true;
            this.btnMostrarEstado.Click += new System.EventHandler(this.btnMostrarEstado_Click);
            // 
            // btnMenuPrincipal
            // 
            this.btnMenuPrincipal.Location = new System.Drawing.Point(650, 492);
            this.btnMenuPrincipal.Name = "btnMenuPrincipal";
            this.btnMenuPrincipal.Size = new System.Drawing.Size(148, 23);
            this.btnMenuPrincipal.TabIndex = 20;
            this.btnMenuPrincipal.Text = "Volver al menu principal";
            this.btnMenuPrincipal.UseVisualStyleBackColor = true;
            this.btnMenuPrincipal.Click += new System.EventHandler(this.btnMenuPrincipal_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(12, 464);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(43, 13);
            this.lblMensaje.TabIndex = 21;
            this.lblMensaje.Text = "label8";
            // 
            // colCodigo
            // 
            this.colCodigo.DataPropertyName = "idProveedor";
            this.colCodigo.HeaderText = "Codigo de proveedor";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            // 
            // colNombre
            // 
            this.colNombre.DataPropertyName = "nombre";
            this.colNombre.HeaderText = "Proveedor";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            // 
            // colRepartidor
            // 
            this.colRepartidor.DataPropertyName = "nombreRepartidor";
            this.colRepartidor.HeaderText = "Nombre del repartidor";
            this.colRepartidor.Name = "colRepartidor";
            this.colRepartidor.ReadOnly = true;
            // 
            // colCiudad
            // 
            this.colCiudad.DataPropertyName = "nombreCiudad";
            this.colCiudad.HeaderText = "Ciudad";
            this.colCiudad.Name = "colCiudad";
            this.colCiudad.ReadOnly = true;
            // 
            // colDireccion
            // 
            this.colDireccion.DataPropertyName = "direccionLocal";
            this.colDireccion.HeaderText = "Direccion de proveedor";
            this.colDireccion.Name = "colDireccion";
            this.colDireccion.ReadOnly = true;
            // 
            // colProveedor
            // 
            this.colProveedor.DataPropertyName = "telefono";
            this.colProveedor.HeaderText = "Teléfono";
            this.colProveedor.Name = "colProveedor";
            this.colProveedor.ReadOnly = true;
            // 
            // colEstado
            // 
            this.colEstado.DataPropertyName = "nombreEstado";
            this.colEstado.HeaderText = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
            // 
            // MantenimientoProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 527);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnMenuPrincipal);
            this.Controls.Add(this.btnMostrarEstado);
            this.Controls.Add(this.btnEliminarProveedor);
            this.Controls.Add(this.btnModificarProveedor);
            this.Controls.Add(this.btnInsertarProveedor);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.dgvProveedores);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.cboCiudad);
            this.Controls.Add(this.txtNombreRepartidor);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MantenimientoProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de proveedores";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MantenimientoProveedores_FormClosed);
            this.Load += new System.EventHandler(this.MantenimientoProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtNombreRepartidor;
        private System.Windows.Forms.ComboBox cboCiudad;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.DataGridView dgvProveedores;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Button btnInsertarProveedor;
        private System.Windows.Forms.Button btnModificarProveedor;
        private System.Windows.Forms.Button btnEliminarProveedor;
        private System.Windows.Forms.Button btnMostrarEstado;
        private System.Windows.Forms.Button btnMenuPrincipal;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRepartidor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCiudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
    }
}