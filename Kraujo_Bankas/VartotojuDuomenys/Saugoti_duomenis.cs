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

        public static string rezervuojamaskraujas = @"..\..\..\RezervuojuKrauja.txt";

        public static void VartotojuDuomenysFailas(string paaukotaskraujas)
        {
            PaaukotasKraujas = paaukotaskraujas;

            bool ArYraFailas = File.Exists(paaukotaskraujas);
            if (!ArYraFailas) { File.Create(paaukotaskraujas); };

        }
        public static void RezervuojuKrauja(string rezervuojamaskraujas)
        {
            PaaukotasKraujas = rezervuojamaskraujas;

            bool ArYraFailas = File.Exists(rezervuojamaskraujas);
            if (!ArYraFailas) { File.Create(rezervuojamaskraujas); };

        }
        public static void kraujogrupe(string kraujas)
        {
            KraujoGrupe = kraujas;
        }
        public static void PaukotasKraujas()
        {
            VartotojuDuomenysFailas(PaaukotasKraujas);
            File.AppendAllText(PaaukotasKraujas, Prisijungti.Name + RegistracijaDuomenys.NameRegistracija + "," + KraujoGrupe + " ");
        }

        public static string IeskomasKraujas(string kraujas)
        {
            VartotojuDuomenysFailas(PaaukotasKraujas);
            int turim = 0;
            List<string> Kraujas = new List<string>();
            foreach (string item in File.ReadLines(PaaukotasKraujas))
            {
                foreach (var kit in item.Split(','))
                {
                    if (kit.Split().Contains(kraujas))
                    {
                        Console.WriteLine(kit[0]);
                        turim++;
                    }
                }
            }
            if (turim > 0)
            {
                return "Šios kraujo grupės turime: " + Convert.ToString(turim);
            }
            else
            {
               
                foreach (var item in File.ReadLines(RegistracijaDuomenys.DonoruFailas))
                {
                    string[] tekstodalis = item.Split(' ');
                    foreach (string tekstas in tekstodalis)
                    {
                        string[] duomenys = tekstas.Split(',');
                        if (duomenys[8] == kraujas)
                        {
                            return $"Šios grupės neturime, bet jos turi: \n {duomenys[0]} {duomenys[2]} {duomenys[3]} {duomenys[4]} {duomenys[5]} {duomenys[6]}";
                        }
                        
                    }

                }
               return "Šios kraujo grupės neturime.";
            }
        }

       
        public static void rezervuojamasKraujas()
        {
            File.AppendAllText(rezervuojamaskraujas, KraujoGrupe + " ");

        }
    }
}