   M S B A M L   `   `   `  ����D  @Desktop01, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Desktop01	Desktop01  5   	       Desktop01.AddUserWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Desktop01     5   	   $	��450��5   E   $	��800��6R     � Title  6	   �� *Title+ �� UpdateSourceTrigger$ PropertyChanged=� � DataContext 5	         Desktop01.AddUserVM  5
   
   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $	��800��5      $	��450��6   $��Center=�6&   $	��Top=�5       �� Orientation$ Vertical=�6%   .+�5      �� $��5q�6    �� TextAlignment$ Center=�6#   $��Center=�6u   $	��200��6�   ��6:   �� *Title+$ PropertyChanged=�6�   �� 5      $��First Name:��6   $��5q�6+   �� 5      $��5q�6V   $��1��6a   ��6   �� *	Firstname+$ PropertyChanged=�6a   �� 5      $��
Last Name:��6   $��5q�6*   $��1��65   �� 5       $��5q�6U   $��1��6`   ��6   �� *
Lastname+$ PropertyChanged=�6`   �� 5!      $
��Age:��6   $��5q�6$   $��1��6/   �� 5"      $��5q�6P   $��1��6[   $��1��6h   ��6   �� *Age+$ PropertyChanged=�6h   �� 5#      $��DateOfBirth:��6   $��5q�6,   $��1��67   �� 5$      $��5q�6X   $��1��6c   $��1��6p   ��6   �� *Dateofbirth+$ PropertyChanged=�6p   �� 5%      $	��GPA��6   $��5q�6#   $��1��6.   �� 5&      $��5q�6P   $��1��6[   $��1��6h   ��6   �� *Gpa+$ PropertyChanged=�6h   �� 5'      $��insert picture��6   $	��100��6.   $
��Left=�6:   $��	5,0,5,-30q�6|   $��3��6�   $��Bottom=�6�   $��2��6�   ��6U   �� *UploadPhotoCommand+6�   �� 5(      $��40��6   $
��Left=�6    $	��100��6;   $	��Top=�6G   $��
120 12 0 0q�6_   ��6s   �� *SelectedImage+$ PropertyChanged=��� 5*      $
��Save��6   $
��0 10q�6D   $��3��6R   $��Bottom=�6_   $��2��6z   ��6$   �� *SaveCommand+6z   5-      5/      50      