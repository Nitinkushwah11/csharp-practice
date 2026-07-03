// Console.WriteLine("Hello, World!");
using System;
using System.Threading.Channels;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Nitin Kushwah.....");
        // Console.WriteLine("!00 doller");
        // TakeInput.Run();

        int a = 3;
        int b = 1;
        int temp = a;
        a=b;
        b=temp;
        // Console.WriteLine(" a "+ a +" b " + b);
        // Introduction.Print();

        //Celsius 0C fahrenheit 32f  
        //f = (c*9/5+32)

        Console.WriteLine("Enter the Temparature in Celsius ");
        double c = 25;

        double f = (c*9/5)+32;
        Console.WriteLine(f);
    }
}