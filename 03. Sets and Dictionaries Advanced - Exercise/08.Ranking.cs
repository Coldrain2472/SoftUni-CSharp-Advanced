using System.Linq;

Dictionary<string, string> contestsPasswords = new Dictionary<string, string>();
SortedDictionary<string, Dictionary<string, int>> usernamesStats = new SortedDictionary<string, Dictionary<string, int>>();

string input = string.Empty;
// {contest}:{password for contest}
while ((input = Console.ReadLine()) != "end of contests")
{
    string[] inputArr = input.Split(":", StringSplitOptions.RemoveEmptyEntries);
    string contest = inputArr[0];
    string password = inputArr[1];
    contestsPasswords.Add(contest, password);
}

string command = string.Empty;
// "{contest}=>{password}=>{username}=>{points}"
while ((command = Console.ReadLine()) != "end of submissions")
{
    string[] commandArr = command.Split("=>", StringSplitOptions.RemoveEmptyEntries);
    string contest = commandArr[0];
    string password = commandArr[1];    
    string username = commandArr[2];
    int points = int.Parse(commandArr[3]);
    if (contestsPasswords.ContainsKey(contest))
    {
        if (contestsPasswords[contest] == password)
        {
            if (!usernamesStats.ContainsKey(username))
            {
                usernamesStats.Add(username, new Dictionary<string, int>());
               
            }
            if (usernamesStats[username].ContainsKey(contest))
            {
                if (usernamesStats[username][contest] < points)
                {
                    usernamesStats[username][contest] = points;
                }
            }
            else
            {
                usernamesStats[username].Add(contest, points);
            } 
        }
    }
}

string bestCandidate = usernamesStats.MaxBy(bc => bc.Value.Values.Sum()).Key;
int bestCandidateTotalPoints = usernamesStats[bestCandidate].Values.Sum();

Console.WriteLine($"Best candidate is {bestCandidate} with total {bestCandidateTotalPoints} points.");
Console.WriteLine("Ranking:");
foreach (var username in usernamesStats.OrderBy(u=>u.Key))
{
    Console.WriteLine(username.Key);
    foreach (var participant in username.Value.OrderByDescending(u=>u.Value))
    {
        Console.WriteLine($"#  {participant.Key} -> {participant.Value}");
    }
}