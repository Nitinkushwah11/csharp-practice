public class Car2
{
    public static int NumberOfCars = 0;

    public Car2()
    {
        // Increment the static field value by one each time a new Car object is created.
        NumberOfCars++;
    }

    public static void DisplayNumberOfCars()
    {
        Console.WriteLine($"Total cars: {NumberOfCars}");
    }
}