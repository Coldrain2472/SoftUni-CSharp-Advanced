using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    public class Car
    {
        private string make;
        public string Make
        {
            get { return make; }
            set { make = value; }
        }

        private string model;
        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        private int year;
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        
        private double fuelQuantity;
        public double FuelQuantity
        {
            get { return fuelQuantity; }
            set { fuelQuantity = value; }
        }

        private double fuelConsumption;
        public double FuelConsumption
        {
            get { return fuelConsumption; }
            set { fuelConsumption = value; }
        }

        public void Drive(double distance)
        {
            // bool canCarDrive = this.FuelQuantity - distance * this.FuelConsumption > 0;
            if (this.FuelQuantity - distance * this.FuelConsumption > 0)
            {
                FuelQuantity -= distance * this.FuelConsumption;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
            
            //if (canCarDrive)
            //{
            //    FuelQuantity -= distance * this.FuelConsumption;
            //}
            //else
            //{
            //    Console.WriteLine("Not enough fuel to perform this trip!");
            //}
        }

        public string WhoAmI()
        {
            return $"Make: {this.Make}\nModel: {this.Model}\nYear: {this.Year}\nFuel: {this.FuelQuantity:f2}";
        }
    }
}
