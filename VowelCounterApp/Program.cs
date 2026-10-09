using System;
namespace VowelCounterApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Usage: dotnet run <string>");
                return;
            }
            string input = args[0];
            int count = CountVowels(input);
            Console.WriteLine($"Number of vowels in \"{input}\" is: {count}");
        }
        public static int CountVowels(string input)
        {
            if (string.IsNullOrEmpty(input))
                return 0;
            int count = 0;
            string vowels = "aeiouAEIOU";
            foreach (char c in input)
            {
                if (vowels.Contains(c))
                    count++;
            }
            return count;
        }
    }
}