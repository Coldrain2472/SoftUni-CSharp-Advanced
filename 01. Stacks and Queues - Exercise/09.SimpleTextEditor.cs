int operations = int.Parse(Console.ReadLine());
string text = string.Empty;
Stack<string> states = new Stack<string>();
for (int i = 0; i < operations; i++)
{
    string[] inputCommand = Console.ReadLine().Split();
    if (inputCommand[0] == "1")
    {
        states.Push(text);
        text += inputCommand[1];
        
    }
    else if (inputCommand[0] == "2")
    {
        states.Push(text);
        int count = int.Parse(inputCommand[1]);
        text = text.Substring(0, text.Length - count);
        
    }
    else if (inputCommand[0] == "3")
    {
        int index = int.Parse(inputCommand[1]);
        Console.WriteLine(text[index - 1]);
    }
    else if (inputCommand[0] == "4")
    {
        text = states.Pop();
    }
}
