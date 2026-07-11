namespace InterfaceSegregation
{
    
    
        /* A class should not be forced to implement methods that it does not use.
           In simple words:
           Create small and specific interfaces instead of one large interface.
           A class should implement only the methods it actually needs.
        */
 

      // Interface for working
interface IWork
    {
        void Work();
    }

    // Interface for eating
    interface IEat
    {
        void Eat();
    }

    class Human : IWork, IEat
    {
        public void Work()
        {
            Console.WriteLine("Human is working.");
        }

        public void Eat()
        {
            Console.WriteLine("Human is eating.");
        }
    }

    class Robot : IWork
    {
        public void Work()
        {
            Console.WriteLine("Robot is working.");
        }
    }

    class Program
    {
        static void Main()
        {
            Human human = new Human();
            human.Work();
            human.Eat();

            Robot robot = new Robot();
            robot.Work();

            Console.ReadLine(); 
        }
    }
}


/*  ❌ Without ISP (Violates the Principle)
using System;

interface IWorker
{
    void Work();
    void Eat();
}

class Robot : IWorker
{
    public void Work()
    {
        Console.WriteLine("Robot is working.");
    }

    // Robot doesn't eat, but it must implement this method.
    public void Eat()
    {
        throw new NotImplementedException();
    }
}

class Program
{
    static void Main()
    {
        Robot robot = new Robot();
        robot.Work();
    }
}
*/