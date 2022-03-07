using System;
using System.Collections.Generic;

namespace LinqImplementation
{
    class Program
    {   
        static void Main()
        {
            List<Student> allStudents = StudentRepository.GetStudents();
        }
    }
}
