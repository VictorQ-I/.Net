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
    public partial class EditarVenta : Form
    {
        public static int TotalInicio = 0;
        public static int ContarFila = 0, TotalVenta = 0, TotalVentaProducto = 0, Total = 0;
        public EditarVenta()
        {
            InitializeComponent();
        }
        private void EditarVenta_Load(object sender, EventArgs e)
        {
            MostrarDetalleVenta();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }
        private void LimpiarDetalleProducto()
        {
            codigo.Text = string.Empty;
            producto.Text = string.Empty;
            txtcantidad.Text = string.Empty;
            txtcantidad.Text = string.Empty;
            precio.Text = string.Empty;
        }
        private void LimpiarDetalleCliente()
        {
            txtcliente.Text = "";
            IdVenta.Text = "";
            codCliente.Text = "";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            VerVenta ver_Venta = new VerVenta();
            ver_Venta.ShowDialog();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro que deseas salir del sistema?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            ListarProductos Listar_Productos = new ListarProductos();
            Listar_Productos.ShowDialog();

            try
            {
                if (Listar_Productos.DialogResult == DialogResult.OK)
                {
                    codigo.Text = Listar_Productos.dataGridView1.Rows[Listar_Productos.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                    producto.Text = Listar_Productos.dataGridView1.Rows[Listar_Productos.dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                    precio.Text = Listar_Productos.dataGridView1.Rows[Listar_Productos.dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debes de seleccionar un producto", "Seleccionar producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            ListarClientes listarClientes = new ListarClientes();
            listarClientes.ShowDialog();

            try
            {
                if (listarClientes.DialogResult == DialogResult.OK)
                {
                    txtcliente.Text = listarClientes.dataGridView1.Rows[listarClientes.dataGridView1.CurrentRow.Index].Cells[1].Value.ToString() + " " +
                        listarClientes.dataGridView1.Rows[listarClientes.dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
                    codCliente.Text = listarClientes.dataGridView1.Rows[listarClientes.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debes de seleccionar un cliente", "Seleccionar cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void GuardarVenta_Click(object sender, EventArgs e)
        {

        }
        private void EditarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("No hay productos registrados", "Editar venta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                    if (dataGridView1.CurrentRow == null)
                    {
                        MessageBox.Show("Debes de seleccionar un producto", "Editar venta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    else
                    {
                        codigo.Text = dataGridView1.SelectedCells[0].Value.ToString();
                        producto.Text = dataGridView1.SelectedCells[1].Value.ToString();
                        txtcantidad.Text = dataGridView1.SelectedCells[2].Value.ToString();
                        precio.Text = dataGridView1.SelectedCells[3].Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("'" + ex.Message + "'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); ;
            }
        }
        private void EliminarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (ContarFila > 0)
                {
                    Total = Total - Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);

                    dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                    ContarFila--;
                }

                TotalVenta = 0;
                foreach (DataGridViewRow row1 in dataGridView1.Rows)
                {
                    TotalVenta += Convert.ToInt32(row1.Cells[4].Value);
                }
                txtTotal.Text = TotalVenta.ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay productos para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("No hay productos registrados", "Editar venta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                    if (dataGridView1.CurrentRow == null)
                    {
                        MessageBox.Show("Debes de seleccionar un producto", "Editar venta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    else
                    {
                        codigo.Text = dataGridView1.SelectedCells[0].Value.ToString();
                        producto.Text = dataGridView1.SelectedCells[1].Value.ToString();
                        txtcantidad.Text = dataGridView1.SelectedCells[2].Value.ToString();
                        precio.Text = dataGridView1.SelectedCells[3].Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("'" + ex.Message + "'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); ;
            }
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            AgregarProducto();
        }
        private void AgregarProducto()
        {
            try
            {
                if (Convert.ToInt32(codigo.Text) == 0)
                {
                    MessageBox.Show("No hay existencia de este producto", "Agregar producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                    if (codigo.Text == string.Empty || producto.Text == string.Empty || txtcantidad.Text == string.Empty || precio.Text == string.Empty)
                    {
                        MessageBox.Show("Debes de completar todos los campos del producto", "Agregar producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        bool Existe = false;
                        int NoFila = 0;

                        if (ContarFila == 0)
                        {
                            TotalVentaProducto = Convert.ToInt32(txtcantidad.Text) * Convert.ToInt32(precio.Text);

                            dataGridView1.Rows.Add(codigo.Text, producto.Text, txtcantidad.Text, precio.Text, TotalVentaProducto);
                            dataGridView1.ClearSelection();
                            LimpiarDetalleProducto();
                            button5.Focus();
                            ContarFila++;
                        }
                        else
                        {
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                if (row.Cells[0].Value.ToString() == codigo.Text)
                                {
                                    Existe = true;
                                }
                            }

                            if (Existe == true)
                            {
                                dataGridView1.Rows[NoFila].Cells[2].Value = Convert.ToInt32(txtcantidad.Text) + Convert.ToInt32(dataGridView1.Rows[NoFila].Cells[2].Value);
                                dataGridView1.Rows[NoFila].Cells[4].Value = (Convert.ToInt32(dataGridView1.Rows[NoFila].Cells[2].Value) * Convert.ToInt32(dataGridView1.Rows[NoFila].Cells[3].Value));
                                LimpiarDetalleProducto();
                            }
                            else
                            {
                                TotalVentaProducto = Convert.ToInt32(txtcantidad.Text) * Convert.ToInt32(precio.Text);

                                dataGridView1.Rows.Add(codigo.Text, producto.Text, txtcantidad.Text, precio.Text, TotalVentaProducto);
                                dataGridView1.ClearSelection();
                                LimpiarDetalleProducto();
                                button5.Focus();
                                ContarFila++;
                            }
                        }

                        TotalVenta = 0;

                        foreach (DataGridViewRow row1 in dataGridView1.Rows)
                        {
                            TotalVenta += Convert.ToInt32(row1.Cells[4].Value);
                        }
                        txtTotal.Text = TotalVenta.ToString("N2");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + "'" + ex.Message + "'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void MostrarDetalleVenta()
        {
            BDFACTURATableAdapters.MostrarDetalleventaTableAdapter ta = new BDFACTURATableAdapters.MostrarDetalleventaTableAdapter();
            BDFACTURA.MostrarDetalleventaDataTable dt = ta.MostrarDetalleVenta(Convert.ToInt32(IdVenta.Text));
            dataGridView1.DataSource = dt;
        }
    }
}
