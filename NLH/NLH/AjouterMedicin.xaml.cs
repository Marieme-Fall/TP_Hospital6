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
    /// Logique d'interaction pour AjouterMedicin.xaml
    /// </summary>
    public partial class AjouterMedicin : Window
    {


        NHLEntities db = new NHLEntities();

        public AjouterMedicin()
        {
            InitializeComponent();
        }

        private void btnQuitter_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnAjouter_Click(object sender, RoutedEventArgs e)
        {
            Medicin m1 = new Medicin();
          
            m1.Nom = tbxNom.Text;
            m1.Prenom = tbxPrenom.Text;
            m1.Specialite = tbxspes.Text;
            db.Medicins.Add(m1);
            db.SaveChanges();
            datemed.ItemsSource = db.Medicins.ToList();
            tbxNom.Text = "";
            tbxPrenom.Text = "";
            tbxspes.Text = "";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new GestionMed().Show();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            datemed.ItemsSource = db.Medicins.ToList();
        }
    }
}
