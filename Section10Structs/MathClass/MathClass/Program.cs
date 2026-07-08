namespace MathClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ceiling : " + Math.Ceiling(15.6));
            Console.WriteLine("Floor : " + Math.Floor(15.6));

            int num1 = 13;
            int num2 = 10;

            Console.WriteLine("Lower of num1 {0}  and num2 {1} is {2}", num1,num2,Math.Min(num1,num2));
            Console.WriteLine("Higher of num1 {0} and num2 {1} is {2}",num1 ,num2, Math.Max(num1,num2));
            Console.WriteLine("{0} to the power of {1} is {2}",2,3,Math.Pow(2,3));
            Console.WriteLine(Math.Abs(-34));
            Console.WriteLine(Math.Sqrt(25));

            Console.WriteLine(Math.Cos(45));





            //Console.WriteLine("Hello, World!");
            Console.ReadKey();
        }
    }
}
