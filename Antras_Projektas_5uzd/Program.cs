using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antras_Projektas_5uzd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa suras ar: ");
            Console.WriteLine("Pirmas skaičius didesnis už antrąjį ir mažesnis už 100");
            Console.WriteLine("Antras skaičius didesnis už 0 ir didesnis  už pirmąjį skaičių");
            Console.WriteLine("Pirmasis skaičius didesnis už antrąjį ir trečiajį arba yra didesnis už 0");
            Console.WriteLine("Trečiass skaičius yra tarp 5 ir 10 arba yra didesnis už pirmąjį arba didesnis už antrajį skaičių");
            Console.WriteLine("Įveskite pirmą skaičių");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Įveskite antrą skaičių");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Įveskite trečia skaičių");
            double c = Convert.ToDouble(Console.ReadLine());
            if (a>b && a<100)
            {
                Console.WriteLine("Pirmas skaičius didesnis už antrąjį ir mažesnis už 100");
                Console.WriteLine($"{a} > {b} ir mažesnis už 100");
            }
            else if (b>0 && b>a)
            {
                Console.WriteLine("Antras skaičius didesnis už 0 ir didesnis  už pirmąjį skaičių");
                Console.WriteLine($"{b} didesnis už 0 ir didesnis už {a}");
            }
            else if (a>b && a>c|| a>0)
            {
                Console.WriteLine("Pirmasis skaičius didesnis už antrąjį ir trečiajį arba yra didesnis už 0");
                Console.WriteLine($"{a} didesnis {b} ir {c} arba yra didesnis už 0");
            }
            else if (5 >= c && c <= 10||c > a||c > b)
            {
                Console.WriteLine("Trečiass skaičius yra tarp 5 ir 10 arba yra didesnis už pirmąjį arba didesnis už antrajį skaičių");
                Console.WriteLine($"{c} yra tarp 5 ir 10 arba yra didesnis už {a} arba didesnis už {b}");
            }
            else
            {
                Console.WriteLine("Klaida");
            }
            Console.ReadLine();
        }
    }
}
