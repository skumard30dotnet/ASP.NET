using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserControl
{
    public partial class Login : System.Web.UI.UserControl
    {
        private string border;

        public string Border
        {
            get { return border; }
            set { border = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}