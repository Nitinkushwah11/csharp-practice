using System.Reflection.Metadata.Ecma335;

namespace Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Count(4));

            Console.ReadKey();
        }

        static int Count(int n)
        {
            
            //if(n==0)
            //{
            //   return 0;
            //}
            
            //return n+Count(n - 1);

            if(n==0 || n==1)
            {
                return 1;
            }


            return n * Count(n - 1);


        }
    }
}
