HashSet<string> vip = new HashSet<string>();
HashSet<string> regular = new HashSet<string>();

string command = string.Empty;
int invitedPeople = 0;
int attendees = 0;

while ((command = Console.ReadLine()) != "PARTY")
{
    if (command.Length == 8)
    {
        if (command.StartsWith("1") || command.StartsWith("2") || command.StartsWith("3") ||
            command.StartsWith("4") || command.StartsWith("5") || command.StartsWith("6") ||
            command.StartsWith("7") || command.StartsWith("8") || command.StartsWith("9") || command.StartsWith("0"))
        {
            vip.Add(command);
        }
        else
        {
            regular.Add(command);
        }
    }
    invitedPeople++;
}

while ((command = Console.ReadLine()) != "END")
{
    if (vip.Contains(command))
    {
        vip.Remove(command);

    }
    else
    {
        regular.Remove(command);

    }
    attendees++;
}

Console.WriteLine($"{invitedPeople - attendees}");
foreach (var guest in vip)
{
    Console.WriteLine(guest);
}
foreach (var guests in regular)
{
    Console.WriteLine(guests);
}