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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Duomenys_Library;

namespace Kraujo_Bankas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            NuskaitytiDuomenisIsFailo.VartotojuDuomenysFailas();
            NuskaitytiDuomenisIsFailo.DonoruDuomenysFailas();
            NuskaitytiDuomenisIsFailo.PaaukotasKraujasFailas();
            NuskaitytiDuomenisIsFailo.RezervuojuKraujaFailas();
        }
        private void Pasirinkimas_Prisijungti_Click(object sender, RoutedEventArgs e)
        {
            Prisijungimas Jungtis = new Prisijungimas();
            Jungtis.Show();
            Close();
        }
        private void Registruotis_Click(object sender, RoutedEventArgs e)
        {
            Registruotis Registruotis = new Registruotis();
            Registruotis.Show();
            Close();
        }
    }
}
