﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class Premium:Cliente
    {
        public Descuento Descuento
        {
            get => default;
            set
            {
            }
        }
    }
}