using Korovin.AppData;
using Korovin.Model;
using Korovin.Views.Pages;
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

namespace Korovin.Views.Windows
{
    /// <summary>
    /// Логика взаимодействия для MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
        private User _selectedUser = AuthorisationHelper.selectedUser;
        public MenuWindow()
        {
            InitializeComponent();
            UserSp.DataContext = _selectedUser;
            FrameHelper.selectedFrame = MainFrm;
            MainFrm.Navigate(new StartPage());
        }

        private void HiringHl_Click(object sender, RoutedEventArgs e)
        {
            MainFrm.Navigate(new HiringPage()); 
        }

        private void ServicesHl_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
