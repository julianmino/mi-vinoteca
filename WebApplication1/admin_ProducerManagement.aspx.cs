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
    public partial class admin_ProducerManagement : System.Web.UI.Page
    {
        private ProductorLogic prodLog = new ProductorLogic();
        private productores productorActual = new productores();

        private enum Accion
        {
            Agregar,
            Modificar,
            Borrar
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            dgvProductores.DataSource = prodLog.GetAll();
            dgvProductores.DataBind();
            bool ban = Session.IsNewSession;
            Session["role"] = (ban) ? "" : Session["role"];
            try
            {

                if (!Session["role"].Equals("admin"))
                {
                    Response.Redirect("homepage.aspx");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void onCheckedPressed(object sender, EventArgs e)
        {
            try
            {
                productorActual = prodLog.GetOne(Int32.Parse(txtIdProductor.Text));
                if (productorActual != null)
                {
                    txtNombre.Text = productorActual.nombre;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void onAgregarPressed(object sender, EventArgs e)
        {
            try
            {
                VisibilityOf(lblNombre, String.IsNullOrEmpty(txtNombre.Text));
                if (!lblNombre.Visible)
                {
                    MapearProductor(Accion.Agregar);
                    if (ProductorPuedeRegistrarse(productorActual))
                    {
                        prodLog.Alta(productorActual.nombre);
                        dgvProductores.DataBind();
                        Page.Response.Redirect(Page.Request.Url.ToString(), true);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        protected void onActualizarPressed(object sender, EventArgs e)
        {
            try
            {
                VisibilityOf(lblNombre, String.IsNullOrEmpty(txtNombre.Text));
                if (!lblNombre.Visible && !String.IsNullOrEmpty(txtIdProductor.Text))
                {
                    MapearProductor(Accion.Modificar);
                    prodLog.Modificacion(productorActual.id_productor, productorActual.nombre);
                    dgvProductores.DataBind();
                    Page.Response.Redirect(Page.Request.Url.ToString(), true);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        protected void onBorrarPressed(object sender, EventArgs e)
        {
            try
            {
                VisibilityOf(lblNombre, String.IsNullOrEmpty(txtNombre.Text));
                if (!lblNombre.Visible && !String.IsNullOrEmpty(txtIdProductor.Text))
                {
                    MapearProductor(Accion.Borrar);
                    prodLog.Baja(productorActual.id_productor);
                    dgvProductores.DataBind();
                    Page.Response.Redirect(Page.Request.Url.ToString(), true);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void onTxtChanged(object sender, EventArgs e)
        {
            VisibilityOf(lblNombre, String.IsNullOrEmpty(txtNombre.Text));
        }

        private void VisibilityOf(Label label, bool value)
        {
            label.Visible = value;
        }

        private void MapearProductor(Enum accion)
        {
            if ((accion.Equals(Accion.Borrar) || accion.Equals(Accion.Modificar)) && !String.IsNullOrEmpty(txtIdProductor.Text))
            {
                productorActual.id_productor = Int32.Parse(txtIdProductor.Text);
            }
            productorActual.nombre = txtNombre.Text;
        }

        private bool ProductorPuedeRegistrarse(productores productor)
        {
            bool ban = true;
            productores productorExistente = new productores();
            productorExistente = prodLog.GetProductorDeNombre(productor.nombre);
            if (productorExistente != null)
            {
                if (productor.nombre == productorExistente.nombre)
                {
                    ban = false;
                }
            }
            return ban;
        }
    }
}