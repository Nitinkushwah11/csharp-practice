using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibityPrinciple
{
    // Responsible only for saving student data
    class StudentRepository
    {
        public void Save(Student student)
        {
            Console.WriteLine("Student data saved to database.");
        }
    }
}
