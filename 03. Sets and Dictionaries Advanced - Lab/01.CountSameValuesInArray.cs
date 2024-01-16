double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();

Dictionary<double, int> occurences = new Dictionary<double, int>();

foreach (var number in input)
{
	if (!occurences.ContainsKey(number))
	{
        occurences.Add(number, 0);
    }
    occurences[number]++;
}

foreach (var occurence in occurences)
{
    Console.WriteLine($"{occurence.Key} - {occurence.Value} times");
}