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
    /// Logique d'interaction pour MedicinPage.xaml
    /// </summary>
    public partial class MedicinPage : Window
    {

       // NHLEntities db = new NHLEntities();
        public MedicinPage()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            comb1.DataContext = MainWindow.db.DossierAdmissions.ToList();
            textDateAd.IsEnabled = false;
            dateAd1.ItemsSource = MainWindow.db.DossierAdmissions.ToList();
        }

        private void comb1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
       
            DossierAdmission d1 =comb1.SelectedItem as DossierAdmission;
            textDateAd.Text = d1.DateAdmission.ToString();
            
             dateCong.SelectedDate = d1.DateConge;
            txtNumLit.Text = d1.NumeroLit.ToString();
            int nr = Convert.ToInt32(txtNumLit.Text);
            var rez = MainWindow.db.Lit1.Where(w => w.NumeroLit == nr).FirstOrDefault();
            txtOcupp.Text= rez.Occupe;

        }

        private void btnDon_Click(object sender, RoutedEventArgs e)
        {
            DossierAdmission d1 = (DossierAdmission)comb1.SelectedItem;
            d1.DateConge = dateCong.SelectedDate;
            
            MainWindow.db.SaveChanges();
            dateAd1.ItemsSource = MainWindow.db.DossierAdmissions.ToList();
        }
    }
}
