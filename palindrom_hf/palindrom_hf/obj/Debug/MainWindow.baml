   M S B A M L   `   `   `  ����G  Cpalindrom_hf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:palindrom_hfpalindrom_hf  5   	       palindrom_hf.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:palindrom_hf     5   	     � Title$  Palindrom számok��5   	   $	��450��6"   $	��800��6/    � 	Resources 5	         c1 �� A �� R �� G �� B  c2  c3 �� 
TargetType 
 hatter �� Property �� Value	 � Color
 � Offset  B1 �� Triggers P� Property P� Value��%�  &	        &	 M     &	 �     &	 �     7   7  7  &	 �    �� 5
   
   $	 180��6   $ 0��6#   $	 100��6)   $	 255��61   6;   �� 5   
   $	 180��6   $	 255��6#   $	 255��6+   $	 255��63   6=   �� 5   
   $	 180��6   $	 100��6#   $	 255��6+   $ 50��63   6<   �� 5   
   " �6   .�5      ��  � �� 5      �� 5      .��5      � 8	   $

 0.25Q�6O   6_   � 5      8	  $	
 0.5Q�6O   6^   � 5      8	  $	
 0.9Q�6O   6^   5      5      5      �� 5   
   " ��6    5      P� 5       �@J�IsMouseOver . . �5      ��  � ��
 ��d�6L   �� 5       � ��
 �����6C   5      5       5!      .��5"      � #��[ 6   .+�5#   
   �� -   5        $��L1��5#      $��10,5,0,0q�6   $��18(�6,   $	��Top=�6:   $
��Left=�6R   .��6m   0.Adja meg a kívánt darabszámot (max. 10000):6�   �� 5$   
   -   5        $��	n_bevitel��5$      $��	80,50,0,0q�6#   $��18(�66   $��90��6D   $��30��6O   $	��Top=�6[   $
��Left=�6s   6�   �� 5%   
   -   5        $��B1��5%      $��
190,50,0,0q�6   $��18(�6/   $��70��6=   $��30��6H   $	��Top=�6T   $
��Left=�6l   .��6�   Mutat6�   �� 5&   
   -   5        $	��LB1��5&      $��
10,80,0,10q�6   $��22(�61   $	��650��6?   $	��300��6K   $��Center=�6X   $��Center=�6u   6�   5'      5(      