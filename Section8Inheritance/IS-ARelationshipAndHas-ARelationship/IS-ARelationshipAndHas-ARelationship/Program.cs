namespace IS_ARelationshipAndHas_ARelationship
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Dog dog = new Dog();
            dog.Bark();
            dog.Eat();

            Car car = new Car();
            car.CarStarted();

            Console.ReadKey();
        }
    }
}
