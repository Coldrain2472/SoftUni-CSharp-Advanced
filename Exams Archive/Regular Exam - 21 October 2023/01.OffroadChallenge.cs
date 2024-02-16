using System.Security.Cryptography;

Stack<int> fuel = new Stack<int>(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

Queue<int> consumption = new Queue<int>(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

Queue<int> requiredFuel = new Queue<int>(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

int count = 0;
List<int> reachedAltitudes = new List<int>();
bool hasReachedAny = false;
while (true)
{
    int result = fuel.Peek() - consumption.Peek();
    count++;

    if (result >= requiredFuel.Peek())
    {
        fuel.Pop();
        consumption.Dequeue();
        requiredFuel.Dequeue();
        Console.WriteLine($"John has reached: Altitude {count}");
        hasReachedAny = true;
    }
    else
    {
        Console.WriteLine($"John did not reach: Altitude {count}");
        Console.WriteLine("John failed to reach the top.");
        if (hasReachedAny)
        {
            Console.Write("Reached altitudes: ");

            List<string> altitudes = new List<string>();

            for (int i = 1; i < count; i++)
            {
                altitudes.Add($"Altitude {i}");
            }

            Console.WriteLine(string.Join(", ", altitudes));
        }
        else
        {
            Console.WriteLine("John didn't reach any altitude.");
        }
        return;
    }

    if (!requiredFuel.Any())
    {
        Console.WriteLine("John has reached all the altitudes and managed to reach the top!");
        return;
    }
}