using Korovin.Model;
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

namespace Korovin.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для HiringPage.xaml
    /// </summary>
    public partial class HiringPage : Page
    {
        private static KorovinDbEntities _context = App.GetContext();
        public HiringPage()
        {
            InitializeComponent();
            EmployeesLb.ItemsSource = _context.Employee.ToList();
        }

        private void ScheduleBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
