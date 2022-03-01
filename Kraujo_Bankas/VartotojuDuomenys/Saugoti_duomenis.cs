using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VartotojuDuomenys
{
    public class Saugoti_duomenis

    {
        public static string KraujoGrupe { get; set; }

        public static string PaaukotasKraujas = @"..\..\..\PaaukotasKraujas.txt";

        public static void VartotojuDuomenysFailas(string paaukotaskraujas)
        {
            PaaukotasKraujas = paaukotaskraujas;

            bool ArYraFailas = File.Exists(paaukotaskraujas);
            if (!ArYraFailas) { File.Create(paaukotaskraujas); };

        }
        public static void kraujogrupe(string kraujas)
        {
            KraujoGrupe = kraujas;
        }
        public static void PaukotasKraujas()
        {
            VartotojuDuomenysFailas(PaaukotasKraujas);
            File.AppendAllText(PaaukotasKraujas, Prisijungti.Name + "," + KraujoGrupe + " ");
        }

        public static string IeskomasKraujas(string kraujas)
        {
            VartotojuDuomenysFailas(PaaukotasKraujas);
            int turim = 0;
            List<string> Kraujas = new List<string>();
            foreach (string item in File.ReadLines(PaaukotasKraujas))
            {
                foreach (var kit in item.Split())
                {
                    if (kit.Split().Contains(kraujas))
                    {
                        Console.WriteLine(kit[0]);
                        turim++;
                    }
                }
            }
            foreach (var item in Kraujas)
            {
                Console.WriteLine(item);
            }
            if (turim > 0)
            {
                return "Šios kraujo grupės turime: " + Convert.ToString(turim);
            }
            else
            {
                return "Šios kraujo grupės neturime";
                // Pratest kad ismestu visus kurie turi ta grupe, gal pagal miesta grupuojant
            }
        }
        public static string RezervuojamasKraujas(string kraujas)
        {
            VartotojuDuomenysFailas(PaaukotasKraujas);
            
                //kol kas nezinau ka daro
            
            string atsakykmas = null;
            return atsakykmas;
        }
    }
}