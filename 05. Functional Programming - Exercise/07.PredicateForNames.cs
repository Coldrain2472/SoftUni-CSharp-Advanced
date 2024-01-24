int length = int.Parse(Console.ReadLine());
List<string> names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
Predicate<string> nameChecker = name => name.Length <= length;
List<string> validNames = new List<string>();
for (int i = 0; i < names.Count; i++)
{
	if (nameChecker(names[i]) == true)
	{
		validNames.Add(names[i]);
	}
}
Console.WriteLine(string.Join(Environment.NewLine, validNames));