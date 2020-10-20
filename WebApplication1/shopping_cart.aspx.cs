using Business.Logic;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class shopping_cart : System.Web.UI.Page
    {
        ClienteLogic cliLogic = new ClienteLogic();
        PedidoLogic pedidoLogic = new PedidoLogic();
        ProductoLogic prodLogic = new ProductoLogic();
        ProductorLogic productorLogic = new ProductorLogic();
        LineaPedidoLogic lpLogic = new LineaPedidoLogic();

        pedidos pedidoActual = new pedidos();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                DataTable dt = new DataTable();
                dt.Columns.AddRange(new DataColumn[5] { new DataColumn("id_producto"), new DataColumn("producto"), new DataColumn("productor"), new DataColumn("cantidad"), new DataColumn("subtotal") });
                GridView1.DataSource = dt;
                GridView1.DataBind();

                productos prod = new productos();

                productores productor = new productores();

                List<lineas_pedidos> lp = new List<lineas_pedidos>();
                lp = (List<lineas_pedidos>)Session["pedidos"];

                if (lp.Count < 0)
                {
                    btnConfirm.Visible = false;
                }
                else
                {
                    btnConfirm.Visible = true;
                }

                foreach (lineas_pedidos l in lp)
                {
                    prod = prodLogic.GetOne(l.id_producto);
                    productor = productorLogic.GetOne(prod.id_productor);
                    DataRow dr1 = dt.NewRow();
                    dr1[0] = l.id_producto;
                    dr1[1] = prod.nombre;
                    dr1[2] = productor.nombre;
                    dr1[3] = l.cantidad;
                    dr1[4] = l.subtotal;
                    dt.Rows.Add(dr1);
                }
                ViewState["dt"] = dt;
                BindGrid();
            }
            
        }
        protected void BindGrid()
        {
            GridView1.DataSource = ViewState["dt"] as DataTable;
            GridView1.DataBind();
        }
        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            BindGrid();
        }
        protected void OnUpdate(object sender, EventArgs e)
        {
            productos prod = new productos();

            
            GridViewRow row = (sender as LinkButton).NamingContainer as GridViewRow;
            int cantidad = Convert.ToInt32(((TextBox)row.Cells[3].Controls[0]).Text);

            DataTable dt = ViewState["dt"] as DataTable;

            int id_prod = int.Parse(dt.Rows[row.RowIndex]["id_producto"].ToString());
            prod = prodLogic.GetOne(id_prod);

            if (cantidad < prod.stock)
            {
                dt.Rows[row.RowIndex]["cantidad"] = cantidad;
                dt.Rows[row.RowIndex]["subtotal"] = (cantidad * prod.precio);

                ViewState["dt"] = dt;
                GridView1.EditIndex = -1;
                BindGrid();
            }
            else
            {
                Response.Write("<script language='javascript'>alert('Stock no valido')</script>");
            }

            
        }
        protected void OnCancel(object sender, EventArgs e)
        {
            GridView1.EditIndex = -1;
            BindGrid();
        }
        protected void OnDelete(object sender, EventArgs e)
        {
            GridViewRow row = (sender as LinkButton).NamingContainer as GridViewRow;
            DataTable dt = ViewState["dt"] as DataTable;

            int id_prod = int.Parse(dt.Rows[row.RowIndex]["id_producto"].ToString());

            List<lineas_pedidos> lp = new List<lineas_pedidos>();
            lp = (List<lineas_pedidos>)Session["pedidos"];
            foreach(lineas_pedidos l in lp)
            {
                if (l.id_producto == id_prod)
                {
                    lp.Remove(l);
                    break;
                }
            }

            dt.Rows.RemoveAt(row.RowIndex);
            ViewState["dt"] = dt;
            BindGrid();
        }

        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            clientes cli = new clientes();
            cli = cliLogic.GetOne(Session["username"].ToString());
            
            mapearDatosPedido(cli);

            int id_pedido = pedidoLogic.Alta(pedidoActual.usuario, pedidoActual.id_descuento, pedidoActual.fecha, pedidoActual.observaciones);

            foreach (GridViewRow row in GridView1.Rows)
            {
                lineas_pedidos linea = new lineas_pedidos();
                linea.id_pedido = id_pedido;
                linea.cantidad = int.Parse(row.Cells[3].Text);
                linea.id_producto = int.Parse(row.Cells[0].Text);
                linea.subtotal = float.Parse(row.Cells[4].Text);
                lpLogic.Alta(linea.id_pedido, linea.id_producto, linea.cantidad, (float)linea.subtotal);
                
                productos prod = prodLogic.GetOne(int.Parse(row.Cells[0].Text));
                int nuevoStock = prod.stock - int.Parse(row.Cells[3].Text);
                prodLogic.Modificacion( prod.id_producto, prod.nombre, prod.id_productor, prod.precio, 
                                        nuevoStock, prod.vol_alcohol, prod.ml, prod.ibu, prod.año, prod.añejamiento,
                                        prod.id_tipo);
            }
            pedidoLogic.Modificacion(   id_pedido, pedidoActual.usuario, pedidoActual.id_descuento,
                                        pedidoActual.fecha, pedidoActual.observaciones,
                                        pedidoLogic.calcularTotal(pedidoActual.id_descuento, id_pedido));

            Response.Write("<script language='javascript'>alert('Pedido Registrado')</script>");
            Response.Redirect("userprofile.aspx");
        }

        private void mapearDatosPedido(clientes cliente)
        {
            try
            {
                pedidoActual.usuario = cliente.usuario;
                pedidoActual.fecha = DateTime.Now;
                pedidoActual.total = 0;
                pedidoActual.observaciones = null;
                pedidoActual.id_descuento = null;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}