namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            MyClass<int> obj1 = new MyClass<int>();
            obj1.Data = 100;
            obj1.Display();

            MyClass<string> obj2 = new MyClass<string>();
            obj2.Data = "Hello";
            obj2.Display();

            Console.ReadKey();
        }
    }
}
