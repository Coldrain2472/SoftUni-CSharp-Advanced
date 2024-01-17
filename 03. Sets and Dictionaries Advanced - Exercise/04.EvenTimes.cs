int n = int.Parse(Console.ReadLine());
Dictionary<int, int> numbers = new Dictionary<int, int>();

for (int i = 0; i < n; i++)
{
    int currentNumber = int.Parse(Console.ReadLine());

    if (numbers.ContainsKey(currentNumber))
    {
        numbers[currentNumber]++;
    }
    else
    {
        numbers.Add(currentNumber, 1);
    }
}

foreach (var number in numbers)
{
    if (number.Value % 2 == 0)
    {
        Console.WriteLine(number.Key);
        return;
    }
}