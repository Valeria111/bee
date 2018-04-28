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
            Label[] labels_one = new Label[] { Label_1, Label_2, Label_3, Label_4, Label_5, Label_6, Label_7, Label_8, Label_9, Label_10, Label_11, Label_12, Label_13, Label_14, Label_15, Label_16 };
            Label[] labels_two = new Label[] { Label_17, Label_18, Label_19, Label_20, Label_21, Label_22, Label_23, Label_24, Label_25, Label_26, Label_27, Label_28, Label_29, Label_30, Label_31, Label_32 };
            Label[] labels_three = new Label[] { Label_33, Label_34, Label_35, Label_36, Label_37, Label_38, Label_39, Label_40, Label_41, Label_42, Label_43, Label_44, Label_45, Label_46, Label_47, Label_48 };
            Label[] labels_four = new Label[] { Label_49, Label_50, Label_51, Label_52, Label_53, Label_54, Label_55, Label_56, Label_57, Label_58, Label_59, Label_60, Label_61, Label_62, Label_63, Label_64 };
            Label[] labels_five = new Label[] { Label_65, Label_66, Label_67, Label_68, Label_69, Label_70, Label_71, Label_72, Label_73, Label_74, Label_75, Label_76, Label_77, Label_78, Label_79, Label_80 };
            Label[] labels_six = new Label[] { Label_6_1, Label_6_2, Label_6_3, Label_6_4, Label_6_5, Label_6_6, Label_6_7, Label_6_8, Label_6_9, Label_6_10, Label_6_11, Label_6_12, Label_6_13, Label_6_14, Label_6_15, Label_6_16 };
            Label[] labels_seven = new Label[] { Label_7_1, Label_7_2, Label_7_3, Label_7_4, Label_7_5, Label_7_6, Label_7_7, Label_7_8, Label_7_9, Label_7_10, Label_7_11, Label_7_12, Label_6_13, Label_7_14, Label_7_15, Label_7_16 };
            Label[] labels_8 = new Label[] { Label_8_1, Label_8_2, Label_8_3, Label_8_4, Label_8_5, Label_8_6, Label_8_7, Label_8_8, Label_8_9, Label_8_10, Label_8_11, Label_8_12, Label_6_13, Label_8_14, Label_8_15, Label_8_16 };
            Label[] labels_9 = new Label[] { Label_9_1, Label_9_2, Label_9_3, Label_9_4, Label_9_5, Label_9_6, Label_9_7, Label_9_8, Label_9_9, Label_9_10, Label_9_11, Label_9_12, Label_6_13,Label_9_14, Label_9_15, Label_9_16 };
            Label[] labels_10 = new Label[] { Label_10_1, Label_10_2, Label_10_3, Label_10_4, Label_10_5, Label_10_6, Label_10_7, Label_10_8, Label_10_9, Label_10_10, Label_10_11, Label_6_13, Label_10_12, Label_10_14, Label_10_15, Label_10_16 };
            List<Label[]> labels = new List<Label[]> { labels_one, labels_two, labels_three, labels_four, labels_five, labels_six, labels_seven,labels_8, labels_9, labels_10 };


        }
       
        
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
            Label[] labels_one = new Label[] { Label_1, Label_2, Label_3, Label_4, Label_5, Label_6, Label_7, Label_8, Label_9, Label_10, Label_11, Label_12, Label_13, Label_14, Label_15, Label_16 };
            Label[] labels_two = new Label[] { Label_17, Label_18, Label_19, Label_20, Label_21, Label_22, Label_23, Label_24, Label_25, Label_26, Label_27, Label_28, Label_29, Label_30, Label_31, Label_32 };
            Label[] labels_three = new Label[] { Label_33, Label_34, Label_35, Label_36, Label_37, Label_38, Label_39, Label_40, Label_41, Label_42, Label_43, Label_44, Label_45, Label_46, Label_47, Label_48 };
            Label[] labels_four = new Label[] { Label_49, Label_50, Label_51, Label_52, Label_53, Label_54, Label_55, Label_56, Label_57, Label_58, Label_59, Label_60, Label_61, Label_62, Label_63, Label_64 };
            Label[] labels_five = new Label[] { Label_65, Label_66, Label_67, Label_68, Label_69, Label_70, Label_71, Label_72, Label_73, Label_74, Label_75, Label_76, Label_77, Label_78, Label_79, Label_80 };
            Label[] labels_six = new Label[] { Label_6_1, Label_6_2, Label_6_3, Label_6_4, Label_6_5, Label_6_6, Label_6_7, Label_6_8, Label_6_9, Label_6_10, Label_6_11, Label_6_12, Label_6_13, Label_6_14, Label_6_15, Label_6_16 };
            Label[] labels_seven = new Label[] { Label_7_1, Label_7_2, Label_7_3, Label_7_4, Label_7_5, Label_7_6, Label_7_7, Label_7_8, Label_7_9, Label_7_10, Label_7_11, Label_7_12, Label_6_13, Label_7_14, Label_7_15, Label_7_16 };
            Label[] labels_8 = new Label[] { Label_8_1, Label_8_2, Label_8_3, Label_8_4, Label_8_5, Label_8_6, Label_8_7, Label_8_8, Label_8_9, Label_8_10, Label_8_11, Label_8_12, Label_6_13, Label_8_14, Label_8_15, Label_8_16 };
            Label[] labels_9 = new Label[] { Label_9_1, Label_9_2, Label_9_3, Label_9_4, Label_9_5, Label_9_6, Label_9_7, Label_9_8, Label_9_9, Label_9_10, Label_9_11, Label_9_12, Label_6_13, Label_9_14, Label_9_15, Label_9_16 };
            Label[] labels_10 = new Label[] { Label_10_1, Label_10_2, Label_10_3, Label_10_4, Label_10_5, Label_10_6, Label_10_7, Label_10_8, Label_10_9, Label_10_10, Label_10_11, Label_6_13, Label_10_12, Label_10_14, Label_10_15, Label_10_16 };
            List<Label[]> labels = new List<Label[]> { labels_one, labels_two, labels_three, labels_four, labels_five, labels_six, labels_seven, labels_8, labels_9, labels_10 };
            attention.IsChecked = false;
            Label[] nomera = new Label[] { Nomer_1, Nomer_2, Nomer_3, Nomer_4, Nomer_5 };
            int[] id = new int[] { 1,2,3,4,5,6,7,8,9,10 };
            int k = 1;
            if (show_all1.IsChecked == true)
            {
                for(int j = 0; j< nomera.Length ; j++)
                {
                    nomera[j].Content =k++;
                }
                for (int i = 0; i < 10; i++)
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
                    labels_seven[i].MouseLeftButtonDown += six_MouseLeftButtonDown;
                    labels_8[i].MouseLeftButtonDown += six_MouseLeftButtonDown;
                    labels_9[i].MouseLeftButtonDown += six_MouseLeftButtonDown;
                    labels_10[i].MouseLeftButtonDown += six_MouseLeftButtonDown;

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


        public void opredelit_nomer_krishki(string nomer_krishki_1, int id_nomer)
        {
            Label[] labels_one = new Label[] { Label_1, Label_2, Label_3, Label_4, Label_5, Label_6, Label_7, Label_8, Label_9, Label_10, Label_11, Label_12, Label_13, Label_14, Label_15, Label_16 };
            Label[] labels_two = new Label[] { Label_17, Label_18, Label_19, Label_20, Label_21, Label_22, Label_23, Label_24, Label_25, Label_26, Label_27, Label_28, Label_29, Label_30, Label_31, Label_32 };
            Label[] labels_three = new Label[] { Label_33, Label_34, Label_35, Label_36, Label_37, Label_38, Label_39, Label_40, Label_41, Label_42, Label_43, Label_44, Label_45, Label_46, Label_47, Label_48 };
            Label[] labels_four = new Label[] { Label_49, Label_50, Label_51, Label_52, Label_53, Label_54, Label_55, Label_56, Label_57, Label_58, Label_59, Label_60, Label_61, Label_62, Label_63, Label_64 };
            Label[] labels_five = new Label[] { Label_65, Label_66, Label_67, Label_68, Label_69, Label_70, Label_71, Label_72, Label_73, Label_74, Label_75, Label_76, Label_77, Label_78, Label_79, Label_80 };
            Label[] labels_six = new Label[] { Label_6_1, Label_6_2, Label_6_3, Label_6_4, Label_6_5, Label_6_6, Label_6_7, Label_6_8, Label_6_9, Label_6_10, Label_6_11, Label_6_12, Label_6_13, Label_6_14, Label_6_15, Label_6_16 };
            Label[] labels_seven = new Label[] { Label_7_1, Label_7_2, Label_7_3, Label_7_4, Label_7_5, Label_7_6, Label_7_7, Label_7_8, Label_7_9, Label_7_10, Label_7_11, Label_7_12, Label_6_13, Label_7_14, Label_7_15, Label_7_16 };
            Label[] labels_8 = new Label[] { Label_8_1, Label_8_2, Label_8_3, Label_8_4, Label_8_5, Label_8_6, Label_8_7, Label_8_8, Label_8_9, Label_8_10, Label_8_11, Label_8_12, Label_6_13, Label_8_14, Label_8_15, Label_8_16 };
            Label[] labels_9 = new Label[] { Label_9_1, Label_9_2, Label_9_3, Label_9_4, Label_9_5, Label_9_6, Label_9_7, Label_9_8, Label_9_9, Label_9_10, Label_9_11, Label_9_12, Label_6_13, Label_9_14, Label_9_15, Label_9_16 };
            Label[] labels_10 = new Label[] { Label_10_1, Label_10_2, Label_10_3, Label_10_4, Label_10_5, Label_10_6, Label_10_7, Label_10_8, Label_10_9, Label_10_10, Label_10_11, Label_6_13, Label_10_12, Label_10_14, Label_10_15, Label_10_16 };
            List<Label[]> labels = new List<Label[]> { labels_one, labels_two, labels_three, labels_four, labels_five, labels_six, labels_seven, labels_8, labels_9, labels_10 };
            int k = Convert.ToInt32(nomer_krishki_1 );
            int x = k;
            if (x>0)
            {               
                        labels[id_nomer-1][x-1].Background = lab1_1.Background;                    
            }
        }
        public void opredelit_nomer_korm(string nomer_krishki_1, int id_nomer)
        {
            Label[] labels_one = new Label[] { Label_1, Label_2, Label_3, Label_4, Label_5, Label_6, Label_7, Label_8, Label_9, Label_10, Label_11, Label_12, Label_13, Label_14, Label_15, Label_16 };
            Label[] labels_two = new Label[] { Label_17, Label_18, Label_19, Label_20, Label_21, Label_22, Label_23, Label_24, Label_25, Label_26, Label_27, Label_28, Label_29, Label_30, Label_31, Label_32 };
            Label[] labels_three = new Label[] { Label_33, Label_34, Label_35, Label_36, Label_37, Label_38, Label_39, Label_40, Label_41, Label_42, Label_43, Label_44, Label_45, Label_46, Label_47, Label_48 };
            Label[] labels_four = new Label[] { Label_49, Label_50, Label_51, Label_52, Label_53, Label_54, Label_55, Label_56, Label_57, Label_58, Label_59, Label_60, Label_61, Label_62, Label_63, Label_64 };
            Label[] labels_five = new Label[] { Label_65, Label_66, Label_67, Label_68, Label_69, Label_70, Label_71, Label_72, Label_73, Label_74, Label_75, Label_76, Label_77, Label_78, Label_79, Label_80 };
            Label[] labels_six = new Label[] { Label_6_1, Label_6_2, Label_6_3, Label_6_4, Label_6_5, Label_6_6, Label_6_7, Label_6_8, Label_6_9, Label_6_10, Label_6_11, Label_6_12, Label_6_13, Label_6_14, Label_6_15, Label_6_16 };
            Label[] labels_seven = new Label[] { Label_7_1, Label_7_2, Label_7_3, Label_7_4, Label_7_5, Label_7_6, Label_7_7, Label_7_8, Label_7_9, Label_7_10, Label_7_11, Label_7_12, Label_6_13, Label_7_14, Label_7_15, Label_7_16 };
            Label[] labels_8 = new Label[] { Label_8_1, Label_8_2, Label_8_3, Label_8_4, Label_8_5, Label_8_6, Label_8_7, Label_8_8, Label_8_9, Label_8_10, Label_8_11, Label_8_12, Label_6_13, Label_8_14, Label_8_15, Label_8_16 };
            Label[] labels_9 = new Label[] { Label_9_1, Label_9_2, Label_9_3, Label_9_4, Label_9_5, Label_9_6, Label_9_7, Label_9_8, Label_9_9, Label_9_10, Label_9_11, Label_9_12, Label_6_13, Label_9_14, Label_9_15, Label_9_16 };
            Label[] labels_10 = new Label[] { Label_10_1, Label_10_2, Label_10_3, Label_10_4, Label_10_5, Label_10_6, Label_10_7, Label_10_8, Label_10_9, Label_10_10, Label_10_11, Label_6_13, Label_10_12, Label_10_14, Label_10_15, Label_10_16 };
            List<Label[]> labels = new List<Label[]> { labels_one, labels_two, labels_three, labels_four, labels_five, labels_six, labels_seven, labels_8, labels_9, labels_10 };
            int x = Convert.ToInt32(nomer_krishki_1);
            if (x > 0)
            {
                    labels[id_nomer - 1][x - 1].Background = lab2_2.Background;
            }
        }
        public void opredelit_nomer_dno(string nomer_krishki_1, int id_nomer)
        {
            Label[] labels_one = new Label[] { Label_1, Label_2, Label_3, Label_4, Label_5, Label_6, Label_7, Label_8, Label_9, Label_10, Label_11, Label_12, Label_13, Label_14, Label_15, Label_16 };
            Label[] labels_two = new Label[] { Label_17, Label_18, Label_19, Label_20, Label_21, Label_22, Label_23, Label_24, Label_25, Label_26, Label_27, Label_28, Label_29, Label_30, Label_31, Label_32 };
            Label[] labels_three = new Label[] { Label_33, Label_34, Label_35, Label_36, Label_37, Label_38, Label_39, Label_40, Label_41, Label_42, Label_43, Label_44, Label_45, Label_46, Label_47, Label_48 };
            Label[] labels_four = new Label[] { Label_49, Label_50, Label_51, Label_52, Label_53, Label_54, Label_55, Label_56, Label_57, Label_58, Label_59, Label_60, Label_61, Label_62, Label_63, Label_64 };
            Label[] labels_five = new Label[] { Label_65, Label_66, Label_67, Label_68, Label_69, Label_70, Label_71, Label_72, Label_73, Label_74, Label_75, Label_76, Label_77, Label_78, Label_79, Label_80 };
            Label[] labels_six = new Label[] { Label_6_1, Label_6_2, Label_6_3, Label_6_4, Label_6_5, Label_6_6, Label_6_7, Label_6_8, Label_6_9, Label_6_10, Label_6_11, Label_6_12, Label_6_13, Label_6_14, Label_6_15, Label_6_16 };
            Label[] labels_seven = new Label[] { Label_7_1, Label_7_2, Label_7_3, Label_7_4, Label_7_5, Label_7_6, Label_7_7, Label_7_8, Label_7_9, Label_7_10, Label_7_11, Label_7_12, Label_6_13, Label_7_14, Label_7_15, Label_7_16 };
            Label[] labels_8 = new Label[] { Label_8_1, Label_8_2, Label_8_3, Label_8_4, Label_8_5, Label_8_6, Label_8_7, Label_8_8, Label_8_9, Label_8_10, Label_8_11, Label_8_12, Label_6_13, Label_8_14, Label_8_15, Label_8_16 };
            Label[] labels_9 = new Label[] { Label_9_1, Label_9_2, Label_9_3, Label_9_4, Label_9_5, Label_9_6, Label_9_7, Label_9_8, Label_9_9, Label_9_10, Label_9_11, Label_9_12, Label_6_13, Label_9_14, Label_9_15, Label_9_16 };
            Label[] labels_10 = new Label[] { Label_10_1, Label_10_2, Label_10_3, Label_10_4, Label_10_5, Label_10_6, Label_10_7, Label_10_8, Label_10_9, Label_10_10, Label_10_11, Label_6_13, Label_10_12, Label_10_14, Label_10_15, Label_10_16 };
            List<Label[]> labels = new List<Label[]> { labels_one, labels_two, labels_three, labels_four, labels_five, labels_six, labels_seven, labels_8, labels_9, labels_10 };
            int x = Convert.ToInt32(nomer_krishki_1);
            if (x > 0)
            {
                    labels[id_nomer - 1][x - 1].Background = lab3_3.Background;
            }
        }
        public void opredelit_nomer_sh8r(string nomer_krishki_1, int id_nomer)
        {
            Label[] labels_one = new Label[] { Label_1, Label_2, Label_3, Label_4, Label_5, Label_6, Label_7, Label_8, Label_9, Label_10, Label_11, Label_12, Label_13, Label_14, Label_15, Label_16 };
            Label[] labels_two = new Label[] { Label_17, Label_18, Label_19, Label_20, Label_21, Label_22, Label_23, Label_24, Label_25, Label_26, Label_27, Label_28, Label_29, Label_30, Label_31, Label_32 };
            Label[] labels_three = new Label[] { Label_33, Label_34, Label_35, Label_36, Label_37, Label_38, Label_39, Label_40, Label_41, Label_42, Label_43, Label_44, Label_45, Label_46, Label_47, Label_48 };
            Label[] labels_four = new Label[] { Label_49, Label_50, Label_51, Label_52, Label_53, Label_54, Label_55, Label_56, Label_57, Label_58, Label_59, Label_60, Label_61, Label_62, Label_63, Label_64 };
            Label[] labels_five = new Label[] { Label_65, Label_66, Label_67, Label_68, Label_69, Label_70, Label_71, Label_72, Label_73, Label_74, Label_75, Label_76, Label_77, Label_78, Label_79, Label_80 };
            Label[] labels_six = new Label[] { Label_6_1, Label_6_2, Label_6_3, Label_6_4, Label_6_5, Label_6_6, Label_6_7, Label_6_8, Label_6_9, Label_6_10, Label_6_11, Label_6_12, Label_6_13, Label_6_14, Label_6_15, Label_6_16 };
            Label[] labels_seven = new Label[] { Label_7_1, Label_7_2, Label_7_3, Label_7_4, Label_7_5, Label_7_6, Label_7_7, Label_7_8, Label_7_9, Label_7_10, Label_7_11, Label_7_12, Label_6_13, Label_7_14, Label_7_15, Label_7_16 };
            Label[] labels_8 = new Label[] { Label_8_1, Label_8_2, Label_8_3, Label_8_4, Label_8_5, Label_8_6, Label_8_7, Label_8_8, Label_8_9, Label_8_10, Label_8_11, Label_8_12, Label_6_13, Label_8_14, Label_8_15, Label_8_16 };
            Label[] labels_9 = new Label[] { Label_9_1, Label_9_2, Label_9_3, Label_9_4, Label_9_5, Label_9_6, Label_9_7, Label_9_8, Label_9_9, Label_9_10, Label_9_11, Label_9_12, Label_6_13, Label_9_14, Label_9_15, Label_9_16 };
            Label[] labels_10 = new Label[] { Label_10_1, Label_10_2, Label_10_3, Label_10_4, Label_10_5, Label_10_6, Label_10_7, Label_10_8, Label_10_9, Label_10_10, Label_10_11, Label_6_13, Label_10_12, Label_10_14, Label_10_15, Label_10_16 };
            List<Label[]> labels = new List<Label[]> { labels_one, labels_two, labels_three, labels_four, labels_five, labels_six, labels_seven, labels_8, labels_9, labels_10 };
            int x = Convert.ToInt32(nomer_krishki_1) ;
            if (x>0)
            {
                  
                        labels[id_nomer - 1][x-1].Background = lab4_4.Background;                    
            }
        }
        public void opredelit_nomer_sh10r(string nomer_krishki_1, int id_nomer)
        {
            Label[] labels_one = new Label[] { Label_1, Label_2, Label_3, Label_4, Label_5, Label_6, Label_7, Label_8, Label_9, Label_10, Label_11, Label_12, Label_13, Label_14, Label_15, Label_16 };
            Label[] labels_two = new Label[] { Label_17, Label_18, Label_19, Label_20, Label_21, Label_22, Label_23, Label_24, Label_25, Label_26, Label_27, Label_28, Label_29, Label_30, Label_31, Label_32 };
            Label[] labels_three = new Label[] { Label_33, Label_34, Label_35, Label_36, Label_37, Label_38, Label_39, Label_40, Label_41, Label_42, Label_43, Label_44, Label_45, Label_46, Label_47, Label_48 };
            Label[] labels_four = new Label[] { Label_49, Label_50, Label_51, Label_52, Label_53, Label_54, Label_55, Label_56, Label_57, Label_58, Label_59, Label_60, Label_61, Label_62, Label_63, Label_64 };
            Label[] labels_five = new Label[] { Label_65, Label_66, Label_67, Label_68, Label_69, Label_70, Label_71, Label_72, Label_73, Label_74, Label_75, Label_76, Label_77, Label_78, Label_79, Label_80 };
            Label[] labels_six = new Label[] { Label_6_1, Label_6_2, Label_6_3, Label_6_4, Label_6_5, Label_6_6, Label_6_7, Label_6_8, Label_6_9, Label_6_10, Label_6_11, Label_6_12, Label_6_13, Label_6_14, Label_6_15, Label_6_16 };
            Label[] labels_seven = new Label[] { Label_7_1, Label_7_2, Label_7_3, Label_7_4, Label_7_5, Label_7_6, Label_7_7, Label_7_8, Label_7_9, Label_7_10, Label_7_11, Label_7_12, Label_6_13, Label_7_14, Label_7_15, Label_7_16 };
            Label[] labels_8 = new Label[] { Label_8_1, Label_8_2, Label_8_3, Label_8_4, Label_8_5, Label_8_6, Label_8_7, Label_8_8, Label_8_9, Label_8_10, Label_8_11, Label_8_12, Label_6_13, Label_8_14, Label_8_15, Label_8_16 };
            Label[] labels_9 = new Label[] { Label_9_1, Label_9_2, Label_9_3, Label_9_4, Label_9_5, Label_9_6, Label_9_7, Label_9_8, Label_9_9, Label_9_10, Label_9_11, Label_9_12, Label_6_13, Label_9_14, Label_9_15, Label_9_16 };
            Label[] labels_10 = new Label[] { Label_10_1, Label_10_2, Label_10_3, Label_10_4, Label_10_5, Label_10_6, Label_10_7, Label_10_8, Label_10_9, Label_10_10, Label_10_11, Label_6_13, Label_10_12, Label_10_14, Label_10_15, Label_10_16 };
            List<Label[]> labels = new List<Label[]> { labels_one, labels_two, labels_three, labels_four, labels_five, labels_six, labels_seven, labels_8, labels_9, labels_10 };
            int x = Convert.ToInt32(nomer_krishki_1);
            if (x > 0)
            {
                    labels[id_nomer - 1][x - 1].Background = lab5_5.Background;
                
            }
        }
        public void opredelit_condition(string nomer_krishki_1, int id_nomer)
        {
            Label[] labels_one = new Label[] { Label_1, Label_2, Label_3, Label_4, Label_5, Label_6, Label_7, Label_8, Label_9, Label_10, Label_11, Label_12, Label_13, Label_14, Label_15, Label_16 };
            Label[] labels_two = new Label[] { Label_17, Label_18, Label_19, Label_20, Label_21, Label_22, Label_23, Label_24, Label_25, Label_26, Label_27, Label_28, Label_29, Label_30, Label_31, Label_32 };
            Label[] labels_three = new Label[] { Label_33, Label_34, Label_35, Label_36, Label_37, Label_38, Label_39, Label_40, Label_41, Label_42, Label_43, Label_44, Label_45, Label_46, Label_47, Label_48 };
            Label[] labels_four = new Label[] { Label_49, Label_50, Label_51, Label_52, Label_53, Label_54, Label_55, Label_56, Label_57, Label_58, Label_59, Label_60, Label_61, Label_62, Label_63, Label_64 };
            Label[] labels_five = new Label[] { Label_65, Label_66, Label_67, Label_68, Label_69, Label_70, Label_71, Label_72, Label_73, Label_74, Label_75, Label_76, Label_77, Label_78, Label_79, Label_80 };
            Label[] labels_six = new Label[] { Label_6_1, Label_6_2, Label_6_3, Label_6_4, Label_6_5, Label_6_6, Label_6_7, Label_6_8, Label_6_9, Label_6_10, Label_6_11, Label_6_12, Label_6_13, Label_6_14, Label_6_15, Label_6_16 };
            Label[] labels_seven = new Label[] { Label_7_1, Label_7_2, Label_7_3, Label_7_4, Label_7_5, Label_7_6, Label_7_7, Label_7_8, Label_7_9, Label_7_10, Label_7_11, Label_7_12, Label_6_13, Label_7_14, Label_7_15, Label_7_16 };
            Label[] labels_8 = new Label[] { Label_8_1, Label_8_2, Label_8_3, Label_8_4, Label_8_5, Label_8_6, Label_8_7, Label_8_8, Label_8_9, Label_8_10, Label_8_11, Label_8_12, Label_6_13, Label_8_14, Label_8_15, Label_8_16 };
            Label[] labels_9 = new Label[] { Label_9_1, Label_9_2, Label_9_3, Label_9_4, Label_9_5, Label_9_6, Label_9_7, Label_9_8, Label_9_9, Label_9_10, Label_9_11, Label_9_12, Label_6_13, Label_9_14, Label_9_15, Label_9_16 };
            Label[] labels_10 = new Label[] { Label_10_1, Label_10_2, Label_10_3, Label_10_4, Label_10_5, Label_10_6, Label_10_7, Label_10_8, Label_10_9, Label_10_10, Label_10_11, Label_6_13, Label_10_12, Label_10_14, Label_10_15, Label_10_16 };
            List<Label[]> labels = new List<Label[]> { labels_one, labels_two, labels_three, labels_four, labels_five, labels_six, labels_seven, labels_8, labels_9, labels_10 };
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
            Label[] labels_one = new Label[] { Label_1, Label_2, Label_3, Label_4, Label_5, Label_6, Label_7, Label_8, Label_9, Label_10, Label_11, Label_12, Label_13, Label_14, Label_15, Label_16 };
            Label[] labels_two = new Label[] { Label_17, Label_18, Label_19, Label_20, Label_21, Label_22, Label_23, Label_24, Label_25, Label_26, Label_27, Label_28, Label_29, Label_30, Label_31, Label_32 };
            Label[] labels_three = new Label[] { Label_33, Label_34, Label_35, Label_36, Label_37, Label_38, Label_39, Label_40, Label_41, Label_42, Label_43, Label_44, Label_45, Label_46, Label_47, Label_48 };
            Label[] labels_four = new Label[] { Label_49, Label_50, Label_51, Label_52, Label_53, Label_54, Label_55, Label_56, Label_57, Label_58, Label_59, Label_60, Label_61, Label_62, Label_63, Label_64 };
            Label[] labels_five = new Label[] { Label_65, Label_66, Label_67, Label_68, Label_69, Label_70, Label_71, Label_72, Label_73, Label_74, Label_75, Label_76, Label_77, Label_78, Label_79, Label_80 };
            Label[] labels_six = new Label[] { Label_6_1, Label_6_2, Label_6_3, Label_6_4, Label_6_5, Label_6_6, Label_6_7, Label_6_8, Label_6_9, Label_6_10, Label_6_11, Label_6_12, Label_6_13, Label_6_14, Label_6_15, Label_6_16 };
            Label[] labels_seven = new Label[] { Label_7_1, Label_7_2, Label_7_3, Label_7_4, Label_7_5, Label_7_6, Label_7_7, Label_7_8, Label_7_9, Label_7_10, Label_7_11, Label_7_12, Label_6_13, Label_7_14, Label_7_15, Label_7_16 };
            Label[] labels_8 = new Label[] { Label_8_1, Label_8_2, Label_8_3, Label_8_4, Label_8_5, Label_8_6, Label_8_7, Label_8_8, Label_8_9, Label_8_10, Label_8_11, Label_8_12, Label_6_13, Label_8_14, Label_8_15, Label_8_16 };
            Label[] labels_9 = new Label[] { Label_9_1, Label_9_2, Label_9_3, Label_9_4, Label_9_5, Label_9_6, Label_9_7, Label_9_8, Label_9_9, Label_9_10, Label_9_11, Label_9_12, Label_6_13, Label_9_14, Label_9_15, Label_9_16 };
            Label[] labels_10 = new Label[] { Label_10_1, Label_10_2, Label_10_3, Label_10_4, Label_10_5, Label_10_6, Label_10_7, Label_10_8, Label_10_9, Label_10_10, Label_10_11, Label_6_13, Label_10_12, Label_10_14, Label_10_15, Label_10_16 };
            List<Label[]> labels = new List<Label[]> { labels_one, labels_two, labels_three, labels_four, labels_five, labels_six, labels_seven, labels_8, labels_9, labels_10 };
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
            Label[] labels_one = new Label[] { Label_1, Label_2, Label_3, Label_4, Label_5, Label_6, Label_7, Label_8, Label_9, Label_10, Label_11, Label_12, Label_13, Label_14, Label_15, Label_16 };
            Label[] labels_two = new Label[] { Label_17, Label_18, Label_19, Label_20, Label_21, Label_22, Label_23, Label_24, Label_25, Label_26, Label_27, Label_28, Label_29, Label_30, Label_31, Label_32 };
            Label[] labels_three = new Label[] { Label_33, Label_34, Label_35, Label_36, Label_37, Label_38, Label_39, Label_40, Label_41, Label_42, Label_43, Label_44, Label_45, Label_46, Label_47, Label_48 };
            Label[] labels_four = new Label[] { Label_49, Label_50, Label_51, Label_52, Label_53, Label_54, Label_55, Label_56, Label_57, Label_58, Label_59, Label_60, Label_61, Label_62, Label_63, Label_64 };
            Label[] labels_five = new Label[] { Label_65, Label_66, Label_67, Label_68, Label_69, Label_70, Label_71, Label_72, Label_73, Label_74, Label_75, Label_76, Label_77, Label_78, Label_79, Label_80 };
            Label[] labels_six = new Label[] { Label_6_1, Label_6_2, Label_6_3, Label_6_4, Label_6_5, Label_6_6, Label_6_7, Label_6_8, Label_6_9, Label_6_10, Label_6_11, Label_6_12, Label_6_13, Label_6_14, Label_6_15, Label_6_16 };
            Label[] labels_seven = new Label[] { Label_7_1, Label_7_2, Label_7_3, Label_7_4, Label_7_5, Label_7_6, Label_7_7, Label_7_8, Label_7_9, Label_7_10, Label_7_11, Label_7_12, Label_6_13, Label_7_14, Label_7_15, Label_7_16 };
            Label[] labels_8 = new Label[] { Label_8_1, Label_8_2, Label_8_3, Label_8_4, Label_8_5, Label_8_6, Label_8_7, Label_8_8, Label_8_9, Label_8_10, Label_8_11, Label_8_12, Label_6_13, Label_8_14, Label_8_15, Label_8_16 };
            Label[] labels_9 = new Label[] { Label_9_1, Label_9_2, Label_9_3, Label_9_4, Label_9_5, Label_9_6, Label_9_7, Label_9_8, Label_9_9, Label_9_10, Label_9_11, Label_9_12, Label_6_13, Label_9_14, Label_9_15, Label_9_16 };
            Label[] labels_10 = new Label[] { Label_10_1, Label_10_2, Label_10_3, Label_10_4, Label_10_5, Label_10_6, Label_10_7, Label_10_8, Label_10_9, Label_10_10, Label_10_11, Label_6_13, Label_10_12, Label_10_14, Label_10_15, Label_10_16 };
            List<Label[]> labels = new List<Label[]> { labels_one, labels_two, labels_three, labels_four, labels_five, labels_six, labels_seven, labels_8, labels_9, labels_10 };
            Label[] nomera = new Label[] { Nomer_1, Nomer_2, Nomer_3, Nomer_4, Nomer_5 };
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
                nomera[j].MouseLeftButtonDown += attention_comment_MouseLeftButtonDown;

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
