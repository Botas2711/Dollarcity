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
    public partial class FormInventario : Form
    {
        private NInventario nInventario = new NInventario();
        private NProductoInventario nProductoInventario = new NProductoInventario();
        private NSucursal nSucursal = new NSucursal();
        public FormInventario()
        {
            InitializeComponent();
            MostrarInventarios(nInventario.ListarTodoFisico());
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
        private void MostrarInventarios(List<Inventario> inventarios)
        {
            dgInventario.DataSource = null;
            if (inventarios.Count == 0)
            {
                return;
            }
            else
            {
                dgInventario.DataSource = inventarios;
                dgInventario.Columns["Sucursal"].Visible = false;
                dgInventario.Columns["ProductoInventario"].Visible = false;
            }
        }
        private void MostrarProductoInventario(List<ProductoInventario> productoInventarios)
        {
            dgProductoInventario.DataSource = null;
            if (productoInventarios.Count == 0)
            {
                return;
            }
            else
            {
                dgProductoInventario.DataSource = productoInventarios;
            }
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if(cbSucursal.Text == "")
            {
                MessageBox.Show("Ingrese los campos requeridos");
                return;
            }
            int idSucursal = int.Parse(cbSucursal.SelectedValue.ToString());

            Inventario inventario = new Inventario();
            inventario.StockTotal = 0;
            inventario.idSucursal = idSucursal;
            inventario.UsuarioCreadorId = NVendedor.VendedorLogueado.idVendedor;
            inventario.FechaCreacion = DateTime.Now;
            inventario.UsuarioModificadorId = NVendedor.VendedorLogueado.idVendedor;
            inventario.FechaModificacion = DateTime.Now;

            int existe = nInventario.SucursalConInventario(idSucursal);
            if(existe == 0)
            {
                MessageBox.Show("La sucursal ya posee un inventario");
                return;
            }
            else
            {
                int registrado = nInventario.Registrar(inventario);
                if (registrado == -1)
                {
                    MessageBox.Show("Se produjo un error");
                    return;
                }

                if (registrado > 0)
                {
                    MessageBox.Show("Registrado correctamente");
                }

                MostrarInventarios(nInventario.ListarTodoFisico());
            }

        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgInventario.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un inventario");
                return;
            }
            int inventarioId = int.Parse(dgInventario.SelectedRows[0].Cells[0].Value.ToString());
            String mensaje = nInventario.EliminarFisico(inventarioId);
            MessageBox.Show(mensaje);

            MostrarInventarios(nInventario.ListarTodoFisico());
        }

        private void dgInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgInventario.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione un inventario");
                    return;
                }
                int inventarioId = int.Parse(dgInventario.SelectedRows[0].Cells[0].Value.ToString());
                MostrarProductoInventario(nProductoInventario.ListarTodoFisico(inventarioId));
                Inventario inventario = nInventario.ObtenerInventario(inventarioId);
                int totalStock = nProductoInventario.CalcularStockTotal(inventario, inventarioId);
                lblStock.Text = inventario.StockTotal.ToString();
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (dgInventario.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un inventario");
                return;
            }
            int inventarioId = int.Parse(dgInventario.SelectedRows[0].Cells[0].Value.ToString());
            FormProductoInventario form = new FormProductoInventario(inventarioId);
            form.Show();
            this.Close();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
