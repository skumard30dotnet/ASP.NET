using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _04Validations
{
    public partial class ClideSideValidation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEmployeeName.Text))
            {
                Response.Write(txtEmployeeName.Text);
            }
            else
            {
                Response.Write("No Text Found");
            }
        }
    }
}