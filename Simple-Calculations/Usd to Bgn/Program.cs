using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usd_to_Bgn
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 USD = 1.79549 BGN
            double u1 = double.Parse(Console.ReadLine());
            double b1 = u1 * 1.79549;

            Console.WriteLine("USD to BGN = " + Math.Round(b1, 2));
        }
    }
}
