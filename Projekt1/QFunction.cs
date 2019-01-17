using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1
{
    class QFunction
    {
        internal static void Start()
        {
            var a = 1;
            var b = 1;
            var c = -6;

            double delta = Math.Pow(b, 2) - 4 * a * c;
            if (delta > 0)
            {
                var x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                var x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"There are two solutions: {x1} and  {x2}.");
            }
            else if (delta == 0)
            {
                var x = -b / (2 * a);
                Console.WriteLine($"There is one solution {x}");
            }
            else
            {
                Console.WriteLine("There is no solution...");
            }
        }
    }
}
