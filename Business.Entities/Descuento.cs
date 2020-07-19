using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class Descuento : BusinessEntity
    {
        private int _Porcentaje;
        private int _FechaCaducidad;

        public Producto Producto
        {
            get => default;
            set
            {
            }
        }

        public Pedido Pedido
        {
            get => default;
            set
            {
            }
        }
    }
}