Queue<int> time = new Queue<int>(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList());

Stack<int> tasks = new Stack<int>(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList());

Dictionary<string, int> ducksCount = new Dictionary<string, int>()
{
    {"Darth Vader Ducky", 0},
    {"Thor Ducky", 0 },
    {"Big Blue Rubber Ducky", 0 },
    {"Small Yellow Rubber Ducky", 0 }
};

while (time.Any() && tasks.Any())
{
    int sum = time.Peek() * tasks.Peek();

    if (sum >= 0 && sum <= 60)
    {
        ducksCount["Darth Vader Ducky"]++;
        time.Dequeue();
        tasks.Pop();
    }
    else if (sum > 60 && sum <= 120)
    {
        ducksCount["Thor Ducky"]++;
        time.Dequeue();
        tasks.Pop();
    }
    else if (sum > 120 && sum <= 180)
    {
        ducksCount["Big Blue Rubber Ducky"]++;
        time.Dequeue();
        tasks.Pop();
    }
    else if (sum > 180 && sum <= 240)
    {
        ducksCount["Small Yellow Rubber Ducky"]++;
        time.Dequeue();
        tasks.Pop();
    }
    else if (sum > 240)
    {
        int numberToDecrease = tasks.Pop() - 2;
        tasks.Push(numberToDecrease);
        int dequeuedTime = time.Dequeue();
        time.Enqueue(dequeuedTime);
    }
}

Console.WriteLine("Congratulations, all tasks have been completed! Rubber ducks rewarded:");
foreach (var duck in ducksCount)
{
    Console.WriteLine($"{duck.Key}: {duck.Value}");
}
