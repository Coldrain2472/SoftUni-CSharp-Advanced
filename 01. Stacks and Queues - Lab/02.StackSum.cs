int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
Stack<int> stack = new Stack<int>(numbers);

string command = Console.ReadLine().ToLower();
while (command != "end")
{
    string[] commandInfoArr = command.Split();
    string commandInfo = commandInfoArr[0];
    
    if (commandInfo == "add")
    {
        int firstNumber = int.Parse(commandInfoArr[1]);
        int secondNumber = int.Parse(commandInfoArr[2]);
        stack.Push(firstNumber);
        stack.Push(secondNumber);
    }
    else if (commandInfo == "remove")
    {
        int firstNumber = int.Parse(commandInfoArr[1]);
        if (stack.Count >= firstNumber)
        {
            for (int i = 0; i < firstNumber; i++)
            {
                stack.Pop();
            }
        }
    }
    command = Console.ReadLine().ToLower();
}
Console.WriteLine($"Sum: {stack.Sum()}");