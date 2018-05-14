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
using System.Drawing;



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
            System.Windows.Controls.PrintDialog printDialog = new System.Windows.Controls.PrintDialog();
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
            unvisible_two();
            full.Background = l.Background;
            unfull.Background = l2.Background;

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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            unfull.Background = l.Background;
            full.Background = l2.Background;
            unvisible();
            visible_two();

        }
        public void visible()
        {

            List<System.Windows.Controls.Label> labels_full = new List<System.Windows.Controls.Label> { name, label_1, label_2, label_3, label_1_Copy7, label_1_Copy1, label_1_Copy2, label_3_Copy, label_3_Copy1, label_3_Copy2, label_3_Copy3, label_3_Copy4, label_1_Copy, label_1_Copy3, label_1_Copy4, label_1_Copy6, label_1_Copy5 };
            for(int i=0; i<labels_full.Count; i++ )
            {
                labels_full[i].Visibility = Visibility.Visible;
            }
        }
        public void unvisible()
        {

            List<System.Windows.Controls.Label> labels_full = new List<System.Windows.Controls.Label> { name, label_1, label_2, label_3, label_1_Copy7, label_1_Copy1, label_1_Copy2, label_3_Copy, label_3_Copy1, label_3_Copy2, label_3_Copy3, label_3_Copy4, label_1_Copy, label_1_Copy3, label_1_Copy4, label_1_Copy6, label_1_Copy5 };
            for (int i = 0; i < labels_full.Count; i++)
            {
                labels_full[i].Visibility = Visibility.Hidden;
            }
        }
        public void visible_two()
        {
            List<System.Windows.Controls.Label> labels_ulei = new List<System.Windows.Controls.Label> { title, lb, lb_Copy, lb_Copy1, lb_Copy2, lb_Copy3, lb_Copy4, lb_Copy5 };
            for (int i = 0; i < labels_ulei.Count; i++)
            {
                labels_ulei[i].Visibility = Visibility.Visible;
            }
            nomer_input.Visibility = Visibility.Visible;
        }
        public void unvisible_two()
        {
            List<System.Windows.Controls.Label> labels_ulei = new List<System.Windows.Controls.Label> { title , lb , lb_Copy , lb_Copy1  , lb_Copy2, lb_Copy3, lb_Copy4, lb_Copy5 };
            for (int i = 0; i < labels_ulei.Count; i++)
            {
                labels_ulei[i].Visibility = Visibility.Hidden;
            }
            nomer_input.Visibility = Visibility.Hidden;
        }

        private void nomer_input_TextChanged(object sender, TextChangedEventArgs e)
        {
            MessageBox.Show(Convert.ToString(nomer_id()));
        }

        public int nomer_id()
        {
            try
            {
                int id = Convert.ToInt32(nomer_input.Text);

                return (id);
            }
            finally
            {
                
            }
        }
        private void nomer_input_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
           
            MessageBox.Show(nomer_input.Text);
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

        private void back_Click(object sender, RoutedEventArgs e)
        {
            Window1 Window1 = new Window1();
            Window1.Show();
            this.Close();
            
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
        private void voidMath(int radplod, string date)
        {
            //int shag = 1;
           // Graphics e = this.CreateCraphics 

        }
    }
}
