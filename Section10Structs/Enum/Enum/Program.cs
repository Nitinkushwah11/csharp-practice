namespace Enum
{
    enum Day { Mo, Tu, We, Th, Fr=16, Sa, Su};
    internal class Program
    {
        static void Main(string[] args)
        {
            Day Ma = Day.Mo;

            Day a = Day.Mo;

            Console.WriteLine(Ma);
            Console.WriteLine(a==Ma);
            Console.WriteLine((int)Day.Fr);

            Console.ReadKey();
        }
    }
}
