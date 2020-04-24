using System;
using System.Data.SqlClient;


namespace WebApplication9.Models
{
    public class StudentDataToDB
    {
        public string AddStudentData(StudentDetails studentDetails)
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=CRUDOperations;Integrated Security=True;Pooling=False");
            try
            {
                string query = "INSERT INTO CRUDOperations.dbo.studentDetails (Id, Name, Email, MobileNumber, CollegeName, Stream)" + "values(@Id, @Name, @Email, @MobileNumber, @CollegeName, @Stream)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id", studentDetails.Id);
                cmd.Parameters.AddWithValue("@Name", studentDetails.Name);
                cmd.Parameters.AddWithValue("@Email", studentDetails.Email);
                cmd.Parameters.AddWithValue("@MobileNumber", studentDetails.MobileNumber);
                cmd.Parameters.AddWithValue("@CollegeName", studentDetails.CollegeName);
                cmd.Parameters.AddWithValue("@Stream", studentDetails.Stream);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }                
            }
            catch(SqlException ex)
            {
                return (ex.Message.ToString());
            }
            finally
            {
                try
                {
                    con.Close();
                }
                catch (Exception ex1)
                {
                    Console.WriteLine(ex1.ToString());
                }
            }
            return ("Data Saved Successfully");
        }
    }
}
