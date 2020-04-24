using System;
using System.Data.SqlClient;


namespace WebApplication9.Models
{
    public class UpdateStudentData
    {
        public void UpdateRecord(int StudentId, StudentDetails studentDetails)
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=CRUDOperations;Integrated Security=True");
            
            

            SqlCommand command = new SqlCommand("UPDATE CRUDOperations.dbo.studentDetails SET Name = @Name, Email=@Email, MobileNumber= @MobileNumber, CollegeName= @CollegeName, Stream=@Stream WHERE Id = @StudentId", con);
            command.Parameters.AddWithValue("@StudentId", studentDetails.Id);
            command.Parameters.AddWithValue("@Name", studentDetails.Name);
            command.Parameters.AddWithValue("@Email", studentDetails.Email);
            command.Parameters.AddWithValue("@MobileNumber", studentDetails.MobileNumber);
            command.Parameters.AddWithValue("@CollegeName", studentDetails.CollegeName);
            command.Parameters.AddWithValue("@Stream", studentDetails.Stream);
            try
            {
               con.Open();
               command.ExecuteNonQuery();
            }
            catch (SqlException sqlEx)
            {
               Console.WriteLine(sqlEx.ToString());
            }            
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
