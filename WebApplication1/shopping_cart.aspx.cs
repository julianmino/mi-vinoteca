using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class shopping_cart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[3] { new DataColumn("id_producto"), new DataColumn("cantidad"), new DataColumn("subtotal") });
            GridView1.DataSource = dt;
            GridView1.DataBind();
            

            List<lineas_pedidos> lp = new List<lineas_pedidos>();
            lp = (List<lineas_pedidos>)Session["pedidos"];
            foreach(lineas_pedidos l in lp) 
            {
                DataRow dr1 = dt.NewRow();
                dr1[0] =l.id_producto ;
                dr1[1] =l.cantidad;
                dr1[2] = l.subtotal;
                dt.Rows.Add(dr1);
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }

        }
    }
}