   M S B A M L   `   `   `  ����>  :GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:GUIGUI  5   	       GUI.slidingPuzzle   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:GUI     5   	     � Title$  slidingPuzzle��5   	   $	��600��6   $	��800��6,    � 	Resources 5	         pic1  pic2��%�   &	        &	 t     �� 5
   
   $��Numbers/amsterdam1.jpg��6   $
��Fill=�6>   $��1��6M   $��2��6]   $��3��6j   $��3��6~   �� 5   
   $��Numbers/amsterdam2.jpg��6   $
��Fill=�6>   $��1��6M   $��2��6]   $��3��6j   $��3��6~   5      .��5      � -   5         �Name$ slidingPuzzleGrid��5   8    � ShowGridLines .  
��� d � � ColumnDefinitions 5   
   �� 5      $	��10* �6   �� 5      $	��10* �6   �� 5      $	��10* �6    � RowDefinitions 5   
   �� 5      $��2* �6   �� 5      $	��10* �6   �� 5      $	��10* �6   �� 5      $	��10* �6   .+�5   
   ]� $��3��6   .+�5      `� $	��Top=�5      $
��Left=�5      $	��550��5      .�5       c� .@�5!      �� -   5        $
��New ��5!      6,   �� 5"      -   5        $��Load ��5"      6-   �� 5#      $��Save ��6   �� 5$      -   5        $��	Highscore��5$      61   �� 5%      -   5         ��Name$
 exit��5%      $
��Exit��6+   6:   �� 5&      -   5        $ login��5&      $��Log in��6,   6=   �� 5'      -   5        $��LblTime��5'      $��50��6,   �� 5(      -   5        $ Start��5(      $��Start��6,   6<   �� 5)      -	   5        $
 Stop��5)      $
��Stop��6+   6:   �� 5*      -
   5        $ Picture��5*      $��Select Picture��6.   6G   �� 5+      -   5        $ PictureTest��5+      $��Picture Test��62   6I   5,      5.      5/      51      53      