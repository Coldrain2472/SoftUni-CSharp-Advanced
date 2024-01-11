string command = Console.ReadLine();
Queue<string> customers = new Queue<string>();
int peopleRemaining = 0;
while (command != "End")
{
    peopleRemaining++;
    if (command != "Paid")
    {
        customers.Enqueue(command);
    }
    else if (command == "Paid")
    {
        while (customers.Count > 0)
        {
            Console.WriteLine(customers.Dequeue());
        }
        peopleRemaining = 0;
    }

    command = Console.ReadLine();
}
Console.WriteLine($"{peopleRemaining} people remaining.");