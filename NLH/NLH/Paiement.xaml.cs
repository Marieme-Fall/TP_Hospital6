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
    /// Logique d'interaction pour Paiement.xaml
    /// </summary>
    public partial class Paiement : Window
    {
        public Paiement()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dateAd1.ItemsSource = MainWindow.db.PaiementFrais.ToList();
            comb1.DataContext = MainWindow.db.DossierAdmissions.ToList();
        }

        private void btnCal_Click(object sender, RoutedEventArgs e)
        {/*
            double fraisChambre = 0;
            int idAdmission2 = Convert.ToInt32(comb1.Text);
     
            var rez = MainWindow.db.DossierAdmissions.Where(x => x.IdAdmission == idAdmission2).FirstOrDefault();// rez recupere une ligne de la table Dossier Admission
            int numlit = Convert.ToInt32(rez2.NumeroLit);
            //if  rez2.Commodite == "oui";
            switch (numlit)
            {
                case 1:
                    rez.FraisChambre = 42.5;
                   
                    // rez.FraisComodite;
                    rez.MontantFacture = fraisChambre;
                    txtFraisCham.Text= rez.MontantFacture.ToString();
                    break;

                case 2:
                    rez.FraisChambre = 267;
                    // rez.FraisComodite;
                    rez.MontantFacture = fraisChambre;
                    txtFraisCham.Text = rez.MontantFacture.ToString();
                    break;
                case 3:
                    rez.FraisChambre = 571;
                    // rez.FraisComodite;
                    rez.MontantFacture = fraisChambre;
                    txtFraisCham.Text = rez.MontantFacture.ToString();
                    break;

                default:
                    break;

            }

            */


        }
    }
}
