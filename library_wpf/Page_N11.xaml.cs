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
using System.Data.SqlClient;
using System.ComponentModel.Design;
using System.Security.Cryptography;

namespace library_wpf
{
    /// <summary>
    /// Логика взаимодействия для Page_N11.xaml
    /// </summary>
    public partial class Page_N11 : Page
    {
        public Page_N11()
        {
            InitializeComponent();
            nameBook.IsEnabled = false;
            bookOfYear.IsEnabled = false;
            WhoPrint.IsEnabled = false;
            AuthorOfBook.IsEnabled = false;
            StyleOfBook.IsEnabled = false;
        }

        String BookID = "";
        String BookName = "";
        String BookYear = "";
        String BookPress = "";
        String BookAuthor = "";
        String BookStyle = "";

        int authorIDForBoxSelected = 0;
        int pressIDForBoxSelected = 0;
        int styleIDForBoxSelected = 0;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page_N6());
        }

        public void SetData(DataTable dataTable)
        {
            if(dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];

                BookID = row["book_id"].ToString();
                string bookName = row["book_name"].ToString();
                string bookYear = row["book_year"].ToString();
                string bookStyle = row["style_name"].ToString();
                string bookAuthor = row["author_name"].ToString();
                string bookPress = row["press_name"].ToString();

                nameBook.Text = bookName;
                bookOfYear.Text = bookYear;
                WhoPrint.Text = bookPress;
                AuthorOfBook.Text = bookAuthor;
                StyleOfBook.Text = bookStyle;
            }

            DB dB = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT book_fav_has_reader_fav.book_FAV_book_id " +
                "FROM book_fav_has_reader_fav " +
                "WHERE book_fav_has_reader_fav.book_FAV_book_id = @bID", dB.getConnection());
            command.Parameters.AddWithValue("@bID", int.Parse(BookID));
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                ReturnBooks.Visibility = Visibility.Visible;
            }
            else
            {
                GiveOutBooks.Visibility = Visibility.Visible;
                DeleteBook.Visibility = Visibility.Visible;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SaveChange.Visibility = Visibility.Visible;
            nameBook.IsEnabled = true;
            bookOfYear.IsEnabled = true;
            WhoPrint.IsEnabled = true;
            AuthorOfBook.IsEnabled = true;
            StyleOfBook.IsEnabled = true;

            //записываются старые данные о книге, ДО изменения
            BookName = nameBook.Text;
            BookYear = bookOfYear.Text;
            BookPress = WhoPrint.Text;
            BookAuthor = AuthorOfBook.Text;
            BookStyle = StyleOfBook.Text;

            BoxAuthors.Visibility = Visibility.Visible;
            BoxPress.Visibility = Visibility.Visible;
            BoxStyles.Visibility = Visibility.Visible;

            DB dB = new DB();

            DataTable tableAuthors = new DataTable();
            DataTable tableAuthorID = new DataTable();
            DataTable tablePress = new DataTable();
            DataTable tablePressID = new DataTable();
            DataTable tableStyles = new DataTable();
            DataTable tableStylesID = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT author_name FROM `author_fav`", dB.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(tableAuthors);

            command = new MySqlCommand("SELECT author_id FROM `author_fav` WHERE author_name = @aN", dB.getConnection());
            command.Parameters.Add("aN", MySqlDbType.VarChar).Value = BookAuthor;
            adapter.SelectCommand = command;
            adapter.Fill(tableAuthorID);

            if (tableAuthors.Rows.Count > 0)
            {
                for(int i = 0; i < tableAuthors.Rows.Count; i++)
                {
                    BoxAuthors.Items.Add(tableAuthors.Rows[i]["author_name"]);
                }
            }

            if (tableAuthorID != null)
            {
                foreach (DataRow row in tableAuthorID.Rows)
                {
                    authorIDForBoxSelected = (int)row["author_id"];
                }
                BoxAuthors.SelectedIndex = authorIDForBoxSelected - 1;
            }

            command = new MySqlCommand("SELECT press_name FROM `press_fav`", dB.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(tablePress);

            command = new MySqlCommand("SELECT press_id FROM `press_fav` WHERE press_name = @pN", dB.getConnection());
            command.Parameters.Add("pN", MySqlDbType.VarChar).Value = BookPress;
            adapter.SelectCommand = command;
            adapter.Fill(tablePressID);

            if (tablePress.Rows.Count > 0)
            {
                for (int i = 0; i < tablePress.Rows.Count; i++)
                {
                    BoxPress.Items.Add(tablePress.Rows[i]["press_name"]);
                }
            }

            if(tablePressID != null)
            {
                foreach(DataRow row in tablePressID.Rows)
                {
                    pressIDForBoxSelected = (int)row["press_id"];
                }
                BoxPress.SelectedIndex = pressIDForBoxSelected - 1;
            }

            command = new MySqlCommand("SELECT style_name FROM `style_fav`", dB.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(tableStyles);

            command = new MySqlCommand("SELECT style_id FROM `style_fav` WHERE style_name = @bS", dB.getConnection());
            command.Parameters.Add("bS", MySqlDbType.VarChar).Value = BookStyle;
            adapter.SelectCommand = command;
            adapter.Fill(tableStylesID);

            if (tableStyles.Rows.Count > 0)
            {
                for (int i = 0; i < tableStyles.Rows.Count; i++)
                {
                    BoxStyles.Items.Add(tableStyles.Rows[i]["style_name"]);
                }
            }

            if (tableStylesID != null)
            {
                foreach (DataRow row in tableStylesID.Rows)
                {
                    styleIDForBoxSelected = (int)row["style_id"];
                }
                BoxStyles.SelectedIndex = styleIDForBoxSelected - 1;
            }
        }

        private void Button_SaveChange_Click(object sender, RoutedEventArgs e)
        {
            String NewBookName = nameBook.Text;
            String NewBookYear = bookOfYear.Text;
            int statusName = 0;
            int statusYear = 0;
            int statusAuthor = 0;
            int statusPress = 0;
            int statusStyle = 0;

            int bID = int.Parse(BookID);
            string connectionString = "server=localhost;port=3306;username=root;password=12345;database=data_lib";

            if(NewBookName != BookName)
            {
                //тут название книги менялось

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "UPDATE `book_fav` SET book_fav.book_name = @bN WHERE book_fav.book_id = @bID";

                    using(MySqlCommand command = new MySqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@bN", NewBookName);
                        command.Parameters.AddWithValue("@bID", bID);

                        int rowsAffected = command.ExecuteNonQuery();

                        if(rowsAffected > 0)
                        {
                            statusName = 1;
                        }
                        else
                        {
                            statusName = 404;
                        }
                    }
                }
            }

            if (NewBookYear != BookYear)
            {
                //тут год книги менялся
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "UPDATE `book_fav` SET book_fav.book_year = @bY WHERE book_fav.book_id = @bID";

                    using (MySqlCommand command = new MySqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@bY", int.Parse(NewBookYear));
                        command.Parameters.AddWithValue("@bID", bID);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            statusYear = 1;
                        }
                        else
                        {
                            statusYear = 404;
                        }
                    }
                }
            }

            if (BoxPress.SelectedIndex + 1 != styleIDForBoxSelected)
            {
                //тут изменилось издательствo
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "UPDATE press_fav_has_book_fav SET press_fav_has_book_fav.press_fav_press_id = @pID WHERE press_fav_has_book_fav.book_fav_book_id = @bID";

                    using (MySqlCommand command = new MySqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@pID", BoxPress.SelectedIndex + 1);
                        command.Parameters.AddWithValue("@bID", bID);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            statusPress = 1;
                        }
                        else
                        {
                            statusPress = 404;
                        }
                    }
                }
            }

            if(BoxAuthors.SelectedIndex + 1 != authorIDForBoxSelected)
            {
                //тут изменился автор
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "UPDATE author_fav_has_book_fav SET author_fav_has_book_fav.author_fav_author_id = @aID WHERE author_fav_has_book_fav.book_fav_book_id = @bID";

                    using (MySqlCommand command = new MySqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@aID", BoxAuthors.SelectedIndex + 1);
                        command.Parameters.AddWithValue("@bID", bID);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            statusAuthor = 1;
                        }
                        else
                        {
                            statusAuthor = 404;
                        }
                    }
                }
            }

            if(BoxStyles.SelectedIndex + 1 != styleIDForBoxSelected)
            {
                //тут изменился жанр
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "UPDATE style_fav_has_book_fav SET style_fav_has_book_fav.style_fav_style_id = @sID WHERE style_fav_has_book_fav.book_fav_book_id = @bID";

                    using (MySqlCommand command = new MySqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@sID", BoxStyles.SelectedIndex + 1);
                        command.Parameters.AddWithValue("@bID", bID);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            statusStyle = 1;
                        }
                        else
                        {
                            statusStyle = 404;
                        }
                    }
                }
            }

            nameBook.IsEnabled = false;
            bookOfYear.IsEnabled = false;
            WhoPrint.IsEnabled = false;
            AuthorOfBook.IsEnabled = false;
            StyleOfBook.IsEnabled = false;
            SaveChange.Visibility = Visibility.Hidden;

            if (statusName == 404 || statusYear == 404 || statusAuthor == 404 || statusPress == 404 || statusStyle == 404)
            {
                DataEditStatus myMessageBox = new DataEditStatus();
                myMessageBox.ShowDialog();
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            GiveOutBook myWindow = new GiveOutBook(int.Parse(BookID));
            myWindow.ShowDialog();
        }

        private void DeleteBook_Click(object sender, RoutedEventArgs e)
        {
            string connectionString = "server=localhost;port=3306;username=root;password=12345;database=data_lib";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "DELETE FROM book_fav WHERE book_id = @bID";

                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@bID", int.Parse(BookID));

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        NavigationService.Navigate(new Page_N3());
                    }
                }
            }
        }

        private void ReturnBooks_Click(object sender, RoutedEventArgs e)
        {
            string connectionString = "server=localhost;port=3306;username=root;password=12345;database=data_lib";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "DELETE FROM book_fav_has_reader_fav WHERE book_fav_book_id = @bID";

                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@bID", int.Parse(BookID));

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        GiveOutBooks.Visibility = Visibility.Visible;
                        DeleteBook.Visibility = Visibility.Visible;
                        ReturnBooks.Visibility = Visibility.Hidden;
                    }
                }
            }
        }
    }
}
