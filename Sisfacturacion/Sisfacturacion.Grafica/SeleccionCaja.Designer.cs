namespace Sisfacturacion.Grafica
{
    partial class SeleccionCaja
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
            this.cboCajas = new System.Windows.Forms.ComboBox();
            this.btnAcceder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número de caja";
            // 
            // cboCajas
            // 
            this.cboCajas.FormattingEnabled = true;
            this.cboCajas.Location = new System.Drawing.Point(128, 18);
            this.cboCajas.Name = "cboCajas";
            this.cboCajas.Size = new System.Drawing.Size(121, 21);
            this.cboCajas.TabIndex = 1;
            // 
            // btnAcceder
            // 
            this.btnAcceder.BackgroundImage = global::Sisfacturacion.Grafica.Properties.Resources.Acceder;
            this.btnAcceder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAcceder.Location = new System.Drawing.Point(100, 57);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(75, 54);
            this.btnAcceder.TabIndex = 2;
            this.btnAcceder.UseVisualStyleBackColor = true;
            this.btnAcceder.Click += new System.EventHandler(this.btnAcceder_Click);
            // 
            // SeleccionCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 117);
            this.Controls.Add(this.btnAcceder);
            this.Controls.Add(this.cboCajas);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SeleccionCaja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccion de caja";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SeleccionCaja_FormClosed);
            this.Load += new System.EventHandler(this.SeleccionCaja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCajas;
        private System.Windows.Forms.Button btnAcceder;
    }
}