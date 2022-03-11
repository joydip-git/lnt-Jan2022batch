using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data; //enums => ConnectionState, CommandType
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
        public bool InsertProduct(Product product)
        {
            SqlConnection connection = null;
            SqlCommand command = null;
            try
            {
                connection = new SqlConnection(this.connectionString);
                //createing connection object
                //this.CreateConnection(out connection);

                //create command object
                command = new SqlCommand();
                //configure command object
                command.Connection = connection;
                command.CommandText = "AddProduct";
                command.CommandType = CommandType.StoredProcedure;

                //configure parameters for the stored procedure
                SqlParameter pmid = CreateParameter<int>("@productid", product.ProductId);
                SqlParameter pmname = CreateParameter<string>("@productname", product.ProductName);
                SqlParameter pmprice = CreateParameter<decimal>("@price", product.Price);
                SqlParameter pmdesc = CreateParameter<string>("@description", product.Description);

                //pass all parameters to the command object
                SqlParameterCollection parameterCollection = command.Parameters;
                parameterCollection.Add(pmid);
                parameterCollection.Add(pmname);
                parameterCollection.Add(pmprice);
                parameterCollection.Add(pmdesc);

                //SqlParameter pmid = new SqlParameter();
                //pmid.ParameterName = "@productid";
                //pmid.Value = product.ProductId;

                //SqlParameter pmname = new SqlParameter();
                //pmname.ParameterName = "@productname";
                //pmname.Value = product.ProductName;

                //SqlParameter pmprice = new SqlParameter();
                //pmprice.ParameterName = "@price";
                //pmprice.Value = product.Price;

                //SqlParameter pmdesc = new SqlParameter();
                //pmdesc.ParameterName = "@description";
                //pmdesc.Value = product.Description;

                //openning the connection
                connection.Open();

                //this.OpenConnection(connection);
                int queryResult = command.ExecuteNonQuery();
                return queryResult > 0;
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
                //access database table
                //this.CloseConnection(connection);
                connection.Close();
            }
        }

        //method to fetch all product records from the database table
        public List<Product> FetchAllProducts()
        {
            SqlConnection connection = null;
            SqlCommand command = null;
            SqlDataReader reader = null;
            List<Product> products = null;
            try
            {
                //createing connection object
                //this.CreateConnection(out connection);
                connection = new SqlConnection(this.connectionString);
                //create command object
                command = new SqlCommand();
                //configure command object
                command.Connection = connection;
                command.CommandText = "GetProducts";
                command.CommandType = CommandType.StoredProcedure;

                //openning the connection
                //this.OpenConnection(connection);
                connection.Open();

                //execute the stored procedure
                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    products = new List<Product>();
                    //DataTable dt = new DataTable("products");
                    //dt.Load(reader);
                    while (reader.Read())
                    {
                        Product product = ConvertToProduct(reader);
                        products.Add(product);
                    }
                }
                return products;
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
                //access database table
                //this.CloseConnection(connection);
                if (reader != null)
                    reader.Close();
                if (connection != null)
                    connection.Close();
            }
        }

        //method to fecth a single product record from database table, given the id of the product
        public Product FetchProductById(int id)
        {
            SqlConnection connection = null;
            SqlCommand command = null;
            SqlDataReader reader = null;
            Product product = null;
            try
            {
                //createing connection object
                //this.CreateConnection(out connection);
                connection = new SqlConnection(this.connectionString);

                //create command object
                command = new SqlCommand();
                //configure command object
                command.Connection = connection;
                command.CommandText = "GetProductById";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter pmid = CreateParameter<int>("@productid", id);
                command.Parameters.Add(pmid);

                //openning the connection
                //this.OpenConnection(connection);
                connection.Open();

                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        product = ConvertToProduct(reader);
                    }
                }
                return product;
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
                //access database table
                //this.CloseConnection(connection);
                connection.Close();
            }
        }

        private SqlParameter CreateParameter<T>(string paramName, T paramValue)
        {
            SqlParameter pm = new SqlParameter();
            pm.ParameterName = paramName;
            pm.Value = paramValue;
            return pm;
        }
        private Product ConvertToProduct(SqlDataReader reader)
        {
            Product product = new Product
            {

                ProductId = (int)reader["productid"],
                ProductName = (string)reader["productname"],
                Price = (decimal)reader["price"],
                Description = (string)reader["description"]
            };
            return product;
        }

        /*
        private SqlParameter CreateParameter(string paramName, object paramValue)
        {
            SqlParameter pm = new SqlParameter();
            pm.ParameterName = paramName;
            pm.Value = paramValue;
            return pm;
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
            catch (Exception ex)
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
    catch (Exception ex)
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
        */
    }
}
