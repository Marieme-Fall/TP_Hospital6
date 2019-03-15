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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NLH
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        

        public static  NHLEntities db = new NHLEntities();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(tbxLogin.Text))
            {
                MessageBox.Show("Introduisez votre login.", "Message", MessageBoxButton.OK, MessageBoxImage.Warning);
                tbxLogin.Focus();
                return;
            }

            foreach (var user1 in db.TableUsers)


            {
                if ((user1.UserName.Replace(" ", "") == tbxLogin.Text) & (user1.Password.Replace(" ", "") == tbxPass.Password))
                {

                    if ((comb1.Text == "admin") & (user1.TypeUser == "admin"))
                    {
                        new AdminPage().Show();
                        return;
                    }
                    else if ((comb1.Text == "medicin") & (user1.TypeUser == "medicin"))
                    {
                        new MedicinPage().Show();
                        return;
                    }
                    else if ((comb1.Text == "prepose") & (user1.TypeUser == "prepose"))
                    {
                        new PreposePage().Show();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Username, Password or type User incorrect");
                    }


                }


            }


        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void NHL_Loaded(object sender, RoutedEventArgs e)
        {
            comb1.DataContext = db.TableUsers.ToList();
        }
    }
}
