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
using Duomenys_Library;

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
            Duomenys PrisijungiDuomenys = new Duomenys(Vardas.Text, Spaltazodis.Password);
            
            if (!PrisijungiDuomenys.Prisijungimas())
            {
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
