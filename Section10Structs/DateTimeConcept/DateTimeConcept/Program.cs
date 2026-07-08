namespace DateTimeConcept
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DateTime dateTime = new DateTime(2025,5,6);
            //DateTime dateTime = new DateTime();
            Console.WriteLine("My birthday is  {0}",dateTime);
            Console.WriteLine(DateTime.Today);
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(GetTomorrow()); 
           
            Console.ReadLine();
        }

        static DateTime GetTomorrow()
        {
            return DateTime.Today.AddDays(1);
        }
    }
}
