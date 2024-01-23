Func<double, double> vatResult = p => p * 0.2;
double[] prices = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
for (int i = 0; i < prices.Length; i++)
{
    prices[i] += vatResult(prices[i]);
    Console.WriteLine($"{prices[i]:f2}");
}