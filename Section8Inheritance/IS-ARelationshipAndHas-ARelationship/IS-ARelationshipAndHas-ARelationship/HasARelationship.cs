using System;
using System.Collections.Generic;
using System.Text;

namespace IS_ARelationshipAndHas_ARelationship
{
    public class Engine
    {
        public void Start()
        {
            Console.WriteLine("Engine started....");
        }
    }

    public class Car
    {
        private Engine engine = new Engine();

        public void CarStarted()
        {
            engine.Start();
            Console.WriteLine("Car started");
        }


    }
}
