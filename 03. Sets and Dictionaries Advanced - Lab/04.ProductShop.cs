using System.Linq;

Dictionary<string, Dictionary<string, double>> shops = new Dictionary<string, Dictionary<string, double>>();
string command = string.Empty;
while ((command = Console.ReadLine()) != "Revision")
{
    string[] input = command.Split(", ", StringSplitOptions.RemoveEmptyEntries);  
    string shop = input[0];
    string product = input[1];
    double price = double.Parse(input[2]);

    if (!shops.ContainsKey(shop))
    {
        shops.Add(shop, new Dictionary<string, double>());
    }
    shops[shop].Add(product, price);
}

shops = shops.OrderBy(s => s.Key).ToDictionary(s => s.Key, s => s.Value);

foreach (var shop in shops)
{
    Console.WriteLine($"{shop.Key}->");
    foreach (var product in shop.Value)
    {
        Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
    }
}
