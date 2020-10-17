using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class PedidoLogic:BusinessLogic
    {
        private YaguaronEntities context = new YaguaronEntities();

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
        public pedidos GetByUsuario(string usuario)
        {
            return context.pedidos.SingleOrDefault(x => x.usuario == usuario);
        }
        public void Alta(string usuario, int? id_descuento, DateTime fecha, string observaciones, float total)
        {
            try
            {
                var pedido = new pedidos()
                {
                    usuario = usuario,
                    id_descuento = id_descuento,
                    fecha = fecha,
                    observaciones = observaciones,
                    total = total
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
    }
}
