namespace ClassesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.SetDetails("Denis", "MainStreet 1");

            Customer customer1 = new Customer("Frank");

            Console.WriteLine("Contactnumber of Frank is: " + customer1.ContactNumber);

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
