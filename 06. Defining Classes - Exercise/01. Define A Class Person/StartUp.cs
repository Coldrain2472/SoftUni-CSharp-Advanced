using System;
using System.Reflection;
using System.Linq;
using DefiningClasses;
using System.Collections.Generic;

public class StartUp
{
    public static void Main(string[] args)
    {
        Person peter = new Person();
        peter.Name = "Peter";
        peter.Age = 20;
        Person george = new Person();
        george.Name = "George";
        george.Age = 18;
        Person jose = new Person();
        jose.Name = "Jose";
        jose.Age = 43;

        Console.WriteLine($"{peter.Name} is {peter.Age} years old");
        Console.WriteLine($"{george.Name} is {george.Age} years old");
        Console.WriteLine($"{jose.Name} is {jose.Age} years old");
    }
}

