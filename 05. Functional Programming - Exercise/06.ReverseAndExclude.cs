List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).Reverse().ToList();
int divider = int.Parse(Console.ReadLine());
Func<List<int>, int, List<int>> calculate = (numbers, divider) =>
{
    List<int> result = new List<int>();
    foreach (var number in numbers)
    {
        if (number % divider != 0)
        {
            result.Add(number);
        }
    }
    return result;
};
Console.WriteLine(string.Join(" ", calculate(numbers,divider)));