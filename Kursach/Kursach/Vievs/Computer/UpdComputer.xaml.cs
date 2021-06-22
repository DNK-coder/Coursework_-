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
    /// Логика взаимодействия для UpdComputer.xaml
    /// </summary>
    public partial class UpdComputer : Window
    {
        Entities db = new Entities();
        public UpdComputer()
        {
            InitializeComponent();
            Load();
        }

        private void Load()
        {
            var cmp = db.Компьютер.FirstOrDefault(m => m.Код_компьютера == Computers.UpdCompId);
            proc.Text = cmp.Процессор;
            GC.Text = cmp.Видеокарта;
            MP.Text = cmp.Мат_плата;
            RAM.Text = cmp.Объём_ОЗУ;
            HD.Text = cmp.Жёсткий_диск;
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            Компьютер cmp = (from m in db.Компьютер
                             where m.Код_компьютера == Computers.UpdCompId
                             select m).Single();
            cmp.Процессор = proc.Text;
            cmp.Видеокарта = GC.Text;
            cmp.Мат_плата = MP.Text;
            cmp.Объём_ОЗУ = RAM.Text;
            cmp.Жёсткий_диск = HD.Text;
            cmp.Местоположение = Convert.ToInt32(loc.SelectedValue);
            db.SaveChanges();
            this.Close();
        }
    }
}
