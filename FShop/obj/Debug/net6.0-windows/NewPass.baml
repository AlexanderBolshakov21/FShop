   M S B A M L   `   `   `  ����@  <FShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:FShopFShop  5   	       FShop.NewPass   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:FShop     5   	     � Title$  NewPass��5   	   $	��950��6   $
��1350��6&   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��450 �6   �� 5      �� 5      $	��450 �6    � RowDefinitions 5   
   �� 5      $	��150 �6   �� 5      �� 5      $	��150 �6   .+�5   
   �� $��0��6   $��0��6    $	��113��6.   $
��Left=�6:   $��Center=�6U   $��92��6p   $��10,0,0,0q�6|   �� 5   
   -   5        $	��100��5      $	��100��6   $��2��6*   
�������$��Right=�6c   5      �� 5   
   $��1��6   $��Ручки.есть��6    $��Center=�65   $��50(�6R   $��Malgun Gothic Semilight)�6`   $��Normal"�6�   $��Center=�6�   $��92��6�   �� 5    
   $��1��6   $	��150��6   
�������$	��350��6@    �� Padding$ 30q�6P   $	��450��6]   $	��100��6l    �� CornerRadius$ 20��6|   $��0,0,6,8q�6�   $��1��6�    J� Effect 5!      3  -System.Windows.Media.Effects.DropShadowEffect  5"         
BlurRadius$ 30Q�6#   ._�5%      �� .+�5&      �� $��Новый пароль��6   $��Malgun Gothic Semilight)�6/   $��30(�6T   $��Center=�6b   �� 5(      $��1q�6   ���#acb0af$ 5��6C   $	��5 5q�6U   ._�5)      � $	��5 5q�6    5*      �� 5+      $
��auto �6/   �� 5,      $��* �6/   .+�5/      �� -   5         ��Name$
 Pass��5/   $   $��Новый пароль��62      textHint#���   6F   $��Malgun Gothic Semilight)�6i   6�   G� 50      -   5         G�Name$ Pass_reg��50   H     textbox#���  6&   $��Malgun Gothic Semilight)�6[   6�   51      52      �� 53      $��1q�6   ���#acb0af$ 5��6C   $	��5 5q�6U   ._�54      � $	��5 5q�6    55      �� 56      $
��auto �6/   �� 57      $��* �6/   .+�5:      �� -   5        $ PassSec��5:   $   $%��Повторите пароль��65   #���   6M   $��Malgun Gothic Semilight)�6p   $��5,0,0,5q�6�   G� 5;      -   5        $ PassSec_reg��5;   H   #���  6&   $��Malgun Gothic Semilight)�6]   6�   5<      5=      �� 5>      -   5        	 ��Name$	 
button_reg��5>        
mainbutton#���  6-   $	��267��6R   $��Сохранить��6^   $��74��6r   $��28(�6~   $��0,5,0,15q�6�   6�   5?      5@      5A      5B      