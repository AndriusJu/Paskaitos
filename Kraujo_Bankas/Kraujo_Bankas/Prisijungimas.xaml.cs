using System;
using System.Collections.Generic;
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
    /// Interaction logic for Prisijungti.xaml
    /// </summary>
    public partial class Prisijungimas : Window
    {
        public Prisijungimas()
        {
            InitializeComponent();
           
        }

        private void Prisijungti_Click(object sender, RoutedEventArgs e)
        {
            Prisijungti PrisijungiDuomenys = new Prisijungti(Vardas.Text, Spaltazodis.Password);
            
            if (!PrisijungiDuomenys.Atsakymas())
            {

                // Eilute.Text = "Blogi prisijungimo duomenys";
                MessageBox.Show("Blogi prisijungimo duomenys");
                Vardas.Clear();
                Spaltazodis.Clear();
            }
            else
            {

                Pasirinkimas pasirinkimas = new Pasirinkimas();
                pasirinkimas.Show();
                Close();

            }

        }
    }   

    
}
