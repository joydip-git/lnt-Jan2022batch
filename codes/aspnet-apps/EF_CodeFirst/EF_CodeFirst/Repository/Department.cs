using System;
using System.Collections.Generic;
using System.Text;

namespace EF_CodeFirst.Repository
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }

        //navigation property. this does not map to any column
        public ICollection<Employee> Employees { set; get; }
    }
}
