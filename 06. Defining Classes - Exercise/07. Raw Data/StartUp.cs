using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData;
public class StartUp
{
    public static void Main(string[] args)
    {
        int numberOfCars = int.Parse(Console.ReadLine());
        List<Car> cars = new List<Car>();
        for (int i = 0; i < numberOfCars; i++)
        {
            // "{model} {engineSpeed} {enginePower} {cargoWeight} {cargoType} {tire1Pressure} {tire1Age} {tire2Pressure} {tire2Age} {tire3Pressure} {tire3Age} {tire4Pressure} {tire4Age}"
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string model = input[0];
            int speed = int.Parse(input[1]);
            int power = int.Parse(input[2]);
            int weight = int.Parse(input[3]);
            string type = input[4];
            float tire1Pressure = float.Parse(input[5]);
            int tire1Age = int.Parse(input[6]);
            float tire2Pressure = float.Parse(input[7]);
            int tire2Age = int.Parse(input[8]);
            float tire3Pressure = float.Parse(input[9]);
            int tire3Age = int.Parse(input[10]);
            float tire4Pressure = float.Parse(input[11]);
            int tire4Age = int.Parse(input[12]);
            Engine currentEngine = new Engine(speed, power);
            Cargo currentCargo = new Cargo(weight, type);
            Tires tire1 = new Tires(tire1Age, tire1Pressure);
            Tires tire2 = new Tires(tire2Age, tire2Pressure);
            Tires tire3 = new Tires(tire3Age, tire3Pressure);
            Tires tire4 = new Tires(tire4Age, tire4Pressure);
            Tires[] currentTires = new Tires[]
            {
                tire1, tire2, tire3, tire4
            };
            Car currentCar = new Car(model, currentEngine, currentCargo, currentTires);
            cars.Add(currentCar);
        }
        string command = Console.ReadLine();
        string[] filteredCars;
        if (command == "fragile")
        {
            filteredCars = cars.Where(c=>c.Cargo.Type == "fragile" && c.Tires.Any(t => t.Pressure < 1))
                .Select(c => c.Model)
                .ToArray();
        }
        else // "flammable"
        {
            filteredCars = cars.Where(c => c.Cargo.Type == "flammable" && c.Engine.Power > 250)
                .Select(c => c.Model)
                .ToArray();
        }

        Console.WriteLine(string.Join(Environment.NewLine, filteredCars));
    }
}
