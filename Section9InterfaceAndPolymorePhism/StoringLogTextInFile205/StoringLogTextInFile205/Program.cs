namespace StoringLogTextInFile205
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The @ sign in C# is used to denote a verbatim string literal
            string directoryPath = @"D:\Logs";
            string filePath = Path.Combine(directoryPath, "log.txt");
            string message = "This is a log entry";

            if(!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }else
            {
                Console.WriteLine("It is exits ");
            }
                
            File.AppendAllText(filePath, message);

            //for nomal craeating text file
            //File.AppendAllText("log.txt", "Hello World");
            //Console.WriteLine("Hello, World!");

            Console.ReadKey();
        }
    }
}
