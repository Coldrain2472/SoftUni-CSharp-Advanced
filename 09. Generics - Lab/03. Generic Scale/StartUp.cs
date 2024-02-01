using System;


namespace GenericScale
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            EqualityScale<int> numbers = new EqualityScale<int>(number1, number2);
            if (numbers.AreEqual())
            {
                Console.WriteLine("Numbers are equal");
            }
            else
            {
                Console.WriteLine("Numbers are not equal");
            }

            string word1 = Console.ReadLine();
            string word2 = Console.ReadLine();
            EqualityScale<string> words = new EqualityScale<string>(word1, word2);
            if (words.AreEqual())
            {
                Console.WriteLine("Words are equal");
            }
            else
            {
                Console.WriteLine("Words are not equal");
            }
        }
    }
}
