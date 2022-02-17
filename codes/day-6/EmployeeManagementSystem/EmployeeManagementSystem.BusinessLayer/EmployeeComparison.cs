using EmployeeManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace EmployeeManagementSystem.BusinessLayer
{
    class EmployeeComparison : IComparer<Employee>
    {
        int sortChoice;
        public EmployeeComparison()
        {

        }
        public EmployeeComparison(int sortChoice)
        {
            this.sortChoice = sortChoice;
        }

        public int Compare(Employee x, Employee y)
        {
            int result = 0;
            switch (sortChoice)
            {
                case 1:
                    result = x.EmployeeId.CompareTo(y.EmployeeId);
                    break;
                
                case 2:
                    result = x.EmployeeName.CompareTo(y.EmployeeName);
                    break;

                case 3:
                    result = x.EmployeeSalary.CompareTo(y.EmployeeSalary);
                    break;

                case 4:
                    result = x.DepartmentId.CompareTo(y.DepartmentId);
                    break;

                default:
                    result = x.EmployeeId.CompareTo(y.EmployeeId);
                    break;
            }
            return result;
        }
    }
}
