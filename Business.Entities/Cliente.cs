using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class Cliente : BusinessEntity
    {
        private string _Nombre;
        private string _Apellido;
        private string _Usuario;
        private string _Clave;
        private string _Email;
        private DateTime _FechaNac;
        private bool _Premium;

        public Pedido Pedido
        {
            get => default;
            set
            {
            }
        }

        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellido { get => _Apellido; set => _Apellido = value; }
        public string Usuario { get => _Usuario; set => _Usuario = value; }
        public string Clave { get => _Clave; set => _Clave = value; }
        public string Email { get => _Email; set => _Email = value; }
        public DateTime FechaNac { get => _FechaNac; set => _FechaNac = value; }
        public bool Premium { get => _Premium; set => _Premium = value; }
    }

}