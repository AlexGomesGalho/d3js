using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ASPDOTNETExampleDisplay;
using InsertValuesUsingParameterizedValues;
using StoredProcedureExample_andInserting;
using DataAdapterExample;


namespace ADODOTNETExample
{
    class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {
            //new Program().InsertData();
            // Display.display();
            // InsertValues.ParaValue();
            //SpExample.SPInsertValue();
            dsad.DSADExample();
            Console.ReadKey();
        }

        public void InsertData() 
        {
            SqlConnection con = null;

                con = new SqlConnection("data source =.; database = Student;integrated security=SSPI");
                SqlCommand cm = new SqlCommand("Insert into student (ID,Name,Email,JoinData) values('102','Chetan Patel','chetanpatelgmail.com','02/03/2020')", con);
                SqlCommand cm2 = new SqlCommand("Delete from student where ID = '102'", con);
                 try
                {
                    con.Open();
                }
                catch (SqlException sqlException)
                {
                    log.Error("Error opening connection to database  Student" + sqlException.Message);
                }
                try
                {
                //cm.ExecuteNonQuery();
                cm2.ExecuteNonQuery();
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
