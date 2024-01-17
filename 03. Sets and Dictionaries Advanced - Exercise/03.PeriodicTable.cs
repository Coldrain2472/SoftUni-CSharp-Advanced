using System.Linq;

int n = int.Parse(Console.ReadLine());
HashSet<string> chemicalElements = new HashSet<string>();

for (int i = 0; i < n; i++)
{
    string[] element = Console.ReadLine().Split();
	for (int j = 0; j < element.Length; j++)
	{
        chemicalElements.Add(element[j]);

    }
}
chemicalElements = chemicalElements.OrderBy(x => x).ToHashSet();
foreach (var element in chemicalElements)
{
    Console.Write(element + " ");
}
