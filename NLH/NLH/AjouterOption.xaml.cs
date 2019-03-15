using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
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
    /// Logique d'interaction pour AjouterOption.xaml
    /// </summary>
    public partial class AjouterOption : Window
    {


        public AjouterOption()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            CompagnieAssurance comp = new CompagnieAssurance();

            comp.NomCompagnie = txtNomCompagnie.Text;




            MainWindow.db.CompagnieAssurances.Add(comp);
            try
            {
                MainWindow.db.SaveChanges();
            }


            catch (DbEntityValidationException ex)
            {
                Console.WriteLine(ex.ToString());
            }

            txtNomCompagnie.Text = "";
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Departement dep = new Departement();

            dep.NomDepartement = txtNomDepartement.Text;

            MainWindow.db.Departements.Add(dep);

            try
            {
                MainWindow.db.SaveChanges();
            }

            catch (DbEntityValidationException ex)
            {
                Console.WriteLine(ex.ToString());
            }

            txtNomDepartement.Text = "";
            cbDept.DataContext = MainWindow.db.Departements.ToList();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            TypeLit typeLit = new TypeLit();

            //typeLit.NumeroType = Convert.ToInt32(txtTypeLit.Text);
            typeLit.Description = txtDescripLit.Text;

            MainWindow.db.TypeLits.Add(typeLit);
            try
            {
                MainWindow.db.SaveChanges();
            }

            catch (DbEntityValidationException ex)
            {
                Console.WriteLine(ex.ToString());
            }


            txtDescripLit.Text = "";
            cbNumType.DataContext = MainWindow.db.TypeLits.ToList();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Lit1 lit2 = new Lit1();
            // lit1.numeroLit = Convert.ToInt32(txtNumLit.Text);
            lit2.Occupe = txtOccupe.Text;
            lit2.NumeroType = Convert.ToInt32(cbNumType.Text);
            lit2.IdDepartament = Convert.ToInt32(cbDept.Text);

            MainWindow.db.Lit1.Add(lit2);
            try
            {
                MainWindow.db.SaveChanges();
            }

            catch (DbEntityValidationException ex)
            {
                Console.WriteLine(ex.ToString());
            }



            txtOccupe.Text = "";
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cbNumType.DataContext = MainWindow.db.TypeLits.ToList();
            cbDept.DataContext = MainWindow.db.Departements.ToList();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {

            Parent par = new Parent();

            par.Nom = txtNom.Text;
            par.Prenom = txtPrenom.Text;
            par.Adresse = txtAdress.Text;
            par.Ville = txtVille.Text;
            par.Province = txtProvince.Text;
            par.CodePostal = txtCodepostal.Text;
            par.Telephone = txtTelephone.Text;


            MainWindow.db.Parents.Add(par);
            try
            {
                MainWindow.db.SaveChanges();
            }

            catch (DbEntityValidationException ex)
            {
                Console.WriteLine(ex.ToString());
            }



            txtNom.Text = "";
            txtPrenom.Text = "";
            txtAdress.Text = "";
            txtVille.Text = "";
            txtProvince.Text = "";
            txtCodepostal.Text = "";
            txtTelephone.Text = "";
        }
    }
}
