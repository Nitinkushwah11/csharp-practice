namespace ClassesApp
{
    // Access Modifier internal
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            Customer customer2 = new Customer("John Doe");
            Customer customer3 = new Customer();

            customer1.GetDetails();
            customer2.GetDetails();

            customer3.Password = "120983qweriuh$%";

            customer3.GetDetails();


            Console.ReadKey();
        }



    }
}
