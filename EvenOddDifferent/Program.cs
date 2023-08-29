using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOddDifferent
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Podaj liczbę całkowitą, program określi czy jest liczba parzysta czy nieparzysta!");
            var number = GetNumber();

            if (number % 2 ==0 )
            {
                Console.WriteLine($" {number} to liczba parzysta.");
            }
            if (number % 2 != 0 )
            {
                Console.WriteLine($" {number} to liczba nieparzysta.");
            }
        }

        private static int GetNumber()
        {
            while (true)
            {           
                if (!int.TryParse(Console.ReadLine(), out int number))
                {
                    Console.WriteLine(" Wpisany tekst nie jest liczbą całkowitą, wpisz liczbę całkowitą.");
                    continue;
                }
                else
                {
                    return number;
                }
            }
        }



    }
}
