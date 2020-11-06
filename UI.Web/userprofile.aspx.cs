using System;
using System.Web.UI.WebControls;
using Business.Logic;
using DAL;

namespace WebApplication1 {
    public partial class userprofile : System.Web.UI.Page {

        private ClienteLogic cliLog = new ClienteLogic();
        private clientes cliente = new clientes();

        private enum SeccionEdicion
        {
            Datos,
            Contraseña
        }
        protected void Page_Load(object sender, EventArgs e) 
        {
            bool ban = Session.IsNewSession;
            Session["role"] = (ban) ? "" : Session["role"];
            try
            {
                if (!Session["role"].Equals("cliente"))
                {
                    Response.Redirect("homepage.aspx");
                } else
                {
                    Session["nombre"] = txtNombre.Text;
                    Session["apellido"] = txtApellido.Text;
                    Session["email"] = txtEmail.Text;
                    llenarDatosCliente(Session["username"].ToString());
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void btnVerDetalle_Click(object sender, EventArgs e)
        {
            LinkButton button = (LinkButton)sender;
            int id_pedido = Convert.ToInt32(button.CommandArgument);

            Session["nro_pedido"] = id_pedido;

            Response.Redirect("detalle_pedido.aspx");
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            enablePasswordValidators(true);
            setReadOnly(false, SeccionEdicion.Contraseña);
            setVisibility(true, SeccionEdicion.Contraseña);
            
        }

        protected void btnEditarDatos_Click(object sender, EventArgs e)
        {
            
            setReadOnly(false, SeccionEdicion.Datos);
            setVisibility(true, SeccionEdicion.Datos);
        }

        protected bool Validar_Contraseña(string usuario)
        {
            try
            {
                bool ban = false;
                if (cliente.clave == txtPassActual.Text)
                {
                    ban = true;
                }
                lblContraseña.Visible = !ban;
                return ban;
            } catch (Exception)
            {
                throw;
            }
           
        }
        protected bool Validar_Email(string email)
        {
            bool ban = true;
            clientes[] clientes = cliLog.GetAll().ToArray();
            foreach (clientes c in clientes)
            {
                if (c.email == email)
                {
                    ban = false;
                    break;
                }
            }
            if (cliente.email == email)
            {
                ban = true;
            }
            lblEmailRegistrado.Visible = !ban;
            return ban;
        }
        private void llenarDatosCliente(string usuario)
        {
            try
            {
                cliente = cliLog.GetOne(usuario);

                txtUsuario.Text = cliente.usuario;
                txtEstado.Text = cliente.estado;
                txtNombre.Text = cliente.nombre;
                txtApellido.Text = cliente.apellido;
                txtEmail.Text = cliente.email;
                txtFechaNac.Text = cliente.fecha_nac.ToString("dd/MM/yyyy");
                
            } catch (Exception)
            {
                Response.Write("<script language='javascript'>alert('Usuario no encontrado en la base de datos')</script>");
                Response.Redirect("homepage.aspx");
            }
        }

        private void Modificar(string passNueva)
        {
            try
            {
                cliLog.Modificacion(cliente.usuario, cliente.nombre, cliente.apellido, cliente.email, passNueva, cliente.fecha_nac, cliente.premium, cliente.id_descuento, cliente.estado);
                cliente = cliLog.GetOne(cliente.usuario);
            } catch (Exception)
            {
                throw;
            }
            
        }
        
        private void Modificar (string usuario, string nombre, string apellido, string email, string pass, DateTime fechaNac, bool premium, int? id_descuento, string estado)
        {
            try
            {
                cliLog.Modificacion(usuario, nombre, apellido, email, pass, fechaNac, premium, id_descuento, estado);
                cliente = cliLog.GetOne(cliente.usuario);
            } catch (Exception)
            {
                throw;
            }
            
        }

        //protected void btnCancelar_Click(object sender, EventArgs e)
        //{
        //    enablePasswordValidators(false);
        //    setReadOnly(true, SeccionEdicion.Contraseña);
        //    setVisibility(false, SeccionEdicion.Contraseña);
        //    llenarDatosCliente(cliente.usuario);
        //    Page.Response.Redirect(Page.Request.Url.ToString(), true);
        //}

        protected void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Page.IsValid)
                {
                    bool passValida = Validar_Contraseña(txtUsuario.Text);
                    if (passValida)
                    {
                        Modificar(txtPassNueva.Text);
                        setReadOnly(true, SeccionEdicion.Contraseña);
                        setVisibility(false, SeccionEdicion.Contraseña);
                        enablePasswordValidators(false);
                        Page.Response.Redirect(Page.Request.Url.ToString(), true);
                    }
                }
            } catch (Exception)
            {
                throw;
            }
            
        }

        //protected void btnCancelarEdicion_Click(object sender, EventArgs e)
        //{
        //    setReadOnly(true, SeccionEdicion.Datos);
        //    setVisibility(false, SeccionEdicion.Datos);
        //    Page.Response.Redirect(Page.Request.Url.ToString(), true);
        //}

        protected void btnConfirmarEdicion_Click(object sender, EventArgs e)
        {
            try
            {
                if (Page.IsValid)
                {
                    bool emailValido = Validar_Email(txtEmail.Text);
                    if (emailValido)
                    {
                        Modificar(txtUsuario.Text, Session["nombre"].ToString(), Session["apellido"].ToString(), Session["email"].ToString(), cliente.clave, cliente.fecha_nac, cliente.premium, cliente.id_descuento, cliente.estado); ;
                        setReadOnly(true, SeccionEdicion.Datos);
                        setVisibility(false, SeccionEdicion.Datos);
                        Session["name"] = Session["nombre"];
                        Page.Response.Redirect(Page.Request.Url.ToString(), true);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void setVisibility(bool estadoEdicion, Enum Seccion)
        {
            switch (Seccion)
            {
                case SeccionEdicion.Datos:
                    //btnCancelarEdicion.Visible = estadoEdicion;
                    btnConfirmarEdicion.Visible = estadoEdicion;
                    btnEditarDatos.Visible = !estadoEdicion;
                    break;
                case SeccionEdicion.Contraseña:
                    //btnCancelar.Visible = estadoEdicion;
                    btnConfirmar.Visible = estadoEdicion;
                    btnActualizar.Visible = !estadoEdicion;
                    break;
            }
        }

        private void setReadOnly(bool valor, Enum Seccion)
        {
            switch (Seccion)
            {
                case SeccionEdicion.Datos:
                    txtNombre.ReadOnly = valor;
                    txtApellido.ReadOnly = valor;
                    txtEmail.ReadOnly = valor;
                    break;
                case SeccionEdicion.Contraseña:
                    txtPassActual.ReadOnly = valor;
                    txtPassNueva.ReadOnly = valor;
                    break;
        }
           
        }

        private void enablePasswordValidators(bool valor)
        {
            rfvPassword.Enabled = valor;
            rfvNewPassword.Enabled = valor;
            revPasswordValidation.Enabled = valor;
        }

    }
    }