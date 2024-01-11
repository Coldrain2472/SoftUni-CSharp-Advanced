using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

int food = int.Parse(Console.ReadLine());
int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();

Queue<int> ordersQueue = new Queue<int>(orders);
Console.WriteLine(ordersQueue.Max());

for (int i = 0; i < orders.Length; i++)
{
    if (food - ordersQueue.Peek() >= 0)
    {
        food -= ordersQueue.Dequeue();
    }
    else
    {
        break;
    }
}

if (ordersQueue.Count == 0)
{
    Console.WriteLine("Orders complete");
}
else
{
    Console.WriteLine($"Orders left: {String.Join(" ", ordersQueue)}");
}