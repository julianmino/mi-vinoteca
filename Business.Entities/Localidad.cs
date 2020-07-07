using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class Localidad
    {
        private int _CodigoPostal;
        private int _ID;
        private int _Nombre;

        public Provincia Provincia
        {
            get => default;
            set
            {
            }
        }
    }
}