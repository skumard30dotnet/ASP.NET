using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace DAL
{
    public class UserDAL
    {
        string conString = string.Empty;
        SqlConnection con = null;

        public UserDAL()
        {
            conString = ConfigurationManager.ConnectionStrings["CheckOutConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(conString);
        }

        public void Save(User user)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SaveUser", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@FirstName", user.FirstName);
                cmd.Parameters.AddWithValue("@LastName", user.LastName);
                cmd.Parameters.AddWithValue("@UserName", user.UserName);
                cmd.Parameters.AddWithValue("@Email", user.Email);
                cmd.Parameters.AddWithValue("@Address1", user.Address1);
                cmd.Parameters.AddWithValue("@Address2", user.Address2);
                cmd.Parameters.AddWithValue("@CountryId", user.CountryId);
                cmd.Parameters.AddWithValue("@State", user.State);
                cmd.Parameters.AddWithValue("@ZipCode", user.@ZipCode);

                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {

                }
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
        }

        public User GetById(int userId)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = new SqlCommand("GetUserById", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", userId);

            SqlDataReader dr = cmd.ExecuteReader();
            User usr = new User();

            while (dr.Read())
            {
                usr.FirstName = dr["FirstName"].ToString();
                usr.LastName = dr["LastName"].ToString();
                usr.UserName = dr["UserName"].ToString();
                usr.Email = dr["Email"].ToString();
                usr.Address1 = dr["Address1"].ToString();
                usr.Address2 = dr["Address2"].ToString();
                usr.CountryId = Convert.ToInt32(dr["CountryId"].ToString());
                usr.State = dr["State"].ToString();
                usr.ZipCode = dr["ZipCode"].ToString();
            }

            return usr;
        }

        public User GetById(int userId)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = new SqlCommand("GetUserById", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", userId);

            SqlDataReader dr = cmd.ExecuteReader();
            User usr = new User();

            //If it a collection of users
            List<User> lstUsr = new List<User>();

            while (dr.Read())
            {
                usr.FirstName = dr["FirstName"].ToString();
                usr.LastName = dr["LastName"].ToString();
                usr.UserName = dr["UserName"].ToString();
                usr.Email = dr["Email"].ToString();
                usr.Address1 = dr["Address1"].ToString();
                usr.Address2 = dr["Address2"].ToString();
                usr.CountryId = Convert.ToInt32(dr["CountryId"].ToString());
                usr.State = dr["State"].ToString();
                usr.ZipCode = dr["ZipCode"].ToString();
            }

            return usr;
        }

        public SqlDataReader GetALL()
        {
            try
            {
                string query = "SELECT * FROM tblUser";
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandType = System.Data.CommandType.Text;
                return cmd.ExecuteReader();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
            }
        }

        // SQL Adapter with Inline Query
        public DataSet GetALLDataAdapter()
        {
            try
            {
                string query = "SELECT * FROM tblUser";
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataSet ds = new DataSet(); // Collection of Tables
                //DataTable dt = new DataTable(); If it is only one table
                da.Fill(ds); // da.Fill(dt); 
                return ds;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
            }
        }

        // SQL Adapter with SP 
        public DataSet GetALLDataAdapterWithStoreProcedure()
        {
            try
            {
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                SqlCommand cmd = new SqlCommand("spGetAllUser", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet(); // Collection of Tables
                //DataTable dt = new DataTable(); If it is only one table
                da.Fill(ds); // da.Fill(dt); 
                return ds;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
            }
        }

        public void Delete(int userId)
        {

        }
    }
}
