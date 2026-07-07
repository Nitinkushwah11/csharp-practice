using System;
using System.Collections.Generic;
using System.Text;

namespace IS_ARelationshipAndHas_ARelationship
{
    public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eating....");
        }
    }

    public class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("barking...");
        }
    }
}
