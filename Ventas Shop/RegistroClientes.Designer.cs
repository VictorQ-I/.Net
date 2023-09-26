namespace Ventas_Shop
{
    partial class RegistroClientes
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroClientes));
			this.Editar = new System.Windows.Forms.Button();
			this.Eliminar = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.button2 = new System.Windows.Forms.Button();
			this.Guardar = new System.Windows.Forms.Button();
			this.telefono = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.correo = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.apellido = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.nombre = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.buscar = new System.Windows.Forms.TextBox();
			this.DescargarInfo = new System.Windows.Forms.Button();
			this.txtCodigoPostal = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.txtDireccion = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.IdRegistro = new System.Windows.Forms.TextBox();
			this.Cancelar = new System.Windows.Forms.Button();
			this.IdDepartamento = new System.Windows.Forms.TextBox();
			this.txtDepartamento = new System.Windows.Forms.ComboBox();
			this.txtCiudad = new System.Windows.Forms.ComboBox();
			this.IdCiudad = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// Editar
			// 
			this.Editar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Editar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Editar.Location = new System.Drawing.Point(683, 136);
			this.Editar.Name = "Editar";
			this.Editar.Size = new System.Drawing.Size(148, 34);
			this.Editar.TabIndex = 75;
			this.Editar.Text = "Editar cliente";
			this.Editar.UseVisualStyleBackColor = true;
			this.Editar.Click += new System.EventHandler(this.button8_Click);
			// 
			// Eliminar
			// 
			this.Eliminar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Eliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Eliminar.Location = new System.Drawing.Point(837, 136);
			this.Eliminar.Name = "Eliminar";
			this.Eliminar.Size = new System.Drawing.Size(148, 34);
			this.Eliminar.TabIndex = 74;
			this.Eliminar.Text = "Eliminar cliente";
			this.Eliminar.UseVisualStyleBackColor = true;
			this.Eliminar.Click += new System.EventHandler(this.button7_Click);
			// 
			// button3
			// 
			this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
			this.button3.Location = new System.Drawing.Point(1608, 3);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(100, 34);
			this.button3.TabIndex = 73;
			this.button3.Text = "Salir";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
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
			this.dataGridView1.Location = new System.Drawing.Point(682, 176);
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
			this.dataGridView1.Size = new System.Drawing.Size(1026, 264);
			this.dataGridView1.TabIndex = 72;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
			this.button2.Location = new System.Drawing.Point(3, 5);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(92, 34);
			this.button2.TabIndex = 71;
			this.button2.Text = "Volver";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Guardar
			// 
			this.Guardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Guardar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
			this.Guardar.Location = new System.Drawing.Point(90, 386);
			this.Guardar.Name = "Guardar";
			this.Guardar.Size = new System.Drawing.Size(191, 34);
			this.Guardar.TabIndex = 69;
			this.Guardar.Text = "Guardar";
			this.Guardar.UseVisualStyleBackColor = true;
			this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
			// 
			// telefono
			// 
			this.telefono.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.telefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.telefono.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.telefono.Location = new System.Drawing.Point(466, 226);
			this.telefono.Name = "telefono";
			this.telefono.Size = new System.Drawing.Size(191, 27);
			this.telefono.TabIndex = 68;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
			this.label4.Location = new System.Drawing.Point(374, 229);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(74, 19);
			this.label4.TabIndex = 67;
			this.label4.Text = "Teléfono";
			// 
			// correo
			// 
			this.correo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.correo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.correo.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.correo.Location = new System.Drawing.Point(104, 223);
			this.correo.Name = "correo";
			this.correo.Size = new System.Drawing.Size(191, 27);
			this.correo.TabIndex = 66;
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
			this.label5.Location = new System.Drawing.Point(27, 226);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(61, 19);
			this.label5.TabIndex = 65;
			this.label5.Text = "Correo";
			// 
			// apellido
			// 
			this.apellido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.apellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.apellido.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.apellido.Location = new System.Drawing.Point(466, 180);
			this.apellido.Name = "apellido";
			this.apellido.Size = new System.Drawing.Size(191, 27);
			this.apellido.TabIndex = 64;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
			this.label3.Location = new System.Drawing.Point(373, 183);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(75, 19);
			this.label3.TabIndex = 63;
			this.label3.Text = "Apellido";
			// 
			// nombre
			// 
			this.nombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.nombre.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.nombre.Location = new System.Drawing.Point(104, 180);
			this.nombre.Name = "nombre";
			this.nombre.Size = new System.Drawing.Size(191, 27);
			this.nombre.TabIndex = 62;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
			this.label2.Location = new System.Drawing.Point(17, 183);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 19);
			this.label2.TabIndex = 61;
			this.label2.Text = "Nombre";
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(781, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(101, 25);
			this.label1.TabIndex = 60;
			this.label1.Text = "CLIENTES";
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Black;
			this.label6.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
			this.label6.Location = new System.Drawing.Point(1485, 169);
			this.label6.MaximumSize = new System.Drawing.Size(0, 1);
			this.label6.MinimumSize = new System.Drawing.Size(210, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(210, 1);
			this.label6.TabIndex = 85;
			// 
			// btnBuscar
			// 
			this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.btnBuscar.FlatAppearance.BorderSize = 0;
			this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
			this.btnBuscar.Location = new System.Drawing.Point(1673, 136);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(35, 34);
			this.btnBuscar.TabIndex = 83;
			this.btnBuscar.TabStop = false;
			this.btnBuscar.UseVisualStyleBackColor = true;
			// 
			// buscar
			// 
			this.buscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buscar.BackColor = System.Drawing.SystemColors.Window;
			this.buscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.buscar.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.buscar.Location = new System.Drawing.Point(1490, 150);
			this.buscar.Name = "buscar";
			this.buscar.Size = new System.Drawing.Size(199, 20);
			this.buscar.TabIndex = 84;
			this.buscar.Text = "Buscar...";
			this.buscar.Click += new System.EventHandler(this.buscar_Click);
			this.buscar.TextChanged += new System.EventHandler(this.buscar_TextChanged);
			// 
			// DescargarInfo
			// 
			this.DescargarInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.DescargarInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.DescargarInfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DescargarInfo.Location = new System.Drawing.Point(991, 136);
			this.DescargarInfo.Name = "DescargarInfo";
			this.DescargarInfo.Size = new System.Drawing.Size(205, 34);
			this.DescargarInfo.TabIndex = 86;
			this.DescargarInfo.Text = "Descargar información";
			this.DescargarInfo.UseVisualStyleBackColor = true;
			this.DescargarInfo.Click += new System.EventHandler(this.DescargarInfo_Click);
			// 
			// txtCodigoPostal
			// 
			this.txtCodigoPostal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.txtCodigoPostal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtCodigoPostal.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.txtCodigoPostal.Location = new System.Drawing.Point(466, 314);
			this.txtCodigoPostal.Name = "txtCodigoPostal";
			this.txtCodigoPostal.Size = new System.Drawing.Size(191, 27);
			this.txtCodigoPostal.TabIndex = 94;
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
			this.label7.Location = new System.Drawing.Point(332, 317);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(117, 19);
			this.label7.TabIndex = 93;
			this.label7.Text = "Código postal";
			// 
			// label8
			// 
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
			this.label8.Location = new System.Drawing.Point(26, 314);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(68, 19);
			this.label8.TabIndex = 91;
			this.label8.Text = "Ciudad";
			// 
			// label9
			// 
			this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
			this.label9.Location = new System.Drawing.Point(326, 271);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(122, 19);
			this.label9.TabIndex = 89;
			this.label9.Text = "Departamento";
			// 
			// txtDireccion
			// 
			this.txtDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtDireccion.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.txtDireccion.Location = new System.Drawing.Point(104, 268);
			this.txtDireccion.Name = "txtDireccion";
			this.txtDireccion.Size = new System.Drawing.Size(191, 27);
			this.txtDireccion.TabIndex = 88;
			// 
			// label10
			// 
			this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
			this.label10.Location = new System.Drawing.Point(8, 271);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(83, 19);
			this.label10.TabIndex = 87;
			this.label10.Text = "Dirección";
			// 
			// IdRegistro
			// 
			this.IdRegistro.Location = new System.Drawing.Point(114, 8);
			this.IdRegistro.Name = "IdRegistro";
			this.IdRegistro.Size = new System.Drawing.Size(37, 20);
			this.IdRegistro.TabIndex = 95;
			this.IdRegistro.Visible = false;
			// 
			// Cancelar
			// 
			this.Cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Cancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
			this.Cancelar.Location = new System.Drawing.Point(368, 386);
			this.Cancelar.Name = "Cancelar";
			this.Cancelar.Size = new System.Drawing.Size(191, 34);
			this.Cancelar.TabIndex = 96;
			this.Cancelar.Text = "Cancelar";
			this.Cancelar.UseVisualStyleBackColor = true;
			this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
			// 
			// IdDepartamento
			// 
			this.IdDepartamento.Location = new System.Drawing.Point(157, 9);
			this.IdDepartamento.Name = "IdDepartamento";
			this.IdDepartamento.Size = new System.Drawing.Size(37, 20);
			this.IdDepartamento.TabIndex = 99;
			this.IdDepartamento.Visible = false;
			// 
			// txtDepartamento
			// 
			this.txtDepartamento.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.txtDepartamento.FormattingEnabled = true;
			this.txtDepartamento.Location = new System.Drawing.Point(466, 268);
			this.txtDepartamento.Name = "txtDepartamento";
			this.txtDepartamento.Size = new System.Drawing.Size(191, 29);
			this.txtDepartamento.TabIndex = 102;
			this.txtDepartamento.SelectionChangeCommitted += new System.EventHandler(this.txtDepartamento_SelectionChangeCommitted);
			// 
			// txtCiudad
			// 
			this.txtCiudad.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.txtCiudad.FormattingEnabled = true;
			this.txtCiudad.Location = new System.Drawing.Point(104, 314);
			this.txtCiudad.Name = "txtCiudad";
			this.txtCiudad.Size = new System.Drawing.Size(191, 29);
			this.txtCiudad.TabIndex = 103;
			this.txtCiudad.SelectionChangeCommitted += new System.EventHandler(this.txtCiudad_SelectionChangeCommitted);
			// 
			// IdCiudad
			// 
			this.IdCiudad.Location = new System.Drawing.Point(200, 8);
			this.IdCiudad.Name = "IdCiudad";
			this.IdCiudad.Size = new System.Drawing.Size(37, 20);
			this.IdCiudad.TabIndex = 104;
			this.IdCiudad.Visible = false;
			// 
			// RegistroClientes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(1720, 452);
			this.Controls.Add(this.IdCiudad);
			this.Controls.Add(this.txtCiudad);
			this.Controls.Add(this.txtDepartamento);
			this.Controls.Add(this.IdDepartamento);
			this.Controls.Add(this.Cancelar);
			this.Controls.Add(this.IdRegistro);
			this.Controls.Add(this.txtCodigoPostal);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.txtDireccion);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.DescargarInfo);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.buscar);
			this.Controls.Add(this.Editar);
			this.Controls.Add(this.Eliminar);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.Guardar);
			this.Controls.Add(this.telefono);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.correo);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.apellido);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.nombre);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "RegistroClientes";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.RegistroClientes_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Editar;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.TextBox telefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox correo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox apellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox buscar;
        private System.Windows.Forms.Button DescargarInfo;
        private System.Windows.Forms.TextBox txtCodigoPostal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox IdRegistro;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.TextBox IdDepartamento;
        private System.Windows.Forms.ComboBox txtDepartamento;
        private System.Windows.Forms.ComboBox txtCiudad;
        private System.Windows.Forms.TextBox IdCiudad;
    }
}