   M S B A M L   `   `   `  ����M  IWpfEntityFramework, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:WpfEntityFrameworkWpfEntityFramework  5   	   &     WpfEntityFramework.manageDetails   5   	   W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:WpfEntityFramework     5   	     � Title$  manageDetails��5   	   $	��450��6   $	��800��6,   .��5	      �� 
�������$��2q�6     �� CornerRadius$ 10��64    �� Padding$ 10q�6F   ._�5
   
   �  � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    .+�5      ��  �� Orientation$ Vertical=�6   $��0��60   $��10q�6=   .+�5      �� $��Product Name:��6   $
��Bold"�61   $��5q�6C   �� 5      -   5        $��txtName��5      $	��200��6)   �� 5      $��	Quantity:��6   $
��Bold"�6-   $��5q�6?   �� 5      -   5        $��txtQuantity��5      $	��200��6-   5      �� 5      $ 
Horizontal=�6   $��1��62   $��10q�6?   $��Center=�6K   .+�5      �� -   5        $��Save New��5      $	��100��6,   68   �� 5       -   5        $��Update Next��5       $	��100��6/   6;   �� 5!      -   5        $��Delete��5!      $��80��6*   65   �� 5"      -   5        $��Clear��5"      $��80��6)   64   5#      �� 5&      $ Vertical=�6   $��2��60   $��10q�6=   .+�5'      �� $��Find by Name:��6   $
��Bold"�61   $��5q�6C   �� 5(      -   5        $��	txtSearch��5(      $	��200��6+   �� 5)      -   5        $��Search��5)      $	��100��6*   66   5*      �� 5-      $ 
Horizontal=�6   $��3��62   $��10q�6?   .+�5.      �� -	   5        $��FindPrevious��5.   =   $��Find Previous��6   $	��120��61   6Q   �� 5/      -
   5        $��FindNext��5/   9   $��	Find Next��6   $	��120��6-   6I   50      �� 53      $��Audit User:��6   $
��Bold"�6+   $��4��6=   $��
11,5,665,5q�6J   �� 54      -   5        $��lblAuditUser��54      $��$��6,   $��4��65   $��116,10,391,10q�6B   �� 57      $ Vertical=�6   $��5��60   $��10q�6=   .+�58      �� -   5        $��UploadImage��58   0   $��Upload Image��6   $	��150��6C   6O   �� 59      -   5        $��
imgProduct��59      $	��150��6*   $	��150��66   $��UniformToFill=�6C   5;      5<      5=      5>      