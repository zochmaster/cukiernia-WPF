   M S B A M L   `   `   `  ����N  JZochowski_cukiernia, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Zochowski_cukierniaZochowski_cukiernia  5   	   !    Zochowski_cukiernia.Window2   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:Zochowski_cukiernia     5   	     � Title$  
Pracownicy��5   	   $	��450��6   $	��800��6)    � 	Resources 5	         tloPrzyciskow �� 
StartPoint �� EndPoint � Color � Offset��%�   &	        �� 5
   
   $ 0.5,0&�64   $ 0.5,1&�5      .��5      � $
 Pink��6   $ 0Q�6(   � 5      $ PaleVioletRed��6   $ 1Q�61   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   $	��671��6*   �� 5      $��0* �6    � ColumnDefinitions 5   
   �� 5      $��* �6    5   
     stylPrzyciskow �� Property	 �� Value��%K  &	       7   �� 5      .�5      ��  � ��$	 10q�62   �� 5       � ��$	 10q�63   �� 5       � ��$	 12(�64   �� 5       � ��$
	 Bold"�66   �� 5       � ��$	 Italic$�65   �� 5       � ��
	 �   �67   �� 5        � ��$	 2q�6;   �� 5!       � ��8	   66   5"      5#      .+�5$   
   o� $��0��6   $��0��6   .@�5&      m� $��Strony��6   .@�5'      m� -   5        $��Zakupy��5'      6+   m� 5(      -   5        $��Opinie��5(      6+   m� 5)      $��
Pracownicy��6   5*      5+      �� 5,   
   $��Dodaj Pracownika��6   $
��Left=�6+   $��54��6F   $��	29,98,0,0q�6R   $	��Top=�6e   $	��343��6}   $��Center=�6�   $��22(�6�   $
��Bold"�6�   �� 5-   
   $��Imię i nazwisko:��6   $
��Left=�6+   $��28��6F   $��
24,152,0,0q�6R   $	��Top=�6f   $	��143��6~   $��Center=�6�   �� 5.   
   -   5        
 ��Name$
 userName��5.      $
��Left=�6$   $��23��6?   $��172,157,0,0q�6K    �� TextWrapping$
 Wrap=�6`   $	��Top=�6t   $	��125��6�   �� 5/   
   $��Stanowisko:��6   $
��Left=�6&   $��28��6A   $��
24,198,0,0q�6M   $	��Top=�6a   $	��143��6y   $��Center=�6�   �� 50   
   -   5         ��Name$ stanowiskoComboBox��50       �� SelectedItem$ 	Stażysta��6/   $
��Left=�6G   $��24��6b   $��172,200,0,0q�6n   $	��Top=�6�   $	��125��6�   �� 52   
   -   5         ��Name$ ResetButton��52      $��reset��6&   #��[ 66   $
��Left=�6^   $��44��6y   $��110,260,0,0q�6�   $	��Top=�6�   $	��106��6�   6�   �� 53   
   -   5        $ 	AddButton��53      $��dodaj��6$   #��[ 64   $
��Left=�6\   $��44��6w   $��251,260,0,0q�6�   $	��Top=�6�   $	��106��6�   6�   �� 54   
   -   5         ��Name$ 	komunikat��54      $
��Left=�6#   $��76��6>   $��
24,331,0,0q�6J   $	��Top=�6^   $	��376��6v   $��Center=�6�   $��24(�6�   $
��Bold"�6�   
���  ��6�   �� 57   
   -   5         ��Name$ lstPracownicy��57      $��400,54,10,367q�6*   ��58      �� 59       �� View 5;      �� 5<      .P�5=      �� $��Nr��6%    �� DisplayMemberBinding 61   �� *Numer+�� 5>      $��Imię��6%    63   �� *Imie+�� 5?      $��Nazwisko��6%    67   �� *
Nazwisko+�� 5@      $��
Stanowisko��6%    69   �� *
Stanowisko+5A      5C      �� 5D   
   -	   5        $ deleteButton��5D      $��usuń użytkownika��6'   #��[ 6B   $
��Left=�6j   $��48��6�   $��498,340,0,0q�6�   $	��Top=�6�   $	��194��6�   6�   5G      5H      