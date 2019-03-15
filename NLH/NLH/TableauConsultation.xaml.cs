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
    /// Logique d'interaction pour TableauConsultation.xaml
    /// </summary>
    public partial class TableauConsultation : Window
    {
        public TableauConsultation()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var query =

            from v in MainWindow.db.Patients
            join m in MainWindow.db.DossierAdmissions on v.IdPatient equals m.IdPatient
            join c in MainWindow.db.Medicins on v.IdMedicin equals c.IdMedicin
            join t in MainWindow.db.CompagnieAssurances on v.IdCompagnie equals t.IdCompagnie
            join s in MainWindow.db.Parents on v.RefParent equals s.RefParent

            select new { v.NSS, v.Nom, v.Prenom, v.Telephone, m.IdAdmission, m.ChirurgieProgramme, m.DateChirurgie, m.NumeroLit, c.IdMedicin, c.Specialite, t.NomCompagnie, s.RefParent};
               

            dategrid.DataContext = query.ToList();
        }
    }
}
