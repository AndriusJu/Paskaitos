using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VartotojuDuomenys
{
    internal class AukotiKrauja
    {
        public static string AukotasKraujas = @"..\..\..\PaaukotasKraujas.txt";
        public static void PaaukotasKraujas(string paaukotaskraujas)
        {
            AukotasKraujas = paaukotaskraujas;

            bool ArYraFailas = File.Exists(paaukotaskraujas);
            if (ArYraFailas == false) { File.Create(paaukotaskraujas); };

        }

        public static void Aukosiu()
        {
            Console.WriteLine("Jūs norite paukoti kraujo");
           //string grupe = KraujoGrupe.KuriosGrupes();
           //File.AppendAllText(@"..\..\..\PaaukotasKraujas.txt", grupe + ",");
           //Console.WriteLine($"Jūsų kraujo grupė yra {grupe} \n AČIŪ UŽ JŪSŲ AUKĄ !");
           //Console.ReadLine();
        }



    }
}
