namespace MethodHiding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Animal myAnimal = new Animal();
            //myAnimal.Speak();  // Output: The animal makes a sound.

            //Dog myDog = new Dog();
            //myDog.Speak();  // Output: The dog barks.


            Animal myPet = new Dog();
            myPet.Speak();  // Output: The animal makes a sound.
            //Here, myPet.Speak() calls the base class method
            //because Method Hiding does not support polymorphism.

            Console.ReadKey();


        }
    }

    class Animal
    {
        public void Speak()
        {
            Console.WriteLine("The animal makes a sound.");
        }
    }

    class Dog : Animal
    {
        public new void Speak()
        {
            Console.WriteLine("The dog barks.");
        }
    }
}
