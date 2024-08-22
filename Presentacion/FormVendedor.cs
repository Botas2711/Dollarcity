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
    public partial class FormVendedor : Form
    {
        private NVendedor nVendedor = new NVendedor();
        public FormVendedor()
        {
            InitializeComponent();
            MostrarVendedores(nVendedor.ListarTodoFisico());
        }
        private void MostrarVendedores(List<Vendedor> vendedores)
        {
            dgVendedores.DataSource = null;
            if (vendedores.Count == 0)
            {
                return;
            }
            else
            {
                dgVendedores.DataSource = vendedores;
            }
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text == "" || tbApellido.Text == "" || tbCorreo.Text == "" || tbNombreUsuario.Text == "" || tbContrasenia.Text == "")
            {
                MessageBox.Show("Ingrese los campos requeridos");
                return;
            }
            Vendedor vendedor = new Vendedor();
            vendedor.Nombre = tbNombre.Text;
            vendedor.Apellido = tbApellido.Text;
            vendedor.CorreoElectronico = tbCorreo.Text;
            vendedor.NombreUsuario = tbNombreUsuario.Text;
            vendedor.Contrasenia = tbContrasenia.Text;
            vendedor.UsuarioCreadorId = NVendedor.VendedorLogueado.idVendedor;
            vendedor.FechaCreacion = DateTime.Now;
            vendedor.UsuarioModificacdorId = NVendedor.VendedorLogueado.idVendedor;
            vendedor.FechaModificacion = DateTime.Now;

            int registrado = nVendedor.Registrar(vendedor);
            if (registrado == -2)
            {
                MessageBox.Show("Nombre de usuario repetido!");
                return;
            }

            if (registrado == -1)
            {
                MessageBox.Show("Se produjo un error");
                return;
            }

            if (registrado > 0)
            {
                MessageBox.Show("Registrado correctamente");
            }

            MostrarVendedores(nVendedor.ListarTodoFisico());
        }

        private void btnEliminarFisico_Click(object sender, EventArgs e)
        {
            if (dgVendedores.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un vendedor");
                return;
            }
            int idVendedor = int.Parse(dgVendedores.SelectedRows[0].Cells[0].Value.ToString());
            String mensaje = nVendedor.EliminarFisico(idVendedor);
            MessageBox.Show(mensaje);

            MostrarVendedores(nVendedor.ListarTodoFisico());
        }

        private void btnEliminarLogico_Click(object sender, EventArgs e)
        {
            if (dgVendedores.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un vendedor");
                return;
            }
            int idVendedor = int.Parse(dgVendedores.SelectedRows[0].Cells[0].Value.ToString());
            String mensaje = nVendedor.EliminarLogico(idVendedor);
            MessageBox.Show(mensaje);

            MostrarVendedores(nVendedor.ListarTodoFisico());
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgVendedores.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un vendedor");
                return;
            }
            int idVendedor = int.Parse(dgVendedores.SelectedRows[0].Cells[0].Value.ToString());

            if (tbNombre.Text == "" || tbApellido.Text == "" || tbCorreo.Text == "" || tbNombreUsuario.Text == "" || tbContrasenia.Text == "")
            {
                MessageBox.Show("Ingrese los campos requeridos");
                return;
            }

            Vendedor vendedor = new Vendedor();
            vendedor.idVendedor = idVendedor;
            vendedor.Nombre = tbNombre.Text;
            vendedor.Apellido = tbApellido.Text;
            vendedor.CorreoElectronico = tbCorreo.Text;
            vendedor.NombreUsuario = tbNombreUsuario.Text;
            vendedor.Contrasenia = tbContrasenia.Text;
            vendedor.UsuarioModificacdorId = NVendedor.VendedorLogueado.idVendedor;
            vendedor.FechaModificacion = DateTime.Now;

            int registrado = nVendedor.Modificar(vendedor);
            if (registrado == -2)
            {
                MessageBox.Show("Nombre de usuario repetido!");
                return;
            }

            if (registrado == -1)
            {
                MessageBox.Show("Se produjo un error");
                return;
            }

            if (registrado > 0)
            {
                MessageBox.Show("Modificado correctamente");
            }

            MostrarVendedores(nVendedor.ListarTodoFisico());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgVendedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbNombre.Text = dgVendedores.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
            tbApellido.Text = dgVendedores.Rows[e.RowIndex].Cells["Apellido"].Value.ToString();
            tbCorreo.Text = dgVendedores.Rows[e.RowIndex].Cells["CorreoElectronico"].Value.ToString();
            tbNombreUsuario.Text = dgVendedores.Rows[e.RowIndex].Cells["NombreUsuario"].Value.ToString();
            tbContrasenia.Text = dgVendedores.Rows[e.RowIndex].Cells["Contrasenia"].Value.ToString();
        }

    }
}
