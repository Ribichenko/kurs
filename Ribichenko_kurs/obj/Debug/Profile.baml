   M S B A M L   `   `   `  ����J  FRibichenko_kurs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Ribichenko_kursRibichenko_kurs  5          Ribichenko_kurs.Profile   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:Ribichenko_kurs     5        N� Title$  Profile��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��400 �6   6-   �� 5      6!   .+�5   
   �� $	��250��6   $	��250��6   $��	0,0,0,180q�6*   
�������._�5      �� $��	login.png��6   5      �� 5   
   $
��Name��6   $��30(�6    $��Center=�6.   $��Center=�6K   $��	0,150,0,0q�6f   6{   �� 5   
   $��1��6    �� Orientation$ Vertical=�6%   $	��500��6<   $	��500��6H   $
��Left=�6U   .+�5      �� $��Имя��6   $��28(�6#   $��80��61   
���   �$��	0,0,200,0q�6O   6d   �� 5      -   5         ��Name$ NameTb��5      $��0,0,0,0q�6'   $��0,0,0,0q�68   $��Center=�6J   $��Center=�6g   $��34(�6�   $��50��6�   $	��300��6�   ��6�   �� *	User.Name+.��6�   ��5      �� 5      .R�5      ��  ��Name$ border1��6!    �� CornerRadius$ 10��62   ���#6A95D7$��1q�5   /    J� SnapsToDevicePixels . ._�5      ��  ��Name$ PART_ContentHost��6+   |�.  6E   5      5      .��5   $   5      �� 5       $��Email��6   $��28(�6%   $��80��63   
���   �$��	0,0,200,0q�6Q   6f   �� 5!      -   5        $ EmailTb��5!      $��0,0,0,0q�6(   $��0,0,0,0q�69   $��Center=�6K   $��Center=�6h   $��34(�6�   $��50��6�   $	��300��6�   ��6�   �� *
User.Email+.��6�   ��5"      �� 5#      .R�5$      �� $ border1��6!   $ 10��62   ���#6A95D7$��1q�5%   /    . ._�5&      �� $ PART_ContentHost��6+   |�.  6E   5'      5(      .��5)   $   5*      �� 5+      $��Телефон��6   $��28(�6'   $	��120��65   
���   �$��	0,0,180,0q�6T   6i   �� 5,      -   5        $ PhoneTb��5,      $��0,0,0,0q�6)   $��0,0,0,0q�6:   $��Center=�6L   $��Center=�6i   $��34(�6�   $��50��6�   $	��300��6�   ��6�   �� *User.PhoneNumber+.��6�   ��5-      �� 5.      .R�5/      �� $ border1��6!   $ 10��62   ���#6A95D7$��1q�50   /    . ._�51      �� $ PART_ContentHost��6+   |�.  6E   52      53      .��54   $   55      �� 56      $��Пароль��6   $��28(�6&   $	��120��64   
���   �$��	0,0,180,0q�6S   6h   �� 57      -   5        $ 
PasswordTb��57      $��0,0,0,10q�6+   $��0,0,0,0q�6=   $��Center=�6O   $��Center=�6l   $��34(�6�   $��50��6�   $	��300��6�   ��6�   �� *User.Password+.��6�   ��58      �� 59      .R�5:      �� $ border1��6!   $ 10��62   ���#6A95D7$��1q�5;   /    . ._�5<      �� $ PART_ContentHost��6+   |�.  6E   5=      5>      .��5?   $   5@      �� 5A      -   5         ��Name$ btnPass��5A      $	��150��5B      $��40��5C      $��Center=�5D      $��Center=�5E      ���	#ff1d222c
�������$#��Изменить пароль��5H      $��15(�5I      $��2��5J      $��	140,0,0,0q�5K      ��5L      �� 5M      	 �� 
TargetType"	 ��6   .�5N      �� 
 �� Property
 � �� �� Value �#a0a0a067   �� 5O      
 � �� 5P      �� 5Q   "    �� 
TargetType" ��62   .R�5R   &   �� $ ButtonBackground��6-   
�������._�5S   *   �� $��Center=�6;   $��Center=�6V   $��0q�5T   [   $ 10��5U   V   ��5V   *   �� 5W   .    �� EndPoint$ 0.5,1&�6B    �� 
StartPoint$ 0.5,0&�6S   .��5X   2   �  � Color$ #24397C��6?    � Offset$ 0Q�6O   � 5Y   2   $ #24397C��6?   $ 1Q�6O   5Z   /   5\   '    �� Triggers 5]   &   P� 5^   *    P� Property �@J�IsMouseOver P� Value . . �5_   .   ��  �� 
TargetName$ ButtonBackground��65   
 � �� 5`   2   �� 5a   6   $ 0.5,0&�6J   $ 0.5,1&�6]   .��5b   :   � $ 	#ff232d3e��6G   $ 0Q�6Y   � 5c   :   $ 	#ff232d3e��6G   $
 0.75Q�6Y   � 5d   :   $ 	#ff232d3e��6G   $
 0.75Q�6Y   � 5e   :   $ 	#ff232d3e��6G   $ 1Q�6Y   5f   7   5h   /   5i   +   5l   #   5n      5o      5q      5s      �� 5t   
   -   5        $	 btn��5t      $��0��5u      $	��120��5v      $��40��5w      $��Bottom=�5x      $
��Left=�5y      ���	#ff1d222c
�������$��
Выход��5|      $��17(�5}      $��2��5~      $��	20,0,0,20q�5      ��5�      �� 5�      "	 ��6   .�5�      �� 
 � �� �#a0a0a063   �� 5�      
 � �� 5�      �� 5�      " ��6.   .R�5�   "   �� $ ButtonBackground��6)   
�������._�5�   &   �� $��Center=�67   $��Center=�6R   $��0q�5�   W   $ 10��5�   R   ��5�   &   �� 5�   *   $ 0.5,1&�6>   $ 0.5,0&�6O   .��5�   .   � $ #24397C��6;   $ 0Q�6K   � 5�   .   $ #24397C��6;   $ 1Q�6K   5�   +   5�   #    5�   "   P� 5�   &    �@J�IsMouseOver . . �5�   *   �� $ ButtonBackground��61   
 � �� 5�   .   �� 5�   2   $ 0.5,0&�6F   $ 0.5,1&�6Y   .��5�   6   � $ 	#ff232d3e��6C   $ 0Q�6U   � 5�   6   $ 	#ff232d3e��6C   $
 0.75Q�6U   � 5�   6   $ 	#ff232d3e��6C   $
 0.75Q�6U   � 5�   6   $ 	#ff232d3e��6C   $ 1Q�6U   5�   3   5�   +   5�   '   5�      5�      5�      5�      �� 5�   
   -   5        $ btnSave��5�      $	��200��5�      $��1��5�      $��40��5�      $��Bottom=�5�      $��Right=�5�      ���	#ff1d222c
�������$+��%Сохранить изменения��5�      $��17(�5�      $��2��5�      $��	0,0,20,20q�5�      ��5�      �� 5�      "	 ��6   .�5�      �� 
 � �� �#a0a0a063   �� 5�      
 � �� 5�      �� 5�      " ��6.   .R�5�   "   �� $ ButtonBackground��6)   
�������._�5�   &   �� $��Center=�67   $��Center=�6R   $��0q�5�   W   $ 10��5�   R   ��5�   &   �� 5�   *   $ 0.5,1&�6>   $ 0.5,0&�6O   .��5�   .   � $ #00BE41��6;   $ 0Q�6K   � 5�   .   $ #00BE41��6;   $ 1Q�6K   5�   +   5�   #    5�   "   P� 5�   &    �@J�IsMouseOver . . �5�   *   �� $ ButtonBackground��61   
 � �� 5�   .   �� 5�   2   $ 0.5,0&�6F   $ 0.5,1&�6Y   .��5�   6   � $ 	#ff232d3e��6C   $ 0Q�6U   � 5�   6   $ 	#ff232d3e��6C   $
 0.75Q�6U   � 5�   6   $ 	#ff232d3e��6C   $
 0.75Q�6U   � 5�   6   $ 	#ff232d3e��6C   $ 1Q�6U   5�   3   5�   +   5�   '   5�      5�      5�      5�      5�      5�      