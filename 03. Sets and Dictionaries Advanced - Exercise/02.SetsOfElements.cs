HashSet<int> nSet = new HashSet<int>();
HashSet<int> mSet = new HashSet<int>();

int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
int n = input[0];
int m = input[1];

for (int i = 0; i < n; i++)
{
    int number = int.Parse(Console.ReadLine());
    nSet.Add(number);
}
for (int i = 0; i < m; i++)
{
    int number = int.Parse(Console.ReadLine());
    mSet.Add(number);

}
foreach (var number in nSet)
{
    if (mSet.Contains(number))
    {
        Console.Write(number + " ");
    }
}
