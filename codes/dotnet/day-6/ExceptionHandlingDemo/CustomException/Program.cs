using System;

namespace CustomException
{
    class Program
    {
        static void Main()
        {
            Application dlApplicationForm = null;

            try
            {
                int x = 10; //x is local to try
                DateTime dob = new DateTime(2010, 4, 14);
                dlApplicationForm = new Application("joy", dob);
            }
            catch (AgeLessThanEighteenException ex)
            {
                int x = 10; //x is local to catch
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
                int x = 10; //x is local to finally
            }
        }
    }
}
