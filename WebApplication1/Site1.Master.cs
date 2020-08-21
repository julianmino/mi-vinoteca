using System;

namespace WebApplication1 {
    public partial class Site1 : System.Web.UI.MasterPage {
        protected void Page_Load(object sender, EventArgs e) {

            }

        protected void LinkButton1_Click(object sender, EventArgs e) {
            Response.Redirect("userlogin.aspx");
            }

        protected void LinkButton2_Click(object sender, EventArgs e) {
            Response.Redirect("usersignup.aspx");
            }

        protected void LinkButton4_Click(object sender, EventArgs e) {
            Response.Redirect("viewproducts.aspx");
            }
        }
    }