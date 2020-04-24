using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace StoredProcedureExample_andInserting
{
    class SpExample
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public static void SPInsertValue()
        {
            SqlConnection con = null;
            con = new SqlConnection("data source =.; database = Student;integrated security=SSPI");
            /*string query =
              @"
                CREATE PROCEDURE Insert_Record_Procedure
                (
                @ID int,
                @Name VARCHAR(50),
                @Email VARCHAR(50),
                @JoinData DATETIME

                )
              AS
                INSERT INTO student(ID,Name,Email,JoinData) Values(@ID,@Name,@Email,@JoinData)
            ";
            */
            //SqlCommand cmd3 = new SqlCommand(query, con);

            SqlCommand cmd4 = new SqlCommand("Insert_Record_Procedure", con);
            
            try
            {
                con.Open();
               
                cmd4.CommandType = CommandType.StoredProcedure;
                try
                {
                    cmd4.Parameters.Add(new SqlParameter("@ID", "104"));
                    cmd4.Parameters.Add(new SqlParameter("@Name", "Ashuthosh"));
                    cmd4.Parameters.Add(new SqlParameter("@Email", "Ashu456gmail.com"));
                    cmd4.Parameters.Add(new SqlParameter("@JoinData", "20/4/2020"));
                    int i = cmd4.ExecuteNonQuery();
                    if (i > 0)
                    {
                        log.Info("Inserted sucessfully!!");
                    }
                }
                catch(SqlException sqlexception)
                {
                    log.Error("Error In inputing the values into the table" + sqlexception.Message);
                }
              
            }
            catch (SqlException sqlException)
            {
                log.Error("Error opening connection to database Student" + sqlException.Message);
            }
            try
            {
               
                //cmd3.ExecuteNonQuery();

               // log.Debug("Stored Procedure Created sucessfully");
            }
            catch (SqlException sqlException)
            {
                //log.Error("Error creating Procedure" + sqlException.Message);
              
            }
            finally
            {
                con.Close();
            }
            


        }
    }
}
