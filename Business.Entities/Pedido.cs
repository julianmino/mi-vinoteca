﻿using System;
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
    }
}