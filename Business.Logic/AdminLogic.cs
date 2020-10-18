using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class AdminLogic : BusinessLogic
    {
        private int a = 1;

        public AdminLogic()
        {
        }

        public List<admin> GetAll()
        {
            List<admin> listaClientes = context.admin.ToList();

            return listaClientes;
        }

        public admin GetByUser(string username)
        {

            return context.admin.SingleOrDefault(x => x.usuario == username);

        }

        public void Alta(string nombre, string apellido, string usuario, string clave)
        {
            try
            {
                var admin = new admin()
                {
                    nombre = nombre,
                    apellido = apellido,
                    usuario = usuario,
                    clave = clave,
                };
                context.admin.Add(admin);
                context.Entry(admin).State = System.Data.Entity.EntityState.Added;
                context.SaveChanges();
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        public void Modificacion(string nombre, string apellido, string usuario, string clave)
        {
            try
            {
                admin admin = this.GetByUser(usuario);
                {
                    admin.nombre = nombre;
                    admin.apellido = apellido;
                    admin.usuario = usuario;
                    admin.clave = clave;
                };
                context.Entry(admin).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.InnerException?.Message);
            }
        }

        public void Baja(string usuario)
        {

            admin adminAEliminar = this.GetByUser(usuario);
            if (adminAEliminar != null)
            {
                context.admin.Remove(adminAEliminar);
                context.SaveChanges();
            }

        }

        public List<admin> ConsultaEnTabla(string filtro)
        {
            List<admin> listaAdmins = new List<admin>();

            if (!String.IsNullOrEmpty(filtro))
            {
                try
                {
                    foreach (var admin in context.admin.Where(u => u.usuario.Contains(filtro)))
                    {
                        listaAdmins.Add(admin);
                    }
                    return listaAdmins;
                }
                catch
                {
                    return null;
                }
            }
            else
            {
                return this.GetAll();
            }
        }

    }
}

