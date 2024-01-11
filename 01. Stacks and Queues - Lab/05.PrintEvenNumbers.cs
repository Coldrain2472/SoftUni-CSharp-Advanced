int[] numbersInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
Queue<int> numbers = new Queue<int>(numbersInput);
List<int> evenNumbers = new List<int>();

for (int i = 0; i < numbersInput.Length; i++)
{
    int currentNumber = numbers.Dequeue();
    if (currentNumber % 2 == 0)
    {
        evenNumbers.Add(currentNumber);
    }
}
Console.WriteLine(String.Join(", ", evenNumbers));