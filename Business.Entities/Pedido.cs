using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class Pedido
    {
        private int _Fecha;
        private int _ID;
        private int _Observaciones;
        private int _Total;

        public Producto Producto
        {
            get => default;
            set
            {
            }
        }

        public Usuario Usuario
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