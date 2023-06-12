using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
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
    /// Логика взаимодействия для Page_N16.xaml
    /// </summary>
    public partial class Page_N16 : Page
    {
        public Page_N16()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page_N3());
        }

        public void SetData(DataTable dataTable)
        {
            if (dataTable != null)
            {
                GridForData.ItemsSource = dataTable.DefaultView;
            }
        }
    }
}
