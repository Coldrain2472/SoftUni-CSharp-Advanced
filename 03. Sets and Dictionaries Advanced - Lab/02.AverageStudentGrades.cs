using System.Diagnostics;
using System.Linq;

int number = int.Parse(Console.ReadLine());
Dictionary<string, List<decimal>> nameAndGrade = new Dictionary<string, List<decimal>>();
for (int i = 0; i < number; i++)
{
    string[] input = Console.ReadLine().Split();
    string name = input[0];
    decimal grade = decimal.Parse(input[1]);
    if (!nameAndGrade.ContainsKey(name))
    {
        nameAndGrade.Add(name, new List<decimal>());
    }
    nameAndGrade[name].Add(grade);
}
foreach (var student in nameAndGrade)
{
    Console.Write($"{student.Key} -> ");

    for (int i = 0; i < student.Value.Count; i++)
    {
        Console.Write($"{student.Value[i]:f2} ");
    }

    Console.WriteLine($"(avg: {student.Value.Average():f2})");
}