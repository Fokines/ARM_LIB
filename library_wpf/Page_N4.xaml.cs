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

namespace library_wpf
{
    /// <summary>
    /// Логика взаимодействия для Page_N4.xaml
    /// </summary>
    public partial class Page_N4 : Page
    {
        public Page_N4()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page_N2());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page_N7());
        }

        private void AddPress_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page_N5());
        }

        private void AddAuthor_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page_N12());
        }

        private void AddStyle_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page_N13());
        }
    }
}
