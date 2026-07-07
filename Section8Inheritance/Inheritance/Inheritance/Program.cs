namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();

            dog.Bark();
            dog.Eat();
            Console.ReadKey();
        }
    }
    //Base calss (Super class or Parent Class)
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eating...");
        }
    }
    //the class that inherit the members of the base class
    //child class (Drived class or Subclass)
    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Barking...");
        }
    }
}
