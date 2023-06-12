using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace library_wpf
{
    /// <summary>
    /// Логика взаимодействия для WpfMessagebox.xaml
    /// </summary>
    public partial class WpfMessagebox : Window
    {
        public WpfMessagebox()
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
        