class Program
{
    static void Main()
    {
        Vector v1 = new Vector(3, 5);
        Vector v2 = new Vector(7, 2);
        Vector result = v1 + v2;

        result.Display(); // Output: Vector: (10, 7)

        Console.ReadKey();
    }
}
