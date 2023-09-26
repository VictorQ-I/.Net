namespace Ventas_Shop
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Ingresar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bdfactura1 = new Ventas_Shop.BDFACTURA();
            this.TextUsuario = new System.Windows.Forms.TextBox();
            this.TextContraseña = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MensajeError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdfactura1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Teal;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(341, 125);
            this.label4.MaximumSize = new System.Drawing.Size(0, 2);
            this.label4.MinimumSize = new System.Drawing.Size(220, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 2);
            this.label4.TabIndex = 87;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(341, 186);
            this.label1.MaximumSize = new System.Drawing.Size(0, 2);
            this.label1.MinimumSize = new System.Drawing.Size(220, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 2);
            this.label1.TabIndex = 89;
            // 
            // Ingresar
            // 
            this.Ingresar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Ingresar.BackColor = System.Drawing.Color.DarkCyan;
            this.Ingresar.FlatAppearance.BorderSize = 0;
            this.Ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ingresar.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.Ingresar.ForeColor = System.Drawing.SystemColors.Window;
            this.Ingresar.Location = new System.Drawing.Point(340, 231);
            this.Ingresar.Name = "Ingresar";
            this.Ingresar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Ingresar.Size = new System.Drawing.Size(221, 44);
            this.Ingresar.TabIndex = 91;
            this.Ingresar.Text = "Ingresar";
            this.Ingresar.UseVisualStyleBackColor = false;
            this.Ingresar.Click += new System.EventHandler(this.Ingresar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 250);
            this.pictureBox1.TabIndex = 92;
            this.pictureBox1.TabStop = false;
            // 
            // bdfactura1
            // 
            this.bdfactura1.DataSetName = "BDFACTURA";
            this.bdfactura1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TextUsuario
            // 
            this.TextUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextUsuario.BackColor = System.Drawing.SystemColors.Window;
            this.TextUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextUsuario.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.TextUsuario.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TextUsuario.Location = new System.Drawing.Point(340, 105);
            this.TextUsuario.Name = "TextUsuario";
            this.TextUsuario.Size = new System.Drawing.Size(221, 20);
            this.TextUsuario.TabIndex = 93;
            this.TextUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextUsuario.Click += new System.EventHandler(this.TextUsuario_Click);
            // 
            // TextContraseña
            // 
            this.TextContraseña.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextContraseña.BackColor = System.Drawing.SystemColors.Window;
            this.TextContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextContraseña.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.TextContraseña.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TextContraseña.Location = new System.Drawing.Point(340, 165);
            this.TextContraseña.Name = "TextContraseña";
            this.TextContraseña.Size = new System.Drawing.Size(221, 20);
            this.TextContraseña.TabIndex = 94;
            this.TextContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextContraseña.Click += new System.EventHandler(this.TextContraseña_Click);
            this.TextContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextContraseña_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.Location = new System.Drawing.Point(338, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 21);
            this.label2.TabIndex = 98;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label3.Location = new System.Drawing.Point(338, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 21);
            this.label3.TabIndex = 99;
            this.label3.Text = "Contraseña";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(378, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 23);
            this.label5.TabIndex = 100;
            this.label5.Text = "INICIAR SESIÓN";
            // 
            // MensajeError
            // 
            this.MensajeError.AutoSize = true;
            this.MensajeError.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.MensajeError.ForeColor = System.Drawing.Color.Red;
            this.MensajeError.Location = new System.Drawing.Point(315, 195);
            this.MensajeError.Name = "MensajeError";
            this.MensajeError.Size = new System.Drawing.Size(0, 21);
            this.MensajeError.TabIndex = 101;
            this.MensajeError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(607, 334);
            this.Controls.Add(this.MensajeError);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextContraseña);
            this.Controls.Add(this.TextUsuario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Ingresar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdfactura1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Ingresar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private BDFACTURA bdfactura1;
        private System.Windows.Forms.TextBox TextUsuario;
        private System.Windows.Forms.TextBox TextContraseña;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label MensajeError;
    }
}