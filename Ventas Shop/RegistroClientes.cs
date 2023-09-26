using DocumentFormat.OpenXml.Drawing.Diagrams;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;
using SpreadsheetLight;
using SpreadsheetLight.Drawing;
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
    public partial class RegistroClientes : Form
    {
        public SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-VUJNIAL\\SQLEXPRESS; database=CONSULTA; integrated security = True; MultipleActiveResultSets=true");
        public RegistroClientes()
        {
            InitializeComponent();
        }
        private void RegistroClientes_Load(object sender, EventArgs e)
        {
            refrescar();
            CargarIdRegistro();
            CargarDepartamentos();
            CargarCiudades();

            dataGridView1.Columns[0].HeaderText = "CÓDIGO";
            dataGridView1.Columns[1].HeaderText = "NOMBRE";
            dataGridView1.Columns[2].HeaderText = "APELLIDO";
            dataGridView1.Columns[3].HeaderText = "CORREO";
            dataGridView1.Columns[4].HeaderText = "TELÉFONO";
            dataGridView1.Columns[5].HeaderText = "DIRECCIÓN";
            dataGridView1.Columns[6].HeaderText = "DEPARTAMENTO";
            dataGridView1.Columns[7].HeaderText = "CIUDAD";
            dataGridView1.Columns[8].HeaderText = "CÓDIGO POSTAL";
            dataGridView1.Columns[9].HeaderText = "COD DEPARTAMENTO";
            dataGridView1.Columns[10].HeaderText = "COD CIUDAD";

            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        private void refrescar()
        {
            BDFACTURATableAdapters.Mostrar_Registro_ClienteTableAdapter ta = new BDFACTURATableAdapters.Mostrar_Registro_ClienteTableAdapter();
            BDFACTURA.Mostrar_Registro_ClienteDataTable dt = ta.MostrarRegistroCliente();
            dataGridView1.DataSource = dt;
        }
        private void LimpiarCampos()
        {
            nombre.Text = "";
            apellido.Text = "";
            correo.Text = "";
            telefono.Text = "";
            txtDireccion.Text = "";
            txtDepartamento.Text = "Seleccione un departamento";
            txtCiudad.Text = "Seleccione una ciudad";
            txtCodigoPostal.Text = "";
            IdDepartamento.Text = "";
            IdCiudad.Text = "";
        }
        private void CargarIdRegistro()
        {

            string cadena = "SELECT IDENT_CURRENT('Registro') + 1 as IdRegistro";
            conexion.Open();
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader reader = comando.ExecuteReader();

            if (reader.Read())
            {
                IdRegistro.Text = reader["IdRegistro"].ToString();
            }
            conexion.Close();
        }
        private void Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                BDFACTURATableAdapters.RegistroTableAdapter ta = new BDFACTURATableAdapters.RegistroTableAdapter();
                ta.Agregar(nombre.Text, apellido.Text, correo.Text, telefono.Text);
                ta.AgregarDireccion(Convert.ToInt32(IdRegistro.Text), txtDireccion.Text, Convert.ToInt32(IdDepartamento.Text), Convert.ToInt32(IdCiudad.Text), txtCodigoPostal.Text);

                refrescar();
                LimpiarCampos();
                CargarIdRegistro();
            }
            catch (Exception ex)
            {
                MessageBox.Show("'" + ex.Message + "'", "Registrar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                BDFACTURATableAdapters.RegistroTableAdapter ta = new BDFACTURATableAdapters.RegistroTableAdapter();
                ta.Editar((int)Id, nombre.Text, apellido.Text, correo.Text, telefono.Text, txtDireccion.Text, Convert.ToInt32(IdDepartamento.Text), Convert.ToInt32(IdCiudad.Text), txtCodigoPostal.Text);
                refrescar();

                LimpiarCampos();
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            int? Id = GetId();

            if (Id != null)
            {
                if (MessageBox.Show("¿Estas seguro que deseas eliminar el cliente?", "Eliminar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    BDFACTURATableAdapters.RegistroTableAdapter ta = new BDFACTURATableAdapters.RegistroTableAdapter();
                    ta.Eliminar((int)Id);
                    refrescar();

                    LimpiarCampos();
                }                
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            refrescar();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro que deseas salir del sistema?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            nombre.Text = dataGridView1.SelectedCells[1].Value.ToString();
            apellido.Text = dataGridView1.SelectedCells[2].Value.ToString();
            correo.Text = dataGridView1.SelectedCells[3].Value.ToString();
            telefono.Text = dataGridView1.SelectedCells[4].Value.ToString();
            txtDireccion.Text = dataGridView1.SelectedCells[5].Value.ToString();
            txtDepartamento.Text = dataGridView1.SelectedCells[6].Value.ToString();
            txtCiudad.Text = dataGridView1.SelectedCells[7].Value.ToString();
            txtCodigoPostal.Text = dataGridView1.SelectedCells[8].Value.ToString();
            IdDepartamento.Text = dataGridView1.SelectedCells[9].Value.ToString();
            IdCiudad.Text = dataGridView1.SelectedCells[10].Value.ToString();
        }
        private void buscar_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"NOMBRE LIKE '{buscar.Text}%'";
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
                pic.SetPosition(0, 1);
                pic.ResizeInPixels(90, 100);
                DocumentoExcel.InsertPicture(pic);

                //Se le agregar un titulo al rreporte de excel y se le da un estilo
                DocumentoExcel.SetCellValue("F3", "Reporte de clientes");
                SLStyle estiloTitulo = DocumentoExcel.CreateStyle();
                estiloTitulo.Font.FontName = "Arial";
                estiloTitulo.Font.FontSize = 14;
                estiloTitulo.Font.Bold = true;
                DocumentoExcel.SetCellStyle("F3", estiloTitulo);
                DocumentoExcel.MergeWorksheetCells("F3", "G3");

                //Se crea la tabla especificando el nombre a las columnas
                int CeldaCabecera = 7, CeldaInicial = 7;
                DocumentoExcel.RenameWorksheet(SLDocument.DefaultFirstSheetName, "Clientes");
                DocumentoExcel.SetCellValue("B" + CeldaCabecera, "CÓDIGO");
                DocumentoExcel.SetCellValue("C" + CeldaCabecera, "NOMBRE");
                DocumentoExcel.SetCellValue("D" + CeldaCabecera, "APELLIDO");
                DocumentoExcel.SetCellValue("E" + CeldaCabecera, "CORREO");
                DocumentoExcel.SetCellValue("F" + CeldaCabecera, "TELÉFONO");
                DocumentoExcel.SetCellValue("G" + CeldaCabecera, "DIRECCIÓN");
                DocumentoExcel.SetCellValue("H" + CeldaCabecera, "DEPARTAMENTO");
                DocumentoExcel.SetCellValue("I" + CeldaCabecera, "CIUDAD");
                DocumentoExcel.SetCellValue("J" + CeldaCabecera, "CÓDIGO POSTAL");

                //Creamos un estilo para la cabecera del cuadro
                SLStyle EstiloCabecera = DocumentoExcel.CreateStyle();
                EstiloCabecera.Font.FontName = "Arial";
                EstiloCabecera.Font.FontSize = 11;
                EstiloCabecera.Font.Bold = true;
                //Le damos color a la letra y fila cabecera de la tabla
                EstiloCabecera.Font.FontColor = System.Drawing.Color.White;
                EstiloCabecera.Fill.SetPattern(PatternValues.Solid, System.Drawing.Color.DarkCyan, System.Drawing.Color.DarkCyan);
                DocumentoExcel.SetCellStyle("B" + CeldaCabecera, "J" + CeldaCabecera, EstiloCabecera);

                //Se crea la copnexion a la BD y se hace la consulta
                string cadena = "select d.IdRegistro, r.Nombre, r.Apellido, r.Correo, r.Telefono, d.Direccion, de.Departamento, c.Ciudad, d.CodigoPostal " +
                    "from Direccion d  " +
                    "inner join Registro r on d.IdRegistro = r.IdRegistro " +
                    "inner join Departamento de on d.IdDepartamento = de.IdDepartamento " +
                    "inner join Ciudad c on d.IdCiudad = c.IdCiudad";

                conexion.Open();
                SqlCommand comando = new SqlCommand(cadena, conexion);
                SqlDataReader reader = comando.ExecuteReader();

                //Se muestra los registros que hay en la BD en la tabla de excel
                while (reader.Read())
                {
                    CeldaCabecera++;
                    DocumentoExcel.SetCellValue("B" + CeldaCabecera, reader["IdRegistro"].ToString());
                    DocumentoExcel.SetCellValue("C" + CeldaCabecera, reader["Nombre"].ToString());
                    DocumentoExcel.SetCellValue("D" + CeldaCabecera, reader["Apellido"].ToString());
                    DocumentoExcel.SetCellValue("E" + CeldaCabecera, reader["Correo"].ToString());
                    DocumentoExcel.SetCellValue("F" + CeldaCabecera, reader["Telefono"].ToString());
                    DocumentoExcel.SetCellValue("G" + CeldaCabecera, reader["Direccion"].ToString());
                    DocumentoExcel.SetCellValue("H" + CeldaCabecera, reader["Departamento"].ToString());
                    DocumentoExcel.SetCellValue("I" + CeldaCabecera, reader["Ciudad"].ToString());
                    DocumentoExcel.SetCellValue("J" + CeldaCabecera, reader["CodigoPostal"].ToString());
                }
                conexion.Close();

                //Agregamos borde a todas las celdas, dando formato a la tabla con color y estilo
                SLStyle EstiloBorde = DocumentoExcel.CreateStyle();
                EstiloBorde.Border.LeftBorder.BorderStyle = BorderStyleValues.Thin;
                EstiloBorde.Border.LeftBorder.Color = System.Drawing.Color.Black;
                EstiloBorde.Border.TopBorder.BorderStyle = BorderStyleValues.Thin;
                EstiloBorde.Border.RightBorder.BorderStyle = BorderStyleValues.Thin;
                EstiloBorde.Border.BottomBorder.BorderStyle = BorderStyleValues.Thin;
                DocumentoExcel.SetCellStyle("B" + CeldaInicial, "J" + CeldaCabecera, EstiloBorde);

                //Poner autotamaño a cada celda de las columnas segun el largo del texto de cada celda
                DocumentoExcel.AutoFitColumn("B", "J");

                //Se le da formato y estilo a los registros númericos
                SLStyle EstiloNumero = DocumentoExcel.CreateStyle();
                EstiloNumero.FormatCode = "#,##0.00";
                DocumentoExcel.SetCellStyle("B" + CeldaInicial, "J" + CeldaCabecera, EstiloNumero);

                //Se especifica la ruta donde se desea guardar el archivo excel y al final en nombre de como se desea que se guarde
                DocumentoExcel.SaveAs("C:/Users/victo/Downloads/Clientes.xlsx");
                MessageBox.Show("Descarga éxitosa", "Descargar información");
            }
            catch(Exception ex)
            {
                MessageBox.Show("'" + ex.Message + "'", "Error al descargar información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }  
        }
        private void Cancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        private void CargarDepartamentos()
        {                                    
            try
            {
                BDFACTURATableAdapters.DepartamentoCiudadTableAdapter ta = new BDFACTURATableAdapters.DepartamentoCiudadTableAdapter();
                BDFACTURA.DepartamentoCiudadDataTable dt = ta.Mostrar_Departamento();

                txtDepartamento.DataSource = dt;
                txtDepartamento.DisplayMember = "Departamento";
                txtDepartamento.ValueMember = "IdDepartamento";

                txtDepartamento.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtDepartamento.AutoCompleteSource = AutoCompleteSource.ListItems;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los departamento" + ex.Message + "'", "Guardar cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void CargarCiudades()
        {
            try
            {
                if (IdDepartamento.Text.Equals(""))
                {
                    return;
                }
                else 
                {
                    BDFACTURATableAdapters.DepartamentoCiudadTableAdapter ta = new BDFACTURATableAdapters.DepartamentoCiudadTableAdapter();
                    BDFACTURA.DepartamentoCiudadDataTable dt = ta.Mostrar_Ciudad(Convert.ToInt32(IdDepartamento.Text));

                    txtCiudad.DataSource = dt;
                    txtCiudad.DisplayMember = "Ciudad";
                    txtCiudad.ValueMember = "IdCiudad";
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las ciudades" + "'" + ex.Message + "'", "Guardar cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            conexion.Close();
        }
        private void txtDepartamento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                String query = ("SELECT IdDepartamento FROM Departamento WHERE IdDepartamento = @IdDepartamento");
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@IdDepartamento", txtDepartamento.SelectedValue);
                SqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    IdDepartamento.Text = reader["IdDepartamento"].ToString();
                    CargarCiudades();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el IdDepartamento " + "'" + ex.Message + "'", "Guardar cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            conexion.Close();
        }
        private void txtCiudad_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                String query = ("SELECT * FROM Ciudad WHERE IdCiudad = @IdCiudad");
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@IdCiudad", txtCiudad.SelectedValue);
                SqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    IdCiudad.Text = reader["IdCiudad"].ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el ID de ciudad" + "'" + ex.Message + "'", "Guardar cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            conexion.Close();
        }
    }
}
