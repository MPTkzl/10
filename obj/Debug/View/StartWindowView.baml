   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$!  Стартовое окно��5	   	   $	��158��6    $	��206��60    � WindowStyle$
 None=�5
   	    � 
ResizeMode$ NoResize=�6   $	��678��63   $
��1122��6@   .��5      �  � RowDefinitions 5      �� 5   
   $��1* �6   �� 5   
   $��2* �6   �� 5   
   $��1* �6    � ColumnDefinitions 5      �� 5   
   $��1* �6   �� 5   
   $��2* �6   �� 5   
   $��1* �6   ��5      �� 5   
      backgroundImage �� ImageSource# [  6   .+�5      �� $��3��6    �� Orientation$ 
Horizontal=�6!   $��Right=�6:   $	��Top=�6V   .+�5      �� ���	#00000000���#0000  mainFontFamily#��[ 6@   $��_��6m   $��10(�6y   $��Center=�6�   $��Center=�6�   �� 5      ���	#00000000���#0000#��[ 6@   $��6(�6m   $��Center=�6z   $��Center=�6�   .��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 
CropSquare=�6*   5       �� 5!      ���	#00000000���#0000$��x��6@   #��[ 6L   $��10(�6y   $��Center=�6�   $��Center=�6�   5"      � 5#   
   $��1��6   $��1��6     	mainColor#���  6,    J� Opacity$
 0.79Q�6U    5$   
   �� 5%      $��3* �6   �� 5&      $
��auto �6   �� 5'      $
��3.5* �6   �� 5(      $
��3.5* �6   .+�5+      �� $��0��6   $��	SunClouds��6%   #��[ 66   $��30(�6c   $��Center=�6q   $��Center=�6�   
�������6�   �� 5-   
   $��1��6   $��Center=�6!   $��Center=�6>   
�������$	��350��6l   $	��350��6{   �� 5/      $��2��6   $��10q�6#   $	��350��6/   $	��350��6>   $��45��6J     secondColor#���  6V   
�������$��30(�6�   #��[ 6�   	 �� TextAlignment$	 Center=�6�   $��Center=�6�   $��Center=�6  )  #MaterialDesignThemes.Wpf.HintAssist
   Hint$
 Ваш город��6  .  (MaterialDesignThemes.Wpf.TextFieldAssist   HasClearButton .  �� 
CaretBrush �	#00000000  
hoverColor �� SelectionBrush# �  6�  �� 51      $��3��6   $��10q�6"   $	��350��6.   $	��350��6=   $��45��6I   #���  6U   
�������$��Узнать погоду��6�   $��30(�6�   #��[ 6�   ���	#000000006�   53      55      56      