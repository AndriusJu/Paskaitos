using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using VartotojuDuomenys;

namespace Kraujo_Bankas
{
    /// <summary>
    /// Interaction logic for Registracija.xaml
    /// </summary>
    public partial class Registruotis : Window
    {
        public Registruotis()
        {
            InitializeComponent();

        }
           

            private void Toliau_Click(object sender, RoutedEventArgs e)
        {

               // Registracija RegistracijosDuomenys = new Registracija(RegistracijosVardas.ToString(),RegistracijosSlaptazodis.ToString(),RegistracijosSlaptazodis2.ToString(),Vardas.ToString(),Pavarde.ToString(),Miestas.ToString(),Telefononumeris.ToString(),Elpastas.ToString(),GimimoData.ToString(),Lytis);
                
                //if (Name = true)
                //{
                //    MessageBox.Show("Toks vardas jau yra, bandykite kita");
                //    RegistracijosVardas.Clear();
                //}

                if (RegistracijosSlaptazodis.Text.Length < 6 || RegistracijosSlaptazodis != RegistracijosSlaptazodis2)
                {
                    MessageBox.Show("Slaptažodis pertrumpas bandykit dar kartą");
                    RegistracijosSlaptazodis.Clear();
                }


                string vardas = Vardas.Text;
                string pavarde = Pavarde.Text;
                string miestas = Miestas.Text;


                string telefonoNumeris = Telefononumeris.Text;
                if (telefonoNumeris.Length == 9)
                {
                    MessageBox.Show("Telefono numeris pertrumpas, gal suklydote. Bandykit dar kartą");
                    Telefononumeris.Clear();
                }


                string elPastas = Elpastas.Text;
                if (!elPastas.Contains('@') && !elPastas.Contains('.'))
                {
                    MessageBox.Show("El. pašto adresas blogas, gal suklydote. Bandykit dar kartą");
                    Elpastas.Clear();

                }
                string gimimoData = GimimoData.Text;
              
            if (gimimoData.Length < 10 )
                {
                    MessageBox.Show("Gimimo data pertrumpa gal suklydote. Bandykit dar kartą");
                     GimimoData.Clear();

                 }
            else if (gimimoData.Any(char.IsDigit))
                {
                Console.WriteLine(gimimoData.Any(char.IsDigit));
            }
                string Lytis = null;
                if (Vyras.IsChecked == true)
                {
                    Lytis = "Vyras";
                }
                if (Moteris.IsChecked == true)
                {
                    Lytis = "Moteris";
                }

                File.AppendAllText(@"..\..\..\Vartotojai.txt", RegistracijosVardas.Text + "," + RegistracijosSlaptazodis.Text + " ");

                File.AppendAllText(@"..\..\..\Donorai.txt", Vardas + "," + Pavarde + "," + Miestas + "," + Telefononumeris + "," + Elpastas + "," + GimimoData + "," + Lytis + " ");
                Console.WriteLine("Jūs Užsiregistravote");
             Pasirinkimas pasirinkimas = new Pasirinkimas();
             pasirinkimas.Show();
             this.Close();
        }
        }
      
    }
