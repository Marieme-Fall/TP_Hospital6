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
    /// Logique d'interaction pour RecherchePatient.xaml
    /// </summary>
    public partial class RecherchePatient : Window
    {
        NHLEntities db = new NHLEntities();


        public RecherchePatient()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnRech_Click(object sender, RoutedEventArgs e)
        {

            string nr = txtNSS.Text;

            var q = from a in db.Patients
                    where a.NSS == nr
                    select a;
            // var rez = db.Patients.Where(w => w.IdPatient == nr);
            listegride.ItemsSource = q.ToList();
            txtNSS.Text = "";
        }
    }
}
