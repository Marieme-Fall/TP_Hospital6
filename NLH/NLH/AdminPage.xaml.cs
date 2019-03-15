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
    /// Logique d'interaction pour AdminPage.xaml
    /// </summary>
    public partial class AdminPage : Window
    {
        public AdminPage()
        {
            InitializeComponent();
           
           
        }

        private void Quitter_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void menuTab_Click(object sender, RoutedEventArgs e)
        {
            TableauConsultation tb = new TableauConsultation();
            tb.ShowDialog();
            this.Hide();

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
       
            new AjouterMedicin().ShowDialog();
            this.Hide();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
       
            new AjouterPrepose().ShowDialog();
            this.Hide();

        }
    }
}
