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

namespace Kursach.Vievs
{
    /// <summary>
    /// Логика взаимодействия для Reg.xaml
    /// </summary>
    public partial class Reg : Window
    {
        Entities db = new Entities();
        public Reg()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Работник_тех_отдела wr = new Работник_тех_отдела()
            {
                Фамилия = lname.Text,
                Имя = name.Text,
                Отчетво = mname.Text,
                Пароль = pass.Text,
                Логин = login.Text

            };
            db.Работник_тех_отдела.Add(wr);
            db.SaveChanges();
            this.Close();
        }
    }
}
