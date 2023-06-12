using MySql.Data.MySqlClient;
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
    /// Логика взаимодействия для Page_N12.xaml
    /// </summary>
    public partial class Page_N12 : Page
    {
        public Page_N12()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page_N4());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string authorName = surname.Text.ToString() + " " + name.Text.ToString() + " " + thirdname.Text.ToString();
            string birthDay = birthDayData.Text.ToString(); // dd/mm/yyyy > yyyy/mm/dd
            string[] parts = birthDay.Split('/');
            string day = parts[0];
            string month = parts[1];
            string year = parts[2];
            birthDay = year + '-' + month + '-' + day;
            string authorInfo = info.Text.ToString();

            string connectionString = "server=localhost;port=3306;username=root;password=12345;database=data_lib";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "insert into author_fav values(null, @aN, @dB, @sI)";

                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@aN", authorName);
                    command.Parameters.AddWithValue("@dB", birthDay);
                    command.Parameters.AddWithValue("@sI", authorInfo);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("добавили автора!");
                    }
                }
            }
        }
    }
}
