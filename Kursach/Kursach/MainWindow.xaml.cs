using Kursach.Vievs.Computer;
using Kursach.Vievs.waybill;
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

namespace Kursach
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Locations lc = new Locations();
            fr.Navigate(lc);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Computers cmp = new Computers();
            fr.Navigate(cmp);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            waybills wb = new waybills();
            fr.Navigate(wb);
        }
    }
}
