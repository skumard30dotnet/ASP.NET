using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _03StateManagement
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.TextBox1.Text = Request.QueryString["Name"];
            this.TextBox2.Text = Request.QueryString["LastName"];

            if (ViewState["Name"] != null)
            {
                this.Viewstate.Text = ViewState["Name"].ToString();
            }

            if (Session["SessionValue"] != null)
            {
                this.lblSession.Text = Session["SessionValue"].ToString();
            }
            if (Application["AppValue"] != null)
            {
                this.lblSession.Text = Application["AppValue"].ToString();
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Application["AppValue"] = TextBox1.Text;
            Response.Write("Session : " + Session["SessionValue"].ToString());
            Response.Write("Application: " + Application["AppValue"].ToString());
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Write(Application["AppValue"].ToString());
        }
    }
}