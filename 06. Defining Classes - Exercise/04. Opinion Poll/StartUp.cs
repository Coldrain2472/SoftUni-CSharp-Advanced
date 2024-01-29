using System;
using System.Reflection;
using System.Linq;
using DefiningClasses;
using System.Collections.Generic;

public class StartUp
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<Person> peopleList = new List<Person>();
        for (int i = 0; i < n; i++)
        {
            string[] currentPerson = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string currentName = currentPerson[0];
            int currentAge = int.Parse(currentPerson[1]);

            peopleList.Add(new Person(currentName, currentAge));
        }

        foreach (var person in peopleList.OrderBy(p => p.Name).Where(p => p.Age > 30))
        {
            Console.WriteLine($"{person.Name} - {person.Age}");
        }
       
    }
}

