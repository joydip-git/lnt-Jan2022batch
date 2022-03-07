using System;
using System.Collections.Generic;
using System.Text;

namespace GenericDemo
{
    class Calculation
    {
        //public void Add(int a, int b)
        //{

        //}
        //public void Add(long a, long b)
        //{

        //}
        //public void Add(double a, double b)
        //{

        //}
        //generic method with constraint (where ....)
        //T=> type parameter
        //T:struct=> T should be a value type (int, double, float, char, boolean etc.). It can't be any reference type,such as, string, object, any class, delegate, interface etc.
        //T:class=> T should NOT be a value type (int, double, float, char, boolean etc.). It can be any reference type,such as, string, object, any class, delegate, interface etc.

        //T:Student=> T should NOT be a value type (int, double, float, char, boolean etc.). It can be of type student and its child classes

        //public void Add<T>(T a, T b) where T : struct
        //public void Add<T>(T a, T b) where T : class
        public void Add<T>(T a, T b) where T : Student
        {
            //code
        }
        public void Add<T1, T2>(T1 a, T2 b) where T1:struct where T2 : struct
        {

        }
    }
}
