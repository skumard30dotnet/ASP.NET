using BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class UserViewList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UserBL userBL = new UserBL();

            //GridView1.DataSource = userBL.GetALL();
            //GridView1.DataBind();

            GridView1.DataSource = userBL.GetALLDataAdapter();
            GridView1.DataBind();
        }
    }
}