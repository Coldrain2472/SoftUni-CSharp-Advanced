using System.Collections.Generic;
using System.Net;

namespace Threeuple
{
    public class StartUp
    {
        public static void Main()
        {
            string[] nameAndAddress = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string[] nameBeerDrunkOrNot = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string[] nameBalanceName = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            CustomThreeuple<string, string, string> person = new(" ", " ", " ");

            if (nameAndAddress.Length > 4)
            {
                person =
                new($"{nameAndAddress[0]} {nameAndAddress[1]}", nameAndAddress[2], $"{nameAndAddress[3]} {nameAndAddress[4]}");
            }
            else
            {
                person =
                new($"{nameAndAddress[0]} {nameAndAddress[1]}", nameAndAddress[2], nameAndAddress[3]);
            }

            CustomThreeuple<string, int, bool> personIsDrunk =
                new(nameBeerDrunkOrNot[0], int.Parse(nameBeerDrunkOrNot[1]), nameBeerDrunkOrNot[2] == "drunk");

            CustomThreeuple<string, double, string> nameBankBalance =
                new(nameBalanceName[0], double.Parse(nameBalanceName[1]), nameBalanceName[2]);

            Console.WriteLine(person);
            Console.WriteLine(personIsDrunk);
            Console.WriteLine(nameBankBalance);
        }
    }
}
