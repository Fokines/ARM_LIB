   M S B A M L   `   `   `  ����F  Blibrary_wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:library_wpflibrary_wpf  5   	       library_wpf.GiveOutBook   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:library_wpf     5   	     � Title$  WpfMessagebox��5   	   $	��160��6    $	��420��5	   	   $	��750��6   $	��750��6(   
������  � SizeToContent$ WidthAndHeight=�5       � WindowStartupLocation$ CenterScreen=�5       � ShowInTaskbar$ False��5       � 
ResizeMode$ NoResize=�6    � WindowStyle$
 None=�5       � Topmost$
 True��6    � AllowsTransparency$
 true��5   	   .��5      � .+�5   
   �� ���#007AFF �� CornerRadius$ 20��6&   $	��527��68   $	��527��6G   $	��176��6V   $	��176��6f   $
��Left=�6v   $	��Top=�6�   ${�False��6�   $	��102��6�   $	��418��6�   ._�5      �� 5      � 5   
   $��210.5��6   $��28��6   $
��Left=�6)   $��Bottom=�6D   
������ $��26.5,0,0,26.5q�6x   .+�5      �� $ 13��6   
�������6'   �� 5      -   5        	 ��Name$	 closeMessBoxButton��5      
������ 
���   �$��Inter)�6]   $��Normal$�6p   $��9(�6�   $��SemiBold"�6�   $��Подтвердить��6�   $��210.5��6�   $��28��6�   $��0,0,0,0q�6�   $��Bottom=�6�   $��0q�6  $
��Left=�67  5      � 5   
   $��210.5��6   $��28��6   $��Bottom=�6)   
������ $��0,0,26.5,26.5q�6]   $��Right=�6t   .+�5      �� $ 13��6   
�������6'   �� 5      -   5        $	 closeMessBoxButton1��5      
������ ���#007AFF$��Inter)�6`   $��Normal$�6s   $��9(�6�   $��SemiBold"�6�   $��Отменить��6�   $��210.5��6�   $��28��6�   $��0,0,0,0q�6�   $��Bottom=�6�   $��0q�6  $��Right=�68  5      �� 5   
   
�������$��Inter)�6'   $��Normal$�6:   $��16(�6M   $��SemiBold"�6[   $
��Left=�6q   $��	40,40,0,0q�6�   $(��"Выберите читателя:��6�   $	��447��6�   $��18��6�   $	��Top=�6�   $
��Wrap=�6�   
 �� TextAlignment$
 Center=�6�   � 5   
   -   5         �Name$ GridForComboBoxReader��5      $��Center=�6.   $��Center=�6K   $	��474��6f   $��26.5,0,26.5,0q�6r   $��28��6�   .+�5      �� $ 13��6   
�������6'   �� 5      -   5         ��Name$ 
BoxReaders��5      $��Inter)�6+   $��Normal$�6>   $��9(�6Q   $��SemiBold"�6^    �� 
IsEditable$
 True��6t   $y�Visible=�6�      ComboBoxStyle1#���   6�   $��Center=�6�   $��Center=�6�   $��0q�6�   ���#CECECE$	��450��6%  $��28��61  $��Center=�6=  $��Center=�6a  5       �� 5!   
   -   5        $��0q�5!      $��Right=�6%   $	��Top=�6A   $��26��6Y   $��22��6d   $��	0,10,10,0q�6�   ��5"      �� 5#       �� ImageSource$ /Frame 2226.png��6   5%      5&      5'      