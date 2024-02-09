Queue<int> monsters = new Queue<int>(Console.ReadLine()
    .Split(",", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

Stack<int> humans = new Stack<int>(Console.ReadLine()
    .Split(",", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

int killedMonstersCount = 0;

while (monsters.Any() && humans.Any())
{
    int armorValue = monsters.Peek();
    int strikeValue = humans.Peek();

    if (strikeValue >= armorValue)
    {
        killedMonstersCount++;
        int damageLeft = strikeValue - armorValue;
        monsters.Dequeue();
        humans.Pop();
        if (damageLeft > 0)
        {
            if (humans.Count == 0)
            {
                humans.Push(damageLeft);
            }
            else
            {
                humans.Push(humans.Peek() + damageLeft);
            }
        } 
    }
    else
    {
        int damageToReduce = armorValue - strikeValue;
        humans.Pop();
        monsters.Dequeue();
        monsters.Enqueue(damageToReduce);
    }
}
if (!monsters.Any())
{
    Console.WriteLine("All monsters have been killed!");
}
if (!humans.Any())
{
    Console.WriteLine("The soldier has been defeated.");
}

Console.WriteLine($"Total monsters killed: {killedMonstersCount}");