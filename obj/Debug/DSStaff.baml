   M S B A M L   `   `   `  ����G  Clab1 dataset, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:lab1lab1  5          lab1.DSStaff   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      $localclr-namespace:lab1     5        N� Title$  DSStaff��5	      .��5      �  � RowDefinitions 5   
   �� 5      $	��41* �6   �� 5      $
��290* �6   �� 5      $	��50* �6   �� 5      $	��50* �6   �� 5      $	��41* �6    � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      .+�5   
   �� -   5         ��Name$ 	addButton��5      $��Добавить��6$   $��4��67   $��Stretch=�6D   $��Stretch=�6c   6   �� 5   
   -   5        $ changeButton��5      $��Изменить��6'   $��4��6:   $��1��6G   $	��Top=�6X   $��39��6�   �� 5   
   -   5        $ deleteButton��5      $��Удалить��6'   $��4��69   $��2��6F   $��Stretch=�6V   $��Stretch=�6u   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 	staffGrid��5      $��1��6&   $��3��63   �� 5   
   -   5         ��Name$ surname��5      $��2��6$   �� 5   
   -   5        $
 name��5      $��2��6!   $��1��6.   �� 5   
   -   5        $ 
middlename��5      $��3��6'   �� 5   
   -   5        $ email��5      $��3��6"   $��1��6/   �� 5    
   -	   5         ��Name$ postKey��5       $��2��6$   $��2��61   5!      5"      