using Datos;
using Negocio;
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
    public partial class FormVentasVendedor : Form
    {
        private NBoleta nBoleta = new NBoleta();
        private NVendedor nVendedor = new NVendedor();
        private FormReporte form;
        public FormVentasVendedor(FormReporte form)
        {
            InitializeComponent();
            this.form = form;
        }
        private void MostrarBoletas(List<Boleta> boletas)
        {
            dgVentas.DataSource = null;
            if (boletas.Count == 0)
            {
                return;
            }
            else
            {
                dgVentas.DataSource = boletas;
            }
        }
        private void btnListarVentas_Click(object sender, EventArgs e)
        {
            if (tbNombreUsuario.Text == "")
            {
                MessageBox.Show("Ingrese los campos requeridos");
                return;
            }
            String nombreUsuario = tbNombreUsuario.Text.Trim();
            Vendedor vendedor = nVendedor.ObtenerVendedorPorNombreUsuario(nombreUsuario);
            if (vendedor == null)
            {
                MessageBox.Show("No se encontro al vendedor");
                return;
            }
            MostrarBoletas(nBoleta.ListarPorVendedor(vendedor));
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            form.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
