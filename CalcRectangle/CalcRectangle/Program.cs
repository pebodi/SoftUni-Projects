using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Въведете дължина на правоъгълника: ");
            var a = decimal.Parse(Console.ReadLine());
            //Console.WriteLine("Въведете височина на правоъгълника: ");
            var b = decimal.Parse(Console.ReadLine());

            // TODO: calculate the area and print it
            Console.WriteLine ( "Лицето на правоъгълника е: " + ( a * b ).ToString () + "\n");
           

        }
    }
}
