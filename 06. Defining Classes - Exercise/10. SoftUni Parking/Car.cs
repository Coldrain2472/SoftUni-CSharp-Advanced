using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniParking
{
    public class Car
    {
        public Car(string make, string model, int horsePower, string registrationNumber)
        {
            Make = make;
            Model = model;
            HorsePower = horsePower;
            RegistrationNumber = registrationNumber;
        }
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

		private int horsePower;
		public int HorsePower
		{
			get { return horsePower; }
			set { horsePower = value; }
		}

		private string registrationNumber;
		public string RegistrationNumber
		{
			get { return registrationNumber; }
			set { registrationNumber = value; }
		}

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Make: {Make}");
            sb.AppendLine($"Model: {Model}");
            sb.AppendLine($"HorsePower: {HorsePower}");
            sb.AppendLine($"RegistrationNumber: {RegistrationNumber}");
            return sb.ToString().TrimEnd();
        }
    }
}
