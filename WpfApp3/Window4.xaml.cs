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
    /// Логика взаимодействия для Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
            labels_one = new Label[] { Label_1, Label_2, Label_3, Label_4, Label_5, Label_6, Label_7, Label_8, Label_9, Label_10, Label_11, Label_12, Label_13, Label_14, Label_15, Label_16 };
             labels_two = new Label[] { Label_17, Label_18, Label_19, Label_20, Label_21, Label_22, Label_23, Label_24, Label_25, Label_26, Label_27, Label_28, Label_29, Label_30, Label_31, Label_32 };
             labels_three = new Label[] { Label_33, Label_34, Label_35, Label_36, Label_37, Label_38, Label_39, Label_40, Label_41, Label_42, Label_43, Label_44, Label_45, Label_46, Label_47, Label_48 };
            labels_four = new Label[] { Label_49, Label_50, Label_51, Label_52, Label_53, Label_54, Label_55, Label_56, Label_57, Label_58, Label_59, Label_60, Label_61, Label_62, Label_63, Label_64 };
            labels_five = new Label[] { Label_65, Label_66, Label_67, Label_68, Label_69, Label_70, Label_71, Label_72, Label_73, Label_74, Label_75, Label_76, Label_77, Label_78, Label_79, Label_80 };
         labels_six = new Label[] { Label_6_1, Label_6_2, Label_6_3, Label_6_4, Label_6_5, Label_6_6, Label_6_7, Label_6_8, Label_6_9, Label_6_10, Label_6_11, Label_6_12, Label_6_13, Label_6_14, Label_6_15, Label_6_16 };
          labels_seven = new Label[] { Label_7_1, Label_7_2, Label_7_3, Label_7_4, Label_7_5, Label_7_6, Label_7_7, Label_7_8, Label_7_9, Label_7_10, Label_7_11, Label_7_12, Label_7_13, Label_7_14, Label_7_15, Label_7_16 };
             labels_8 = new Label[] { Label_8_1, Label_8_2, Label_8_3, Label_8_4, Label_8_5, Label_8_6, Label_8_7, Label_8_8, Label_8_9, Label_8_10, Label_8_11, Label_8_12, Label_8_13, Label_8_14, Label_8_15, Label_8_16 };
            labels_9 = new Label[] { Label_9_1, Label_9_2, Label_9_3, Label_9_4, Label_9_5, Label_9_6, Label_9_7, Label_9_8, Label_9_9, Label_9_10, Label_9_11, Label_9_12, Label_9_13,Label_9_14, Label_9_15, Label_9_16 };
            labels_10 = new Label[] { Label_10_1, Label_10_2, Label_10_3, Label_10_4, Label_10_5, Label_10_6, Label_10_7, Label_10_8, Label_10_9, Label_10_10, Label_10_11, Label_10_13, Label_10_12, Label_10_14, Label_10_15, Label_10_16 };
            labels_11 = new Label[] { Label_11_1, Label_11_2, Label_11_3, Label_11_4, Label_11_5, Label_11_6, Label_11_7, Label_11_8, Label_11_9, Label_11_10, Label_11_11, Label_11_13, Label_11_12, Label_11_14, Label_11_15, Label_11_16 };
            labels_12 = new Label[] { Label_12_1, Label_12_2, Label_12_3, Label_12_4, Label_12_5, Label_12_6, Label_12_7, Label_12_8, Label_12_9, Label_12_10, Label_12_11, Label_12_13, Label_12_12, Label_12_14, Label_12_15, Label_12_16 };
            labels_13 = new Label[] { Label_13_1, Label_13_2, Label_13_3, Label_13_4, Label_13_5, Label_13_6, Label_13_7, Label_13_8, Label_13_9, Label_13_10, Label_13_11, Label_13_13, Label_13_12, Label_13_14, Label_13_15, Label_13_16 };
            labels_14 = new Label[] { Label_14_1, Label_14_2, Label_14_3, Label_14_4, Label_14_5, Label_14_6, Label_14_7, Label_14_8, Label_14_9, Label_14_10, Label_14_11, Label_14_13, Label_14_12, Label_14_14, Label_14_15, Label_14_16 };
            labels_15 = new Label[] { Label_15_1, Label_15_2, Label_15_3, Label_15_4, Label_15_5, Label_15_6, Label_15_7, Label_15_8, Label_15_9, Label_15_10, Label_15_11, Label_15_13, Label_15_12, Label_15_14, Label_15_15, Label_15_16 };
            labels_16 = new Label[] { Label_16_1, Label_16_2, Label_16_3, Label_16_4, Label_16_5, Label_16_6, Label_16_7, Label_16_8, Label_16_9, Label_16_10, Label_16_11, Label_16_13, Label_16_12, Label_16_14, Label_16_15, Label_16_16 };
            labels_17 = new Label[] { Label_17_1, Label_17_2, Label_17_3, Label_17_4, Label_17_5, Label_17_6, Label_17_7, Label_17_8, Label_17_9, Label_17_10, Label_17_11, Label_17_13, Label_17_12, Label_17_14, Label_17_15, Label_17_16 };
            labels_18 = new Label[] { Label_18_1, Label_18_2, Label_18_3, Label_18_4, Label_18_5, Label_18_6, Label_18_7, Label_18_8, Label_18_9, Label_18_10, Label_18_11, Label_18_13, Label_18_12, Label_18_14, Label_18_15, Label_18_16 };
            labels_19 = new Label[] { Label_19_1, Label_19_2, Label_19_3, Label_19_4, Label_19_5, Label_19_6, Label_19_7, Label_19_8, Label_19_9, Label_19_10, Label_19_11, Label_19_13, Label_19_12, Label_19_14, Label_19_15, Label_19_16 };
            labels_20 = new Label[] { Label_20_1, Label_20_2, Label_20_3, Label_20_4, Label_20_5, Label_20_6, Label_10_7, Label_20_8, Label_20_9, Label_20_10, Label_20_11, Label_20_13, Label_20_12, Label_20_14, Label_20_15, Label_20_16 };

            labels = new List<Label[]> { labels_one, labels_two, labels_three, labels_four, labels_five, labels_six, labels_seven,labels_8, labels_9, labels_10, labels_11, labels_12, labels_13, labels_14, labels_15, labels_16, labels_17, labels_18, labels_19, labels_20 };


        }
        Label[] labels_one; Label[] labels_five; Label[] labels_8; Label[] labels_12; Label[] labels_15; Label[] labels_18;
        Label[] labels_two; Label[] labels_six; Label[] labels_10; Label[] labels_13; Label[] labels_16; Label[] labels_19;
        Label[] labels_three; Label[] labels_seven; Label[] labels_11; Label[] labels_14; Label[] labels_17; Label[] labels_20;
        Label[] labels_four; Label[] labels_9;
        List<Label[]> labels;
        string connectString = "server=localhost;user=root;database=diplom;password=;";
        string nomer_yacheiki_kr, next_date, last_date, family, commentarii_vivod;
        Boolean all= false;
      //  private List<Label> labels_one;
      //   private List<Label> labels_two;
      //    public int[] id;


        public void select_id()

        {

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            lables_no_color();
            attention.IsChecked = false;
            Label[] nomera = new Label[] { Nomer_1, Nomer_2, Nomer_3, Nomer_4, Nomer_5, Nomer_7, Nomer_8, Nomer_9, Nomer_10, Nomer_11, Nomer_12, Nomer_13, Nomer_14, Nomer_15, Nomer_16, Nomer_17, Nomer_18, Nomer_19, Nomer_20, Nomer_21 };
            int[] id = new int[] { 1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20 };
            int k = 1;
            if (show_all1.IsChecked == true)
            {
                for(int j = 0; j< nomera.Length ; j++)
                {
                    nomera[j].Content =k++;
                }
                for (int i = 0; i < 20; i++)
            {
                connect_kr(id[i]);
                connect_korm(id[i]);
                connect_dno(id[i]);
                connect_sh8r(id[i]);
                connect_sh10r(id[i]);
                connect_cond(id[i]);
            }
                for (int i = 0; i < 16; i++)
                {

                    labels_one[i].MouseLeftButtonDown += one_MouseLeftButtonDown;
                    labels_two[i].MouseLeftButtonDown += two_MouseLeftButtonDown;
                    labels_three[i].MouseLeftButtonDown += three_MouseLeftButtonDown;
                    labels_four[i].MouseLeftButtonDown += four_MouseLeftButtonDown;
                    labels_five[i].MouseLeftButtonDown += five_MouseLeftButtonDown;
                    labels_six[i].MouseLeftButtonDown += six_MouseLeftButtonDown;
                    labels_seven[i].MouseLeftButtonDown += c7_MouseLeftButtonDown;
                    labels_8[i].MouseLeftButtonDown += c8_MouseLeftButtonDown;
                    labels_9[i].MouseLeftButtonDown += c9_MouseLeftButtonDown;
                    labels_10[i].MouseLeftButtonDown += c10_MouseLeftButtonDown;
                    labels_11[i].MouseLeftButtonDown += c11_MouseLeftButtonDown;
                    labels_12[i].MouseLeftButtonDown += c12_MouseLeftButtonDown;
                    labels_13[i].MouseLeftButtonDown += c13_MouseLeftButtonDown;
                    labels_14[i].MouseLeftButtonDown += c14_MouseLeftButtonDown;
                    labels_15[i].MouseLeftButtonDown += c15_MouseLeftButtonDown;
                    labels_16[i].MouseLeftButtonDown += c16_MouseLeftButtonDown;
                    labels_17[i].MouseLeftButtonDown += c17_MouseLeftButtonDown;
                    labels_18[i].MouseLeftButtonDown += c18_MouseLeftButtonDown;
                    labels_19[i].MouseLeftButtonDown += c19_MouseLeftButtonDown;
                    labels_20[i].MouseLeftButtonDown += c20_MouseLeftButtonDown;

                }

            }

        }

      
        private void FormMain_Load(object sender, EventArgs e)
        {
        
          
        }

        private  void one_MouseLeftButtonDown(object sender, EventArgs e)
        {
            comment_info(1);
            
        }
        private void two_MouseLeftButtonDown(object sender, EventArgs e)
        {
            comment_info(2);

        }
        private void three_MouseLeftButtonDown(object sender, EventArgs e)
        {
            comment_info(3);

        }
        private void four_MouseLeftButtonDown(object sender, EventArgs e)
        {
            comment_info(4);

        }
        private void five_MouseLeftButtonDown(object sender, EventArgs e)
        {
            comment_info(5);

        }
        private void six_MouseLeftButtonDown(object sender, EventArgs e)
        {
            comment_info(6);

        }
        private void c7_MouseLeftButtonDown(object sender, EventArgs e)
        {
            comment_info(7);

        }
        private void c8_MouseLeftButtonDown(object sender, EventArgs e)
        {
            comment_info(8);

        }
        private void c9_MouseLeftButtonDown(object sender, EventArgs e)
        {
            comment_info(9);

        }
        private void c10_MouseLeftButtonDown(object sender, EventArgs e)
        {
            comment_info(10);

        }
        private void c11_MouseLeftButtonDown(object sender, EventArgs e)
        {
            comment_info(11);

        }
        private void c12_MouseLeftButtonDown(object sender, EventArgs e)
        {
            comment_info(12);

        }
        private void c13_MouseLeftButtonDown(object sender, EventArgs e)
        {
            comment_info(13);

        }
        private void c14_MouseLeftButtonDown(object sender, EventArgs e)
        {
            comment_info(14);

        }
        private void c15_MouseLeftButtonDown(object sender, EventArgs e)
        {
            comment_info(15);

        }
        private void c16_MouseLeftButtonDown(object sender, EventArgs e)
        {
            comment_info(16);

        }
        private void c17_MouseLeftButtonDown(object sender, EventArgs e)
        {
            comment_info(17);

        }
        private void c18_MouseLeftButtonDown(object sender, EventArgs e)
        {
            comment_info(18);

        }
        private void c19_MouseLeftButtonDown(object sender, EventArgs e)
        {
            comment_info(19);

        }
        private void c20_MouseLeftButtonDown(object sender, EventArgs e)
        {
            comment_info(20);

        }
        public void opredelit_nomer_krishki(string nomer_krishki_1, int id_nomer)
        {
            int k = Convert.ToInt32(nomer_krishki_1 );
            int x = k;
            if (x>0)
            {               
                        labels[id_nomer-1][x-1].Background = lab1_1.Background;                    
            }
        }
        public void opredelit_nomer_korm(string nomer_krishki_1, int id_nomer)
        {

            int x = Convert.ToInt32(nomer_krishki_1);
            if (x > 0)
            {
                    labels[id_nomer - 1][x - 1].Background = lab2_2.Background;
            }
        }
        public void opredelit_nomer_dno(string nomer_krishki_1, int id_nomer)
        {

            int x = Convert.ToInt32(nomer_krishki_1);
            if (x > 0)
            {
                    labels[id_nomer - 1][x - 1].Background = lab3_3.Background;
            }
        }
        public void opredelit_nomer_sh8r(string nomer_krishki_1, int id_nomer)
        {
 
            int x = Convert.ToInt32(nomer_krishki_1) ;
            if (x>0)
            {
                  
                        labels[id_nomer - 1][x-1].Background = lab4_4.Background;                    
            }
        }
        public void opredelit_nomer_sh10r(string nomer_krishki_1, int id_nomer)
        {

            int x = Convert.ToInt32(nomer_krishki_1);
            if (x > 0)
            {
                    labels[id_nomer - 1][x - 1].Background = lab5_5.Background;
                
            }
        }
        public void opredelit_condition(string nomer_krishki_1, int id_nomer)
        {
            int x = Convert.ToInt32(nomer_krishki_1);
            if (x > 0)
            {
                    labels[id_nomer - 1][x - 1].Background = lab_condi_color.Background;
                
            }
        }
        public void comment_info(int id)
        {
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
                    commentarii_vivod = Convert.ToString(reader[0]);
                }
            }
            finally { conn.Close(); }
            MessageBox.Show(commentarii_vivod);
        }
        public void connect_kr(int id)
        {
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
                opredelit_nomer_krishki(nomer_kr[i],id);

            }
        

        }
        public void connect_korm(int id)
        {
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
            finally { conn.Close(); }
            string[] nomer_kr = nomer_yacheiki_kr.Split(new char[] { ',' });

            for (int i = 0; i < nomer_kr.Length; i++)
            {
                opredelit_nomer_korm(nomer_kr[i],id);

            }

        }
        public void connect_dno(int id)
        {
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
            finally { conn.Close(); }
            string[] nomer_kr = nomer_yacheiki_kr.Split(new char[] { ',' });

            for (int i = 0; i < nomer_kr.Length; i++)
            {
                opredelit_nomer_dno(nomer_kr[i],id);

            }


        }
        public void connect_sh8r(int id)
        {
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
            finally { conn.Close(); }
            string[] nomer_kr = nomer_yacheiki_kr.Split(new char[] { ',' });

            for (int i = 0; i < nomer_kr.Length; i++)
            {
                opredelit_nomer_sh8r(nomer_kr[i],id);

            }
        }
        public void connect_sh10r(int id)
        {
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
            finally { conn.Close(); }
            string[] nomer_kr = nomer_yacheiki_kr.Split(new char[] { ',' });

            for (int i = 0; i < nomer_kr.Length; i++)
            {
                opredelit_nomer_sh10r(nomer_kr[i],id);

            }
        }
        public void connect_cond(int id)
        {
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
                opredelit_condition(nomer_kr[i],id);

            }
        }
        private void attention_Checked(object sender, RoutedEventArgs e)
        {
            lables_no_color();
            attention_connect();
        }
        public void lables_no_color()
        {
            for (int i = 0; i < labels.Count; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    labels[i][j].Background = no_color.Background;
                }
            }
        }
        public void attention_comment(int id)
        {

        }
        public void attention_connect()
        {

            Label[] nomera = new Label[] { Nomer_1, Nomer_2, Nomer_3, Nomer_4, Nomer_5, Nomer_7, Nomer_8, Nomer_9, Nomer_10, Nomer_11, Nomer_12, Nomer_13, Nomer_14, Nomer_15, Nomer_16, Nomer_17, Nomer_18, Nomer_19, Nomer_20 };
            List<int> att_id = new List<int>();
            if (attention.IsChecked == true)
            {
                show_all1.IsChecked = false;
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q1 = "SELECT number FROM work_1 where attention = 1";
                MySqlCommand command = new MySqlCommand(q1, conn);
                MySqlDataReader reader = command.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        for (int i = 0; i == reader.Depth; i++)
                        {
                            Console.WriteLine(String.Format("{0}", reader[0]));
                            att_id.Add(Convert.ToInt32(reader[i]));
                        }
                    }
                }
                finally { conn.Close(); }
            }

            Label[] att_mess = new Label[] { att_lab_1, att_lab_2 };

            for (int j = 0; j < att_id.Count; j++)
            {
                nomera[j].Content = att_id[j];
                int q = att_id[j];
                for (int i = 0; i < 16; i++)
                {
                    labels[j][i].MouseLeftButtonDown += attention_comment_MouseLeftButtonDown;
                }
                void attention_comment_MouseLeftButtonDown(object sender, EventArgs e)
                {

                    comment_info(q);
                }
                for (int i = 0; i < connect_kr_att(att_id[j]).Length; i++)
                {
                    
                    int x = Convert.ToInt32(connect_kr_att(att_id[j])[i]);
                    if (x > 0)
                    {
                        labels[j][x - 1].Background = lab1_1.Background;
                        
                    }
                }
            }
            for (int j = 0; j < att_id.Count; j++)
            {
                nomera[j].Content = att_id[j];
                for (int i = 0; i < connect_korm_att(att_id[j]).Length; i++)
                {
                    int x = Convert.ToInt32(connect_korm_att(att_id[j])[i]);
                    if (x > 0)
                    {
                        labels[j][x - 1].Background = lab2_2.Background;
                    }
                }
            }
            for (int j = 0; j < att_id.Count; j++)
            {
                for (int i = 0; i < connect_dno_att(att_id[j]).Length; i++)
                {
                    int x = Convert.ToInt32(connect_dno_att(att_id[j])[i]);
                    if (x > 0)
                    {
                        labels[j][x - 1].Background = lab3_3.Background;
                    }
                }
            }
            for (int j = 0; j < att_id.Count; j++)
            {
                for (int i = 0; i < connect_sh8r_att(att_id[j]).Length; i++)
                {
                    int x = Convert.ToInt32(connect_sh8r_att(att_id[j])[i]);
                    if (x > 0)
                    {
                        labels[j][x - 1].Background = lab4_4.Background;
                    }
                }
            }
            for (int j = 0; j < att_id.Count; j++)
            {
                for (int i = 0; i < connect_sh10r_att(att_id[j]).Length; i++)
                {
                    int x = Convert.ToInt32(connect_sh10r_att(att_id[j])[i]);
                    if (x > 0)
                    {
                        labels[j][x - 1].Background = lab5_5.Background;
                    }
                }
            }
            for (int j = 0; j < att_id.Count; j++)
            {
                for (int i = 0; i < connect_cond_att(att_id[j]).Length; i++)
                        {
                            int x = Convert.ToInt32(connect_cond_att(att_id[j])[i]);
                            if (x > 0)
                            {
                                labels[j][x - 1].Background = lab_condi_color.Background;
                            }
                        }
                    }
                
            
     
        }
        public void att_color()
        {

        }
        public string[] connect_kr_att(int id)
        {
            MySqlConnection conn = new MySqlConnection(connectString);
            conn.Open();
            string q1 = "SELECT nomer_kr FROM work_1 where number = " + id;
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
            return nomer_kr;

        }
        public string[] connect_korm_att(int id)
        {
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
            finally { conn.Close(); }
            string[] nomer_kr = nomer_yacheiki_kr.Split(new char[] { ',' });
            return nomer_kr;

        }
        public string[] connect_dno_att(int id)
        {
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
            finally { conn.Close(); }
            string[] nomer_kr = nomer_yacheiki_kr.Split(new char[] { ',' });

            return nomer_kr;

        }
        public string[] connect_sh8r_att(int id)
        {
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
            finally { conn.Close(); }
            string[] nomer_kr = nomer_yacheiki_kr.Split(new char[] { ',' });
            return nomer_kr;
        }

        private void ScrollBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void ScrollBar_ValueChanged_1(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void back_Click_1(object sender, RoutedEventArgs e)
        {
            Window1 Window1 = new Window1();
            Window1.Show();
            this.Close();
        }
        public string[] connect_sh10r_att(int id)
        {
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
            finally { conn.Close(); }
            string[] nomer_kr = nomer_yacheiki_kr.Split(new char[] { ',' });
            return nomer_kr;
        }
        public string[] connect_cond_att(int id)
        {
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
            return nomer_kr;
        }
        private void back_Click(object sender, RoutedEventArgs e)
        {
            Window1 Window1 = new Window1();
            Window1.Show();
            this.Close();
        }
        private void combobox_id_ContextMenuClosing(object sender, ContextMenuEventArgs e)
        {

        }

    }
}
