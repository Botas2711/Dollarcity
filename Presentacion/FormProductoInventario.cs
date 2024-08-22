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
    public partial class FormProductoInventario : Form
    {
        private NInventario nInventario = new NInventario();
        private NProductoInventario nProductoInventario = new NProductoInventario();
        private NProducto nProducto = new NProducto();
        private int inventarioId;

        public FormProductoInventario(int inventarioId)
        {
            InitializeComponent();
            this.inventarioId = inventarioId;
            MostrarProductos(nProducto.ListarTodoLogico());
            MostrarProductoInventario(nProductoInventario.ListarTodoFisico(this.inventarioId));
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
                lblStock.Text = nProductoInventario.CalcularStockTotal(nInventario.ObtenerInventario(inventarioId), this.inventarioId).ToString();
                dgProductoInventario.Columns["Inventario"].Visible = false;
                dgProductoInventario.Columns["Producto"].Visible = false;
            }
        }
        private void MostrarProductos(List<Producto> productos)
        {
            cbProducto.DataSource = null;
            if (productos.Count == 0)
            {
                return;
            }
            else
            {
                cbProducto.DataSource = productos;
                cbProducto.ValueMember = "idProducto";
                cbProducto.DisplayMember = "Nombre";
            }
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (tbStock.Text == "" || cbProducto.Text == "")
            {
                MessageBox.Show("Ingrese los campos requeridos");
                return;
            }
            int idProducto = int.Parse(cbProducto.SelectedValue.ToString());

            int stock = 0;
            try
            {
                stock = int.Parse(tbStock.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingrese los campos numericos correctamente");
                return;
            }

            if (stock < 1)
            {
                MessageBox.Show("El stock debe ser positivo");
                return;
            }

            ProductoInventario productoInventario = new ProductoInventario();
            productoInventario.idProducto = idProducto;
            productoInventario.idInventario = this.inventarioId;
            productoInventario.Stock = stock;
            productoInventario.UsuarioCreadorId = NVendedor.VendedorLogueado.idVendedor;
            productoInventario.FechaCreacion = DateTime.Now;
            productoInventario.UsuarioModificadorId = NVendedor.VendedorLogueado.idVendedor;
            productoInventario.FechaModificacion = DateTime.Now;
      
            Producto producto = nProducto.ObtenerProductoPorId(idProducto);

            int existe = nProductoInventario.ProductoConInventario(idProducto, this.inventarioId);
            if (existe == 0)
            {
                MessageBox.Show("Este producto ya se encuentra registrado en el inventario, intenta modificarlo");
                return;
            }
            else
            {
                int actualizar = nProducto.ActualizarCantidadProductoRegistrar(producto, stock);

                if (actualizar == 0)
                {
                    MessageBox.Show("El producto no cuenta con stock suficiente");
                    return;
                }
                else if (actualizar == -1)
                {
                    MessageBox.Show("Se produjo un error");
                    return;
                }
                else if (actualizar > 0)
                {
                    String mensaje = nProductoInventario.Registrar(productoInventario);
                    MessageBox.Show(mensaje);
                    Inventario inventarioTemp = nInventario.ObtenerInventario(inventarioId);
                    int totalStockTemp = nProductoInventario.CalcularStockTotal(nInventario.ObtenerInventario(inventarioId), inventarioId);
                    MostrarProductoInventario(nProductoInventario.ListarTodoFisico(this.inventarioId));
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgProductoInventario.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un productoInventario");
                return;
            }
            int productoInventarioId = int.Parse(dgProductoInventario.SelectedRows[0].Cells[0].Value.ToString());

            ProductoInventario productoInventarioTemp = nProductoInventario.ObtenerPorId(productoInventarioId);
            Producto producto = nProducto.ObtenerProductoPorId(productoInventarioTemp.idProducto);

            int actualizar = nProducto.ActualizarCantidadProductoElmininar(producto, productoInventarioTemp.Stock);
            if (actualizar == -1)
            {
                MessageBox.Show("Se produjo un error");
                return;
            }
            else if (actualizar > 0)
            {
                String mensaje = nProductoInventario.EliminarFisico(productoInventarioId);
                Inventario inventario = nInventario.ObtenerInventario(inventarioId);
                int totalStock = nProductoInventario.CalcularStockTotal(inventario, inventarioId);
                MessageBox.Show(mensaje);

                MostrarProductoInventario(nProductoInventario.ListarTodoFisico(this.inventarioId));
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgProductoInventario.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un productoInventario");
                return;
            }
            int productoInventarioId = int.Parse(dgProductoInventario.SelectedRows[0].Cells[0].Value.ToString());

            ProductoInventario productoInventarioTemp = nProductoInventario.ObtenerPorId(productoInventarioId);
            Producto productoTemp = nProducto.ObtenerProductoPorId(productoInventarioTemp.idProducto);

            int eliminar = nProducto.ActualizarCantidadProductoElmininar(productoTemp, productoInventarioTemp.Stock);

            if (tbStock.Text == "" || cbProducto.Text == "")
            {
                MessageBox.Show("Ingrese los campos requeridos");
                return;
            }
            int idProducto = int.Parse(cbProducto.SelectedValue.ToString());

            int stock = 0;
            try
            {
                stock = int.Parse(tbStock.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingrese los campos numericos correctamente");
                return;
            }

            if (stock < 1)
            {
                MessageBox.Show("El stock debe ser positivo");
                return;
            }

            ProductoInventario productoInventario = new ProductoInventario();
            productoInventario.idProductoInventario = productoInventarioId;
            productoInventario.idInventario = this.inventarioId;
            productoInventario.idProducto = idProducto;
            productoInventario.Stock = stock;
            productoInventario.UsuarioModificadorId = NVendedor.VendedorLogueado.idVendedor;
            productoInventario.FechaModificacion = DateTime.Now;

            Inventario inventario = nInventario.ObtenerInventario(inventarioId);
            int totalStock = nProductoInventario.CalcularStockTotal(nInventario.ObtenerInventario(inventarioId), inventarioId);

            Producto producto = nProducto.ObtenerProductoPorId(idProducto);

            int existe = nProductoInventario.ProductoConInventario(idProducto, this.inventarioId);
            int actualizar = nProducto.ActualizarCantidadProductoRegistrar(producto, stock);

            if (actualizar == 0)
            {
                MessageBox.Show("El producto no cuenta con stock suficiente");
                return;
            }
            else if (actualizar == -1)
            {
                MessageBox.Show("Se produjo un error");
                return;
            }
            else if (actualizar > 0)
            {
                String mensaje = nProductoInventario.Modificar(productoInventario);
                Inventario inventarioTemp = nInventario.ObtenerInventario(this.inventarioId);
                int totalStockTemp = nProductoInventario.CalcularStockTotal(inventarioTemp, this.inventarioId);
                MessageBox.Show(mensaje);
                MostrarProductoInventario(nProductoInventario.ListarTodoFisico(this.inventarioId));
            }
        }

        private void dgProductoInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbStock.Text = dgProductoInventario.Rows[e.RowIndex].Cells["Stock"].Value.ToString();
            cbProducto.SelectedIndex = -1;
            cbProducto.Text = "";
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Inventario inventarioTemp = nInventario.ObtenerInventario(this.inventarioId);
            int totalStockTemp = nProductoInventario.CalcularStockTotal(inventarioTemp, this.inventarioId);
            FormInventario form = new FormInventario();
            form.Show();
            this.Close();
        }
    }
}
