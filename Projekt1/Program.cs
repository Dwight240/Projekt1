using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World!!!!!");

            var a = 1;
            var b = 1;
            var c = -6;

            double delta = Math.Pow(b, 2) - 4 * a * c;
            if(delta>0)
            {
                var x1 = (-b-Math.Sqrt(delta)) / (2*a);
                var x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"There are two solutions: {x1} and  {x2}.");
            }
            else if(delta == 0)
            {
                var x = -b / (2 * a);
                Console.WriteLine($"There is one solution {x}");
            }
            else
            {
                Console.WriteLine("There is no solution...");
            }

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
