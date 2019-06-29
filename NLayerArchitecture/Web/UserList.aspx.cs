using BL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class UserList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM tblUser";
            SqlConnection con = new SqlConnection("data source=.; database=CheckOut; integrated security=SSPI");
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            grdUserList.DataSource = cmd.ExecuteReader();
            grdUserList.DataBind();
        }

        public void GetALL()
        {
            UserBL userBL = new UserBL();
            SqlDataReader data = userBL.GetALL();
            grdUserList.DataSource = data;
            grdUserList.DataBind();
        }
    }
}