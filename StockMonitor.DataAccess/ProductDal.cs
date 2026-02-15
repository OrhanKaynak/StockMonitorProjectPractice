using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using StockMonitor.Entities;

namespace StockMonitor.DataAccess
{
    public class ProductDal
    {
        string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=StokTakipDB;Integrated Security=True";
        public List<Product> GetAll()
        {
            List<Product> products = new List<Product>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Products", connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Product p = new Product
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            ProductName = reader["ProductName"].ToString(),
                            Price = Convert.ToDecimal(reader["Price"]),
                            Stock = Convert.ToInt32(reader["StockQuantity"]),
                            CategoryId = Convert.ToInt32(reader["CategoryId"])
                        };
                        products.Add(p);
                    }
                    reader.Close();
                }
                
                catch (Exception ex)
                {
                    throw new Exception("Veri çekilirken hata oluştu: " + ex.Message);
                }
            }
            return products;
        }
        public void Add(Product product)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "INSERT INTO Products (ProductName, Price, StockQuantity, CategoryId, Status) VALUES (@name, @price, @stock, 1, 1)";

                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@name", product.ProductName);
                command.Parameters.AddWithValue("@price", product.Price);
                command.Parameters.AddWithValue("@stock", product.Stock);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "DELETE FROM Products WHERE Id = @id";
                
                SqlCommand command = new SqlCommand (sql, connection);
                command.Parameters.AddWithValue("@id", id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Update(Product product)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "UPDATE Products SET ProductName=@name, Price=@price, StockQuantity=@stock WHERE Id=@id";

                SqlCommand command = new SqlCommand(sql, connection);

                command.Parameters.AddWithValue("@name", product.ProductName);
                command.Parameters.AddWithValue("@price", product.Price);
                command.Parameters.AddWithValue("@stock", product.Stock);
                command.Parameters.AddWithValue("@id", product.Id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public List<Product> GetProductsByName (string key)
        {
            List<Product> products = new List<Product>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "SELECT * FROM Products WHERE ProductName LIKE @key";

                SqlCommand command = new SqlCommand(sql, connection);

                command.Parameters.AddWithValue("@key", "%" + key + "%");
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Product p = new Product
                    {
                        Id = Convert.ToInt32(reader["ID"]),
                        ProductName = reader["ProductName"].ToString(),
                        Price = Convert.ToDecimal(reader["Price"]),
                        Stock = Convert.ToInt32(reader["StockQuantity"]),
                        CategoryId = Convert.ToInt32(reader["CategoryId"])
                    };
                    products.Add(p);
                }
                reader.Close();
            }
            return products;
        }
    }
}
