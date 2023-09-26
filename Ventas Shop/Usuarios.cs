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

namespace Ventas_Shop
{
    public partial class Usuarios : Form
    {
        public SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-VUJNIAL\\SQLEXPRESS; database=CONSULTA; integrated security = True; MultipleActiveResultSets=true");
        public Usuarios()
        {
            InitializeComponent();
            contraseña.PasswordChar = '*';
            contraseña.MaxLength = 14;
        }
        private void Usuarios_Load(object sender, EventArgs e)
        {
            refrescar();

            dataGridView1.Columns[0].HeaderText = "CÓDIGO";
            dataGridView1.Columns[1].HeaderText = "NOMBRE";
            dataGridView1.Columns[2].HeaderText = "USUARIO";
            dataGridView1.Columns[3].HeaderText = "CONTRASEÑA";
            dataGridView1.Columns[4].HeaderText = "TIPO DE USUARIO";
        }
        private void refrescar()
        {
            BDFACTURATableAdapters.Mostrar_Cuenta_UsuarioTableAdapter ta = new BDFACTURATableAdapters.Mostrar_Cuenta_UsuarioTableAdapter();
            BDFACTURA.Mostrar_Cuenta_UsuarioDataTable dt = ta.Mostrar_Cuenta_Usuario();
            dataGridView1.DataSource = dt;
        }
        private void Salir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro que deseas salir del sistema?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void buscar_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"NOMBRE LIKE '{buscar.Text}%'";
        }
        private void volver_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Guardar_Click(object sender, EventArgs e)
        {
            BDFACTURATableAdapters.Mostrar_Cuenta_UsuarioTableAdapter ta = new BDFACTURATableAdapters.Mostrar_Cuenta_UsuarioTableAdapter();
            ta.Crear_Cuenta_Usuario(nombre.Text, usuario.Text, contraseña.Text, TipoUsuario.Text);
            refrescar();

            nombre.Text = "";
            usuario.Text = "";
            contraseña.Text = "";
            TipoUsuario.Text = "";
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
                DocumentoExcel.SetCellValue("C3", "Reporte de usuarios");
                SLStyle estiloTitulo = DocumentoExcel.CreateStyle();
                estiloTitulo.Font.FontName = "Arial";
                estiloTitulo.Font.FontSize = 14;
                estiloTitulo.Font.Bold = true;
                DocumentoExcel.SetCellStyle("C3", estiloTitulo);
                DocumentoExcel.MergeWorksheetCells("C3", "D3");

                //Se crea la tabla especificando el nombre a las columnas
                int CeldaCabecera = 7, CeldaInicial = 7;
                DocumentoExcel.RenameWorksheet(SLDocument.DefaultFirstSheetName, "Usuarios");
                DocumentoExcel.SetCellValue("B" + CeldaCabecera, "CÓDIGO");
                DocumentoExcel.SetCellValue("C" + CeldaCabecera, "NOMBRE");
                DocumentoExcel.SetCellValue("D" + CeldaCabecera, "USUARIO");
                DocumentoExcel.SetCellValue("E" + CeldaCabecera, "CONTRASEÑA");
                DocumentoExcel.SetCellValue("F" + CeldaCabecera, "TIPO DE USUARIO");

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
                string cadena = "select * from Usuario";
                conexion.Open();
                SqlCommand comando = new SqlCommand(cadena, conexion);
                SqlDataReader reader = comando.ExecuteReader();

                //Se muestra los registros que hay en la BD en la tabla de excel
                while (reader.Read())
                {
                    CeldaCabecera++;
                    DocumentoExcel.SetCellValue("B" + CeldaCabecera, reader["IdUsuario"].ToString());
                    DocumentoExcel.SetCellValue("C" + CeldaCabecera, reader["Nombre"].ToString());
                    DocumentoExcel.SetCellValue("D" + CeldaCabecera, reader["Usuario"].ToString());
                    DocumentoExcel.SetCellValue("E" + CeldaCabecera, reader["Contraseña"].ToString());
                    DocumentoExcel.SetCellValue("F" + CeldaCabecera, reader["TipoUsuario"].ToString());
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
                DocumentoExcel.AutoFitColumn("B", "F");

                //Se le da formato y estilo a los registros númericos
                SLStyle EstiloNumero = DocumentoExcel.CreateStyle();
                EstiloNumero.FormatCode = "#,##0.00";
                DocumentoExcel.SetCellStyle("B" + CeldaInicial, "F" + CeldaCabecera, EstiloNumero);

                //Se especifica la ruta donde se desea guardar el archivo excel y al final en nombre de como se desea que se guarde
                DocumentoExcel.SaveAs("C:/Users/victo/Downloads/Usuarios.xlsx");
                MessageBox.Show("Descarga éxitosa", "Descargar información");
            }
            catch (Exception ex)
            {
                MessageBox.Show("'" + ex.Message + "'", "Error al descargar información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            if (Id != null)
            {
                BDFACTURATableAdapters.Mostrar_Cuenta_UsuarioTableAdapter ta = new BDFACTURATableAdapters.Mostrar_Cuenta_UsuarioTableAdapter();
                ta.Editar_Cuenta_Usuario((int)Id, nombre.Text, usuario.Text, contraseña.Text, TipoUsuario.Text);
                refrescar();

                nombre.Text = "";
                usuario.Text = "";
                contraseña.Text = "";
                TipoUsuario.Text = "";
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            nombre.Text = dataGridView1.SelectedCells[1].Value.ToString();
            usuario.Text = dataGridView1.SelectedCells[2].Value.ToString();
            contraseña.Text = dataGridView1.SelectedCells[3].Value.ToString();
            TipoUsuario.Text = dataGridView1.SelectedCells[4].Value.ToString();
        }
        private void Eliminar_Click(object sender, EventArgs e)
        {
            int? Id = GetId();

            if (Id != null)
            {
                if (MessageBox.Show("¿Estas seguro que deseas eliminar el usuario?", "Eliminar usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    BDFACTURATableAdapters.Mostrar_Cuenta_UsuarioTableAdapter ta = new BDFACTURATableAdapters.Mostrar_Cuenta_UsuarioTableAdapter();
                    ta.Eliminar_Cuenta_Usuario((int)Id);
                    refrescar();

                    nombre.Text = "";
                    usuario.Text = "";
                    contraseña.Text = "";
                    TipoUsuario.Text = "";
                }
            }
        }
        private void buscar_Click(object sender, EventArgs e)
        {
            buscar.Text = String.Empty;
        }
        private void Cancelar_Click(object sender, EventArgs e)
        {
            nombre.Text = "";
            usuario.Text = "";
            contraseña.Text = "";
            TipoUsuario.Text = "";
        }
    }
}
