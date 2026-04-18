using DynamicalSystems.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicalSystems.Systems
{
    public static class KnownSystems
    {
        // x(t+1) = 1 - ax^2 + y
        // y(t+1) = bx
        public static DynamicSystem Henon(double a = 1.4, double b = 0.3) =>
            new DynamicSystem("Hénon Map",
                new[]
                {
                    new Equation("x", new[]
                    {
                        Monom.Constant(1),
                        Monom.FromParts(-1, ("a", 1), ("x", 2)),
                        Monom.FromParts( 1, ("y", 1))
                    }),
                    new Equation("y", new[]
                    {
                        Monom.FromParts(1, ("b", 1), ("x", 1))
                    })
                },
                new Dictionary<string, double> { ["a"] = a, ["b"] = b });



        //x(t+1)=rx - rx^2
        public static DynamicSystem Logistic(double r = 3.9) =>
            new DynamicSystem("Logistic Map",
                new[]
                {
                    new Equation("x", new[]
                    {
                        Monom.FromParts( 1, ("r", 1), ("x", 1)),
                        Monom.FromParts(-1, ("r", 1), ("x", 2))
                    })
                },
                new Dictionary<string, double> { ["r"] = r });


        // x(t+1) = 1 + u(xcos(t) - ysin(t))
        // y(t+1) = u(xsin(t) + ycos(t))
        // t = 0.4 - 6/(1 + x^2 + y^2)

        public static DynamicSystem Ikeda(double u = 0.9) =>
            new IkedaSystem(u);



        // x(t+1) = mu(1-x)  
        public static DynamicSystem TentMap(double mu = 1.9) =>
           new TentSystem(mu);



        // x(t+1) = 1 - 1.4x^2 + y   (parametri fixi Henon clasic)
        // y(t+1) = 0.3x
        public static DynamicSystem HenonClassic() => Henon(1.4, 0.3);
    }

    public class IkedaSystem : DynamicSystem
    {
        public IkedaSystem(double u = 0.9) : base("Ikeda Map",
            new[]
            {
                new Equation("x", new[] { Monom.Constant(0) }),
                new Equation("y", new[] { Monom.Constant(0) })
            },
            new Dictionary<string, double> { ["u"] = u })
        { }

        public override Dictionary<string, double> Step(Dictionary<string, double> state)
        {
            double x = state["x"];
            double y = state["y"];
            double u = Parameters["u"];
            double t = 0.4 - 6.0 / (1 + x * x + y * y);

            return new Dictionary<string, double>
            {
                ["x"] = 1 + u * (x * Math.Cos(t) - y * Math.Sin(t)),
                ["y"] = u * (x * Math.Sin(t) + y * Math.Cos(t))
            };
        }
    }

    public class TentSystem : DynamicSystem
    {
        public TentSystem(double mu = 1.9)
            : base("Tent Map",
                   new[]
                   {
                   new Equation("x", new[] { Monom.Constant(0) })
                   },
                   new Dictionary<string, double> { ["mu"] = mu })
        { }

        public override Dictionary<string, double> Step(Dictionary<string, double> state)
        {
            double x = state["x"];
            double mu = Parameters["mu"];

            double next = x < 0.5
                ? mu * x
                : mu * (1 - x);

            return new Dictionary<string, double>
            {
                ["x"] = next
            };
        }
    }
}
