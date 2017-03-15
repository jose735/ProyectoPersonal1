namespace Sisfacturacion.Grafica
{
    partial class MantenimientoUsuarios
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
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.txtContrasenna = new System.Windows.Forms.TextBox();
            this.txtNombreCompleto = new System.Windows.Forms.TextBox();
            this.cboTipoUsuario = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.colNombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContrasenna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnInsertarUsuario = new System.Windows.Forms.Button();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.btnMenuPrincipal = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.btnMostrarUsuarios = new System.Windows.Forms.Button();
            this.btnModificarEstado = new System.Windows.Forms.Button();
            this.pbCarga = new System.Windows.Forms.ProgressBar();
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.tiempoCarga = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(127, 20);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(133, 20);
            this.txtNombreUsuario.TabIndex = 0;
            // 
            // txtContrasenna
            // 
            this.txtContrasenna.Location = new System.Drawing.Point(127, 61);
            this.txtContrasenna.Name = "txtContrasenna";
            this.txtContrasenna.PasswordChar = '*';
            this.txtContrasenna.Size = new System.Drawing.Size(171, 20);
            this.txtContrasenna.TabIndex = 1;
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.Location = new System.Drawing.Point(127, 99);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new System.Drawing.Size(205, 20);
            this.txtNombreCompleto.TabIndex = 2;
            // 
            // cboTipoUsuario
            // 
            this.cboTipoUsuario.FormattingEnabled = true;
            this.cboTipoUsuario.Location = new System.Drawing.Point(127, 138);
            this.cboTipoUsuario.Name = "cboTipoUsuario";
            this.cboTipoUsuario.Size = new System.Drawing.Size(133, 21);
            this.cboTipoUsuario.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre Completo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tipo de usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre de usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Contraseña";
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNombreUsuario,
            this.colNombreCompleto,
            this.colContrasenna,
            this.colTipoUsuario,
            this.colEstado});
            this.dgvUsuarios.Location = new System.Drawing.Point(15, 224);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersVisible = false;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(654, 150);
            this.dgvUsuarios.TabIndex = 8;
            this.dgvUsuarios.SelectionChanged += new System.EventHandler(this.dgvUsuarios_SelectionChanged);
            // 
            // colNombreUsuario
            // 
            this.colNombreUsuario.DataPropertyName = "nombreUsuario";
            this.colNombreUsuario.HeaderText = "Nombre de Usuario";
            this.colNombreUsuario.Name = "colNombreUsuario";
            this.colNombreUsuario.ReadOnly = true;
            // 
            // colNombreCompleto
            // 
            this.colNombreCompleto.DataPropertyName = "nombreCompleto";
            this.colNombreCompleto.HeaderText = "Nombre Completo";
            this.colNombreCompleto.Name = "colNombreCompleto";
            this.colNombreCompleto.ReadOnly = true;
            // 
            // colContrasenna
            // 
            this.colContrasenna.DataPropertyName = "contrasenna";
            this.colContrasenna.HeaderText = "Clave de Acceso";
            this.colContrasenna.Name = "colContrasenna";
            this.colContrasenna.ReadOnly = true;
            // 
            // colTipoUsuario
            // 
            this.colTipoUsuario.DataPropertyName = "nombreTipoUsuario";
            this.colTipoUsuario.HeaderText = "Tipo de Usuario";
            this.colTipoUsuario.Name = "colTipoUsuario";
            this.colTipoUsuario.ReadOnly = true;
            // 
            // colEstado
            // 
            this.colEstado.DataPropertyName = "nombreEstado";
            this.colEstado.HeaderText = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
            // 
            // btnInsertarUsuario
            // 
            this.btnInsertarUsuario.Location = new System.Drawing.Point(179, 182);
            this.btnInsertarUsuario.Name = "btnInsertarUsuario";
            this.btnInsertarUsuario.Size = new System.Drawing.Size(140, 23);
            this.btnInsertarUsuario.TabIndex = 9;
            this.btnInsertarUsuario.Text = "Nuevo Usuario";
            this.btnInsertarUsuario.UseVisualStyleBackColor = true;
            this.btnInsertarUsuario.Click += new System.EventHandler(this.btnInsertarUsuario_Click);
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.Location = new System.Drawing.Point(512, 182);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(135, 23);
            this.btnEliminarUsuario.TabIndex = 10;
            this.btnEliminarUsuario.Text = "Eliminar Usuario";
            this.btnEliminarUsuario.UseVisualStyleBackColor = true;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // btnMenuPrincipal
            // 
            this.btnMenuPrincipal.Location = new System.Drawing.Point(512, 444);
            this.btnMenuPrincipal.Name = "btnMenuPrincipal";
            this.btnMenuPrincipal.Size = new System.Drawing.Size(157, 23);
            this.btnMenuPrincipal.TabIndex = 11;
            this.btnMenuPrincipal.Text = "Volver al menu principal";
            this.btnMenuPrincipal.UseVisualStyleBackColor = true;
            this.btnMenuPrincipal.Click += new System.EventHandler(this.btnMenuPrincipal_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.Red;
            this.lblMensaje.Location = new System.Drawing.Point(12, 449);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 13);
            this.lblMensaje.TabIndex = 12;
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Location = new System.Drawing.Point(15, 182);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(131, 23);
            this.btnLimpiarCampos.TabIndex = 13;
            this.btnLimpiarCampos.Text = "Limpiar campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(287, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Estado / Mostrar por";
            // 
            // cboEstado
            // 
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(420, 138);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(137, 21);
            this.cboEstado.TabIndex = 15;
            // 
            // btnMostrarUsuarios
            // 
            this.btnMostrarUsuarios.Location = new System.Drawing.Point(564, 136);
            this.btnMostrarUsuarios.Name = "btnMostrarUsuarios";
            this.btnMostrarUsuarios.Size = new System.Drawing.Size(105, 23);
            this.btnMostrarUsuarios.TabIndex = 16;
            this.btnMostrarUsuarios.Text = "Mostrar";
            this.btnMostrarUsuarios.UseVisualStyleBackColor = true;
            this.btnMostrarUsuarios.Click += new System.EventHandler(this.btnMostrarUsuarios_Click);
            // 
            // btnModificarEstado
            // 
            this.btnModificarEstado.Location = new System.Drawing.Point(350, 182);
            this.btnModificarEstado.Name = "btnModificarEstado";
            this.btnModificarEstado.Size = new System.Drawing.Size(134, 23);
            this.btnModificarEstado.TabIndex = 17;
            this.btnModificarEstado.Text = "Activar Usuario";
            this.btnModificarEstado.UseVisualStyleBackColor = true;
            this.btnModificarEstado.Click += new System.EventHandler(this.btnModificarEstado_Click_1);
            // 
            // pbCarga
            // 
            this.pbCarga.Location = new System.Drawing.Point(118, 380);
            this.pbCarga.Name = "pbCarga";
            this.pbCarga.Size = new System.Drawing.Size(439, 23);
            this.pbCarga.TabIndex = 18;
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.Location = new System.Drawing.Point(330, 406);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(0, 13);
            this.lblPorcentaje.TabIndex = 19;
            // 
            // tiempoCarga
            // 
            this.tiempoCarga.Tick += new System.EventHandler(this.tiempoCarga_Tick);
            // 
            // MantenimientoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 479);
            this.Controls.Add(this.lblPorcentaje);
            this.Controls.Add(this.pbCarga);
            this.Controls.Add(this.btnModificarEstado);
            this.Controls.Add(this.btnMostrarUsuarios);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnMenuPrincipal);
            this.Controls.Add(this.btnEliminarUsuario);
            this.Controls.Add(this.btnInsertarUsuario);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboTipoUsuario);
            this.Controls.Add(this.txtNombreCompleto);
            this.Controls.Add(this.txtContrasenna);
            this.Controls.Add(this.txtNombreUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MantenimientoUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de usuarios";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MantenimientoUsuarios_FormClosed);
            this.Load += new System.EventHandler(this.MantenimientoUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.TextBox txtContrasenna;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.ComboBox cboTipoUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Button btnInsertarUsuario;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.Button btnMenuPrincipal;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContrasenna;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Button btnMostrarUsuarios;
        private System.Windows.Forms.Button btnModificarEstado;
        private System.Windows.Forms.ProgressBar pbCarga;
        private System.Windows.Forms.Label lblPorcentaje;
        private System.Windows.Forms.Timer tiempoCarga;
    }
}