namespace Sisfacturacion.Grafica
{
    partial class MostrarFactura
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MostrarFactura));
            this.PA_Seleccionar_Por_Id_Enc_FacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DB_SisFacturacionDataSet = new Sisfacturacion.Grafica.DB_SisFacturacionDataSet();
            this.PA_Seleccionar_Por_Id_Det_FacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DB_SisFacturacionDataSet1 = new Sisfacturacion.Grafica.DB_SisFacturacionDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PA_Seleccionar_Por_Id_Enc_FacturaTableAdapter = new Sisfacturacion.Grafica.DB_SisFacturacionDataSetTableAdapters.PA_Seleccionar_Por_Id_Enc_FacturaTableAdapter();
            this.PA_Seleccionar_Por_Id_Det_FacturaTableAdapter = new Sisfacturacion.Grafica.DB_SisFacturacionDataSet1TableAdapters.PA_Seleccionar_Por_Id_Det_FacturaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PA_Seleccionar_Por_Id_Enc_FacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DB_SisFacturacionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PA_Seleccionar_Por_Id_Det_FacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DB_SisFacturacionDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // PA_Seleccionar_Por_Id_Enc_FacturaBindingSource
            // 
            this.PA_Seleccionar_Por_Id_Enc_FacturaBindingSource.DataMember = "PA_Seleccionar_Por_Id_Enc_Factura";
            this.PA_Seleccionar_Por_Id_Enc_FacturaBindingSource.DataSource = this.DB_SisFacturacionDataSet;
            // 
            // DB_SisFacturacionDataSet
            // 
            this.DB_SisFacturacionDataSet.DataSetName = "DB_SisFacturacionDataSet";
            this.DB_SisFacturacionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PA_Seleccionar_Por_Id_Det_FacturaBindingSource
            // 
            this.PA_Seleccionar_Por_Id_Det_FacturaBindingSource.DataMember = "PA_Seleccionar_Por_Id_Det_Factura";
            this.PA_Seleccionar_Por_Id_Det_FacturaBindingSource.DataSource = this.DB_SisFacturacionDataSet1;
            // 
            // DB_SisFacturacionDataSet1
            // 
            this.DB_SisFacturacionDataSet1.DataSetName = "DB_SisFacturacionDataSet1";
            this.DB_SisFacturacionDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsEncFactura";
            reportDataSource1.Value = this.PA_Seleccionar_Por_Id_Enc_FacturaBindingSource;
            reportDataSource2.Name = "dsDetFactura";
            reportDataSource2.Value = this.PA_Seleccionar_Por_Id_Det_FacturaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sisfacturacion.Grafica.Factura.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(413, 617);
            this.reportViewer1.TabIndex = 0;
            // 
            // PA_Seleccionar_Por_Id_Enc_FacturaTableAdapter
            // 
            this.PA_Seleccionar_Por_Id_Enc_FacturaTableAdapter.ClearBeforeFill = true;
            // 
            // PA_Seleccionar_Por_Id_Det_FacturaTableAdapter
            // 
            this.PA_Seleccionar_Por_Id_Det_FacturaTableAdapter.ClearBeforeFill = true;
            // 
            // MostrarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 617);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MostrarFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Documento Digital Factura";
            this.Load += new System.EventHandler(this.MostrarFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PA_Seleccionar_Por_Id_Enc_FacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DB_SisFacturacionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PA_Seleccionar_Por_Id_Det_FacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DB_SisFacturacionDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PA_Seleccionar_Por_Id_Enc_FacturaBindingSource;
        private DB_SisFacturacionDataSet DB_SisFacturacionDataSet;
        private System.Windows.Forms.BindingSource PA_Seleccionar_Por_Id_Det_FacturaBindingSource;
        private DB_SisFacturacionDataSet1 DB_SisFacturacionDataSet1;
        private DB_SisFacturacionDataSetTableAdapters.PA_Seleccionar_Por_Id_Enc_FacturaTableAdapter PA_Seleccionar_Por_Id_Enc_FacturaTableAdapter;
        private DB_SisFacturacionDataSet1TableAdapters.PA_Seleccionar_Por_Id_Det_FacturaTableAdapter PA_Seleccionar_Por_Id_Det_FacturaTableAdapter;
    }
}