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
    /// Interaction logic for IeskotiKraujo.xaml
    /// </summary>
    public partial class IeskotiKraujo : Window
    {
        public IeskotiKraujo()
        {
            InitializeComponent();
            KuriKraujoGrupe kurikraujogrupe = new KuriKraujoGrupe();
            kurikraujogrupe.ShowDialog();
        }
        private void Ieskoti_Toliau_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Saugoti_duomenis.IeskomasKraujas(Saugoti_duomenis.KraujoGrupe)); 
            Close();
        }
    }
}
