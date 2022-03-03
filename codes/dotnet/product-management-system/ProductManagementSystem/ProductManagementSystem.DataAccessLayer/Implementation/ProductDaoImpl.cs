using ProductManagementSystem.BusinessEntities;
using ProductManagementSystem.DataAccessLayer.Contract;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace ProductManagementSystem.DataAccessLayer.Implementation
{
    public class ProductDaoImpl : IProductDaoManager
    {
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;

        public bool DeleteRecord(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllRecords()
        {
            List<Product> products = null;
            try
            {
                connection = new SqlConnection("server=joydip-pc;database=lntdb;user id=sa;password=sqlserver2017");
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "GetAllProducts";
                command.CommandType = CommandType.StoredProcedure;

                connection.Open();
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    products = new List<Product>();
                    while (reader.Read())
                    {
                        Product product = new Product
                        {
                            ProductId = (int)reader["productid"],
                            ProductName = (string)reader["productname"],
                            Price = (decimal)reader["price"],
                            Description = (string)reader["description"],
                            ReleaseDate = (DateTime)reader["releasedate"],
                            StarRating = (decimal)reader["rating"],
                            ImagePath = (string)reader["imagepath"],
                            CategoryId = (int)reader["categoryid"]
                        };
                        products.Add(product);
                    }
                }
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                if (connection != null && connection.State == ConnectionState.Open)
                    connection.Close();
            }
            return products;
        }

        public Product GetARecordById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetPoductsByName(string name)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductsByCategoryId(int categoryId)
        {
            throw new NotImplementedException();
        }

        public bool InsertRecord(Product newData)
        {
            throw new NotImplementedException();
        }

        public bool UpdateRecord(Product updatedData)
        {
            throw new NotImplementedException();
        }
    }
}
