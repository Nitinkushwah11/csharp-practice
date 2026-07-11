namespace DRYCodeUnderstanding
{
    using System;

    class Program
    {
        static void Main()
        {
            // Print greeting three times
            PrintGreeting();
            PrintGreeting();
            PrintGreeting();
        }

        // Method to print a greeting message
        static void PrintGreeting()
        {
            Console.WriteLine("Welcome to C#");
        }

        /*Why is this DRY?

        ❌ Without DRY:

        Console.WriteLine("Welcome to C#");
        Console.WriteLine("Welcome to C#");
        Console.WriteLine("Welcome to C#");

        ✅ With DRY:

        PrintGreeting();
        PrintGreeting();
        PrintGreeting();

        Simple Rules for DRY
        Write the same code only once.
        Use methods (functions) for repeated tasks.
        Reuse methods whenever needed.
        This makes your code easier to read, update, and maintain.
        */
    }
}
