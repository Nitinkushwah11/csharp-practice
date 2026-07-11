using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManagement
{
    public class ReportTask : ITask<string>
    {
        public string ReportName { get; set; }

        public string Perform()
        {
            return $"Report {ReportName} generated successfully.";
        }
    }
}