   M S B A M L   `   `   `  ����@  <FShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:FShopFShop  5   	       FShop.AdminManipulation   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:FShop     5   	     � Title$  AdminManipulation��5   	   $	��950��6#   $
��1350��60   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��100 �6   �� 5      $��* �6   �� 5      $	��100 �6    � RowDefinitions 5   
   �� 5      $	��100 �6   �� 5      �� 5      $	��100 �6   .+�5   
   �� 
�������$��Center=�6&    �� Padding$ 30q�6A   $��1��6N   $��1��6[    �� CornerRadius$ 10��6k   $	��650��6}    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 30Q�6#      Color$ 	LightGray��63      ShadowDepth$ 0Q�6E   ._�5      �� .+�5      � $	��500��6    5      �� 5      �� 5      $	��700 �6+   .+�5      �� -   5        $��ImageR��5      $��Uniform=�6+   $	��300��6=   $	��300��6J   5!      �� 5"      -   5        $	��SP1��5"   1   $��1��6!   .+�5#      �� -   5        $��NameTB��5#   9   $��35(�6H   $��Center=�6V   $	��300��6s   $��	5,11,5,20q�6   	 � Cursor$	 Arrow��6�   $��Malgun Gothic)�6�   $
��Bold"�6�   ��6#   �� *Name+6�   �� 5%      
 �� Orientation$
 
Horizontal=�6%   $��0,0,0,20q�6>   .+�5&      �� $��Malgun Gothic Semilight)�6(   $��	Цена:��6M   $��Center=�6Z   $��0 0 10 0q�6u   $��30(�6�   �� 5'      -   5        $��PriceTB��5'   b   $��Malgun Gothic Semilight)�6&   $��10 10 50 10q�6q   $��30(�6�   $��Center=�6�   $	��100��6�   $	 Arrow��6�    �� SelectionBrush �	#FFBEBEBE �� 
CaretBrush �	#FFA1A1A1$��37��6�   ��6K   �� *Price+6�   �� 5(      $��Malgun Gothic Semilight)�6(   $��Колисчество:��6M   $��Center=�6a   $��	10 0 10 0q�6|   $��30(�6�   $��Stretch=�6�   �� 5)      -   5        $
��QuTB��5)   e   $��Malgun Gothic Semilight)�6&   $��10 10 50 10q�6q   $��30(�6�   $��Center=�6�   $	��100��6�   $	 Arrow��6�    �	#FFBEBEBE �	#FFA1A1A1$��37��6�   ��6K   �� *
Quantity+6�   5*      �� 5+      -   5        $��DescTb��5+   y   $��Malgun Gothic Semilight)�6"    �� AcceptsReturn$
 True��6d   $��30(�6�   $	��202��6�   $��0,20,0,0q�6�   ��6G   �� *Description+6�   5,      5.      � 5/      .+�50      �� -   5        $��Сохранить��50      $��	859,0,0,0q�61      
mainbutton#���   6D   $
	 Hand��6j   $��30(�6�   �� 51      -   5        $��ChangePhotoButton��51   �   $
��Left=�6   $��Изменить фото��68   $	��Top=�6P   #���   6h   $
	 Hand��6�   $	��237��6�   $��30(�6�   52      54      55      56      57      