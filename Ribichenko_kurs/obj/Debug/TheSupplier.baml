   M S B A M L   `   `   `  ����J  FRibichenko_kurs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Ribichenko_kursRibichenko_kurs  5      !    Ribichenko_kurs.TheSupplier   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:Ribichenko_kurs     5        N� Title$  TheSupplier��5	      .��5      �  � RowDefinitions 5   
   �� 5      $��60 �6   6*   �� 5      $��* �6   6)   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DGridRecords��5       $��1��6      AutoGenerateColumns .     
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ НАИМЕНОВАНИЕ ��6&      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6V   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   �� *Name+6b     5      $ Email��6%   $	 100 6N    64   �� *Email+6\     5      $ 
Адрес��6%   $	 100 6O    64   �� *Adress+6]     5      $ 
Номер��6%   $	 150 6T    64   �� *PhoneNumber+6b   4  .System.Windows.Controls.DataGridTemplateColumn  5      $
 auto 6)   	   CellTemplate	 5      �� 5      .R�5      �� $��BtnEdit��6�   -   5        $ ��Редактировать��5   %   $��5q�6=   $	��175��6H   $��30��6T   $��Center=�6`   
��� ���6�   5      5      5      �� 5    
   -   5        
 ��Name$
 	btndelete��5       $	��200��5!      $��40��5"      $��Center=�5#      $
��Left=�5$      ���	#ff1d222c
�������$��Удалить��5'      $��17(�5(      $��0��5)      $��20,0,0,0q�5*      ��5,      �� 5-       �� 
TargetType" ��6   .�5.      ��  �� Property � �� �� Value �#a0a0a063   �� 5/       � �� 50      �� 51       �� 
TargetType" ��6.   .R�52   "   ��  ��Name$ ButtonBackground��6)   
�������._�53   &   �� $��Center=�67   $��Center=�6R   $��0q�54   W    �� CornerRadius$ 10��55   R   ��56   &   �� 57   *    �� EndPoint$ 0.5,1&�6>    �� 
StartPoint$ 0.5,0&�6O   .��58   .   �  � Color$ #00BE41��6;    � Offset$ 0Q�6K   � 59   .   $ #00BE41��6;   $ 1Q�6K   5:   +   5<   #    �� Triggers 5=   "   P� 5>   &    P� Property �@J�IsMouseOver P� Value . . �5?   *   ��  �� 
TargetName$ ButtonBackground��61    � �� 5@   .   �� 5A   2   $ 0.5,0&�6F   $ 0.5,1&�6Y   .��5B   6   � $ 	#ff232d3e��6C   $ 0Q�6U   � 5C   6   $ 	#ff232d3e��6C   $
 0.75Q�6U   � 5D   6   $ 	#ff232d3e��6C   $
 0.75Q�6U   � 5E   6   $ 	#ff232d3e��6C   $ 1Q�6U   5F   3   5H   +   5I   '   5L      5N      5O      5Q      �� 5R   
   -   5        $
 btnAdd��5R      $	��200��5S      $��40��5T      $��Center=�5U      $��Right=�5V      ���	#ff1d222c
�������$��Добавить��5Y      $��17(�5Z      $��0��5[      ��5^      �� 5_      " ��6   .�5`      ��  � �� �#a0a0a063   �� 5a       � �� 5b      �� 5c      " ��6.   .R�5d   "   �� $ ButtonBackground��6)   
�������._�5e   &   �� $��Center=�67   $��Center=�6R   $��0q�5f   W   $ 10��5g   R   ��5h   &   �� 5i   *   $ 0.5,1&�6>   $ 0.5,0&�6O   .��5j   .   � $ #00BE41��6;   $ 0Q�6K   � 5k   .   $ #00BE41��6;   $ 1Q�6K   5l   +   5n   #    5o   "   P� 5p   &    �@J�IsMouseOver . . �5q   *   �� $ ButtonBackground��61    � �� 5r   .   �� 5s   2   $ 0.5,0&�6F   $ 0.5,1&�6Y   .��5t   6   � $ 	#ff232d3e��6C   $ 0Q�6U   � 5u   6   $ 	#ff232d3e��6C   $
 0.75Q�6U   � 5v   6   $ 	#ff232d3e��6C   $
 0.75Q�6U   � 5w   6   $ 	#ff232d3e��6C   $ 1Q�6U   5x   3   5z   +   5{   '   5~      5�      5�      5�      5�      5�      