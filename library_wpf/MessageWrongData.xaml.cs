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

namespace library_wpf
{
    /// <summary>
    /// Логика взаимодействия для MessageWrongData.xaml
    /// </summary>
    public partial class MessageWrongData : Window
    {
        public MessageWrongData()
        {
            InitializeComponent();
        }

        public new void Show()
        {
            Visibility = Visibility.Collapsed;
        }

        private void closeMessBoxButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
