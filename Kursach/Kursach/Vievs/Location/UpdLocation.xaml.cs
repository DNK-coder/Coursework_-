using Kursach.Models;
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

namespace Kursach.Vievs.Location
{
    public partial class UpdLocation : Window
    {
        Entities db = new Entities();
        public UpdLocation()
        {
            InitializeComponent();
            Load();
        }

        private void Load()
        {
            var loc = db.Местоположения.FirstOrDefault(a => a.Код_местоположения == Locations.UpdLocId);
            name.Text = loc.Нименование.ToString();
        }

        

        private void cls_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            Местоположения l = (from m in db.Местоположения
                                where m.Код_местоположения == Locations.UpdLocId
                                select m).Single();
            l.Нименование = name.Text;
            db.SaveChanges();
            this.Close();
        }
    }
}
