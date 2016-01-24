using System;

namespace SquareFromAsterisks
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Console.WriteLine("Въведете страна на квадрата: ");
            //number = int.Parse(Console.ReadLine());
            int number;

            number = 5;
            for (int x = 1; x <= number; x++)
            {
                for (int p = 1; p <= number; p++)
                {
                    if (x == 1 || x == number)
                        Console.Write("*");
                    else if (p == 1 || p == number)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
                          
                    

            Console.ReadLine();

           
        }

    }
}
