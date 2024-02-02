Queue<int> textiles = new Queue<int>(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

Stack<int> medicaments = new Stack<int>(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

Dictionary<int, string> healingItemsTable = new Dictionary<int, string>()
{
    {30, "Patch"},
    {40, "Bandage"},
    {100, "MedKit"}
};

Dictionary<string, int> healingItemsAndCount = new Dictionary<string, int>();

while (textiles.Any() && medicaments.Any())
{
    int resources = textiles.Peek() + medicaments.Peek();

    if (healingItemsTable.ContainsKey(resources))
    {
        if (healingItemsAndCount.ContainsKey(healingItemsTable[resources]))
        {
            healingItemsAndCount[healingItemsTable[resources]] += 1;
        }
        else
        {
            healingItemsAndCount.Add(healingItemsTable[resources], 1);
        }

        textiles.Dequeue();
        medicaments.Pop();
    }
    else if (resources > 100)
    {
        if (healingItemsAndCount.ContainsKey("MedKit"))
        {
            healingItemsAndCount["MedKit"] += 1;
        }
        else
        {
            healingItemsAndCount.Add("MedKit", 1);
        }

        int remainingValue = resources - 100;
        textiles.Dequeue();
        medicaments.Pop();

        int valueToAdd = medicaments.Peek() + remainingValue;
        medicaments.Pop();
        medicaments.Push(valueToAdd);
    }
    else
    {
        textiles.Dequeue();
        int valueToAdd = medicaments.Peek() + 10;
        medicaments.Pop();
        medicaments.Push(valueToAdd);
    }
}

if (!textiles.Any() && !medicaments.Any())
{
    Console.WriteLine("Textiles and medicaments are both empty.");
}
else if (!textiles.Any())
{
    Console.WriteLine("Textiles are empty.");
}
else if (!medicaments.Any())
{
    Console.WriteLine("Medicaments are empty.");
}

if (healingItemsAndCount.Any())
{
    foreach (var item in healingItemsAndCount.OrderByDescending(i => i.Value).ThenBy(i => i.Key))
    {
        Console.WriteLine($"{item.Key} - {item.Value}");
    }
}

if (medicaments.Any())
{
    Console.Write("Medicaments left: ");
    Console.WriteLine(string.Join(", ", medicaments));
}
if (textiles.Any())
{
    Console.Write("Textiles left: ");
    Console.WriteLine(string.Join(", ", textiles));
}