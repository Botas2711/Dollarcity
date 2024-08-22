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
    public partial class FormCategoria : Form
    {
        private NCategoria nCategoria = new NCategoria();
        public FormCategoria()
        {
            InitializeComponent();
            MostrarCategorias(nCategoria.ListarTodoFisico());
        }
        private void MostrarCategorias(List<Categoria> categorias)
        {
            dgCategorias.DataSource = null;
            if (categorias.Count == 0)
            {
                return;
            }
            else
            {
                dgCategorias.DataSource = categorias;
                dgCategorias.Columns["Producto"].Visible = false;
            }
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese los campos requeridos");
                return;
            }

            Categoria categoria = new Categoria();
            categoria.Nombre = tbNombre.Text.Trim();
            categoria.Eliminado = false;
            categoria.UsuarioCreadorId = NVendedor.VendedorLogueado.idVendedor;
            categoria.FechaCreacion = DateTime.Now;
            categoria.UsuarioModificadorId = NVendedor.VendedorLogueado.idVendedor;
            categoria.FechaModificacion = DateTime.Now;

            int registrado = nCategoria.Registrar(categoria);
            if (registrado == -2)
            {
                MessageBox.Show("Nombre de la categoria repetido!");
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
            MostrarCategorias(nCategoria.ListarTodoFisico());
        }

        private void btnEliminarFisico_Click(object sender, EventArgs e)
        {
            if (dgCategorias.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una categoria");
                return;
            }
            int categoriaId = int.Parse(dgCategorias.SelectedRows[0].Cells[0].Value.ToString());
            String mensaje = nCategoria.EliminarFisico(categoriaId);
            MessageBox.Show(mensaje);

            MostrarCategorias(nCategoria.ListarTodoFisico());
        }

        private void btnEliminarLogico_Click(object sender, EventArgs e)
        {
            if (dgCategorias.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una categoria");
                return;
            }
            int categoriaId = int.Parse(dgCategorias.SelectedRows[0].Cells[0].Value.ToString());
            String mensaje = nCategoria.EliminarLogico(categoriaId);
            MessageBox.Show(mensaje);

            MostrarCategorias(nCategoria.ListarTodoFisico());
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgCategorias.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una categoria");
                return;
            }
            int categoriaId = int.Parse(dgCategorias.SelectedRows[0].Cells[0].Value.ToString());

            if (tbNombre.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese los campos requeridos");
                return;
            }

            Categoria categoria = new Categoria();
            categoria.idCategoria = categoriaId;
            categoria.Nombre = tbNombre.Text.Trim();
            categoria.Eliminado = false;
            categoria.UsuarioModificadorId = NVendedor.VendedorLogueado.idVendedor;
            categoria.FechaModificacion = DateTime.Now;

            int registrado = nCategoria.Modificar(categoria);
            if (registrado == -2)
            {
                MessageBox.Show("Nombre de la categoria repetido!");
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

            MostrarCategorias(nCategoria.ListarTodoFisico());
        }

        private void dgCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbNombre.Text = dgCategorias.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
