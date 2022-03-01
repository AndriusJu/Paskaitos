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

            RegistracijaDuomenys RegistracijosDuomenys = new RegistracijaDuomenys(RegistracijosVardas.Text, RegistracijosSlaptazodis.Text, RegistracijosSlaptazodis2.Text, Vardas.Text, Pavarde.Text, Miestas.Text, Telefononumeris.Text, Elpastas.Text, GimimoData.Text);

            if (RegistracijosDuomenys.vardas() != "001")
            {
                MessageBox.Show(RegistracijosDuomenys.vardas());
                RegistracijosVardas.Clear();
            }

            if (RegistracijosDuomenys.slaptazodis() != "001")
            {
                MessageBox.Show(RegistracijosDuomenys.slaptazodis());
                RegistracijosSlaptazodis.Clear();
                RegistracijosSlaptazodis2.Clear();
            }

            if (RegistracijosDuomenys.telefononumeris() != "001")
            {
                MessageBox.Show(RegistracijosDuomenys.telefononumeris());
                Telefononumeris.Clear();
            }

            
            if (RegistracijosDuomenys.elpastas() != "001")
            {
                MessageBox.Show(RegistracijosDuomenys.elpastas());
                Elpastas.Clear();
            }

            if (RegistracijosDuomenys.gimimodata() != "001")
            {
                MessageBox.Show(RegistracijosDuomenys.gimimodata());
                GimimoData.Clear();
            }



               
             if (Vyras.IsChecked == true)
             {
             RegistracijosDuomenys.Lytis = "Vyras";
             }
             else if (Moteris.IsChecked == true)
             {
             RegistracijosDuomenys.Lytis = "Moteris";
             }
             else
             {
             MessageBox.Show("Pasirinkite vyras ar moteris");
             }
                 
             




             RegistracijosDuomenys.Registruotis();
 
            // pataisyti kad atidarytu tik jei viskas good
             Pasirinkimas pasirinkimas = new Pasirinkimas();
             pasirinkimas.Show();
             Close();
        }
        }
      
    }
