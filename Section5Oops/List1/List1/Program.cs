namespace List1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declearing and initializing the list
                List<string> list = new List<string>();
            list.Add("Apple");
            list.Add("banana");
            list.Add("Orange");
            //list.Remove("Orange");
            list.Add("Apple");

            //another way to represent a list
            List<int> l = [1, 4, 6, 8, 4];
            foreach(int a in l)
            {
                Console.WriteLine(a);
            }
            bool isDeleted = list.Remove("Apple");

            // for deleting the all the apple from the list
            while(isDeleted)
            {
                isDeleted = list.Remove("Apple");
            }
            //read all the element 
            foreach(string item in list)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
