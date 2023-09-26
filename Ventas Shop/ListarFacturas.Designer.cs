namespace Ventas_Shop
{
    partial class ListarFacturas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListarFacturas));
            this.mostrarFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDFACTURA = new Ventas_Shop.BDFACTURA();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MostraFactura = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.FiltrarPorNombre = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.imprimir = new System.Windows.Forms.Button();
            this.FechaAño = new System.Windows.Forms.Button();
            this.FechaMes = new System.Windows.Forms.Button();
            this.FechaSemana = new System.Windows.Forms.Button();
            this.FiltrarDia = new System.Windows.Forms.Button();
            this.FechaPersonalizada = new System.Windows.Forms.Button();
            this.PikerFechaFin = new System.Windows.Forms.DateTimePicker();
            this.PikerFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mostrar_FacturaTableAdapter = new Ventas_Shop.BDFACTURATableAdapters.Mostrar_FacturaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarFacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDFACTURA)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // panel1
            // 
            this.panel1.Controls.Add(this.MostraFactura);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(889, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 538);
            this.panel1.TabIndex = 0;
            // 
            // MostraFactura
            // 
            this.MostraFactura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MostraFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Mostrar_Ventas_Factura";
            reportDataSource1.Value = this.mostrarFacturaBindingSource;
            this.MostraFactura.LocalReport.DataSources.Add(reportDataSource1);
            this.MostraFactura.LocalReport.ReportEmbeddedResource = "Ventas_Shop.Imprimir_Factura.rdlc";
            this.MostraFactura.Location = new System.Drawing.Point(0, 0);
            this.MostraFactura.Name = "MostraFactura";
            this.MostraFactura.ServerReport.BearerToken = null;
            this.MostraFactura.ShowBackButton = false;
            this.MostraFactura.ShowContextMenu = false;
            this.MostraFactura.ShowCredentialPrompts = false;
            this.MostraFactura.ShowDocumentMapButton = false;
            this.MostraFactura.ShowExportButton = false;
            this.MostraFactura.ShowFindControls = false;
            this.MostraFactura.ShowPageNavigationControls = false;
            this.MostraFactura.ShowParameterPrompts = false;
            this.MostraFactura.ShowProgress = false;
            this.MostraFactura.ShowPromptAreaButton = false;
            this.MostraFactura.ShowRefreshButton = false;
            this.MostraFactura.ShowStopButton = false;
            this.MostraFactura.ShowZoomControl = false;
            this.MostraFactura.Size = new System.Drawing.Size(580, 538);
            this.MostraFactura.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.FiltrarPorNombre);
            this.panel2.Controls.Add(this.btnVolver);
            this.panel2.Controls.Add(this.imprimir);
            this.panel2.Controls.Add(this.FechaAño);
            this.panel2.Controls.Add(this.FechaMes);
            this.panel2.Controls.Add(this.FechaSemana);
            this.panel2.Controls.Add(this.FiltrarDia);
            this.panel2.Controls.Add(this.FechaPersonalizada);
            this.panel2.Controls.Add(this.PikerFechaFin);
            this.panel2.Controls.Add(this.PikerFechaInicio);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(889, 538);
            this.panel2.TabIndex = 1;
            // 
            // FiltrarPorNombre
            // 
            this.FiltrarPorNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.FiltrarPorNombre.BackColor = System.Drawing.SystemColors.Window;
            this.FiltrarPorNombre.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.FiltrarPorNombre.Location = new System.Drawing.Point(568, 127);
            this.FiltrarPorNombre.Name = "FiltrarPorNombre";
            this.FiltrarPorNombre.Size = new System.Drawing.Size(273, 27);
            this.FiltrarPorNombre.TabIndex = 94;
            this.FiltrarPorNombre.Text = "Filtrar por nombre";
            this.FiltrarPorNombre.Click += new System.EventHandler(this.FiltrarPorNombre_Click);
            this.FiltrarPorNombre.TextChanged += new System.EventHandler(this.FiltrarPorNombre_TextChanged);
            // 
            // btnVolver
            // 
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(8, 12);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(124, 33);
            this.btnVolver.TabIndex = 91;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // imprimir
            // 
            this.imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imprimir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imprimir.Location = new System.Drawing.Point(8, 121);
            this.imprimir.Name = "imprimir";
            this.imprimir.Size = new System.Drawing.Size(124, 33);
            this.imprimir.TabIndex = 90;
            this.imprimir.Text = "Generar";
            this.imprimir.UseVisualStyleBackColor = true;
            this.imprimir.Click += new System.EventHandler(this.imprimir_Click);
            // 
            // FechaAño
            // 
            this.FechaAño.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FechaAño.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaAño.Location = new System.Drawing.Point(741, 68);
            this.FechaAño.Name = "FechaAño";
            this.FechaAño.Size = new System.Drawing.Size(100, 33);
            this.FechaAño.TabIndex = 89;
            this.FechaAño.Text = "Este mes";
            this.FechaAño.UseVisualStyleBackColor = true;
            this.FechaAño.Click += new System.EventHandler(this.FechaAño_Click);
            // 
            // FechaMes
            // 
            this.FechaMes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FechaMes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaMes.Location = new System.Drawing.Point(602, 68);
            this.FechaMes.Name = "FechaMes";
            this.FechaMes.Size = new System.Drawing.Size(133, 33);
            this.FechaMes.TabIndex = 88;
            this.FechaMes.Text = "Últimos 30 días";
            this.FechaMes.UseVisualStyleBackColor = true;
            this.FechaMes.Click += new System.EventHandler(this.FechaMes_Click);
            // 
            // FechaSemana
            // 
            this.FechaSemana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FechaSemana.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaSemana.Location = new System.Drawing.Point(453, 67);
            this.FechaSemana.Name = "FechaSemana";
            this.FechaSemana.Size = new System.Drawing.Size(143, 33);
            this.FechaSemana.TabIndex = 87;
            this.FechaSemana.Text = "Ultimos 7 días";
            this.FechaSemana.UseVisualStyleBackColor = true;
            this.FechaSemana.Click += new System.EventHandler(this.FechaSemana_Click);
            // 
            // FiltrarDia
            // 
            this.FiltrarDia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FiltrarDia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiltrarDia.Location = new System.Drawing.Point(389, 67);
            this.FiltrarDia.Name = "FiltrarDia";
            this.FiltrarDia.Size = new System.Drawing.Size(58, 34);
            this.FiltrarDia.TabIndex = 86;
            this.FiltrarDia.Text = "Hoy";
            this.FiltrarDia.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.FiltrarDia.UseVisualStyleBackColor = true;
            this.FiltrarDia.Click += new System.EventHandler(this.FiltrarDia_Click);
            // 
            // FechaPersonalizada
            // 
            this.FechaPersonalizada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FechaPersonalizada.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaPersonalizada.Location = new System.Drawing.Point(267, 68);
            this.FechaPersonalizada.Name = "FechaPersonalizada";
            this.FechaPersonalizada.Size = new System.Drawing.Size(49, 27);
            this.FechaPersonalizada.TabIndex = 85;
            this.FechaPersonalizada.Text = "OK";
            this.FechaPersonalizada.UseVisualStyleBackColor = true;
            this.FechaPersonalizada.Click += new System.EventHandler(this.FechaPersonalizada_Click);
            // 
            // PikerFechaFin
            // 
            this.PikerFechaFin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PikerFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.PikerFechaFin.Location = new System.Drawing.Point(138, 68);
            this.PikerFechaFin.Name = "PikerFechaFin";
            this.PikerFechaFin.Size = new System.Drawing.Size(123, 27);
            this.PikerFechaFin.TabIndex = 84;
            // 
            // PikerFechaInicio
            // 
            this.PikerFechaInicio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PikerFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.PikerFechaInicio.Location = new System.Drawing.Point(8, 68);
            this.PikerFechaInicio.Name = "PikerFechaInicio";
            this.PikerFechaInicio.Size = new System.Drawing.Size(124, 27);
            this.PikerFechaInicio.TabIndex = 83;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridView1.Location = new System.Drawing.Point(0, 171);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(889, 367);
            this.dataGridView1.TabIndex = 82;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // mostrar_FacturaTableAdapter
            // 
            this.mostrar_FacturaTableAdapter.ClearBeforeFill = true;
            // 
            // ListarFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1469, 538);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListarFacturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ListarFacturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mostrarFacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDFACTURA)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer MostraFactura;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button imprimir;
        private System.Windows.Forms.Button FechaAño;
        private System.Windows.Forms.Button FechaMes;
        private System.Windows.Forms.Button FechaSemana;
        private System.Windows.Forms.Button FiltrarDia;
        private System.Windows.Forms.Button FechaPersonalizada;
        private System.Windows.Forms.DateTimePicker PikerFechaFin;
        private System.Windows.Forms.DateTimePicker PikerFechaInicio;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.BindingSource mostrarFacturaBindingSource;
        private BDFACTURA bDFACTURA;
        private BDFACTURATableAdapters.Mostrar_FacturaTableAdapter mostrar_FacturaTableAdapter;
        private System.Windows.Forms.TextBox FiltrarPorNombre;
    }
}