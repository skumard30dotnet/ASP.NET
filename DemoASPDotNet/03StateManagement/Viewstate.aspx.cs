using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _03StateManagement
{
    public partial class Viewstate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //Viewstate v = new Viewstate();
            //ViewState["Id"] = 123;
            //ViewState["LastName"] = "Pragim";

            if (ViewState["Name"] != null)
            {
                ViewState["Name"] = TextBox1.Text;
                Label1.Text = ViewState["Name"].ToString();
            }
            else
            {
                ViewState["Name"] = "No Value in View State";
                Label1.Text = ViewState["Name"].ToString();
            }


        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string txt = ViewState["Name"].ToString();
            Session["SessionValue"] = txt;
            Application["AppValue"] = txt;
            Response.Redirect("Default.aspx?Name=" + this.TextBox1.Text + "&LastName=" + "Pragim");

        }
    }
}