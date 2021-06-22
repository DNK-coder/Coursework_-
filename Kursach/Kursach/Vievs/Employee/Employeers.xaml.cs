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

namespace Kursach.Vievs.Employee
{
    public partial class Employeers : Page
    {
        public static int UpdEmpId;
        Entities db = new Entities();
        public Employeers()
        {
            InitializeComponent(); Load();
        }

        private void Load()
        {
            dg.ItemsSource = db.Компьютер.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int id = (dg.SelectedItem as Работник_тех_отдела).Код_сотрудника;
            db.Работник_тех_отдела.Remove(db.Работник_тех_отдела.Where(m => m.Код_сотрудника == id).Single());
            db.SaveChanges();
            dg.ItemsSource = db.Работник_тех_отдела.ToList();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
