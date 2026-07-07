namespace InterfaceApp
{

    public interface IAnimal
    {
        void MakeSound();

        void Eat(string food);
    }

    public class Dog : IAnimal
    {
        public void Eat(string food)
        {
            Console.WriteLine("Treat");
        }

        public void MakeSound()
        {
            Console.WriteLine("Every animal makes sound..");
        }
    }

    public class Cat : IAnimal
    {
        public void Eat(string food)
        {
            Console.WriteLine("Cat Eats " + food);
        }

        public void MakeSound()
        {
            Console.WriteLine("Meou");
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                IAnimal animal = new Dog();
                Dog dog = new Dog();
                animal.MakeSound();
                animal.Eat("Treat");

                Console.ReadKey();
            }
        }
    }
}
