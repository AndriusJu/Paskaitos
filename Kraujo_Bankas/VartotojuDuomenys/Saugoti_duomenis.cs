using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duomenys_Library
{
    public class Saugoti_duomenis
    {
        public static string KraujoGrupe { get; set; }

        public static void kraujogrupe(string kraujas)
        {
            KraujoGrupe = kraujas;
        }
        public static void PaukotasKraujas()
        {
            File.AppendAllText(NuskaitytiDuomenisIsFailo.paaukotasKraujas, Duomenys.NamePrisijungti + Duomenys.NameRegistracija + "," + KraujoGrupe + " ");
        }
        public static string IeskomasKraujas(string kraujas)
        {
            try
            {
                int turim = 0;
                List<string> Kraujas = new List<string>();
                foreach (string item in File.ReadLines(NuskaitytiDuomenisIsFailo.paaukotasKraujas))
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
                    foreach (var item in File.ReadLines(NuskaitytiDuomenisIsFailo.DonoruFailas))
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
            catch(Exception Klaidele)
            {
                return "Dėja tokios kraujo grupės neturime.";
            }
        }
               
        public static string rezervuojamasKraujas()
        {
            File.AppendAllText(NuskaitytiDuomenisIsFailo.rezervuojamaskraujas, KraujoGrupe + " ");
           return File.ReadAllText(NuskaitytiDuomenisIsFailo.rezervuojamaskraujas.ToString());
        }
    }
}