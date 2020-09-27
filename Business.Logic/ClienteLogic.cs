﻿using DAL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Business.Logic 
{
    public class ClienteLogic : BusinessLogic 
    {
        private YaguaronEntities context = new YaguaronEntities();
        public ClienteLogic() 
        {
        }

        public List<cliente> GetAll() 
        {
            List<cliente> listaClientes = context.clientes.ToList();

            return listaClientes;
        }
        public cliente GetOne(int id) 
        {

            return context.clientes.SingleOrDefault(x => x.id_cliente == id);

        }

        public cliente GetByUser(string username)
        {

            return context.clientes.SingleOrDefault(x => x.usuario == username);

        }

        public void Alta(string nombre, string apellido, string usuario,
            string email, string clave, DateTime fecha_nac, bool premium, int? id_descuento) 
        {
            try 
            {
                var cliente = new cliente() 
                {
                    nombre = nombre,
                    apellido = apellido,
                    usuario = usuario,
                    email = email,
                    clave = clave,
                    fecha_nac = fecha_nac,
                    premium = premium,
                    id_descuento = id_descuento
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

        public void Modificacion(int id, string nombre, string apellido, string usuario,
            string email, string clave, DateTime fecha_nac, bool premium, int? id_descuento) {
            try {                
                cliente cliente = this.GetOne(id);
                    {
                    cliente.nombre = nombre;
                    cliente.apellido = apellido;
                    cliente.usuario = usuario;
                    cliente.email = email;
                    cliente.clave = clave;
                    cliente.fecha_nac = fecha_nac;
                    cliente.premium = premium;
                    cliente.id_descuento = id_descuento;
                    };
                context.Entry(cliente).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
            catch (Exception Ex) 
            {
                Console.WriteLine(Ex.InnerException?.Message);
            }
        }

        public void Baja(int id) {

            cliente clienteAEliminar = this.GetOne(id);
            if (clienteAEliminar != null) {
                context.clientes.Remove(clienteAEliminar);
                context.SaveChanges();
                }

            }

        public List<cliente> ConsultaEnTabla(string filtro) 
        {
            List<cliente> listaClientes = new List<cliente>();

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

    }
}
