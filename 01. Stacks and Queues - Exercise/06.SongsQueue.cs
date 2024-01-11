string[] songs = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
Queue<string> songsQueue = new Queue<string>(songs);

while (songsQueue.Count >= 0)
{
    string[] command = Console.ReadLine().Split();

    if (command[0] == "Play")
    {
        if (songsQueue.Count > 0)
        {
            songsQueue.Dequeue();

            if (songsQueue.Count == 0)
            {
                Console.WriteLine("No more songs!");
                return;
            }
        }
    }
    else if (command[0] == "Add")
    {
        string songName = string.Join(" ", command.Skip(1));

        if (songsQueue.Contains(songName))
        {
            Console.WriteLine($"{songName} is already contained!");
        }
        else
        {
            songsQueue.Enqueue(songName);
        }
    }
    else if (command.Contains("Show"))
    {
        Console.WriteLine(string.Join(", ", songsQueue));
    }
}
