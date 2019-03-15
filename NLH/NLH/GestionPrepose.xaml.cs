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
    /// Logique d'interaction pour GestionPrepose.xaml
    /// </summary>
    public partial class GestionPrepose : Window
    {
        NHLEntities db = new NHLEntities();
        public GestionPrepose()
        {
            InitializeComponent();
        }

       

        private void btnQuitter_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dateprep.ItemsSource = db.Preposes.ToList();
            comb1.DataContext = db.Preposes.ToList();
        }

        private void btnMod_Click(object sender, RoutedEventArgs e)
        {
            Prepose rez = (Prepose)comb1.SelectedItem;
            rez.Nom = tbxNom.Text;
            rez.Prenom = tbxPrenom.Text;
            rez.Specialite = tbxspes.Text;
            db.SaveChanges();
            dateprep.ItemsSource = db.Preposes.ToList();
            
        }

        private void btnSup_Click(object sender, RoutedEventArgs e)
        {
            int s = Convert.ToInt32(comb1.Text);
            var rez = db.Preposes.Where(w => w.IdPrepose == s).FirstOrDefault();
            db.Preposes.Remove(rez);
            db.SaveChanges();
            dateprep.ItemsSource = db.Preposes.ToList();
            tbxNom.Text = "";
            tbxPrenom.Text = "";
            tbxspes.Text = "";
        }

        private void comb1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           Prepose prep = comb1.SelectedItem as Prepose;
            tbxNom.Text = Convert.ToString(prep.Nom);
            tbxPrenom.Text = Convert.ToString(prep.Prenom);
            tbxspes.Text = Convert.ToString(prep.Specialite);
        }
    }
}
