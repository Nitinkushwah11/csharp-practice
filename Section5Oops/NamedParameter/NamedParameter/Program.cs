namespace NamedParameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AddTwoNumbers(10,20));
            Console.WriteLine(AddTwoNumbers(firstNumber: 10,secondNumber: 20));
            Console.WriteLine(AddTwoNumbers(10, secondNumber: 20));

            Console.ReadKey();
        }

        public static int AddTwoNumbers(int firstNumber,int secondNumber) 
            {
                return firstNumber + secondNumber;
            }
    }
}
