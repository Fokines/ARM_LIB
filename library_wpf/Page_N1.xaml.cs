using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace library_wpf
{
    /// <summary>
    /// Логика взаимодействия для Page_N1.xaml
    /// </summary>
    public partial class Page_N1 : Page
    {
        public Page_N1()
        {
            InitializeComponent();
        }

        private void login_button_Click(object sender, RoutedEventArgs e)
        {
            //проверить данные
            //если неверно - вывести сообщение что данные неверны (добавить месседж бокс)
            String loginUser = loginField.Text;
            String loginPassword = passField.Text;

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users_fav` WHERE `user_name` = @uL AND `password` = @uP", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = loginPassword;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if(table.Rows.Count > 0)
            {
                //переход в главное меню после успешной авторизации
                NavigationService.Navigate(new Page_N2());
            }
            else
            {
                WpfMessagebox myMessageBox = new WpfMessagebox();
                myMessageBox.ShowDialog();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
                Application.Current.Shutdown();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }
    }
}
