using System;
using DAL;
using Business.Logic;

namespace WebApplication1 {

    

    public partial class usersingup : System.Web.UI.Page {
        

        public void registrar() 
        {
            ClienteLogic cliLog = new ClienteLogic();
            DateTime dt = DateTime.Parse(txtFechaNac.Text);
            cliLog.Alta(txtNombre.Text.Trim(), txtApellido.Text.Trim(), txtUsuario.Text.Trim(), 
                        txtEmail.Text.Trim(), txtPassword.Text.Trim(), dt, false, null, "pendiente");
        }

        public bool Validar()
        {
            // Los valores de los msgLabel son seteados en los eventos TextChanged de cada TextBox
            bool ban = false;

            nameHelp.Visible = !String.IsNullOrEmpty(nameHelp.Text);
            apellidoHelp.Visible = !String.IsNullOrEmpty(apellidoHelp.Text);
            mailHelp.Visible = !String.IsNullOrEmpty(mailHelp.Text);
            birthHelp.Visible = !String.IsNullOrEmpty(birthHelp.Text);
            usuarioHelp.Visible = !String.IsNullOrEmpty(usuarioHelp.Text);
            passHelp.Visible = !String.IsNullOrEmpty(passHelp.Text);
            confPassHelp.Visible = !String.IsNullOrEmpty(confPassHelp.Text);

            if (!nameHelp.Visible)
            {
                if (!apellidoHelp.Visible)
                {
                    if (!mailHelp.Visible)
                    {
                        if (!birthHelp.Visible)
                        {
                            if (!usuarioHelp.Visible)
                            {
                                if (!passHelp.Visible)
                                {
                                    if (!confPassHelp.Visible)
                                    {
                                        ban = true;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return ban;
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            Validar();
            if (Validar())
            {
                registrar();
                //volver a homepage
            }
        }
    


        protected void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNombre.Text))
            {
                nameHelp.Text = "Debe ingresar un nombre";
            }
            else
            {
                nameHelp.Text = null;
            }

            nameHelp.Visible = !String.IsNullOrEmpty(nameHelp.Text);
        }

        protected void txtApellido_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtApellido.Text))
            {
                apellidoHelp.Text = "Debe ingresar un apellido";
            }
            else
            {
                apellidoHelp.Text = null;
            }

            apellidoHelp.Visible = (apellidoHelp.Text == null) ? false : true;
        }

        protected void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtEmail.Text))
            {
                mailHelp.Text = "Debe ingresar un email";
            }
            else if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains(".com"))
            {
                mailHelp.Text = "El email posee un formato inválido";
            }
            else
            {
                mailHelp.Text = null;
            }
            mailHelp.Visible = (mailHelp.Text == null) ? false : true;
        }

        protected void txtFechaNac_TextChanged(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Parse(txtFechaNac.Text);
            if (String.IsNullOrEmpty(txtFechaNac.Text))
            {
                birthHelp.Text = "Debe ingresar su fecha de nacimiento";
            }
            else if (dt >= DateTime.Now.AddYears(-18))
            {
                birthHelp.Text = "Debe ser mayor de edad";
            }
            else
            {
                birthHelp.Text = null;
            }

            birthHelp.Visible = (birthHelp.Text == null) ? false : true;
        }

        protected void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUsuario.Text))
            {
                usuarioHelp.Text = "Debe ingresar un nombre de usuario";
            }
            else
            {
                usuarioHelp.Text = null;
            }
            usuarioHelp.Visible = (usuarioHelp.Text == null) ? false : true;
        }

        protected void txtPassword_TextChanged(object sender, EventArgs e)
        {
            string pass = txtPassword.Text;
            if (String.IsNullOrEmpty(txtPassword.Text))
            {
                passHelp.Text = "Debe ingresar una clave";
            }
            else if (pass.Length < 6)
            {
                passHelp.Text = "Debe ingresar una clave con 6 o más caracteres";
                if (!String.IsNullOrEmpty(txtConfirmPassword.Text))
                {
                    if (txtPassword.Text != txtConfirmPassword.Text)
                    {
                        confPassHelp.Text = "Las claves ingresadas no coinciden";
                    }
                    else
                    {
                        confPassHelp.Text = null;
                    }
                }

            }
            else if (txtPassword.Text != txtConfirmPassword.Text && !String.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                passHelp.Text = null;
                confPassHelp.Text = "Las claves ingresadas no coinciden";
            }
            else if (txtPassword.Text == txtConfirmPassword.Text)
            {
                passHelp.Text = null;
                confPassHelp.Text = null;
            }
            else
            {
                passHelp.Text = null;
            }
            passHelp.Visible = (passHelp.Text == null) ? false : true;
        }

        protected void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                confPassHelp.Text = "Debe confirmar la clave";
            }
            else if (txtPassword.Text != txtConfirmPassword.Text)
            {
                confPassHelp.Text = "Las claves ingresadas no coinciden";
            }
            else
            {
                confPassHelp.Text = null;
            }
            confPassHelp.Visible = (confPassHelp.Text == null) ? false : true;
        }
    }
    }
    