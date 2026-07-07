namespace SealedMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("The animal makes a sound.");
        }
    }

    class Dog : Animal
    {
        public sealed override void MakeSound()
        {
            Console.WriteLine("The dog barks.");
        }
    }

    class Bulldog : Dog
    {
        //public override void MakeSound() {} // ❌ ERROR: Cannot override because it's sealed
    }
}
