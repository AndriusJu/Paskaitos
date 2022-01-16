using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_aparatas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pasirinkitę norimą punktą ir programą");
            Console.WriteLine("Pasirinkimai:" +
                "\n -    1 - Limonadas" +
                "\n -    2 - Arbata" +
                "\n -    3 - Kava" +
                "\n -    4 - Nieko");
            Console.WriteLine("Pasirinkitę:");
            int a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Console.WriteLine("Jūs pasirinkote limonadą");
                    break;
                case 2:
                    Console.WriteLine("Jūs pasirinkote kakavą");
                    break;
                case 3:
                    Console.WriteLine("Jūs pasirinkote kavą");
                    break;
                case 4:
                    Console.WriteLine("Jūs nieko nepasirinkote");
                    break;
                default:
                    Console.WriteLine("Klaida");
                    break;
            }
            Console.ReadLine();
        }
    }
}
