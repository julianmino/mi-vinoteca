using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class LineaPedido
    {
        private int _IDPedido;
        private int _IDProducto;
        private int _Cantidad;
        private int _Subtotal;

        public Producto Producto
        {
            get => default;
            set
            {
            }
        }
    }
}