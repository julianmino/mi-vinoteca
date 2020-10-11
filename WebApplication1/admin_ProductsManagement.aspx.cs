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
    public partial class admin_ProductsManagement : System.Web.UI.Page
    {
        ProductoLogic prodLog = new ProductoLogic();
        productos productoActual;

        protected void Page_Load(object sender, EventArgs e)
        {
            dgvProductos.DataSource = prodLog.GetAll();
            dgvProductos.DataBind();
            
        }

        protected void onTipoChanged(object sender, EventArgs e)
        {
            switch (dropTipos.SelectedIndex)
            {
                case 0: 
                    filtrarProductores("Vino");
                    cambiarReadOnly(true, false, true);
                    break;
                case 1: 
                    filtrarProductores("Cerveza");
                    cambiarReadOnly(false, true, true);
                    break;
                case 2: 
                    filtrarProductores("Licor");
                    cambiarReadOnly(true, true, true);
                    break;
                case 3: 
                    filtrarProductores("Whisky");
                    cambiarReadOnly(true, false, false);
                    break;
            }

            listProductores.DataBind();
        }

        private void filtrarProductores(string tipo)
        {
            string[] productores = prodLog.GetProductoresDeTipo(tipo);

            for (int i=0;i<listProductores.Items.Count;i++)
            {
                for (int j=0;j<productores.Length;j++)
                {
                    if (listProductores.Items[i].Value != productores[j])
                    {
                        listProductores.Items[i].Enabled = false;
                    } else
                    {
                        listProductores.Items[i].Enabled = true;
                        break;
                    }
                }
                
            }
        }

        private void cambiarReadOnly(bool ibu, bool anio, bool aniejamiento)
        {
            txtIBU.ReadOnly = ibu;
            txtAnio.ReadOnly = anio;
            txtAniejamiento.ReadOnly = aniejamiento;
        }

        protected void onCheckedPressed(object sender, EventArgs e)
        {
            try
            {
                productoActual = prodLog.GetOne(Int32.Parse(txtIDProducto.Text));
                if (productoActual != null)
                {
                    llenarDatos(productoActual);
                }
            } catch (Exception)
            {
                throw;
            }
        }

        protected void onAgregarPressed(object sender, EventArgs e)
        {
            try
            {
                SetVisibilidades();
                if(ValidarCampos())
                {
                    Response.Redirect("homepage.aspx");
                }
            } 
            catch (Exception)
            {
                throw;
            }
        }

        protected void onActualizarPressed(object sender, EventArgs e)
        {

        }

        protected void onBorrarPressed(object sender, EventArgs e)
        {

        }

        private void llenarDatos(productos prod)
        {
            txtIDProducto.Text = prod.id_producto.ToString();
            txtNombre.Text = prod.nombre;
            txtMililitros.Text = prod.ml.ToString();
            txtVolAlcohol.Text = prod.vol_alcohol.ToString();
            txtIBU.Text = (String.IsNullOrEmpty(prod.ibu.ToString())) ? "" : prod.ibu.ToString();
            txtAnio.Text = (String.IsNullOrEmpty(prod.año.ToString())) ? "" : prod.año.ToString();
            txtAniejamiento.Text = (String.IsNullOrEmpty(prod.añejamiento.ToString())) ? "" : prod.añejamiento.ToString();
            txtPrecio.Text = prod.precio.ToString();
            txtStock.Text = prod.stock.ToString();


            switch (prod.id_tipo)
            {
                case 0: 
                    dropTipos.SelectedIndex = 0;
                    filtrarProductores("Vino");
                    cambiarReadOnly(true, false, true);
                    break;
                case 1: 
                    dropTipos.SelectedIndex = 1;
                    filtrarProductores("Cerveza");
                    cambiarReadOnly(false, true, true);
                    break;
                case 2: 
                    dropTipos.SelectedIndex = 2;
                    filtrarProductores("Licor");
                    cambiarReadOnly(true, true, true);
                    break;
                case 3: 
                    dropTipos.SelectedIndex = 3;
                    filtrarProductores("Whisky");
                    cambiarReadOnly(true, false, false);
                    break;
            }

            productores productores = prodLog.GetProductorEspecifico(prod.id_productor);
            for (int i = 0; i < listProductores.Items.Count; i++)
            {
                if (listProductores.Items[i].Text == productores.nombre)
                {
                    listProductores.SelectedIndex = i;
                    break;
                }
            }
        }


        private void VisibilityOf(Label label, bool value)
        {
            label.Visible = value;
        }
        private void SetVisibilidades()
        {
            VisibilityOf(lblNombre, String.IsNullOrEmpty(txtNombre.Text));
            VisibilityOf(lblTipo, String.IsNullOrEmpty(dropTipos.Text));
            VisibilityOf(lblProductor, String.IsNullOrEmpty(listProductores.Text));
            VisibilityOf(lblMililitros, String.IsNullOrEmpty(txtMililitros.Text));
            VisibilityOf(lblVolAlcohol, String.IsNullOrEmpty(txtVolAlcohol.Text));
            VisibilityOf(lblPrecio, String.IsNullOrEmpty(txtPrecio.Text));
            VisibilityOf(lblStock, String.IsNullOrEmpty(txtStock.Text));
            switch (dropTipos.SelectedIndex)
            {
                case 0:
                    VisibilityOf(lblAnio, String.IsNullOrEmpty(txtAnio.Text));
                    break;
                case 1:
                    VisibilityOf(lblIBU, String.IsNullOrEmpty(txtIBU.Text));
                    break;
                case 2:
                    break;
                case 3:
                    VisibilityOf(lblAniejamiento, String.IsNullOrEmpty(txtAniejamiento.Text));
                    VisibilityOf(lblAnio, String.IsNullOrEmpty(txtAnio.Text));
                    break;
            }
        }

        private bool ValidarCampos()
        {
            bool ban = false;
            if (!String.IsNullOrEmpty(txtNombre.Text))
            {
                if (!String.IsNullOrEmpty(dropTipos.Text))
                {
                    if (!String.IsNullOrEmpty(listProductores.Text))
                    {
                        if (!String.IsNullOrEmpty(txtMililitros.Text))
                        {
                            if (!String.IsNullOrEmpty(txtVolAlcohol.Text))
                            {
                                if (!String.IsNullOrEmpty(txtPrecio.Text))
                                {
                                    if (!String.IsNullOrEmpty(txtStock.Text))
                                    {
                                        switch (dropTipos.SelectedIndex)
                                        {
                                            case 0:
                                                ban = (!String.IsNullOrEmpty(txtAnio.Text));
                                                break;
                                            case 1:
                                                ban = (!String.IsNullOrEmpty(txtIBU.Text));
                                                break;
                                            case 2:
                                                ban = true;
                                                break;
                                            case 3:
                                                ban = (!String.IsNullOrEmpty(txtAniejamiento.Text) && !String.IsNullOrEmpty(txtAnio.Text));
                                                break;
                                        }
                                    }
                                    else ban = false;
                                }
                                else ban = false;
                            }
                            else ban = false;
                        }
                        else ban = false;
                    }
                    else ban = false;
                }
                else ban = false;
            }
            else ban = false;
            
            return ban;
        }
    }
}