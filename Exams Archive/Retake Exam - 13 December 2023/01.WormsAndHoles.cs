Stack<int> worms = new Stack<int>(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

Queue<int> holes = new Queue<int>(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

int matchesCount = 0;
int wormsCount = worms.Count;
while (worms.Any() && holes.Any())
{
    int wormValue = worms.Peek();
    int holeValue = holes.Peek();

    if (wormValue == holeValue)
    {
        matchesCount++;
        worms.Pop();
        holes.Dequeue();
        continue;
    }
    else
    {
        holes.Dequeue();
        int newWormValue = worms.Peek() - 3;
        worms.Pop();
        worms.Push(newWormValue);
        if (worms.Peek() <= 0)
        {
            worms.Pop();
        }
    }
}

if (matchesCount > 0)
{
    Console.WriteLine($"Matches: {matchesCount}");
}
else
{
    Console.WriteLine("There are no matches.");
}

if (!worms.Any() && matchesCount == wormsCount)
{
    Console.WriteLine("Every worm found a suitable hole!");
}
else if (!worms.Any())
{
    Console.WriteLine("Worms left: none");
}
else
{
     Console.WriteLine($"Worms left: {string.Join(", ", worms)}");
}

if (!holes.Any())
{
    Console.WriteLine("Holes left: none");
}
else
{
    Console.WriteLine($"Holes left: {string.Join(", ", holes)}");
}