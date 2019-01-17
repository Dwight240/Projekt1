using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1
{
    class ObjectiveQFunction
    {

        public double A { get; set; } = 0;
        public double B { get; set; } = 0;
        public double C { get; set; } = 0;
        public double Delta { get; set; } = 0;


        public ObjectiveQFunction(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;
            Delta = B * B - 4 * A * C;
        }

        public void Solve()
        {
            if (Delta > 0)
            {
                var x1 = (-B - Math.Sqrt(Delta)) / (2 * A);
                var x2 = (-B + Math.Sqrt(Delta)) / (2 * A);
                Console.WriteLine($"There are two solutions: {x1} and  {x2}.");
            }
            else if (Delta == 0)
            {
                var x = -B / (2 * A);
                Console.WriteLine($"There is one solution {x}");
            }
            else
            {
                Console.WriteLine("There is no solution...");
            }

        }
    }
}
