using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VartotojuDuomenys
{
    public class Prisijungti
    {
        public static string Name { get; set; }
        private static string Password { get; set; }

        public static string PrisijungimoDuomenys = @"..\..\..\Vartotojai.txt";
        public static void VartotojuDuomenysFailas(string prisijungimoduomenys)
        {
            PrisijungimoDuomenys = prisijungimoduomenys;

            bool ArYraFailas = File.Exists(prisijungimoduomenys);
            if (!ArYraFailas) { File.Create(prisijungimoduomenys); };

        }
        public Prisijungti(string name, string password)
        {
            Name = name;
            Password = password;
        }
        public bool Atsakymas()
        {
           return File.ReadAllText(PrisijungimoDuomenys).Contains(Name + "," + Password + " ");

        }





    }
}
