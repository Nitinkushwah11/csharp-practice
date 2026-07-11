namespace KISSPrincipleConcept
{
    using System;

    class Program
    {
        static void Main()
        {
            /*Key Idea
             
                ✅ Write simple and readable code.
                ✅ Avoid unnecessary variables, classes, or logic.
                ✅ Choose the easiest solution that correctly solves the problem.
            */
            /*❌ Without KISS*/
            int a = 10;
            int b = 20;

            int sum = 0;
            sum = a + b;

            Console.WriteLine(sum);

            Console.ReadKey();

            /* ✅ With KISS
            int a = 10;
            int b = 20;
            Console.WriteLine(a + b);
            */


        }
    }
}
