using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
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
using MySql.Data.MySqlClient;
namespace library_wpf
{
    /// <summary>
    /// Логика взаимодействия для GiveOutBook.xaml
    /// </summary>
    public partial class GiveOutBook : Window
    {
        public GiveOutBook(int bookID)
        {
            InitializeComponent();
            BookID = bookID;

            DB dB = new DB();

            DataTable readersList = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT reader_name, " +
                "COUNT(book_fav_has_reader_fav.reader_FAV_reader_id) AS books_amount " +
                "FROM reader_fav LEFT JOIN book_fav_has_reader_fav ON reader_fav.reader_id = book_fav_has_reader_fav.reader_FAV_reader_id " +
                "GROUP BY reader_fav.reader_id", dB.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(readersList);

            if (readersList.Rows.Count > 0)
            {
                for (int i = 0; i < readersList.Rows.Count; i++)
                {
                    if(int.Parse(readersList.Rows[i]["books_amount"].ToString()) < 5)
                    {
                        BoxReaders.Items.Add(readersList.Rows[i]["reader_name"]);
                    }
                }
            }
        }

        int BookID = 0;

        public new void Show()
        {
            Visibility = Visibility.Collapsed;
        }

        private void closeMessBoxButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void saveMessBoxButton_Click(object sender, RoutedEventArgs e)
        {
            string readerChoisenName = BoxReaders.Text;
            int readerIDReturned = 0;

            DB dB = new DB();

            DataTable readerID = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT reader_id FROM `reader_fav` WHERE reader_name = @rN", dB.getConnection());
            command.Parameters.Add("rN", MySqlDbType.VarChar).Value = readerChoisenName;
            adapter.SelectCommand = command;
            adapter.Fill(readerID);

            if (readerID.Rows.Count > 0)
            {
                foreach(DataRow row in readerID.Rows)
                {
                    readerIDReturned = (int)row["reader_id"];
                }
            }

            string connectionString = "server=localhost;port=3306;username=root;password=12345;database=data_lib";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "INSERT INTO book_fav_has_reader_fav values(@rID, @bID)";

                using (MySqlCommand command1 = new MySqlCommand(sql, connection))
                {
                    command1.Parameters.AddWithValue("@bID", BookID);
                    command1.Parameters.AddWithValue("@rID", readerIDReturned);

                    int rowsAffected = command1.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("УСПЕХ!");
                    }
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
