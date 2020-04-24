using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DataAdapterExample
{
    class dsad
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
       public static void DSADExample()
        {
            string conn = "Data Source=(local) ;Initial catalog=Student;" //inital catalog is the database
           + "integrated security=true"; //it can either be integrated security or sql server security
            SqlConnection connection = new SqlConnection(conn);
            SqlDataAdapter command = new SqlDataAdapter("select * from student", connection); //disconnected architecture
            DataSet ds = new DataSet(); //creating a dataset
            command.Fill(ds, "student"); //fill the dataset ds with student table
            log.Info(ds.GetXml());
            Console.ReadLine();
        }
    }
}