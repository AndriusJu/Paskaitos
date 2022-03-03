using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
    /// Interaction logic for KuriKraujoGrupe.xaml
    /// </summary>
    public partial class KuriKraujoGrupe : Window
    {
        public KuriKraujoGrupe()
        {
            InitializeComponent();
        }
        
        private void KuriKraujo_Click(object sender, RoutedEventArgs e)
        {
        string Grupe = null;
        string Rezus = null;
            
            bool Atsakymas1 = Pirmas.Children.OfType<RadioButton>().Where(x => x.IsChecked == true).Any();
            bool Atsakymas2 = Antras.Children.OfType<RadioButton>().Where(x => x.IsChecked == true).Any();
            if (Atsakymas1 && Atsakymas2 == true)
            {
                if (O.IsChecked == true)
                {
                    Grupe = "O";
                }
                else if (A.IsChecked == true)
                {
                    Grupe = "A";
                }
                else if (B.IsChecked == true)
                {
                    Grupe = "B";
                }
                else if (AB.IsChecked == true)
                {
                    Grupe = "AB";
                }

                if (Teigiama.IsChecked == true)
                {
                    Rezus = "+";
                }
                else if (Neigiama.IsChecked == true)
                {
                    Rezus = "-";
                }
                string KraujoGrupe = Grupe + Rezus;

                Saugoti_duomenis.kraujogrupe(KraujoGrupe);
                Close();
            }
            else
            {
                MessageBox.Show("Neteisingai pažymėtas pasirinkimas");
            }
        }
    }
}
