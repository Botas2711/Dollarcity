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
    public partial class FormPrincipal : Form
    {
        private FormInicioSesion form;
        public FormPrincipal(FormInicioSesion form)
        {
            InitializeComponent();
            this.form = form;
        }
       
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            form.Show();
        }
        private void btnVerReportes_Click(object sender, EventArgs e)
        {
            FormReporte form = new FormReporte();
            form.Show();
        }

        private void btnVerVendedores_Click_1(object sender, EventArgs e)
        {
            FormVendedor form = new FormVendedor();
            form.Show();
        }

        private void btnVerSucursales_Click(object sender, EventArgs e)
        {
            FormSucursal form = new FormSucursal();
            form.Show();
        }

        private void btnVerCategorias_Click(object sender, EventArgs e)
        {
            FormCategoria form = new FormCategoria();
            form.Show();
        }

        private void btnVerProductos_Click(object sender, EventArgs e)
        {
            FormProducto form = new FormProducto();
            form.Show();
        }

        private void btnVerBoletas_Click(object sender, EventArgs e)
        {
            FormBoleta form = new FormBoleta();
            form.Show();
        }

        private void btnVerInventarios_Click(object sender, EventArgs e)
        {
            FormInventario form = new FormInventario();
            form.Show();
        }
    }
}
