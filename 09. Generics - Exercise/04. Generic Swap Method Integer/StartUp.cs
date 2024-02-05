List<int> items = new List<int>();

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    items.Add(int.Parse(Console.ReadLine()));
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

static void Swap<T> (int firstIndex, int secondIndex, List<T> items)
{
    T word = items[firstIndex];
    items[firstIndex] = items[secondIndex];
    items[secondIndex] = word;
}