namespace MyCustomComparator
{
    public class StartUp
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

            Array.Sort(numbers, new CustomComparator());

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}