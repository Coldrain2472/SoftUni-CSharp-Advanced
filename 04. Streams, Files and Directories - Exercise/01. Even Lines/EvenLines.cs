namespace EvenLines
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath)); // .Reverse()
        }

        public static string ProcessLines(string inputFilePath)
        {
            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                StringBuilder text = new StringBuilder();
                int count = 0;
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (count % 2 == 0)
                    {
                        string replacedSymbols = ReplaceSymbols(line);
                        string reversedWords = ReverseWords(replacedSymbols);
                        text.AppendLine(reversedWords);
                    }
                    count++;
                }
                return text.ToString().TrimEnd();
            }
        }
        public static string ReplaceSymbols(string line)
        {
            StringBuilder symbols = new StringBuilder(line);
            char[] symbolsToReplace = { '-', ',', '.', '!', '?' };
            foreach (var symbol in symbolsToReplace)
            {
                symbols = symbols.Replace(symbol, '@');
            }

            return symbols.ToString();
        }
        public static string ReverseWords(string words)
        {
            string[] reversedWords = words.Split(" ", StringSplitOptions.RemoveEmptyEntries).Reverse().ToArray();
            return string.Join(" ", reversedWords);
        }
    }
}
