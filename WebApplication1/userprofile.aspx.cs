using System;
using System.Web.UI.WebControls;

namespace WebApplication1 {
    public partial class userprofile : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) 
        {

        }

        protected void btnVerDetalle_Click(object sender, EventArgs e)
        {
            LinkButton button = (LinkButton)sender;
            int id_pedido = Convert.ToInt32(button.CommandArgument);

            Session["nro_pedido"] = id_pedido;

            Response.Redirect("detalle_pedido.aspx");
        }
    }
    }