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
    public partial class FormProducto : Form
    {
        private NProducto nProducto = new NProducto();
        private NCategoria nCategoria = new NCategoria();

        public FormProducto()
        {
            InitializeComponent();
            MostrarProductos(nProducto.ListarTodoFisico());
            MostrarCategorias(nCategoria.ListarTodoLogico());

        }
        private void MostrarProductos(List<Producto> productos)
        {
            dgProductos.DataSource = null;
            if (productos.Count == 0)
            {
                return;
            }
            else
            {
                tbNombre.Enabled = true;
                dgProductos.DataSource = productos;
                dgProductos.Columns["Categoria"].Visible = false;
                dgProductos.Columns["DetalleBoleta"].Visible = false;
                dgProductos.Columns["ProductoInventario"].Visible = false;
            }
        }
        private void MostrarCategorias(List<Categoria> categorias)
        {
            cbCategoria.DataSource = null;
            if (categorias.Count == 0)
            {
                return;
            }
            else
            {
                cbCategoria.DataSource = categorias;
                cbCategoria.ValueMember = "idCategoria";
                cbCategoria.DisplayMember = "Nombre";
            }
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if(tbNombre.Text == "" || tbDescripcion.Text == "" || tbCantidadTotal.Text == "" || tbPrecioProducto.Text == "" || cbCategoria.Text == "")
            {
                MessageBox.Show("Ingrese los campos requeridos");
                return;
            }

            int idCategoria = int.Parse(cbCategoria.SelectedValue.ToString());

            // Validacion de campos numericos
            Decimal precio = 0;
            int cantidad = 0;
            try
            {
                precio = Decimal.Parse(tbPrecioProducto.Text);
                cantidad = int.Parse(tbCantidadTotal.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingrese los campos numericos correctamente");
                return;
            }

            if (precio < 1 || cantidad < 1)
            {
                MessageBox.Show("El precio y la cantidad deben ser positivos");
                return;
            }
            Producto producto = new Producto();
            producto.Nombre = tbNombre.Text;
            producto.Descripcion = tbDescripcion.Text;
            producto.PrecioProducto = precio;
            producto.CantidadTotal = cantidad;
            producto.idCategoria = idCategoria;
            producto.UsuarioCreadorId = NVendedor.VendedorLogueado.idVendedor;
            producto.FechaCreacion = DateTime.Now;
            producto.UsuarioModificadorId = NVendedor.VendedorLogueado.idVendedor;
            producto.FechaModificacion = DateTime.Now;

            int registrado = nProducto.Registrar(producto);
            if (registrado == -2)
            {
                MessageBox.Show("Nombre de producto repetido!");
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

            MostrarProductos(nProducto.ListarTodoFisico());
        }

        private void btnEliminarFisico_Click(object sender, EventArgs e)
        {
            if (dgProductos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un producto");
                return;
            }
            int productoId = int.Parse(dgProductos.SelectedRows[0].Cells[0].Value.ToString());
            String mensaje = nProducto.EliminarFisico(productoId);
            MessageBox.Show(mensaje);

            MostrarProductos(nProducto.ListarTodoFisico());
        }

        private void btnEliminarLogico_Click(object sender, EventArgs e)
        {
            if (dgProductos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un producto");
                return;
            }
            int productoId = int.Parse(dgProductos.SelectedRows[0].Cells[0].Value.ToString());
            String mensaje = nProducto.EliminarLogico(productoId);
            MessageBox.Show(mensaje);

            MostrarProductos(nProducto.ListarTodoFisico());
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgProductos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un producto");
                return;
            }
            int productoId = int.Parse(dgProductos.SelectedRows[0].Cells[0].Value.ToString());

            if (tbNombre.Text == "" || tbDescripcion.Text == "" || tbCantidadTotal.Text == "" || tbPrecioProducto.Text == "" || cbCategoria.Text == "")
            {
                MessageBox.Show("Ingrese los campos requeridos");
                return;
            }

            int idCategoria = int.Parse(cbCategoria.SelectedValue.ToString());

            // Validacion de campos numericos
            Decimal precio = 0;
            int cantidad = 0;
            try
            {
                precio = Decimal.Parse(tbPrecioProducto.Text);
                cantidad = int.Parse(tbCantidadTotal.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingrese los campos numericos correctamente");
                return;
            }

            if (precio < 1 || cantidad < 1)
            {
                MessageBox.Show("El precio y la cantidad deben ser positivos");
                return;
            }
            Producto producto = new Producto();
            producto.idProducto = productoId;
            producto.Nombre = tbNombre.Text;
            producto.Descripcion = tbDescripcion.Text;
            producto.PrecioProducto = precio;
            producto.CantidadTotal = cantidad;
            producto.idCategoria = idCategoria;
            producto.UsuarioModificadorId = NVendedor.VendedorLogueado.idVendedor;
            producto.FechaModificacion = DateTime.Now;

            int registrado = nProducto.Modificar(producto);
            if (registrado == -1)
            {
                MessageBox.Show("Se produjo un error");
                return;
            }

            if (registrado > 0)
            {
                MessageBox.Show("Modificado correctamente");
            }

            MostrarProductos(nProducto.ListarTodoFisico());
        }

        private void dgProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbNombre.Text = dgProductos.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
            tbDescripcion.Text = dgProductos.Rows[e.RowIndex].Cells["Descripcion"].Value.ToString();
            tbCantidadTotal.Text = dgProductos.Rows[e.RowIndex].Cells["CantidadTotal"].Value.ToString();
            tbPrecioProducto.Text = dgProductos.Rows[e.RowIndex].Cells["PrecioProducto"].Value.ToString();
            cbCategoria.SelectedIndex = -1;
            cbCategoria.Text = "";
            tbNombre.Enabled = false;
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
