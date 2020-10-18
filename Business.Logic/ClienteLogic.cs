using DAL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Business.Logic
{
    public class ClienteLogic : BusinessLogic
    {
        private int a = 1;
        public ClienteLogic() 
        {
        }

        public List<clientes> GetAll() 
        {
            List<clientes> listaClientes = context.clientes.ToList();

            return listaClientes;
        }
        public clientes GetOne(string usuario) 
        {
            return context.clientes.SingleOrDefault(x => x.usuario == usuario);

        }

        public void Alta(string nombre, string apellido, string usuario,
            string email, string clave, DateTime fecha_nac, bool premium, int? id_descuento, string estado) 
        {
            try 
            {
                var cliente = new clientes()
                {
                    nombre = nombre,
                    apellido = apellido,
                    usuario = usuario,
                    email = email,
                    clave = clave,
                    fecha_nac = fecha_nac,
                    premium = premium,
                    id_descuento = id_descuento,
                    estado = estado,
                };
                context.clientes.Add(cliente);
                context.Entry(cliente).State = System.Data.Entity.EntityState.Added;
                context.SaveChanges();
            }
            catch (Exception Ex) 
            {
                throw Ex;                
            }
        }

        public void Modificacion(string usuario, string nombre, string apellido, 
            string email, string clave, DateTime fecha_nac, bool premium, int? id_descuento, string estado) {
            try {                
                clientes cliente = this.GetOne(usuario);
                    {
                    cliente.nombre = nombre;
                    cliente.apellido = apellido;
                    cliente.usuario = usuario;
                    cliente.email = email;
                    cliente.clave = clave;
                    cliente.fecha_nac = fecha_nac;
                    cliente.premium = premium;
                    cliente.id_descuento = id_descuento;
                    cliente.estado = estado;
                    };
                context.Entry(cliente).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
            catch (Exception Ex) 
            {
                Console.WriteLine(Ex.InnerException?.Message);
            }
        }

        public void Baja(string usuario) {

            clientes clienteAEliminar = this.GetOne(usuario);
            if (clienteAEliminar != null) {
                context.clientes.Remove(clienteAEliminar);
                context.Entry(clienteAEliminar).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
                }

            }

        public List<clientes> ConsultaEnTabla(string filtro) 
        {
            List<clientes> listaClientes = new List<clientes>();

            if (!String.IsNullOrEmpty(filtro))
            {
                try
                {
                    foreach (var cliente in context.clientes.Where(u => u.usuario.Contains(filtro)))
                    {
                        listaClientes.Add(cliente);
                    }
                    return listaClientes;
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

        public void CambiarEstado(clientes cliente, string estado)
        {
            if (cliente != null)
            {
                cliente.estado = estado;
                context.Entry(cliente).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
            
        }



    }
}
