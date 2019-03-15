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
    /// Logique d'interaction pour GestionMed.xaml
    /// </summary>
    public partial class GestionMed : Window
    {

        NHLEntities db = new NHLEntities();

        public GestionMed()
        {
            InitializeComponent();
        }

        private void btnQuitter_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            datemed.ItemsSource = db.Medicins.ToList();
            comb1.DataContext = db.Medicins.ToList();
        }

 

        private void btnMod_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Medicin rez = (Medicin)comb1.SelectedItem;
                rez.Nom = tbxNom.Text;
                rez.Prenom = tbxPrenom.Text;
                rez.Specialite = tbxspes.Text;
                db.SaveChanges();
                datemed.ItemsSource = db.Medicins.ToList();
            }
            catch (Exception)
            {
                MessageBox.Show("Modification du donnees du medicin impossible car il est lie avec un patient!", "Message", MessageBoxButton.OK, MessageBoxImage.Warning);


            }




        }

        private void btnSup_Click(object sender, RoutedEventArgs e)
        {

          
                int nr = Convert.ToInt32(comb1.Text);
                var rez = db.Patients.Where(w => w.IdMedicin == nr).FirstOrDefault();
              
                if (rez != null)
                {
                    MessageBox.Show("Suppression du medicin impossible car il est lie avec un patient!", "Message", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else
                {
                    Medicin m = db.Medicins.Where(w => w.IdMedicin == nr).FirstOrDefault();
                    db.Medicins.Remove(m);

                    db.SaveChanges();
                MessageBox.Show("Medicin supprime avec succes!", "Message", MessageBoxButton.OK, MessageBoxImage.Warning);
                datemed.ItemsSource = db.Medicins.ToList();
                    comb1.DataContext = db.Medicins.ToList();

                }

            
          

        }

     

        private void comb1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Medicin med = comb1.SelectedItem as Medicin;
            tbxNom.Text = Convert.ToString(med.Nom);
            tbxPrenom.Text = Convert.ToString(med.Prenom);
            tbxspes.Text = Convert.ToString(med.Specialite);
        }
    }
}
