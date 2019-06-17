using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoASPDotNet
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Pre_Init(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TextBox txtDynamicControl = new TextBox();
                txtDynamicControl.Text = "Dynamic Control";
                PlaceHolder1.Controls.Add(txtDynamicControl);
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {




                List<string> lst = new List<string>();
                lst.Add("India");
                lst.Add("China");
                lst.Add("USA");
                lst.Add("Japan");

                //// 1 st Approach
                //ListItem item = new ListItem();
                //item.Text = "Russia";
                //item.Value = "Russia";

                //ddlCountry.Items.Add(item);

                //2nd Approach
                //ListItem item = new ListItem() { Text="Singapore", Value = "Singapore" };
                //ddlCountry.Items.Add(item);

                //3rd Approach
                ddlCountry.Items.Add(new ListItem() { Text = "Malaysia", Value = "Malaysia" });

                //4th Approach
                ddlCountry.DataSource = lst;
                ddlCountry.DataBind();

                //5th Approach
                List<ListItem> lstItem = new List<ListItem>();
                lstItem.Add(new ListItem() { Text = "Srilanka", Value = "Srilanka" });




                Response.Write("First Name: " + txtFirstName.Text);
                Response.Write("Last Name: " + txtLastName.Text);
                Response.Write("Country : " + ddlCountry.SelectedItem.Text);
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Response.Write("First Name: " + txtFirstName.Text);
            Response.Write("Last Name: " + txtLastName.Text);
            Response.Write("Country : " + ddlCountry.SelectedItem.Text);
        }

        protected void ddlCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            string key = ddlCustomer.SelectedItem.Value;
            string value = ddlCustomer.SelectedItem.Text;

            Response.Write("Country Key : " + key);
            Response.Write("Country Value : " + value);
        }
    }
}