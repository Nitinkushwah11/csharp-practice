namespace ClassesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //Creating an pbject  of the class Car
            //Creating an instance of the class Car
            Car audi = new Car("A3", "Audi",false);
            Car bmw = new Car("i7","BMW",true);


            Console.WriteLine("Please enter the brand name");
            //Setting Brand
            //audi.Brand = Console.ReadLine();

            //getting Brand
            Console.WriteLine("Brand is " + audi.Brand);
            Console.WriteLine("Brand is " + bmw.Brand);
            Console.ReadKey();
            */

            Customer raj = new Customer("Raj");

            //Console.WriteLine("My name is " + raj.Name);

            //Default customer with No arguments given

            Customer newCustomer = new Customer();
            Console.WriteLine("New Customer Name is : "+ newCustomer.Name);


            
          



            Console.ReadKey();

        }
    }
}
