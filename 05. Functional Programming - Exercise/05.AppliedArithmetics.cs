List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
string command = string.Empty;
Func<string, List<int>, List<int>> calculatedNumbers = (command, numbers) =>
{
    List<int> result = new List<int>();
	foreach (var number in numbers)
	{
        if (command == "add")
        {
            result.Add(number+1);
        }
        else if (command == "multiply")
        {
            result.Add(number * 2);
        }
        else if (command == "subtract")
        {
            result.Add(number - 1);
        }
    }
    return result;
};
Action<List<int>> printer = numbers => Console.WriteLine(string.Join(" ", numbers));
while ((command = Console.ReadLine()) != "end")
{
    if (command == "print")
    {
        printer(numbers);
    }
    else
    {
        numbers = calculatedNumbers(command, numbers);
    }
}