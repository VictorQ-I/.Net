using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas_Shop
{
    public partial class Factura_Generada : Form
    {
        public Factura_Generada()
        {
            InitializeComponent();
        }

        private void Factura_Generada_Load(object sender, EventArgs e)
        {
            fecha.Enabled = false;
            numfactura.Enabled = false;
            cliente.Enabled = false;
            correo.Enabled = false;
            telefono.Enabled = false;
            producto.Enabled = false;
            cantidad.Enabled = false;
            precio.Enabled = false;
            subtotal.Enabled = false;
            iva.Text = "$0";
            iva.Enabled = false;
            total.Enabled = false;
        }

        private void telefono_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistroFacturas Registro_Facturas = new RegistroFacturas();
            Registro_Facturas.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            printDocument1 = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            printDocument1.PrinterSettings = ps;
            printDocument1.PrintPage += Imprimir;
            printDocument1.Print();
        }

        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            e.Graphics.Equals(groupBox1);
        }

    }
}
