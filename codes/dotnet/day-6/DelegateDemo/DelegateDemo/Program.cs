using System;

namespace DelegateDemo
{
    //delegate is used to store address of a function or addresses of more than one function
    //and call the function(s) using the address(s) 
    //declare delegate which signature should match to the signature of the function [ return type and arguments (type, number, position)]
    //delegate <RT of the function> <name-of-delegate>(arguments of the function)
    //argument names need not to be same
    //delegate is a different type like class or interface
    //in this case, CalDel can store address of a function whose return type is void and takes two arguments of int
    delegate void CalDel(int a, int b);

    /*
    class CalDel:Delegate
    {
        System.Reflection.MethodInfo _method;
        object _target;

        public CalDel(object target, System.Reflection.MethodInfo method)
        {
            _target = target;
            _method = method;
        }

        public void Invoke(int a, int b)
        {
            _method.Invoke(_target, new object[] { a, b });
        }
    }
    */

    class Program
    {
        static void Main()
        {
            Calculation calc = new Calculation();
            //calc.Add(10, 20);
            //Calculation.Subtract(10, 2);

            //2. create object of the delegate and pass the reference (name of the function) to the constructor
            //in case of non-static (instance) function, pass function with object reference           
            CalDel calDelAdd = new CalDel(calc.Add);

            //in case of static function, pass function name with class name
            CalDel calDelSub = new CalDel(Calculation.Subtract);


            //3. call function using the address in delegate
            //pass the necessary arguments for the function to the delegate
            calDelAdd(10, 20);
            calDelSub.Invoke(10, 2);
        }
    }
}
