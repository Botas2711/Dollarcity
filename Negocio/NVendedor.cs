using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NVendedor
    {
        DVendedor dVendedor = new DVendedor();
        public static Vendedor VendedorLogueado { get; set; }
        public int Registrar(Vendedor vendedor)
        {
            if (dVendedor.NombreUsuarioRepetido(vendedor.Nombre))
            {
                return -2;
            }
            return dVendedor.Registrar(vendedor);
        }
        public Vendedor IniciarSesion(string nombreUsuario, string contrasenia)
        {
            VendedorLogueado = dVendedor.IniciarSesion(nombreUsuario, contrasenia);
            return VendedorLogueado;
        }
        public String EliminarFisico(int vendedorId)
        {
            return dVendedor.EliminarFisico(vendedorId);
        }
        public String EliminarLogico(int vendedorId)
        {
            return dVendedor.EliminarLogico(vendedorId);
        }
        public int Modificar(Vendedor vendedor)
        {
            if (dVendedor.NombreUsuarioRepetido(vendedor.Nombre))
            {
                return -2;
            }
            return dVendedor.Modificar(vendedor);

        }
        public List<Vendedor> ListarTodoFisico()
        {
            return dVendedor.ListarTodoFisico();
        }
        public List<Vendedor> ListarTodoLogico()
        {
            return dVendedor.ListarTodoLogico();

        }
        public Vendedor ObtenerVendedorPorNombreUsuario(String nombreUsuario)
        {
            return dVendedor.ObtenerVendedorPorNombreUsuario(nombreUsuario);
        }
    }
}
