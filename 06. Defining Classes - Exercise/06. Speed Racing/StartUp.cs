using System;
using System.Reflection;
using System.Linq;
using System.Collections.Generic;

namespace SpeedRacing
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            Dictionary<string, Car> cars = new Dictionary<string, Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                // {model} {fuelAmount} {fuelConsumptionFor1km}
                string[] carInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = carInfo[0];
                double fuelAmount = double.Parse(carInfo[1]);
                double fuelConsumptionFor1km = double.Parse(carInfo[2]);
                Car car = new Car(model, fuelAmount, fuelConsumptionFor1km, 0);
                cars.Add(model, car);
            }

            string commandInfo = string.Empty;
            while ((commandInfo = Console.ReadLine()) != "End")
            {
                // Drive {carModel} {amountOfKm}
                string[] command = commandInfo.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = command[1];
                double amountOfKm = double.Parse(command[2]);
                Car currentCar = cars[model];
                currentCar.Drive(amountOfKm);
            }
            //  {model} {fuelAmount:f2} {distanceTraveled}
            foreach (var car in cars.Values)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }
}