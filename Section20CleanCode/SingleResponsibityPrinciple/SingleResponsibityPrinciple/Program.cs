using SingleResponsibityPrinciple;
using System;


class Program
{
        /*Why is this SRP?
          Student → Stores student information.
          StudentPrinter → Only displays student details.
          StudentRepository → Only saves student data.

          Each class has one responsibility, making the code easier to understand, test, and maintain.

          Interview Answer (One Line):
          The Single Responsibility Principle (SRP) states that a class should
          have only one responsibility and only one reason to change.
     */
    static void Main()
    {
        /* ✅ With SRP (Each class has one responsibility) */
        Student student = new Student();

        StudentPrinter printer = new StudentPrinter();
        printer.Print(student);

        StudentRepository repository = new StudentRepository();
        repository.Save(student);

        Console.ReadLine();
    }
}

/*  ❌ Without SRP (One class doing multiple jobs)
class Student
{
    // Display student details
    public void DisplayDetails()
    {
        Console.WriteLine("Name: Nitin");
        Console.WriteLine("Roll No: 101");
    }

    // Save student data
    public void SaveToDatabase()
    {
        Console.WriteLine("Student data saved to database.");
    }
}

class Program
{
    static void Main()
    {
        Student student = new Student();

        student.DisplayDetails();
        student.SaveToDatabase();


        Console.ReadLine();
    }
}

*/