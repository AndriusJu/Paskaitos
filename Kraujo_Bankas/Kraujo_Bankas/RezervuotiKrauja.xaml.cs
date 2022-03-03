using Duomenys_Library;
using System.Windows;

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
            Close();
            MessageBox.Show($"Kraujas rezervuotas !  \n Šiuo metu jau rezervuota: {Saugoti_duomenis.rezervuojamasKraujas()}");
        }
    }
}
