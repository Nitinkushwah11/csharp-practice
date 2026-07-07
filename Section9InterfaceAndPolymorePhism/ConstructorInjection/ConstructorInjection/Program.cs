namespace ConstructorInjection
{
    public class Hammer
    {
        public void Use()
        {
            Console.WriteLine("Hammering Nails!");
        }
    }

    public class Saw
    {
        public void Use()
        {
            Console.WriteLine("Sawing wood!");
        }
    }

    public class Builder
    {
        private Hammer _hammer;
        private Saw _saw;

        // Constructor Dependency Injection (DI)
        public Builder(Hammer hammer, Saw saw)
        {
            _saw = saw;
            _hammer = hammer;
           
        }

        public void BuildHouse()
        {
            _saw.Use();
            _hammer.Use();
           
            Console.WriteLine("House built");
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Hammer hammer = new Hammer();
            Saw saw = new Saw();
            Builder builder = new Builder(hammer, saw);

            builder.BuildHouse();

            Console.ReadLine();
        }
    }
}
