int n = int.Parse(Console.ReadLine());
Stack<int> stack = new Stack<int>();
for (int i = 0; i < n; i++)
{
    int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
    
    if (input[0] == 1)
    {
        int number = input[1];
        stack.Push(number);
    }
    else if (input[0] == 2)
    {
        stack.Pop();
    }
    if (stack.Count > 0)
    {
        if (input[0] == 3)
        {
            Console.WriteLine($"{stack.Max()}");
        }
        else if (input[0] == 4) 
        {
            Console.WriteLine($"{stack.Min()}");
        }
    }
}
Console.WriteLine(String.Join(", ", stack));
