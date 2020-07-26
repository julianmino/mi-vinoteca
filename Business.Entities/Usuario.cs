using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class Usuario : BusinessEntity
    {
        private string _Nombre;
        private string _Apellido;
        private string _Usuario;
        private string _Clave;
        private string _Email;
        private int _FechaNac;

        public Pedido Pedido
        {
            get => default;
            set
            {
            }
        }
    }

}