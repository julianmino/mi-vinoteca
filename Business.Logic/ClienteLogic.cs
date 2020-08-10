using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class ClienteLogic:BusinessLogic
    {

        private Data.Database.ClienteAdapter _UsuarioData;

        public ClienteAdapter ClienteData { get => _UsuarioData; set => _UsuarioData = value; }


        public ClienteLogic(Data.Database.ClienteAdapter clientedata)
        {
            ClienteData = clientedata;
        }

        public List<Cliente> GetAll()
        {
            List<Cliente> clientes = ClienteData.GetAll();
            return clientes;
        }
        public Cliente GetOne(int id)
        {
            Cliente cliente = ClienteData.GetOne(id);
            return cliente;
        }
        public void Delete(int id)
        {
            ClienteData.Delete(id);
        }

        public void Save(Cliente cliente)
        {
            ClienteData.Save(cliente);
        }

    }
}
