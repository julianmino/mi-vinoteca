using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class Pedido : BusinessEntity
    {
        private int _Fecha;
        private int _Observaciones;
        private int _Total;
        private int _IDCliente;
        private int _IDDescuento;

        public Usuario Usuario
        {
            get => default;
            set
            {
            }
        }

        public LineaPedido LineaPedido
        {
            get => default;
            set
            {
            }
        }

        public Descuento Descuento
        {
            get => default;
            set
            {
            }
        }
    }
}