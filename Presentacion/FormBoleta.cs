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
    public partial class FormBoleta : Form
    {
        private NBoleta nBoleta = new NBoleta();
        private NDetalleBoleta nDetalleBoleta = new NDetalleBoleta();
        private NSucursal nSucursal = new NSucursal();
        public FormBoleta()
        {
            InitializeComponent();
            MostrarBoletas(nBoleta.ListarTodoFisico());
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
        private void MostrarBoletas(List<Boleta> boletas)
        {
            dgBoleta.DataSource = null;
            if (boletas.Count == 0)
            {
                return;
            }
            else
            {
                dgBoleta.DataSource = boletas;
                dgBoleta.Columns["Sucursal"].Visible = false;
                dgBoleta.Columns["DetalleBoleta"].Visible = false;
            }
        }
        private void MostrarDetalleBoleta(List<DetalleBoleta> detalleBoletas)
        {
            dgDetalleBoleta.DataSource = null;
            if (detalleBoletas.Count == 0)
            {
                return;
            }
            else
            {
                dgDetalleBoleta.DataSource = detalleBoletas;
            }
        }

        private void btnRegistrar_Click(object sender, System.EventArgs e)
        {
            if (dpFechaEmision.Text == "" || cbSucursal.Text == "")
            {
                MessageBox.Show("Ingrese los campos requeridos");
                return;
            }

            int idSucursal = int.Parse(cbSucursal.SelectedValue.ToString());

            Decimal total = 0;
            Boleta boleta = new Boleta();
            boleta.FechaEmision = dpFechaEmision.Value.Date;
            boleta.idSucursal = idSucursal;
            boleta.Eliminado = false;
            boleta.Total = total;
            boleta.UsuarioCreadorId = NVendedor.VendedorLogueado.idVendedor;
            boleta.FechaCreacion = DateTime.Now;
            boleta.UsuarioModificadorId = NVendedor.VendedorLogueado.idVendedor;
            boleta.FechaModificacion = DateTime.Now;

            int registrado = nBoleta.Registrar(boleta);
            if (registrado == -1)
            {
                MessageBox.Show("Se produjo un error");
                return;
            }

            if (registrado > 0)
            {
                MessageBox.Show("Registrado correctamente");
            }

            MostrarBoletas(nBoleta.ListarTodoFisico());
        }

        private void btnEliminar_Click(object sender, System.EventArgs e)
        {
            if (dgBoleta.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una boleta");
                return;
            }
            int boletaId = int.Parse(dgBoleta.SelectedRows[0].Cells[0].Value.ToString());
            String mensaje = nBoleta.EliminarFisico(boletaId);
            MessageBox.Show(mensaje);

            MostrarBoletas(nBoleta.ListarTodoFisico());
        }

        private void btnModificar_Click(object sender, System.EventArgs e)
        {
            if (dgBoleta.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una boleta");
                return;
            }
            int boletaId = int.Parse(dgBoleta.SelectedRows[0].Cells[0].Value.ToString());
            int idSucursal = nBoleta.ObtenerBoleta(boletaId).idSucursal;

            cbSucursal.Enabled = false;
            if (dpFechaEmision.Text == "")
            {
                MessageBox.Show("Ingrese los campos requeridos");
                return;
            }

            Decimal total = 0;
            Boleta boleta = new Boleta();
            boleta.idBoleta = boletaId;
            boleta.FechaEmision = dpFechaEmision.Value.Date;
            boleta.idSucursal = idSucursal;
            boleta.Eliminado = false;
            boleta.Total = total;
            boleta.UsuarioModificadorId = NVendedor.VendedorLogueado.idVendedor;
            boleta.FechaModificacion = DateTime.Now;

            int registrado = nBoleta.Modificar(boleta);
            cbSucursal.Enabled = true;
            if (registrado == -1)
            {
                MessageBox.Show("Se produjo un error");
                return;
            }

            if (registrado > 0)
            {
                MessageBox.Show("Modificado correctamente");
            }
            MostrarBoletas(nBoleta.ListarTodoFisico());
        }

        private void btnAgregarProducto_Click(object sender, System.EventArgs e)
        {
            if (dgBoleta.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una boleta");
                return;
            }
            int boletaId = int.Parse(dgBoleta.SelectedRows[0].Cells[0].Value.ToString());
            int idSucursal = nBoleta.ObtenerBoleta(boletaId).idSucursal;
            this.Close();
            FormDetalleBoleta form = new FormDetalleBoleta(boletaId, idSucursal);
            form.Show();
            this.Close();
        }

        private void btnSalir_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void dgBoleta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgBoleta.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione una boleta");
                    return;
                }
                int boletaId = int.Parse(dgBoleta.SelectedRows[0].Cells[0].Value.ToString());
                MostrarDetalleBoleta(nDetalleBoleta.ListarTodoFisico(boletaId));
                Boleta boleta = nBoleta.ObtenerBoleta(boletaId);
                boleta.Total = nDetalleBoleta.CalcularTotal(boleta, boletaId);
                lblTotal.Text = boleta.Total.ToString();
            }
        }
    }
}
