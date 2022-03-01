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
    /// Interaction logic for RezervuotiKrauja.xaml
    /// </summary>
    public partial class RezervuotiKrauja : Window
    {
        public static string KraujoGrupe { get; set; }
        public RezervuotiKrauja()
        {
            InitializeComponent();
            KuriKraujoGrupe kurikraujogrupe = new KuriKraujoGrupe();
            kurikraujogrupe.ShowDialog();
        }

         private void Rezervuoti_Click(object sender, RoutedEventArgs e)
        {
            Saugoti_duomenis.rezervuojamasKraujas();
            Close();
            MessageBox.Show("Kraujas rezervuotas");
        }
    }
}
