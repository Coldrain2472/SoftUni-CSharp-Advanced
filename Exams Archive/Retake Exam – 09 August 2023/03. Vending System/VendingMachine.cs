using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendingSystem
{
    public class VendingMachine
    {
        public VendingMachine(int buttonCapacity)
        {
            ButtonCapacity = buttonCapacity;
            Drinks = new List<Drink>();
        }
        public int ButtonCapacity {get;set;}
        public List<Drink> Drinks { get;set;}
        public int GetCount => this.Drinks.Count();

        public void AddDrink(Drink drink)
        {
            if (ButtonCapacity>Drinks.Count)
            {
                Drinks.Add(drink);
            }
        }

        public bool RemoveDrink(string name)
        {
            Drink drink = Drinks.Find(x => x.Name == name);
            if (drink != null)
            {
                Drinks.Remove(drink);
                return true;
            }
            return false;
        }

        public Drink GetLongest()
        {
            Drink drink = Drinks.OrderByDescending(x => x.Volume).FirstOrDefault();
            return drink;
        }

        public Drink GetCheapest()
        {
            Drink drink = Drinks.OrderBy(x => x.Price).FirstOrDefault();
            return drink;
        }

        public string BuyDrink(string name)
        {
            Drink drink = Drinks.FirstOrDefault(x => x.Name == name);
            return drink.ToString().TrimEnd();
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Drinks available:");
            foreach (var drink in Drinks)
            {
                sb.AppendLine(drink.ToString());
            }

            return sb.ToString().TrimEnd();
        }

    }
}
