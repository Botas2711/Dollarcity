using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormReporte : Form
    {
        public FormReporte()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVerSucursalesConMasVentas_Click(object sender, EventArgs e)
        {
            FormSucursalesMasVentas form = new FormSucursalesMasVentas(this);
            form.Show();
        }

        private void btnVerProductosMasVendidos_Click(object sender, EventArgs e)
        {
            FormProductosMasVendidos form = new FormProductosMasVendidos(this);
            form.Show();
        }

        private void btnVerCategoriasMasVendidas_Click(object sender, EventArgs e)
        {
            FormCategoriasMasVendidas form = new FormCategoriasMasVendidas(this);
            form.Show();
        }

        private void btnVerProductosMenosStock_Click(object sender, EventArgs e)
        {
            FormProductosMenosStock form = new FormProductosMenosStock(this);
            form.Show();
        }

        private void btnVerVentasdeVendedor_Click(object sender, EventArgs e)
        {
            FormVentasVendedor form = new FormVentasVendedor(this);
            form.Show();
        }
    }
}
