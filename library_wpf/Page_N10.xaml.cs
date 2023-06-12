using System;
using System.Collections.Generic;
using System.Data;
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
using MySql.Data.MySqlClient;

namespace library_wpf
{
    /// <summary>
    /// Логика взаимодействия для Page_N10.xaml
    /// </summary>
    public partial class Page_N10 : Page
    {
        public Page_N10()
        {
            InitializeComponent();

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT reader_id, reader_name, " +
                "YEAR(CURDATE()) - YEAR(reader_birthday) AS age," +
                "COUNT(book_fav_has_reader_fav.reader_FAV_reader_id) AS books_amount " +
                "FROM reader_fav LEFT JOIN book_fav_has_reader_fav ON reader_fav.reader_id = book_fav_has_reader_fav.reader_FAV_reader_id " +
                "GROUP BY reader_fav.reader_id", db.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            

            if(table.Rows.Count > 0)
            {
                GridForData.ItemsSource = table.DefaultView;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page_N9());
        }
    }
}
