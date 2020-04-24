using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using MVC_PROJECT.Models;


namespace MVC_PROJECT.Models
{
    public class Db
    { 
        SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Project;Integrated Security=True");

        public int LoginCheck(Ad_login ad)
        {
            int res = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_Login", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Login_ID", ad.Login_ID);
                cmd.Parameters.AddWithValue("@Password", ad.Mypassword);
                SqlParameter oblogin = new SqlParameter();
                oblogin.ParameterName = "@Isvalid";
                oblogin.SqlDbType = SqlDbType.Bit;
                oblogin.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(oblogin);
                con.Open();
                cmd.ExecuteNonQuery();
                res = Convert.ToInt32(oblogin.Value);
                con.Close();
            }
            catch (Exception)
            {

            }
            return res;


        }
    }
}
