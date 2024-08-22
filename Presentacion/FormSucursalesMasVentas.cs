using Negocio;
using Datos.Clases;
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
    public partial class FormSucursalesMasVentas : Form
    {
        private FormReporte form;
        private NSucursal nSucursal = new NSucursal();
        public FormSucursalesMasVentas(FormReporte form)
        {
            InitializeComponent();
            this.form = form;
            MostrarSucursalesConMasVentas(nSucursal.ListarSucursalesConMasVentas());
        }
        private void MostrarSucursalesConMasVentas(List<CSucursalVenta> sucursales)
        {
            dgSucursales.DataSource = null;
            if (sucursales.Count == 0)
            {
                return;
            }
            else
            {
                dgSucursales.DataSource = sucursales;
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
