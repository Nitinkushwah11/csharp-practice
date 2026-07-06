using System;
using System.Collections.Generic;
using System.Text;

namespace PartialClasses
{
    public partial  class Employee
    {
        public string JobTitle { get; set; }
        public double Salary { get; set; }
    }


    //for partial Method
    public partial class Employee
    {
        // Declaration of a partial method
        partial void OnJobAssigned();
    }

    public partial class Employee
    {
        // Optional implementation of the partial method
        partial void OnJobAssigned()
        {
            Console.WriteLine("A new job has been assigned.");
        }
    }

    public partial class Employee
    {
        public void AssignJob(string jobTitle)
        {
            this.JobTitle = jobTitle;
            OnJobAssigned(); // Call the partial method
        }
    }
}
