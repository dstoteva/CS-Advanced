using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    public class Engine
    {
        private const string defaultValue = "n/a";
        private const int defaultValueInt = -1;
        public Engine(string model, int power, int displacement, string efficiency)
        {
            this.Model = model;
            this.Power = power;
            this.Displacement = displacement;
            this.Efficiency = efficiency;
        }

        public Engine(string model, int power, int displacement) : this(model, power, displacement, defaultValue)
        {
        }

        public Engine(string model, int power, string efficiency) : this(model, power, defaultValueInt, efficiency)
        {
        }

        public Engine(string model, int power) :this(model, power, defaultValueInt, defaultValue)
        {
        }
        public string Model { get; set; }
        public int Power { get; set; }
        public int Displacement { get; set; }
        public string Efficiency { get; set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("  " + Model + ":");
            sb.AppendLine("    Power: " + Power);
            sb.AppendLine(this.Displacement == -1 ? "    Displacement: n/a" : "    Displacement: " + Displacement);
            sb.Append("    Efficiency: " + Efficiency);

            return sb.ToString();
        }


    }
}
