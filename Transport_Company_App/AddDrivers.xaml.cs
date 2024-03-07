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
    /// Логика взаимодействия для AddDrivers.xaml
    /// </summary>
    public partial class AddDrivers : Page
    {
        public Водители Водители { get; set; } = new Водители();

        public AddDrivers(Водители водители = null)
        {
            InitializeComponent();
            if (водители != null)
            {
                Водители = водители;
            }
            this.DataContext = Водители;
        }

        private void Save_Button_Click(object sender, RoutedEventArgs e)
        {
            if (Водители.ID_водителя == 0)
            {
                TransportCompanyDBEntities.GetContext().Водители.Add(Водители);
            }      
            TransportCompanyDBEntities.GetContext().SaveChanges();
            NavigationService.Navigate(new Drivers());
        }

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.NavigationService.GoBack();
        }
    }
}
