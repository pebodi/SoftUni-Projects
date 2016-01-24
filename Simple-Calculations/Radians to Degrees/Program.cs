using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radians_to_Degrees
{
    class Program
    {
        static void Main(string[] args)
        {
            //α°= αрад*(180°/π)
            double r1 = double.Parse(Console.ReadLine());
            double c1 = r1 * (180/Math.PI);

            Console.WriteLine("Radians to degree = " + Math.Round(c1, 0));
        }
    }
}
