using System;

namespace CompleteApp
{
    class Program
    {
        static void Main()
        {
            Professor anilProfessor = new Professor("anil", 7);
            Person sunilProfessor = new Professor("Sunil", 4);

            Student rameshStudent = new Student("ramesh", 78);
            Person sureshStudent = new Student("suresh", 87);

            //storing addresses of directly Person (if possible) or Person type object in this array
            Person[] people = new Person[4];
            people[0] = anilProfessor;
            people[1] = sunilProfessor;
            people[2] = rameshStudent;
            people[3] = sureshStudent;

            foreach (Person person in people)
            {
                if (person.IsOutstanding())
                {
                    Console.WriteLine(person.PrintInfo());
                }
            }
        }
    }
}
