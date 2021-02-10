using Microsoft.EntityFrameworkCore;
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

namespace EntityOneToMore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IskolaContext context = new IskolaContext();
        public MainWindow()
        {
            InitializeComponent();

            //AddOsztaly();
            //AddTanulo();

            //context.SaveChanges();

            context.Tanulo.Load();
            context.Osztaly.Load();

            DG_tanulok.ItemsSource = context.Tanulo.Local.ToObservableCollection();
            DG_osztaly.ItemsSource = context.Osztaly.Local.ToObservableCollection();

            var o = context.Osztaly.Local.OrderBy(x => x.osztalyNev).ToList();
            o.Insert(0, new Osztaly() { osztalyId = -1, osztalyNev = "Kérem Válasszon!" });
            CBO_osztalyok.ItemsSource = o;
            CBO_osztalyok.SelectedIndex = 0;
        }

        private void CBO_osztalyok_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var lekerdezes = (from t in context.Tanulo
                              where t.Osztaly.osztalyId == ((Osztaly)CBO_osztalyok.SelectedItem).osztalyId
                              select new { t.tanuloNev, t.szuletesiDatum, t.Osztaly.osztalyNev }).ToList();
            DG_lekerdezes.ItemsSource = lekerdezes;
        }

        private void AddOsztaly() {
            Osztaly osztaly = new Osztaly() { osztalyNev = "9A", osztalyFonok = "Józsi" };
            context.Add<Osztaly>(osztaly);

            osztaly = new Osztaly() { osztalyNev = "13A", osztalyFonok = "Kowa" };
            context.Add<Osztaly>(osztaly);
        }
        private void AddTanulo()
        {
            Tanulo tanulo = new Tanulo() { tanuloNev = "Béla", szuletesiDatum = DateTime.Parse("2001.01.01"), osztalyId = 1 };
            context.Add<Tanulo>(tanulo);

            tanulo = new Tanulo() { tanuloNev = "Cili", szuletesiDatum = DateTime.Parse("2005.03.22"), osztalyId = 1 };
            context.Add<Tanulo>(tanulo);

            tanulo = new Tanulo() { tanuloNev = "Kata", szuletesiDatum = DateTime.Parse("2003.04.13"), osztalyId = 2 };
            context.Add<Tanulo>(tanulo);
        }
    }
}
