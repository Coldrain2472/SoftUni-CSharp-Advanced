using CustomDoublyLinkedList;

DoublyLinkedList numbers = new DoublyLinkedList();

string command = string.Empty;

while ((command = Console.ReadLine()) != "End")
{
    string[] commandInfo = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

    string typeCommand = commandInfo[0];

    if (typeCommand == "AddFirst")
    {
        int element = int.Parse(commandInfo[1]);
        numbers.AddFirst(element);
    }
    else if (typeCommand == "AddLast")
    {
        int element = int.Parse(commandInfo[1]);
        numbers.AddLast(element);
    }
    else if (typeCommand == "RemoveFirst")
    {
        numbers.RemoveFirst();
    }
    else if (typeCommand == "RemoveLast")
    {
        numbers.RemoveLast();
    }
    else if (typeCommand == "ForEach")
    {
        Func<int, int> action = new Func<int, int>(n => n * 2);
        numbers.ForEach(action);
    }
    else if (typeCommand == "ToArray")
    {
        numbers.ToArray();
    }
}