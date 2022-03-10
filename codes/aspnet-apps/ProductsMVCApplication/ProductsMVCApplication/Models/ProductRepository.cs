using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data; //ConnectionState enum
using System.Data.SqlClient; //SqlConnection

namespace ProductsMVCApplication.Models
{
    public class ProductRepository
    {
        //private SqlConnection connection;
        private string connectionString;

        public ProductRepository()
        {
            this.connectionString = "server=joydip-pc; database=appdb; user id=sa; password=sqlserver2017";
        }

        //method to add new product into database table
        public void InsertProduct(Product product)
        {
            SqlConnection connection;
            try
            {
                //createing connection object
                this.CreateConnection(out connection);

                //openning the connection
                this.OpenConnection(connection);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                //access database table
                this.CloseConnection(connection);
            }
        }

        //method to fetch all product records from the database table
        public void FetchAllProducts()
        {
            SqlConnection connection;
            try
            {
                //createing connection object
                this.CreateConnection(out connection);

                //openning the connection
                this.OpenConnection(connection);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                //access database table
                this.CloseConnection(connection);
            }
        }

        //method to fecth a single product record from database table, given the id of the product
        public void FetchProductById(int id)
        {
            SqlConnection connection;
            try
            {
                //createing connection object
                this.CreateConnection(out connection);

                //openning the connection
                this.OpenConnection(connection);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                //access database table
                this.CloseConnection(connection);
            }
        }

        private void CreateConnection(out SqlConnection connection)
        {
            connection = new SqlConnection(this.connectionString);
        }
        private void OpenConnection(SqlConnection connection)
        {
            try
            {
                if (this.CheckConnection(connection))
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }
                    else
                    {
                        Exception ex = new Exception("connection state is open. do not try to open already opened connection.");
                        throw ex;
                    }
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        private void CloseConnection(SqlConnection connection)
        {
            try
            {
                if (this.CheckConnection(connection))
                {
                    if (connection.State == ConnectionState.Open || connection.State == ConnectionState.Broken)
                    {
                        connection.Close();
                    }
                    else
                    {
                        Exception ex = new Exception("connection is busy. do not try to close the connection now.");
                        throw ex;
                    }
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        private bool CheckConnection(SqlConnection connection)
        {
            if (connection != null && connection.ConnectionString != null && connection.ConnectionString != string.Empty)
            {
                return true;
            }
            else
            {
                Exception ex = new Exception("either connection is not instantiated, or the connection string is not passed or empty connection string present");
                throw ex;
            }
        }
    }
}
