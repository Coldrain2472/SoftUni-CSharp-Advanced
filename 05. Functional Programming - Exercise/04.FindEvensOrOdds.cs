int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
Predicate<int> isOdd = numbers => numbers % 2 != 0;
Predicate<int> isEven = numbers => numbers % 2 == 0;
int start = numbers[0];
int end = numbers[1];
string command = Console.ReadLine();
for (int i = start; i <= end; i++)
{
    if (command == "odd")
    {
        if (isOdd(i))
        {
            Console.Write(string.Join(" ", i + " "));
        }
    }
    else // even
    {
        if (isEven(i))
        {
            Console.Write(string.Join(" ", i + " "));
        }
    }
}