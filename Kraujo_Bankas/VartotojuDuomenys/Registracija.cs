using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VartotojuDuomenys
{
    public class Registracija
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
        private static string Lytis { get; set; }

        private static string tekstas { get; set; }

     

        public static string DonoruFailas = @"..\..\..\Donorai.txt";
        public static void DonoruDuomenysFailas(string donorufailas)
        {
            DonoruFailas = donorufailas;

            bool ArYraFailas = File.Exists(donorufailas);
            if (!ArYraFailas) { File.Create(donorufailas); };

        }
        public Registracija(string RegistracijosVardas, string RegistracijosSlaptazodis, string RegistracijosSlaptazodis2, string vardas, string pavarde, string miestas, string telefononumeris, string elpastas, string gimimoData, string lytis)
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
            Lytis = lytis;
        }

        public static bool vardas(string RegistracijosVardas)
        {
            string tekstas = File.ReadAllText(@"..\..\..\Vartotojai.txt");
            return tekstas.Contains(RegistracijosVardas);
        }
       
        private static void Registruotis()
        {
            tekstas = File.ReadAllText(@"..\..\..\Vartotojai.txt");
            bool Name = tekstas.Contains(NameRegistracija);
            if (Name)
            {
                // "Toks vardas jau yra";
                
            }
            else
            {
                Console.WriteLine("Įveskite slaptažodį: ");
                PasswordRegistracija = Console.ReadLine();

                while (PasswordRegistracija.Length < 6)
                {
                    Console.WriteLine("Slaptažodis pertrumpas bandykit dar kartą");
                    PasswordRegistracija = Console.ReadLine();
                }
                Console.WriteLine("Įveskite savo vardą: ");
                Vardas = Console.ReadLine();

                Console.WriteLine("Įveskite savo pavarde: ");
                Pavarde = Console.ReadLine();

                Console.WriteLine("Įveskite savo miesta: ");
                Miestas = Console.ReadLine();

                Console.WriteLine("Įveskite savo telefono numerį: ");
                TelefonoNumeris = Console.ReadLine();
                while (TelefonoNumeris.Length < 9)
                {
                    Console.WriteLine("Telefono numeris pertrumpas, gal suklydote. Bandykit dar kartą");
                    TelefonoNumeris = Console.ReadLine();
                }

                Console.WriteLine("Įveskite savo El.Pašta: ");
                ElPastas = Console.ReadLine();
                while (!ElPastas.Contains('@') && !ElPastas.Contains('.'))
                {
                    Console.WriteLine("El. pašto adresas blogas, gal suklydote. Bandykit dar kartą");
                    ElPastas = Console.ReadLine();
                }

                Console.WriteLine("Įveskite savo gimimo data pvz.(1990-01-01): ");
                GimimoData = Console.ReadLine();
                while (GimimoData.Length < 10)
                {
                    Console.WriteLine("Gimimo data pertrumpa gal suklydote. Bandykit dar kartą");
                    GimimoData = Console.ReadLine();
                }

                Console.WriteLine("Įveskite savo lytį (vyr, mot): ");
                Lytis = Console.ReadLine().ToLower();
                while (Lytis != "vyr" || Lytis != "mot")
                {
                    Console.WriteLine("Lytį įvedėte blogai. Bandykit dar kartą");
                    Lytis = Console.ReadLine().ToLower();
                }
                File.AppendAllText(@"..\..\..\Vartotojai.txt", NameRegistracija + "," + PasswordRegistracija + " ");
                Console.WriteLine("Įveskite kokia kraujo grupė ir teigima ar ne ? \n" +
                             "O (+ AR -)\n" +
                             "A (+ AR -)\n" +
                             "B (+ AR -)\n" +
                             "AB (+ AR -)\n");
                string grupe = Console.ReadLine();
                File.AppendAllText(@"..\..\..\Donorai.txt", Vardas + "," + Pavarde + "," + Miestas + "," + TelefonoNumeris + "," + ElPastas + "," + GimimoData + "," + Lytis + "," + grupe + " ");
                Console.WriteLine("Jūs Užsiregistravote");
                //Pasirinkimas.Pasirinkite();

            }
        }
    }
}
