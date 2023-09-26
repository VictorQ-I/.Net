namespace Ventas_Shop
{
    partial class Factura_Generada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Factura_Generada));
            this.imrpimir = new System.Windows.Forms.Button();
            this.subtotal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.iva = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.precio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cantidad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.producto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Cancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numfactura = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.telefono = new System.Windows.Forms.TextBox();
            this.correo = new System.Windows.Forms.TextBox();
            this.cliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imrpimir
            // 
            this.imrpimir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imrpimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imrpimir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imrpimir.Location = new System.Drawing.Point(107, 556);
            this.imrpimir.Name = "imrpimir";
            this.imrpimir.Size = new System.Drawing.Size(93, 29);
            this.imrpimir.TabIndex = 59;
            this.imrpimir.Text = "Imprimir";
            this.imrpimir.UseVisualStyleBackColor = true;
            this.imrpimir.Click += new System.EventHandler(this.button4_Click);
            // 
            // subtotal
            // 
            this.subtotal.BackColor = System.Drawing.SystemColors.Window;
            this.subtotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.subtotal.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotal.Location = new System.Drawing.Point(306, 352);
            this.subtotal.Multiline = true;
            this.subtotal.Name = "subtotal";
            this.subtotal.Size = new System.Drawing.Size(121, 20);
            this.subtotal.TabIndex = 58;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(213, 351);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 18);
            this.label10.TabIndex = 57;
            this.label10.Text = "Sub total";
            // 
            // iva
            // 
            this.iva.BackColor = System.Drawing.SystemColors.Window;
            this.iva.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.iva.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iva.Location = new System.Drawing.Point(306, 378);
            this.iva.Multiline = true;
            this.iva.Name = "iva";
            this.iva.Size = new System.Drawing.Size(121, 20);
            this.iva.TabIndex = 56;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(253, 377);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 18);
            this.label9.TabIndex = 55;
            this.label9.Text = "IVA";
            // 
            // total
            // 
            this.total.BackColor = System.Drawing.SystemColors.Window;
            this.total.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.total.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.Location = new System.Drawing.Point(305, 404);
            this.total.Multiline = true;
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(121, 20);
            this.total.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(158, 401);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 23);
            this.label6.TabIndex = 53;
            this.label6.Text = "Total factura";
            // 
            // precio
            // 
            this.precio.BackColor = System.Drawing.SystemColors.Window;
            this.precio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.precio.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precio.Location = new System.Drawing.Point(332, 288);
            this.precio.Multiline = true;
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(106, 20);
            this.precio.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(329, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 18);
            this.label7.TabIndex = 51;
            this.label7.Text = "Precio";
            // 
            // cantidad
            // 
            this.cantidad.BackColor = System.Drawing.SystemColors.Window;
            this.cantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cantidad.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidad.Location = new System.Drawing.Point(40, 288);
            this.cantidad.Multiline = true;
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(32, 20);
            this.cantidad.TabIndex = 50;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 18);
            this.label8.TabIndex = 49;
            this.label8.Text = "Cantidad";
            // 
            // producto
            // 
            this.producto.BackColor = System.Drawing.SystemColors.Window;
            this.producto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.producto.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.producto.Location = new System.Drawing.Point(114, 288);
            this.producto.Multiline = true;
            this.producto.Name = "producto";
            this.producto.Size = new System.Drawing.Size(185, 20);
            this.producto.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(111, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 18);
            this.label5.TabIndex = 47;
            this.label5.Text = "Producto";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(111, 489);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(196, 16);
            this.label15.TabIndex = 67;
            this.label15.Text = "GRACIAS POR TU COMPRA    ";
            // 
            // Cancelar
            // 
            this.Cancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar.Location = new System.Drawing.Point(256, 556);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(93, 29);
            this.Cancelar.TabIndex = 68;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.subtotal);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.iva);
            this.groupBox1.Controls.Add(this.numfactura);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.total);
            this.groupBox1.Controls.Add(this.telefono);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.correo);
            this.groupBox1.Controls.Add(this.precio);
            this.groupBox1.Controls.Add(this.cliente);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cantidad);
            this.groupBox1.Controls.Add(this.fecha);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.producto);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 525);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(78, 47);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(279, 18);
            this.label14.TabIndex = 79;
            this.label14.Text = "C.C. MAYORCA CL 45 # 37 - 28 LC 1170";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(175, 101);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 18);
            this.label13.TabIndex = 78;
            this.label13.Text = "3172966866";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(166, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 18);
            this.label12.TabIndex = 77;
            this.label12.Text = "(604) 4483584     ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(161, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 18);
            this.label11.TabIndex = 76;
            this.label11.Text = "NIT. 28754236-6";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(172, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 19);
            this.label4.TabIndex = 75;
            this.label4.Text = "VENTA SHOP";
            // 
            // numfactura
            // 
            this.numfactura.BackColor = System.Drawing.SystemColors.Window;
            this.numfactura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numfactura.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numfactura.Location = new System.Drawing.Point(269, 172);
            this.numfactura.Multiline = true;
            this.numfactura.Name = "numfactura";
            this.numfactura.Size = new System.Drawing.Size(35, 20);
            this.numfactura.TabIndex = 74;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(266, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 18);
            this.label3.TabIndex = 73;
            this.label3.Text = "No. de factura";
            // 
            // telefono
            // 
            this.telefono.BackColor = System.Drawing.SystemColors.Window;
            this.telefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.telefono.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefono.Location = new System.Drawing.Point(17, 193);
            this.telefono.Multiline = true;
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(231, 20);
            this.telefono.TabIndex = 72;
            // 
            // correo
            // 
            this.correo.BackColor = System.Drawing.SystemColors.Window;
            this.correo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.correo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correo.Location = new System.Drawing.Point(17, 213);
            this.correo.Multiline = true;
            this.correo.Name = "correo";
            this.correo.Size = new System.Drawing.Size(231, 20);
            this.correo.TabIndex = 71;
            // 
            // cliente
            // 
            this.cliente.BackColor = System.Drawing.SystemColors.Window;
            this.cliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cliente.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cliente.Location = new System.Drawing.Point(17, 172);
            this.cliente.Multiline = true;
            this.cliente.Name = "cliente";
            this.cliente.Size = new System.Drawing.Size(231, 20);
            this.cliente.TabIndex = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 69;
            this.label2.Text = "Cliente";
            // 
            // fecha
            // 
            this.fecha.BackColor = System.Drawing.SystemColors.Window;
            this.fecha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fecha.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha.Location = new System.Drawing.Point(269, 216);
            this.fecha.Multiline = true;
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(168, 20);
            this.fecha.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 18);
            this.label1.TabIndex = 67;
            this.label1.Text = "Fecha";
            // 
            // Factura_Generada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(474, 602);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.imrpimir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Factura_Generada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Factura_Generada_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button imrpimir;
        public System.Windows.Forms.TextBox subtotal;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox iva;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox total;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox precio;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox cantidad;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox producto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button Cancelar;
        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox numfactura;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox telefono;
        public System.Windows.Forms.TextBox correo;
        public System.Windows.Forms.TextBox cliente;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox fecha;
        private System.Windows.Forms.Label label1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}