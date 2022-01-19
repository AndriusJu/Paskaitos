using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kepykla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa suskaičiuos kiek duonos kepalų kepykla sugebės iškepti per dieną, bei suskaičiuos kiek iš jų uždirbs pelno.");
            Console.WriteLine("Sakičiams su kableliu naudokite tašką");
            Console.WriteLine("Kiek darbuotojas gali iškepti kepalų per valandą ?");
            double kepalai = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Kiek darbuotojų turi kepykla ?");
            double darbuotojai = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Kokia vieno kepalo savikaina ?");
            double savikaina = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Kokia vieno kepalo pardavimo kaina ?");
            double pard_kaina = Convert.ToDouble(Console.ReadLine());
            double iskepe = kepalai * darbuotojai * 8;
            double sav_pard = iskepe * savikaina;
            double pelnas = iskepe * pard_kaina - sav_pard;
            Console.WriteLine($"Per vieną darbo dieną kepykla iškeps {iskepe}");
            Console.WriteLine($"Visų kepalų savikaina yra {sav_pard}, na, o pelno gauta {pelnas}");
            Console.ReadLine();
        }
    }
}
