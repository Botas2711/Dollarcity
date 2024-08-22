using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DVendedor
    {
        public int Registrar(Vendedor vendedor)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Vendedor.Add(vendedor);
                    context.SaveChanges();
                    return vendedor.idVendedor;
                }
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
        public Vendedor IniciarSesion(string nombreUsuario, string contrasenia)
        {
            Vendedor vendedorTemp = null;
            using (var context = new BDEFEntities())
            {
                var query = from b in context.Vendedor
                            where b.NombreUsuario == nombreUsuario
                                  && b.Contrasenia == contrasenia
                                  && b.Eliminado == false
                            select b;
                vendedorTemp = query.FirstOrDefault();
            }
            return vendedorTemp;
        }
        public bool NombreUsuarioRepetido(String nombreUsuario)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    List<Vendedor> vendedorTemp = context.Vendedor.Where(s => s.NombreUsuario == nombreUsuario).ToList();
                    return !(vendedorTemp.Count == 0);
                }
            }
            catch (Exception ex)
            {
                return true;
            }
        }
        public int Modificar(Vendedor vendedor)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Vendedor vendedorTemp = context.Vendedor.Find(vendedor.idVendedor);
                    vendedorTemp.Nombre = vendedor.Nombre;
                    vendedorTemp.Apellido = vendedor.Apellido;
                    vendedorTemp.NombreUsuario = vendedor.NombreUsuario;
                    vendedorTemp.CorreoElectronico = vendedor.CorreoElectronico;
                    vendedorTemp.Contrasenia = vendedor.Contrasenia;
                    vendedorTemp.UsuarioModificacdorId = vendedor.UsuarioModificacdorId;
                    vendedorTemp.FechaModificacion = vendedor.FechaModificacion;
                    context.SaveChanges();
                    return vendedorTemp.idVendedor;
                }
            }
            catch (Exception ex)
            {
                return -3;
            }
        }
        //Eliminar fisico
        public String EliminarFisico(int vendedorId)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Vendedor vendedorTemp = context.Vendedor.Find(vendedorId);
                    context.Vendedor.Remove(vendedorTemp);
                    context.SaveChanges();
                }
                return "Eliminado fisico correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        //Eliminar logico
        public String EliminarLogico(int vendedorId)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Vendedor vendedorTemp = context.Vendedor.Find(vendedorId);
                    vendedorTemp.Eliminado = true;
                    context.SaveChanges();
                }
                return "Eliminado logico correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        //Listar fisico
        public List<Vendedor> ListarTodoFisico()
        {
            List<Vendedor> vendedores = new List<Vendedor>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    vendedores = context.Vendedor.ToList();
                }
                return vendedores;
            }
            catch (Exception ex)
            {
                return vendedores;
            }
        }
        //Listar logico
        public List<Vendedor> ListarTodoLogico()
        {
            List<Vendedor> vendedores = new List<Vendedor>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    vendedores = context.Vendedor.Where(s => s.Eliminado == false).ToList();
                }
                return vendedores;
            }
            catch (Exception ex)
            {
                return vendedores;
            }
        }
        public Vendedor ObtenerVendedorPorNombreUsuario(String nombreUsuario)
        {
            Vendedor vendedor = new Vendedor();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    vendedor = context.Vendedor.FirstOrDefault(s => s.NombreUsuario.Contains(nombreUsuario));
                }
                return vendedor;
            }
            catch (Exception ex)
            {
                return vendedor;
            }
        }
    }
}
