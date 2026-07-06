namespace ClassesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Car car2 = new Car();
            Car car3 = new Car("A3", "Audi", false);


            // accessing the public static variable NumberOfCars of the Car Class
            Console.WriteLine("Number of cars produced: " + Car.NumberOfCars);

            Car2 car1 = new Car2();
            Car2 car4 = new Car2();
            Car2.DisplayNumberOfCars();

            int result = Utilities.Add(5, 10); // Output: 15// Output: Total cars: 2
            Console.WriteLine(result);


            Console.ReadKey();

        }
           


        public static class Utilities
        {
            public static int Add(int a, int b)
            {
                return a + b;
            }
        }



        }



    }

