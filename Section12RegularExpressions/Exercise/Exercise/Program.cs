using System;
using System.Text.RegularExpressions;

namespace ExerciseRunner
{
    public class Exercise
    {
        public void ExtractPatterns(string input)
        {
            string pattern = @"[a-zA-Z0-9._]+@[a-zA-Z]+\.[a-zA-Z]+";

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Exercise exercise = new Exercise();

            string text = "Contact us at support@example.com or sales@example.org.";

            exercise.ExtractPatterns(text);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}