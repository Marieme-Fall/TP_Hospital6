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
    /// Logique d'interaction pour Inscription.xaml
    /// </summary>
    public partial class Inscription : Window
    {
        public Inscription()
        {
            InitializeComponent();
        }

        private void btnEffec_Click(object sender, RoutedEventArgs e)
        {
            new Paiement().Show();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dateAd1.ItemsSource = MainWindow.db.DossierAdmissions.ToList();
            comb1.DataContext = MainWindow.db.Patients.ToList();
            comb2.DataContext = MainWindow.db.Lit1.ToList();
            cbNumType.DataContext = MainWindow.db.TypeLits.ToList();
            dateConge.IsEnabled = false;


           /* var query =

           from l in MainWindow.db.Lit1
           join c in MainWindow.db.Departements on l.IdDepartament equals c.IdDepartement
           select new { l.NumeroLit };
            comb2.ItemsSource = query.ToList();*/
        }
        
        private void comb2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Lit1 x = comb2.SelectedItem as Lit1;
            int nr = Convert.ToInt32(x.NumeroLit);
            var rez = MainWindow.db.Lit1.Where(w => w.NumeroLit == nr).FirstOrDefault();
            txtOccup.Text = rez.Occupe;
            x.Occupe = txtOccup.Text;
            MainWindow.db.SaveChanges();
            // Lit1 x = comb2.SelectedItem as Lit1;
            //  txtDes.Text = MainWindow.db.TypeLits.des
            //  int nr = Convert.ToInt32(comb2.SelectedItem);
            //  var rez = MainWindow.db.Lit1.Where(w => w.NumeroLit == nr).FirstOrDefault();


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            try
            {

                Lit1 l = new Lit1();
                DossierAdmission p1 = new DossierAdmission();
                
                p1.ChirurgieProgramme = txtChirurgie.Text;
                p1.DateAdmission = dateAd.SelectedDate;
                p1.DateChirurgie = dateChirurgie.SelectedDate;
               
            
                p1.IdPatient = Convert.ToInt32(comb1.Text);
                p1.NumeroLit= Convert.ToInt32(comb2.Text);
             
                l.Occupe = txtOccup.Text;
           

                MainWindow.db.DossierAdmissions.Add(p1);
                MainWindow.db.SaveChanges();
                dateAd1.ItemsSource = MainWindow.db.DossierAdmissions.ToList();
                txtChirurgie.Text = "";

            }
            catch (Exception)
            {
                MessageBox.Show("Ajout de dossier impossible!", "Message", MessageBoxButton.OK, MessageBoxImage.Warning);

            }
        }

        private void dateAd1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void cbNumType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           // TypeLit t1 = cbNumType.SelectedItem as TypeLit;
           // txtDesc.Text = t1.Description;
          //  int nr = Convert.ToInt32(t1.NumeroType);
          //  var rez = MainWindow.db.Lit1.Where(w => w.NumeroLit == nr).FirstOrDefault();
          //  txtOccup.Text = rez.Occupe;


        }

        private void combDepartement_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           

            //dataGrid1.ItemsSource = query.ToList();
            // Departement d1 = combDepartement.SelectedItem as Departement;

            // int nr = Convert.ToInt32(d1.IdDepartement);
            // var rez = MainWindow.db.Lit1.Where(w => w.IdDepartament== nr).FirstOrDefault();
            // comb2.DataContext = MainWindow.db.Lit1.ToList();

        }
    }
}
