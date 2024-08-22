using Datos;
using Datos.Clases;
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
    public partial class FormCategoriasMasVendidas : Form
    {
        private FormReporte form;
        private NSucursal nSucursal = new NSucursal();
        private NProducto nProducto = new NProducto();
        public FormCategoriasMasVendidas(FormReporte form)
        {
            InitializeComponent();
            this.form = form;
            MostrarSucursales(nSucursal.ListarTodoLogico());
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
        private void MostrarCategoriasVendidas(List<CCategoriaVendida> cCategoriaVendidas)
        {
            dgCategorias.DataSource = null;
            if (cCategoriaVendidas.Count == 0)
            {
                return;
            }
            else
            {
                dgCategorias.DataSource = cCategoriaVendidas;
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
            MostrarCategoriasVendidas(nProducto.ListarCategoriasMasVendidas(idSucursal));
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
