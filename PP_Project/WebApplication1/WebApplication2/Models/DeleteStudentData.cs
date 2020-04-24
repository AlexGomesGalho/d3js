using System;
using System.Data.SqlClient;


namespace WebApplication9.Models
{
    public class DeleteStudentData
    {
        SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=CRUDOperations;Integrated Security=True");
        public void Delete(int Id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM CRUDOperations.dbo.studentDetails WHERE Id = @Id;", con);
            command.Parameters.AddWithValue("@Id", Id);
            try
            {
                con.Open();
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine(sqlEx.ToString());
            }
            command.ExecuteNonQuery();
            try
            {
                con.Close();
            }
            catch (SqlException sqlEx1)
            {
                Console.WriteLine(sqlEx1.Message);
            }         
        }
    }
}
