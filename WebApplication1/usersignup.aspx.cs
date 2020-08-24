using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class usersingup : System.Web.UI.Page
    {
        string strconn = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //Evento de click en el boton registrar
        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (validakNombreUsuario())
            {
                Response.Write("<script>alert('Ya existe este ID, intente con otro'); </script>");
            }
            else
            {
                registroNuevoUsuario();
            }
        }


        bool validakNombreUsuario()
        {
            SqlConnection Conn = new SqlConnection(strconn);
            if (Conn.State == ConnectionState.Closed)
            {
                Conn.Open();
            }
            SqlCommand cmd = new SqlCommand("select * from clientes where id_cliente = '"+ txtID.Text.Trim() +"'", Conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            return false;
        }

        void registroNuevoUsuario() 
        {
            //Response.Write("<script>alert('el boton anda, forro'); </script>");

            try
            {
                SqlConnection Conn = new SqlConnection(strconn);
                if (Conn.State == ConnectionState.Closed)
                {
                    Conn.Open();
                    //Response.Write("<script>alert('se abrio la conneccion'); </script>");
                }

                SqlCommand cmd = new SqlCommand("insert into " +
                    "clientes(id_cliente, nombre, apellido, usuario, email, clave, fecha_nac, premium)" +
                    "values(@id_cliente, @nombre, @apellido, @usuario, @email, @clave, @fecha_nac, @premium)", Conn);

                cmd.Parameters.AddWithValue("@id_cliente", txtID.Text.Trim());
                cmd.Parameters.AddWithValue("@nombre", txtNombre.Text.Trim());
                cmd.Parameters.AddWithValue("@apellido", txtApellido.Text.Trim());
                cmd.Parameters.AddWithValue("@usuario", txtUsuario.Text.Trim());
                cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@clave", txtPassword.Text.Trim());
                cmd.Parameters.AddWithValue("@fecha_nac", txtFechaNac.Text.Trim());
                cmd.Parameters.AddWithValue("@premium", 0);

                cmd.ExecuteNonQuery();
                Conn.Close();
                Response.Write("<script>alert('Registro exitoso. Vaya a Iniciar Sesion'); </script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
                //Response.Write("<script>alert('y aca ya no te anduvo nada rey'); </script>");
            };
        }




    }
}