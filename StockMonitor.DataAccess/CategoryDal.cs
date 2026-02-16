using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using StockMonitor.Entities;

namespace StockMonitor.DataAccess
{
    public class CategoryDal : ICategoryDal
    {
        string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=StokTakipDB;Integrated Security=True";

        public List<Category> GetAll()
        {
            List<Category> categories = new List<Category>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "SELECT * FROM Categories";
                SqlCommand command = new SqlCommand(sql, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read()) 
                {
                    categories.Add(new Category
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        CategoryName = reader["CategoryName"].ToString()
                    });
                }
                reader.Close();
            }
            return categories;
        }
    }
}
