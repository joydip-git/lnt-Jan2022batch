using System;
using System.Collections.Generic;

namespace Implementation
{
    delegate bool FilterDel(int number);

    class FilterLogic
    {
        public bool IsEven(int num)
        {
            return num % 2 == 0;
        }
        public bool IsOdd(int num)
        {
            return num % 2 != 0 ? true : false;
        }
        public bool IsGreaterThanFive(int num)
        {
            if (num > 5)
                return true;
            else
                return false;
        }
    }
    class Program
    {
        //in order to pass a function as an argument to another function we take help of delegate, where a delegate can store the address of the function and the delegate can be passed from one to another function
        //then in that function call the delegate, which will call the other function using it's address
        static List<int> Filter(List<int> input, FilterDel filterDel)
        {
            List<int> result = new List<int>();
            foreach (int item in input)
            {
                bool isTrue = filterDel(item);
                if (isTrue)
                {
                    result.Add(item);
                }
            }
            return result;
        }
        static void Main()
        {
            List<int> numbers = new List<int> { 1, 4, 2, 5, 3, 7, 8, 6, 0, 9 };

            FilterLogic evenLogic = new FilterLogic();
            FilterDel evenFilterDel = new FilterDel(evenLogic.IsEven);
            FilterDel oddFilterDel = new FilterDel(evenLogic.IsOdd);
            FilterDel isGreaterFilterDel = new FilterDel(evenLogic.IsGreaterThanFive);

            //anonymous method (method without name)
            //anonymous method is called by a delegate always
            //FilterDel isLessThanFiveDel = public bool IsLessThanFive(int num)
            FilterDel isLessThanFiveDel = delegate (int num)
            {
                return num < 5;
            };

            //FilterDel isGreaterThanFourDel = (num) => 
            //{
            //    if (num > 4)
            //        return true;
            //    else
            //        return false;
            //};

            //Lambda Expression (used to write anonymous method)
            FilterDel isGreaterThanFourDel = (num) => num > 4;

            List<int> result = Filter(numbers, isGreaterThanFourDel);
            //List<int> result = Filter(numbers, isLessThanFiveDel);
            //List<int> result = Filter(numbers, isGreaterFilterDel);
            //List<int> result = Filter(numbers, evenFilterDel);
            //List<int> result = Filter(numbers, oddFilterDel);
            foreach (int item in result)
            {
                Console.WriteLine(item);
            }

            MDel mdel = new MDel(M2);
            M1(mdel);
        }

        static void M1(MDel mdel) { }
        static void M2() { }
    }
    delegate void MDel();
}
