namespace isANDasOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             The is operator checks if an object is of a specific type 
            and returns a boolean (true or false).The as operator attempts to convert an 
            object to a specified type and returns
            null if the conversion is not possible instead of throwing an exception. */
            /*
             * for is operator understanding
            
            Animal myPet = new Dog();

            if (myPet is Dog)
            {
                Console.WriteLine("myPet is a Dog");
            }
            else
            {
                Console.WriteLine("myPet is NOT a Dog");
            }

            Console.WriteLine("Hello, World!");

            //Pattern Matching 
            object obj = "Hello World";
            if (obj is string message)
            {
                Console.WriteLine($"The message is: {message}");
            }

            */

            Animal1 myPet = new Dog1();

            Dog1 myDog = myPet as Dog1;
            if (myDog != null)
            {
                Console.WriteLine("Successfully cast to Dog.");
            }
            else
            {
                Console.WriteLine("Conversion failed.");
            }




            Console.ReadKey();
        }
    }
}
