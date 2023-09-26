using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas_Shop
{
    public partial class ListarProductos : Form
    {
        Home Registro_Ventas = new Home();
        public ListarProductos()
        {
            InitializeComponent();
        }

        private void ListarProductos_Load(object sender, EventArgs e)
        {
            Listar();

            dataGridView1.Columns[0].HeaderText = "CÓDIGO";
            dataGridView1.Columns[1].HeaderText = "PRODUCTO";
            dataGridView1.Columns[2].HeaderText = "COD CATEGORÍA";
            dataGridView1.Columns[3].HeaderText = "CATEGORÍA";
            dataGridView1.Columns[4].HeaderText = "STOCK";
            dataGridView1.Columns[5].HeaderText = "PRECIO";

            dataGridView1.Columns[2].Visible = false;
        }
        private void Listar()
        {
            BDFACTURATableAdapters.Mostrar_ProductosTableAdapter ta = new BDFACTURATableAdapters.Mostrar_ProductosTableAdapter();
            BDFACTURA.Mostrar_ProductosDataTable dt = ta.MostrarProductos();
            dataGridView1.DataSource = dt;
        }
        private void Agregar_Click(object sender, EventArgs e)
        {
            RegistroProductos Registro_Productos = new RegistroProductos();
            Registro_Productos.ShowDialog();
            Listar();
        }
        private void dataGridView1_DoubleClick_1(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
        private void buscar_TextChanged_1(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Nombre_Producto LIKE '{buscar.Text}%'";
        }
        private void buscar_Click_1(object sender, EventArgs e)
        {
            buscar.Text = String.Empty;
        }
    }
}
