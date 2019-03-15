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
    /// Logique d'interaction pour AjouterPrepose.xaml
    /// </summary>
    public partial class AjouterPrepose : Window
    {

        NHLEntities db = new NHLEntities();

        public AjouterPrepose()
        {
            InitializeComponent();
        }

        private void btnQuitter_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnAjouter_Click(object sender, RoutedEventArgs e)
        {
            Prepose p1 = new Prepose();

            p1.Nom = tbxNom.Text;
            p1.Prenom = tbxPrenom.Text;
            p1.Specialite = tbxspes.Text;
            db.Preposes.Add(p1);
            db.SaveChanges();
            dateprep.ItemsSource = db.Preposes.ToList();
            tbxNom.Text = "";
            tbxPrenom.Text = "";
            tbxspes.Text = "";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new GestionPrepose().Show();
            this.Hide();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dateprep.ItemsSource = db.Preposes.ToList();
        }
    }
}
