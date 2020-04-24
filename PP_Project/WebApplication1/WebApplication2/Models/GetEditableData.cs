using System;
using System.Data;
using System.Data.SqlClient;


namespace WebApplication9.Models
{
    public class GetEditableData
    {
        SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=CRUDOperations;Integrated Security=True");
        public DataSet GetDataById(int Id)
        {
            SqlCommand command = new SqlCommand("select * from CRUDOperations.dbo.studentDetails where Id = @Id", con);
            command.Parameters.AddWithValue("@Id", Id);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            try
            {
                con.Open();
                command.ExecuteNonQuery();
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
            catch (SqlException sqlEx1)
            {
                Console.WriteLine(sqlEx1.Message);
            }
            return (dataSet);
        }
    }
}
