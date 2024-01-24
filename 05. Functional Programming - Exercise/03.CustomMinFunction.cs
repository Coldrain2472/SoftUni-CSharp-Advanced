HashSet<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToHashSet();
Func<HashSet<int>, int> smallestNumber = numbers =>
{
    return numbers.Min();
};
Console.WriteLine(smallestNumber(numbers));