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
    public partial class Home : Form
    {
        static int Indixe, ContarFila = 0, TotalVenta = 0, TotalVentaProducto = 0, total = 0;
        static SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-VUJNIAL\\SQLEXPRESS; database=CONSULTA; integrated security = True; MultipleActiveResultSets=true");
        public Home()
        {
            InitializeComponent();
        }
        private void RegistroFacturas_Load(object sender, EventArgs e)
        {
            CargarIdVenta();
            Acceso();
        }
        public void Acceso()
        {
            if (TipoUsuario.Text == "Usuario")
            {
                ToolConfiguracion.Visible = false;
                ToolVentas.Visible = false;
            }
            else
            {
                ToolUsuarios.Visible = true;
                ToolVentas.Visible = true;
            }
        }
        private void CargarIdVenta()
        {

            string cadena = "SELECT IDENT_CURRENT('Venta') + 1 as IDNuevo";
            conexion.Open();
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader reader = comando.ExecuteReader();

            if (reader.Read())
            {
                IdVenta.Text = reader["IDNuevo"].ToString();
            }
            conexion.Close();
        }
        private void LimpiarDetalleProducto()
        {
            TxtCodigo.Text = string.Empty;
            TxtProducto.Text = string.Empty;
            TxtCantidad.Text = string.Empty;
            TxtCantidad.Text = string.Empty;
            TxtPrecio.Text = string.Empty;
            txtTotal.Text = string.Empty;
            CargarIdVenta();
        }
        private void LimpiarDetalleCliente()
        {
            txtcliente.Text = "";
            IdVenta.Text = "";
            codCliente.Text = "";
        }
        private void HoraFecha_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToLongTimeString();
            lblfecha.Text = DateTime.Now.ToShortDateString();
        }
        private void registrarClienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RegistroClientes Registro_Cliente = new RegistroClientes();
            Registro_Cliente.Show();
        }
        private void registrarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroProductos Registro_Productos = new RegistroProductos();
            Registro_Productos.Show();
        }
        private void Salir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro que deseas salir del sistema?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void BuscarCliente_Click(object sender, EventArgs e)
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
        private void BuscarProducto_Click(object sender, EventArgs e)
        {
            BtnAgregarProducto.Enabled = true;
            ListarProductos Listar_Productos = new ListarProductos();
            Listar_Productos.ShowDialog();

            try
            {
                if (Listar_Productos.DialogResult == DialogResult.OK)
                {
                    TxtCodigo.Text = Listar_Productos.dataGridView1.Rows[Listar_Productos.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                    TxtProducto.Text = Listar_Productos.dataGridView1.Rows[Listar_Productos.dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                    TxtStock.Text = Listar_Productos.dataGridView1.Rows[Listar_Productos.dataGridView1.CurrentRow.Index].Cells[4].Value.ToString();
                    TxtPrecio.Text = Listar_Productos.dataGridView1.Rows[Listar_Productos.dataGridView1.CurrentRow.Index].Cells[5].Value.ToString();
                    TxtCantidad.Text = "1";
                    Mensaje_Stock_Agotado();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debes de seleccionar un producto", "Seleccionar producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void AgregarProducto_Click(object sender, EventArgs e)
        {
            AgregarProducto();
        }
        private void AgregarProducto()
        {
            try
            {
                if (Convert.ToInt32(TxtCodigo.Text) == 0)
                {
                    MessageBox.Show("No hay existencia de este producto", "Agregar producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                    if (TxtCodigo.Text == string.Empty || TxtProducto.Text == string.Empty || TxtCantidad.Text == string.Empty || TxtPrecio.Text == string.Empty)
                    {
                        MessageBox.Show("Debes de completar todos los campos del producto", "Agregar producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        bool Encontrado = false;
                        int NoFila = 0;

                        if (ContarFila == 0)
                        {
                            TotalVentaProducto = Convert.ToInt32(TxtCantidad.Text) * Convert.ToInt32(TxtPrecio.Text);

                            dataGridView1.Rows.Add(TxtCodigo.Text, TxtProducto.Text, TxtCantidad.Text, TxtPrecio.Text, TotalVentaProducto);
                            dataGridView1.ClearSelection();
                            LimpiarDetalleProducto();
                            BuscarProducto.Focus();
                            ContarFila++;
                        }
                        else
                        {

                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                if (row.Cells[0].Value.ToString() == TxtCodigo.Text)
                                {
                                    Encontrado = true;
                                }
                            }

                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                if (row.Cells[1].Value.ToString() == TxtProducto.Text)
                                {
                                    // Actualizar la cantidad y el total del producto existente
                                    row.Cells[2].Value = Convert.ToInt32(row.Cells[2].Value) + Convert.ToInt32(TxtCantidad.Text);
                                    row.Cells[4].Value = Convert.ToInt32(row.Cells[2].Value) * Convert.ToDecimal(row.Cells[3].Value);
                                    Encontrado = true;
                                    LimpiarDetalleProducto();
                                    break;
                                }
                            }

                            // Si el producto no está agregado, agregar un nuevo registro
                            if (!Encontrado)
                            {
                                TotalVentaProducto = Convert.ToInt32(TxtCantidad.Text) * Convert.ToInt32(TxtPrecio.Text);

                                dataGridView1.Rows.Add(TxtCodigo.Text, TxtProducto.Text, TxtCantidad.Text, TxtPrecio.Text, TotalVentaProducto);
                                dataGridView1.ClearSelection();
                                LimpiarDetalleProducto();
                                BuscarProducto.Focus();
                                ContarFila++;
                            }
                        }

                        TotalVenta = 0;

                        foreach (DataGridViewRow row1 in dataGridView1.Rows)
                        {
                            TotalVenta += Convert.ToInt32(row1.Cells[4].Value);
                        }
                        txtTotal.Text = Convert.ToString(TotalVenta);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + "'" + ex.Message + "'", "Agregar producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Mensaje_Stock_Agotado()
        {
            try
            {
                int Stock = Convert.ToInt32(TxtStock.Text);
                if (Stock == 1)
                {
                    MessageBox.Show("Este es el ultimo producto existente", "Agregar producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (Stock <= 0)
                {
                    MessageBox.Show("Este producto no hay en bodega", "Agregar producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("'" + ex.Message + "'", "Agregar producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void LblSalir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0)
            {
                if (MessageBox.Show("¿Estas seguro que deseas salir del sistema?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    return;
                }
            }
            else if (MessageBox.Show("¡Tiene una venta en proceso!\n\n¿Deseas seguir con la venta?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                return;
            }
            else
            {
                Application.Exit();
            }
            // Nombre, cc, dirección y telefono
        }
        private void vENTASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                VerVenta Registro_Ventas = new VerVenta();
                Registro_Ventas.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("'" + ex.Message + "'", "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void GuardarVenta_Click(object sender, EventArgs e)
        {
            String estado = "Emitido";
            DateTime fecha = Convert.ToDateTime(DateTime.UtcNow.ToString("dd-MM-yyyy"));
            BDFACTURATableAdapters.DataTable1TableAdapter ta = new BDFACTURATableAdapters.DataTable1TableAdapter();

            try
            {
                if (txtcliente.Text == string.Empty)
                {
                    MessageBox.Show("Debes de completar todos los campos requeridos", "Realizar venta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    ta.AgregarVenta(Convert.ToInt32(codCliente.Text), Convert.ToInt32(IdUsuario.Text), fecha, Convert.ToInt32(txtTotal.Text), estado);

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        ta.AgregarDetalleVenta(Convert.ToInt32(IdVenta.Text),
                                                Convert.ToInt32(row.Cells[0].Value.ToString()),
                                                Convert.ToInt32(codCliente.Text),
                                                Convert.ToString(row.Cells[1].Value.ToString()),
                                                Convert.ToInt32(row.Cells[2].Value.ToString()),
                                                Convert.ToInt32(row.Cells[3].Value.ToString()),
                                                Convert.ToInt32(row.Cells[4].Value.ToString()));
                    }

                    MessageBox.Show("Venta relizada con éxito", "Realizar venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarDetalleCliente();
                    LimpiarDetalleProducto();
                    this.dataGridView1.Rows.Clear();
                    CargarIdVenta();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + "'" + ex.Message + "'", "Guardar venta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void EliminarProducto_Click_1(object sender, EventArgs e)
        {
			try
			{
				if (ContarFila > 0)
				{
					total = total - Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);

					dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
					ContarFila--;

					BtnAgregarProducto.Enabled = true;
					LimpiarDetalleProducto();
				}

				TotalVenta = 0;

				foreach (DataGridViewRow row1 in dataGridView1.Rows)
				{
					TotalVenta += Convert.ToInt32(row1.Cells[4].Value);
				}
				txtTotal.Text = Convert.ToString(TotalVenta);
			}
			catch (Exception ex)
			{
				MessageBox.Show("No hay productos para eliminar", "Eliminar venta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}
        private void EditarProducto_Click(object sender, EventArgs e)
        {
			try
			{
				if (TxtCodigo.Text == string.Empty || TxtProducto.Text == string.Empty || TxtCantidad.Text == string.Empty || TxtPrecio.Text == string.Empty)
				{
					MessageBox.Show("No hay productos seleccionados", "Editar venta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
				else
				{
					int total = 0;

					total = Convert.ToInt32(TxtCantidad.Text) * Convert.ToInt32(TxtPrecio.Text);

					dataGridView1[0, Indixe].Value = TxtCodigo.Text;
					dataGridView1[1, Indixe].Value = TxtProducto.Text;
					dataGridView1[2, Indixe].Value = TxtCantidad.Text;
					dataGridView1[3, Indixe].Value = TxtPrecio.Text;
					dataGridView1[4, Indixe].Value = total;

					LimpiarDetalleProducto();
					BtnAgregarProducto.Enabled = true;
				}
				TotalVenta = 0;

				foreach (DataGridViewRow row1 in dataGridView1.Rows)
				{
					TotalVenta += Convert.ToInt32(row1.Cells[4].Value);
				}
				txtTotal.Text = Convert.ToString(TotalVenta);
			}
			catch (Exception ex)
			{
				MessageBox.Show("'" + ex.Message + "'", "Editar venta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); ;
			}
		}
        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroCategorias categorias = new RegistroCategorias();
            categorias.ShowDialog();
        }
        private void fACTURCIÓNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarFacturas listarFactura = new ListarFacturas();
            listarFactura.ShowDialog();
        }

        private void CancelarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.RowCount == 0)
                {
                    return;

                }
                else if (MessageBox.Show("¿Estas seguro que deseas cancelar la venta?", "Cancelar venta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    this.dataGridView1.Rows.Clear();
                    LimpiarDetalleProducto();
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("'" + ex.Message + "'", "Cancelar venta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
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
                        Indixe = dataGridView1.CurrentRow.Index;

                        TxtCodigo.Text = dataGridView1[0, Indixe].Value.ToString();
                        TxtProducto.Text = dataGridView1[1, Indixe].Value.ToString();
                        TxtCantidad.Text = dataGridView1[2, Indixe].Value.ToString();
                        TxtPrecio.Text = dataGridView1[3, Indixe].Value.ToString();

                        BtnAgregarProducto.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("'" + ex.Message + "'", "Editar venta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); ;
            }
        }
        private void eSTADISTICASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estadisticas estadisticas = new Estadisticas();
            estadisticas.Show();
        }
        private void crerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }
        private void uSUARIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Usuarios usuarios = new Usuarios();
                usuarios.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("'" + ex.Message + "'", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
