List<string> people = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
string command = string.Empty;
while ((command = Console.ReadLine()) != "Party!")
{
    string[] commandArr = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string commandType = commandArr[0];
    string commandCriteria = commandArr[1];

    Predicate<string> name = name =>
    {
        if (commandCriteria == "StartsWith")
        {
            return name.StartsWith(commandArr[2]);
        }
        else if (commandCriteria == "EndsWith")
        {
            return name.EndsWith(commandArr[2]);
        }
        else if (commandCriteria == "Length")
        {
            return name.Length == int.Parse(commandArr[2]);
        }
        return false;
    };

    if (commandType == "Double")
    {
        for (int i = 0; i < people.Count; i++)
        {
            if (name(people[i]))
            {
                people.Insert(i, people[i]);
                i++;
            }
        }
    }
    else if (commandType == "Remove")
    {
        for (int i = 0; i < people.Count; i++)
        {
            if (name(people[i]))
            {
                people.Remove(people[i]);
                i--;
            }
        }
    }

}

if (people.Count > 0)
{
    Console.Write(string.Join(", ", people));
    Console.Write(" are going to the party!");
}
else
{
    Console.WriteLine("Nobody is going to the party!");
}