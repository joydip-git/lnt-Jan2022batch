using EmployeeManagementSystem.DataAccessLayer;
using EmployeeManagementSystem.Entities;
using System;
using System.Collections.Generic;

namespace EmployeeManagementSystem.BusinessLayer
{
    public class EmployeeBo
    {
        public List<Employee> GetEmployeeRecords(int choice)
        {
            EmployeeDao employeeDao = null;
            List<Employee> employees = null;
            try
            {
                employeeDao = new EmployeeDao();
                employees = employeeDao.FetchEmployees();
                SortEmployees(employees, choice);
                return employees;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void SortEmployees(List<Employee> employees, int choice)
        {
            EmployeeComparison employeeComparison = new EmployeeComparison(choice);
            employees.Sort(employeeComparison);
        }
    }
}
