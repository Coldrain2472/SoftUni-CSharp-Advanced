Queue<int> coffee = new Queue<int>(Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

Stack<int> milk = new Stack<int>(Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

Dictionary<string, int> drinksCount = new Dictionary<string, int>()
        {
            {"Cortado", 0 },
            {"Espresso", 0 },
            {"Capuccino", 0 },
            {"Americano", 0 },
            {"Latte", 0 }
        };

while (coffee.Any() && milk.Any())
{
    int currentCoffee = coffee.Peek();
    int currentMilk = milk.Peek();
    int result = currentCoffee + currentMilk;

    if (result == 50)
    {
        drinksCount["Cortado"]++;
        coffee.Dequeue();
        milk.Pop();
    }
    else if (result == 75)
    {
        drinksCount["Espresso"]++;
        coffee.Dequeue();
        milk.Pop();
    }
    else if (result == 100)
    {
        drinksCount["Capuccino"]++;
        coffee.Dequeue();
        milk.Pop();
    }
    else if (result == 150)
    {
        drinksCount["Americano"]++;
        coffee.Dequeue();
        milk.Pop();
    }
    else if (result == 200)
    {
        drinksCount["Latte"]++;
        coffee.Dequeue();
        milk.Pop();
    }
    else
    {
        coffee.Dequeue();
        int newMilkValue = milk.Pop() - 5;
        milk.Push(newMilkValue);
    }
}

if (!coffee.Any() && !milk.Any())
{
    Console.WriteLine("Nina is going to win! She used all the coffee and milk!");
}
else
{
    Console.WriteLine("Nina needs to exercise more! She didn't use all the coffee and milk!");
}

if (!coffee.Any())
{
    Console.WriteLine("Coffee left: none");
}
else
{
    Console.Write("Coffee left: ");
    Console.WriteLine(string.Join(", ", coffee));
}

if (!milk.Any())
{
    Console.WriteLine("Milk left: none");
}
else
{
    Console.Write("Milk left: ");
    Console.WriteLine(string.Join(", ", milk));
}

foreach (var item in drinksCount.Where(x => x.Value > 0).OrderBy(x => x.Value).ThenByDescending(x => x.Key))
{
    Console.WriteLine($"{item.Key}: {item.Value}");
}