using System;

namespace AbstractDemo
{
    class Program
    {
        static void Main()
        {
            int a = 10;
            int b = 20;
            int c = a > b ? a : b;
            //(condition)? and some-value:else-value;

            //if you create object of child class, you can store the reference/address of the child class in variable of child class or
            //if you create object of child class, you can store the reference/address of the child class in variable of base class also (up-casting)
            //in case of up-casting, you can access only base class members from child class object, except the overriden members

            Professor anilProfessor = new Professor("anil", 6);
            //you can access both base class member (inherited) as well as child class's own members
            Console.WriteLine(anilProfessor.Bookspublished);
            Console.WriteLine(anilProfessor.IsOutstanding());

            Person sunilProfessor = new Professor("Sunil", 4);
            //you can only access base class members (inherited) in the child class
            Console.WriteLine(sunilProfessor.Name);
            //method from child class will be called, NOT base class (anyway base class method is abstract, none can call that), since it is anyway overriden in the child
            Console.WriteLine(sunilProfessor.IsOutstanding());

            Student rameshStudent = new Student("ramesh", 78);
            Person sureshStudent = new Student("suresh", 87);
        }
    }
}
