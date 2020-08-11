using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace Business.Logic
{
    public class ClienteLogic:BusinessLogic
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
            cliente cliente = context.clientes.SingleOrDefault(x => x.id_cliente == id);

            return cliente;
        }
        public static int Alta(string nom, string ape, string usuario, 
            string email, string clave, DateTime fecha_nac,bool premium, int id_descuento)
        {

            using (var context = new YaguaronEntities())
            {
                try
                {
                    var cliente = new cliente()
                    {
                        nombre = nom,
                        apellido = ape,
                        usuario = usuario,
                        email = email,
                        clave = clave,
                        fecha_nac = fecha_nac,
                        premium = premium,
                        id_descuento = id_descuento
                    };
                    context.clientes.Add(cliente);
                    context.SaveChanges();

                    return cliente.id_cliente;
                }
                catch (Exception Ex)
                {
                    Console.WriteLine(Ex.InnerException?.Message);
                    return 0;
                }
            }
        }
                
        public static void Modificacion(int ID, string nueva_clave)
        {
            using (var context = new YaguaronEntities())
            {
                cliente clienteAActualizar = context.clientes.Find(ID);
                clienteAActualizar.clave = nueva_clave;
                context.SaveChanges();
            }
        }

        public static void Baja(int ID)
        {
            using (var context = new YaguaronEntities())
            {
                cliente clienteAEliminar = context.clientes.Find(ID);
                if (clienteAEliminar != null)
                {
                    context.clientes.Remove(clienteAEliminar);
                    context.SaveChanges();
                }
            }
        }

        public static void Consulta(string filtro)
        {
            using (var context = new YaguaronEntities())
            {
                foreach (var cliente in context.clientes.Where(u => u.usuario.Contains(filtro)))
                {
                    Console.WriteLine(cliente.usuario);
                }
            }
        }

    }
}
