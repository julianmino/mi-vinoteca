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
    public partial class admin_UsersManagement : System.Web.UI.Page
    {
        readonly ClienteLogic cliLog = new ClienteLogic();

        protected void Page_Load(object sender, EventArgs e)
        {
            dgvUsuarios.DataSource = cliLog.GetAll();
            dgvUsuarios.DataBind();
        }
    }
}