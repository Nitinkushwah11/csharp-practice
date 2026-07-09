namespace DelegatesUnderstanding
{
    // 1. Declaration:
    // we can declear the delegate outside of the class as well.
    public delegate void Notify(string message);
    internal class Program
    {
        // 1. Declaration:
        public delegate void Notify(string message);
        static void Main(string[] args)
        {
            // Delegates define a method signature,
            // and any method assigned to a del]egate must match this signature.


            // 2. Instantiation:
            Notify notifyDelegate = ShowMessage;
            //Notify notifyDelegate1 = new Notify(ShowMessage);

            // 3. Invocation
            notifyDelegate("Hello, Delegates!");


            Console.ReadKey();
        }

        static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
