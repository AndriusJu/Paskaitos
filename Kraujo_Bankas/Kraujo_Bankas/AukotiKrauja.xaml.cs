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
    /// Interaction logic for AukotiKrauja.xaml
    /// </summary>
    public partial class AukotiKrauja : Window
    {
       public AukotiKrauja()
        {
            InitializeComponent();
            KuriKraujoGrupe kurikraujogrupe = new KuriKraujoGrupe();
            kurikraujogrupe.ShowDialog();
        }
        private void Aukoti_Click(object sender, RoutedEventArgs e)
        {
            Saugoti_duomenis.PaukotasKraujas();
            Close();
            MessageBox.Show("Ačiū už jūsų auką.");
            // Neiraso kokios grupes nes neaisku kuri grupe prisijungiant....
        }
    }
}
