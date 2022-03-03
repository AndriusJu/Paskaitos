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

namespace Kraujo_Bankas
{
    /// <summary>
    /// Interaction logic for Pasirinkimas.xaml
    /// </summary>
    public partial class Pasirinkimas : Window
    {
        public Pasirinkimas()
        {
            InitializeComponent();
        }

        private void AukotiKrauja_Click(object sender, RoutedEventArgs e)
        {
            AukotiKrauja Aukoti = new AukotiKrauja();
            Aukoti.Show();
            Close();
        }
        private void RezervuotiKrauja_Click(object sender, RoutedEventArgs e)
        {
            RezervuotiKrauja Rezervuoti = new RezervuotiKrauja();
            Rezervuoti.Show();
            Close();
        }
        private void IeskotiKraujo_Click(object sender, RoutedEventArgs e)
        { 
            IeskotiKraujo Ieskoti = new IeskotiKraujo();
            Ieskoti.Show();
            Close();
        }
    }
}
