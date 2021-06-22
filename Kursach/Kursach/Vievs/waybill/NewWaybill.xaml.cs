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

namespace Kursach.Vievs.waybill
{
    /// <summary>
    /// Логика взаимодействия для NewWaybill.xaml
    /// </summary>
    public partial class NewWaybill : Window
    {
        Entities db = new Entities();
        public NewWaybill()
        {
            InitializeComponent();
            Load();
        }

        private void Load()
        {
            CBcmp.ItemsSource = db.Компьютер.ToList();
            from.ItemsSource = db.Местоположения.ToList();
            to.ItemsSource = db.Местоположения.ToList();
            emp.ItemsSource = db.Работник_тех_отдела.ToList();
            emp.SelectedValuePath = "Код_сотрудника";
            CBcmp.DisplayMemberPath = "Код_компьютера";
            CBcmp.SelectedValuePath = "Код_компьютера";
            from.DisplayMemberPath = "Нименование";
            to.DisplayMemberPath = "Нименование";
            from.SelectedValuePath = "Код_местоположения";
            to.SelectedValuePath = "Код_местоположения";
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            Накладная nakl = new Накладная()
            {
                Компьютер = Convert.ToInt32(CBcmp.SelectedValue),
                Дата = DP.SelectedDate,
                От_куда = Convert.ToInt32(from.SelectedValue),
                Куда = Convert.ToInt32(to.SelectedValue),
                Ответственный = Convert.ToInt32(emp.SelectedValue),

            };
            db.Накладная.Add(nakl);
            db.SaveChanges();
            this.Close();
        }
    }
}
