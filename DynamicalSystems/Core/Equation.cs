using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicalSystems.Core
{
    public class Equation
    {
        public string VariableName { get; }
        public List<Monom> Monoms { get; }

        public Equation(string variableName, IEnumerable<Monom> monoms)
        {
            if (string.IsNullOrWhiteSpace(variableName))
                throw new ArgumentException("Variable name cannot be empty.");
            Monoms = monoms?.ToList() ?? throw new ArgumentNullException(nameof(monoms));
            VariableName = variableName;
        }

        public double Evaluate(Dictionary<string, double> state) =>
            Monoms.Sum(m => m.Evaluate(state));

        public override string ToString() =>
            $"{VariableName}(t+1) = {string.Join(" + ", Monoms)}";
    }
}
