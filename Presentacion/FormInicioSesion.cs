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
    public partial class FormInicioSesion : Form
    {
        private NVendedor nVendedor = new NVendedor();
        public FormInicioSesion()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string nombreUsuario = tbNombreUsuario.Text.Trim();
            string contrasenia = tbContrasenia.Text.Trim();

            Vendedor vendedorTemp = nVendedor.IniciarSesion(nombreUsuario, contrasenia);

            if (vendedorTemp == null)
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrecto");
                return;
            }
            else
            {
                this.Hide();
                FormPrincipal form = new FormPrincipal(this);
                form.Show();
            }
        }
    }
}
