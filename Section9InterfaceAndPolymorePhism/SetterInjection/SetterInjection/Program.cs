namespace SetterInjection
{
    public class SetterInjection
    {
        static void Main(string[] args)
        {
            Hammer hammer = new Hammer();// create the dependency outside
            Saw saw = new Saw();

            Builder builder = new Builder();
            builder.Hammer = hammer;//Inject Dependencies via Setters
            builder.Saw = saw;

            builder.BuildHouse();

            Console.ReadLine();
        }
    }

    

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
        public Hammer Hammer { get; set; }

        public Saw Saw { get; set; }

        // Settor Dependency Injection (DI)


        public void BuildHouse()
        {
            Saw.Use();
            Hammer.Use();

            Console.WriteLine("House built");
        }
    } 
}
