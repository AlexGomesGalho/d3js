using System;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication9.Models
{
    public class GetDataFromDataBase
    {
        SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=CRUDOperations;Integrated Security=True");
        public DataSet ShowData()
        {
            SqlCommand command = new SqlCommand("select * from CRUDOperations.dbo.studentDetails", con);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            try
            {
                con.Open();
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine(sqlEx.ToString());
            }
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
           
            try
            {
                con.Close();
            }
            catch(SqlException sqlEx1)
            {
                Console.WriteLine(sqlEx1.Message);
            }
            return (dataSet);
        } 
    }
}
