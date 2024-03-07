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

namespace Transport_Company_App
{
    /// <summary>
    /// Логика взаимодействия для Drivers.xaml
    /// </summary>
    public partial class Drivers : Page
    {
        public Drivers()
        {
            InitializeComponent();
            DriversDG.ItemsSource = TransportCompanyDBEntities.GetContext().Водители.ToList();
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            Водители drivers = (sender as Button).DataContext as Водители;
            TransportCompanyDBEntities.GetContext().Водители.Remove(drivers);
            TransportCompanyDBEntities.GetContext().SaveChanges();
            DriversDG.ItemsSource = TransportCompanyDBEntities.GetContext().Водители.ToList();
        }

        private void red_Click(object sender, RoutedEventArgs e)
        {
            Водители водители = (sender as Button).DataContext as Водители;
            Manager.MainFrame.Navigate(new AddDrivers(водители));
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            DriversDG.ItemsSource = TransportCompanyDBEntities.GetContext().Водители.Where(s => s.Фамилия.Contains(search.Text)).ToList();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddDrivers());
        }
    }
}
