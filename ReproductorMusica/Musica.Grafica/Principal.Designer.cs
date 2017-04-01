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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreCancion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboInterprete = new System.Windows.Forms.ComboBox();
            this.cboAlbum = new System.Windows.Forms.ComboBox();
            this.btnBuscarCancion = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.wmpReproductor = new AxWMPLib.AxWindowsMediaPlayer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblAlbum = new System.Windows.Forms.Label();
            this.lblInterprete = new System.Windows.Forms.Label();
            this.lblNombreCancion = new System.Windows.Forms.Label();
            this.lblNumeroCancion = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmpReproductor)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(1004, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraciónToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 19);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.configuraciónToolStripMenuItem.Text = "Configuración";
            this.configuraciónToolStripMenuItem.Click += new System.EventHandler(this.configuraciónToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 19);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre de la canción";
            // 
            // txtNombreCancion
            // 
            this.txtNombreCancion.Location = new System.Drawing.Point(167, 32);
            this.txtNombreCancion.Name = "txtNombreCancion";
            this.txtNombreCancion.Size = new System.Drawing.Size(100, 23);
            this.txtNombreCancion.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Interprete";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Album";
            // 
            // cboInterprete
            // 
            this.cboInterprete.FormattingEnabled = true;
            this.cboInterprete.Location = new System.Drawing.Point(9, 93);
            this.cboInterprete.Name = "cboInterprete";
            this.cboInterprete.Size = new System.Drawing.Size(121, 25);
            this.cboInterprete.TabIndex = 5;
            // 
            // cboAlbum
            // 
            this.cboAlbum.FormattingEnabled = true;
            this.cboAlbum.Location = new System.Drawing.Point(232, 93);
            this.cboAlbum.Name = "cboAlbum";
            this.cboAlbum.Size = new System.Drawing.Size(121, 25);
            this.cboAlbum.TabIndex = 6;
            // 
            // btnBuscarCancion
            // 
            this.btnBuscarCancion.Location = new System.Drawing.Point(144, 142);
            this.btnBuscarCancion.Name = "btnBuscarCancion";
            this.btnBuscarCancion.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarCancion.TabIndex = 7;
            this.btnBuscarCancion.Text = "Buscar";
            this.btnBuscarCancion.UseVisualStyleBackColor = true;
            this.btnBuscarCancion.Click += new System.EventHandler(this.btnBuscarCancion_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnBuscarCancion);
            this.groupBox1.Controls.Add(this.txtNombreCancion);
            this.groupBox1.Controls.Add(this.cboAlbum);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboInterprete);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 173);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la busqueda";
            // 
            // pnlBotones
            // 
            this.pnlBotones.AutoScroll = true;
            this.pnlBotones.Location = new System.Drawing.Point(12, 207);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(362, 333);
            this.pnlBotones.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.wmpReproductor);
            this.panel2.Location = new System.Drawing.Point(380, 207);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(612, 333);
            this.panel2.TabIndex = 10;
            // 
            // wmpReproductor
            // 
            this.wmpReproductor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wmpReproductor.Enabled = true;
            this.wmpReproductor.Location = new System.Drawing.Point(0, 0);
            this.wmpReproductor.Name = "wmpReproductor";
            this.wmpReproductor.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpReproductor.OcxState")));
            this.wmpReproductor.Size = new System.Drawing.Size(612, 333);
            this.wmpReproductor.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblAlbum);
            this.groupBox2.Controls.Add(this.lblInterprete);
            this.groupBox2.Controls.Add(this.lblNombreCancion);
            this.groupBox2.Controls.Add(this.lblNumeroCancion);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(380, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(612, 173);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de la canción";
            // 
            // lblAlbum
            // 
            this.lblAlbum.AutoSize = true;
            this.lblAlbum.Location = new System.Drawing.Point(62, 145);
            this.lblAlbum.Name = "lblAlbum";
            this.lblAlbum.Size = new System.Drawing.Size(0, 17);
            this.lblAlbum.TabIndex = 7;
            // 
            // lblInterprete
            // 
            this.lblInterprete.AutoSize = true;
            this.lblInterprete.Location = new System.Drawing.Point(83, 111);
            this.lblInterprete.Name = "lblInterprete";
            this.lblInterprete.Size = new System.Drawing.Size(0, 17);
            this.lblInterprete.TabIndex = 6;
            // 
            // lblNombreCancion
            // 
            this.lblNombreCancion.AutoSize = true;
            this.lblNombreCancion.Location = new System.Drawing.Point(167, 73);
            this.lblNombreCancion.Name = "lblNombreCancion";
            this.lblNombreCancion.Size = new System.Drawing.Size(0, 17);
            this.lblNombreCancion.TabIndex = 5;
            // 
            // lblNumeroCancion
            // 
            this.lblNumeroCancion.AutoSize = true;
            this.lblNumeroCancion.Location = new System.Drawing.Point(150, 35);
            this.lblNumeroCancion.Name = "lblNumeroCancion";
            this.lblNumeroCancion.Size = new System.Drawing.Size(0, 17);
            this.lblNumeroCancion.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Album: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Interprete: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nombre de la canción: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Número de canción: ";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 552);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlBotones);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wmpReproductor)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreCancion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboInterprete;
        private System.Windows.Forms.ComboBox cboAlbum;
        private System.Windows.Forms.Button btnBuscarCancion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblAlbum;
        private System.Windows.Forms.Label lblInterprete;
        private System.Windows.Forms.Label lblNombreCancion;
        private System.Windows.Forms.Label lblNumeroCancion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private AxWMPLib.AxWindowsMediaPlayer wmpReproductor;
    }
}