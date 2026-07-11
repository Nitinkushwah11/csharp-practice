using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    using System;

    class MyClass<T>
    {
        public T Data;

        public void Display()
        {
            Console.WriteLine("Value: " + Data);
        }
    }

   
}
