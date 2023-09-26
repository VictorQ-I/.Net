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
    public partial class RegistroCategorias : Form
    {
        public RegistroCategorias()
        {
            InitializeComponent();
        }
        private void RegistroCategorias_Load(object sender, EventArgs e)
        {
            refrescar();

            dataGridView1.Columns[0].HeaderText = "CÓDIGO";
            dataGridView1.Columns[1].HeaderText = "CATEGORIA";
        }
        private void refrescar()
        {
            BDFACTURATableAdapters.Mostrar_CategoriasTableAdapter ta = new BDFACTURATableAdapters.Mostrar_CategoriasTableAdapter();
            BDFACTURA.Mostrar_CategoriasDataTable dt = ta.Mostrar_Categoria();
            dataGridView1.DataSource = dt;
        }
        private void buscar_Click(object sender, EventArgs e)
        {
            buscar.Text = "";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Salir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro que deseas salir del sistema?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (categoria.Text == String.Empty)
                {
                    MessageBox.Show("Debes de completar todos los campos requeridos", "Registrar categorías", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    BDFACTURATableAdapters.DataTable2TableAdapter ta = new BDFACTURATableAdapters.DataTable2TableAdapter();
                    ta.Agregar_Categoria(categoria.Text);

                    refrescar();

                    categoria.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("'" + ex.Message + "'", "Guardar Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private int? GetId()
        {
            try
            {
                //Se selecciiona la fila segun el ID que se especifique
                return int.Parse(
                    dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString()
                    );
            }
            catch
            {
                return null;
            }
        }
        private void Editar_Click(object sender, EventArgs e)
        {
            int? Id = GetId();
            int IdCategoria = 0;

            if (Id != null)
            {
                BDFACTURATableAdapters.DataTable2TableAdapter ta = new BDFACTURATableAdapters.DataTable2TableAdapter();
                ta.Editar_Categoria((int)Id, categoria.Text);

                refrescar();

                categoria.Text = "";
            }
        }
        private void Eliminar_Click(object sender, EventArgs e)
        {
            int? Id = GetId();

            if (Id != null)
            {
                if (MessageBox.Show("¿Estas seguro que deseas eliminar el productos?", "Eliminar Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    BDFACTURATableAdapters.DataTable2TableAdapter ta = new BDFACTURATableAdapters.DataTable2TableAdapter();
                    ta.Eliminar_Categoria((int)Id);

                    refrescar();

                    categoria.Text = "";
                }
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            categoria.Text = dataGridView1.SelectedCells[1].Value.ToString();
        }
        private void buscar_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"CATEGORIA LIKE '{buscar.Text}%'";
        }
        private void Cancelar_Click(object sender, EventArgs e)
        {
            categoria.Text = "";
        }
    }
}
