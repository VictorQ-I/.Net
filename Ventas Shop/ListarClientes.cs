using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas_Shop
{
    public partial class ListarClientes : Form
    {
        public ListarClientes()
        {
            InitializeComponent();
        }
        private void ListarClientes_Load(object sender, EventArgs e)
        {
            Listar();

            dataGridView1.Columns[0].HeaderText = "CÓDIGO";
            dataGridView1.Columns[1].HeaderText = "NOMBRE";
        }
        private void Listar()
        {
            BDFACTURATableAdapters.Registro1TableAdapter ta = new BDFACTURATableAdapters.Registro1TableAdapter();
            BDFACTURA.Registro1DataTable dt = ta.ListarClientes();
            dataGridView1.DataSource = dt;
        }
        private void Agregar_Click(object sender, EventArgs e)
        {
            RegistroClientes Registro_Clientes = new RegistroClientes();
            Registro_Clientes.ShowDialog();
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
        private void buscar_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"NOMBRE LIKE '{buscar.Text}%'";
        }
        private void buscar_Click(object sender, EventArgs e)
        {
            buscar.Text = String.Empty;
        }
    }
}
