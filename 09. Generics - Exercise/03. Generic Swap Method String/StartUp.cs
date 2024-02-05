using System;
using System.Collections.Generic;
using System.Linq;



List<string> items = new List<string>();
int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    string item = Console.ReadLine();
    items.Add(item);
}

int[] indices = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

Swap(indices[0], indices[1], items);

foreach (var item in items)
{
    Console.WriteLine($"{item.GetType()}: {item}");
}

static void Swap<T>(int firstIndex, int secondIndex, List<T> items)
{
    T word = items[firstIndex];
    items[firstIndex] = items[secondIndex];
    items[secondIndex] = word;
}

