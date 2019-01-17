using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1
{
    class PiApproximation
    {
        internal static void Start()
        {
            double pi = 0;
            double sum = 0;
            int i = 0;
            while (Math.Abs(pi - Math.PI) > 0.0000001)
            {
                sum += Math.Pow(-1, i) / (1 + 2 * i);
                i++;
                pi = sum * 4;
            }
            Console.WriteLine(pi);

        }
    }
}
