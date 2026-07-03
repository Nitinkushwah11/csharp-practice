using System;

class Introduction
{
    public static void Print()
    {
        //ReadLine Always takes strings
        Console.WriteLine("Enter the Name : ");
        String name = Console.ReadLine();
        Console.WriteLine("Enter the Number");
        int age  = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("My name is "+ name + " and Age "+ age);
    }
}