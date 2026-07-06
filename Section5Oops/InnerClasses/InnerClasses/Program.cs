namespace InnerClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OuterClass.InnerClass innerClassObject = new OuterClass.InnerClass();
            innerClassObject.Display();

            Console.ReadKey();
        }
    }
}
