using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
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
    /// Логика взаимодействия для Page_N7.xaml
    /// </summary>
    public partial class Page_N7 : Page
    {
        DataTable tableAuthors = new DataTable();
        DataTable tableStyles = new DataTable();
        DataTable tablePress = new DataTable();

        public Page_N7()
        {
            InitializeComponent();

            DB dB = new DB();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT author_id, author_name FROM `author_fav`", dB.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(tableAuthors);
            command = new MySqlCommand("SELECT style_id, style_name FROM `style_fav`", dB.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(tableStyles);
            command = new MySqlCommand("SELECT press_id, press_name FROM `press_fav`", dB.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(tablePress);

            if (tablePress.Rows.Count > 0 && tableStyles.Rows.Count > 0 && tableAuthors.Rows.Count > 0)
            {
                for (int i = 0; i < tablePress.Rows.Count; i++)
                {
                    BoxPress.Items.Add(tablePress.Rows[i]["press_name"]);
                }

                for (int i = 0; i < tableStyles.Rows.Count; i++)
                {
                    BoxStyles.Items.Add(tableStyles.Rows[i]["style_name"]);
                }

                for (int i = 0; i < tableAuthors.Rows.Count; i++)
                {
                    BoxAuthors.Items.Add(tableAuthors.Rows[i]["author_name"]);
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page_N4());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            // переменные для подстановки в бд
            int bookAddedId = 0;
            string bookName = name.Text.ToString();
            int bookYear = int.Parse(year.Text.ToString());
            int pressId = int.Parse(tablePress.Rows[BoxPress.SelectedIndex]["press_id"].ToString());
            int styleId = int.Parse(tableStyles.Rows[BoxStyles.SelectedIndex]["style_id"].ToString());
            int authorId = int.Parse(tableAuthors.Rows[BoxAuthors.SelectedIndex]["author_id"].ToString());

            // добавление книги
            string connectionString = "server=localhost;port=3306;username=root;password=12345;database=data_lib";
            MySqlCommand command;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // заинсертить все новые данные

                string sql = "insert into book_fav (book_id, book_name, book_year) value" +
                    "(null, @bN, @bY)";
                using (command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@bN", bookName);
                    command.Parameters.AddWithValue("@bY", bookYear);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("добавлено название и год книги");
                    }
                }
            }

            // возврат ID добавленной книги
            DB dB = new DB();
            DataTable bookID = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            command = new MySqlCommand("SELECT MAX(book_id) as bookAddedId FROM book_fav", dB.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(bookID);

            if(bookID.Rows.Count > 0)
            {
                foreach(DataRow row in bookID.Rows)
                {
                    bookAddedId = (int)row["bookAddedId"];
                }
            }

            // добавление связи книги и автора в связную таблицу (автор, книга)
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string sql = "insert into author_fav_has_book_fav value(@aID, @bID)";
                using (command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@aID", authorId);
                    command.Parameters.AddWithValue("@bID", bookAddedId);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("добавлена связь книга + автор");
                    }
                }
            }

            // добавление связи книги и стиля в связную таблицу (книга, стиль)
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string sql = "insert into style_fav_has_book_fav value(@bID, @sID)";
                using (command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@sID", styleId);
                    command.Parameters.AddWithValue("@bID", bookAddedId);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("добавлена связь книга + жанр");
                    }
                }
            }

            // добавление связи книги и издательства в связную таблицу (издательство, книга)
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string sql = "insert into press_fav_has_book_fav value(@pID, @bID)";
                using (command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@pID", pressId);
                    command.Parameters.AddWithValue("@bID", bookAddedId);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("добавлена связь книга + издание");
                    }
                }
            }
        }
    }
}
