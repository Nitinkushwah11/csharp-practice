using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManagement
{
    internal class Emailtask : ITask<string>
    {

        public string Message { get; set; }

        public string Recipient {  get; set; }
        public string Perform()
        {
            return $"Email sent to {Recipient} with message {Message}";
        }
    }
}
