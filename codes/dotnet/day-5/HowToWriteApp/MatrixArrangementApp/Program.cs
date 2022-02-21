using System;

namespace MatrixArrangementApp
{
    class Program
    {

        static void Main()
        {
            int[,] input = new int[,] { { 4, 2, 13 }, { 3, 8, 5 },{ 9,6,17} };
            int[] result = MatrixArray.ArrangeElements(input);
            foreach (int value in result)
            {
                Console.WriteLine(value);
            }
        }
    }
}
