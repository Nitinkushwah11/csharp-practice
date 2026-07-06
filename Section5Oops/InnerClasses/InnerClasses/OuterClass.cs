using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace InnerClasses
{
    internal class OuterClass
    {
        private string _name = "Hello from OuterClass";

        public class InnerClass
        {
            public void Display()
            {
                Console.WriteLine("Hello from InnerClass");
            }
        }
    }
}
