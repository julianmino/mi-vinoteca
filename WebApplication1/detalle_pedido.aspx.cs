﻿using Business.Logic;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class detalle_pedido : System.Web.UI.Page
    {
        PedidoLogic pedidoLogic = new PedidoLogic();
        protected void Page_Load(object sender, EventArgs e)
        {
            pedidos pedido = pedidoLogic.GetOne((int)Session["nro_pedido"]);
            lblNroPedido.Text = pedido.id_pedido.ToString();
            lblTotal.Text = "Total $" + pedido.total.ToString();
        }

        protected void btnReturn_Click(object sender, EventArgs e)
        {
            Response.Redirect("userprofile.aspx");
        }
    }
}