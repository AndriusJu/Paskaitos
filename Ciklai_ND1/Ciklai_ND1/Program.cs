using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciklai_ND1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string pasirinkimas = "T";
            while (pasirinkimas == "T")
            {
                Console.WriteLine("Kokį skaičiavimo veiksmą norite atlikti ? (+, -, *, / ar ^)");
                var simbolis = Console.ReadLine();
                Console.WriteLine("Įveskite pirma skaičių: ");
                double skaicius1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Įveskite antra skaičių: ");
                double skaicius2 = Convert.ToDouble(Console.ReadLine());
                if (simbolis == "+")
                {
                    Console.WriteLine($" {skaicius1} + {skaicius2} = {skaicius1 + skaicius2}");
                }
                else if (simbolis == "-")
                {
                    Console.WriteLine($" {skaicius1} - {skaicius2} = {skaicius1 - skaicius2}");
                }
                else if (simbolis == "/")
                {
                    Console.WriteLine($" {skaicius1} / {skaicius2} = {skaicius1 / skaicius2}");
                }
                else if (simbolis == "*")
                {
                    Console.WriteLine($" {skaicius1} * {skaicius2} = {skaicius1 * skaicius2}");
                }
                else
                {
                    Console.WriteLine("Neteisingas veiksmas");
                }
                Console.WriteLine("Ar norite skaičiuoti iš naujo T/N ?");
                pasirinkimas = Console.ReadLine();
            }
            Console.ReadLine();

        }
    }
}
