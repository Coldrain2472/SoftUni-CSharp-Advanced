using System.Linq;

SortedDictionary<string, SortedSet<string>> sideUsers = new SortedDictionary<string, SortedSet<string>>();

string command = string.Empty;
while ((command = Console.ReadLine()) != "Lumpawaroo")
{
    if (command.Contains('|')) // {forceSide} | {forceUser}
    {
        string[] commandArr = command.Split(" | ", StringSplitOptions.RemoveEmptyEntries);

        string side = commandArr[0];
        string user = commandArr[1];

        if (!sideUsers.Values.Any(u => u.Contains(user)))
        {
            if (!sideUsers.ContainsKey(side))
            {
                sideUsers.Add(side, new SortedSet<string>());
            }

            sideUsers[side].Add(user);
        }
    }
    else // {forceUser} -> {forceSide}
    {
        string[] commandArr = command.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
        string user = commandArr[0];
        string side = commandArr[1];
        foreach (var sideUser in sideUsers)
        {
            if (sideUser.Value.Contains(user))
            {
                sideUser.Value.Remove(user);
                break;
            }
        }
        if (!sideUsers.ContainsKey(side))
        {
            sideUsers.Add(side, new SortedSet<string>());
        }
        sideUsers[side].Add(user);
        Console.WriteLine($"{user} joins the {side} side!");
    }
}
foreach (var users in sideUsers.OrderByDescending(su => su.Value.Count))
{
    if (users.Value.Count == 0)
    {
        break;
    }
    else 
    {
        Console.WriteLine($"Side: {users.Key}, Members: {users.Value.Count}");
        foreach (var user in users.Value)
        {
            Console.WriteLine($"! {user}");
        }
    }
}