   M S B A M L   `   `   `  ����G  Clab1 dataset, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:lab1lab1  5   	       lab1.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:lab1     5   	     � Title$  DataSet��5   	   $	��450��6   $	��800��6&   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��41* �6   �� 5      $
��290* �6    � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      .+�5   
   �� -   5         ��Name$ 
corpButton��5      $��Корпус��6%   $��2��66   $��Stretch=�6F   $��Stretch=�6e   6�   �� 5   
   -   5        $ 
postButton��5      $��Должность��6%   $��1��69   $��Stretch=�6I   $��Stretch=�6h   6�   �� 5   
   -   5        $ staffButton��5      $��Сотрудники��6&   $��Stretch=�6;   $��Stretch=�6Y   6u    � 5   
   -   5          �Name$ 	PageFrame��5        � NavigationUIVisibility$ Hidden=�6#   $��3��6C   $��1��6W   $��4��6d   5      5      