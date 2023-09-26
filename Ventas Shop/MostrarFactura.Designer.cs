namespace Ventas_Shop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MostrarFactura));
            this.mostrarFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDFACTURA = new Ventas_Shop.BDFACTURA();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.mostrar_FacturaTableAdapter = new Ventas_Shop.BDFACTURATableAdapters.Mostrar_FacturaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarFacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDFACTURA)).BeginInit();
            this.SuspendLayout();
            // 
            // mostrarFacturaBindingSource
            // 
            this.mostrarFacturaBindingSource.DataMember = "Mostrar_Factura";
            this.mostrarFacturaBindingSource.DataSource = this.bDFACTURA;
            // 
            // bDFACTURA
            // 
            this.bDFACTURA.DataSetName = "BDFACTURA";
            this.bDFACTURA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "Mostrar_Ventas_Factura";
            reportDataSource1.Value = this.mostrarFacturaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Ventas_Shop.Imprimir_Factura.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(812, 561);
            this.reportViewer1.TabIndex = 0;
            // 
            // mostrar_FacturaTableAdapter
            // 
            this.mostrar_FacturaTableAdapter.ClearBeforeFill = true;
            // 
            // MostrarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(812, 561);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MostrarFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MostrarFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mostrarFacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDFACTURA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource mostrarFacturaBindingSource;
        private BDFACTURA bDFACTURA;
        private BDFACTURATableAdapters.Mostrar_FacturaTableAdapter mostrar_FacturaTableAdapter;
    }
}