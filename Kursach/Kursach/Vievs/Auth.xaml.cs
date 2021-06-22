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
    /// Логика взаимодействия для Auth.xaml
    /// </summary>
    public partial class Auth : Window
    {
        Entities db = new Entities();
        public static string namewr;
        public Auth()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool bl = false;
            for (int i = 0; i < db.Работник_тех_отдела.Count(); i++)
            {
                if ((db.Работник_тех_отдела.ToList()[i].Логин == login.Text) && (db.Работник_тех_отдела.ToList()[i].Пароль == pass.Password))
                {
                    bl = true;
                    namewr = db.Работник_тех_отдела.ToList()[i].Имя + db.Работник_тех_отдела.ToList()[i].Отчетво;
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                }
            }
            if (!bl) MessageBox.Show("Неверный логин или пароль");
            else this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            Reg reg = new Reg();
            reg.Show();
        }
    }
}
