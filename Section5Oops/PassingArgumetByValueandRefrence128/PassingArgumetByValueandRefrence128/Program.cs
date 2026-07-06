namespace PassingArgumetByValueandRefrence128
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Pass by value
             * 
            int a = 10;
            Update(a);

            static void Update(int a)
            {
                a += 5;
                Console.WriteLine("Inside of the method  a : "  + a);
            }
            Console.WriteLine("Outside of the Method a : "+ a);

            */

            /* Pass by refrence
             * 
            int a = 10;
            Update(ref a);

            static void Update(ref int a)
            {
                a += 5;
                Console.WriteLine("Inside of the method  a : " + a);
            }
            Console.WriteLine("Outside of the Method a : " + a);

            */

            /*  Here value not assign firstly 
             *  we need to assign value inside the method
            int a;
            Update(out a);

            static void Update(out int a)
            {
                a = 5;
                Console.WriteLine("Inside of the method  a : " + a);
            }
            Console.WriteLine("Outside of the Method a : " + a);

           */

            Console.ReadKey();
        }

       
    }
}
