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
    /// Logique d'interaction pour GestionPatient.xaml
    /// </summary>
    public partial class GestionPatient : Window
    {

        NHLEntities db = new NHLEntities();

        public GestionPatient()
        {
            InitializeComponent();
        }

        private void btnSup_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            listegride.ItemsSource = db.Patients.ToList();
            combobox1.DataContext = db.Patients.ToList();
            comb2.DataContext = db.Medicins.ToList();
            comb3.DataContext = db.CompagnieAssurances.ToList();
            comb4.DataContext = db.Parents.ToList();
        }

        
        private void btnMod_Click(object sender, RoutedEventArgs e)
        {

            Patient rez = (Patient)combobox1.SelectedItem;

            rez.NSS=txtNSS.Text; 
            rez.DateNaissance = txtdate.SelectedDate;
            rez.Nom = txtNom.Text;
            rez.Prenom = txtPrenom.Text;
            rez.TypePatient = com1.Text;
            rez.Adresse = txtAd.Text;
            rez.Ville = txtVille.Text;
            rez.Province = txtProv.Text;
            rez.CodePostal = txtCodePostal.Text;
            rez.Telephone = txtTel.Text;
            rez.IdMedicin = Convert.ToInt32(comb2.Text);
            rez.IdCompagnie = Convert.ToInt32(comb3.Text);
            rez.RefParent = Convert.ToInt32(comb4.Text);

            db.SaveChanges();
            listegride.ItemsSource = db.Patients.ToList();
        }

        private void btnSup_Click_1(object sender, RoutedEventArgs e)
        {
            int nr = Convert.ToInt32(combobox1.Text);
            var rez = db.Patients.Where(w => w.IdPatient == nr).FirstOrDefault();
            db.Patients.Remove(rez);
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

       

        private void combobox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Patient pat1 = combobox1.SelectedItem as Patient;
            txtNSS.Text = Convert.ToString(pat1.NSS);
            txtdate.SelectedDate = pat1.DateNaissance;
            txtNom.Text = Convert.ToString(pat1.Nom);
            txtPrenom.Text = Convert.ToString(pat1.Prenom);
            com1.Text= (Convert.ToString(pat1.TypePatient)).Trim();
            txtAd.Text = Convert.ToString(pat1.Adresse);
            txtVille.Text = Convert.ToString(pat1.Ville);
            txtAd.Text = Convert.ToString(pat1.Adresse);
            txtProv.Text = Convert.ToString(pat1.Province);
            txtCodePostal.Text = Convert.ToString(pat1.CodePostal);
            txtTel.Text = Convert.ToString(pat1.Telephone);
            comb2.Text = (Convert.ToString(pat1.IdMedicin)).Trim();
            comb3.Text = (Convert.ToString(pat1.IdCompagnie)).Trim();
            comb4.Text = (Convert.ToString(pat1.RefParent)).Trim();


        }
    }
}
