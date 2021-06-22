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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Kursach.Vievs.waybill
{
    
    public partial class waybills : Page
    {
        Entities db = new Entities();
        public waybills()
        {
            InitializeComponent();
            dg.ItemsSource = db.Накладная.ToList();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int id = (dg.SelectedItem as Накладная).Код_накладной;
            db.Накладная.Remove(db.Накладная.Where(m => m.Код_накладной == id).Single());
            db.SaveChanges();
            dg.ItemsSource = db.Накладная.ToList();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            NewWaybill wb = new NewWaybill();
            wb.Show();
        }
    }
}
