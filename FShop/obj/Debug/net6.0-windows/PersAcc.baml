   M S B A M L   `   `   `  ����@  <FShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:FShopFShop  5   	       FShop.PersAcc   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:FShop     5   	     � Title$  PersAcc��5   	   $	��950��6   $
��1350��6&   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��117 �6   �� 5      �� 5      $	��117 �6    � RowDefinitions 5   
   �� 5      $	��100 �6   �� 5      �� 5      $	��100 �6   .+�5   
   �� -   5        $��2��5         
mainbutton#���   6"   $��
Назад��6G   
�������$��30(�6�   5      �� 5   
   -   5        $��Malgun Gothic Semilight)�5      $��30(�66   #���   6D   $��
Выйти��6i   $��0��6y   6�   �� 5   
   
�������$��Center=�6&    �� Padding$ 30q�6A   $��1��6N   $��1��6[    �� CornerRadius$ 10��6k   $	��650��6}    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 30Q�6#      Color$ 	LightGray��63      ShadowDepth$ 0Q�6E   ._�5      �� .+�5      � $	��500��6    5      �� 5       �� 5!      .+�5$      � $��0��6    5%      �� 5&      �� 5'       5)      �� 5*      �� 5+      �� 5,      .+�50      �� $��Login��6    $��Malgun Gothic Semilight)�60   $��30(�6U   $��Center=�6c   $��Center=�6�   �� 51      -   5        	 ��Name$	 loginlab��51       $��1��62   $��Login��6B   $��Malgun Gothic Semilight)�6R   $��30(�6w   $��Center=�6�   $��Center=�6�   �� 52      -   5        
 ��Name$
 logtb��52   "   $��Malgun Gothic Semilight)�61   $��30(�6V   $��1��6d   $y�Hidden=�6t   �� 53      $��1��6    $��Fullname��6-   $��Malgun Gothic Semilight)�6@   $��30(�6e   $��Center=�6s   $��Center=�6�   �� 54      -   5        $	 fullnamelab��54       $��1��65   $��1��6B   $��Fullname��6R   $��Malgun Gothic Semilight)�6e   $��30(�6�   $��Center=�6�   $��Center=�6�   �� 55      -   5        $
 fulltb��55   "   $��1��63   $��Malgun Gothic Semilight)�6@   $��30(�6e   $��1��6s   $y�Hidden=�6�   �� 57      $��2��6    $��Phone��6-   $��Malgun Gothic Semilight)�6=   $��30(�6b   $��Center=�6p   $��Center=�6�   �� 58      -   5        $	 phonelab��58       $��2��62   $��1��6?   $��Phone��6O   $��Malgun Gothic Semilight)�6_   $��30(�6�   $��Center=�6�   $��Center=�6�   �� 59      -   5        $

 phtb��59   "   $��2��61   $��Malgun Gothic Semilight)�6>   $��30(�6c   $��1��6q   $y�Hidden=�6�   5;      � 5=      $��1��6    5>      �� 5?       5A      �� 5B      $	��100 �6,   �� 5C      .+�5E      �� $��Orders��6    $��0��61   $��1��6>   $��Center=�6N   $��Center=�6k   $��Malgun Gothic Semilight)�6�   $��30(�6�   &   System.Windows.Controls.DataGrid  5G      -	   5          Name$ 	DGridUser��5G   s   $��Malgun Gothic Semilight)�6#   $��30(�6H   $��1��6V   $��1��6f      AutoGenerateColumns$ False��6�      
IsReadOnly$
 True��6�      Columns 5H      0  *System.Windows.Controls.DataGridTextColumn  5I   "   ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��65      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6\   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6C   �� *Nane+6h     5J   "   $ 	Fullprice��65   $ * 6f    6H   �� *	Fullprice+6r     5K   "   $
 Date��65   $ * 6\    6C   �� *Date+6h     5L   "   $ Address��65   $ * 6b    6F   �� *	Address+6n     5M   "   $ Comment��65   $ * 6b    6F   �� *	Comment+6n     5N   "   $ Phone��65   $ * 6^    6D   �� *Phone+6j   4  .System.Windows.Controls.DataGridTemplateColumn  5P   "   $
 auto 69      CellTemplate 5Q   &   �� 5R   *   5T   +   5V   #   5Y      5\      5]      � 5^      .+�5_      �� -
   5        $��ChangeButton��5_   �   $��Right=�6   $��Изменить��69   $	��Top=�6L   #���   6d    � Cursor$
 Hand��6�   $	��237��6�   $��30(�6�   $��0,15,0,0q�6�   �� 5`      -   5        $��
SaveButton��5`   �   $��Right=�6   $��Сохранить��69   $	��Top=�6M   #���   6e   $
 Hand��6�   $	��237��6�   $��30(�6�   $��0,10,0,0q�6�   $y�Hidden=�6�   5b      5d      5f      5h      5i      