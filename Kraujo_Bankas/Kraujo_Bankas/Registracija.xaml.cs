using Duomenys_Library;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Kraujo_Bankas
{
    /// <summary>
    /// Interaction logic for Registracija.xaml
    /// </summary>
    public partial class Registruotis : Window
    {
        public Registruotis()
        {
            InitializeComponent();
        }
        private void Toliau_Click(object sender, RoutedEventArgs e)
        {
            try
         {
                Duomenys RegistracijosDuomenys = new Duomenys(RegistracijosVardas.Text, RegistracijosSlaptazodis.Text, RegistracijosSlaptazodis2.Text, Vardas.Text, Pavarde.Text, Miestas.Text, Telefononumeris.Text, Elpastas.Text, GimimoData.Text);

                bool Atsakymas3 = Laukeliai.Children.OfType<TextBox>().Any(x => x.Text.Length != 0);
                bool Atsakymas1 = Lyties_Laukelis.Children.OfType<RadioButton>().Where(x => x.IsChecked == true).Any();
               
                if (!Atsakymas3 && !Atsakymas1)
                {
                    MessageBox.Show("Užpildykite visus laukelius");
                }
                else if (Atsakymas3 || Atsakymas1)
                {
                    if (RegistracijosDuomenys.NameRegistracijaTikrinimas() == "002"){}
                    else if (RegistracijosDuomenys.NameRegistracijaTikrinimas() != "001")
                    {
                        MessageBox.Show(RegistracijosDuomenys.NameRegistracijaTikrinimas());
                        RegistracijosVardas.Clear();
                    }

                    if (RegistracijosDuomenys.SlaptazodisTikrinimas() == "002") { }
                    else if (RegistracijosDuomenys.SlaptazodisTikrinimas() != "001")
                    {
                        MessageBox.Show(RegistracijosDuomenys.SlaptazodisTikrinimas());
                        RegistracijosSlaptazodis.Clear();
                        RegistracijosSlaptazodis2.Clear();
                    }

                    if (RegistracijosDuomenys.VardasTikrinimas() == "002") { }
                    else if (RegistracijosDuomenys.VardasTikrinimas() != "001")
                    {
                        MessageBox.Show(RegistracijosDuomenys.VardasTikrinimas());
                        Vardas.Clear();
                    }

                    if (RegistracijosDuomenys.PavardeTikrinimas() == "002") { }
                    else if (RegistracijosDuomenys.PavardeTikrinimas() != "001")
                    {
                        MessageBox.Show(RegistracijosDuomenys.PavardeTikrinimas());
                        Pavarde.Clear();
                    }

                    if (RegistracijosDuomenys.MiestasTikrinimas() == "002") { }
                    else if (RegistracijosDuomenys.MiestasTikrinimas() != "001")
                    {
                        MessageBox.Show(RegistracijosDuomenys.MiestasTikrinimas());
                        Miestas.Clear();
                    }

                    if (RegistracijosDuomenys.TelefonoNumerisTikrinimas() != "001")
                    {
                        MessageBox.Show(RegistracijosDuomenys.TelefonoNumerisTikrinimas());
                        Telefononumeris.Clear();
                    }

                    if (RegistracijosDuomenys.ElpastasTikrinimas() == "002") { }
                    else if (RegistracijosDuomenys.ElpastasTikrinimas() != "001")
                    {
                        MessageBox.Show(RegistracijosDuomenys.ElpastasTikrinimas());
                        Elpastas.Clear();
                    }

                    if (RegistracijosDuomenys.GimimoDataTikrinimas() != "001")
                    {
                        MessageBox.Show(RegistracijosDuomenys.GimimoDataTikrinimas());
                        GimimoData.Clear();
                    }

                    if (Vyras.IsChecked == true)
                    {
                        Duomenys.Lytis = "Vyras";
                    }
                    else if (Moteris.IsChecked == true)
                    {
                        Duomenys.Lytis = "Moteris";
                    }
                    else
                    {
                        MessageBox.Show("Pasirinkite vyras ar moteris");
                    }
                    bool Atsakymas = Laukeliai.Children.OfType<TextBox>().All(x => x.Text.Length != 0);
                    
                    if (Atsakymas && Atsakymas1)
                    {
                        KuriKraujoGrupe kurikraujogrupe = new KuriKraujoGrupe();
                        kurikraujogrupe.ShowDialog();

                        if (Saugoti_duomenis.KraujoGrupe != null)
                        {
                            Duomenys.Registracija();
                            Pasirinkimas pasirinkimas = new Pasirinkimas();
                            pasirinkimas.Show();
                            Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Įvyko kalida !" + ex.Message);
            }
        }
        private void RegistracijosSlaptazodis2_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Nezianu kaip padaryt kad palauktu kol antra karta ives slaptazodi
            
        }
      }
}    
  

       
