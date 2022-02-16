using System;

namespace FunctionOverriiding
{
    class Program
    {
        static void Main()
        {
            Staff staffObj = new Staff("joydip", "Staff Dept", "D");
            string staffInfo = staffObj.PrintInfo();
            Console.WriteLine(staffInfo);

            Student anilStudent = new Student("anil", new string[] { "Math", "Physics" }, "Science", new double[] { 56.78, 78.90 });
            string anilInfo = anilStudent.PrintInfo();
            Console.WriteLine(anilInfo);

            Professor sunilProfessor = new Professor("sunil", "Physics", "Science", 15, 7);
            Console.WriteLine(sunilProfessor.PrintInfo());
        }
    }
}
