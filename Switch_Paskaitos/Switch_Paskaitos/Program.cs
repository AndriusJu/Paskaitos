using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Paskaitos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vartotojas įrašo tris skaičius");
            Console.WriteLine("Įrašykite pirmąjį skaičių");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Įrašykite antrąjį skaičių");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Įrašykite trečiąjį skaičių");
            double c = Convert.ToDouble(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Console.WriteLine($"Visų trijų skaičių suma: {a + b + c}");
                    break;
                case 2:
                    Console.WriteLine($"Pirmojo ir trečiojo skirtumas: {a - c}");
                    break;
                case 3:
                    Console.WriteLine($"Antro ir trečio skaičių sandauga {b * c}");
                    break;
                default:
                    Console.WriteLine("Netenkina salygų");
                    break;


            }
            Console.ReadLine();

        }
    }
}
