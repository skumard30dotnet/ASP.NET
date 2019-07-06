using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;
using Model;

namespace Web
{
    public partial class UserView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void Save()
        {
            User user = new User();
            UserBL userBL = new UserBL();

            user.FirstName = firstName.Text;
            user.LastName = lastName.Text;
            user.UserName = username.Text;
            user.Email = email.Text;
            user.Address1 = address.Text;
            user.Address2 = address2.Text;
            user.CountryId = Convert.ToInt32(ddlCountry.SelectedItem.Value);
            user.State = txtState.Text;
            user.ZipCode = zip.Text;

            userBL.Save(user);

            Response.Redirect("UserViewList.aspx");
        }

        public void GetById(int userId)
        {

        }

        public void GetALL()
        {

        }

        public void Delete(int userId)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Save();
        }
    }
}