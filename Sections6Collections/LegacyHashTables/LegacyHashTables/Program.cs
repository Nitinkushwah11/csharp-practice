using System.Collections;

namespace LegacyHashTables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * A Hashtable is a legacy collection in C# that stores data as key-value pairs.
             Before generics (Dictionary<TKey, TValue>) were introduced in .NET 2.0, 
             Hashtable was commonly used. Today, it's mostly kept for backward compatibility,
             and in new code you should usually use Dictionary<TKey, TValue> instead.
             * */
            Hashtable students = new Hashtable();

            students.Add(101, "John");
            students.Add(102, "Alice");
            students.Add(103, "Bob");

            Console.WriteLine(students[101]);
            
        }
    }
}
