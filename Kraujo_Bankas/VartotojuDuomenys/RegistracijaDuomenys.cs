using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace VartotojuDuomenys
{
    public class RegistracijaDuomenys
    {
        public static string NameRegistracija { get; set; }
        private static string PasswordRegistracija { get; set; }
        private static string PasswordRegistracija2 { get; set; }
        private static string Vardas { get; set; }
        private static string Pavarde { get; set; }
        private static string Miestas { get; set; }
        private string TelefonoNumeris { get; set; }
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
            if (NameRegistracija.Length < 6)
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
            else if (PasswordRegistracija.Length < 6)
            {
                return "Įvestas slaptazodis pertrumpas";
            }
            else
            {
                return "001";
            }


        }
        public string Vardui()
        {
            if (!Regex.IsMatch(Pavarde, @"^[a-zA-Z]"))
            {
                return "Vardui naudojam tik raides !";
            }
            else
            {
                return "001";
            }
        }
        public string pavarde()
        {
            if (!Regex.IsMatch(Pavarde, @"^[a-zA-Z]"))
            {
                return "Pavardei naudojam tik raides !";
            }
            else
            {
                return "001";
            }
        }
        public string miestas()
        {
            if (!Regex.IsMatch(Miestas, @"^[a-zA-Z]"))
            {
                return "Miestui naudojam tik raides !";
            }
            else
            {
                return "001";
            }
        }
        public string telefononumeris()
        {
                    
           try
            {
                Convert.ToInt32(TelefonoNumeris);
                if (TelefonoNumeris.Length != 9)
                {
                    return "Telefono numeris turi būti 9 skaitmenų, gal suklydote. Bandykit dar kartą";
                }
                else
                {
                    return "001";
                }
            }
            catch (Exception)
                {
                return "Klaida, numeryje ne vien skaičiai arba langelis tuščias";
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
            try
            {
                
                string[] data = GimimoData.Split('-');
                foreach (var item in data)
                {
                    Convert.ToInt32(item);
                }


                if (GimimoData.Length < 10)
                {
                    return "Gimimo data pertrumpa gal suklydote. Bandykit dar kartą";

                }
                else if (data[0].Length!=4)
                {
                    return "Jūs blogai įvedėte metus, datos pvz. 1999-12-01";
                }
                else if (data[1].Length != 2)
                {
                    return "Jūs blogai įvedėte mėnesį, datos pvz. 1999-12-01";
                }
                else if (data[2].Length != 2)
                {
                    return "Jūs blogai įvedėte diena, datos pvz. 1999-12-01";
                }
                else
                {
                    return "001";
                }
            }
            catch (Exception)
            {
                return "Klaida, datoje ne vien skaičiai arba langelis tuščias";
            }
        }
       



        public string Registruotis()
        {
            if (NameRegistracija == null || PasswordRegistracija == null || PasswordRegistracija2 == null || Vardas == null ||
                   Pavarde == null || Miestas == null || TelefonoNumeris == null || ElPastas == null || GimimoData == null ||
                   Lytis == null)
            {
                return "Užpildykite visus laukelius";
            }
            else
            {
                File.AppendAllText(@"..\..\..\Vartotojai.txt", NameRegistracija + "," + PasswordRegistracija + " ");

                File.AppendAllText(@"..\..\..\Donorai.txt", NameRegistracija + "," + Vardas + "," + Pavarde + "," + Miestas + "," + TelefonoNumeris + "," + ElPastas + "," + GimimoData + "," + Lytis + "," + Saugoti_duomenis.KraujoGrupe + " ");

                return "001";
               
            }
            
                }
    }
}
