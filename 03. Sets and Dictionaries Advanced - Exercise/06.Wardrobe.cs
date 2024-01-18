int n = int.Parse(Console.ReadLine());
Dictionary<string, Dictionary<string,int>> colorClothesCount = new Dictionary<string, Dictionary<string,int>>();
for (int i = 0; i < n; i++)
{
    // Blue -> dress,jeans,hat 
    string[] input = Console.ReadLine().Split(new string[] {" -> ", ","}, StringSplitOptions.RemoveEmptyEntries);
    string color = input[0];

    if (!colorClothesCount.ContainsKey(color))
    {
        colorClothesCount.Add(color, new Dictionary<string,int>());
    }
    for (int j = 1; j < input.Length; j++)
    {
        string currentClothes = input[j];
        if (!colorClothesCount[color].ContainsKey(currentClothes))
        {
            colorClothesCount[color].Add(currentClothes,0);
        }
        colorClothesCount[color][currentClothes]++;
    }
}
string[] outfitToFind = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
string colorToFind = outfitToFind[0];
string itemToFind = outfitToFind[1];
foreach (var colors in colorClothesCount)
{
    Console.WriteLine($"{colors.Key} clothes:");
    foreach (var outfit in colors.Value)
    {
        if (colors.Key == colorToFind && outfit.Key == itemToFind)
        {
            Console.WriteLine($"* {outfit.Key} - {outfit.Value} (found!)");
        }
        else
        {
            Console.WriteLine($"* {outfit.Key} - {outfit.Value}");
        }
    }
}