using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace InsertValuesUsingParameterizedValues
{
    class InsertValues
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType); 
        public static void ParaValue()
        {
            SqlConnection con = null;

            con = new SqlConnection("data source =.; database = Student;integrated security=SSPI");
            string query = "Insert into student(ID, Name, Email, JoinData) VALUES (@ID,@Name,@Email,@JoinData)";
           
            SqlCommand cmd4 = new SqlCommand(query,con);

            cmd4.Parameters.AddWithValue("@ID", "102");
            cmd4.Parameters.AddWithValue("@Name", "Raj");
            cmd4.Parameters.AddWithValue("@Email", "RAJ767gmail.com");
            cmd4.Parameters.AddWithValue("@JoinData", "10/2/2020");
            try
            {
                con.Open();
            }
            catch (SqlException sqlException)
            {
                log.Error("error opening connection to database  Student" + sqlException.Message);
            }
            try
            {
                cmd4.ExecuteNonQuery();
                log.Debug("Query Executed sucessfully");
            }
            catch (SqlException sqlException)
            {
                log.Error("Error executing the Query" + sqlException.Message);
            }
            con.Close();

        }
    }
}
