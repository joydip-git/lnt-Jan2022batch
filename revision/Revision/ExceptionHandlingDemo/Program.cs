using System;

namespace ExceptionHandlingDemo
{
    class Program
    {
        static void Divide()
        {
            int a = 12;
            int b = 0;
            int res = 0;
            try
            {
                res = a / b;                
            }
            catch (DivideByZeroException ex)//ex=d
            {
                throw ex;
            }
            finally
            {
                Console.WriteLine(res);
            }
        }
        static void Main()
        {
            try
            {
                Divide();
            }
            catch (DivideByZeroException ex)//ex=d
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.TargetSite);
                Console.WriteLine(ex.Source);
                Console.WriteLine(ex.StackTrace);
            }
            catch (NullReferenceException ex)
            {

            }
            catch (ArgumentException ex)
            {

            }
            catch (Exception ex)
            {

            }
        }
    }
}
