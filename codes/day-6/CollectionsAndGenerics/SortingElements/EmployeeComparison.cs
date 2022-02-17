using System;
using System.Collections.Generic;
using System.Text;

namespace SortingElements
{
    class EmployeeComparison : IComparer<Employee>
    {
        int sortChoice;
        public EmployeeComparison()
        {

        }
        public EmployeeComparison(int choice)
        {
            sortChoice = choice;
        }
        public int Compare(Employee x, Employee y)
        {
            //return +ive value if x>y
            //return -ive value if x<y
            //return 0 if x=y

            //defaul comparison logic invloving all the attributes of Employee
            //if (x.Id.CompareTo(y.id) == 0)
            //{
            //    if (x.Name.CompareTo(y.Name) == 0)
            //    {
            //        return x.Salary.CompareTo(y.Salary);
            //    }
            //    else
            //        return x.Name.CompareTo(y.Name);
            //}
            //else
            //    return x.Id.CompareTo(y.Id);

            //simply sort based on one attribute of Employee
            //return x.Id.CompareTo(y.Id);

            //choice based sorting
            int result = 0;
            switch (sortChoice)
            {
                case 1:
                    result = x.Name.CompareTo(y.Name);
                    break;

                case 2:
                    result = x.Id.CompareTo(y.Id);
                    break;

                case 3:
                    result = x.Salary.CompareTo(y.Salary);
                    break;

                default:
                    result = x.Id.CompareTo(y.Id);
                    break;
            }

            return result;
        }
    }
}
