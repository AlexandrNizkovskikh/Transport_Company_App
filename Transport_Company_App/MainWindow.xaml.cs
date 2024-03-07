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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Manager.MainFrame = MainFrame;
        }

        private void DriversButton_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Drivers());
        }

        private void OrdersButton_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Orders());
        }

        private void OrderHistoryButton_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new OrderHistory());
        }

        private void ClientsButton_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Clients());
        }

        private void RoutesButton_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Routes());
        }

        private void TransportButton_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Transport());
        }
    }
}
