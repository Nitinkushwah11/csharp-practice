namespace FindAllPredicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 1, 51, 8, 13, 9, 4, 66, 34 };
            Console.WriteLine("Before");
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
            //Define the predicate to check if a number is grater than 10
            Predicate<int> isGreaterThenTen = x => x > 10;
            List<int> higherTen = list.FindAll(isGreaterThenTen);
                
            Console.WriteLine("After");
            foreach (int i in higherTen)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
