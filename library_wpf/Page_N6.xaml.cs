using MySql.Data.MySqlClient;
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

namespace library_wpf
{
    /// <summary>
    /// Логика взаимодействия для Page_N6.xaml
    /// </summary>
    public partial class Page_N6 : Page
    {
        public Page_N6()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page_N2());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            String nameOfBook = bookNameForSearch.Text;

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT book_fav.book_id, book_fav.book_name, book_fav.book_year, " +
                "style_fav.style_name, author_fav.author_name, " +
                "press_fav.press_name FROM `book_fav` " +
                "INNER JOIN `style_fav_has_book_fav` ON book_fav.book_id = style_fav_has_book_fav.book_FAV_book_id " +
                "INNER JOIN `style_fav` ON style_fav_has_book_fav.style_FAV_style_id = style_fav.style_id " +
                "INNER JOIN `author_fav_has_book_fav` ON book_fav.book_id = author_fav_has_book_fav.book_FAV_book_id " +
                "INNER JOIN `author_fav` ON author_fav_has_book_fav.author_FAV_author_id = author_fav.author_id " +
                "INNER JOIN `press_fav_has_book_fav` ON book_fav.book_id = press_fav_has_book_fav.book_FAV_book_id " +
                "INNER JOIN `press_fav` ON press_fav_has_book_fav.press_FAV_press_ID = press_fav.press_ID " +
                "WHERE book_fav.book_name = @bN", db.getConnection());
            command.Parameters.Add("@bN", MySqlDbType.VarChar).Value = nameOfBook;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                Page_N11 page_N11 = new Page_N11();
                page_N11.SetData(table);
                NavigationService.Navigate(page_N11);
            }
            else
            {
                MessageWrongData wrongDataMessage = new MessageWrongData();
                wrongDataMessage.ShowDialog();
            }
        }
    }
}
