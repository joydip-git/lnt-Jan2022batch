using System;

namespace FunctionOverriiding
{
    class Program
    {
        static void Main()
        {
            //when you have overriden the base class method in the child class
            //up-casting
            Person staffObj = new Staff("joydip", "Staff Dept", "D");
            //here the method of child will be called, NOT base, since the method has been overriden in the child class
            string staffInfo = staffObj.PrintInfo();
            Console.WriteLine(staffInfo);

            Student anilStudent = new Student("anil", new string[] { "Math", "Physics" }, "Science", new double[] { 56.78, 78.90 });
            string anilInfo = anilStudent.PrintInfo();
            Console.WriteLine(anilInfo);

            //when you have not overriden the base class method in the child class
            //1.no upcasting
            //this will call child class method, since the reference variable (sunilProfessor) is of type Professor
            //Professor sunilProfessor = new Professor("sunil", "Physics", "Science", 15, 7);
            //Console.WriteLine(sunilProfessor.PrintInfo());

            //2. upcasting
            //this will call base class method, since the reference variable (sunilProfessor) is of type Person and you have not overriden the
            //Person->PrintInfo methid in the child class
            Person sunilProfessor = new Professor("sunil", "Physics", "Science", 15, 7);
            Console.WriteLine(sunilProfessor.PrintInfo());
        }
    }
}
