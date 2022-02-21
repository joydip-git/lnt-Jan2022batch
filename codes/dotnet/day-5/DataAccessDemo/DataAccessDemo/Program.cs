using System;
using System.Data.SqlClient;

namespace DataAccessDemo
{
    class Program
    {
        static void Main()
        {
            SqlConnection connection = null;
            SqlCommand command = null;
            SqlDataReader reader = null;
            string qury = "select employee_id as ID, employee_name as NAME, employee_salary as SALARY, dept_id as DEPT from employees";
            string conStr = "SERVER=JOYDIP-PC;database=lntdb;user id=sa;password=sqlserver2017";

            try
            {
                //sql server authentication
                connection = new SqlConnection(conStr);
                command = new SqlCommand(qury, connection);

                //windows authentication
                //connection = new SqlConnection("SERVER=JOYDIP-PC;database=lntdb;persistent security=true");
                //connection = new SqlConnection("SERVER=JOYDIP-PC;database=lntdb;integrated security=sspi");
                //sspi: security service provider interface

                //open the connection
                connection.Open();

                //Console.WriteLine(connection.State.ToString());
                //ExecuteReader() method executes the query
                //and puts the result set in a SqlDataReader object 
                //and returns that reader object
                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader["ID"]}, {reader["NAME"]}, {reader["SALARY"]}, {reader["DEPT"]}");
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.TargetSite);
                Console.WriteLine(ex.LineNumber);
                Console.WriteLine(ex.Source);
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                if (connection != null)
                    connection.Close();
            }
        }
    }
}
