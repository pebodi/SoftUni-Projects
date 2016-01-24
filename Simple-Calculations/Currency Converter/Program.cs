using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double amount;
            double USD = 1.79549;
            double GBP = 2.53405;
            double EUR = 1.95583;
            double Lev = 1.00000;
            string currency;

            Dictionary<string, double> factors = new Dictionary<string, double>();
            factors.Add("GBP", 2.53405D);
            factors.Add("USD", 1.79549D);
            factors.Add("EUR", 1.95583D);
            factors.Add("BGN", 1.00000D);

            Console.WriteLine("Моля, въведете сума, която искате да конвертирате:");
            amount = double.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("Моля, посочете валута, в която е въведената сума:");
            Console.WriteLine("USD");
            Console.WriteLine("GBP");
            Console.WriteLine("EUR");
            Console.WriteLine("BGN");
            Console.WriteLine("");
            string currfrom = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("Моля, посочете валута, в която да се конвертира:");
            Console.WriteLine("USD");
            Console.WriteLine("GBP");
            Console.WriteLine("EUR");
            Console.WriteLine("BGN");
            Console.WriteLine("");
            string currto = Console.ReadLine();
            currency = currto;

            switch (currfrom)
                {
            case "BGN":
                break;
            case "USD":
                value = (value * dollar);
                break;
            case "EUR":
                value = (value * euro);
                break;
            case "GBP":
                value = (value * pound);
                break;
            default:
                break;
                }


            double factor;
            if (factors.TryGetValue(currency, out factor))
            {
                if (currfrom == "BGN")
                Console.WriteLine("You have entered {0} BGN which converts to {1} {2}", amount, Math.Round(amount / factor, 2), currency);
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("Въведохте несъществуващ код за валута {1}", currency);
            }
        }
    }
}
