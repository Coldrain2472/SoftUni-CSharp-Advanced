string input = Console.ReadLine();
Stack<char> inputInfo = new Stack<char>();
foreach (var item in input)
{
    inputInfo.Push(item);
}
while (inputInfo.Count != 0)
{
    Console.Write(inputInfo.Pop());
}