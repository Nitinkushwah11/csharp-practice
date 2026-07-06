namespace SortApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 5, 7, 3, 9 };
            Console.WriteLine("UnSorted List");
            foreach(int num in numbers)
            {
                Console.WriteLine(num);
            }
            numbers.Sort();
            Console.WriteLine("Sorted List");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

            Console.ReadKey();
        }
    }
}
