using System;

namespace Static_NonStatic
{
    class Program
    {
        static void Main()
        {
            int x = 0;
            x = 10;
            //static method can be called with the class name directly
            //static method is never called with object reference
            string result = Sample.Call();
            Console.WriteLine(result);

            Sample.secondData = 10;

            //object is known as instance of class
            //non-static (instance) method has to be called through an object reference
            //non-static (instance) method is never called with class name directly
            Sample sampleObjectReference = new Sample();
            string message = sampleObjectReference.SayHi();
            Console.WriteLine(message);

            sampleObjectReference.firstData = 20;

            Employee joydipEmpObjectRef = null;
            joydipEmpObjectRef = new Employee("joydip", 1, 10000);
            Employee anilEmpObjectRef = new Employee("Anil", 2, 20000);
            Employee sunilEmpObjectRef = new Employee("Sunil", 2, 30000);

            string joydipInfo = joydipEmpObjectRef.GetInfo();
            string anilInfo = anilEmpObjectRef.GetInfo();
            string sunilInfo = sunilEmpObjectRef.GetInfo();

            Console.WriteLine(joydipInfo);
            Console.WriteLine(anilInfo);
            Console.WriteLine(sunilInfo);

            char chInUpper = Converter.ConvertLowerCaseToUpperCase('a');
            char chInLOwer = Converter.ConvertUpperCaseToLowerCase('A');

            Console.WriteLine(chInUpper);
            Console.WriteLine(chInLOwer);
        }
    }
}
