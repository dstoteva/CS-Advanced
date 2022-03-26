using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    public class Car
    {
        private const string defaultValue = "n/a";
        private const int defaultValueInt = -1;
        public Car(string model, Engine engine, double weight, string color)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = weight;
            this.Color = color;
        }
        public Car(string model, Engine engine, double weight) :this(model, engine, weight, defaultValue)
        {
        }
        public Car(string model, Engine engine, string color) : this(model, engine, defaultValueInt, color)
        {
        }
        public Car(string model, Engine engine) : this(model, engine, defaultValueInt, defaultValue)
        {
        }
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public double Weight { get; set; }
        public string Color { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Model + ":");
            sb.AppendLine(Engine.ToString());
            sb.AppendLine(Weight == -1 ? "  Weight: n/a" : "  Weight: " + Weight);
            sb.Append("  Color: " + Color);
            return sb.ToString();
        }
    }
}
