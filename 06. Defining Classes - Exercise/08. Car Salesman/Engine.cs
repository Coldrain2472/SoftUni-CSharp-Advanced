using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSalesman
{
    public class Engine
    {
        public Engine(string model, int power)
        {
            Model = model;
            Power = power;
        }
        public Engine(string model, int power, int displacement, string efficiency) : this(model, power)
        {
            Displacement = displacement;
            Efficiency = efficiency;
        }

        private string model;
		public string Model
		{
			get { return model; }
			set { model = value; }
		}

		private int power;
		public int Power
		{
			get { return power; }
			set { power = value; }
		}

		private int displacement;
		public int Displacement
		{
			get { return displacement; }
			set { displacement = value; }
		}

		private string efficiency;
		public string Efficiency
        {
			get { return efficiency; }
			set { efficiency = value; }
		}

        public override string ToString()
        {
            string displacement = Displacement == 0 ? "n/a" : Displacement.ToString();
            string efficiency = Efficiency ?? "n/a";

            StringBuilder sb = new();

            sb.AppendLine($"{Model}:");
            sb.AppendLine($"    Power: {Power}");
            sb.AppendLine($"    Displacement: {displacement}");
            sb.AppendLine($"    Efficiency: {efficiency}");

            return sb.ToString().TrimEnd();
        }
    }
}
