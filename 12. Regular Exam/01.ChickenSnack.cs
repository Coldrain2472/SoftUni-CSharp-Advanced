Stack<int> money = new Stack<int>(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

Queue<int> prices = new Queue<int>(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

int foodEaten = 0;

while (money.Any() && prices.Any())
{
    int moneyValue = money.Peek();
    int priceValue = prices.Peek();

    if (moneyValue == priceValue)
    {
        foodEaten++;
        money.Pop();
        prices.Dequeue();
    }
    else if (moneyValue > priceValue)
    {
        foodEaten++;
        int difference = moneyValue - priceValue;
        money.Pop();
        if (money.Count > 0)
        {
            money.Push(money.Pop() + difference);
        }
        
        prices.Dequeue();
    }
    else if (moneyValue < priceValue)
    {
        money.Pop();
        prices.Dequeue();
    }
}

if (foodEaten >= 4)
{
    Console.WriteLine($"Gluttony of the day! Henry ate {foodEaten} foods.");
}
else if (foodEaten > 0)
{
    Console.WriteLine($"Henry ate: {foodEaten} {(foodEaten == 1 ? "food" : "foods")}.");
}
else
{
    Console.WriteLine("Henry remained hungry. He will try next weekend again.");
}