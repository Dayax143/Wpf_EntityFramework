   M S B A M L   `   `   `  ����M  IWpfEntityFramework, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:WpfEntityFrameworkWpfEntityFramework  5   	   #    WpfEntityFramework.MainWindow   5   	   W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:WpfEntityFramework     5   	     � Title$  
MainWindow��5   	   $	��540��6   $
��1063��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      .+�5   
   �� $��Product Name:��6   $
��Bold"�6)   $��5q�6;   $��0��6F   $��0��6S   �� 5   
   -   5        $��txtname��5      $	��150��6!   $��25��6-   
�������
�������$��0��5   %   $��0��62   �� 5   
   $��	Quantity:��6   $
��Bold"�6%   $��5q�67   $��0��6B   $��1��6O   �� 5   
   -   5        $��txtquantity��5      $	��150��6%   $��25��61   
�������
�������$��0��5   %   $��1��62   �� 5!   
   -   5        $��	btnsubmit��5!      $��Submit��6"   $	��120��63   $��35��6?   $
��Bold"�5"      
������
��� d �$��0��5#      $��2��6   6*   �� 5&   
   -   5        $��btnLoad��5&      $��Refresh��6    $	��120��62   $��35��6>   $
��Bold"�5'      
������
��� d �$��0��5(      $��2��6   $��2��6@   $��224,47,188,49q�6T   �� 5*   
   -   5        $��btnProducts��5*      $��Products��6$   $	��120��67   $��35��6C   $
��Bold"�5+      
������
��� d �$��0��5,      $��3��6   $��97,47,49,49q�6D   &   System.Windows.Controls.DataGrid  5-   
   -   5        $��dgvTest��5-      $��1��6"   $��3��6/   $��0��6@   $��3��6P   $��15,14,251,12q�6d      Columns 5/      4  .System.Windows.Controls.DataGridCheckBoxColumn  50      4  .System.Windows.Controls.DataGridComboBoxColumn  51      53      56      57      