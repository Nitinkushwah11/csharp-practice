using System.Collections;
namespace LegacyArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaring an arraylist with undefined amount of time
            ArrayList list = new ArrayList();

            ArrayList List1 = new ArrayList(100);


            list.Add(10);
            list.Add("Rahul");
            list.Add(90);
            list.Add("A");
            list.Add(4.56);

            //Delete element with specific value from the arrayList
            list.Remove("Rahul");

            //delete element and specific possition
            list.RemoveAt(0);

            Console.WriteLine("Count the element in the arrayList " + list.Count);
             
            double sum = 0;

            foreach(object obj in list)
            {
                if(obj is int)
                {
                    sum += Convert.ToDouble(obj);
                }else if(obj is double)
                {
                    sum += (double)obj;
                }else if(obj is string)
                    {
                    Console.WriteLine(obj);
                }
                Console.WriteLine(obj);
            }




            Console.WriteLine("Sum " + sum);

            Console.ReadKey();
        }
    }
}
