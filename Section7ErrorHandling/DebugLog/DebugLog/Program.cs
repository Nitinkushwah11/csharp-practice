using System.Diagnostics;

namespace TryCatchExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            Debug.WriteLine("Main Method is calling....");

            try
            {
                Console.WriteLine("Please enter a number");
                Debug.WriteLine("We are inside the try block....");
                int num1 = int.Parse(Console.ReadLine());
                //int num1 = 0;
                int num2 = 2;
                result = num2 / num1;
            }
            catch (Exception ex)
            {
                
                Console.WriteLine("Error: " + ex.Message);
                Console.WriteLine("Error: " + ex.StackTrace);
                Debug.WriteLine("Now!, We are inside the catch block....");
            }
            finally
            {
                // Code to cleanup or finalize
                // ideal for cleaning up resources,
                // like closing file streams or database connections.
                Debug.WriteLine("Now!, We are inside the finally block....");
                Console.WriteLine("This always executes");
            }
            Debug.WriteLine("......We out of the block....");
            Console.WriteLine("Result: " + result);
            Console.ReadKey();



        }
    }
}
