using System;

namespace InheritanceDemo
{
    class Program
    {
        static void Main()
        {
            int x = 10;
            Staff joydipStaff = null;
            // joydipStaff = new Staff();
            joydipStaff = new Staff("joy", "janitor", "D");
            //joydipStaff.name = "joy";

            string[] anilSubjects = new string[] { "Math", "Physics" };
            double[] anilMarks = new double[] { 78.9, 98.7 };
            Student anilStudent = new Student("anil", anilSubjects, "Science", anilMarks);

            Professor sunilProfessor = new Professor("sunil", "Physics", "Science", 15, 7);
        }
    }
}
