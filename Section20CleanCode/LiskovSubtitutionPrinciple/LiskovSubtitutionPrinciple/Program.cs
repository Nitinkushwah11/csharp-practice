namespace LiskovSubtitutionPrinciple
{

    using System;

    class Bird
    {
        public void Eat()
        {
            Console.WriteLine("Bird is eating");
        }
    }

    class FlyingBird : Bird
    {
        public void Fly()
        {
            Console.WriteLine("Flying...");
        }
    }

    class Sparrow : FlyingBird
    {
    }

    class Penguin : Bird
    {
        public void Swim()
        {
            Console.WriteLine("Swimming...");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
