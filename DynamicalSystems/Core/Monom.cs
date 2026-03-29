using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicalSystems.Core
{
    public class Monom
    {
        public double Coefficient { get; }
        public List<Variable> Variables { get; }

        public Monom(double coefficient, IEnumerable<Variable> variables = null)
        {
            Coefficient = coefficient;
            Variables = variables?.ToList() ?? new List<Variable>();
        }

        public static Monom Constant(double value) => new Monom(value);

        public static Monom FromParts(double coef, params (string name, int power)[] vars) => new Monom(coef, vars.Select(v => new Variable(v.name, v.power)));

        public double Evaluate(Dictionary<string, double> state)
        {
            if (Variables.Count == 0) return Coefficient;

            double result = Coefficient;
            foreach(var v in Variables)
            {
                if(!state.TryGetValue(v.Name, out double val))
                    throw new KeyNotFoundException($"Variable/parameter '{v.Name}' not found.");
                result *= v.Evaluate(val);
            }
            return result;
        }

        public override string ToString()
        {
            if (!Variables.Any()) return Coefficient.ToString("G");
            string coefStr = Math.Abs(Coefficient - 1) < 1e-12 ? "" :
                             Math.Abs(Coefficient + 1) < 1e-12 ? "-" :
                             Coefficient.ToString("G");
            return coefStr + string.Join("·", Variables);
        }
    }
}
