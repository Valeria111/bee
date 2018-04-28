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
using System.Data;
using MySql.Data.MySqlClient;

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            connect_full_ul();
            connect_unfull_ul();
            connect_attention();
            label_2_Copy2.Content = nomer;
            label_output_text_1.Content = krishki;
            label_2_Copy3.Content = attention;
        }

        private void change_Click(object sender, RoutedEventArgs e)
        {

            MainWindow MainWindow = new MainWindow();
            MainWindow.Show();
            this.Close();

        }

        private void fam_Click(object sender, RoutedEventArgs e)
        {
            Window2 Window2 = new Window2();
            Window2.Show();
            this.Close();
        }

        private void all_Click(object sender, RoutedEventArgs e)
        {
            Window4 Window4 = new Window4();
            Window4.Show();
            this.Close();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Print_Click(object sender, RoutedEventArgs e)
        {

        }
        int nomer = 0, attention = 0;
        string kr, krishki, att;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window5 Window5 = new Window5();
            Window5.Show();
            this.Close();

        }

        public void connect_full_ul()
        {
            string connectString = "server=localhost;user=root;database=diplom;password=;";
            MySqlConnection conn = new MySqlConnection(connectString);
            conn.Open();
            string q1 = "SELECT nomer_kr FROM work_1 ";
            MySqlCommand command = new MySqlCommand(q1, conn);
            MySqlDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    Console.WriteLine(String.Format("{0}", reader[0]));
                    kr = Convert.ToString(reader[0]);
                    if(kr != "" && kr != "0")
                    {
                        nomer++;
                    }
                }
            }
            finally
            {
                conn.Close();
            }
        }
        public void connect_unfull_ul()
        {
            string connectString = "server=localhost;user=root;database=diplom;password=;";
            MySqlConnection conn = new MySqlConnection(connectString);
            conn.Open();
            string q1 = "SELECT number FROM work_1 ";
            MySqlCommand command = new MySqlCommand(q1, conn);
            MySqlDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    Console.WriteLine(String.Format("{0}", reader[0]));
                    krishki = Convert.ToString(reader[0]);
                }
            }
            finally
            {
                conn.Close();
            }
        }
        public void connect_attention()
        {
            string connectString = "server=localhost;user=root;database=diplom;password=;";
            MySqlConnection conn = new MySqlConnection(connectString);
            conn.Open();
            string q1 = "SELECT attention FROM work_1 ";
            MySqlCommand command = new MySqlCommand(q1, conn);
            MySqlDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    Console.WriteLine(String.Format("{0}", reader[0]));
                    att = Convert.ToString(reader[0]);
                    if (att =="1")
                    {
                        attention++;
                    }
                }
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
