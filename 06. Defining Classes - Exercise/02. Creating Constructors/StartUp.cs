using System;
using System.Reflection;
using System.Linq;
using DefiningClasses;
using System.Collections.Generic;

public class StartUp
{
    public static void Main(string[] args)
    {
        Person firstPerson = new Person();
        
        Person secondPerson = new Person();
        secondPerson.Age = 23;
        
        Person thirdPerson = new Person();
        secondPerson.Name = "Misho";
        secondPerson.Age = 30;

        Console.WriteLine($"{firstPerson.Name} - {firstPerson.Age}");
        Console.WriteLine($"{secondPerson.Name} - {secondPerson.Age}");
        Console.WriteLine($"{thirdPerson.Name} - {thirdPerson.Age}");
    }
}

