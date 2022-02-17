using System;

namespace ExceptionHandlingDemo
{
    class Program
    {
        static int Divide()
        {
            int a = 10;
            int b = 0;
            int res = 0;

            //public void Try()
            try
            {
                res = a / b;
            }           
            catch (DivideByZeroException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return res;
        }
        static void Main()
        {
            try
            {
                Divide();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Message: {ex.Message}");
                Console.WriteLine($"Method: {ex.TargetSite}");
                Console.WriteLine($"Source: {ex.Source}");
                Console.WriteLine($"Details: {ex.StackTrace}");
            }
            /*
            //A obj = new B();
            int a = 10;
            int b = 0;
            int res = 0;

            //public void Try()
            try
            {
                res = a / b;                
            }
            //public void Catch(Exception ex)
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Message: {ex.Message}");
                Console.WriteLine($"Method: {ex.TargetSite}");
                Console.WriteLine($"Source: {ex.Source}");
                Console.WriteLine($"Details: {ex.StackTrace}");
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Message: {ex.Message}");
                Console.WriteLine($"Method: {ex.TargetSite}");
                Console.WriteLine($"Source: {ex.Source}");
                Console.WriteLine($"Details: {ex.StackTrace}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Message: {ex.Message}");
                Console.WriteLine($"Method: {ex.TargetSite}");
                Console.WriteLine($"Source: {ex.Source}");
                Console.WriteLine($"Details: {ex.StackTrace}");
            }
            finally
            {
                Console.WriteLine(res);
            }
            */

        }
    }
}
