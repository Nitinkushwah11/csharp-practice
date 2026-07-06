namespace PartialClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FirstName = "John";
            employee.LastName = "Sinha";
            employee.JobTitle = "Software Engineer";
            employee.Salary = 40000;

            Console.WriteLine($"{employee.FirstName} {employee.LastName} works as a {employee.JobTitle} with a salary of {employee.Salary}");


            Console.ReadKey();
        }
    }
}
