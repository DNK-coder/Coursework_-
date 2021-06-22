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
    
    public partial class NewLocation : Window
    {
        Entities db = new Entities();
        public NewLocation()
        {
            InitializeComponent();
            
        }
        
        private void cls_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            Местоположения loc = new Местоположения()
            {
                Нименование = name.Text,
            };
            db.Местоположения.Add(loc);
            db.SaveChanges();
            this.Close();

        }
    }
}
