using System.Linq;

SortedDictionary<string, int> participantsPoints = new SortedDictionary<string, int>();
SortedDictionary<string, int> languagesSubmissions = new SortedDictionary<string, int>();

string input = string.Empty;

while ((input = Console.ReadLine()) != "exam finished")
{
    string[] command = input.Split('-', StringSplitOptions.RemoveEmptyEntries);
    // "{username}-banned"
    if (command[1] == "banned")
    {
        string username = command[0];
        participantsPoints.Remove(username);
    }
    else
    {
        // "{username}-{language}-{points}"
        string username = command[0];
        string language = command[1];
        int points = int.Parse(command[2]);
        int submissionCounts = 0;
        if (!participantsPoints.ContainsKey(username))
        {
            participantsPoints.Add(username, points);
        }
        else // participantsPoints.ContainsKey(username)
        {
            if (participantsPoints[username] < points)
            {
                participantsPoints[username] = points;
            }
        }
        if (languagesSubmissions.ContainsKey(language))
        {
            languagesSubmissions[language] += 1;
        }
        else
        {
            languagesSubmissions.Add(language, 1);
        }
       
        submissionCounts++;
    }
}

Console.WriteLine("Results:");
foreach (var participant in participantsPoints.OrderByDescending(pp => pp.Value))
{
    Console.WriteLine($"{participant.Key} | {participant.Value}");
}
Console.WriteLine("Submissions:");
foreach (var language in languagesSubmissions.OrderByDescending(ls => ls.Value))
{
    Console.WriteLine($"{language.Key} - {language.Value}");
}
