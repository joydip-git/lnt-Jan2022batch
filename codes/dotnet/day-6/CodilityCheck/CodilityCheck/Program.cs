using System;

namespace CodilityCheck
{
    class Solution
    {
        public int FrogJumpMethod(int X, int Y, int D)
        {
            // int count=0;
            // while(X<Y)
            // {
            //     X+=D;
            //     count++;
            // }
            // return count;
            decimal diff = Y - X;
            decimal count = diff / D;
            return Convert.ToInt32(Math.Ceiling(count));
        }
    }
    class Program
    {
        //static bool DoesHaveZero(string binaryValue)
        //{
        //    bool doesExist = false;
        //    foreach (char ch in binaryValue)
        //    {
        //        if (ch == '0')
        //        {
        //            doesExist = true;
        //            break;
        //        }
        //    }
        //    return doesExist;
        //}

        static void Main(string[] args)
        {
            //string binary = Convert.ToString(15, 2);
            //Console.WriteLine(DoesHaveZero(binary));

            //int sum = 0;
            //for (int i = 1; i < 1000; i++)
            //{
            //    sum += i;
            //}
            //decimal diff = 84-10;
            //decimal count = diff / 30;
            //Console.WriteLine(count);
            //Console.WriteLine(Math.Ceiling(count));
            Console.WriteLine( new Solution().FrogJumpMethod(10,85,30));
        }
    }
}
