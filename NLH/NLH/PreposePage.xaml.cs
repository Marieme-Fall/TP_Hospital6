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

namespace NLH
{
    /// <summary>
    /// Logique d'interaction pour PreposePage.xaml
    /// </summary>
    public partial class PreposePage : Window
    {
        public PreposePage()
        {
            InitializeComponent();
        }

        private void Quitter_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
          Inscription   d1 = new Inscription();
            d1.ShowDialog();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
           

           new AjouterPatient().ShowDialog();
        }

        private void menuTab_Click(object sender, RoutedEventArgs e)
        {
            RecherchePatient rech1 = new RecherchePatient();
            rech1.ShowDialog();
        }

        private void option_Click(object sender, RoutedEventArgs e)
        {
            new AjouterOption().Show();
        }
    }
}
