namespace Musica.Grafica
{
    partial class Reproductor
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reproductor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.wmpReproductor = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnAbrirReroductor = new System.Windows.Forms.Button();
            this.ofdReproductor = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmpReproductor)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAbrirReroductor);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 400);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.wmpReproductor);
            this.panel2.Location = new System.Drawing.Point(350, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(491, 400);
            this.panel2.TabIndex = 1;
            // 
            // wmpReproductor
            // 
            this.wmpReproductor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wmpReproductor.Enabled = true;
            this.wmpReproductor.Location = new System.Drawing.Point(0, 0);
            this.wmpReproductor.Name = "wmpReproductor";
            this.wmpReproductor.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpReproductor.OcxState")));
            this.wmpReproductor.Size = new System.Drawing.Size(491, 400);
            this.wmpReproductor.TabIndex = 0;
            // 
            // btnAbrirReroductor
            // 
            this.btnAbrirReroductor.Location = new System.Drawing.Point(125, 183);
            this.btnAbrirReroductor.Name = "btnAbrirReroductor";
            this.btnAbrirReroductor.Size = new System.Drawing.Size(75, 23);
            this.btnAbrirReroductor.TabIndex = 0;
            this.btnAbrirReroductor.Text = "Abrir";
            this.btnAbrirReroductor.UseVisualStyleBackColor = true;
            this.btnAbrirReroductor.Click += new System.EventHandler(this.btnAbrirReroductor_Click);
            // 
            // Reproductor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 424);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Reproductor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reproductor de música y video";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wmpReproductor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAbrirReroductor;
        private System.Windows.Forms.Panel panel2;
        private AxWMPLib.AxWindowsMediaPlayer wmpReproductor;
        private System.Windows.Forms.OpenFileDialog ofdReproductor;
    }
}

