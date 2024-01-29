using System;
using System.Reflection;
using System.Linq;
using System.Collections.Generic;
namespace DateModifier;

public class StartUp
{
    public static void Main(string[] args)
    {
        string start = Console.ReadLine();
        string end = Console.ReadLine();

        int differenceInDays = DateModifier.GetDifferenceInDays(start, end);

        Console.WriteLine(differenceInDays);
    }
}
