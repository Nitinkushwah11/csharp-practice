using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibityPrinciple
{
    // Responsible only for displaying student details
    class StudentPrinter
    {
        public void Print(Student student)
        {
            Console.WriteLine("Name: " + student.Name);
            Console.WriteLine("Roll No: " + student.RollNo);
        }
    }
}
