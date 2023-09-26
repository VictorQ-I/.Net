namespace Ventas_Shop
{
    partial class VerVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerVenta));
            this.button7 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PikerFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.PikerFechaFin = new System.Windows.Forms.DateTimePicker();
            this.FechaPersonalizada = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.FechaSemana = new System.Windows.Forms.Button();
            this.FechaMes = new System.Windows.Forms.Button();
            this.FechaAño = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EditarVenta = new System.Windows.Forms.Button();
            this.DescargarInfo = new System.Windows.Forms.Button();
            this.Imprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button7
            // 
            this.button7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(8, 123);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(148, 34);
            this.button7.TabIndex = 70;
            this.button7.Text = "Eliminar venta";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(791, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 34);
            this.button3.TabIndex = 69;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(8, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 34);
            this.button2.TabIndex = 66;
            this.button2.Text = "Volver";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(346, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 26);
            this.label1.TabIndex = 58;
            this.label1.Text = "VENTAS";
            // 
            // PikerFechaInicio
            // 
            this.PikerFechaInicio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PikerFechaInicio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PikerFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.PikerFechaInicio.Location = new System.Drawing.Point(8, 63);
            this.PikerFechaInicio.Name = "PikerFechaInicio";
            this.PikerFechaInicio.Size = new System.Drawing.Size(124, 27);
            this.PikerFechaInicio.TabIndex = 74;
            // 
            // PikerFechaFin
            // 
            this.PikerFechaFin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PikerFechaFin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PikerFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.PikerFechaFin.Location = new System.Drawing.Point(138, 63);
            this.PikerFechaFin.Name = "PikerFechaFin";
            this.PikerFechaFin.Size = new System.Drawing.Size(123, 27);
            this.PikerFechaFin.TabIndex = 75;
            // 
            // FechaPersonalizada
            // 
            this.FechaPersonalizada.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.FechaPersonalizada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FechaPersonalizada.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaPersonalizada.Location = new System.Drawing.Point(267, 63);
            this.FechaPersonalizada.Name = "FechaPersonalizada";
            this.FechaPersonalizada.Size = new System.Drawing.Size(49, 27);
            this.FechaPersonalizada.TabIndex = 76;
            this.FechaPersonalizada.Text = "OK";
            this.FechaPersonalizada.UseVisualStyleBackColor = true;
            this.FechaPersonalizada.Click += new System.EventHandler(this.FechaPersonalizada_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(439, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 34);
            this.button1.TabIndex = 77;
            this.button1.Text = "Hoy";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.FechaHoy_Click_1);
            // 
            // FechaSemana
            // 
            this.FechaSemana.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.FechaSemana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FechaSemana.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaSemana.Location = new System.Drawing.Point(503, 62);
            this.FechaSemana.Name = "FechaSemana";
            this.FechaSemana.Size = new System.Drawing.Size(143, 33);
            this.FechaSemana.TabIndex = 78;
            this.FechaSemana.Text = "Ultimos 7 días";
            this.FechaSemana.UseVisualStyleBackColor = true;
            this.FechaSemana.Click += new System.EventHandler(this.FechaSemana_Click);
            // 
            // FechaMes
            // 
            this.FechaMes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.FechaMes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FechaMes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaMes.Location = new System.Drawing.Point(652, 63);
            this.FechaMes.Name = "FechaMes";
            this.FechaMes.Size = new System.Drawing.Size(133, 33);
            this.FechaMes.TabIndex = 79;
            this.FechaMes.Text = "Últimos 30 días";
            this.FechaMes.UseVisualStyleBackColor = true;
            this.FechaMes.Click += new System.EventHandler(this.FechaMes_Click);
            // 
            // FechaAño
            // 
            this.FechaAño.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.FechaAño.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FechaAño.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaAño.Location = new System.Drawing.Point(791, 63);
            this.FechaAño.Name = "FechaAño";
            this.FechaAño.Size = new System.Drawing.Size(100, 33);
            this.FechaAño.TabIndex = 80;
            this.FechaAño.Text = "Este mes";
            this.FechaAño.UseVisualStyleBackColor = true;
            this.FechaAño.Click += new System.EventHandler(this.FechaAño_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridView1.Location = new System.Drawing.Point(8, 163);
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
            this.dataGridView1.Size = new System.Drawing.Size(883, 208);
            this.dataGridView1.TabIndex = 81;
            // 
            // EditarVenta
            // 
            this.EditarVenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EditarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditarVenta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditarVenta.Location = new System.Drawing.Point(162, 123);
            this.EditarVenta.Name = "EditarVenta";
            this.EditarVenta.Size = new System.Drawing.Size(148, 34);
            this.EditarVenta.TabIndex = 82;
            this.EditarVenta.Text = "Editar venta";
            this.EditarVenta.UseVisualStyleBackColor = true;
            this.EditarVenta.Click += new System.EventHandler(this.EditarVenta_Click);
            // 
            // DescargarInfo
            // 
            this.DescargarInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DescargarInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DescargarInfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescargarInfo.Location = new System.Drawing.Point(442, 123);
            this.DescargarInfo.Name = "DescargarInfo";
            this.DescargarInfo.Size = new System.Drawing.Size(205, 34);
            this.DescargarInfo.TabIndex = 88;
            this.DescargarInfo.Text = "Descargar información";
            this.DescargarInfo.UseVisualStyleBackColor = true;
            this.DescargarInfo.Click += new System.EventHandler(this.DescargarInfo_Click);
            // 
            // Imprimir
            // 
            this.Imprimir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Imprimir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Imprimir.Location = new System.Drawing.Point(316, 123);
            this.Imprimir.Name = "Imprimir";
            this.Imprimir.Size = new System.Drawing.Size(120, 34);
            this.Imprimir.TabIndex = 89;
            this.Imprimir.Text = "Imprimir";
            this.Imprimir.UseVisualStyleBackColor = true;
            this.Imprimir.Click += new System.EventHandler(this.Imprimir_Click);
            // 
            // VerVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(896, 383);
            this.Controls.Add(this.Imprimir);
            this.Controls.Add(this.DescargarInfo);
            this.Controls.Add(this.EditarVenta);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.FechaAño);
            this.Controls.Add(this.FechaMes);
            this.Controls.Add(this.FechaSemana);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FechaPersonalizada);
            this.Controls.Add(this.PikerFechaFin);
            this.Controls.Add(this.PikerFechaInicio);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VerVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.RealizarVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker PikerFechaInicio;
        private System.Windows.Forms.DateTimePicker PikerFechaFin;
        private System.Windows.Forms.Button FechaPersonalizada;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button FechaSemana;
        private System.Windows.Forms.Button FechaMes;
        private System.Windows.Forms.Button FechaAño;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button EditarVenta;
        private System.Windows.Forms.Button DescargarInfo;
        private System.Windows.Forms.Button Imprimir;
    }
}