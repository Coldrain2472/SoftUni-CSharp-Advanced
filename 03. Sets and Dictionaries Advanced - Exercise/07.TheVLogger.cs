using System.Collections.Immutable;
using System.Diagnostics.Contracts;
using System.Linq;

Dictionary<string, Dictionary<string, HashSet<string>>> vloggers =
    new Dictionary<string, Dictionary<string, HashSet<string>>>();

string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
while (command[0] != "Statistics")
{
    if (command.Contains("joined")) // "{vloggername}" joined The V-Logger 
    {
        string vloggerName = command[0];
        if (!vloggers.ContainsKey(vloggerName))
        {
            vloggers.Add(vloggerName, new Dictionary<string, HashSet<string>>());
            vloggers[vloggerName].Add("followers", new HashSet<string>());
            vloggers[vloggerName].Add("following", new HashSet<string>());
        }
    }
    else if (command.Contains("followed")) // "{vloggername} followed {vloggername}"
    {
        string firstVlogger = command[0];
        string secondVlogger = command[2];
        if (vloggers.ContainsKey(firstVlogger) && vloggers.ContainsKey(secondVlogger) &&
            firstVlogger != secondVlogger)
        {
            vloggers[firstVlogger]["following"].Add(secondVlogger);
            vloggers[secondVlogger]["followers"].Add(firstVlogger);
        }
    }
    command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
}

Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");

Dictionary<string, Dictionary<string, HashSet<string>>> orderedVloggers = vloggers.OrderByDescending(v => v.Value["followers"].Count).
    ThenBy(v => v.Value["following"].Count).ToDictionary(v => v.Key, v => v.Value);

int count = 1;
foreach (var vlogger in orderedVloggers)
{
    Console.WriteLine($"{count}. {vlogger.Key} : {vlogger.Value["followers"].Count} followers, {vlogger.Value["following"].Count} following");
    if (count == 1)
    {
        List<string> orderedFollowers = vlogger.Value["followers"].OrderBy(f => f).ToList();
        foreach (var follower in orderedFollowers)
        {
            Console.WriteLine($"*  {follower}");
        }
    }
    count++;
}