int[] parameters = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
int inputLength = parameters[0];
int specialNum = parameters[2];
if (inputLength == input.Length)
{
    Queue<int> numbers = new Queue<int>(input);
	for (int i = 0; i < parameters[1]; i++)
	{
		numbers.Dequeue();
	}
	if (numbers.Count > 0)
	{
		if (numbers.Contains(specialNum))
		{
            Console.WriteLine("true");
        }
		else
		{
            Console.WriteLine(numbers.Min());
        }
	}
	else
	{
        Console.WriteLine("0");
    }
}