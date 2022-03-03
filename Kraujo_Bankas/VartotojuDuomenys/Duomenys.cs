using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Duomenys_Library
{
    public class Duomenys
    {
        //Registracijai
        public static string NameRegistracija { get; set; }
        public static string PasswordRegistracija { get; set; }
        public static string PasswordRegistracija2 { get; set; }
        public static string Vardas { get; set; }
        public static string Pavarde { get; set; }
        public static string Miestas { get; set; }
        public static string TelefonoNumeris { get; set; }
        public static string ElPastas { get; set; }
        public static string GimimoData { get; set; }
        public static string Lytis { get; set; }

        //Prisijungimui
        public static string NamePrisijungti { get; set; }
        private static string PasswordPrisijungti { get; set; }
        
        public Duomenys(string RegistracijosVardas, string RegistracijosSlaptazodis, string RegistracijosSlaptazodis2, string vardas, string pavarde, string miestas, string telefononumeris, string elpastas, string gimimoData)
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
        public Duomenys(string name, string password)
        {
            NamePrisijungti = name;
            PasswordPrisijungti = password;
        }
        public bool Prisijungimas()
        {
            return File.ReadAllText(NuskaitytiDuomenisIsFailo.PrisijungimoDuomenys).Contains(NamePrisijungti + "," + PasswordPrisijungti + " ");
        }

        public string NameRegistracijaTikrinimas()
        {
           //Perdaryti su stringbuilder
            if (NameRegistracija.Length == 0)
            {
                return "002";
            }
            else if (File.ReadAllText(NuskaitytiDuomenisIsFailo.PrisijungimoDuomenys).Contains(NameRegistracija + ","))
            {
                return "Toks Registracijos vardas jau yra";
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
        public string SlaptazodisTikrinimas()
        {
            if (PasswordRegistracija.Length == 0 && PasswordRegistracija2.Length == 0)
            {
                return "002";
            }
            else if (PasswordRegistracija != PasswordRegistracija2)
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
        public string VardasTikrinimas()
        {

            if (Vardas.Length == 0)
            {
                return "002";
            }
            else if (!Regex.IsMatch(Vardas, @"^[a-zA-Z]"))
            {
                return "Vardui naudojam tik raides !";
            }
            else
            {
                return "001";
            }
        }
        public string PavardeTikrinimas()
        {

            if (Pavarde.Length == 0)
            {
                return "002";
            }
            else if (!Regex.IsMatch(Pavarde, @"^[a-zA-Z]"))
            {
                return "Pavardei naudojam tik raides !";
            }
            else
            {
                return "001";
            }
        }
        public string MiestasTikrinimas()
        {

            if (Miestas.Length == 0)
            {
                return "002";
            }
            else if (!Regex.IsMatch(Miestas, @"^[a-zA-Z]"))
            {
                return "Miestui naudojam tik raides !";
            }
            else
            {
                return "001";
            }
        }
        public string TelefonoNumerisTikrinimas()
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

        public string ElpastasTikrinimas()
        {
            if (ElPastas.Length == 0)
            {
                return "002";
            }
            else if (!ElPastas.Contains('@') && !ElPastas.Contains('.'))
            {
                return "El. pašto adresas blogas, gal suklydote. Bandykit dar kartą";
            }
            else
            {
                return "001";
            }
        }
        public string GimimoDataTikrinimas()
        {
            try
            {
                string[] data = GimimoData.Split('-');
                foreach (var item in data)
                {
                    Convert.ToInt32(item);
                }

                 if (GimimoData.Length < 10 || GimimoData.Length > 10)
                {
                    return "Suklydote gimimo datą pvz 1999-12-01. Bandykit dar kartą";
                }
                else if (data[0].Length != 4 && Convert.ToInt32(data[0]) < 1900)
                {
                    return "Jūs blogai įvedėte metus, datos pvz. 1999-12-01";
                }
                else if (data[1].Length != 2 && Convert.ToInt32(data[1]) < 0 &&  Convert.ToInt32(data[1]) > 13)
                {
                    return "Jūs blogai įvedėte mėnesį, datos pvz. 1999-12-01";
                }
                else if (data[2].Length != 2 && Convert.ToInt32(data[2]) < 0 && Convert.ToInt32(data[1]) > 32)
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
                return "Klaida, datoje ne vien skaičiai";
            }
        }
        public static void Registracija()
        {
            File.AppendAllText(@"..\..\..\Vartotojai.txt", NameRegistracija + "," + PasswordRegistracija + " ");

            File.AppendAllText(@"..\..\..\Donorai.txt", NameRegistracija + "," + Vardas + "," + Pavarde + "," + Miestas + "," + TelefonoNumeris + "," + ElPastas + "," + GimimoData + "," + Lytis + "," + Saugoti_duomenis.KraujoGrupe + " ");
        }
    }
}

