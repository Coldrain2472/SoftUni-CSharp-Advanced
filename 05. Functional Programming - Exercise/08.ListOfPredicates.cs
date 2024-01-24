int end = int.Parse(Console.ReadLine());
int[] dividers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
List<int> validNumbers = new List<int>();
Func<int, int, bool> isDivisibleF = (number1, number2) =>
{
    if (number1 % number2 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
};

for (int i = 1; i <= end; i++) // 1-10
{
    bool isDivisible = true;
    for (int j = 0; j < dividers.Length; j++)
    {
        if (!isDivisibleF(i, dividers[j]))
        {
            isDivisible = false;
            break;
        }
    }
    if (isDivisible)
    {
        validNumbers.Add(i);
    }
}
Console.WriteLine(string.Join(" ", validNumbers));