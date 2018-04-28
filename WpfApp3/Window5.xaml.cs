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
    /// Логика взаимодействия для Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {
        public Window5()
        {
            InitializeComponent();

        }

      private void Button_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == true)
            {
               printDialog.PrintVisual(canvas, "Распечатываем элемент Canvas");
            }
        }
        int nomer = 0, attention = 0, sh_8_r = 0, sh_10_r = 0, condi = 0;
        string kr, krishki, att;

        private void full_Click(object sender, RoutedEventArgs e)//мяу
        {
            visible();
            full.Background = l.Background;

            connect_full_ul();
            connect_unfull_ul();
            connect_attention();
            connect_sh8r();
            connect_sh10r();
            connect_cond();
            label_1_Copy7.Content = nomer;
            label_1_Copy1.Content = krishki;
            label_1_Copy.Content = krishki;
            label_1_Copy3.Content = krishki;
            label_1_Copy2.Content = attention;
            label_1_Copy4.Content = sh_8_r/2;
            label_1_Copy6.Content = sh_10_r / 2;
            label_1_Copy5.Content = condi;

        }
        public void visible()
        {
            List<Label> labels_full = new List<Label> { name, label_1, label_2, label_3, label_1_Copy7, label_1_Copy1, label_1_Copy2, label_3_Copy, label_3_Copy1, label_3_Copy2, label_3_Copy3, label_3_Copy4, label_1_Copy, label_1_Copy3, label_1_Copy4, label_1_Copy6, label_1_Copy5 };
            for(int i=0; i<labels_full.Count; i++ )
            {
                labels_full[i].Visibility = Visibility.Visible;
            }
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
                    if (kr != "" && kr != "0")
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

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
                    if (att == "1")
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
        string nomer_yacheiki_kr;
        public void connect_sh8r()
        {
            string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
            MySqlConnection conn = new MySqlConnection(connectString);
            conn.Open();
            string q1 = "SELECT nomer_sh_8_r FROM work_1 ";
            MySqlCommand command = new MySqlCommand(q1, conn);
            MySqlDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    Console.WriteLine(String.Format("{0}", reader[0]));
                    nomer_yacheiki_kr = Convert.ToString(reader[0]);
                    string[] nomer_kr = nomer_yacheiki_kr.Split(new char[] { ',' });

                    for (int i = 0; i < nomer_kr.Length; i++)
                    {
                        if (nomer_kr[i] != "0")
                        {
                            sh_8_r++;
                        }
                    }
                }
            }
            finally { conn.Close(); }
           

        }
        public void connect_sh10r()
        {
            string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
            MySqlConnection conn = new MySqlConnection(connectString);
            conn.Open();
            string q1 = "SELECT nomer_sh_10_r FROM work_1 ";
            MySqlCommand command = new MySqlCommand(q1, conn);
            MySqlDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    Console.WriteLine(String.Format("{0}", reader[0]));
                    nomer_yacheiki_kr = Convert.ToString(reader[0]);
                    string[] nomer_kr = nomer_yacheiki_kr.Split(new char[] { ',' });

                    for (int i = 0; i < nomer_kr.Length; i++)
                    {
                       if(nomer_kr[i] != "0")
                        {
                            sh_10_r++;
                        }

                    }
                }
            }
            finally { conn.Close(); }

        }
        public void connect_cond()
        {
            string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
            MySqlConnection conn = new MySqlConnection(connectString);
            conn.Open();
            string q1 = "SELECT nomer_condi FROM work_1 ";
            MySqlCommand command = new MySqlCommand(q1, conn);
            MySqlDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    Console.WriteLine(String.Format("{0}", reader[0]));
                    nomer_yacheiki_kr = Convert.ToString(reader[0]);
                    string[] nomer_kr = nomer_yacheiki_kr.Split(new char[] { ',' });

                    for (int i = 0; i < nomer_kr.Length; i++)
                    {
                        if(nomer_kr[i] !="0")
                        {
                            condi++;
                        }

                    }
                }
            }
            finally { conn.Close(); }

        }
    }
}
