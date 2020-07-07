using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class Cliente:Usuario
    {
        private int _Direccion;

        public Localidad Localidad
        {
            get => default;
            set
            {
            }
        }
    }
}