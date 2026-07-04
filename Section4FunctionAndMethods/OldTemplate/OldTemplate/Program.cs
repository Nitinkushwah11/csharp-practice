namespace OldTemplate
{
    internal class Program
    {
        //field (or instance variable) = globle variable
        static int myResult;
        static void Main(string[] args)
        {

            // Methods are structured like this
            // modifier returnType MethodName(Parameters){
            // code block
            // }

            

            int SubtractTwoValues(int value1, int value2)
            {
                int result = (value1 - value2);
                return result;
            }


            Console.WriteLine("Enter a number, I'll add 10 to it!");
            int num1 = int.Parse(Console.ReadLine());

            myResult = AddTwoValues(num1, 10);
            Console.WriteLine("The result is " + myResult);
            Console.ReadKey();


            Console.WriteLine("Hello, World!");
        }

        static int AddTwoValues(int value1, int value2)
        {
            int result = value1 + value2;
            return result;
        }
    }
}
