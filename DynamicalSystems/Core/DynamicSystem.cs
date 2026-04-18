using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicalSystems.Core
{
    public class DynamicSystem
    {
        public string Name { get; set; }
        public List<Equation> Equations { get; }
        public Dictionary<string, double> Parameters { get; }

        public DynamicSystem(string name, IEnumerable<Equation> equations, Dictionary<string, double> parameters = null)
        {
            Name = name;
            Equations = equations?.ToList() ?? throw new ArgumentNullException(nameof(equations));
            Parameters = parameters ?? new Dictionary<string, double>();
        }

        public virtual Dictionary<string, double> Step(Dictionary<string, double> state)
        {
            var fullState = new Dictionary<string, double>(state);  
            foreach(var p in Parameters)
                fullState[p.Key] = p.Value;

            var next = new Dictionary<string, double>();
            foreach(var eq in Equations)
            {
                next[eq.VariableName] = eq.Evaluate(fullState);
            }
            return next;
        }

        public List<Dictionary<string, double>> Iterate(Dictionary<string, double> initial, int steps, int transient = 0) 
        {
            if (steps <= 0)
                throw new ArgumentOutOfRangeException(nameof(steps), "Steps must be positive.");

            var state = new Dictionary<string, double>(initial);

            for(int i = 0; i < transient; i++)
            {
                state = Step(state);
            }

            var orbit = new List<Dictionary<string, double>>(steps) { new Dictionary<string, double>(state)};

            for(int i = 0; i < steps - 1; i++)
            {
                state = Step(state);
                orbit.Add(new Dictionary<string, double>(state));
            }
            return orbit;
        }

        public List<string> StateVariables => Equations.Select(e => e.VariableName).ToList();

        public override string ToString() =>
            $"[{Name}]\n" +
            string.Join("\n", Equations.Select(e => "  " + e)) + "\n" +
            (Parameters.Any()
                ? "  Params: " + string.Join(", ", Parameters.Select(p => $"{p.Key}={p.Value}"))
                : "");
    }
}
