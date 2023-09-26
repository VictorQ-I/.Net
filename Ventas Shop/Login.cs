using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas_Shop
{
    public partial class Login : Form
    {
        public SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-VUJNIAL\\SQLEXPRESS; database=CONSULTA; integrated security = True; MultipleActiveResultSets=true");
        public Home principal = new Home();
        public Login()
        {
            InitializeComponent();
            TextContraseña.PasswordChar = '*';
            TextContraseña.MaxLength = 14;
			TextUsuario.Focus();
		}
        private void Login_Load(object sender, EventArgs e)
        {
            TextUsuario.Focus();
        }
        private void Ingresar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            SqlCommand cadena = new SqlCommand("SELECT IdUsuario, Nombre, TipoUsuario FROM Usuario WHERE Usuario = @Usuario AND Contraseña = @Contraseña", conexion);
            cadena.Parameters.AddWithValue("Usuario", TextUsuario.Text);
            cadena.Parameters.AddWithValue("Contraseña", TextContraseña.Text);
            SqlDataReader reader = cadena.ExecuteReader();


            if (reader.Read())
            {
                this.Hide();
                principal.Usuario.Text = reader["Nombre"].ToString();
                principal.IdUsuario.Text = reader["IdUsuario"].ToString();
                principal.TipoUsuario.Text = reader["TipoUsuario"].ToString();
                principal.ShowDialog();
            }
            else
            {
                MensajeError.Text = "Usuario y/o contraseña incorrectas";
				TextUsuario.Text = "";
                TextContraseña.Text = "";
				TextUsuario.Focus();
			}
			conexion.Close();
		}
        private void TextUsuario_Click(object sender, EventArgs e)
        {
            MensajeError.Text = "";
        }
        private void TextContraseña_Click(object sender, EventArgs e)
        {
            MensajeError.Text = "";
        }
        private void TextContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

                conexion.Open();
                SqlCommand cadena = new SqlCommand("SELECT IdUsuario, Nombre, TipoUsuario FROM Usuario WHERE Usuario = @Usuario AND Contraseña = @Contraseña", conexion);
                cadena.Parameters.AddWithValue("Usuario", TextUsuario.Text);
                cadena.Parameters.AddWithValue("Contraseña", TextContraseña.Text);
                SqlDataReader reader = cadena.ExecuteReader();


                if (reader.Read())
                {
                    this.Hide();
                    principal.Usuario.Text = reader["Nombre"].ToString();
                    principal.IdUsuario.Text = reader["IdUsuario"].ToString();
                    principal.TipoUsuario.Text = reader["TipoUsuario"].ToString();
                    principal.ShowDialog();
                }
                else
                {
                    MensajeError.Text = "Usuario y/o contraseña incorrectas";
					TextUsuario.Text = "";
					TextContraseña.Text = "";
                    TextUsuario.Focus();
				}
				conexion.Close();
			}
        }
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
