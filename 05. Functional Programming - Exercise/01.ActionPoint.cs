string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
Action<string[]> print = names => Console.WriteLine(string.Join(Environment.NewLine, names));
print(names);