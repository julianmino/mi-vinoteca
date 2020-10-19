using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class PedidoLogic : BusinessLogic
    {
        private DescuentoLogic descLog = new DescuentoLogic();
        public PedidoLogic() { }

        public List<pedidos> GetAll()
        {
            List<pedidos> listaPedidos = context.pedidos.ToList();

            return listaPedidos;
        }

        public pedidos GetOne(int id)
        {
            return context.pedidos.SingleOrDefault(x => x.id_pedido == id);
        }

        public List<pedidos> GetByUsuario(string usuario)
        {
            List <pedidos> listaPedidos = context.pedidos.Where(x => x.usuario == usuario).ToList();
            return listaPedidos;
        }

        public void Alta(string usuario, int? id_descuento, DateTime fecha, string observaciones)
        {
            try
            {
                var pedido = new pedidos()
                {
                    usuario = usuario,
                    id_descuento = id_descuento,
                    fecha = fecha,
                    observaciones = observaciones,
                    total = 0
                };
                context.pedidos.Add(pedido);
                context.Entry(pedido).State = System.Data.Entity.EntityState.Added;
                context.SaveChanges();
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }
        public void Modificacion(int id_pedido, string usuario, int? id_descuento, DateTime fecha, string observaciones, float total)
        {
            try
            {
                pedidos pedido = this.GetOne(id_pedido);
                {
                    pedido.usuario = usuario;
                    pedido.id_descuento = id_descuento;
                    pedido.fecha = fecha;
                    pedido.observaciones = observaciones;
                    pedido.total = total;
                };
                context.Entry(pedido).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.InnerException?.Message);
            }
        }
        public void Baja(int id_pedido)
        {

            pedidos pedidoAEliminar = this.GetOne(id_pedido);
            if (pedidoAEliminar != null)
            {
                context.pedidos.Remove(pedidoAEliminar);
                context.SaveChanges();
            }
        }

        public double calcularTotal(lineas_pedidos[] lineas, int? id_descuento)
        {
            descuentos descuento = descLog.GetOne(id_descuento);

            double total = 0;
            if (descuento != null)
            {

                foreach (lineas_pedidos lp in lineas)
                {
                    if (lp.id_producto == descuento.id_producto)
                    {
                        total += (lp.subtotal * descuento.porcentaje);
                    }
                    else
                    {
                        total += lp.subtotal;
                    }
                }
            }
            else
            {
                foreach (lineas_pedidos lp in lineas)
                {
                    total += lp.subtotal;
                }
            }

            return total;
        }
    }
}
