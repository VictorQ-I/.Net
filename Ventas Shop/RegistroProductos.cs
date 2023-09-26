using DocumentFormat.OpenXml.Spreadsheet;
using SpreadsheetLight.Drawing;
using SpreadsheetLight;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml.Office.CustomUI;
using DocumentFormat.OpenXml.Office2010.CustomUI;

namespace Ventas_Shop
{
    public partial class RegistroProductos : Form
    {
        private SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-VUJNIAL\\SQLEXPRESS; database=CONSULTA; integrated security = True; MultipleActiveResultSets=true");
        public RegistroProductos()
        {
            InitializeComponent();
        }
        private void RegistroProductos_Load(object sender, EventArgs e)
        {
            refrescar();
            Llenar_Categoria();

            dataGridView1.Columns[0].HeaderText = "CÓDIGO";
            dataGridView1.Columns[1].HeaderText = "PRODUCTO";
            dataGridView1.Columns[2].HeaderText = "COD CATEGORÍA";
            dataGridView1.Columns[3].HeaderText = "CATEGORÍA";
            dataGridView1.Columns[4].HeaderText = "STOCK";
            dataGridView1.Columns[5].HeaderText = "PRECIO";

            dataGridView1.Columns[2].Visible = false;
        }
        private void LimpiarCampos()
        {
            nombre.Text = "";
            stock.Text = "";
            precio.Text = "";
            Categoria.Text = "Seleccione una opción";
            IdCategoria.Text = "";
        }
        private void refrescar()
        {
            BDFACTURATableAdapters.Mostrar_ProductosTableAdapter ta = new BDFACTURATableAdapters.Mostrar_ProductosTableAdapter();
            BDFACTURA.Mostrar_ProductosDataTable dt = ta.MostrarProductos();
            dataGridView1.DataSource = dt;
        }
        private void Llenar_Categoria()
        {
            try
            {

                BDFACTURATableAdapters.Mostrar_CategoriasTableAdapter ta = new BDFACTURATableAdapters.Mostrar_CategoriasTableAdapter();
                BDFACTURA.Mostrar_CategoriasDataTable dt = ta.Mostrar_Categoria();

                Categoria.DataSource = dt;
                Categoria.DisplayMember = "Categoria";
                Categoria.ValueMember = "IdCategoria";

                Categoria.AutoCompleteMode = AutoCompleteMode.Suggest;
                Categoria.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
            catch (Exception ex)
            {
                MessageBox.Show("'" + ex.Message + "'", "Cargar productos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        private void Categoria_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                String query = ("SELECT IdCategoria FROM Categoria WHERE IdCategoria = @IdCategoria");
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@IdCategoria", Categoria.SelectedValue);
                SqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    IdCategoria.Text = reader["IdCategoria"].ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el ID " + "'" + ex.Message + "'", "Guardar Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            conexion.Close();
        }
        private void Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (nombre.Text == String.Empty || stock.Text == String.Empty || precio.Text == String.Empty)
                {
                    MessageBox.Show("Debes de completar todos los campos requeridos", "Registrar producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (IdCategoria.Text == String.Empty)
                {
                    MessageBox.Show("Debes de de seleccionar una categoría", "Registrar producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    BDFACTURATableAdapters.DataTable2TableAdapter ta = new BDFACTURATableAdapters.DataTable2TableAdapter();
                    ta.Agregar(Convert.ToInt32(IdCategoria.Text), nombre.Text, Convert.ToInt32(stock.Text), Convert.ToInt32(precio.Text));

                    Llenar_Categoria();
                    refrescar();

                    LimpiarCampos();
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
        private void button8_Click(object sender, EventArgs e)
        {
            int? Id = GetId();

            if (Id != null)
            {
                BDFACTURATableAdapters.DataTable2TableAdapter ta = new BDFACTURATableAdapters.DataTable2TableAdapter();
                ta.Editar((int)Id, Convert.ToInt32(IdCategoria.Text), nombre.Text.Trim(), Convert.ToInt32(stock.Text), Convert.ToInt32(precio.Text));

                Llenar_Categoria();
                refrescar();

                LimpiarCampos();
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            int? Id = GetId();

            if (Id != null)
            {
                if (MessageBox.Show("¿Estas seguro que deseas eliminar el productos?", "Eliminar Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    BDFACTURATableAdapters.DataTable2TableAdapter ta = new BDFACTURATableAdapters.DataTable2TableAdapter();
                    ta.Eliminar((int)Id);

                    Llenar_Categoria();
                    refrescar();

                    LimpiarCampos();
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro que deseas salir del sistema?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            refrescar();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            nombre.Text = dataGridView1.SelectedCells[1].Value.ToString();
            IdCategoria.Text = dataGridView1.SelectedCells[2].Value.ToString();
            Categoria.Text = dataGridView1.SelectedCells[3].Value.ToString();
            stock.Text = dataGridView1.SelectedCells[4].Value.ToString();
            precio.Text = dataGridView1.SelectedCells[5].Value.ToString();
        }
        private void buscar_TextChanged_1(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"NOMBRE_PRODUCTO LIKE '{buscar.Text}%'";
        }
        private void buscar_Click(object sender, EventArgs e)
        {
            buscar.Text = String.Empty;
        }
        private void DescargarInfo_Click(object sender, EventArgs e)
        {
            try
            {
                //Inicializamos el documento excel donde se va a guardar todo lo se desea
                SLDocument DocumentoExcel = new SLDocument();

                //Inicializamos la instancia para ponerle un logotipo al excel
                System.Drawing.Bitmap imagen = new System.Drawing.Bitmap("C:/Users/victo/Documents/Ventas Shop/IMG/LogoExcel.png");
                //Se convierte la imagen a bytes para poer mostrarla en el excel y se guardar en un arregle tipo Byte
                byte[] bytes;

                using (System.IO.MemoryStream convertir = new System.IO.MemoryStream())
                {
                    imagen.Save(convertir, System.Drawing.Imaging.ImageFormat.Png);
                    convertir.Close();
                    bytes = convertir.ToArray();
                }

                //Enviamos la convercion de la imagen a SLPicture, dandole la posición y tamaño
                SLPicture pic = new SLPicture(bytes, DocumentFormat.OpenXml.Packaging.ImagePartType.Png);
                pic.SetPosition(0, 0);
                pic.ResizeInPixels(90, 100);
                DocumentoExcel.InsertPicture(pic);

                //Se le agregar un titulo al rreporte de excel y se le da un estilo
                DocumentoExcel.SetCellValue("C3", "Reporte de productos");
                SLStyle estiloTitulo = DocumentoExcel.CreateStyle();
                estiloTitulo.Font.FontName = "Arial";
                estiloTitulo.Font.FontSize = 14;
                estiloTitulo.Font.Bold = true;
                DocumentoExcel.SetCellStyle("C3", estiloTitulo);
                DocumentoExcel.MergeWorksheetCells("C3", "D3");

                //Se crea la tabla especificando el nombre a las columnas
                int CeldaCabecera = 7, CeldaInicial = 7;
                DocumentoExcel.RenameWorksheet(SLDocument.DefaultFirstSheetName, "Prodcutos");
                DocumentoExcel.SetCellValue("B" + CeldaCabecera, "CÓDIGO");
                DocumentoExcel.SetCellValue("C" + CeldaCabecera, "PRODUCTO");
                DocumentoExcel.SetCellValue("D" + CeldaCabecera, "CATEGORÍA");
                DocumentoExcel.SetCellValue("E" + CeldaCabecera, "STOCK");
                DocumentoExcel.SetCellValue("F" + CeldaCabecera, "PRECIO");

                //Creamos un estilo para la cabecera del cuadro
                SLStyle EstiloCabecera = DocumentoExcel.CreateStyle();
                EstiloCabecera.Font.FontName = "Arial";
                EstiloCabecera.Font.FontSize = 11;
                EstiloCabecera.Font.Bold = true;
                //Le damos color a la letra y fila cabecera de la tabla
                EstiloCabecera.Font.FontColor = System.Drawing.Color.White;
                EstiloCabecera.Fill.SetPattern(PatternValues.Solid, System.Drawing.Color.DarkCyan, System.Drawing.Color.DarkCyan);
                DocumentoExcel.SetCellStyle("B" + CeldaCabecera, "F" + CeldaCabecera, EstiloCabecera);

                //Se crea la copnexion a la BD y se hace la consulta
                string cadena = "select p.IdProductos, p.Nombre_Producto, c.Categoria, p.Stock, p.Precio " +
                    "from Productos p " +
                    "inner join Categoria c on p.IdCategoria = c.IdCategoria";

                conexion.Open();
                SqlCommand comando = new SqlCommand(cadena, conexion);
                SqlDataReader reader = comando.ExecuteReader();

                //Se muestra los registros que hay en la BD en la tabla de excel
                while (reader.Read())
                {
                    CeldaCabecera++;
                    DocumentoExcel.SetCellValue("B" + CeldaCabecera, reader["IdProductos"].ToString());
                    DocumentoExcel.SetCellValue("C" + CeldaCabecera, reader["Nombre_Producto"].ToString());
                    DocumentoExcel.SetCellValue("D" + CeldaCabecera, reader["Categoria"].ToString());
                    DocumentoExcel.SetCellValue("E" + CeldaCabecera, reader["Stock"].ToString());
                    DocumentoExcel.SetCellValue("F" + CeldaCabecera, reader["Precio"].ToString());
                }
                conexion.Close();

                //Agregamos borde a todas las celdas, dando formato a la tabla con color y estilo
                SLStyle EstiloBorde = DocumentoExcel.CreateStyle();
                EstiloBorde.Border.LeftBorder.BorderStyle = BorderStyleValues.Thin;
                EstiloBorde.Border.LeftBorder.Color = System.Drawing.Color.Black;
                EstiloBorde.Border.TopBorder.BorderStyle = BorderStyleValues.Thin;
                EstiloBorde.Border.RightBorder.BorderStyle = BorderStyleValues.Thin;
                EstiloBorde.Border.BottomBorder.BorderStyle = BorderStyleValues.Thin;
                DocumentoExcel.SetCellStyle("B" + CeldaInicial, "F" + CeldaCabecera, EstiloBorde);

                //Poner autotamaño a cada celda de las columnas segun el largo del texto de cada celda
                DocumentoExcel.AutoFitColumn("B", "E");

                //Se le da formato y estilo a los registros númericos
                SLStyle EstiloNumero = DocumentoExcel.CreateStyle();
                EstiloNumero.FormatCode = "#,##0.00";
                DocumentoExcel.SetCellStyle("B" + CeldaInicial, "F" + CeldaCabecera, EstiloNumero);

                //Se especifica la ruta donde se desea guardar el archivo excel y al final en nombre de como se desea que se guarde
                DocumentoExcel.SaveAs("C:/Users/victo/Downloads/Productos.xlsx");
                MessageBox.Show("Descarga éxitosa", "Descargar información");
            }
            catch (Exception ex)
            {
                MessageBox.Show("'" + ex.Message + "'", "Error al descargar información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
