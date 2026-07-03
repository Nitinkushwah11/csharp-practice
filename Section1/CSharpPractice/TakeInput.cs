using System;

class TakeInput
{
    public static void Run()
    {
        Console.WriteLine("Enter the name");

        System.String name = Console.ReadLine();
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("My Name is " + name);
    }
}