using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;using System.Text;

using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data;
using MySql.Data.MySqlClient;

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataSet dataset = new DataSet();

        public MainWindow()
        {
            InitializeComponent();
            labels_one = new List<Label> { Label_1, Label_2, Label_3, Label_4, Label_5, Label_6, Label_7, Label_8, Label_9, Label_10, Label_11, Label_12, Label_13, Label_14, Label_15, Label_16 };
        }

        List<Label> labels_one;
        static Boolean ld = false, nd = false, f = false, r = false, ramkiif = false, shuh_uzif = false, shuh_shif = false, yacheika1 = false, yacheika8, yacheika9, yacheika10, yacheika11, yacheika12, yacheika13, yacheika14, yacheika15, yacheika16, nomerif = true, yacheika2, yacheika3, yacheika4, yacheika5, yacheika6, yacheika7;
        //      static Boolean yacheika1, yacheika8 , yacheika9 , yacheika10, yacheika11, yacheika12 , yacheika13, yacheika14 , yacheika15 , yacheika16 , nomerif = true, yacheika2 , yacheika3 , yacheika4, yacheika5, yacheika6 , yacheika7 ;
        Boolean[] yacheiki = { yacheika1, yacheika2, yacheika3, yacheika4, yacheika5, yacheika6, yacheika7, yacheika8, yacheika9, yacheika10, yacheika11, yacheika12, yacheika13, yacheika14, yacheika15, yacheika16 };
        int kr = 0, attention_if = 0;
        int korm = 0;
        int dno = 0, condi = 0;
        int id;
        double shuh8 , shuh10 , ramki, shuh8_prom = 0, shuh10_prom = 0, shuh_uz = 0, shuh_sh = 0;
        string last_date, next_date, fam, ras, comm, family, nomer_yacheiki_kr, rasplod, commentarii_vivod,nomer_condition, ramki_2, sh_uz_2 , sh_sh_2 ;
        //    static Label Label1, Label2, Label3, Label4, Label5, Label6, Label7, Label8, Label9, Label10, Label11, Label12,Label13, Label14, Label15,Label16;
        //    Label[] labels = {Label1, Label2, Label3, Label4, Label5, Label6, Label7, Label8, Label9, Label10, Label11, Label12, Label13, Label14, Label15, Label16 };

        private void labels(int nomer)
        {
            for (int i = 0; i < yacheiki.Length; i++)
            {
                yacheiki[i] = false;
            }
            visible_yachiki();
            yacheiki[nomer] = true;
            attention.IsChecked = false;
        }

        private void Label_1_MouseDoubleClick(object sender, MouseButtonEventArgs e)//ячейка 1
        {
            labels(0);
            for (int i = 0; i < 16; i++)
            {
                if (labels_one[i].Background == color_click.Background)
                {
                    labels_one[i].Background = no_color.Background;
                }
            }
            labels_one[0].Background = color_click.Background;
        }
        private void Label_2_MouseDoubleClick(object sender, MouseButtonEventArgs e)//ячейка 2
        {
            labels(1);
            for (int i = 0; i < labels_one.Count; i++)
            {
                if (labels_one[i].Background == color_click.Background)
                {
                    labels_one[i].Background = no_color.Background;
                }
            }
            labels_one[1].Background = color_click.Background;


        }
        private void Label_3_MouseDoubleClick(object sender, MouseButtonEventArgs e)//ячейка 3
        {
            labels(2);
            for (int i = 0; i < labels_one.Count; i++)
            {
                if (labels_one[i].Background == color_click.Background)
                {
                    labels_one[i].Background = no_color.Background;
                }
            }
            labels_one[2].Background = color_click.Background;
        }
        private void Label_4_MouseDoubleClick(object sender, MouseButtonEventArgs e)//ячейка 4
        {

            labels(3);
            for (int i = 0; i < labels_one.Count; i++)
            {
                if (labels_one[i].Background == color_click.Background)
                {
                    labels_one[i].Background = no_color.Background;
                }
            }
            labels_one[3].Background = color_click.Background;

        }
        private void Label_5_MouseDoubleClick(object sender, MouseButtonEventArgs e)//ячейка 5
        {
            labels(4);
            for (int i = 0; i < labels_one.Count; i++)
            {
                if (labels_one[i].Background == color_click.Background)
                {
                    if (labels_one[i].Background == color_click.Background)
                    {
                        labels_one[i].Background = no_color.Background;
                    }
                }
            }
            labels_one[4].Background = color_click.Background;
        }
        private void Label_6_MouseDoubleClick(object sender, MouseButtonEventArgs e)//ячейка 6
        {
            labels(5);
            for (int i = 0; i < labels_one.Count; i++)
            {
                if (labels_one[i].Background == color_click.Background)
                {
                    labels_one[i].Background = no_color.Background;
                }
            }
            labels_one[5].Background = color_click.Background;
        }
        private void Label_7_MouseDoubleClick(object sender, MouseButtonEventArgs e)//ячейка 7
        {
            labels(6);
            for (int i = 0; i < labels_one.Count; i++)
            {
                if (labels_one[i].Background == color_click.Background)
                {
                    labels_one[i].Background = no_color.Background;
                }
            }
            labels_one[6].Background = color_click.Background;
        }
        private void Label_8_MouseDoubleClick(object sender, MouseButtonEventArgs e)//ячейка 8
        {
            labels(7);
            for (int i = 0; i < labels_one.Count; i++)
            {
                if (labels_one[i].Background == color_click.Background)
                {
                    labels_one[i].Background = no_color.Background;
                }
            }
            labels_one[7].Background = color_click.Background;

        }
        private void Label_9_MouseDoubleClick(object sender, MouseButtonEventArgs e)//ячейка 9
        {
            labels(8);
            for (int i = 0; i < labels_one.Count; i++)
            {
                if (labels_one[i].Background == color_click.Background)
                {
                    labels_one[i].Background = no_color.Background;
                }
            }
            labels_one[8].Background = color_click.Background;

        }
        private void Label_10_MouseDoubleClick(object sender, MouseButtonEventArgs e)//ячейка 10
        {
            labels(9);
            for (int i = 0; i < labels_one.Count; i++)
            {
                if (labels_one[i].Background == color_click.Background)
                {
                    labels_one[i].Background = no_color.Background;
                }
            }
            labels_one[9].Background = color_click.Background;

        }
        private void Label_11_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            labels(10);
            for (int i = 0; i < labels_one.Count; i++)
            {
                if (labels_one[i].Background == color_click.Background)
                {
                    labels_one[i].Background = no_color.Background;
                }
            }
            labels_one[10].Background = color_click.Background;
        }
        private void Label_12_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            labels(11);
            for (int i = 0; i < labels_one.Count; i++)
            {
                if (labels_one[i].Background == color_click.Background)
                {
                    labels_one[i].Background = no_color.Background;
                }
            }
            labels_one[11].Background = color_click.Background;
        }
        private void Label_13_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            labels(12);
            for (int i = 0; i < labels_one.Count; i++)
            {
                if (labels_one[i].Background == color_click.Background)
                {
                    labels_one[i].Background = no_color.Background;
                }
            }
            labels_one[12].Background = color_click.Background;
        }
        private void Label_14_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            labels(13);
            for (int i = 0; i < labels_one.Count; i++)
            {
                if (labels_one[i].Background == color_click.Background)
                {
                    labels_one[i].Background = no_color.Background;
                }
            }
            labels_one[13].Background = color_click.Background;
        }
        private void Label_15_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            labels(14);
            for (int i = 0; i < labels_one.Count; i++)
            {
                if (labels_one[i].Background == color_click.Background)
                {
                    labels_one[i].Background = no_color.Background;
                }
            }
            labels_one[14].Background = color_click.Background;
        }
        private void Label_16_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            labels(15);
            for (int i = 0; i < labels_one.Count; i++)
            {
                if (labels_one[i].Background == color_click.Background)
                {
                    labels_one[i].Background = no_color.Background;
                }
            }
            labels_one[15].Background = color_click.Background;

        }

        private void visible_yachiki()
        {
            lab1.Visibility = Visibility.Visible;
            lab1_1.Visibility = Visibility.Visible;
            lab2.Visibility = Visibility.Visible;
            lab2_2.Visibility = Visibility.Visible;
            lab3.Visibility = Visibility.Visible;
            lab3_3.Visibility = Visibility.Visible;
            lab4.Visibility = Visibility.Visible;
            lab4_4.Visibility = Visibility.Visible;
            lab5.Visibility = Visibility.Visible;
            lab5_5.Visibility = Visibility.Visible;
            lab_condi.Visibility = Visibility.Visible;
            lab_condi_color.Visibility = Visibility.Visible;

        }
        private void hidden_yacheiki()
        {
            lab1.Visibility = Visibility.Hidden;
            lab1_1.Visibility = Visibility.Hidden;
            lab2.Visibility = Visibility.Hidden;
            lab2_2.Visibility = Visibility.Hidden;
            lab3.Visibility = Visibility.Hidden;
            lab3_3.Visibility = Visibility.Hidden;
            lab4.Visibility = Visibility.Hidden;
            lab4_4.Visibility = Visibility.Hidden;
            lab5.Visibility = Visibility.Hidden;
            lab5_5.Visibility = Visibility.Hidden;
            lab_condi.Visibility = Visibility.Hidden;
            lab_condi_color.Visibility = Visibility.Hidden;
        }
        private void yacheiki_false()
        {
            for (int i = 0; i < yacheiki.Length; i++)
            {
                yacheiki[i] = false;
            }
        }
        private void Button2_Click(object sender, RoutedEventArgs e)//кнопка назад
        {
            Window1 Window1 = new Window1();
            Window1.Show();
            this.Close();

        }


        private void lab1_1_MouseDoubleClick_1(object sender, MouseButtonEventArgs e)//krishkio
        {
            ramkiif = true;
            shuh_shif = true;
            shuh_uzif = true;
          
            if (yacheiki[0] == true)
            {
                kr = kr + 1;
                Label_1.Background = lab1_1.Background;
                hidden_yacheiki();
                
                yacheiki_false();
            }
            if (yacheiki[1] == true)
            {
                kr = kr + 1;
                Label_2.Background = lab1_1.Background;
                hidden_yacheiki();
                
                yacheiki_false();
            }
            if (yacheiki[2] == true)
            {
                kr = kr + 1;
                Label_3.Background = lab1_1.Background;
                hidden_yacheiki();
                yacheiki_false();
            }
            if (yacheiki[3] == true)
            {
                kr = kr + 1;
                Label_4.Background = lab1_1.Background;
                hidden_yacheiki();
                yacheiki_false();
            }
            if (yacheiki[4] == true)
            {
                kr = kr + 1;
                Label_5.Background = lab1_1.Background;
                hidden_yacheiki();
                yacheiki_false();
            }
            if (yacheiki[5] == true)
            {
                kr = kr + 1;
                Label_6.Background = lab1_1.Background;
                hidden_yacheiki();
                yacheika1 = false;
                yacheiki_false();
            }
            if (yacheiki[6] == true)
            {
                kr = kr + 1;
                Label_7.Background = lab1_1.Background;
                hidden_yacheiki();
                yacheika1 = false;
                yacheiki_false();
            }
            if (yacheiki[7] == true)
            {
                kr = kr + 1;
                Label_8.Background = lab1_1.Background;
                hidden_yacheiki();
                yacheika1 = false;
                yacheiki_false();
            }
            if (yacheiki[8] == true)
            {
                kr = kr + 1;
                Label_9.Background = lab1_1.Background;
                hidden_yacheiki();
                yacheika1 = false;
                yacheiki_false();
            }
            if (yacheiki[9] == true)
            {
                kr = kr + 1;
                Label_10.Background = lab1_1.Background;
                hidden_yacheiki();
                yacheika1 = false;
                yacheiki_false();
            }
            if (yacheiki[10] == true)
            {
                kr = kr + 1;
                Label_11.Background = lab1_1.Background;
                hidden_yacheiki();
                yacheika1 = false;
                yacheiki_false();
            }
            if (yacheiki[11] == true)
            {
                kr = kr + 1;
                Label_12.Background = lab1_1.Background;
                hidden_yacheiki();
                yacheika1 = false;
                yacheiki_false();
            }
            if (yacheiki[12] == true)
            {
                kr = kr + 1;
                Label_13.Background = lab1_1.Background;
                hidden_yacheiki();
                yacheika1 = false;
                yacheiki_false();
            }
            if (yacheiki[13] == true)
            {
                kr = kr + 1;
                Label_14.Background = lab1_1.Background;
                hidden_yacheiki();
                yacheika1 = false;
                yacheiki_false();
            }
            if (yacheiki[14] == true)
            {
                kr = kr + 1;
                Label_15.Background = lab1_1.Background;
                hidden_yacheiki();
                yacheika1 = false;
                yacheiki_false();
            }
            if (yacheiki[15] == true)
            {
                kr = kr + 1;
                Label_16.Background = lab1_1.Background;
                hidden_yacheiki();
                yacheika1 = false;
                yacheiki_false();
            }
            shuh_uz = kr + dno;
            shuh_sh = shuh10_prom + shuh8_prom;
            ramki = shuh8_prom * 8 + shuh10_prom * 10 + dno + kr;

            lab10_10.Text = "ramki= " + ramki + "; шухлятки узкие= " + shuh_uz + "; шухлятки широкие = " + shuh_sh;

        }
        private void lab2_2_MouseDoubleClick(object sender, MouseButtonEventArgs e)//korm
        {


            if (yacheiki[0] == true)
            {
                korm = korm + 1;
                Label_1.Background = lab2_2.Background;
                hidden_yacheiki();
                yacheiki_false();
            }
            if (yacheiki[1] == true)
            {
                korm = korm + 1;
                Label_2.Background = lab2_2.Background;
                hidden_yacheiki();
                yacheiki_false();
            }
            if (yacheiki[2] == true)
            {
                korm = korm + 1;
                Label_3.Background = lab2_2.Background;
                hidden_yacheiki();
                yacheiki_false();
            }
            if (yacheiki[3] == true)
            {
                korm = korm + 1;
                Label_4.Background = lab2_2.Background;
                hidden_yacheiki();
                yacheiki_false();
            }
            if (yacheiki[4] == true)
            {
                korm = korm + 1;
                Label_5.Background = lab2_2.Background;
                hidden_yacheiki();
                yacheiki_false();
            }
            if (yacheiki[5] == true)
            {
                korm = korm + 1;
                Label_6.Background = lab2_2.Background;
                hidden_yacheiki();
                yacheiki_false();
            }
            if (yacheiki[6] == true)
            {
                korm = korm + 1;
                Label_7.Background = lab2_2.Background;
                hidden_yacheiki();
                yacheiki_false();
            }
            if (yacheiki[7] == true)
            {
                korm = korm + 1;
                Label_8.Background = lab2_2.Background;
                hidden_yacheiki();
                yacheiki_false();
            }
            if (yacheiki[8] == true)
            {
                korm = korm + 1;
                Label_9.Background = lab2_2.Background;
                hidden_yacheiki();
                yacheiki_false();
            }
            if (yacheiki[9] == true)
            {
                korm = korm + 1;
                Label_10.Background = lab2_2.Background;
                hidden_yacheiki();
                yacheiki_false();
            }
            if (yacheiki[10] == true)
            {
                korm = korm + 1;
                Label_11.Background = lab2_2.Background;
                hidden_yacheiki();
                yacheiki_false();
            }
            if (yacheiki[11] == true)
            {
                korm = korm + 1;
                Label_12.Background = lab2_2.Background;
                hidden_yacheiki();
                yacheika1 = false;
                yacheiki_false();
            }
            if (yacheiki[12] == true)
            {
                korm = korm + 1;
                Label_13.Background = lab2_2.Background;
                hidden_yacheiki();
                yacheiki_false();
            }
            if (yacheiki[13] == true)
            {
                korm = korm + 1;
                Label_14.Background = lab2_2.Background;
                hidden_yacheiki();
                yacheiki_false();
            }
            if (yacheiki[14] == true)
            {
                korm = korm + 1;
                Label_15.Background = lab2_2.Background;
                hidden_yacheiki();
                yacheiki_false();
            }
            if (yacheiki[15] == true)
            {
                korm = korm + 1;
                Label_16.Background = lab2_2.Background;
                hidden_yacheiki();
                yacheiki_false();
            }

            ramki = shuh8_prom * 8 + shuh10_prom * 10 + dno + kr;
            shuh_uz = kr + dno;
            shuh_sh = shuh10_prom + shuh8_prom;
            lab10_10.Text = "ramki= " + ramki + "; шухлятки узкие= " + shuh_uz + "; шухлятки широкие = " + shuh_sh;
        }
        private void lab3_3_MouseDoubleClick(object sender, MouseButtonEventArgs e)//dno
        {
    

            if (yacheiki[0] == true)
            {
                dno = dno + 1;
                Label_1.Background = lab3_3.Background;
                hidden_yacheiki();
                yacheiki_false();
            }
            if (yacheiki[1] == true)
            {
                dno = dno + 1;
                Label_2.Background = lab3_3.Background;
                hidden_yacheiki();
                yacheiki_false();
            }
            if (yacheiki[2] == true)
            {
                dno = dno + 1;
                Label_3.Background = lab3_3.Background;
                hidden_yacheiki();
                yacheiki_false();
            }
            if (yacheiki[3] == true)
            {
                dno = dno + 1;
                Label_4.Background = lab3_3.Background;
                hidden_yacheiki();
                yacheiki_false();
            }
            if (yacheiki[4] == true)
            {
                dno = dno + 1;
                Label_5.Background = lab3_3.Background;
                hidden_yacheiki();
                yacheiki_false();
            }
            if (yacheiki[5] == true)
            {
                dno = dno + 1;
                Label_6.Background = lab3_3.Background;
                hidden_yacheiki();
                yacheiki_false();
            }
            if (yacheiki[6] == true)
            {
                dno = dno + 1;
                Label_7.Background = lab3_3.Background;
                hidden_yacheiki();
                yacheiki_false();
            }
            if (yacheiki[7] == true)
            {
                dno = dno + 1;
                Label_8.Background = lab3_3.Background;
                hidden_yacheiki();
                yacheiki_false();
            }
            if (yacheiki[8] == true)
            {
                dno = dno + 1;
                Label_9.Background = lab3_3.Background;
                hidden_yacheiki();
                yacheiki_false();
            }
            if (yacheiki[9] == true)
            {
                dno = dno + 1;
                Label_10.Background = lab3_3.Background;
                hidden_yacheiki();
                yacheiki_false();
            }
            if (yacheiki[10] == true)
            {
                dno = dno + 1;
                Label_11.Background = lab3_3.Background;
                hidden_yacheiki();
                yacheiki_false();
            }
            if (yacheiki[11] == true)
            {
                dno = dno + 1;
                Label_12.Background = lab3_3.Background;
                hidden_yacheiki();
                yacheiki_false();
            }
            if (yacheiki[12] == true)
            {
                dno = dno + 1;
                Label_13.Background = lab3_3.Background;
                hidden_yacheiki();
                yacheiki_false();
            }
            if (yacheiki[13] == true)
            {
                dno = dno + 1;
                Label_14.Background = lab3_3.Background;
                hidden_yacheiki();
                yacheiki_false();
            }
            if (yacheiki[14] == true)
            {
                dno = dno + 1;
                Label_15.Background = lab3_3.Background;
                hidden_yacheiki();
                yacheiki_false();
            }
            if (yacheiki[15] == true)
            {
                dno = dno + 1;
                Label_16.Background = lab3_3.Background;
                hidden_yacheiki();
                yacheiki_false();
            }
            ramki = shuh8_prom * 8 + shuh10_prom * 10 + dno + kr;
            shuh_uz = kr + dno;
            shuh_sh = shuh10_prom + shuh8_prom;
            lab10_10.Text = "ramki= " + ramki + "; шухлятки узкие= " + shuh_uz + "; шухлятки широкие = " + shuh_sh;
        }
        private void lab4_4_MouseDoubleClick(object sender, MouseButtonEventArgs e)//шухлятки 8 рамок
        {
            shuh8_prom = shuh8_prom + 1;

            if (yacheiki[0] == true)
            {
                Label_1.Background = lab4_4.Background;
                Label_2.Background = lab4_4.Background;
                hidden_yacheiki();
                yacheiki_false();
            }
            if (yacheiki[1] == true)
            {
                Label_2.Background = lab4_4.Background;
                Label_3.Background = lab4_4.Background;
                hidden_yacheiki();
                yacheiki_false();
            }
            if (yacheiki[2] == true)
            {
                Label_3.Background = lab4_4.Background;
                Label_4.Background = lab4_4.Background;
                hidden_yacheiki();
                yacheiki_false();
            }
            if (yacheiki[3] == true)
            {
                Label_4.Background = lab4_4.Background;
                Label_5.Background = lab4_4.Background;
                hidden_yacheiki();
                yacheiki_false();
            }
            if (yacheiki[4] == true)
            {
                Label_5.Background = lab4_4.Background; Label_6.Background = lab4_4.Background;
                hidden_yacheiki();
                yacheiki_false();
            }
            if (yacheiki[5] == true)
            {
                Label_6.Background = lab4_4.Background; Label_7.Background = lab4_4.Background;
                hidden_yacheiki();
                yacheiki_false();
            }
            if (yacheiki[6] == true)
            {
                Label_7.Background = lab4_4.Background; Label_8.Background = lab4_4.Background;
                hidden_yacheiki();
                yacheiki_false();
            }
            if (yacheiki[7] == true)
            {
                Label_8.Background = lab4_4.Background; Label_9.Background = lab4_4.Background;
                hidden_yacheiki();
                yacheiki_false();
            }
            if (yacheiki[8] == true)
            {
                Label_9.Background = lab4_4.Background; Label_10.Background = lab4_4.Background;
                hidden_yacheiki();
                yacheiki_false();
            }
            if (yacheiki[9] == true)
            {
                Label_10.Background = lab4_4.Background; Label_11.Background = lab4_4.Background;
                hidden_yacheiki();
                yacheiki_false();
            }
            if (yacheiki[10] == true)
            {
                Label_11.Background = lab4_4.Background; Label_12.Background = lab4_4.Background;
                hidden_yacheiki();
                yacheiki_false();
            }
            if (yacheiki[11] == true)
            {
                Label_12.Background = lab4_4.Background; Label_13.Background = lab4_4.Background;
                hidden_yacheiki();
                yacheiki_false();
            }
            if (yacheiki[12] == true)
            {
                Label_13.Background = lab4_4.Background; Label_14.Background = lab4_4.Background;
                hidden_yacheiki();
                yacheiki_false();
            }
            if (yacheiki[13] == true)
            {
                Label_14.Background = lab4_4.Background; Label_15.Background = lab4_4.Background;
                hidden_yacheiki();
                yacheiki_false();
            }
            if (yacheiki[14] == true)
            {
                Label_15.Background = lab4_4.Background; Label_16.Background = lab4_4.Background;
                hidden_yacheiki();
                yacheiki_false();
            }
            if (yacheiki[15] == true)
            {
                lab11_11.Visibility = Visibility.Visible;
                lab11_11.Text = "Ошибка, Широкие шухлятки должны занимать 2 ячейки";
            }
            ramki = shuh8_prom * 8 + shuh10_prom * 10 + dno + kr;
            shuh_uz = kr + dno;
            shuh_sh = shuh10_prom + shuh8_prom;
            lab10_10.Text = "ramki= " + ramki + "; шухлятки узкие= " + shuh_uz + "; шухлятки широкие = " + shuh_sh;
        }
        private void lab5_5_MouseDoubleClick(object sender, MouseButtonEventArgs e)// шухлятки 10 рамок
        {
            shuh10_prom = shuh10_prom + 1;

            if (yacheiki[0] == true)
            {
                Label_1.Background = lab5_5.Background; Label_2.Background = lab5_5.Background;
                hidden_yacheiki();
                yacheiki_false();

            }
            if (yacheiki[1] == true)
            {
                Label_2.Background = lab5_5.Background; Label_3.Background = lab5_5.Background;
                hidden_yacheiki();
                yacheiki_false();
            }
            if (yacheiki[2] == true)
            {
                Label_3.Background = lab5_5.Background; Label_4.Background = lab5_5.Background;
                hidden_yacheiki();
                yacheiki_false();
            }
            if (yacheiki[3] == true)
            {
                Label_4.Background = lab5_5.Background; Label_5.Background = lab5_5.Background;
                hidden_yacheiki();
                yacheiki_false();
            }
            if (yacheiki[4] == true)
            {
                Label_5.Background = lab5_5.Background; Label_6.Background = lab5_5.Background;
                hidden_yacheiki();
                yacheiki_false();
            }
            if (yacheiki[5] == true)
            {
                Label_6.Background = lab5_5.Background; Label_7.Background = lab5_5.Background;
                hidden_yacheiki();
                yacheiki_false();
            }
            if (yacheiki[6] == true)
            {
                Label_7.Background = lab5_5.Background; Label_8.Background = lab5_5.Background;
                hidden_yacheiki();
                yacheiki_false();
            }
            if (yacheiki[7] == true)
            {
                Label_8.Background = lab5_5.Background; Label_9.Background = lab5_5.Background;
                hidden_yacheiki();
                yacheiki_false();
            }
            if (yacheiki[8] == true)
            {
                Label_9.Background = lab5_5.Background; Label_10.Background = lab5_5.Background;
                hidden_yacheiki();
                yacheiki_false();
            }
            if (yacheiki[9] == true)
            {
                Label_10.Background = lab5_5.Background; Label_11.Background = lab5_5.Background;
                hidden_yacheiki();
                yacheiki_false();
            }
            if (yacheiki[10] == true)
            {
                Label_11.Background = lab5_5.Background; Label_12.Background = lab5_5.Background;
                hidden_yacheiki();
                yacheiki_false();
            }
            if (yacheiki[11] == true)
            {
                Label_12.Background = lab5_5.Background; Label_13.Background = lab5_5.Background;
                hidden_yacheiki();
                yacheiki_false();
            }
            if (yacheiki[12] == true)
            {
                Label_13.Background = lab5_5.Background; Label_14.Background = lab5_5.Background;
                hidden_yacheiki();
                yacheiki_false();
            }
            if (yacheiki[13] == true)
            {
                Label_14.Background = lab5_5.Background; Label_15.Background = lab5_5.Background;
                hidden_yacheiki();
                yacheiki_false();
            }
            if (yacheiki[14] == true)
            {
                Label_15.Background = lab5_5.Background; Label_16.Background = lab5_5.Background;
                hidden_yacheiki();
                yacheiki_false();
            }
            if (yacheiki[15] == true)
            {
                lab11_11.Visibility = Visibility.Visible;
                lab11_11.Text = "Ошибка, Широкие шухлятки должны занимать 2 ячейки";
            }
            ramki = shuh8_prom * 8 + shuh10_prom * 10 + dno + kr;
            shuh_uz = kr + dno;
            shuh_sh = shuh10_prom + shuh8_prom;
            lab10_10.Text = "ramki= " + ramki + "; шухлятки узкие= " + shuh_uz + "; шухлятки широкие = " + shuh_sh;
        }
        private void lab_condi_color_MouseDoubleClick(object sender, MouseButtonEventArgs e)//кондиционер
        {
         

            if (yacheiki[0] == true)
            {
                condi = condi + 1;
                Label_1.Background = lab_condi_color.Background;
                hidden_yacheiki();
                yacheiki_false();
            }
            if (yacheiki[1] == true)
            {
                condi = condi + 1;
                Label_2.Background = lab_condi_color.Background;
                hidden_yacheiki();
                yacheiki_false();
            }
            if (yacheiki[2] == true)
            {
                condi = condi + 1;
                Label_3.Background = lab_condi_color.Background;
                hidden_yacheiki();
                yacheiki_false();
            }
            if (yacheiki[3] == true)
            {
                condi = condi + 1;
                Label_4.Background = lab_condi_color.Background;
                hidden_yacheiki();
                yacheiki_false();
            }
            if (yacheiki[4] == true)
            {
                condi = condi + 1;
                Label_5.Background = lab_condi_color.Background;
                hidden_yacheiki();
                yacheiki_false();
            }
            if (yacheiki[5] == true)
            {
                condi = condi + 1;
                Label_6.Background = lab_condi_color.Background;
                hidden_yacheiki();
                yacheiki_false();
            }
            if (yacheiki[6] == true)
            {
                condi = condi + 1;
                Label_7.Background = lab_condi_color.Background;
                hidden_yacheiki();
                yacheiki_false();
            }
            if (yacheiki[7] == true)
            {
                condi = condi + 1;
                Label_8.Background = lab_condi_color.Background;
                hidden_yacheiki();
                yacheiki_false();
            }
            if (yacheiki[8] == true)
            {
                condi = condi + 1;
                Label_9.Background = lab_condi_color.Background;
                hidden_yacheiki();
                yacheiki_false();
            }
            if (yacheiki[9] == true)
            {
                condi = condi + 1;
                Label_10.Background = lab_condi_color.Background;
                hidden_yacheiki();
                yacheiki_false();
            }
            if (yacheiki[10] == true)
            {
                condi = condi + 1;
                Label_11.Background = lab2_2.Background;
                hidden_yacheiki();
                yacheiki_false();
            }
            if (yacheiki[11] == true)
            {
                condi = condi + 1;
                Label_12.Background = lab2_2.Background;
                hidden_yacheiki();
                yacheika1 = false;
                yacheiki_false();
            }
            if (yacheiki[12] == true)
            {
                condi = condi + 1;
                Label_13.Background = lab2_2.Background;
                hidden_yacheiki();
                yacheiki_false();
            }
            if (yacheiki[13] == true)
            {
                condi = condi + 1;
                Label_14.Background = lab2_2.Background;
                hidden_yacheiki();
                yacheiki_false();
            }
            if (yacheiki[14] == true)
            {
                condi = condi + 1;
                Label_15.Background = lab2_2.Background;
                hidden_yacheiki();
                yacheiki_false();
            }
            if (yacheiki[15] == true)
            {
                condi = condi + 1;
                Label_16.Background = lab2_2.Background;
                hidden_yacheiki();
                yacheiki_false();
            }
            ramki = shuh8_prom * 8 + shuh10_prom * 10 + dno + kr;
            shuh_uz = kr + dno;
            shuh_sh = shuh10_prom + shuh8_prom;
            lab10_10.Text = "ramki= " + ramki + "; шухлятки узкие= " + shuh_uz + "; шухлятки широкие = " + shuh_sh;
        }


        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {


        }



        private void lab6_6_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

        }

        private void attention_Checked(object sender, RoutedEventArgs e)
        {
            if (attention.IsChecked == true)
            {
                attention_if = 1;
                att_border.Visibility = Visibility.Visible;
            }

        }


        private void lab7_7_TextChanged(object sender, TextChangedEventArgs e) //дата следующего осмотра
        {
            nd = true;
            next_date = lab7_7.Text;

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void attention_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {


        }

        private void Print_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void lab10_1_Click(object sender, RoutedEventArgs e)//рамки
        {


        }
        private void lab9_9_TextChanged(object sender, TextChangedEventArgs e)//rasplod
        {
            r = true;
            ras = lab9_9.Text;
        }

        private void lab8_8_TextChanged(object sender, TextChangedEventArgs e)//family
        {
            f = true;
            fam = lab8_8.Text;
        }
        private void lab6_6_TextChanged_1(object sender, TextChangedEventArgs e) //дата последнего осмотра
        {

            last_date = lab6_6.Text;
            ld = true;
        }

        private void lab6_6_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void comment_TextChanged(object sender, TextChangedEventArgs e)
        {
            comm = comment.Text;
        }


  
        private void textbox_TextChanged(object sender, TextChangedEventArgs e) //id по улиям
        {
            uznat_id();
            clean();
            // connect_id(id);
            connect_kr(id);
            connect_korm(id);
            connect_dno(id);
            connect_sh8r(id);
            connect_sh10r(id);
            connect_cond(id);
            connect_attention(id);
            label_info(id);
            show();
            allert.Visibility = Visibility.Hidden;
           
        }


        private void uznat_id()
        {
            String id_text = textbox.Text;
            if (id_text != "")
            {
                id = Convert.ToInt32(id_text);
            }
            else { clean(); }
           
        }

       private void select_Click(object sender, RoutedEventArgs e)
       {
            att_border.Visibility = Visibility.Hidden;
           clean();
            uznat_id();
           shuh8 = 0; shuh10 = 0; ramki=0; shuh8_prom = 0; shuh10_prom = 0; shuh_uz = 0; shuh_sh = 0; dno = 0; korm = 0;kr = 0; condi = 0;
            lab6_6.Text = "";
            lab7_7.Text = "";
            lab8_8.Text = "";
            lab9_9.Text = "";
            comment.Text = "";
            clean_bd(id);
            attention_if = 0;
        }
     
        private void number_u_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }


        private void lab10_10_MouseMove(object sender, MouseEventArgs e)
        {

        }
        public void done_bd()
        {
            lab10_10.Text = "";
            ramki = 0; korm = 0; kr = 0; shuh8 = 0; shuh10 = 0;dno = 0;


        }
        private  void clean_bd(int id)
        {
            ld = true;
            nd = true;
            f = true;
            r = true;
            string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
            MySqlConnection conn = new MySqlConnection(connectString);
            conn.Open();
            string q1 = "Update work_1 Set last_date ='',next_date = '',family = '', ramki= 0, krishki = 0, dno = 0, korm = 0, condi = 0, attention = 0, rasplod = '', sh_uz= 0,  sh_sh = 0,sh_8_r= 0, sh_10_r= 0 where id = " + id; 
             MySqlCommand command = new MySqlCommand(q1, conn);
            command.ExecuteNonQuery();
        }
        private void Button1_Click(object sender, RoutedEventArgs e) //обновить бд
        {
            allert.Visibility = Visibility.Visible;
            if (ld == true)
            {
                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q1 = "Update work_1 Set last_date = '" + last_date + "' where id = " + id;
                 MySqlCommand command = new MySqlCommand(q1, conn);
                command.ExecuteNonQuery();

            }
            if (nd == true)
            {
                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q7 = "Update work_1 Set next_date = '" + next_date + "' where id = " + id;
                 MySqlCommand command = new MySqlCommand(q7, conn);
                command.ExecuteNonQuery();

            }
            if (f == true)
            {
                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q8 = "Update work_1 Set family = '" + fam + "' where id = " + id;
                 MySqlCommand command = new MySqlCommand(q8, conn);
                command.ExecuteNonQuery();

            }
            if (r == true)
            {
                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q9 = "Update work_1 Set rasplod = '" + ras + "' where id = " + id;
                 MySqlCommand command = new MySqlCommand(q9, conn);
                command.ExecuteNonQuery();

            }

            if (Label_1.Background == lab1_1.Background)
            {

                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q2 = "Update work_1 Set krishki =" + kr + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q2, conn);
                command.ExecuteNonQuery();


            }
            if (Label_1.Background == lab2_2.Background)
            {

                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q3 = "Update work_1 Set korm =" + korm + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q3, conn);
                command.ExecuteNonQuery();


            }
            if (Label_1.Background == lab3_3.Background)
            {

                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q4 = "Update work_1 Set dno =" + dno + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q4, conn);
                command.ExecuteNonQuery();
            }
            if (Label_1.Background == lab4_4.Background)
            {
                shuh8 = shuh8_prom;
                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q5 = "Update work_1 Set sh_8_r =" + shuh8 + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q5, conn);
                command.ExecuteNonQuery();
            }
            if (Label_1.Background == lab5_5.Background)
            {
                shuh10 = shuh10_prom;
                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q6 = "Update work_1 Set sh_10_r =" + shuh10 + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q6, conn);
                command.ExecuteNonQuery();
            }
            if (Label_1.Background == lab_condi_color.Background)
            {
              
                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q6 = "Update work_1 Set condi =" + condi + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q6, conn);
                command.ExecuteNonQuery();
            }
            if (Label_2.Background == lab1_1.Background)// вторая ячейка krishki
            {

                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q13 = "Update work_1 Set krishki =" + kr + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q13, conn);
                command.ExecuteNonQuery();
            }
            if (Label_2.Background == lab2_2.Background)
            {

                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q14 = "Update work_1 Set korm =" + korm + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q14, conn);
                command.ExecuteNonQuery();


            }
            if (Label_2.Background == lab3_3.Background)
            {

                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q15 = "Update work_1 Set dno =" + dno + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q15, conn);
                command.ExecuteNonQuery();
            }
            if (Label_2.Background == lab4_4.Background)
            {
                shuh8 = shuh8_prom;
                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q16 = "Update work_1 Set sh_8_r =" + shuh8 + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q16, conn);
                command.ExecuteNonQuery();
            }
            if (Label_2.Background == lab5_5.Background)
            {
                shuh10 = shuh10_prom;
                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q17 = "Update work_1 Set sh_10_r =" + shuh10 + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q17, conn);
                command.ExecuteNonQuery();

            }
            if (Label_2.Background == lab_condi_color.Background)
            {

                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q6 = "Update work_1 Set condi =" + condi + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q6, conn);
                command.ExecuteNonQuery();
            }
            if (Label_3.Background == lab1_1.Background)
            {

                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q18 = "Update work_1 Set krishki =" + kr + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q18, conn);
                command.ExecuteNonQuery();


            }
            if (Label_3.Background == lab2_2.Background)
            {

                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q19 = "Update work_1 Set korm =" + korm + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q19, conn);
                command.ExecuteNonQuery();


            }
            if (Label_3.Background == lab3_3.Background)
            {

                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q20 = "Update work_1 Set dno =" + dno + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q20, conn);
                command.ExecuteNonQuery();
            }
            if (Label_3.Background == lab4_4.Background)
            {
                shuh8 = shuh8_prom;
                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q21 = "Update work_1 Set sh_8_r =" + shuh8 + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q21, conn);
                command.ExecuteNonQuery();
            }
            if (Label_3.Background == lab5_5.Background)
            {
                shuh10 = shuh10_prom;
                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q22 = "Update work_1 Set sh_10_r =" + shuh10 + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q22, conn);
                command.ExecuteNonQuery();
            }
            if (Label_3.Background == lab_condi_color.Background)
            {

                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q6 = "Update work_1 Set condi =" + condi + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q6, conn);
                command.ExecuteNonQuery();
            }
            if (Label_4.Background == lab1_1.Background)
            {

                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q23 = "Update work_1 Set krishki =" + kr + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q23, conn);
                command.ExecuteNonQuery();


            }
            if (Label_4.Background == lab2_2.Background)
            {

                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q24 = "Update work_1 Set korm =" + korm + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q24, conn);
                command.ExecuteNonQuery();
            }
            if (Label_4.Background == lab3_3.Background)
            {

                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q25 = "Update work_1 Set dno =" + dno + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q25, conn);
                command.ExecuteNonQuery();
            }
            if (Label_4.Background == lab4_4.Background)
            {
                shuh8 = shuh8_prom;
                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q26 = "Update work_1 Set sh_8_r =" + shuh8 + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q26, conn);
                command.ExecuteNonQuery();
            }
            if (Label_4.Background == lab5_5.Background)
            {
                shuh10 = shuh10_prom;
                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q27 = "Update work_1 Set sh_10_r =" + shuh10 + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q27, conn);
                command.ExecuteNonQuery();
            }
            if (Label_4.Background == lab_condi_color.Background)
            {

                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q6 = "Update work_1 Set condi =" + condi + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q6, conn);
                command.ExecuteNonQuery();
            }
            if (Label_5.Background == lab1_1.Background)
            {


                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q28 = "Update work_1 Set krishki =" + kr + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q28, conn);
                command.ExecuteNonQuery();


            }
            if (Label_5.Background == lab2_2.Background)
            {

                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q29 = "Update work_1 Set korm =" + korm + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q29, conn);
                command.ExecuteNonQuery();

            }
            if (Label_5.Background == lab3_3.Background)
            {
                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q30 = "Update work_1 Set dno =" + dno + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q30, conn);
                command.ExecuteNonQuery();
            }
            if (Label_5.Background == lab4_4.Background)
            {
                shuh8 = shuh8_prom;
                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q30 = "Update work_1 Set sh_8_r =" + shuh8 + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q30, conn);
                command.ExecuteNonQuery();
            }
            if (Label_5.Background == lab5_5.Background)
            {
                shuh10 = shuh10_prom;
                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q31 = "Update work_1 Set sh_10_r =" + shuh10 + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q31, conn);
                command.ExecuteNonQuery();
            }
            if (Label_5.Background == lab_condi_color.Background)
            {

                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q6 = "Update work_1 Set condi =" + condi + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q6, conn);
                command.ExecuteNonQuery();
            }
            if (Label_6.Background == lab1_1.Background)
            {

                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q32 = "Update work_1 Set krishki =" + kr + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q32, conn);
                command.ExecuteNonQuery();


            }
            if (Label_6.Background == lab2_2.Background)
            {

                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q33 = "Update work_1 Set korm =" + korm + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q33, conn);
                command.ExecuteNonQuery();


            }
            if (Label_6.Background == lab3_3.Background)
            {

                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q34 = "Update work_1 Set dno =" + dno + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q34, conn);
                command.ExecuteNonQuery();
            }
            if (Label_6.Background == lab4_4.Background)
            {
                shuh8 = shuh8_prom;
                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q35 = "Update work_1 Set sh_8_r =" + shuh8 + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q35, conn);
                command.ExecuteNonQuery();
            }
            if (Label_6.Background == lab5_5.Background)
            {
                shuh10 = shuh10_prom;
                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q36 = "Update work_1 Set sh_10_r =" + shuh10 + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q36, conn);
                command.ExecuteNonQuery();
            }
            if (Label_6.Background == lab_condi_color.Background)
            {

                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q6 = "Update work_1 Set condi =" + condi + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q6, conn);
                command.ExecuteNonQuery();
            }
            if (Label_7.Background == lab1_1.Background)
            {

                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q37 = "Update work_1 Set krishki =" + kr + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q37, conn);
                command.ExecuteNonQuery();


            }
            if (Label_7.Background == lab2_2.Background)
            {

                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q38 = "Update work_1 Set korm =" + korm + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q38, conn);
                command.ExecuteNonQuery();

            }
            if (Label_7.Background == lab3_3.Background)
            {

                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q39 = "Update work_1 Set dno =" + dno + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q39, conn);
                command.ExecuteNonQuery();

            }
            if (Label_7.Background == lab4_4.Background)
            {
                shuh8 = shuh8_prom;
                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q40 = "Update work_1 Set sh_8_r =" + shuh8 + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q40, conn);
                command.ExecuteNonQuery();
            }
            if (Label_7.Background == lab5_5.Background)
            {
                shuh10 = shuh10 = shuh10_prom;
                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q41 = "Update work_1 Set sh_10_r =" + shuh10 + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q41, conn);
                command.ExecuteNonQuery();
            }
            if (Label_7.Background == lab_condi_color.Background)
            {

                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q6 = "Update work_1 Set condi =" + condi + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q6, conn);
                command.ExecuteNonQuery();
            }
            if (Label_8.Background == lab1_1.Background)
            {

                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q42 = "Update work_1 Set krishki =" + kr + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q42, conn);
                command.ExecuteNonQuery();


            }
            if (Label_8.Background == lab2_2.Background)
            {

                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q43 = "Update work_1 Set korm =" + korm + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q43, conn);
                command.ExecuteNonQuery();


            }
            if (Label_8.Background == lab3_3.Background)
            {

                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q44 = "Update work_1 Set dno =" + dno + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q44, conn);
                command.ExecuteNonQuery();

            }
            if (Label_8.Background == lab4_4.Background)
            {
                shuh8 = shuh8_prom;
                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q45 = "Update work_1 Set sh_8_r =" + shuh8 + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q45, conn);
                command.ExecuteNonQuery();

            }
            if (Label_8.Background == lab5_5.Background)
            {
                shuh10 = shuh10_prom;
                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q46 = "Update work_1 Set sh_10_r =" + shuh10 + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q46, conn);
                command.ExecuteNonQuery();

            }
            if (Label_8.Background == lab_condi_color.Background)
            {

                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q6 = "Update work_1 Set condi =" + condi + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q6, conn);
                command.ExecuteNonQuery();
            }
            if (Label_9.Background == lab1_1.Background)
            {

                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q47 = "Update work_1 Set krishki =" + kr + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q47, conn);
                command.ExecuteNonQuery();


            }
            if (Label_9.Background == lab2_2.Background)
            {

                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q48 = "Update work_1 Set korm =" + korm + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q48, conn);
                command.ExecuteNonQuery();


            }
            if (Label_9.Background == lab3_3.Background)
            {

                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q49 = "Update work_1 Set dno =" + dno + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q49, conn);
                command.ExecuteNonQuery();

            }
            if (Label_9.Background == lab4_4.Background)
            {
                shuh8 = shuh8_prom;
                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q50 = "Update work_1 Set sh_8_r =" + shuh8 + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q50, conn);
                command.ExecuteNonQuery();

            }
            if (Label_9.Background == lab5_5.Background)
            {
                shuh10 = shuh10_prom;
                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q51 = "Update work_1 Set sh_10_r =" + shuh10 + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q51, conn);
                command.ExecuteNonQuery();

            }
            if (Label_9.Background == lab_condi_color.Background)
            {

                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q6 = "Update work_1 Set condi =" + condi + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q6, conn);
                command.ExecuteNonQuery();
            }
            if (Label_10.Background == lab1_1.Background)
            {

                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q52 = "Update work_1 Set krishki =" + kr + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q52, conn);
                command.ExecuteNonQuery();


            }
            if (Label_10.Background == lab2_2.Background)
            {

                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q53 = "Update work_1 Set korm =" + korm + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q53, conn);
                command.ExecuteNonQuery();


            }
            if (Label_10.Background == lab3_3.Background)
            {

                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q54 = "Update work_1 Set dno =" + dno + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q54, conn);
                command.ExecuteNonQuery();

            }
            if (Label_10.Background == lab4_4.Background)
            {
                shuh8 = shuh8_prom;
                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q55 = "Update work_1 Set sh_8_r =" + shuh8 + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q55, conn);
                command.ExecuteNonQuery();

            }
            if (Label_10.Background == lab5_5.Background)
            {
                shuh10 = shuh10_prom;
                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q56 = "Update work_1 Set sh_10_r =" + shuh10 + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q56, conn);
                command.ExecuteNonQuery();

            }
            if (Label_10.Background == lab_condi_color.Background)
            {

                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q6 = "Update work_1 Set condi =" + condi + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q6, conn);
                command.ExecuteNonQuery();
            }
            if (Label_11.Background == lab1_1.Background)
            {

                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q57 = "Update work_1 Set krishki =" + kr + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q57, conn);
                command.ExecuteNonQuery();


            }
            if (Label_11.Background == lab2_2.Background)
            {

                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q58 = "Update work_1 Set korm =" + korm + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q58, conn);
                command.ExecuteNonQuery();


            }
            if (Label_11.Background == lab3_3.Background)
            {

                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q59 = "Update work_1 Set dno =" + dno + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q59, conn);
                command.ExecuteNonQuery();

            }
            if (Label_11.Background == lab4_4.Background)
            {
                shuh8 = shuh8_prom;
                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q60 = "Update work_1 Set sh_8_r =" + shuh8 + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q60, conn);
                command.ExecuteNonQuery();
            }
            if (Label_11.Background == lab5_5.Background)
            {
                shuh10 = shuh10_prom;
                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q61 = "Update work_1 Set sh_10_r =" + shuh10 + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q61, conn);
                command.ExecuteNonQuery();
            }
            if (Label_11.Background == lab_condi_color.Background)
            {

                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q6 = "Update work_1 Set condi =" + condi + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q6, conn);
                command.ExecuteNonQuery();
            }
            if (Label_12.Background == lab1_1.Background)
            {

                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q62 = "Update work_1 Set krishki =" + kr + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q62, conn);
                command.ExecuteNonQuery();


            }
            if (Label_12.Background == lab2_2.Background)
            {

                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q63 = "Update work_1 Set korm =" + korm + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q63, conn);
                command.ExecuteNonQuery();


            }
            if (Label_12.Background == lab3_3.Background)
            {

                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q64 = "Update work_1 Set dno =" + dno + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q64, conn);
                command.ExecuteNonQuery();

            }
            if (Label_12.Background == lab4_4.Background)
            {
                shuh8 = shuh8_prom;
                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q65 = "Update work_1 Set sh_8_r =" + shuh8 + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q65, conn);
                command.ExecuteNonQuery();
            }
            if (Label_12.Background == lab5_5.Background)
            {
                shuh10 = shuh10_prom;
                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q66 = "Update work_1 Set sh_10_r =" + shuh10 + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q66, conn);
                command.ExecuteNonQuery();
            }
            if (Label_12.Background == lab_condi_color.Background)
            {

                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q6 = "Update work_1 Set condi =" + condi + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q6, conn);
                command.ExecuteNonQuery();
            }
            if (Label_13.Background == lab1_1.Background)
            {

                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q67 = "Update work_1 Set krishki =" + kr + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q67, conn);
                command.ExecuteNonQuery();


            }
            if (Label_13.Background == lab2_2.Background)
            {
                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q68 = "Update work_1 Set korm =" + korm + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q68, conn);
                command.ExecuteNonQuery();
            }
            if (Label_13.Background == lab3_3.Background)
            {
                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q69 = "Update work_1 Set dno =" + dno + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q69, conn);
                command.ExecuteNonQuery();
            }
            if (Label_13.Background == lab4_4.Background)
            {
                shuh8 = shuh8_prom;
                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q70 = "Update work_1 Set sh_8_r =" + shuh8 + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q70, conn);
                command.ExecuteNonQuery();
            }
            if (Label_13.Background == lab5_5.Background)
            {
                shuh10 = shuh10_prom;
                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q71 = "Update work_1 Set sh_10_r =" + shuh10 + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q71, conn);
                command.ExecuteNonQuery();
            }
            if (Label_13.Background == lab_condi_color.Background)
            {

                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q6 = "Update work_1 Set condi =" + condi + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q6, conn);
                command.ExecuteNonQuery();
            }
            if (Label_14.Background == lab1_1.Background)
            {
                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q72 = "Update work_1 Set krishki =" + kr + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q72, conn);
                command.ExecuteNonQuery();
            }
            if (Label_14.Background == lab2_2.Background)
            {
                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q73 = "Update work_1 Set korm =" + korm + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q73, conn);
                command.ExecuteNonQuery();
            }
            if (Label_14.Background == lab3_3.Background)
            {
                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q74 = "Update work_1 Set dno =" + dno + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q74, conn);
                command.ExecuteNonQuery();
            }
            if (Label_14.Background == lab4_4.Background)
            {
                shuh8 = shuh8_prom;
                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q75 = "Update work_1 Set sh_8_r =" + shuh8 + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q75, conn);
                command.ExecuteNonQuery();
            }
            if (Label_14.Background == lab5_5.Background)
            {
                shuh10 = shuh10_prom;
                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q76 = "Update work_1 Set sh_10_r =" + shuh10 + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q76, conn);
                command.ExecuteNonQuery();
            }
            if (Label_14.Background == lab_condi_color.Background)
            {

                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q6 = "Update work_1 Set condi =" + condi + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q6, conn);
                command.ExecuteNonQuery();
            }
            if (Label_15.Background == lab1_1.Background)
            {
                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q77 = "Update work_1 Set krishki =" + kr + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q77, conn);
                command.ExecuteNonQuery();


            }
            if (Label_15.Background == lab2_2.Background)
            {
                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q78 = "Update work_1 Set korm =" + korm + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q78, conn);
                command.ExecuteNonQuery();


            }
            if (Label_15.Background == lab3_3.Background)
            {
                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q79 = "Update work_1 Set dno =" + dno + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q79, conn);
                command.ExecuteNonQuery();
            }
            if (Label_15.Background == lab4_4.Background)
            {
                shuh8 = shuh8_prom;
                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q80 = "Update work_1 Set sh_8_r =" + shuh8 + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q80, conn);
                command.ExecuteNonQuery();
            }
            if (Label_15.Background == lab5_5.Background)
            {
                shuh10 = shuh10_prom;
                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q81 = "Update work_1 Set sh_10_r =" + shuh10 + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q81, conn);
                command.ExecuteNonQuery();
            }
            if (Label_15.Background == lab_condi_color.Background)
            {

                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q6 = "Update work_1 Set condi =" + condi + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q6, conn);
                command.ExecuteNonQuery();
            }
            if (Label_16.Background == lab1_1.Background)
            {
                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q82 = "Update work_1 Set krishki =" + kr + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q82, conn);
                command.ExecuteNonQuery();


            }
            if (Label_16.Background == lab2_2.Background)
            {
                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q83 = "Update work_1 Set korm =" + korm + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q83, conn);
                command.ExecuteNonQuery();


            }
            if (Label_16.Background == lab3_3.Background)
            {
                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q84 = "Update work_1 Set dno =" + dno + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q84, conn);
                command.ExecuteNonQuery();
            }
            if (Label_16.Background == lab4_4.Background)
            {
                shuh8 = shuh8_prom;
                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q85 = "Update work_1 Set sh_8_r =" + shuh8 + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q85, conn);
                command.ExecuteNonQuery();
            }
            if (Label_16.Background == lab5_5.Background)
            {

                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q86 = "Update work_1 Set sh_10_r =" + shuh10 + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q86, conn);
                command.ExecuteNonQuery();
            }
            if (Label_16.Background == lab_condi_color.Background)
            {

                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q6 = "Update work_1 Set condi =" + condi + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q6, conn);
                command.ExecuteNonQuery();
            }
            if (ramkiif == true)
            {
                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q10 = "Update work_1 Set ramki=" + ramki + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q10, conn);
                command.ExecuteNonQuery();
            }
            if (shuh_uzif == true)
            {
                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q11 = "Update work_1 Set sh_uz =" + shuh_uz + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q11, conn);
                command.ExecuteNonQuery();
            }
            if (shuh_shif == true)
            {
                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q12 = "Update work_1 Set sh_sh =" + shuh_sh + " where id=" + id;
                 MySqlCommand command = new MySqlCommand(q12, conn);
                command.ExecuteNonQuery();
            }
            if (nomerif == true)
            
                {
                    String nomer_yacheiki_kr="0";
                    string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                    MySqlConnection conn = new MySqlConnection(connectString);
                    conn.Open();
                    string q87 = "Update work_1 Set nomer_kr ='" + podschet_yacheiki_kr(nomer_yacheiki_kr)+ "' where id=" + id;
                     MySqlCommand command = new MySqlCommand(q87, conn);
                    command.ExecuteNonQuery();
                
            }
            if (nomerif == true)

            {
                String nomer_yacheiki_korm = "0";
                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q88 = "Update work_1 Set nomer_korm ='" + podschet_yacheiki_korm(nomer_yacheiki_korm) + "' where id=" + id;
                 MySqlCommand command = new MySqlCommand(q88, conn);
                command.ExecuteNonQuery();

            }
            if (nomerif == true)

            {
                String nomer_yacheiki_dno = "0";
                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q89 = "Update work_1 Set nomer_dno ='" + podschet_yacheiki_dno(nomer_yacheiki_dno) + "' where id=" + id;
                 MySqlCommand command = new MySqlCommand(q89, conn);
                command.ExecuteNonQuery();

            }
            if (nomerif == true)

            {
                String nomer_yacheiki_sh8r = "0";
                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q90 = "Update work_1 Set nomer_sh_8_r ='" + podschet_yacheiki_sh8r(nomer_yacheiki_sh8r) + "' where id=" + id;
                 MySqlCommand command = new MySqlCommand(q90, conn);
                command.ExecuteNonQuery();

            }
            if (nomerif == true)

            {
                String nomer_yacheiki_sh10r = "0";
                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q91 = "Update work_1 Set nomer_sh_10_r ='" + podschet_yacheiki_sh10r(nomer_yacheiki_sh10r) + "' where id=" + id;
                 MySqlCommand command = new MySqlCommand(q91, conn);
                command.ExecuteNonQuery();

            }
            if (nomerif == true)

            {
                String nomer_yacheiki_condi = "0";
                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q91 = "Update work_1 Set nomer_condi ='" + podschet_condition(nomer_yacheiki_condi) + "' where id=" + id;
                 MySqlCommand command = new MySqlCommand(q91, conn);
                command.ExecuteNonQuery();

            }
            if (nomerif == true)

            {
                
                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q92 = "Update work_1 Set comment ='" + comm + "' where id=" + id;
                 MySqlCommand command = new MySqlCommand(q92, conn);
                command.ExecuteNonQuery();

            }
            if (attention_if == 1)

            {
                if (attention.IsChecked == true)
                    attention_if = 1;
                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q92 = "Update work_1 Set attention ='" + attention_if + "' where id=" + id;
                 MySqlCommand command = new MySqlCommand(q92, conn);
                command.ExecuteNonQuery();

            }
            if (attention_if == 0)

            {
                if (attention.IsChecked == false)
                    attention_if = 0;
                string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
                MySqlConnection conn = new MySqlConnection(connectString);
                conn.Open();
                string q92 = "Update work_1 Set attention = 0 where id=" + id;
                 MySqlCommand command = new MySqlCommand(q92, conn);
                command.ExecuteNonQuery();

            }
            attention_if = 0;

        }
        private string podschet_yacheiki_kr(string nomer_yacheiki)
        {
            nomerif = true;
            if (Label_1.Background == lab1_1.Background)
            {
                nomer_yacheiki = "1";
            }
          
            if (Label_2.Background == lab1_1.Background)
            {
                nomer_yacheiki  = nomer_yacheiki+ ",2";
            }
           
            if (Label_3.Background == lab1_1.Background)
            {
                nomer_yacheiki  = nomer_yacheiki+",3";
            }
            
            if (Label_4.Background == lab1_1.Background)
            {
                nomer_yacheiki  = nomer_yacheiki+",4";
            }
           
            if (Label_5.Background == lab1_1.Background)
            {
               nomer_yacheiki  = nomer_yacheiki+",5";
            }
          
            if (Label_6.Background == lab1_1.Background)
            {
                nomer_yacheiki  = nomer_yacheiki+",6";
            }
            
            if (Label_7.Background == lab1_1.Background)
            {
               nomer_yacheiki  = nomer_yacheiki+",7";
            }
          
            if (Label_8.Background == lab1_1.Background)
            {
               nomer_yacheiki  = nomer_yacheiki+",8";
            }
           
            if (Label_9.Background == lab1_1.Background)
            {
                nomer_yacheiki = nomer_yacheiki+",9";
            }
          
            if (Label_10.Background == lab1_1.Background)
            {
                nomer_yacheiki  = nomer_yacheiki+",10";
            }
         
            if (Label_11.Background == lab1_1.Background)
            {
                nomer_yacheiki  = nomer_yacheiki+",11";
            }
          
            if (Label_12.Background == lab1_1.Background)
            {
               nomer_yacheiki  = nomer_yacheiki+",12";
            }
          
            if (Label_13.Background == lab1_1.Background)
            {
                nomer_yacheiki  = nomer_yacheiki + ",13";
            }
          
            if (Label_14.Background == lab1_1.Background)
            {
                nomer_yacheiki  = nomer_yacheiki + ",14";
            }
           
            if (Label_15.Background == lab1_1.Background)
            {
                nomer_yacheiki  = nomer_yacheiki + ",15";
            }
      
            if (Label_16.Background == lab1.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",16";
            }

            return nomer_yacheiki;
        }
        private string podschet_yacheiki_korm(string nomer_yacheiki)
        {
            nomerif = true;
            if (Label_1.Background == lab2_2.Background)
            {
                nomer_yacheiki = "1";
            }

            if (Label_2.Background == lab2_2.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",2";
            }

            if (Label_3.Background == lab2_2.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",3";
            }

            if (Label_4.Background == lab2_2.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",4";
            }

            if (Label_5.Background == lab2_2.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",5";
            }

            if (Label_6.Background == lab2_2.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",6";
            }

            if (Label_7.Background == lab2_2.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",7";
            }

            if (Label_8.Background == lab2_2.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",8";
            }

            if (Label_9.Background == lab2_2.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",9";
            }

            if (Label_10.Background == lab2_2.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",10";
            }

            if (Label_11.Background == lab2_2.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",11";
            }

            if (Label_12.Background == lab2_2.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",12";
            }

            if (Label_13.Background == lab2_2.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",13";
            }

            if (Label_14.Background == lab2_2.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",14";
            }

            if (Label_15.Background == lab2_2.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",15";
            }

            if (Label_16.Background == lab2_2.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",16";
            }

            return nomer_yacheiki;
        }
        private string podschet_yacheiki_dno(string nomer_yacheiki)
        {
            nomerif = true;
            if (Label_1.Background == lab3_3.Background)
            {
                nomer_yacheiki = "1";
            }

            if (Label_2.Background == lab3_3.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",2";
            }

            if (Label_3.Background == lab3_3.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",3";
            }

            if (Label_4.Background == lab3_3.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",4";
            }

            if (Label_5.Background == lab3_3.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",5";
            }

            if (Label_6.Background == lab3_3.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",6";
            }

            if (Label_7.Background == lab3_3.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",7";
            }

            if (Label_8.Background == lab3_3.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",8";
            }

            if (Label_9.Background == lab3_3.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",9";
            }

            if (Label_10.Background == lab3_3.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",10";
            }

            if (Label_11.Background == lab3_3.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",11";
            }

            if (Label_12.Background == lab3_3.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",12";
            }

            if (Label_13.Background == lab3_3.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",13";
            }

            if (Label_14.Background == lab3_3.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",14";
            }

            if (Label_15.Background == lab3_3.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",15";
            }

            if (Label_16.Background == lab3_3.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",16";
            }

            return nomer_yacheiki;
        }
        private string podschet_yacheiki_sh8r(string nomer_yacheiki)
        {
            nomerif = true;
            if (Label_1.Background == lab4_4.Background)
            {
                nomer_yacheiki = "1";
            }

            if (Label_2.Background == lab4_4.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",2";
            }

            if (Label_3.Background == lab4_4.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",3";
            }

            if (Label_4.Background == lab4_4.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",4";
            }

            if (Label_5.Background == lab4_4.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",5";
            }

            if (Label_6.Background == lab4_4.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",6";
            }

            if (Label_7.Background == lab4_4.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",7";
            }

            if (Label_8.Background == lab4_4.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",8";
            }

            if (Label_9.Background == lab4_4.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",9";
            }

            if (Label_10.Background == lab4_4.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",10";
            }

            if (Label_11.Background == lab4_4.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",11";
            }

            if (Label_12.Background == lab4_4.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",12";
            }

            if (Label_13.Background == lab4_4.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",13";
            }

            if (Label_14.Background == lab4_4.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",14";
            }

            if (Label_15.Background == lab4_4.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",15";
            }

            if (Label_16.Background == lab4_4.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",16";
            }

            return nomer_yacheiki;
        }
        private string podschet_yacheiki_sh10r(string nomer_yacheiki)
        {
            nomerif = true;
            if (Label_1.Background == lab5_5.Background)
            {
                nomer_yacheiki = "1";
            }

            if (Label_2.Background == lab5_5.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",2";
            }

            if (Label_3.Background == lab5_5.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",3";
            }

            if (Label_4.Background == lab5_5.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",4";
            }

            if (Label_5.Background == lab5_5.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",5";
            }

            if (Label_6.Background == lab5_5.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",6";
            }

            if (Label_7.Background == lab5_5.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",7";
            }

            if (Label_8.Background == lab5_5.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",8";
            }

            if (Label_9.Background == lab5_5.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",9";
            }

            if (Label_10.Background == lab5_5.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",10";
            }

            if (Label_11.Background == lab5_5.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",11";
            }

            if (Label_12.Background == lab5_5.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",12";
            }

            if (Label_13.Background == lab5_5.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",13";
            }

            if (Label_14.Background == lab5_5.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",14";
            }

            if (Label_15.Background == lab5_5.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",15";
            }

            if (Label_16.Background == lab5_5.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",16";
            }

            return nomer_yacheiki;
        }
        private string podschet_condition(string nomer_yacheiki)
        {
            nomerif = true;
            if (Label_1.Background == lab_condi_color.Background)
            {
                nomer_yacheiki = "1";
            }

            if (Label_2.Background == lab_condi_color.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",2";
            }

            if (Label_3.Background == lab_condi_color.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",3";
            }

            if (Label_4.Background == lab_condi_color.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",4";
            }

            if (Label_5.Background == lab_condi_color.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",5";
            }

            if (Label_6.Background == lab_condi_color.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",6";
            }

            if (Label_7.Background == lab_condi_color.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",7";
            }

            if (Label_8.Background == lab_condi_color.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",8";
            }

            if (Label_9.Background == lab_condi_color.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",9";
            }

            if (Label_10.Background == lab_condi_color.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",10";
            }

            if (Label_11.Background == lab_condi_color.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",11";
            }

            if (Label_12.Background == lab_condi_color.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",12";
            }

            if (Label_13.Background == lab_condi_color.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",13";
            }

            if (Label_14.Background == lab_condi_color.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",14";
            }

            if (Label_15.Background == lab_condi_color.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",15";
            }

            if (Label_16.Background == lab_condi_color.Background)
            {
                nomer_yacheiki = nomer_yacheiki + ",16";
            }
            done_bd();
            return nomer_yacheiki;
        }
        public void show()
        {
            Label_1.Visibility = Visibility.Visible;
            Label_2.Visibility = Visibility.Visible;
            Label_3.Visibility = Visibility.Visible;
            Label_4.Visibility = Visibility.Visible;
            Label_5.Visibility = Visibility.Visible;
            Label_6.Visibility = Visibility.Visible;
            Label_7.Visibility = Visibility.Visible;
            Label_8.Visibility = Visibility.Visible;
            Label_9.Visibility = Visibility.Visible;
            Label_10.Visibility = Visibility.Visible;
            Label_11.Visibility = Visibility.Visible;
            Label_12.Visibility = Visibility.Visible;
            Label_13.Visibility = Visibility.Visible;
            Label_14.Visibility = Visibility.Visible;
            Label_15.Visibility = Visibility.Visible;
            Label_16.Visibility = Visibility.Visible;
        }
        public void hide()
        {
            Label_1.Visibility = Visibility.Hidden;
            Label_2.Visibility = Visibility.Hidden;
            Label_3.Visibility = Visibility.Hidden;
            Label_4.Visibility = Visibility.Hidden;
            Label_5.Visibility = Visibility.Hidden;
            Label_6.Visibility = Visibility.Hidden;
            Label_7.Visibility = Visibility.Hidden;
            Label_8.Visibility = Visibility.Hidden;
            Label_9.Visibility = Visibility.Hidden;
            Label_10.Visibility = Visibility.Hidden;
            Label_11.Visibility = Visibility.Hidden;
            Label_12.Visibility = Visibility.Hidden;
            Label_13.Visibility = Visibility.Hidden;
            Label_14.Visibility = Visibility.Hidden;
            Label_15.Visibility = Visibility.Hidden;
            Label_16.Visibility = Visibility.Hidden;
        }
        public string opredelit_nomer_krishki(string nomer_krishki_1)
        {
            if (nomer_krishki_1 == "1")
            {
                Label_1.Background = lab1_1.Background;
            }
            if (nomer_krishki_1 == "2")
            {
                Label_2.Background = lab1_1.Background;
            }
            if (nomer_krishki_1 == "3")
            {
                Label_3.Background = lab1_1.Background;
            }
            if (nomer_krishki_1 == "4")
            {
                Label_4.Background = lab1_1.Background;
            }
            if (nomer_krishki_1 == "5")
            {
                Label_5.Background = lab1_1.Background;
            }
            if (nomer_krishki_1 == "6")
            {
                Label_6.Background = lab1_1.Background;
            }
            if (nomer_krishki_1 == "7")
            {
                Label_7.Background = lab1_1.Background;
            }
            if (nomer_krishki_1 == "8")
            {
                Label_8.Background = lab1_1.Background;
            }
            if (nomer_krishki_1 == "9")
            {
                Label_9.Background = lab1_1.Background;
            }
            if (nomer_krishki_1 == "10")
            {
                Label_10.Background = lab1_1.Background;
            }
            if (nomer_krishki_1 == "11")
            {
                Label_11.Background = lab1_1.Background;
            }
            if (nomer_krishki_1 == "12")
            {
                Label_12.Background = lab1_1.Background;
            }
            if (nomer_krishki_1 == "13")
            {
                Label_13.Background = lab1_1.Background;
            }
            if (nomer_krishki_1 == "14")
            {
                Label_14.Background = lab1_1.Background;
            }
            if (nomer_krishki_1 == "15")
            {
                Label_15.Background = lab1_1.Background;
            }
            if (nomer_krishki_1 == "16")
            {
                Label_16.Background = lab1_1.Background;
            }
            return nomer_krishki_1;
        }
        public string opredelit_nomer_korm(string nomer_krishki_1)
        {
            if (nomer_krishki_1 == "1")
            {
                Label_1.Background = lab2_2.Background;
            }
            if (nomer_krishki_1 == "2")
            {
                Label_2.Background = lab2_2.Background;
            }
            if (nomer_krishki_1 == "3")
            {
                Label_3.Background = lab2_2.Background;
            }
            if (nomer_krishki_1 == "4")
            {
                Label_4.Background = lab2_2.Background;
            }
            if (nomer_krishki_1 == "5")
            {
                Label_5.Background = lab2_2.Background;
            }
            if (nomer_krishki_1 == "6")
            {
                Label_6.Background = lab2_2.Background;
            }
            if (nomer_krishki_1 == "7")
            {
                Label_7.Background = lab2_2.Background;
            }
            if (nomer_krishki_1 == "8")
            {
                Label_8.Background = lab2_2.Background;
            }
            if (nomer_krishki_1 == "9")
            {
                Label_9.Background = lab2_2.Background;
            }
            if (nomer_krishki_1 == "10")
            {
                Label_10.Background = lab2_2.Background;
            }
            if (nomer_krishki_1 == "11")
            {
                Label_11.Background = lab2_2.Background;
            }
            if (nomer_krishki_1 == "12")
            {
                Label_12.Background = lab2_2.Background;
            }
            if (nomer_krishki_1 == "13")
            {
                Label_13.Background = lab2_2.Background;
            }
            if (nomer_krishki_1 == "14")
            {
                Label_14.Background = lab2_2.Background;
            }
            if (nomer_krishki_1 == "15")
            {
                Label_15.Background = lab2_2.Background;
            }
            if (nomer_krishki_1 == "16")
            {
                Label_16.Background = lab2_2.Background;
            }
            return nomer_krishki_1;
        }
        public string opredelit_nomer_dno(string nomer_krishki_1)
        {
            if (nomer_krishki_1 == "1")
            {
                Label_1.Background = lab3_3.Background;
            }
            if (nomer_krishki_1 == "2")
            {
                Label_2.Background = lab3_3.Background;
            }
            if (nomer_krishki_1 == "3")
            {
                Label_3.Background = lab3_3.Background;
            }
            if (nomer_krishki_1 == "4")
            {
                Label_4.Background = lab3_3.Background;
            }
            if (nomer_krishki_1 == "5")
            {
                Label_5.Background = lab3_3.Background;
            }
            if (nomer_krishki_1 == "6")
            {
                Label_6.Background = lab3_3.Background;
            }
            if (nomer_krishki_1 == "7")
            {
                Label_7.Background = lab3_3.Background;
            }
            if (nomer_krishki_1 == "8")
            {
                Label_8.Background = lab3_3.Background;
            }
            if (nomer_krishki_1 == "9")
            {
                Label_9.Background = lab3_3.Background;
            }
            if (nomer_krishki_1 == "10")
            {
                Label_10.Background = lab3_3.Background;
            }
            if (nomer_krishki_1 == "11")
            {
                Label_11.Background = lab3_3.Background;
            }
            if (nomer_krishki_1 == "12")
            {
                Label_12.Background = lab3_3.Background;
            }
            if (nomer_krishki_1 == "13")
            {
                Label_13.Background = lab3_3.Background;
            }
            if (nomer_krishki_1 == "14")
            {
                Label_14.Background = lab3_3.Background;
            }
            if (nomer_krishki_1 == "15")
            {
                Label_15.Background = lab3_3.Background;
            }
            if (nomer_krishki_1 == "16")
            {
                Label_16.Background = lab3_3.Background;
            }
            return nomer_krishki_1;
        }
        public string opredelit_nomer_sh8r(string nomer_krishki_1)
        {
            if (nomer_krishki_1 == "1")
            {
                Label_1.Background = lab4_4.Background;
            }
            if (nomer_krishki_1 == "2")
            {
                Label_2.Background = lab4_4.Background;
            }
            if (nomer_krishki_1 == "3")
            {
                Label_3.Background = lab4_4.Background;
            }
            if (nomer_krishki_1 == "4")
            {
                Label_4.Background = lab4_4.Background;
            }
            if (nomer_krishki_1 == "5")
            {
                Label_5.Background = lab4_4.Background;
            }
            if (nomer_krishki_1 == "6")
            {
                Label_6.Background = lab4_4.Background;
            }
            if (nomer_krishki_1 == "7")
            {
                Label_7.Background = lab4_4.Background;
            }
            if (nomer_krishki_1 == "8")
            {
                Label_8.Background = lab4_4.Background;
            }
            if (nomer_krishki_1 == "9")
            {
                Label_9.Background = lab4_4.Background;
            }
            if (nomer_krishki_1 == "10")
            {
                Label_10.Background = lab4_4.Background;
            }
            if (nomer_krishki_1 == "11")
            {
                Label_11.Background = lab4_4.Background;
            }
            if (nomer_krishki_1 == "12")
            {
                Label_12.Background = lab4_4.Background;
            }
            if (nomer_krishki_1 == "13")
            {
                Label_13.Background = lab4_4.Background;
            }
            if (nomer_krishki_1 == "14")
            {
                Label_14.Background = lab4_4.Background;
            }
            if (nomer_krishki_1 == "15")
            {
                Label_15.Background = lab4_4.Background;
            }
            if (nomer_krishki_1 == "16")
            {
                Label_16.Background = lab4_4.Background;
            }
            return nomer_krishki_1;
        }
        public string opredelit_nomer_sh10r(string nomer_krishki_1)
        {
            if (nomer_krishki_1 == "1")
            {
                Label_1.Background = lab5_5.Background;
            }
            if (nomer_krishki_1 == "2")
            {
                Label_2.Background = lab5_5.Background;
            }
            if (nomer_krishki_1 == "3")
            {
                Label_3.Background = lab5_5.Background;
            }
            if (nomer_krishki_1 == "4")
            {
                Label_4.Background = lab5_5.Background;
            }
            if (nomer_krishki_1 == "5")
            {
                Label_5.Background = lab5_5.Background;
            }
            if (nomer_krishki_1 == "6")
            {
                Label_6.Background = lab5_5.Background;
            }
            if (nomer_krishki_1 == "7")
            {
                Label_7.Background = lab5_5.Background;
            }
            if (nomer_krishki_1 == "8")
            {
                Label_8.Background = lab5_5.Background;
            }
            if (nomer_krishki_1 == "9")
            {
                Label_9.Background = lab5_5.Background;
            }
            if (nomer_krishki_1 == "10")
            {
                Label_10.Background = lab5_5.Background;
            }
            if (nomer_krishki_1 == "11")
            {
                Label_11.Background = lab5_5.Background;
            }
            if (nomer_krishki_1 == "12")
            {
                Label_12.Background = lab5_5.Background;
            }
            if (nomer_krishki_1 == "13")
            {
                Label_13.Background = lab5_5.Background;
            }
            if (nomer_krishki_1 == "14")
            {
                Label_14.Background = lab5_5.Background;
            }
            if (nomer_krishki_1 == "15")
            {
                Label_15.Background = lab5_5.Background;
            }
            if (nomer_krishki_1 == "16")
            {
                Label_16.Background = lab5_5.Background;
            }
            return nomer_krishki_1;
        }
        public string opredelit_condition(string nomer_krishki_1)
        {
            if (nomer_krishki_1 == "1")
            {
                Label_1.Background = lab_condi_color.Background;
            }
            if (nomer_krishki_1 == "2")
            {
                Label_2.Background = lab_condi_color.Background;
            }
            if (nomer_krishki_1 == "3")
            {
                Label_3.Background = lab_condi_color.Background;
            }
            if (nomer_krishki_1 == "4")
            {
                Label_4.Background = lab_condi_color.Background;
            }
            if (nomer_krishki_1 == "5")
            {
                Label_5.Background = lab_condi_color.Background;
            }
            if (nomer_krishki_1 == "6")
            {
                Label_6.Background = lab_condi_color.Background;
            }
            if (nomer_krishki_1 == "7")
            {
                Label_7.Background = lab_condi_color.Background;
            }
            if (nomer_krishki_1 == "8")
            {
                Label_8.Background = lab_condi_color.Background;
            }
            if (nomer_krishki_1 == "9")
            {
                Label_9.Background = lab_condi_color.Background;
            }
            if (nomer_krishki_1 == "10")
            {
                Label_10.Background = lab_condi_color.Background;
            }
            if (nomer_krishki_1 == "11")
            {
                Label_11.Background = lab_condi_color.Background;
            }
            if (nomer_krishki_1 == "12")
            {
                Label_12.Background = lab_condi_color.Background;
            }
            if (nomer_krishki_1 == "13")
            {
                Label_13.Background = lab_condi_color.Background;
            }
            if (nomer_krishki_1 == "14")
            {
                Label_14.Background = lab_condi_color.Background;
            }
            if (nomer_krishki_1 == "15")
            {
                Label_15.Background = lab_condi_color.Background;
            }
            if (nomer_krishki_1 == "16")
            {
                Label_16.Background = lab_condi_color.Background;
            }
            return nomer_krishki_1;
        }
        public void connect_fam(int id)
        {
            string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
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
            finally { conn.Close(); }
        }
        public void connect_attention(int id)
        {
            string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
            MySqlConnection conn = new MySqlConnection(connectString);
            conn.Open();
            string q1 = "SELECT attention FROM work_1 where id = " + id;
             MySqlCommand command = new MySqlCommand(q1, conn);
            MySqlDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    Console.WriteLine(String.Format("{0}", reader[0]));
                    string a = Convert.ToString(reader[0]);
                    if (a == "1") { attention.IsChecked = true; att_border.Visibility = Visibility.Visible; } else { att_border.Visibility = Visibility.Hidden; }
                }
            }
            finally { conn.Close(); }
        }

        public void itog_info(int id)
        {

            string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
            MySqlConnection conn = new MySqlConnection(connectString);
            conn.Open();
            string q1 = "SELECT ramki,sh_uz,sh_sh FROM work_1 where id = " + id;
             MySqlCommand command = new MySqlCommand(q1, conn);
            MySqlDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    for (int i = 0; i == reader.Depth; i++)
                    {
                        ramki_2 =Convert.ToString(reader[0]);
                        sh_uz_2 = Convert.ToString(reader[1]);
                        sh_sh_2 = Convert.ToString(reader[2]);
                    }
                }
            }

            finally { conn.Close(); }
 

            lab10_10.Text = "Рамки=" + ramki_2 + "; шухлятки узкие = " + sh_uz_2 + "; шухлятки широкие =" + sh_sh_2;
        }
        public void connect_last_date(int id)
        {
            string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
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
            string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
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
            string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
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
            string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
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
                opredelit_nomer_korm(nomer_kr[i]);

            }

        }
        public void connect_dno(int id)
        {
            string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
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
                opredelit_nomer_dno(nomer_kr[i]);

            }


        }
        public void connect_sh8r(int id)
        {
            string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
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
                opredelit_nomer_sh8r(nomer_kr[i]);

            }
        }
        public void connect_sh10r(int id)
        {
            string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
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
                opredelit_nomer_sh10r(nomer_kr[i]);

            }
        }
        public void connect_cond(int id)
        {
            string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
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
        public void clean()
        {
            Label_1.Background = no_color.Background;
            Label_2.Background = no_color.Background;
            Label_3.Background = no_color.Background;
            Label_4.Background = no_color.Background;
            Label_5.Background = no_color.Background;
            Label_6.Background = no_color.Background;
            Label_7.Background = no_color.Background;
            Label_8.Background = no_color.Background;
            Label_9.Background = no_color.Background;
            Label_10.Background = no_color.Background;
            Label_11.Background = no_color.Background;
            Label_12.Background = no_color.Background;
            Label_13.Background = no_color.Background;
            Label_14.Background = no_color.Background;
            Label_15.Background = no_color.Background;
            Label_16.Background = no_color.Background;
            attention.IsChecked = false;
        }
        public void label_info(int id)
        {
            itog_info(id);
            connect_fam(id);
            connect_last_date(id);
            connect_next_date(id);
            rasplod_info(id);
            comment_info(id);
            lab6_6.Text = last_date;
            lab7_7.Text = next_date;
            lab8_8.Text = family;
            lab9_9.Text = rasplod;
            comment.Text = commentarii_vivod;    
           
        }
        public void rasplod_info(int id)
        {
            string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
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
                    rasplod = Convert.ToString(reader[0]);
                }
            }
            finally { conn.Close(); }
        }
        public void comment_info(int id)
        {
            string connectString = "server=localhost;user=root;database=diplom;password=;charset=utf8;";
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
        }
    }

}

