using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;
using System.Data.SqlClient;

namespace BL
{
    public class UserBL
    {
        UserDAL userDAL;
        public UserBL()
        {
            userDAL = new UserDAL();
        }
        public void Save(User user)
        {
            //UserDAL userDAL = new UserDAL();
            userDAL.Save(user);
        }

        public void GetById(int userId)
        {

        }

        public SqlDataReader GetALL()
        {
            //UserDAL userDAL = new UserDAL();
            return userDAL.GetALL();
        }

        public List<User> GetALLDataAdapter()
        {
            //UserDAL userDAL = new UserDAL();
            return userDAL.GetALLDataAdapter();
        }

        public void Delete(int userId)
        {

        }
    }
}
