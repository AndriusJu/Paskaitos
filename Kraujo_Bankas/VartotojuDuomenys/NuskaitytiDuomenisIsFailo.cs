using System.IO;

namespace Duomenys_Library
{
    public class NuskaitytiDuomenisIsFailo
    {
        public static string PrisijungimoDuomenys = @"..\..\..\Vartotojai.txt";
        public static string DonoruFailas = @"..\..\..\Donorai.txt";
        public static string rezervuojamaskraujas = @"..\..\..\RezervuojuKrauja.txt";
        public static string paaukotasKraujas = @"..\..\..\PaaukotasKraujas.txt";

        public static void VartotojuDuomenysFailas()
        {
            bool ArYraFailas = File.Exists(PrisijungimoDuomenys);
            if (!ArYraFailas) { File.WriteAllText(PrisijungimoDuomenys,"Andrius,123456 Jonas,aksonas Boruzele,vienasdutrys "); };
        }

        public static void PaaukotasKraujasFailas()
        {
            bool ArYraFailas = File.Exists(paaukotasKraujas);
            if (!ArYraFailas) { File.WriteAllText(paaukotasKraujas, "Andrius,AB+ Jonas,B- Boruzele,A+ "); };
        }

        public static void RezervuojuKraujaFailas()
        {

            bool ArYraFailas = File.Exists(rezervuojamaskraujas);
            if (!ArYraFailas) { File.WriteAllText(rezervuojamaskraujas, "A+ B+ AB- A- "); };
        }

        public static void DonoruDuomenysFailas()
        {
            bool ArYraFailas = File.Exists(DonoruFailas);
            if (!ArYraFailas) { File.WriteAllText(DonoruFailas, "Petras,Petras,Jonaitis,Joniskis,555555555,Jonaitis@vienas.com,1888-10-13,Vyras,O- Andrius,Andrius,Jurkevicius,Sakiai,868617462,Andrius@gmail.com,1994-12-30,Vyras,AB+ Boruzele,Gyte,Jurkeviciene,Kaunas,852145687,Gyte@brumbrum.com,1995-08-31,A+ "); };
        }
    }
}
