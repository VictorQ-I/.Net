namespace Ventas_Shop
{
    partial class Home
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.HoraFecha = new System.Windows.Forms.Timer(this.components);
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.ToolArchivo = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolCerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolRegistros = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolClientes = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolProductos = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolCategorias = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolVentas = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolEstadisticas = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolFacturación = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolConfiguracion = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolUsuarios = new System.Windows.Forms.ToolStripMenuItem();
			this.IdVenta = new System.Windows.Forms.TextBox();
			this.codCliente = new System.Windows.Forms.TextBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.TxtStock = new System.Windows.Forms.TextBox();
			this.BuscarCliente = new System.Windows.Forms.Button();
			this.txtcliente = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.BuscarProducto = new System.Windows.Forms.Button();
			this.TxtPrecio = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.TxtCodigo = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.TxtProducto = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.TxtCantidad = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.BtnAgregarProducto = new System.Windows.Forms.Button();
			this.LblSalir = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.TipoUsuario = new System.Windows.Forms.TextBox();
			this.IdUsuario = new System.Windows.Forms.TextBox();
			this.Usuario = new System.Windows.Forms.Label();
			this.lblfecha = new System.Windows.Forms.Label();
			this.lblhora = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.CancelarVenta = new System.Windows.Forms.Button();
			this.GuardarVenta = new System.Windows.Forms.Button();
			this.EliminarProducto = new System.Windows.Forms.Button();
			this.EditarProducto = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.panel5 = new System.Windows.Forms.Panel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txtTotal = new System.Windows.Forms.TextBox();
			this.menuStrip1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// HoraFecha
			// 
			this.HoraFecha.Enabled = true;
			this.HoraFecha.Tick += new System.EventHandler(this.HoraFecha_Tick);
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.LightSkyBlue;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolArchivo,
            this.ToolRegistros,
            this.ToolVentas,
            this.ToolEstadisticas,
            this.ToolFacturación,
            this.ToolConfiguracion});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.menuStrip1.Size = new System.Drawing.Size(1093, 31);
			this.menuStrip1.TabIndex = 103;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// ToolArchivo
			// 
			this.ToolArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolCerrarSesion});
			this.ToolArchivo.Font = new System.Drawing.Font("Century Gothic", 15F);
			this.ToolArchivo.ForeColor = System.Drawing.Color.Black;
			this.ToolArchivo.Image = ((System.Drawing.Image)(resources.GetObject("ToolArchivo.Image")));
			this.ToolArchivo.Name = "ToolArchivo";
			this.ToolArchivo.Size = new System.Drawing.Size(132, 27);
			this.ToolArchivo.Text = "ARCHIVO";
			// 
			// ToolCerrarSesion
			// 
			this.ToolCerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("ToolCerrarSesion.Image")));
			this.ToolCerrarSesion.Name = "ToolCerrarSesion";
			this.ToolCerrarSesion.Size = new System.Drawing.Size(210, 28);
			this.ToolCerrarSesion.Text = "Crerrar sesión";
			this.ToolCerrarSesion.Click += new System.EventHandler(this.crerrarSesiónToolStripMenuItem_Click);
			// 
			// ToolRegistros
			// 
			this.ToolRegistros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolClientes,
            this.ToolProductos,
            this.ToolCategorias});
			this.ToolRegistros.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ToolRegistros.ForeColor = System.Drawing.Color.Black;
			this.ToolRegistros.Image = ((System.Drawing.Image)(resources.GetObject("ToolRegistros.Image")));
			this.ToolRegistros.Name = "ToolRegistros";
			this.ToolRegistros.Size = new System.Drawing.Size(140, 27);
			this.ToolRegistros.Text = "REGISTRAR";
			// 
			// ToolClientes
			// 
			this.ToolClientes.Image = ((System.Drawing.Image)(resources.GetObject("ToolClientes.Image")));
			this.ToolClientes.Name = "ToolClientes";
			this.ToolClientes.Size = new System.Drawing.Size(187, 28);
			this.ToolClientes.Text = "Cientes";
			this.ToolClientes.Click += new System.EventHandler(this.registrarClienteToolStripMenuItem1_Click);
			// 
			// ToolProductos
			// 
			this.ToolProductos.Image = ((System.Drawing.Image)(resources.GetObject("ToolProductos.Image")));
			this.ToolProductos.Name = "ToolProductos";
			this.ToolProductos.Size = new System.Drawing.Size(187, 28);
			this.ToolProductos.Text = "Productos";
			this.ToolProductos.Click += new System.EventHandler(this.registrarProductoToolStripMenuItem_Click);
			// 
			// ToolCategorias
			// 
			this.ToolCategorias.Image = ((System.Drawing.Image)(resources.GetObject("ToolCategorias.Image")));
			this.ToolCategorias.Name = "ToolCategorias";
			this.ToolCategorias.Size = new System.Drawing.Size(187, 28);
			this.ToolCategorias.Text = "Categorias";
			this.ToolCategorias.Click += new System.EventHandler(this.categoriasToolStripMenuItem_Click);
			// 
			// ToolVentas
			// 
			this.ToolVentas.Font = new System.Drawing.Font("Century Gothic", 15F);
			this.ToolVentas.ForeColor = System.Drawing.Color.Black;
			this.ToolVentas.Image = ((System.Drawing.Image)(resources.GetObject("ToolVentas.Image")));
			this.ToolVentas.Name = "ToolVentas";
			this.ToolVentas.Size = new System.Drawing.Size(112, 27);
			this.ToolVentas.Text = "VENTAS";
			this.ToolVentas.Click += new System.EventHandler(this.vENTASToolStripMenuItem_Click);
			// 
			// ToolEstadisticas
			// 
			this.ToolEstadisticas.Font = new System.Drawing.Font("Century Gothic", 15F);
			this.ToolEstadisticas.ForeColor = System.Drawing.Color.Black;
			this.ToolEstadisticas.Image = ((System.Drawing.Image)(resources.GetObject("ToolEstadisticas.Image")));
			this.ToolEstadisticas.Name = "ToolEstadisticas";
			this.ToolEstadisticas.Size = new System.Drawing.Size(166, 27);
			this.ToolEstadisticas.Text = "ESTADISTICAS";
			this.ToolEstadisticas.Click += new System.EventHandler(this.eSTADISTICASToolStripMenuItem_Click);
			// 
			// ToolFacturación
			// 
			this.ToolFacturación.Font = new System.Drawing.Font("Century Gothic", 15F);
			this.ToolFacturación.ForeColor = System.Drawing.Color.Black;
			this.ToolFacturación.Image = ((System.Drawing.Image)(resources.GetObject("ToolFacturación.Image")));
			this.ToolFacturación.Name = "ToolFacturación";
			this.ToolFacturación.Size = new System.Drawing.Size(165, 27);
			this.ToolFacturación.Text = "FACTURCIÓN";
			this.ToolFacturación.Click += new System.EventHandler(this.fACTURCIÓNToolStripMenuItem_Click);
			// 
			// ToolConfiguracion
			// 
			this.ToolConfiguracion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolUsuarios});
			this.ToolConfiguracion.Font = new System.Drawing.Font("Century Gothic", 15F);
			this.ToolConfiguracion.ForeColor = System.Drawing.Color.Black;
			this.ToolConfiguracion.Image = ((System.Drawing.Image)(resources.GetObject("ToolConfiguracion.Image")));
			this.ToolConfiguracion.Name = "ToolConfiguracion";
			this.ToolConfiguracion.Size = new System.Drawing.Size(211, 27);
			this.ToolConfiguracion.Text = "CONFIGURACIÓN";
			// 
			// ToolUsuarios
			// 
			this.ToolUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("ToolUsuarios.Image")));
			this.ToolUsuarios.Name = "ToolUsuarios";
			this.ToolUsuarios.Size = new System.Drawing.Size(157, 28);
			this.ToolUsuarios.Text = "Usuarios";
			this.ToolUsuarios.Click += new System.EventHandler(this.uSUARIOSToolStripMenuItem_Click);
			// 
			// IdVenta
			// 
			this.IdVenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.IdVenta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.IdVenta.ForeColor = System.Drawing.SystemColors.MenuText;
			this.IdVenta.Location = new System.Drawing.Point(239, 6);
			this.IdVenta.Name = "IdVenta";
			this.IdVenta.Size = new System.Drawing.Size(26, 27);
			this.IdVenta.TabIndex = 99;
			this.IdVenta.Visible = false;
			// 
			// codCliente
			// 
			this.codCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.codCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.codCliente.ForeColor = System.Drawing.SystemColors.MenuText;
			this.codCliente.Location = new System.Drawing.Point(207, 6);
			this.codCliente.Name = "codCliente";
			this.codCliente.Size = new System.Drawing.Size(26, 27);
			this.codCliente.TabIndex = 98;
			this.codCliente.Visible = false;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.SystemColors.Window;
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel3.Controls.Add(this.TxtStock);
			this.panel3.Controls.Add(this.IdVenta);
			this.panel3.Controls.Add(this.codCliente);
			this.panel3.Controls.Add(this.BuscarCliente);
			this.panel3.Controls.Add(this.txtcliente);
			this.panel3.Controls.Add(this.label4);
			this.panel3.Controls.Add(this.label3);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.panel3.Location = new System.Drawing.Point(0, 31);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1093, 100);
			this.panel3.TabIndex = 106;
			// 
			// TxtStock
			// 
			this.TxtStock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.TxtStock.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtStock.ForeColor = System.Drawing.SystemColors.MenuText;
			this.TxtStock.Location = new System.Drawing.Point(271, 6);
			this.TxtStock.Name = "TxtStock";
			this.TxtStock.Size = new System.Drawing.Size(26, 27);
			this.TxtStock.TabIndex = 100;
			this.TxtStock.Visible = false;
			// 
			// BuscarCliente
			// 
			this.BuscarCliente.FlatAppearance.BorderSize = 0;
			this.BuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BuscarCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
			this.BuscarCliente.Image = ((System.Drawing.Image)(resources.GetObject("BuscarCliente.Image")));
			this.BuscarCliente.Location = new System.Drawing.Point(373, 43);
			this.BuscarCliente.Name = "BuscarCliente";
			this.BuscarCliente.Size = new System.Drawing.Size(36, 32);
			this.BuscarCliente.TabIndex = 92;
			this.BuscarCliente.UseVisualStyleBackColor = true;
			this.BuscarCliente.Click += new System.EventHandler(this.BuscarCliente_Click);
			// 
			// txtcliente
			// 
			this.txtcliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.txtcliente.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.txtcliente.Location = new System.Drawing.Point(77, 46);
			this.txtcliente.Name = "txtcliente";
			this.txtcliente.Size = new System.Drawing.Size(290, 27);
			this.txtcliente.TabIndex = 92;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(3, 3);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(188, 19);
			this.label4.TabIndex = 85;
			this.label4.Text = "Información del cliente";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
			this.label3.Location = new System.Drawing.Point(8, 50);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(63, 19);
			this.label3.TabIndex = 75;
			this.label3.Text = "Cliente";
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.SystemColors.Window;
			this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel4.Controls.Add(this.BuscarProducto);
			this.panel4.Controls.Add(this.TxtPrecio);
			this.panel4.Controls.Add(this.label9);
			this.panel4.Controls.Add(this.TxtCodigo);
			this.panel4.Controls.Add(this.label8);
			this.panel4.Controls.Add(this.TxtProducto);
			this.panel4.Controls.Add(this.label6);
			this.panel4.Controls.Add(this.TxtCantidad);
			this.panel4.Controls.Add(this.label5);
			this.panel4.Controls.Add(this.label7);
			this.panel4.Controls.Add(this.BtnAgregarProducto);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(0, 131);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(1093, 136);
			this.panel4.TabIndex = 107;
			// 
			// BuscarProducto
			// 
			this.BuscarProducto.FlatAppearance.BorderSize = 0;
			this.BuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BuscarProducto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
			this.BuscarProducto.Image = ((System.Drawing.Image)(resources.GetObject("BuscarProducto.Image")));
			this.BuscarProducto.Location = new System.Drawing.Point(618, 51);
			this.BuscarProducto.Name = "BuscarProducto";
			this.BuscarProducto.Size = new System.Drawing.Size(36, 32);
			this.BuscarProducto.TabIndex = 93;
			this.BuscarProducto.UseVisualStyleBackColor = true;
			this.BuscarProducto.Click += new System.EventHandler(this.BuscarProducto_Click);
			// 
			// TxtPrecio
			// 
			this.TxtPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.TxtPrecio.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.TxtPrecio.Location = new System.Drawing.Point(77, 99);
			this.TxtPrecio.Name = "TxtPrecio";
			this.TxtPrecio.Size = new System.Drawing.Size(213, 27);
			this.TxtPrecio.TabIndex = 91;
			// 
			// label9
			// 
			this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
			this.label9.Location = new System.Drawing.Point(14, 103);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(57, 19);
			this.label9.TabIndex = 90;
			this.label9.Text = "Precio";
			// 
			// TxtCodigo
			// 
			this.TxtCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.TxtCodigo.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.TxtCodigo.Location = new System.Drawing.Point(77, 54);
			this.TxtCodigo.Name = "TxtCodigo";
			this.TxtCodigo.Size = new System.Drawing.Size(213, 27);
			this.TxtCodigo.TabIndex = 89;
			// 
			// label8
			// 
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
			this.label8.Location = new System.Drawing.Point(4, 58);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(67, 19);
			this.label8.TabIndex = 88;
			this.label8.Text = "Código";
			// 
			// TxtProducto
			// 
			this.TxtProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.TxtProducto.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.TxtProducto.Location = new System.Drawing.Point(399, 54);
			this.TxtProducto.Name = "TxtProducto";
			this.TxtProducto.Size = new System.Drawing.Size(213, 27);
			this.TxtProducto.TabIndex = 87;
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(3, 3);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(207, 19);
			this.label6.TabIndex = 86;
			this.label6.Text = "Información del producto";
			// 
			// TxtCantidad
			// 
			this.TxtCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.TxtCantidad.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.TxtCantidad.Location = new System.Drawing.Point(765, 54);
			this.TxtCantidad.Name = "TxtCantidad";
			this.TxtCantidad.Size = new System.Drawing.Size(213, 27);
			this.TxtCantidad.TabIndex = 77;
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
			this.label5.Location = new System.Drawing.Point(315, 58);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(78, 19);
			this.label5.TabIndex = 74;
			this.label5.Text = "Producto";
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
			this.label7.Location = new System.Drawing.Point(676, 58);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(83, 19);
			this.label7.TabIndex = 76;
			this.label7.Text = "Cantidad";
			// 
			// BtnAgregarProducto
			// 
			this.BtnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnAgregarProducto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
			this.BtnAgregarProducto.Location = new System.Drawing.Point(319, 92);
			this.BtnAgregarProducto.Name = "BtnAgregarProducto";
			this.BtnAgregarProducto.Size = new System.Drawing.Size(171, 34);
			this.BtnAgregarProducto.TabIndex = 78;
			this.BtnAgregarProducto.Text = "Agregar producto";
			this.BtnAgregarProducto.UseVisualStyleBackColor = true;
			this.BtnAgregarProducto.Click += new System.EventHandler(this.AgregarProducto_Click);
			// 
			// LblSalir
			// 
			this.LblSalir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.LblSalir.AutoSize = true;
			this.LblSalir.BackColor = System.Drawing.Color.LightSkyBlue;
			this.LblSalir.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblSalir.ForeColor = System.Drawing.Color.Red;
			this.LblSalir.Location = new System.Drawing.Point(1063, 3);
			this.LblSalir.Name = "LblSalir";
			this.LblSalir.Size = new System.Drawing.Size(26, 25);
			this.LblSalir.TabIndex = 101;
			this.LblSalir.Text = "X";
			this.LblSalir.Click += new System.EventHandler(this.LblSalir_Click);
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.TipoUsuario);
			this.panel1.Controls.Add(this.IdUsuario);
			this.panel1.Controls.Add(this.Usuario);
			this.panel1.Controls.Add(this.lblfecha);
			this.panel1.Controls.Add(this.lblhora);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 724);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1093, 43);
			this.panel1.TabIndex = 113;
			// 
			// TipoUsuario
			// 
			this.TipoUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.TipoUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TipoUsuario.ForeColor = System.Drawing.SystemColors.MenuText;
			this.TipoUsuario.Location = new System.Drawing.Point(586, 10);
			this.TipoUsuario.Name = "TipoUsuario";
			this.TipoUsuario.Size = new System.Drawing.Size(129, 27);
			this.TipoUsuario.TabIndex = 103;
			this.TipoUsuario.Visible = false;
			// 
			// IdUsuario
			// 
			this.IdUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.IdUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.IdUsuario.ForeColor = System.Drawing.SystemColors.MenuText;
			this.IdUsuario.Location = new System.Drawing.Point(2, 10);
			this.IdUsuario.Name = "IdUsuario";
			this.IdUsuario.Size = new System.Drawing.Size(26, 27);
			this.IdUsuario.TabIndex = 100;
			this.IdUsuario.Visible = false;
			// 
			// Usuario
			// 
			this.Usuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.Usuario.AutoSize = true;
			this.Usuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
			this.Usuario.Location = new System.Drawing.Point(30, 14);
			this.Usuario.Name = "Usuario";
			this.Usuario.Size = new System.Drawing.Size(0, 19);
			this.Usuario.TabIndex = 94;
			// 
			// lblfecha
			// 
			this.lblfecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblfecha.AutoSize = true;
			this.lblfecha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblfecha.ForeColor = System.Drawing.Color.Black;
			this.lblfecha.Location = new System.Drawing.Point(951, 22);
			this.lblfecha.Name = "lblfecha";
			this.lblfecha.Size = new System.Drawing.Size(95, 19);
			this.lblfecha.TabIndex = 102;
			this.lblfecha.Text = "16/07/2023";
			// 
			// lblhora
			// 
			this.lblhora.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblhora.AutoSize = true;
			this.lblhora.BackColor = System.Drawing.SystemColors.Window;
			this.lblhora.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblhora.ForeColor = System.Drawing.Color.Black;
			this.lblhora.Location = new System.Drawing.Point(946, 3);
			this.lblhora.Name = "lblhora";
			this.lblhora.Size = new System.Drawing.Size(110, 19);
			this.lblhora.TabIndex = 101;
			this.lblhora.Text = "11:55:00 a.m.";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.Window;
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.CancelarVenta);
			this.panel2.Controls.Add(this.GuardarVenta);
			this.panel2.Controls.Add(this.EliminarProducto);
			this.panel2.Controls.Add(this.EditarProducto);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.txtTotal);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel2.Location = new System.Drawing.Point(875, 267);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(218, 457);
			this.panel2.TabIndex = 114;
			// 
			// CancelarVenta
			// 
			this.CancelarVenta.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.CancelarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CancelarVenta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CancelarVenta.Location = new System.Drawing.Point(14, 170);
			this.CancelarVenta.Name = "CancelarVenta";
			this.CancelarVenta.Size = new System.Drawing.Size(180, 34);
			this.CancelarVenta.TabIndex = 92;
			this.CancelarVenta.Text = "Cancelar venta";
			this.CancelarVenta.UseVisualStyleBackColor = true;
			this.CancelarVenta.Click += new System.EventHandler(this.CancelarVenta_Click);
			// 
			// GuardarVenta
			// 
			this.GuardarVenta.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.GuardarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.GuardarVenta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.GuardarVenta.Location = new System.Drawing.Point(14, 268);
			this.GuardarVenta.Name = "GuardarVenta";
			this.GuardarVenta.Size = new System.Drawing.Size(180, 34);
			this.GuardarVenta.TabIndex = 91;
			this.GuardarVenta.Text = "Realizar venta";
			this.GuardarVenta.UseVisualStyleBackColor = true;
			this.GuardarVenta.Click += new System.EventHandler(this.GuardarVenta_Click);
			// 
			// EliminarProducto
			// 
			this.EliminarProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.EliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.EliminarProducto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.EliminarProducto.Location = new System.Drawing.Point(14, 130);
			this.EliminarProducto.Name = "EliminarProducto";
			this.EliminarProducto.Size = new System.Drawing.Size(180, 34);
			this.EliminarProducto.TabIndex = 89;
			this.EliminarProducto.Text = "Eliminar fila";
			this.EliminarProducto.UseVisualStyleBackColor = true;
			this.EliminarProducto.Click += new System.EventHandler(this.EliminarProducto_Click_1);
			// 
			// EditarProducto
			// 
			this.EditarProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.EditarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.EditarProducto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.EditarProducto.Location = new System.Drawing.Point(14, 90);
			this.EditarProducto.Name = "EditarProducto";
			this.EditarProducto.Size = new System.Drawing.Size(180, 34);
			this.EditarProducto.TabIndex = 90;
			this.EditarProducto.Text = "Editar producto";
			this.EditarProducto.UseVisualStyleBackColor = true;
			this.EditarProducto.Click += new System.EventHandler(this.EditarProducto_Click);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(3, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 25);
			this.label1.TabIndex = 87;
			this.label1.Text = "Total";
			// 
			// panel5
			// 
			this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel5.Controls.Add(this.dataGridView1);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel5.Location = new System.Drawing.Point(0, 267);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(875, 457);
			this.panel5.TabIndex = 115;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGray;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGray;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.EnableHeadersVisualStyles = false;
			this.dataGridView1.GridColor = System.Drawing.SystemColors.AppWorkspace;
			this.dataGridView1.Location = new System.Drawing.Point(0, 0);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
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
			this.dataGridView1.Size = new System.Drawing.Size(873, 455);
			this.dataGridView1.TabIndex = 112;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// Column1
			// 
			this.Column1.HeaderText = "CÓDIGO";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "PRODUCTO";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "CANTIDAD";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			// 
			// Column4
			// 
			this.Column4.HeaderText = "PRECIO UND";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			// 
			// Column5
			// 
			this.Column5.HeaderText = "TOTAL";
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			// 
			// txtTotal
			// 
			this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtTotal.BackColor = System.Drawing.Color.White;
			this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtTotal.Cursor = System.Windows.Forms.Cursors.No;
			this.txtTotal.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTotal.ForeColor = System.Drawing.Color.Red;
			this.txtTotal.Location = new System.Drawing.Point(66, 10);
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.Size = new System.Drawing.Size(141, 26);
			this.txtTotal.TabIndex = 81;
			this.txtTotal.TabStop = false;
			// 
			// Home
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(1093, 767);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.LblSalir);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.menuStrip1);
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Home";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.RegistroFacturas_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer HoraFecha;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolRegistros;
        private System.Windows.Forms.ToolStripMenuItem ToolClientes;
        private System.Windows.Forms.ToolStripMenuItem ToolProductos;
        private System.Windows.Forms.ToolStripMenuItem ToolArchivo;
        private System.Windows.Forms.ToolStripMenuItem ToolEstadisticas;
        private System.Windows.Forms.ToolStripMenuItem ToolFacturación;
        private System.Windows.Forms.ToolStripMenuItem ToolConfiguracion;
        private System.Windows.Forms.ToolStripMenuItem ToolCerrarSesion;
        private System.Windows.Forms.ToolStripMenuItem ToolVentas;
        private System.Windows.Forms.ToolStripMenuItem ToolUsuarios;
        public System.Windows.Forms.TextBox IdVenta;
        public System.Windows.Forms.TextBox codCliente;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BuscarCliente;
        public System.Windows.Forms.TextBox txtcliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BuscarProducto;
        public System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox TxtProducto;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnAgregarProducto;
        private System.Windows.Forms.Label LblSalir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button GuardarVenta;
        private System.Windows.Forms.Button EliminarProducto;
        private System.Windows.Forms.Button EditarProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        public System.Windows.Forms.Label Usuario;
        public System.Windows.Forms.TextBox IdUsuario;
        private System.Windows.Forms.ToolStripMenuItem ToolCategorias;
        public System.Windows.Forms.TextBox TxtStock;
        private System.Windows.Forms.Button CancelarVenta;
        public System.Windows.Forms.TextBox TipoUsuario;
		public System.Windows.Forms.TextBox txtTotal;
	}
}

