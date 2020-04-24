using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ASPDOTNETExampleDisplay
{
    class Display
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public static void display()
        {
            SqlConnection con = null;
            con = new SqlConnection("data source =.; database = Student;integrated security=SSPI");
            SqlCommand cm = new SqlCommand("select * from student", con);
            try
            {
                con.Open();
            }
            catch(SqlException sqlexception)
            {
                log.Error("Error Opening database student" + sqlexception.Message);
            }
            try
            {
                SqlDataReader sdr = cm.ExecuteReader();
                while (sdr.Read())
                    log.Debug(sdr["ID"] + " " + sdr["Name"] + " " + sdr["Email"] + " " + sdr["JoinData"]);
            }
            catch(SqlException sqlexception)
            {
                log.Error("Error executing the Query" + sqlexception.Message);
            }
            con.Close();



        }
    }
}
