   M S B A M L   `   `   `  ����@  <FShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:FShopFShop  5   	       FShop.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:FShop     5   	     � Title$  Autorization��5   	   $	��950��6   $
��1350��6+   .��5
      �  � ColumnDefinitions 5   
   �� 5      $	��450 �6   �� 5      $��* �6   �� 5      $	��450 �6    � RowDefinitions 5   
   �� 5      $	��200 �6   �� 5      �� 5      $	��200 �6   .+�5   
   �� $��0��6   $��0��6    $	��113��6-   $
��Left=�69   $��Center=�6T   $��92��6o   $��10,0,0,0q�6{   �� 5   
   $��Ручки.есть��6   $��1��6%   $��Center=�65   $��70(�6R   $��Malgun Gothic)�6`   $
��Bold"�6{   $	��132��6�   $	��400��6�   $��Center=�6�   �� 5   
   $	��150��6   
�������$	��450��63    �� Padding$ 30,30,30,30q�6C   $	��400��6Y   $	��100��6h    �� CornerRadius$ 20��6x   $��1��6�   $��	0,198,0,7q�6�   $��2��6�    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 30Q�6#   ._�5!      �� .+�5"      �� $��Вход��6   $��Malgun Gothic Semilight)�6'   $��30(�6L   $��Center=�6Z   �� 5#      $��1q�6   ���#acb0af$ 5��6C   $	��5 5q�6T   ._�5$      � $	��5 5q�6    5%      �� 5&      $
��auto �6/   �� 5'      $��* �6/   .+�5*      �� -   5         ��Name$	 Log��5*   $   $��Введите логин��61      textHint#���   6F   $��Malgun Gothic Semilight)�6i   $��36(�6�   �� 5+      -   5         ��Name$ Log_ent��5+   E     textbox#���  6#   $��Malgun Gothic Semilight)�6x   5,      5-      �� 5.      $��1q�6   ���#acb0af$ 5��6C   $	��5 5q�6T   ._�5/      � $	��5 5q�6    50      �� 51      $
��auto �6/   �� 52      $��* �6/   .+�55      �� -   5        $
 Pass��55   $   $!��Введите пароль��62   #���   6H   $��Malgun Gothic Semilight)�6k   $��36(�6�   G� 56      -   5        	 G�Name$	 Pass_ent��56   H   #���  6&   $��Malgun Gothic Semilight)�6Z   6   57      58      �� 59      $	��192��6   $��Magneto)�6(   $��25(�6=   �� 6L   -   5        $��
page2.xaml?�59   V   ���#689359$��Malgun Gothic Semilight)�6�   
 � Cursor$

 Hand��6�   .�6�   �� $ �Забыли пароль?��6�   6�   6�   �� 5:      -   5         ��Name$ button_login��5:        
mainbutton#���  6/   $	��234��6T   $��
Войти��6`   $��84��6p   $��36(�6|   $��	0,10,0,10q�6�   6�   �� 5;      $��Center=�6   $��25(�69   �� 6H   -   5        $��Registration.xaml?�5;   R   ���#689359$��Malgun Gothic Semilight)�6�   .�6�   &$Зарегистрироваться6�   6�   5<      5=      5>      5?      