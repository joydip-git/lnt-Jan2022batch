using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using EmployeeManagementSystem.Entities;

namespace EmployeeManagementSystem.DataAccessLayer
{
    public class EmployeeDao
    {
        public List<Employee> FetchEmployees()
        {
            SqlConnection connection = null;
            SqlCommand command = null;
            SqlDataReader reader = null;
            string conStr = "server=joydip-pc;database=lntdb;user id=sa;password=sqlserver2017";
            string query = "select employee_id as ID, employee_name as NAME, employee_salary as SALARY, dept_id as DEPT from employees";
            List<Employee> employees = null;
            try
            {
                connection = new SqlConnection(conStr);
                command = new SqlCommand(query, connection);

                connection.Open();
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    employees = new List<Employee>();
                    while (reader.Read())
                    {
                        Employee employee = new Employee();

                        employee.EmployeeId = (int)reader["ID"];
                        employee.EmployeeName = (string)reader["NAME"];
                        employee.EmployeeSalary = (decimal)reader["SALARY"];
                        employee.DepartmentId = (int)reader["DEPT"];

                        employees.Add(employee);
                    }
                }
                return employees;
            }
            catch (Exception ex)
            {
                throw ex;
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
