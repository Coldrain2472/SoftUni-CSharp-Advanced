using System.Collections.Generic;
using System;

Queue<int> tools = new Queue<int>(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray());

Stack<int> substances = new Stack<int>(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray());

List<int> challenges = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();

while (tools.Any() && substances.Any() && challenges.Count > 0)
{
    int result = tools.Peek() * substances.Peek();
    if (challenges.Contains(result))
    {
        tools.Dequeue();
        substances.Pop();
        challenges.Remove(result);

    }
    else // the challenge is NOT resolved
    {
        int newTool = tools.Dequeue() + 1;
        tools.Enqueue(newTool);
        int newSubstance = substances.Pop() - 1;
        if (newSubstance > 0)
        {
            substances.Push(newSubstance);
        }
    }
}

if (challenges.Count > 0)
{
    Console.WriteLine("Harry is lost in the temple. Oblivion awaits him.");
}
else
{
    Console.WriteLine("Harry found an ostracon, which is dated to the 6th century BCE.");

}

if (tools.Any())
{
    Console.Write("Tools: ");
    Console.WriteLine(string.Join(", ", tools));
}
if (substances.Any())
{
    Console.Write("Substances: ");
    Console.WriteLine(string.Join(", ", substances));
}

if (challenges.Count > 0)
{
    Console.Write("Challenges: ");
    Console.WriteLine(string.Join(", ", challenges));
}