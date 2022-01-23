using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciklai_ND2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int slaptasskaicius = 4;
            int skaicius = 1;
            while (skaicius != slaptasskaicius)
            {
                Console.WriteLine("Bandykite atspėti slaptą skaičių /n Nuo 1 iki 10 ");
                skaicius = Convert.ToInt32(Console.ReadLine());
                if (skaicius < slaptasskaicius)
                {
                    Console.WriteLine("Slaptas skaičius yra didesnis");
                }
                else if (skaicius > slaptasskaicius)
                {
                    Console.WriteLine("Slaptas skaičius yra mažesnis");
                }
                else if (skaicius == slaptasskaicius)
                {
                    Console.WriteLine("Atspėjote !");
                }
                else
                {
                    Console.WriteLine("Klaida");
                }
            }
            Console.ReadLine();
        }
    }
}
