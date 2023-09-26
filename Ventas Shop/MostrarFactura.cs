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
    public partial class MostrarFactura : Form
    {
        public MostrarFactura()
        {
            InitializeComponent();
        }

        private int IdVenta;

        public int IdVenta1 { get => IdVenta; set => IdVenta = value; }

        private void MostrarFactura_Load(object sender, EventArgs e)
        {
            this.mostrar_FacturaTableAdapter.Fill(this.bDFACTURA.Mostrar_Factura, IdVenta1);
            this.reportViewer1.RefreshReport();
        }
    }
}
