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
    public partial class FormSucursal : Form
    {
        NSucursal nSucursal = new NSucursal();
        public FormSucursal()
        {
            InitializeComponent();
            MostrarSucursales(nSucursal.ListarTodoFisico());

        }
        private void MostrarSucursales(List<Sucursal> sucursales)
        {
            dgSucursales.DataSource = null;
            if (sucursales.Count == 0)
            {
                return;
            }
            else
            {
                dgSucursales.DataSource = sucursales;
                dgSucursales.Columns["Boleta"].Visible = false;
                dgSucursales.Columns["Inventario"].Visible = false;
            }
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text.Trim() == "" || tbDistrito.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese los campos requeridos");
                return;
            }

            Sucursal sucursal = new Sucursal();
            sucursal.Nombre = tbNombre.Text.Trim();
            sucursal.Distrito = tbDistrito.Text.Trim();
            sucursal.Eliminado = false;
            sucursal.UsuarioCreadorId = NVendedor.VendedorLogueado.idVendedor;
            sucursal.FechaCreacion = DateTime.Now;
            sucursal.UsuarioModificacdorId = NVendedor.VendedorLogueado.idVendedor;
            sucursal.FechaModificacion = DateTime.Now;

            int registrado = nSucursal.Registrar(sucursal);
            if (registrado == -2)
            {
                MessageBox.Show("Nombre de la sucursal repetido!");
                return;
            }

            if (registrado == -1)
            {
                MessageBox.Show("Se produjo un error");
                return;
            }

            if(registrado > 0)
            {
                MessageBox.Show("Registrado correctamente");
            }

            MostrarSucursales(nSucursal.ListarTodoFisico());
        }

        private void btnEliminarFisico_Click(object sender, EventArgs e)
        {
            if (dgSucursales.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un sucursal");
                return;
            }
            int sucursalId = int.Parse(dgSucursales.SelectedRows[0].Cells[0].Value.ToString());
            String mensaje = nSucursal.EliminarFisico(sucursalId);
            MessageBox.Show(mensaje);

            MostrarSucursales(nSucursal.ListarTodoFisico());
        }

        private void btnEliminarLogico_Click(object sender, EventArgs e)
        {
            if (dgSucursales.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un sucursal");
                return;
            }
            int sucursalId = int.Parse(dgSucursales.SelectedRows[0].Cells[0].Value.ToString());
            String mensaje = nSucursal.EliminarLogico(sucursalId);
            MessageBox.Show(mensaje);

            MostrarSucursales(nSucursal.ListarTodoFisico());
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgSucursales.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un sucursal");
                return;
            }
            int sucursalId = int.Parse(dgSucursales.SelectedRows[0].Cells[0].Value.ToString());

            if (tbNombre.Text.Trim() == "" || tbDistrito.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese los campos requeridos");
                return;
            }

            Sucursal sucursal = new Sucursal();
            sucursal.idSucursal = sucursalId;
            sucursal.Nombre = tbNombre.Text.Trim();
            sucursal.Distrito = tbDistrito.Text.Trim();
            sucursal.Eliminado = false;
            sucursal.UsuarioModificacdorId = NVendedor.VendedorLogueado.idVendedor;
            sucursal.FechaModificacion = DateTime.Now;

            int registrado = nSucursal.Modificar(sucursal);
            if (registrado == -2)
            {
                MessageBox.Show("Nombre de la sucursal repetido!");
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

            MostrarSucursales(nSucursal.ListarTodoFisico());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgSucursales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbNombre.Text = dgSucursales.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
            tbDistrito.Text = dgSucursales.Rows[e.RowIndex].Cells["Distrito"].Value.ToString();
        }
    }
}
