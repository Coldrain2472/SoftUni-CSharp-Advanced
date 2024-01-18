SortedDictionary<char, int> charsCount = new SortedDictionary<char, int>();
string input = Console.ReadLine();
foreach (char ch in input)
{
	if (!charsCount.ContainsKey(ch))
	{
		charsCount.Add(ch, 0);
	}
	charsCount[ch]++;
}
foreach (var item in charsCount)
{
    Console.WriteLine($"{item.Key}: {item.Value} time/s");
}