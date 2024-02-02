using System;
using System.Collections.Generic;
using System.Linq;

namespace TilesMaster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> whiteTiles = new Stack<int>(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList());

            Queue<int> greyTiles = new Queue<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList());

            Dictionary<string, int> tileAreas = new Dictionary<string, int>()
            {
                {"Sink", 0 },
                {"Oven", 0 },
                {"Countertop", 0},
                {"Wall", 0 },
                {"Floor", 0 }
            };

            while ((greyTiles.Any() && whiteTiles.Any()))
            {
                int sum = 0;
                bool isMatch = false;
                if (greyTiles.Peek() == whiteTiles.Peek())
                {
                    sum = whiteTiles.Peek() + greyTiles.Peek();

                }
                else
                {
                    int whiteTileToReduce = whiteTiles.Pop() / 2;
                    whiteTiles.Push(whiteTileToReduce);
                    int greyTilesToMove = greyTiles.Dequeue();
                    greyTiles.Enqueue(greyTilesToMove);
                    continue;
                }
                if (sum == 40)
                {
                    tileAreas["Sink"]++;
                    isMatch = true;
                }
                else if (sum == 50)
                {
                    tileAreas["Oven"]++;
                    isMatch = true;
                }
                else if (sum == 60)
                {
                    tileAreas["Countertop"]++;
                    isMatch = true;
                }
                else if (sum == 70)
                {
                    tileAreas["Wall"]++;
                    isMatch = true;
                }
                else
                {
                    tileAreas["Floor"]++;
                    isMatch = true;
                }

                if (isMatch)
                {
                    whiteTiles.Pop();
                    greyTiles.Dequeue();
                }
            }

            if (!whiteTiles.Any())
            {
                Console.WriteLine("White tiles left: none");
            }
            else
            {
                Console.Write("White tiles left: ");
                Console.WriteLine(string.Join(", ", whiteTiles));
            }

            if (!greyTiles.Any())
            {
                Console.WriteLine("Grey tiles left: none");
            }
            else
            {
                Console.Write("Grey tiles left: ");
                Console.WriteLine(string.Join(", ", greyTiles));
            }

            foreach (var area in tileAreas.Where(a => a.Value > 0).OrderByDescending(a => a.Value).ThenBy(a => a.Key))
            {
                Console.WriteLine($"{area.Key}: {area.Value}");
            }
        }
    }
}