namespace Nullable161
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? age = null;//int? is an nullable

            if(age.HasValue)
            {
                Console.WriteLine("Age is : "+ age.Value);
            }else
            {
                Console.WriteLine("age value not defined!");
            }

            Console.ReadKey();
        }
    }
}
