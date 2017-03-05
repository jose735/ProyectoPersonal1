namespace Sisfacturacion.Grafica
{
    partial class CambiarContrasenna
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
            this.txtContrasennaActual = new System.Windows.Forms.TextBox();
            this.txtConfirmarContrasenna = new System.Windows.Forms.TextBox();
            this.txtNuevaContrasenna = new System.Windows.Forms.TextBox();
            this.btnCambiarContrasenna = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtNombreUsuario);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblMensaje);
            this.groupBox1.Controls.Add(this.btnCambiarContrasenna);
            this.groupBox1.Controls.Add(this.txtNuevaContrasenna);
            this.groupBox1.Controls.Add(this.txtConfirmarContrasenna);
            this.groupBox1.Controls.Add(this.txtContrasennaActual);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 310);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Digita los campos necesarios para cambiar tu contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contraseña actual";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nueva contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirmar contraseña";
            // 
            // txtContrasennaActual
            // 
            this.txtContrasennaActual.Location = new System.Drawing.Point(149, 86);
            this.txtContrasennaActual.Name = "txtContrasennaActual";
            this.txtContrasennaActual.PasswordChar = '*';
            this.txtContrasennaActual.Size = new System.Drawing.Size(147, 20);
            this.txtContrasennaActual.TabIndex = 3;
            // 
            // txtConfirmarContrasenna
            // 
            this.txtConfirmarContrasenna.Location = new System.Drawing.Point(149, 170);
            this.txtConfirmarContrasenna.Name = "txtConfirmarContrasenna";
            this.txtConfirmarContrasenna.PasswordChar = '*';
            this.txtConfirmarContrasenna.Size = new System.Drawing.Size(147, 20);
            this.txtConfirmarContrasenna.TabIndex = 4;
            // 
            // txtNuevaContrasenna
            // 
            this.txtNuevaContrasenna.Location = new System.Drawing.Point(149, 130);
            this.txtNuevaContrasenna.Name = "txtNuevaContrasenna";
            this.txtNuevaContrasenna.PasswordChar = '*';
            this.txtNuevaContrasenna.Size = new System.Drawing.Size(147, 20);
            this.txtNuevaContrasenna.TabIndex = 5;
            // 
            // btnCambiarContrasenna
            // 
            this.btnCambiarContrasenna.Location = new System.Drawing.Point(149, 251);
            this.btnCambiarContrasenna.Name = "btnCambiarContrasenna";
            this.btnCambiarContrasenna.Size = new System.Drawing.Size(147, 23);
            this.btnCambiarContrasenna.TabIndex = 6;
            this.btnCambiarContrasenna.Text = "Cambiar contraseña";
            this.btnCambiarContrasenna.UseVisualStyleBackColor = true;
            this.btnCambiarContrasenna.Click += new System.EventHandler(this.btnCambiarContrasenna_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(6, 211);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 13);
            this.lblMensaje.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nombre de usuario";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(149, 46);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(147, 20);
            this.txtNombreUsuario.TabIndex = 9;
            // 
            // CambiarContrasenna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 334);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CambiarContrasenna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CambiarContrasenna";
            this.Load += new System.EventHandler(this.CambiarContrasenna_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnCambiarContrasenna;
        private System.Windows.Forms.TextBox txtNuevaContrasenna;
        private System.Windows.Forms.TextBox txtConfirmarContrasenna;
        private System.Windows.Forms.TextBox txtContrasennaActual;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label label4;
    }
}