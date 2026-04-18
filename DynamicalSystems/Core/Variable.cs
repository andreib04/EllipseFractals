using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicalSystems.Core
{
    public class Variable
    {
        public string Name { get; }
        public int Power { get; }

        public Variable(string name, int power = 1)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name cannot be empty.");
            Name = name;
            Power = power;
        }

        public double Evaluate(double value) => Math.Pow(value, Power);

        public override string ToString()
        {
            return Power == 1 ? Name : $"{Name}^{Power}";
        }
    }
}
