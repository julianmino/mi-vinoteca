﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class Usuario
    {
        private int _ID;
        private int _Nombre;
        private int _Apellido;
        private int _Usuario;
        private int _Clave;
        private int _Email;

        public Pedido Pedido
        {
            get => default;
            set
            {
            }
        }
    }

}