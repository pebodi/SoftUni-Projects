using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celsius_degree_to_Farenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            //°F = °C × 1,8 + 32
            double c1 = double.Parse(Console.ReadLine());
            double f1 = c1*1.8 + 32;

            Console.WriteLine("Farenheit degree = " + Math.Round(f1, 2));
        }
    }
}
