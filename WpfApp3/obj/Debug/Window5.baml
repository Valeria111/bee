   M S B A M L   `   `   `  ����B  >WpfApp3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp3WpfApp3  5   	       WpfApp3.Window5   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp3     5   	     � Title$  Window5��5   	   $��303.918��6   $��590.112��6*   .��5	      � $��	0,0,4,3.4q�6    � ColumnDefinitions 5
   
   �� 5       � RowDefinitions 5   
   �� 5      .+�5   
   �� -   5         ��Name$ canvas��5      $	��201��6!   $��
10,36,10,0q�6.   $	��Top=�6B   .+�5      �� -   5         ��Name$ label_1��5      $%��Количество ульев��6%   $	��162��6@   $��2q�6L   ���	#FF403636
 �� Top$ 32��6x   $y�Hidden=�6�   �� 5      -   5        $ label_2��5      $2��,Количество полных ульев��6%   $ 62��6G   $	��162��6W   ���	#FF403636���	#FFDFDFDF J� OpacityMask
 �   �$��2q�6�   $��32��6�   $y�Hidden=�6�   �� 5      -   5        $ label_3��5      $��внимание��6%   $ 94��68   $	��162��6H   ���	#FF403636
�������
 �   �$��2q�6�   $��32��6�   $y�Hidden=�6�   �� 5      -   5        $ label_1_Copy��5      $�� ��6*   $��91��65   $��2q�6@   ���	#FF403636 �� Left$	 450��6l   $ 32��6~   $y�Hidden=�6�   �� 5      -   5        $ label_1_Copy1��5      $�� ��6+   $��91��66   $��2q�6A   ���	#FF403636$	 162��6m   $ 62��6   $��32��6�   ���	#FFDFDFDF$y�Hidden=�6�   �� 5      -   5        $ label_1_Copy2��5      $�� ��6+   $��91��66   $��2q�6A   ���	#FF403636$	 162��6m   $ 94��6   $��32��6�   $y�Hidden=�6�   �� 5      -   5        $ label_3_Copy��5      $��крышки��6*   $	��162��6;   ���	#FF403636
�������
 �   �$��2q�6�   $��30��6�   $	 288��6�   $ 32��6�   $y�Hidden=�6�   �� 5      -	   5        $ label_3_Copy1��5      $��
донья��6+   $	��162��6;   ���	#FF403636���	#FFDFDFDF
 �   �$��2q�6�   $��32��6�   $	 288��6�   $ 62��6�   $y�Hidden=�6�   �� 5      -
   5        $ label_3_Copy2��5      $3��-шухляткие зимние(8 рамок)��6+   $	��162��6O   ���	#FF403636
�������
 �   �$��2q�6�   $��32��6�   $	 288��6�   $ 94��6�   $��11(�6�   $y�Hidden=�6�   �� 5      -   5        $ label_3_Copy3��5      $2��,шухлятки летние(10 рамок)��6+   $	��162��6O   ���	#FF403636���	#FFDFDFDF
 �   �$��2q�6�   $��32��6�   $	 288��6�   $	 126��6�   $��11(�6�   $y�Hidden=�6�   �� 5      -   5        $ label_3_Copy4��5      $��кондиционер��6+   $	��162��6A   ���	#FF403636
�������
 �   �$��2q�6�   $��32��6�   $	 288��6�   $	 158��6�   $y�Hidden=�6�   �� 5      -   5        $ label_1_Copy3��5      $�� ��6+   $��91��66   $��2q�6A   ���	#FF403636$	 450��6m   $ 62��6   $��32��6�   ���	#FFDFDFDF$y�Hidden=�6�   �� 5      -   5        $ label_1_Copy4��5      $�� ��6+   $��91��66   $��2q�6A   ���	#FF403636$	 450��6m   $ 94��6   $��32��6�   $y�Hidden=�6�   �� 5      -   5        $ label_1_Copy5��5      $�� ��6+   $��91��66   $��2q�6A   ���	#FF403636$	 450��6m   $	 158��6   $��32��6�   $y�Hidden=�6�   �� 5      -   5        $ label_1_Copy6��5      $�� ��6+   $��91��66   $��2q�6A   ���	#FF403636$	 450��6m   $	 126��6   $��32��6�   ���	#FFDFDFDF$y�Hidden=�6�   �� 5       -   5        $ label_1_Copy7��5       $�� ��6+   $��91��66   $��2q�6A   ���	#FF403636$	 162��6m   $ 32��6   $y�Hidden=�6�   �� 5!      -   5        $
 name��5!      $;��5            Полный отчет по пасеке��6"   $	 162��6O   $ 1��6a   $	��288��6p   $y�Hidden=�6|   �� 5"      -   5        $ lb��5"      $��Номер улья��6    $ 42��65   $��95��6E    J� RenderTransformOrigin$ 0.5,0.5&�6P   ���	#FF8C8C8C$��2q�6�   z�5#      V� 5$      .~�5%      �� �� 5&      �� 5'      T� 5(      	 T� X$	 2Q�6-   
 T� Y$
 2Q�63   5)      5+      �� 5,      -   5         ��Name$ nomer_input��5,      $��27��6+   $	 100��67    �� TextWrapping$
 Wrap=�6I   $ 45��6]   $	��130��6m   6�   �� 5-      -   5        $ title��5-      $/��)Полный отчет по улию №��6#   $	 100��6D   $ 6��6V   $��34��6e   $	��313��6q   $��14(�6}   $��Center=�6�   �� 5.      -   5        $ lb_Copy��5.      $��Семейство��6%   $ 72��69   $��95��6I   $ 0.5,0.5&�6T   ���	#FF8C8C8C$��2q�6�   z�5/      V� 50      .~�51      �� �� 52      �� 53      T� 54      $	 2Q�6-   $
 2Q�63   55      57      �� 58      -   5        $ lb_Copy1��58      $��Расплод��6&   $	 102��68   $��95��6I   $ 0.5,0.5&�6T   ���	#FF8C8C8C$��2q�6�   z�59      V� 5:      .~�5;      �� �� 5<      �� 5=      T� 5>      $	 2Q�6-   $
 2Q�63   5?      5A      �� 5B      -   5        $ lb_Copy2��5B      $�� ��6&   $ 72��61   $	��135��6A   $ 0.5,0.5&�6M   ���	#FF8C8C8C$��2q�6�   $ 95��6�   z�5C      V� 5D      .~�5E      �� �� 5F      �� 5G      T� 5H      $	 2Q�6-   $
 2Q�63   5I      5K      �� 5L      -   5        $ lb_Copy3��5L      $�� ��6&   $	 102��61   $	��135��6B   $ 0.5,0.5&�6N   ���	#FF8C8C8C$��2q�6�   $ 95��6�   z�5M      V� 5N      .~�5O      �� �� 5P      �� 5Q      T� 5R      $	 2Q�6-   $
 2Q�63   5S      5U      �� 5V      -   5        $ lb_Copy4��5V      $��Комментарий��6&   $ 45��6<   $	��105��6L   $ 0.5,0.5&�6X   ���	#FF8C8C8C$��2q�6�   $	 244��6�   z�5W      V� 5X      .~�5Y      �� �� 5Z      �� 5[      T� 5\      $	 2Q�6-   $
 2Q�63   5]      5_      �� 5`      -   5        $ lb_Copy5��5`      $�� ��6&   $ 45��61   $	��192��6A   $ 0.5,0.5&�6M   ���	#FF8C8C8C$��2q�6�   $	 349��6�   $��57��6�   z�5a      V� 5b      .~�5c      �� �� 5d      �� 5e      T� 5f      $	 2Q�6-   $
 2Q�63   5g      5i      5j      �� 5k   
   -   5         ��Name$ Button��5k      $��Печать��6!   $
��Left=�62   $��471,242,0,0q�6M   $	��Top=�6b   $��75��6z   6�   �� 5l   
   -   5        $
 full��5l      $��Пасека��6   $
��Left=�60   $��	10,10,0,0q�6K   $	��Top=�6^   $��79��6v   $��21��6�   ���	#FFDDDDDD6�   �� 5m   
   -   5        $ unfull��5m      $��Улей��6!   $
��Left=�60   $��	94,10,0,0q�6K   $	��Top=�6^   $��79��6v   $��21��6�   �� 5n   
   -   5        $ l��5n      $��Label��6   $
��Left=�6+   $��
288,10,0,0q�6F   $	��Top=�6Z   ���	#FF96B7C5$y�Hidden=�6�   �� 5o   
   $��Label��6   $
��Left=�6    $��685,41,-205,0q�6;   $	��Top=�6R   $	��100��6j   �� 5p   
   $��CheckBox��6   $
��Left=�6&   $��627,138,-147,0q�6A   $	��Top=�6Y   $	��100��6q   �� 5q   
   -    5        $ l2��5q      $��Button��6   $
��Left=�6.   $��21��6I   $��
455,10,0,0q�6U   $	��Top=�6i   $��29��6�   $y�Hidden=�6�   �� 5r   
   -!   5        $
 back��5r      $��
Назад��6   $
��Left=�6/   $��19��6J   $��398,242,0,0q�6V   $	��Top=�6k   $��68��6�   6�   5t      5u      