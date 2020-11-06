using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Logic;
using DAL;
using System.IO;

namespace WebApplication1
{
    public partial class admin_ProductsManagement : System.Web.UI.Page
    {
        ProductoLogic prodLog = new ProductoLogic();
        productos productoActual = new productos();
        bool validar = false;

        private enum Accion
        {
            Agregar,
            Modificar,
            Borrar
        }

        private enum Producto
        {
            Vino,
            Cerveza,
            Licor,
            Whisky
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            dgvProductos.DataSource = prodLog.GetAll();
            dgvProductos.DataBind();
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

        protected void onTipoChanged(object sender, EventArgs e)
        {
            switch (dropTipos.SelectedIndex)
            {
                case 0:
                    cambiarReadOnly(true, false, true);
                    break;
                case 1:
                    cambiarReadOnly(false, true, true);
                    break;
                case 2:
                    cambiarReadOnly(true, true, true);
                    break;
                case 3:
                    cambiarReadOnly(true, false, false);
                    break;
            }
            if (validar) { SetVisibilidades(); }
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
                    SetVisibilidades();
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
                validar = true;
                SetVisibilidades();
                if (ValidarCampos())
                {
                    mapearDatosProducto(Accion.Agregar);
                    if (ProductoPuedeRegistrarse(productoActual))
                    {
                        prodLog.Alta(productoActual.nombre, productoActual.id_productor, productoActual.precio, productoActual.stock, productoActual.vol_alcohol,
                        productoActual.ml, productoActual.ibu, productoActual.año, productoActual.añejamiento, productoActual.id_tipo, productoActual.foto);

                        dgvProductos.DataBind();
                        validar = false;
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
                validar = true;
                SetVisibilidades();
                if (ValidarCampos())
                {
                    mapearDatosProducto(Accion.Modificar);
                    prodLog.Modificacion(productoActual.id_producto, productoActual.nombre, productoActual.id_productor, productoActual.precio, productoActual.stock, productoActual.vol_alcohol,
                    productoActual.ml, productoActual.ibu, productoActual.año, productoActual.añejamiento, productoActual.id_tipo, productoActual.foto);

                    dgvProductos.DataBind();
                    validar = false;
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
                mapearDatosProducto(Accion.Borrar);
                prodLog.Baja(productoActual.id_producto);
                dgvProductos.DataBind();
                Page.Response.Redirect(Page.Request.Url.ToString(), true);
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void onTxtChanged(object sender, EventArgs e)
        {
            if (validar) { SetVisibilidades(); }
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
                    cambiarReadOnly(true, false, true);
                    break;
                case 1:
                    dropTipos.SelectedIndex = 1;
                    cambiarReadOnly(false, true, true);
                    break;
                case 2:
                    dropTipos.SelectedIndex = 2;
                    cambiarReadOnly(true, true, true);
                    break;
                case 3:
                    dropTipos.SelectedIndex = 3;
                    cambiarReadOnly(true, false, false);
                    break;
            }

            productores productor = prodLog.GetProductorEspecifico(prod.id_productor);
            for (int i = 0; i < listProductores.Items.Count; i++)
            {
                if (listProductores.Items[i].Text == productor.nombre)
                {
                    listProductores.SelectedIndex = i;
                    break;
                }
            }
        }

        private void limpiarDatos()
        {
            txtIDProducto.Text = "";
            txtNombre.Text = "";
            txtMililitros.Text = "";
            txtIBU.Text = "";
            txtAnio.Text = "";
            txtAniejamiento.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
            txtVolAlcohol.Text = "";
            dropTipos.ClearSelection();
            listProductores.ClearSelection();
        }

        private void mapearDatosProducto(Enum accion)
        {
            try
            {
                if ((accion.Equals(Accion.Borrar) || accion.Equals(Accion.Modificar)) && !String.IsNullOrEmpty(txtIDProducto.Text))
                {
                    productoActual.id_producto = Int32.Parse(txtIDProducto.Text);
                }
                productoActual.nombre = txtNombre.Text;
                productoActual.ml = Int32.Parse(txtMililitros.Text);
                productoActual.vol_alcohol = Int32.Parse(txtVolAlcohol.Text);
                productoActual.ibu = String.IsNullOrEmpty(txtIBU.Text) ? 0 : Int32.Parse(txtIBU.Text);
                productoActual.año = String.IsNullOrEmpty(txtAnio.Text) ? 0 : Int32.Parse(txtAnio.Text);
                productoActual.añejamiento = String.IsNullOrEmpty(txtAniejamiento.Text) ? 0 : Int32.Parse(txtAniejamiento.Text);
                productoActual.precio = Int32.Parse(txtPrecio.Text);
                productoActual.stock = Int32.Parse(txtStock.Text);
                productoActual.id_tipo = Int32.Parse(dropTipos.SelectedValue);
                productoActual.id_productor = Int32.Parse(listProductores.SelectedValue);
                productoActual.foto = uploaderFoto.FileBytes;
            }
            catch (Exception e)
            {
                throw e;
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

        private bool ProductoPuedeRegistrarse(productos producto)
        {
            bool ban = false;
            List<productos> productosExistentes = new List<productos>();
            productosExistentes = prodLog.GetProductosDeProductor(producto.id_productor);
            if (productosExistentes.Count == 0)
            {
                ban = true;
            }
            else
            {
                foreach (productos p in productosExistentes)
                {
                    if (producto.nombre == p.nombre)
                    {
                        if (producto.ml == p.ml)
                        {
                            if (producto.vol_alcohol == p.vol_alcohol)
                            {
                                switch (producto.id_tipo)
                                {
                                    case 0:
                                        ban = !(producto.año == p.año);
                                        break;
                                    case 1:
                                        ban = !(producto.ibu == p.ibu);
                                        break;
                                    case 2:
                                        ban = false;
                                        break;
                                    case 3:
                                        if (producto.año == p.año)
                                        {
                                            ban = !(producto.añejamiento == p.añejamiento);
                                        }
                                        else ban = true;
                                        break;
                                }
                            }
                            else ban = true;
                        }
                        else ban = true;
                    }
                    else ban = true;
                }
            }

            return ban;
        }

        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                return ms.ToArray();
            }
        }

    }
}