   M S B A M L   `   `   `  ���� @  <FShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:FShopFShop      FShop.Orders   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     %localclr-namespace:FShop       � Title$  Orders��$	��950��$
��1350�� � Icon$b \C:\Users\1\Pictures\впкс-курсач (цветочный)\FShop\FShop\Resources\mdi.ico��.��� .+�� .+��  � RowDefinitions �� $	��100 ��� �� $	��100 �.+��� $��0��$	��100��$	��Top=�.+��  � ColumnDefinitions �� $	��113 ��� �� $	��200 �.+��� $��0��$b��\C:\Users\1\Pictures\впкс-курсач (цветочный)\FShop\FShop\Resources\mdi.png��$	��113��$
��Left=�$��Center=�$��92���� -   $��30(�$��Products��   
mainbutton#���   $	��100��$��2��
�������$��Center=�$	��180��$��Center=�$��Malgun Gothic Semilight)��� $��1��$��FlowersForLovers��$��Center=�$��Center=�$��Malgun Gothic Semilight)�$��30(�&   System.Windows.Controls.DataGrid  -     Name$ 
DGridOrder��$��Malgun Gothic Semilight)�$��30(�$��1��   AutoGenerateColumns$ False��   
IsReadOnly$
 True��$��	0,35,0,10q�   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ IdUser��	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 * 1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 �� *IdUser+  $
 Name��$	 * 
 �� *Name+  $ 	Fullprice��$	 * 
 �� *	Fullprice+  $ Address��$	 * 
 �� *	Address+  $ Comment��$	 * 
 �� *	Comment+  $ Phone��$	 * 
 �� *Phone+4  .System.Windows.Controls.DataGridTemplateColumn  $
	 auto    CellTemplate �� �� $	��150��$��Delete��#���   $��2��$��Right=�$��0,0,10,0q�$��30(�