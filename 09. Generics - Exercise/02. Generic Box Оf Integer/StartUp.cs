﻿namespace BoxOfInteger
{
    public class StartUp
    {
        public static void Main()
        {
            Box<int> box = new Box<int>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                box.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine(box.ToString());
        }
    }
}
