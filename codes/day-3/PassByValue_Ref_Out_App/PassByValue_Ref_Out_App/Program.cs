using System;

namespace PassByValue_Ref_Out_App
{
    class Program
    {
        /*
        static void Swap(int x, int y)
        {
            //Note: any change in values of x and y will be scoped within swap
            //no effect will take place in a and b, in Main method
            x = 11;
            y = 21;
            Console.WriteLine($"in Swap, x:{x}, y:{y}");
        }
        */
        //the second parameter, y, must be declared also with ref keyword, to accept the reference of b memory block
        static void Swap(int x, ref int y, out int z)
        {
            //Note: any change in value of x will be scoped within swap
            //no effect will take place in a in Main method
            //any change in value of y will be permanent, since you are actually changing the value in b memory block through the reference of b memory as stored in y
            //so, value of b will be changed

            //z, which has been passed by out keyword, MUST be assigned a value before leaving Swap and retruning to Main
            x = 11;
            y = 21;
            z = 31;
            Console.WriteLine($"in Swap, x:{x}, y:{y}, z:{z}");
        }
        static void Main()
        {
            int a = 10;
            int b = 20;
            int c;
            //c = a + b;
            Console.WriteLine($"Before swapping, a:{a}, b:{b}");
            //pass by value: passing copy of values stored in a and b memory blocks (variables) to x and y parameters of Swap
            //Swap(a, b);

            //pass by reference: passing the copy of value in a memory bllock to x parameter and address of b memory block to y parameter of Swap
            //Swap(a, ref b);

            //pass by out
            Swap(a, ref b, out c);
            Console.WriteLine($"After swapping, a:{a}, b:{b}, c:{c}");

            //stiuation:
            //Console.Write("enter your date of birth in [MM/DD/YYYY] format: ");
            //string strDob = Console.ReadLine();
            //DateTime dob = DateTime.Parse(strDob);
            //Console.WriteLine(dob);

            //pass by out example
            Console.Write("enter your date of birth in [MM/DD/YYYY] format: ");
            string strDob = Console.ReadLine();

            DateTime dob;
            
            bool possible = DateTime.TryParse(strDob, out dob);
            if (possible)
                Console.WriteLine(dob);
            else
            {
                Console.WriteLine("not posible to convert");
                Console.WriteLine($"default dob: {dob}");
            }
        }
        //static bool TryParse(string value, out DateTime result)
        //{
        //   bool possible=false;
        //    try
        //    {
        //       result = DateTime.Parse(value);
        //       possible = true;
        //    }
        //    catch(Exception ex)
        //    {
        //        result = new DateTime(1, 1, 1);
        //    }
        //    return possible;
        //}
    }
}
