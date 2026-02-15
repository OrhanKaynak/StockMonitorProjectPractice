using System.Data.SqlClient;
using StockMonitor.Entities;

namespace StockMonitor.DataAccess
{
    public class UserDal
    {
        string connectionString = @"server=(localdb)\MSSQLLocalDB;Database=StokTakipDB; Integrated Security=True";

        public bool CheckUser(User user)
        {
            bool result = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "SELECT * FROM Users WHERE Username=@user AND Password=@pass";

                SqlCommand command = new SqlCommand(sql, connection);

                command.Parameters.AddWithValue("@user", user.UserName);
                command.Parameters.AddWithValue("pass", user.Password);
                
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                result = reader.Read();
            }
            return result;
        }
    }
}
