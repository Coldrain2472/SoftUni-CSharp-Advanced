List<string> invitations = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
string command = string.Empty;
List<string> filters = new List<string>();
while ((command = Console.ReadLine()) != "Print")
{
    string[] commandArr = command.Split(";", StringSplitOptions.RemoveEmptyEntries);
    string commandType = commandArr[0]; // add filter, remove filter, print=end the program
    string filterType = commandArr[1];      // starts with, ends with, length, contains
    string filterParameter = commandArr[2];

    if (commandType == "Add filter")
    {
        filters.Add(filterType + ";" + filterParameter);
    }
    else if (commandType == "Remove filter")
    {
        filters.Remove(filterType + ";" + filterParameter);
    }
}

List<Predicate<string>> filter = new List<Predicate<string>>();
for (int i = 0; i < filters.Count; i++)
{
    string[] filterArray = filters[i].Split(";").ToArray();
    string filterType = filterArray[0];
    string filterParameter = filterArray[1];

    Predicate<string> filterName = name =>
{
    if (filterType == "Starts with")
    {
        return name.StartsWith(filterParameter);
    }
    else if (filterType == "Ends with")
    {
        return name.EndsWith(filterParameter);
    }
    else if (filterType == "Length")
    {
        return name.Length == int.Parse(filterParameter);
    }
    else if (filterType == "Contains")
    {
        return name.Contains(filterParameter);
    }
    return false;
};
    filter.Add(filterName);
}

for (int i = 0; i < invitations.Count; i++)
{
    string currentName = invitations[i];
    bool isValid = true;
    for (int j = 0; j < filter.Count; j++)
    {
        Predicate<string> currentFilter = filter[j];
        if (currentFilter(currentName))
        {
            isValid = false;
            invitations.RemoveAt(i);
            i--;
            break;
        }
    }
}
Console.WriteLine(string.Join(" ", invitations));