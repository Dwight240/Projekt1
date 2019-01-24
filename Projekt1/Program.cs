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

            //QFunction.Start();
            //var o1 = new ObjectiveQFunction(1,5,4);
            //o1.Solve();
            //PasjaInformatykiPrzyklad.Start();



            List<int> lista = Enumerable.Range(0, 20).Where(x => x % 5 == 0).ToList();
            foreach (var item in lista)
            {
                //Console.WriteLine(item);
            }


            //Console.WriteLine(Sum(1, 2, 3, 4, 5,6));
            //string a = null;
            //string s = a == null ? null : a;
            //Console.WriteLine(s);

            string aa = "2a";
            int bb;

            if (int.TryParse(aa, out bb))
            {
                //Console.WriteLine($"a: {aa}, b: {bb}");
            }
            else
            {
                //Console.WriteLine($"(Błąd) a: {aa} b: {bb}");
            }

            long[] array = new long[] { 1, 2, 4, 7, 9, 11, 13 };
            long[] resultArray = new long[array.Length];
            long init = 0;
            for (var i = 0; i < array.Length; i++)
            {
                resultArray[i] = init + array[i];
                init = resultArray[i];
            }
            //Math.Gdci

            foreach (var item in resultArray)
            {
                //Console.WriteLine(item);
            }
            int a = 525;
            int b = 2310;
            int result = 0;
            int temp = 0;
            for (int i = 2; i < a; i++)
            {
                while (b != 0)
                {

                    result = a % b;
                    a = b;
                    temp = b;
                    b = result;

                }
            }

            Rectangle rec1 = new Rectangle(3, 4);
            Rectangle rec2 = new Rectangle { X = 3, Y = 6 };
            //Console.WriteLine(rec1.Y);
            //Console.WriteLine($"NWW result {temp}");

            List<string> d = new List<string> { "s", "a", "d", "e" };
            List<string> e = new List<string> { "e", "b", "a", "y" };

            d.Sort();
            e.Sort();
            foreach (var item in d)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();


            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }

        static public double Sum(params double[] table)
        {
            return table.Sum() / table.Length;
        }

        static public List<double> PolynomalSolution(params double[] coeffs)
        {
            List<double> rootsArray = new List<double>(10);


            return rootsArray;
        }

        


        public static int Bisection(int a, int b)
        {
            return 0;
        }
    }
}
