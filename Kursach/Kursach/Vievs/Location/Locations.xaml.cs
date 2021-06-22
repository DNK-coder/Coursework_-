using Kursach.Models;
using Kursach.Vievs.Location;
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

namespace Kursach
{
    
    public partial class Locations : Page
    {
        public static int UpdLocId;
        Entities db = new Entities();
        public Locations()
        {
            InitializeComponent();
            Load();
        }

        private void Load()
        {
            dg.ItemsSource = db.Местоположения.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)//удаление
        {
            int id = (dg.SelectedItem as Местоположения).Код_местоположения;
            db.Местоположения.Remove(db.Местоположения.Where(m => m.Код_местоположения == id).Single());
            db.SaveChanges();
            dg.ItemsSource = db.Местоположения.ToList();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)//добавление
        {
            NewLocation newloc = new NewLocation();
            newloc.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)//изменение
        {
            UpdLocId = (dg.SelectedItem as Местоположения).Код_местоположения;
            UpdLocation updloc = new UpdLocation();
            updloc.Show();
        }
    }
}
