using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VartotojuDuomenys
{
    public class RegistracijaDuomenys
    {
        private static string NameRegistracija { get; set; }
        private static string PasswordRegistracija { get; set; }
        private static string PasswordRegistracija2 { get; set; }
        private static string Vardas { get; set; }
        private static string Pavarde { get; set; }
        private static string Miestas { get; set; }
        private static string TelefonoNumeris { get; set; }
        private static string ElPastas { get; set; }
        private static string GimimoData { get; set; }
        public string Lytis { get; set; }

        public static string PrisijungimoDuomenys = @"..\..\..\Vartotojai.txt";



        public static string DonoruFailas = @"..\..\..\Donorai.txt";
        public static void DonoruDuomenysFailas(string donorufailas)
        {
            DonoruFailas = donorufailas;

            bool ArYraFailas = File.Exists(donorufailas);
            if (!ArYraFailas) { File.Create(donorufailas); };

        }
        public RegistracijaDuomenys(string RegistracijosVardas, string RegistracijosSlaptazodis, string RegistracijosSlaptazodis2, string vardas, string pavarde, string miestas, string telefononumeris, string elpastas, string gimimoData)
        {
            NameRegistracija = RegistracijosVardas;
            PasswordRegistracija = RegistracijosSlaptazodis;
            PasswordRegistracija2 = RegistracijosSlaptazodis2;
            Vardas = vardas;
            Pavarde = pavarde;
            Miestas = miestas;
            TelefonoNumeris = telefononumeris;
            ElPastas = elpastas;
            GimimoData = gimimoData;
           
        }

        public string vardas()
        {
            if (PrisijungimoDuomenys.Contains(NameRegistracija))
            {
                return "Toks vardas jau yra";
            }
            else if (NameRegistracija.Length < 6)
            {
                return "Prisijungimo vardas pertrumpas";
            }
            else
            {
                return "001";
            }

            
        }
        public string slaptazodis()
        {
            if (PasswordRegistracija != PasswordRegistracija2)
            {
                return "Įvesti slaptazodziai nesutampa";
            }
            if (PasswordRegistracija.Length < 6)
            {
                return "Įvestas slaptazodis pertrumpas";
            }
            else
            {
                return "001";
            }


        }
        public string telefononumeris()
        {
            if (TelefonoNumeris.Length < 9)
            {
                return "Telefono numeris pertrumpas, gal suklydote. Bandykit dar kartą";
            }
            if (!int.TryParse(TelefonoNumeris, out _))
            {
                return "Klaida, numeryje ne vien skaičiai !";
            }
            else
            {
                return "001";
            }
        }

            public string elpastas()
            {
                if (!ElPastas.Contains('@')&& !ElPastas.Contains('.'))
                {
                    return "El. pašto adresas blogas, gal suklydote. Bandykit dar kartą";
                }
                else
                {
                    return "001";
                }


        }
        public string gimimodata()
        {

            if (GimimoData.Length < 10)
            {
                return  "Gimimo data pertrumpa gal suklydote. Bandykit dar kartą";
                
            }
            else if (!int.TryParse(GimimoData, out _))
            {
                return "";
            }
            else
            {
                return "001";
            }
        }
        public string lytis()
        {

            if (Lytis.Length < 10)
            {
                return "Gimimo data pertrumpa gal suklydote. Bandykit dar kartą";

            }
            else if (!int.TryParse(GimimoData, out _))
            {
                return "";
            }
            else
            {
                return "001";
            }
        }



        public void Registruotis()
        {
            File.AppendAllText(@"..\..\..\Vartotojai.txt", NameRegistracija + "," + PasswordRegistracija + " ");

            File.AppendAllText(@"..\..\..\Donorai.txt", Vardas + "," + Pavarde + "," + Miestas + "," + TelefonoNumeris + "," + ElPastas + "," + GimimoData + "," + Lytis + " ");

        
        }
    }
}
