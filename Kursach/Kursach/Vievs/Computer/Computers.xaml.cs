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

namespace Kursach.Vievs.Computer
{
    /// <summary>
    /// Логика взаимодействия для Computers.xaml
    /// </summary>
    public partial class Computers : Page
    {
        public static int UpdCompId;
        Entities db = new Entities();
        public Computers()
        {
            InitializeComponent(); Load();
        }

        private void Load()
        {
            dg.ItemsSource = db.Компьютер.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)//удалить
        {
            int id = (dg.SelectedItem as Компьютер).Код_компьютера;
            db.Компьютер.Remove(db.Компьютер.Where(m => m.Код_компьютера == id).Single());
            db.SaveChanges();
            dg.ItemsSource = db.Компьютер.ToList();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)//изменить
        {
            UpdCompId = (dg.SelectedItem as Компьютер).Код_компьютера;
            UpdComputer updcmp = new UpdComputer();
            updcmp.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)//добавить
        {
            NewComputer newcmp = new NewComputer();
            newcmp.Show();
        }
    }
}
