   M S B A M L   `   `   `  ����J  FRibichenko_kurs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Ribichenko_kursRibichenko_kurs  5          Ribichenko_kurs.Employ   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:Ribichenko_kurs     5        N� Title$  Employ��5	      .��5
      �  � RowDefinitions 5   
   �� 5      $��60 �6   6*   �� 5      $��* �6   6)   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DGridRecord��5       $��1��6      AutoGenerateColumns .     
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ФИО��6&      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6K   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   �� *FIO+6W     5      $ ДОЛЖНОСТЬ��6%   $	 100 6U    68   �� *
Position+6c     5      $ EMAIL��6%   $	 100 6N    64   �� *Email+6\     5      $ АДРЕСС��6%   $	 100 6P    65   �� *Adress+6^     5      $ 
НОМЕР��6%   $	 100 6T    64   �� *PhoneNumber+6b   4  .System.Windows.Controls.DataGridTemplateColumn  5      $
 auto 6)   	   CellTemplate	 5      �� 5      .R�5      �� -   5        $ ��Редактировать��5   %   $��5q�6=   $	��175��6H   $��30��6T   $��Center=�6`   
��� ���6�   5      5      5      �� 5   
   -   5        
 ��Name$
 btnAdd��5      $	��200��5       $��40��5!      $��Center=�5"      $��Right=�5#      ���	#ff1d222c
�������$��Добавить��5&      $��17(�5'      $��0��5(      ��5+      �� 5,       �� 
TargetType" ��6   .�5-      ��  �� Property � �� �� Value �#a0a0a063   �� 5.       � �� 5/      �� 50       �� 
TargetType" ��6.   .R�51   "   ��  ��Name$ ButtonBackground��6)   
�������._�52   &   �� $��Center=�67   $��Center=�6R   $��0q�53   W    �� CornerRadius$ 10��54   R   ��55   &   �� 56   *    �� EndPoint$ 0.5,1&�6>    �� 
StartPoint$ 0.5,0&�6O   .��57   .   �  � Color$ #00BE41��6;    � Offset$ 0Q�6K   � 58   .   $ #00BE41��6;   $ 1Q�6K   59   +   5;   #    �� Triggers 5<   "   P� 5=   &    P� Property �@J�IsMouseOver P� Value . . �5>   *   ��  �� 
TargetName$ ButtonBackground��61    � �� 5?   .   �� 5@   2   $ 0.5,0&�6F   $ 0.5,1&�6Y   .��5A   6   � $ 	#ff232d3e��6C   $ 0Q�6U   � 5B   6   $ 	#ff232d3e��6C   $
 0.75Q�6U   � 5C   6   $ 	#ff232d3e��6C   $
 0.75Q�6U   � 5D   6   $ 	#ff232d3e��6C   $ 1Q�6U   5E   3   5G   +   5H   '   5K      5M      5N      5P      �� 5Q   
   -   5        $
 	btndelete��5Q      $	��200��5R      $��40��5S      $��Center=�5T      $
��Left=�5U      ���	#ff1d222c
�������$��Удалить��5X      $��17(�5Y      $��0��5Z      $��20,0,0,0q�5[      ��5]      �� 5^      " ��6   .�5_      ��  � �� �#a0a0a063   �� 5`       � �� 5a      �� 5b      " ��6.   .R�5c   "   �� $ ButtonBackground��6)   
�������._�5d   &   �� $��Center=�67   $��Center=�6R   $��0q�5e   W   $ 10��5f   R   ��5g   &   �� 5h   *   $ 0.5,1&�6>   $ 0.5,0&�6O   .��5i   .   � $ #00BE41��6;   $ 0Q�6K   � 5j   .   $ #00BE41��6;   $ 1Q�6K   5k   +   5m   #    5n   "   P� 5o   &    �@J�IsMouseOver . . �5p   *   �� $ ButtonBackground��61    � �� 5q   .   �� 5r   2   $ 0.5,0&�6F   $ 0.5,1&�6Y   .��5s   6   � $ 	#ff232d3e��6C   $ 0Q�6U   � 5t   6   $ 	#ff232d3e��6C   $
 0.75Q�6U   � 5u   6   $ 	#ff232d3e��6C   $
 0.75Q�6U   � 5v   6   $ 	#ff232d3e��6C   $ 1Q�6U   5w   3   5y   +   5z   '   5}      5      5�      5�      5�      5�      