using System;
using Datos.Clases;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Datos;

namespace Presentacion
{
    public partial class FormProductosMasVendidos : Form
    {
        private FormReporte form;
        private NProducto nProducto = new NProducto();
        private NSucursal nSucursal = new NSucursal();
        public FormProductosMasVendidos(FormReporte form)
        {
            InitializeComponent();
            this.form = form;
            MostrarSucursales(nSucursal.ListarTodoLogico());
        }
        private void MostrarProductoVendidos(List<CProductoVendido> cProductoVendidos)
        {
            dgProductos.DataSource = null;
            if (cProductoVendidos.Count == 0)
            {
                return;
            }
            else
            {
                dgProductos.DataSource = cProductoVendidos;
            }
        }
        private void MostrarSucursales(List<Sucursal> sucursales)
        {
            cbSucursal.DataSource = null;
            if (sucursales.Count == 0)
            {
                return;
            }
            else
            {
                cbSucursal.DataSource = sucursales;
                cbSucursal.ValueMember = "idSucursal";
                cbSucursal.DisplayMember = "Nombre";
            }
        }
        private void btnListar_Click(object sender, EventArgs e)
        {
            if (cbSucursal.Text == "")
            {
                MessageBox.Show("Ingrese los campos requeridos");
                return;
            }
            int idSucursal = int.Parse(cbSucursal.SelectedValue.ToString());
            MostrarProductoVendidos(nProducto.ListarProductoMasVendidos(idSucursal));
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
