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

namespace Kursach.Vievs.Computer
{
    /// <summary>
    /// Логика взаимодействия для NewComputer.xaml
    /// </summary>
    public partial class NewComputer : Window
    {
        Entities db = new Entities();
        public NewComputer()
        {
            InitializeComponent();
            loc.ItemsSource = db.Местоположения.ToList();
            loc.SelectedValuePath = "Код_местоположение";
        }

        private void cls_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            Компьютер cmp = new Компьютер()
            {
                Процессор = proc.Text,
                Видеокарта = GC.Text,
                Мат_плата = MP.Text,
                Объём_ОЗУ = RAM.Text,
                Жёсткий_диск = HD.Text,
                Местоположение = Convert.ToInt32(loc.SelectedValue),
            };
            db.Компьютер.Add(cmp);
            db.SaveChanges();
            this.Close();
        }
    }
}
