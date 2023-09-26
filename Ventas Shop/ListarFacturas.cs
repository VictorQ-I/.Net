using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas_Shop
{
    public partial class ListarFacturas : Form
    {
        private int IdVenta;
        public int IdVenta1 { get => IdVenta; set => IdVenta = value; }
        public ListarFacturas()
        {
            InitializeComponent();
            MostraFactura.Visible = false;
        }
        private void ListarFacturas_Load(object sender, EventArgs e)
        {          
            refrescar();

            dataGridView1.Columns[0].HeaderText = "CÓDIGO";
            dataGridView1.Columns[1].HeaderText = "CLIENTE";
            dataGridView1.Columns[2].HeaderText = "FECHA";
            dataGridView1.Columns[3].HeaderText = "TOTAL";
            dataGridView1.Columns[4].HeaderText = "ESTADO";
            dataGridView1.Columns[5].HeaderText = "CAJERO/A";
        }
        private void refrescar()
        {
            BDFACTURATableAdapters.MostrarVentaTableAdapter ta = new BDFACTURATableAdapters.MostrarVentaTableAdapter();
            BDFACTURA.MostrarVentaDataTable dt = ta.GetData();
            dataGridView1.DataSource = dt;
        }
        private void FechaPersonalizada_Click(object sender, EventArgs e)
        {
            BDFACTURATableAdapters.MostrarVentaTableAdapter ta = new BDFACTURATableAdapters.MostrarVentaTableAdapter();
            BDFACTURA.MostrarVentaDataTable dt = ta.BuscarVentaFecha(Convert.ToDateTime(PikerFechaInicio.Text), Convert.ToDateTime(PikerFechaFin.Text));
            dataGridView1.DataSource = dt;
        }
        private void FiltrarDia_Click(object sender, EventArgs e)
        {
            DateTime fecha = Convert.ToDateTime(DateTime.UtcNow.ToString("dd-MM-yyyy"));
            BDFACTURATableAdapters.MostrarVentaTableAdapter ta = new BDFACTURATableAdapters.MostrarVentaTableAdapter();
            BDFACTURA.MostrarVentaDataTable dt = ta.BuscarVentaFecha(Convert.ToDateTime(fecha), Convert.ToDateTime(fecha));
            dataGridView1.DataSource = dt;
        }
        private void FechaSemana_Click(object sender, EventArgs e)
        {
            BDFACTURATableAdapters.MostrarVentaTableAdapter ta = new BDFACTURATableAdapters.MostrarVentaTableAdapter();
            BDFACTURA.MostrarVentaDataTable dt = ta.BuscarVentaSemana();
            dataGridView1.DataSource = dt;
        }
        private void FechaMes_Click(object sender, EventArgs e)
        {
            BDFACTURATableAdapters.MostrarVentaTableAdapter ta = new BDFACTURATableAdapters.MostrarVentaTableAdapter();
            BDFACTURA.MostrarVentaDataTable dt = ta.BuscarVentaMes();
            dataGridView1.DataSource = dt;
        }
        private void FechaAño_Click(object sender, EventArgs e)
        {
            BDFACTURATableAdapters.MostrarVentaTableAdapter ta = new BDFACTURATableAdapters.MostrarVentaTableAdapter();
            BDFACTURA.MostrarVentaDataTable dt = ta.BuscarVentaMesActual();
            dataGridView1.DataSource = dt;
        }
        private void CargarTiempo()
        {
            Thread.Sleep(2000);
        }
        private async void imprimir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count != 0)
                {
                    MostrarLoading loading = new MostrarLoading();
                    loading.Show();
                    Task tarea = new Task(CargarTiempo);
                    tarea.Start();                    
                    await tarea;
                    loading.Hide();

                    MostraFactura.Visible = true;
                    IdVenta1 = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IdVenta"].Value.ToString());

                    this.mostrar_FacturaTableAdapter.Fill(this.bDFACTURA.Mostrar_Factura, IdVenta1);
                    this.MostraFactura.RefreshReport();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una venta", "Mostrar venta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("'" + ex.Message + "'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }            
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
        private async void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count != 0)
                {
                    MostrarLoading loading = new MostrarLoading();
                    loading.Show();
                    Task tarea = new Task(CargarTiempo);
                    tarea.Start();
                    await tarea;
                    loading.Hide();

                    MostraFactura.Visible = true;
                    IdVenta1 = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IdVenta"].Value.ToString());

                    this.mostrar_FacturaTableAdapter.Fill(this.bDFACTURA.Mostrar_Factura, IdVenta1);
                    this.MostraFactura.RefreshReport();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una venta", "Mostrar venta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("'" + ex.Message + "'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void FiltrarPorNombre_Click(object sender, EventArgs e)
        {
            FiltrarPorNombre.Text = String.Empty;
        }

        private void FiltrarPorNombre_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"NOMBRE LIKE '{FiltrarPorNombre.Text}%'";
        }
    }
}
