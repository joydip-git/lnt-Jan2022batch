using ProductManagementSystem.BusinessEntities;
using ProductManagementSystem.DataAccessLayer.Contract;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ProductManagementSystem.DataAccessLayer.Implementation
{
    public class ProductDaoImpl : IProductDaoManager
    {
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;

        public bool DeleteRecord(int id)
        {
            bool status = false;
            try
            {
                connection = new SqlConnection("server=joydip-pc;database=lntdb;user id=sa;password=sqlserver2017");
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "DeleteProduct";
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@pid", id)
                    .SqlDbType = SqlDbType.Int;

                connection.Open();
                int result = command.ExecuteNonQuery();
                if (result > 0)
                    status = true;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (connection != null && connection.State == ConnectionState.Open)
                    connection.Close();
            }
            return status;
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
            catch (SqlException ex)
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
            Product product = null;
            try
            {
                connection = new SqlConnection("server=joydip-pc;database=lntdb;user id=sa;password=sqlserver2017");
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "GetProductById";
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@pid", id).SqlDbType = SqlDbType.Int;

                //select count(productname) from products
                // command.ExecuteScalar(); => used to executeselect query which returns single value
                connection.Open();
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {                   
                    while (reader.Read())
                    {
                        product = new Product
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
                    }
                }
            }
            catch (SqlException ex)
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
            return product;
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
            bool status = false;
            try
            {
                connection = new SqlConnection("server=joydip-pc;database=lntdb;user id=sa;password=sqlserver2017");
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "InsertProduct";
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@pname", newData.ProductName)
                    .SqlDbType = SqlDbType.VarChar;
                command.Parameters.AddWithValue("@price", newData.Price)
                    .SqlDbType = SqlDbType.Decimal;
                command.Parameters.AddWithValue("@cid", newData.CategoryId)
                    .SqlDbType = SqlDbType.Int;
                command.Parameters.AddWithValue("@rating", newData.StarRating)
                    .SqlDbType = SqlDbType.Decimal;
                command.Parameters.AddWithValue("@imgpath", newData.ImagePath)
                    .SqlDbType = SqlDbType.VarChar;
                command.Parameters.AddWithValue("@releasedate", newData.ReleaseDate)
                    .SqlDbType = SqlDbType.Date;
                command.Parameters.AddWithValue("@desc", newData.Description)
                    .SqlDbType = SqlDbType.VarChar;

                /*
                SqlParameter pname = new SqlParameter();
                pname.ParameterName = "@pname";
                pname.Value = newData.ProductName;
                pname.SqlDbType = SqlDbType.VarChar;

                SqlParameter price = new SqlParameter();
                price.ParameterName = "@price";
                price.Value = newData.Price;
                price.SqlDbType = SqlDbType.Decimal;

                command.Parameters.Add(pname);
                command.Parameters.Add(price);
                */

                connection.Open();
                int result = command.ExecuteNonQuery();
                if (result > 0)
                    status = true;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (connection != null && connection.State == ConnectionState.Open)
                    connection.Close();
            }
            return status;
        }

        public bool UpdateRecord(Product updatedData)
        {
            bool status = false;
            try
            {
                connection = new SqlConnection("server=joydip-pc;database=lntdb;user id=sa;password=sqlserver2017");
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "UpdateProduct";
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@pid", updatedData.ProductId)
                    .SqlDbType = SqlDbType.Int;
                command.Parameters.AddWithValue("@pname", updatedData.ProductName)
                    .SqlDbType = SqlDbType.VarChar;
                command.Parameters.AddWithValue("@price", updatedData.Price)
                    .SqlDbType = SqlDbType.Decimal;
                command.Parameters.AddWithValue("@cid", updatedData.CategoryId)
                    .SqlDbType = SqlDbType.Int;
                command.Parameters.AddWithValue("@rating", updatedData.StarRating)
                    .SqlDbType = SqlDbType.Decimal;
                command.Parameters.AddWithValue("@imgpath", updatedData.ImagePath)
                    .SqlDbType = SqlDbType.VarChar;
                command.Parameters.AddWithValue("@releasedate", updatedData.ReleaseDate)
                    .SqlDbType = SqlDbType.Date;
                command.Parameters.AddWithValue("@desc", updatedData.Description)
                    .SqlDbType = SqlDbType.VarChar;

                connection.Open();
                int result = command.ExecuteNonQuery();
                if (result > 0)
                    status = true;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (connection != null && connection.State == ConnectionState.Open)
                    connection.Close();
            }
            return status;
        }
    }
}
