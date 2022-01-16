using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veliava
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įrašykite vardą: ");
            string vardas = Console.ReadLine();
            Console.WriteLine("Įveskitę amžių: ");
            int amzius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Įveskite mėgstamiausia skaičių: ");
            double skaicius = Convert.ToDouble(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Mano vardas yra {vardas}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Mano amžius yra {amzius}");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Mano skaičius yra {skaicius}");
            Console.ReadLine();
        }
    }
}
