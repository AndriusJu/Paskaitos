using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VartotojuDuomenys
{
    public class Vartotoju_Duomenys
    {

        public static string DuomenuFailas = @"..\..\..\Vartotojai.txt";
        public static string DonoruFailas = @"..\..\..\Donorai.txt";


        public static void VartotojuDuomenysFailas(string duomenufailas)
        {
            DuomenuFailas = duomenufailas;

            bool ArYraFailas = File.Exists(duomenufailas);
            if (ArYraFailas == false) { File.Create(duomenufailas); };

        }
        public static void DonoruDuomenysFailas(string donorufailas)
        {
            DonoruFailas = donorufailas;

            bool ArYraFailas = File.Exists(donorufailas);
            if (ArYraFailas == false) { File.Create(donorufailas); };

        }



    }
}
