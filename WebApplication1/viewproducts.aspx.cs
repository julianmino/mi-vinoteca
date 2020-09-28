using System;
using System.Data;
using System.Web.UI.WebControls;

namespace WebApplication1 {
    public partial class viewproducts : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) 
            {
            }

        protected void OnRowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                DataRowView dr = (DataRowView)e.Row.DataItem;
                string imageUrl = "data:image/jpg;base64," + Convert.ToBase64String((byte[])dr["foto"]);
                (e.Row.FindControl("Image") as Image).ImageUrl = imageUrl;
            }
        }
        }
    }