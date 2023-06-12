using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
    /// Логика взаимодействия для Page_N5.xaml
    /// </summary>
    public partial class Page_N5 : Page
    {
        public Page_N5()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page_N4());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string pressName = name.Text.ToString();
            string pressPhone = phone.Text.ToString();
            string pressAdress = adress.Text.ToString();

            string connectionString = "server=localhost;port=3306;username=root;password=12345;database=data_lib";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "insert into press_fav values(null, @pN, @pP, @pA)";

                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@pN", pressName);
                    command.Parameters.AddWithValue("@pP", pressPhone);
                    command.Parameters.AddWithValue("@pA", pressAdress);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("добавили издательство!");
                    }
                }
            }
        }
    }
}
