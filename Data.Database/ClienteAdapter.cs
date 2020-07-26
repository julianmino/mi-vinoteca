using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using System.Data;
using System.Data.SqlClient;

namespace Data.Database
{
    public class ClienteAdapter:Adapter
    {
        public List<Cliente> GetAll()
        {
            List<Cliente> clientes = new List<Cliente>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdClientes = new SqlCommand("Select * from clientes", sqlConn);
                SqlDataReader drClientes = cmdClientes.ExecuteReader();

                while (drClientes.Read())
                {
                    Cliente cliente = new Cliente();
                    cliente.ID = (int)drClientes["id_cliente"];
                    cliente.Nombre = (string)drClientes["nombre"];
                    cliente.Apellido = (string)drClientes["apellido"];
                    cliente.Usuario = (string)drClientes["usuario"];
                    cliente.Email = (string)drClientes["email"];
                    cliente.Clave = (string)drClientes["clave"];
                    cliente.FechaNac = (DateTime)drClientes["fecha_nac"];
                    cliente.Premium = (bool)drClientes["premium"];

                    clientes.Add(cliente);
                }

                drClientes.Close();
            }

            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de clientes", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }


            return clientes;
        }


        public Cliente GetOne(int ID)
        {
            
            Cliente cliente = new Cliente();
            try
            {
                this.OpenConnection();
                SqlCommand cmdClientes = new SqlCommand("Select * from clientes where id_cliente=@id", sqlConn);
                cmdClientes.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drClientes = cmdClientes.ExecuteReader();

                if (drClientes.Read())
                {
                    cliente.ID = (int)drClientes["id_cliente"];
                    cliente.Nombre = (string)drClientes["nombre"];
                    cliente.Apellido = (string)drClientes["apellido"];
                    cliente.Usuario = (string)drClientes["usuario"];
                    cliente.Email = (string)drClientes["email"];
                    cliente.Clave = (string)drClientes["clave"];
                    cliente.FechaNac = (DateTime)drClientes["fecha_nac"];
                    cliente.Premium = (bool)drClientes["premium"];
                }

                drClientes.Close();
            }

            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar datos de cliente", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }


            return cliente;

        }



        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();

                SqlCommand cmdDelete = new SqlCommand("delete clientes where id_cliente=@id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;

                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar cliente", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }

        }


        protected void Update(Cliente cliente)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdUpdate = new SqlCommand("UPDATE clientes SET nombre = @nombre, " +
                    "apellido = @apellido, usuario = @usuario, email = @email, clave = @clave, " +
                    "fecha_nac = @fecha_nac, premium = @premium " + "WHERE id_cliente=@id", sqlConn);
                cmdUpdate.Parameters.Add("@id", SqlDbType.Int).Value = cliente.ID;
                cmdUpdate.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = cliente.Nombre;
                cmdUpdate.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = cliente.Apellido;
                cmdUpdate.Parameters.Add("@usuario", SqlDbType.VarChar).Value = cliente.Usuario;
                cmdUpdate.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = cliente.Email;
                cmdUpdate.Parameters.Add("@clave", SqlDbType.VarChar, 50).Value = cliente.Clave;
                cmdUpdate.Parameters.Add("@fecha_nac", SqlDbType.DateTime).Value = cliente.FechaNac;
                cmdUpdate.Parameters.Add("@premium", SqlDbType.Bit).Value = cliente.Premium;
                cmdUpdate.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al modificar datos del cliente", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }


        protected void Insert(Cliente cliente)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand("insert into clientes(nombre,apellido,usuario,email,clave,fecha_nac,premium) " +
                "values (@nombre, @apellido,@usuario,@email,@clave,@fecha_nac,@premium) " + "select @@identity", sqlConn);
                cmdSave.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = cliente.Nombre;
                cmdSave.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = cliente.Apellido;
                cmdSave.Parameters.Add("@usuario", SqlDbType.VarChar).Value = cliente.Usuario;
                cmdSave.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = cliente.Email;
                cmdSave.Parameters.Add("@clave", SqlDbType.VarChar, 50).Value = cliente.Clave;
                cmdSave.Parameters.Add("@fecha_nac", SqlDbType.DateTime).Value = cliente.FechaNac;
                cmdSave.Parameters.Add("@premium", SqlDbType.Bit).Value = cliente.Premium;
                cliente.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al crear usuario", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }

        }


        public void Save(Cliente cliente)
        {
            if (cliente.State == BusinessEntity.States.New)
            {
                this.Insert(cliente);
            }
            else if (cliente.State == BusinessEntity.States.Modified)
            {
                this.Update(cliente);
            }
            else if (cliente.State == BusinessEntity.States.Deleted)
            {
                this.Delete(cliente.ID);
            }
            cliente.State = BusinessEntity.States.Unmodified;
        }

    }
}
