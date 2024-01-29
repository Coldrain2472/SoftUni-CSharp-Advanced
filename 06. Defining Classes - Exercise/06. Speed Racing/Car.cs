using System;
using System.Reflection;
using System.Linq;
using System.Collections.Generic;

namespace SpeedRacing
{
    public class Car
    {
        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer, double travelledDistance)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
            TravelledDistance = travelledDistance;
        }

        private string model;
        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        private double fuelAmount;
        public double FuelAmount
        {
            get { return fuelAmount; }
            set { fuelAmount = value; }
        }

        private double fuelConsumptionPerKilometer;
        public double FuelConsumptionPerKilometer
        {
            get { return fuelConsumptionPerKilometer; }
            set { fuelConsumptionPerKilometer = value; }
        }

        private double travelledDistance;
        public double TravelledDistance
        {
            get { return travelledDistance; }
            set { travelledDistance = value; }
        }

        public void Drive(double distance)
        {
            if (distance * FuelConsumptionPerKilometer > fuelAmount)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else
            {
                FuelAmount -= distance * FuelConsumptionPerKilometer;
                TravelledDistance += distance;
            }
        }
    }
}
