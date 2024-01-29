using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSalesman
{
    public class Car
    {
        public Car(string model, Engine engine)
        {
            Model = model;
            Engine = engine;
        }
        public Car(string model, Engine engine, int weight, string color) : this(model, engine)
        {
            Weight = weight;
            Color = color;
        }

        private string model;
		public string Model
		{
			get { return model; }
			set { model = value; }
		}

		private int weight;
		public int Weight
		{
			get { return weight; }
			set { weight = value; }
		}

		private string color;
		public string Color
		{
			get { return color; }
			set { color = value; }
		}

		public Engine Engine { get; set; }

        public override string ToString()
        {
            string weight = Weight == 0 ? "n/a" : Weight.ToString();
            string color = Color ?? "n/a";


            StringBuilder sb = new();

            sb.AppendLine($"{Model}:");
            sb.AppendLine($"  {Engine.ToString()}");
            sb.AppendLine($"  Weight: {weight}");
            sb.AppendLine($"  Color: {color}");

            return sb.ToString().TrimEnd();
        }

    }
}
