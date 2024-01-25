int expectedSum = int.Parse(Console.ReadLine());
string[] inputNames = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
foreach (var name in inputNames)
{
    Func<string, int, bool> isValidName = (name, nameLength) =>
    {
        int sum = 0;
        for (int i = 0; i < nameLength; i++)
        {
            sum += name[i];
        }
        return sum >= expectedSum;
    };
    if (isValidName(name,name.Length))
    {
        Console.WriteLine(name);
        return;
    }
}