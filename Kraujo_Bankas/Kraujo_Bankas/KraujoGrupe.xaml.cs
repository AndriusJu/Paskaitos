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
    /// Interaction logic for KraujoGrupe.xaml
    /// </summary>
    public partial class KraujoGrupe : Window
    {
        public static string Grupe { get; set; }
        public KraujoGrupe()
        {
            InitializeComponent();
        }
        private void KraujoGrupe_Click(object sender, RoutedEventArgs e)
        {
            string KraujoGrupe = null;
            string Rezus = null;
            if (O.IsChecked == true)
            {
                KraujoGrupe = "O";
            }
            else if (A.IsChecked == true)
            {
                KraujoGrupe = "A";
            }
            else if (B.IsChecked == true)
            {
                KraujoGrupe = "B";
            }
            else if (AB.IsChecked == true)
            {
                KraujoGrupe = "AB";
            }
            if (Teigiama.IsChecked == true)
            {
                Rezus = "+";
            }
            else if (Neigiama.IsChecked == true)
            {
                Rezus = "-";
            }
            Grupe = KraujoGrupe + Rezus;



        }
    }
}
