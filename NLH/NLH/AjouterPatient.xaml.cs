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
    /// Logique d'interaction pour AjouterPatient.xaml
    /// </summary>
    public partial class AjouterPatient : Window
    {

        NHLEntities db = new NHLEntities();
        public AjouterPatient()
        {
            InitializeComponent();
        }

        private void btnQuitter_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnAjouter_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                Patient p1 = new Patient();
                p1.NSS = txtNSS.Text;
                p1.DateNaissance = txtdate.SelectedDate;
                p1.Nom = txtNom.Text;
                p1.Prenom = txtPrenom.Text;
                p1.TypePatient = com1.Text;
                p1.Adresse = txtAd.Text;
                p1.Ville = txtVille.Text;
                p1.Province = txtProv.Text;
                p1.CodePostal = txtCodePostal.Text;
                p1.Telephone = txtTel.Text;
                p1.IdMedicin = Convert.ToInt32(comb2.Text);
                p1.IdCompagnie = Convert.ToInt32(comb3.Text);
                p1.RefParent = Convert.ToInt32(comb4.Text);

                db.Patients.Add(p1);
                db.SaveChanges();
                listegride.ItemsSource = db.Patients.ToList();
                txtNSS.Text = "";

                txtNom.Text = "";
                txtPrenom.Text = "";
                txtAd.Text = "";
                txtVille.Text = "";
                txtProv.Text = "";
                txtCodePostal.Text = "";
                txtTel.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Ajout de patient impossible!", "Message", MessageBoxButton.OK, MessageBoxImage.Warning);

            }


        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            listegride.ItemsSource = db.Patients.ToList();
            comb2.DataContext = db.Medicins.ToList();
            comb3.DataContext = db.CompagnieAssurances.ToList();
            comb4.DataContext = db.Parents.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new GestionPatient().Show();
        }
    }
}
