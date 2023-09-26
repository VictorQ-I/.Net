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
using System.Collections;

namespace Ventas_Shop
{
    public partial class Estadisticas : Form
    {
        public SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-VUJNIAL\\SQLEXPRESS; database=CONSULTA; integrated security = True; MultipleActiveResultSets=true");
        public SqlCommand cmd;
        SqlDataReader dr;

        public Estadisticas()
        {
            InitializeComponent();
        }
        private void Estadisticas_Load(object sender, EventArgs e)
        {
            ProductosPreferidos();
            CantidadDatos();
        }
        ArrayList producto = new ArrayList();
        ArrayList cantidad = new ArrayList();
        private void ProductosPreferidos()
        {
            cmd = new SqlCommand("ProductosMasVendidos", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                producto.Add(dr.GetString(0));
                cantidad.Add(dr.GetInt32(1));
            }
            chartProductosPreferidos.Series[0].Points.DataBindXY(producto, cantidad);
            dr.Close();
            conexion.Close();
        }  
        private void CantidadDatos()
        {
            cmd = new SqlCommand("ContarCantidadRegistros", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter CantVentas = new SqlParameter("@TotalVentas", 0);
            CantVentas.Direction = ParameterDirection.Output;
            SqlParameter CantClientes = new SqlParameter("@CantidadClientes", 0);
            CantClientes.Direction = ParameterDirection.Output;
            SqlParameter Cantprouctos = new SqlParameter("@CantidadProductos", 0);
            Cantprouctos.Direction = ParameterDirection.Output;

            cmd.Parameters.Add(CantVentas);
            cmd.Parameters.Add(CantClientes);
            cmd.Parameters.Add(Cantprouctos);

            conexion.Open();
            cmd.ExecuteNonQuery();

            TotalVentas.Text = "$" + cmd.Parameters["@TotalVentas"].Value.ToString();
            cantClientes.Text = cmd.Parameters["@CantidadClientes"].Value.ToString();
            cantProductos.Text = cmd.Parameters["@CantidadProductos"].Value.ToString();
            conexion.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro que deseas salir del sistema?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
