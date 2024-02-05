using System;
using System.Collections.Generic;
using System.Linq;

namespace BakeryShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<double> water = new Queue<double>(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(double.Parse)
    .ToList());

            Stack<double> flour = new Stack<double>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList());

            Dictionary<string, int> bakedGoodsCount = new Dictionary<string, int>
{
    {"Croissant", 0},
    {"Muffin", 0 },
    {"Baguette",0 },
    {"Bagel", 0 },
};

            while (water.Any() && flour.Any())
            {
                double currentWater = water.Peek();
                double currentFlour = flour.Peek();
                double mix = currentWater + currentFlour;
                bool isBaked = false;

                if (currentWater == mix * 0.5 && currentFlour == mix * 0.5)
                {
                    isBaked = true;
                    bakedGoodsCount["Croissant"]++;
                }
                else if (currentWater == mix * 0.4 && currentFlour == mix * 0.6)
                {
                    isBaked = true;
                    bakedGoodsCount["Muffin"]++;
                }
                else if (currentWater == mix * 0.3 && currentFlour == mix * 0.7)
                {
                    isBaked = true;
                    bakedGoodsCount["Baguette"]++;
                }
                else if (currentWater == mix * 0.2 && currentFlour == mix * 0.8)
                {
                    isBaked = true;
                    bakedGoodsCount["Bagel"]++;
                }
                else
                {
                    double currentFlourValue = flour.Pop();
                    double flourToAdd = water.Dequeue();
                    flour.Push(currentFlourValue - flourToAdd);
                    bakedGoodsCount["Croissant"]++;
                }

                if (isBaked)
                {
                    water.Dequeue();
                    flour.Pop();
                }
            }

            foreach (var item in bakedGoodsCount.Where(x => x.Value > 0).OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            if (water.Any())
            {
                Console.Write("Water left: ");
                Console.WriteLine(string.Join(", ", water));
            }
            else
            {
                Console.WriteLine("Water left: None");
            }

            if (flour.Any())
            {
                Console.Write("Flour left: ");
                Console.WriteLine(string.Join(", ", flour));
            }
            else
            {
                Console.WriteLine("Flour left: None");
            }
        }
    }
}