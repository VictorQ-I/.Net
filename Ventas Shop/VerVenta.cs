using DocumentFormat.OpenXml.Spreadsheet;
using SpreadsheetLight.Drawing;
using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas_Shop
{
    public partial class VerVenta : Form
    {
        EditarVenta Editar_Ventas = new EditarVenta();
        public SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-VUJNIAL\\SQLEXPRESS; database=CONSULTA; integrated security = True; MultipleActiveResultSets=true");
        public VerVenta()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void RealizarVenta_Load(object sender, EventArgs e)
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
        private void button7_Click(object sender, EventArgs e)
        {
            int? Id = GetId();

            if (Id != null)
            {
                if (MessageBox.Show("¿Estas seguro que deseas eliminar la venta?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    BDFACTURATableAdapters.MostrarVentaTableAdapter ta = new BDFACTURATableAdapters.MostrarVentaTableAdapter();
                    ta.AnularVenta((int)Id);
                    refrescar();
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
        private void FechaHoy_Click_1(object sender, EventArgs e)
        {
            DateTime fecha = Convert.ToDateTime(DateTime.UtcNow.ToString("dd-MM-yyyy"));
            BDFACTURATableAdapters.MostrarVentaTableAdapter ta = new BDFACTURATableAdapters.MostrarVentaTableAdapter();
            BDFACTURA.MostrarVentaDataTable dt = ta.BuscarVentaFecha(Convert.ToDateTime(fecha), Convert.ToDateTime(fecha));
            dataGridView1.DataSource = dt;
        }
        private void FechaPersonalizada_Click(object sender, EventArgs e)
        {
            BDFACTURATableAdapters.MostrarVentaTableAdapter ta = new BDFACTURATableAdapters.MostrarVentaTableAdapter();
            BDFACTURA.MostrarVentaDataTable dt = ta.BuscarVentaFecha(Convert.ToDateTime(PikerFechaInicio.Text), Convert.ToDateTime(PikerFechaFin.Text));
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
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                this.Hide();
                Home ventas = new Home();
                ventas.ShowDialog();
                Close();
            }
        }
        private void EditarVenta_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No hay ventas registradas","Editar venta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                if (dataGridView1.CurrentRow == null)
                {
                    MessageBox.Show("Debe seleccionar una venta para editar", "Editar venta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                    Editar_Ventas.IdVenta.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    Editar_Ventas.txtcliente.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    Editar_Ventas.txtTotal.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                    this.Hide();                    
                }
                Editar_Ventas.ShowDialog();
            }            
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
                pic.SetPosition(0, 1);
                pic.ResizeInPixels(90, 100);
                DocumentoExcel.InsertPicture(pic);

                //Se le agregar un titulo al rreporte de excel y se le da un estilo
                DocumentoExcel.SetCellValue("D3", "Reporte de ventas");
                SLStyle estiloTitulo = DocumentoExcel.CreateStyle();
                estiloTitulo.Font.FontName = "Arial";
                estiloTitulo.Font.FontSize = 14;
                estiloTitulo.Font.Bold = true;
                DocumentoExcel.SetCellStyle("D3", estiloTitulo);
                DocumentoExcel.MergeWorksheetCells("D3", "E3");

                //Se crea la tabla especificando el nombre a las columnas
                int CeldaCabecera = 7, CeldaInicial = 7;
                DocumentoExcel.RenameWorksheet(SLDocument.DefaultFirstSheetName, "Ventas");
                DocumentoExcel.SetCellValue("B" + CeldaCabecera, "CÓDIGO");
                DocumentoExcel.SetCellValue("C" + CeldaCabecera, "CLIENTE");
                DocumentoExcel.SetCellValue("D" + CeldaCabecera, "FECHA DE VENTA");
                DocumentoExcel.SetCellValue("E" + CeldaCabecera, "TOTAL");
                DocumentoExcel.SetCellValue("F" + CeldaCabecera, "ESTADO");
                DocumentoExcel.SetCellValue("G" + CeldaCabecera, "USUARIO");

                //Creamos un estilo para la cabecera del cuadro
                SLStyle EstiloCabecera = DocumentoExcel.CreateStyle();
                EstiloCabecera.Font.FontName = "Arial";
                EstiloCabecera.Font.FontSize = 11;
                EstiloCabecera.Font.Bold = true;
                //Le damos color a la letra y fila cabecera de la tabla
                EstiloCabecera.Font.FontColor = System.Drawing.Color.White;
                EstiloCabecera.Fill.SetPattern(PatternValues.Solid, System.Drawing.Color.DarkCyan, System.Drawing.Color.DarkCyan);
                DocumentoExcel.SetCellStyle("B" + CeldaCabecera, "G" + CeldaCabecera, EstiloCabecera);

                //Se crea la copnexion a la BD y se hace la consulta
                string cadena = "select v.IdVenta, concat(r.Nombre,' ',r.Apellido) as Nombre, v.Fecha_Venta, v.Total, v.Estado, u.Nombre as Usuario from Venta v INNER JOIN Registro r on v.IdCliente = r.IdRegistro inner join Usuario u on v.IdUsuario = u.IdUsuario";
                conexion.Open();
                SqlCommand comando = new SqlCommand(cadena, conexion);
                SqlDataReader reader = comando.ExecuteReader();

                //Se muestra los registros que hay en la BD en la tabla de excel
                while (reader.Read())
                {
                    CeldaCabecera++;
                    DocumentoExcel.SetCellValue("B" + CeldaCabecera, reader["IdVenta"].ToString());
                    DocumentoExcel.SetCellValue("C" + CeldaCabecera, reader["Nombre"].ToString());
                    DocumentoExcel.SetCellValue("D" + CeldaCabecera, reader["Fecha_Venta"].ToString());
                    DocumentoExcel.SetCellValue("E" + CeldaCabecera, reader["Total"].ToString());
                    DocumentoExcel.SetCellValue("F" + CeldaCabecera, reader["Estado"].ToString());
                    DocumentoExcel.SetCellValue("G" + CeldaCabecera, reader["Usuario"].ToString());
                }
                conexion.Close();

                //Agregamos borde a todas las celdas, dando formato a la tabla con color y estilo
                SLStyle EstiloBorde = DocumentoExcel.CreateStyle();
                EstiloBorde.Border.LeftBorder.BorderStyle = BorderStyleValues.Thin;
                EstiloBorde.Border.LeftBorder.Color = System.Drawing.Color.Black;
                EstiloBorde.Border.TopBorder.BorderStyle = BorderStyleValues.Thin;
                EstiloBorde.Border.RightBorder.BorderStyle = BorderStyleValues.Thin;
                EstiloBorde.Border.BottomBorder.BorderStyle = BorderStyleValues.Thin;
                DocumentoExcel.SetCellStyle("B" + CeldaInicial, "G" + CeldaCabecera, EstiloBorde);

                //Poner autotamaño a cada celda de las columnas segun el largo del texto de cada celda
                DocumentoExcel.AutoFitColumn("B", "G");

                //Se le da formato y estilo a los registros númericos
                SLStyle EstiloNumero = DocumentoExcel.CreateStyle();
                EstiloNumero.FormatCode = "#,##0.00";
                DocumentoExcel.SetCellStyle("B" + CeldaInicial, "G" + CeldaCabecera, EstiloNumero);

                //Se especifica la ruta donde se desea guardar el archivo excel y al final en nombre de como se desea que se guarde
                DocumentoExcel.SaveAs("C:/Users/victo/Downloads/Ventas.xlsx");
                MessageBox.Show("Descarga éxitosa", "Descargar información");
            }
            catch (Exception ex)
            {
                MessageBox.Show("'" + ex.Message + "'", "Error al descargar información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void Imprimir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count != 0)
                {
                    MostrarFactura mostrar = new MostrarFactura();
                    mostrar.IdVenta1 = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IdVenta"].Value.ToString());
                    mostrar.ShowDialog();
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
    }
}
