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
using System.Data.SqlClient;
using System.Data.Common;
using System.Data;
using MySql.Data.MySqlClient;



namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }
        int id; string nomer_yacheiki_kr, family, last_date, next_date, rasplod_info, comment_info;
        public void text_id_TextChanged(object sender, TextChangedEventArgs e)
        {
            String id_text = text_id.Text;
            if (id_text != "")
            {
                id = Convert.ToInt32(id_text);
            }
            else { clean(); }
            clean();
           // connect_id(id);
            connect_kr(id);
            connect_korm(id);
            connect_dno(id);
            connect_sh8r(id);
            connect_sh10r(id);
            label_info(id);
            connect_cond(id);

        }
        public void label_info(int id)
        {
            connect_fam(id);
            connect_last_date(id);
            connect_next_date(id);
            connect_comment(id);
            connect_rasplod(id);
            lab_last_date1.Text = last_date;
            lab_next_date.Text = next_date;
            lab_family.Text = family;
            rasplod.Text = rasplod_info;
            comment.Text = comment_info;
            
        }
        public void clean()
        {
            Label1.Background = no_color.Background;
            Label2.Background = no_color.Background;
            Label3.Background = no_color.Background;
            Label4.Background = no_color.Background;
            Label5.Background = no_color.Background;
            Label6.Background = no_color.Background;
            Label7.Background = no_color.Background;
            Label8.Background = no_color.Background; 
            Label9.Background = no_color.Background;
            Label10.Background = no_color.Background;
            Label11.Background = no_color.Background;
            Label12.Background = no_color.Background;
            Label13.Background = no_color.Background;
            Label14.Background = no_color.Background;
            Label15.Background = no_color.Background;
            Label16.Background = no_color.Background;
        }
        public void connect_comment(int id)
        {
            string connectString = "server=localhost;user=root;database=diplom;password=;";
            MySqlConnection conn = new MySqlConnection(connectString);
            conn.Open();
            string q1 = "SELECT comment FROM work_1 where id = " + id;
            MySqlCommand command = new MySqlCommand(q1, conn);
            MySqlDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    Console.WriteLine(String.Format("{0}", reader[0]));
                    comment_info = Convert.ToString(reader[0]);
                }
            }
            finally
            {
                conn.Close();
            }
        }
        public void connect_rasplod(int id)
        {
            string connectString = "server=localhost;user=root;database=diplom;password=;";
            MySqlConnection conn = new MySqlConnection(connectString);
            conn.Open();
            string q1 = "SELECT rasplod FROM work_1 where id = " + id;
            MySqlCommand command = new MySqlCommand(q1, conn);
            MySqlDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    Console.WriteLine(String.Format("{0}", reader[0]));
                    rasplod_info = Convert.ToString(reader[0]);
                }
            }
            finally
            {
                conn.Close();
            }
        }
        public void connect_fam(int id)
        {
            string connectString = "server=localhost;user=root;database=diplom;password=;";
            MySqlConnection conn = new MySqlConnection(connectString);
            conn.Open();
            string q1 = "SELECT family FROM work_1 where id = " + id;
            MySqlCommand command = new MySqlCommand(q1, conn);
            MySqlDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    Console.WriteLine(String.Format("{0}", reader[0]));
                    family = Convert.ToString(reader[0]);
                }
            }
            finally
            {
                conn.Close();
            }
        }
        public void connect_last_date(int id)
        {
            string connectString = "server=localhost;user=root;database=diplom;password=;";
            MySqlConnection conn = new MySqlConnection(connectString);
            conn.Open();
            string q1 = "SELECT last_date FROM work_1 where id = " + id;
            MySqlCommand command = new MySqlCommand(q1, conn);
            MySqlDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    Console.WriteLine(String.Format("{0}", reader[0]));
                    last_date = Convert.ToString(reader[0]);
                }

            }
            finally { conn.Close(); }
            }
        public void connect_next_date(int id)
        {
            string connectString = "server=localhost;user=root;database=diplom;password=;";
            MySqlConnection conn = new MySqlConnection(connectString);
            conn.Open();
            string q1 = "SELECT next_date FROM work_1 where id = " + id;
            MySqlCommand command = new MySqlCommand(q1, conn);
            MySqlDataReader reader = command.ExecuteReader();
            try
            {

                while (reader.Read())
                {
                    Console.WriteLine(String.Format("{0}", reader[0]));
                    next_date = Convert.ToString(reader[0]);
                }
            }
            finally { conn.Close(); }
        }
        public void connect_kr(int id)
        {
            string connectString = "server=localhost;user=root;database=diplom;password=;";
            MySqlConnection conn = new MySqlConnection(connectString);
            conn.Open();
            string q1 = "SELECT nomer_kr FROM work_1 where id = " + id;
            MySqlCommand command = new MySqlCommand(q1, conn);
            MySqlDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    Console.WriteLine(String.Format("{0}", reader[0]));
                    nomer_yacheiki_kr = Convert.ToString(reader[0]);
                }
            }
            finally { conn.Close(); }
            string[] nomer_kr = nomer_yacheiki_kr.Split(new char[] { ',' });

            for (int i = 0; i < nomer_kr.Length; i++)
            {
                opredelit_nomer_krishki(nomer_kr[i]);

            }

        }
        public void connect_korm(int id)
        {
            string connectString = "server=localhost;user=root;database=diplom;password=;";
            MySqlConnection conn = new MySqlConnection(connectString);
            conn.Open();
            string q1 = "SELECT nomer_korm FROM work_1 where id = " + id;
            MySqlCommand command = new MySqlCommand(q1, conn);
            MySqlDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    Console.WriteLine(String.Format("{0}", reader[0]));
                    nomer_yacheiki_kr = Convert.ToString(reader[0]);
                }
            }
            finally
            {
                conn.Close();
            }
            string[] nomer_kr = nomer_yacheiki_kr.Split(new char[] { ',' });

            for (int i = 0; i < nomer_kr.Length; i++)
            {
                opredelit_nomer_korm(nomer_kr[i]);

            }

        }
        public void connect_dno(int id)
        {
            string connectString = "server=localhost;user=root;database=diplom;password=;";
            MySqlConnection conn = new MySqlConnection(connectString);
            conn.Open();
            string q1 = "SELECT nomer_dno FROM work_1 where id = " + id;
            MySqlCommand command = new MySqlCommand(q1, conn);
            MySqlDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    Console.WriteLine(String.Format("{0}", reader[0]));
                    nomer_yacheiki_kr = Convert.ToString(reader[0]);
                }
            }
            finally
            {
                conn.Close();
            }
            string[] nomer_kr = nomer_yacheiki_kr.Split(new char[] { ',' });

            for (int i = 0; i < nomer_kr.Length; i++)
            {
                opredelit_nomer_dno(nomer_kr[i]);

            }


        }
        public void connect_sh8r(int id)
        {
            string connectString = "server=localhost;user=root;database=diplom;password=;";
            MySqlConnection conn = new MySqlConnection(connectString);
            conn.Open();
            string q1 = "SELECT nomer_sh_8_r FROM work_1 where id = " + id;
            MySqlCommand command = new MySqlCommand(q1, conn);
            MySqlDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    Console.WriteLine(String.Format("{0}", reader[0]));
                    nomer_yacheiki_kr = Convert.ToString(reader[0]);
                }
            }
            finally
            {
                conn.Close();
            }
            string[] nomer_kr = nomer_yacheiki_kr.Split(new char[] { ',' });

            for (int i = 0; i < nomer_kr.Length; i++)
            {
                opredelit_nomer_sh8r(nomer_kr[i]);

            }
        }
        public void connect_sh10r(int id)
        {
            string connectString = "server=localhost;user=root;database=diplom;password=;";
            MySqlConnection conn = new MySqlConnection(connectString);
            conn.Open();
            string q1 = "SELECT nomer_sh_10_r FROM work_1 where id = " + id;
            MySqlCommand command = new MySqlCommand(q1, conn);
            MySqlDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    Console.WriteLine(String.Format("{0}", reader[0]));
                    nomer_yacheiki_kr = Convert.ToString(reader[0]);
                }
            }
            finally
            {
                conn.Close();
            }
            string[] nomer_kr = nomer_yacheiki_kr.Split(new char[] { ',' });

            for (int i = 0; i < nomer_kr.Length; i++)
            {
                opredelit_nomer_sh10r(nomer_kr[i]);

            }
        }
        public void connect_cond(int id)
        {
            string connectString = "server=localhost;user=root;database=diplom;password=;";
            MySqlConnection conn = new MySqlConnection(connectString);
            conn.Open();
            string q1 = "SELECT nomer_condi FROM work_1 where id = " + id;
            MySqlCommand command = new MySqlCommand(q1, conn);
            MySqlDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    Console.WriteLine(String.Format("{0}", reader[0]));
                    nomer_yacheiki_kr = Convert.ToString(reader[0]);
                }
            }
            finally { conn.Close(); }
            string[] nomer_kr = nomer_yacheiki_kr.Split(new char[] { ',' });

            for (int i = 0; i < nomer_kr.Length; i++)
            {
                opredelit_condition(nomer_kr[i]);

            }
        }
        public string opredelit_nomer_krishki(string nomer_krishki_1)
        {
            if (nomer_krishki_1 == "1")
            {
                Label1.Background = lab1.Background;
            }
            if (nomer_krishki_1 == "2")
            {
                Label2.Background = lab1.Background;
            }
            if (nomer_krishki_1 == "3")
            {
                Label3.Background = lab1.Background;
            }
            if (nomer_krishki_1 == "4")
            {
                Label4.Background = lab1.Background;
            }
            if (nomer_krishki_1 == "5")
            {
                Label5.Background = lab1.Background;
            }
            if (nomer_krishki_1 == "6")
            {
                Label6.Background = lab1.Background;
            }
            if (nomer_krishki_1 == "7")
            {
                Label7.Background = lab1.Background;
            }
            if (nomer_krishki_1 == "8")
            {
                Label8.Background = lab1.Background;
            }
            if (nomer_krishki_1 == "9")
            {
                Label9.Background = lab1.Background;
            }
            if (nomer_krishki_1 == "10")
            {
                Label10.Background = lab1.Background;
            }
            if (nomer_krishki_1 == "11")
            {
                Label11.Background = lab1.Background;
            }
            if (nomer_krishki_1 == "12")
            {
                Label12.Background = lab1.Background;
            }
            if (nomer_krishki_1 == "13")
            {
                Label13.Background = lab1.Background;
            }
            if (nomer_krishki_1 == "14")
            {
                Label14.Background = lab1.Background;
            }
            if (nomer_krishki_1 == "15")
            {
                Label15.Background = lab1.Background;
            }
            if (nomer_krishki_1 == "16")
            {
                Label16.Background = lab1.Background;
            }
            return nomer_krishki_1;
        }
        public string opredelit_nomer_korm(string nomer_krishki_1)
        {
            if (nomer_krishki_1 == "1")
            {
                Label1.Background = lab2.Background;
            }
            if (nomer_krishki_1 == "2")
            {
                Label2.Background = lab2.Background;
            }
            if (nomer_krishki_1 == "3")
            {
                Label3.Background = lab2.Background;
            }
            if (nomer_krishki_1 == "4")
            {
                Label4.Background = lab2.Background;
            }
            if (nomer_krishki_1 == "5")
            {
                Label5.Background = lab2.Background;
            }
            if (nomer_krishki_1 == "6")
            {
                Label6.Background = lab2.Background;
            }
            if (nomer_krishki_1 == "7")
            {
                Label7.Background = lab2.Background;
            }
            if (nomer_krishki_1 == "8")
            {
                Label8.Background = lab2.Background;
            }
            if (nomer_krishki_1 == "9")
            {
                Label9.Background = lab2.Background;
            }
            if (nomer_krishki_1 == "10")
            {
                Label10.Background = lab2.Background;
            }
            if (nomer_krishki_1 == "11")
            {
                Label11.Background = lab2.Background;
            }
            if (nomer_krishki_1 == "12")
            {
                Label12.Background = lab2.Background;
            }
            if (nomer_krishki_1 == "13")
            {
                Label13.Background = lab2.Background;
            }
            if (nomer_krishki_1 == "14")
            {
                Label14.Background = lab2.Background;
            }
            if (nomer_krishki_1 == "15")
            {
                Label15.Background = lab2.Background;
            }
            if (nomer_krishki_1 == "16")
            {
                Label16.Background = lab2.Background;
            }
            return nomer_krishki_1;
        }

        public string opredelit_nomer_dno(string nomer_krishki_1)
        {
            if (nomer_krishki_1 == "1")
            {
                Label1.Background = lab3.Background;
            }
            if (nomer_krishki_1 == "2")
            {
                Label2.Background = lab3.Background;
            }
            if (nomer_krishki_1 == "3")
            {
                Label3.Background = lab3.Background;
            }
            if (nomer_krishki_1 == "4")
            {
                Label4.Background = lab3.Background;
            }
            if (nomer_krishki_1 == "5")
            {
                Label5.Background = lab3.Background;
            }
            if (nomer_krishki_1 == "6")
            {
                Label6.Background = lab3.Background;
            }
            if (nomer_krishki_1 == "7")
            {
                Label7.Background = lab3.Background;
            }
            if (nomer_krishki_1 == "8")
            {
                Label8.Background = lab3.Background;
            }
            if (nomer_krishki_1 == "9")
            {
                Label9.Background = lab3.Background;
            }
            if (nomer_krishki_1 == "10")
            {
                Label10.Background = lab3.Background;
            }
            if (nomer_krishki_1 == "11")
            {
                Label11.Background = lab3.Background;
            }
            if (nomer_krishki_1 == "12")
            {
                Label12.Background = lab3.Background;
            }
            if (nomer_krishki_1 == "13")
            {
                Label13.Background = lab3.Background;
            }
            if (nomer_krishki_1 == "14")
            {
                Label14.Background = lab3.Background;
            }
            if (nomer_krishki_1 == "15")
            {
                Label15.Background = lab3.Background;
            }
            if (nomer_krishki_1 == "16")
            {
                Label16.Background = lab3.Background;
            }
            return nomer_krishki_1;
        }
        public string opredelit_nomer_sh8r(string nomer_krishki_1)
        {
            if (nomer_krishki_1 == "1")
            {
                Label1.Background = lab4.Background;
            }
            if (nomer_krishki_1 == "2")
            {
                Label2.Background = lab4.Background;
            }
            if (nomer_krishki_1 == "3")
            {
                Label3.Background = lab4.Background;
            }
            if (nomer_krishki_1 == "4")
            {
                Label4.Background = lab4.Background;
            }
            if (nomer_krishki_1 == "5")
            {
                Label5.Background = lab4.Background;
            }
            if (nomer_krishki_1 == "6")
            {
                Label6.Background = lab4.Background;
            }
            if (nomer_krishki_1 == "7")
            {
                Label7.Background = lab4.Background;
            }
            if (nomer_krishki_1 == "8")
            {
                Label8.Background = lab4.Background;
            }
            if (nomer_krishki_1 == "9")
            {
                Label9.Background = lab4.Background;
            }
            if (nomer_krishki_1 == "10")
            {
                Label10.Background = lab4.Background;
            }
            if (nomer_krishki_1 == "11")
            {
                Label11.Background = lab4.Background;
            }
            if (nomer_krishki_1 == "12")
            {
                Label12.Background = lab4.Background;
            }
            if (nomer_krishki_1 == "13")
            {
                Label13.Background = lab4.Background;
            }
            if (nomer_krishki_1 == "14")
            {
                Label14.Background = lab4.Background;
            }
            if (nomer_krishki_1 == "15")
            {
                Label15.Background = lab4.Background;
            }
            if (nomer_krishki_1 == "16")
            {
                Label16.Background = lab4.Background;
            }
            return nomer_krishki_1;
        }
        public string opredelit_nomer_sh10r(string nomer_krishki_1)
        {
            if (nomer_krishki_1 == "1")
            {
                Label1.Background = lab5.Background;
            }
            if (nomer_krishki_1 == "2")
            {
                Label2.Background = lab5.Background;
            }
            if (nomer_krishki_1 == "3")
            {
                Label3.Background = lab5.Background;
            }
            if (nomer_krishki_1 == "4")
            {
                Label4.Background = lab5.Background;
            }
            if (nomer_krishki_1 == "5")
            {
                Label5.Background = lab5.Background;
            }
            if (nomer_krishki_1 == "6")
            {
                Label6.Background = lab5.Background;
            }
            if (nomer_krishki_1 == "7")
            {
                Label7.Background = lab5.Background;
            }
            if (nomer_krishki_1 == "8")
            {
                Label8.Background = lab5.Background;
            }
            if (nomer_krishki_1 == "9")
            {
                Label9.Background = lab5.Background;
            }
            if (nomer_krishki_1 == "10")
            {
                Label10.Background = lab5.Background;
            }
            if (nomer_krishki_1 == "11")
            {
                Label11.Background = lab5.Background;
            }
            if (nomer_krishki_1 == "12")
            {
                Label12.Background = lab5.Background;
            }
            if (nomer_krishki_1 == "13")
            {
                Label13.Background = lab5.Background;
            }
            if (nomer_krishki_1 == "14")
            {
                Label14.Background = lab5.Background;
            }
            if (nomer_krishki_1 == "15")
            {
                Label15.Background = lab5.Background;
            }
            if (nomer_krishki_1 == "16")
            {
                Label16.Background = lab5.Background;
            }
            return nomer_krishki_1;
        }
        public string opredelit_condition(string nomer_krishki_1)
        {
            if (nomer_krishki_1 == "1")
            {
                Label1.Background = lab_condi_color.Background;
            }
            if (nomer_krishki_1 == "2")
            {
                Label2.Background = lab_condi_color.Background;
            }
            if (nomer_krishki_1 == "3")
            {
                Label3.Background = lab_condi_color.Background;
            }
            if (nomer_krishki_1 == "4")
            {
                Label4.Background = lab_condi_color.Background;
            }
            if (nomer_krishki_1 == "5")
            {
                Label5.Background = lab_condi_color.Background;
            }
            if (nomer_krishki_1 == "6")
            {
                Label6.Background = lab_condi_color.Background;
            }
            if (nomer_krishki_1 == "7")
            {
                Label7.Background = lab_condi_color.Background;
            }
            if (nomer_krishki_1 == "8")
            {
                Label8.Background = lab_condi_color.Background;
            }
            if (nomer_krishki_1 == "9")
            {
                Label9.Background = lab_condi_color.Background;
            }
            if (nomer_krishki_1 == "10")
            {
                Label10.Background = lab_condi_color.Background;
            }
            if (nomer_krishki_1 == "11")
            {
                Label11.Background = lab_condi_color.Background;
            }
            if (nomer_krishki_1 == "12")
            {
                Label12.Background = lab_condi_color.Background;
            }
            if (nomer_krishki_1 == "13")
            {
                Label13.Background = lab_condi_color.Background;
            }
            if (nomer_krishki_1 == "14")
            {
                Label14.Background = lab_condi_color.Background;
            }
            if (nomer_krishki_1 == "15")
            {
                Label15.Background = lab_condi_color.Background;
            }
            if (nomer_krishki_1 == "16")
            {
                Label16.Background = lab_condi_color.Background;
            }
            return nomer_krishki_1;
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            Window1 Window1 = new Window1();
            Window1.Show();
            this.Close();
        }

    }
}
