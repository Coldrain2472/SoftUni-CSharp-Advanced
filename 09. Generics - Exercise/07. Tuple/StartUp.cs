using System;

namespace Tuple
{
    public class StartUp
    {
        public static void Main()
        {
            // {first name} {last name} {address}
            string[] nameAndAddress = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            // {name} {liters of beer}
            string[] nameAndBeerAmount = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            // {integer} {double}
            string[] intAndDouble = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            CustomTuple<string, string> nameAddress = new($"{nameAndAddress[0]} {nameAndAddress[1]}", nameAndAddress[2]);
            CustomTuple<string, int> nameBeer = new(nameAndBeerAmount[0], int.Parse(nameAndBeerAmount[1]));
            CustomTuple<int, double> intDouble = new(int.Parse(intAndDouble[0]), double.Parse(intAndDouble[1]));

            Console.WriteLine(nameAddress);
            Console.WriteLine(nameBeer);
            Console.WriteLine(intDouble);
        }
    }
}


