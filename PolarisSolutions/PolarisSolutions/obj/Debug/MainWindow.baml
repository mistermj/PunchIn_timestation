   M S B A M L   `   `   `  ����K  GPolarisSolutions, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:PolarisSolutionsPolarisSolutions  5   	   H DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5   	   !    PolarisSolutions.MainWindow   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:PolarisSolutions     5   	   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	      AccentColorBrush(  "MahApps.Metro.Controls.MetroWindow    	GlowBrush#  �   5   	      	TitleCaps .   � 
ResizeMode$ CanResizeWithGrip=�5
   	    � WindowStartupLocation$ CenterScreen=�5   	    � Title$ Polaris Solutions��5   	   $	��350��5   	   $	��550��6      RightWindowCommands 5      +  %MahApps.Metro.Controls.WindowCommands  5   
   .@�5      �� -   5        $��LoadAndPunchIn��5      .��5   2   QuickPunchIn6@   5      .��5      �  � RowDefinitions 5   
   �� 5      6   �� 5      $��35 �6   6*    � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   .+�5    
   �� $��3��6   $��2��6!   #���   66   .@�5!      �� $
��Left=�5"      $��Polaris Powered Solutions��5#      
�������$��Yu Gothic UI Light)�5%      $
��Bold"�5&      $��15(�5'      $��12 0 0 0q�5(      5*      5+      �� 5.   
   $��0��6   $��0��5/       �� Orientation$ Vertical=�50      $��20 40q�51      .+�52      �� $��10 30 10 20q�6   .��6*   Enter User Name54      �� 55      -   5        $��username��56      $��	10 0 10 0q�55      56   (   �� 58      $��10 30 10 20q�6   .��6*   Enter Password5:      �� 5;      -   5        $��password��5<      $��	10 0 10 0q�5;      5<   (   5>      �� 5@   
   $��0��6   $ Vertical=�5A      $��1��5B      $��
20 60 60 0q�5C      .+�5E      �� -   5        $��punchIn��5L      $��10 10q�5E      $��	0 20 0 20q�5F      $��65��5G      	 � Cursor$
	 Hand��5H      
���   ����#607D8B
���   �$��2q�5M      .��6?   
Punch In5O      �� 5P      �� 5Q      -   5        $��punchOut��5T      $��10 10q�5Q      $��65��5R      $
	 Hand��5S      
���   ����#607D8B
���   �$��2q�5X      .��6@   	Punch Out5Z      5\      5^      5`      