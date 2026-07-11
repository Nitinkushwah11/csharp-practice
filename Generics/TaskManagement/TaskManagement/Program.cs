namespace TaskManagement
{

    public interface ITask<TResult>
    {
         TResult Perform();
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            var emailTask = new Emailtask()
            {
                Message = "Hello, this is a test email.",
                Recipient = "example@example.com"
            };

            var reportTask = new ReportTask()
            {
                ReportName = "Annual Report"
            };

            var emailProcessor = new TaskProcessor<Emailtask, string> (emailTask);
            var reportProcessor = new TaskProcessor<ReportTask, string>(reportTask);

            Console.WriteLine(emailProcessor.Execute());
            Console.WriteLine(reportProcessor.Execute());

            Console.ReadKey();

        }
    }
}
