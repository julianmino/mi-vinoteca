using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Logic;
using DAL;
namespace WebApplication1
{
    public partial class admin_UsersManagement : System.Web.UI.Page
    {
        ClienteLogic cliLog = new ClienteLogic();
        clientes clienteActual;

        protected void Page_Load(object sender, EventArgs e)
        {
            dgvUsuarios.DataSource = cliLog.GetAll();
            dgvUsuarios.DataBind();
        }

        protected void btnCheckPressed(object sender, EventArgs e)
        {
                
                clienteActual = cliLog.GetOne(txtUsuario.Text);
                
                if (clienteActual != null)
                {
                    
                    txtEstado.Text = clienteActual.estado;
                    txtEstado.Font.Bold = true;
                    txtNombre.Text = clienteActual.nombre;
                    txtApellido.Text = clienteActual.apellido;
                    txtEmail.Text = clienteActual.email;
                    txtFechaNac.Text = clienteActual.fecha_nac.ToString("dd/MM/yyyy");
                    
                    btnHabilitado.Visible = true;
                    btnPendiente.Visible = true;
                    btnCancelado.Visible = true;
                    btnBorrarUsuario.Visible = true;
                }
        }


        protected void btnHabilitadoPressed(object sender, EventArgs e)
        {
            try
            {
                clienteActual = cliLog.GetOne(txtUsuario.Text);
                try
                {
                    
                    cliLog.CambiarEstado(clienteActual, "Habilitado");
                    dgvUsuarios.DataBind();
                    txtEstado.Text = "Habilitado";

                } catch (Exception)
                {
                    throw;
                }
                
            } catch (Exception)
            {
                throw;
            } 
         }


        protected void btnPendientePressed(object sender, EventArgs e)
        {
            try
            {
                clienteActual = cliLog.GetOne(txtUsuario.Text);
                try
                {
                    
                    cliLog.CambiarEstado(clienteActual, "Pendiente");
                    dgvUsuarios.DataBind();
                    txtEstado.Text = "Pendiente";

                }
                catch (Exception)
                {
                    throw;
                }

            }
            catch (Exception)
            {
                throw;
            }

        }

        protected void btnCanceladoPressed(object sender, EventArgs e)
        {
            try
            {
                clienteActual = cliLog.GetOne(txtUsuario.Text);
                try
                {
                    
                    cliLog.CambiarEstado(clienteActual, "Cancelado");
                    dgvUsuarios.DataBind();
                    txtEstado.Text = "Cancelado";

                }
                catch (Exception)
                {
                    throw;
                }

            }
            catch (Exception)
            {
                throw;
            }

        }

        protected void btnBorrarUsuarioPressed(object sender, EventArgs e)
        {
            try
            {
                cliLog.Baja(txtUsuario.Text);
                dgvUsuarios.DataBind();
                LimpiarCampos();
                btnHabilitado.Visible = false;
                btnPendiente.Visible = false;
                btnCancelado.Visible = false;
                btnBorrarUsuario.Visible = false;
            } catch (Exception)
            {
                throw;
            }
            
        }

        private void LimpiarCampos()
        {
            txtUsuario.Text = "";
            txtEstado.Text = "";
            txtApellido.Text = "";
            txtNombre.Text = "";
            txtEmail.Text = "";
            txtFechaNac.Text = "";
        }

    }
}