   M S B A M L   `   `   `  ����@  <VkWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:VkWPF.WindowsVkWPF.Windows  5   	       VkWPF.Windows.WindowStart   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   U QMahApps.Metro, Version=1.5.0.23, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4f;Controls,http://metro.mahapps.com/winfx/xaml/controls  5   	   'localclr-namespace:VkWPF.Windows  5   	   -   5        (  "MahApps.Metro.Controls.MetroWindow   Name$  StartWindow��5       � Title$ Vk статистика��5	   	   $��463.929��6   $��781.5��60    � WindowStartupLocation$ CenterScreen=�6>   $��1q�5
   	      	GlowBrush
 �   ���5      !� 5   
   -   5        Back��5         RightWindowCommands 5      +  %MahApps.Metro.Controls.WindowCommands  5   
   .@�5      �� -   5         ��Name$ btnUserInfo��5      $��Аккаунт��6,   6>   �� 5      -   5        $ btnChangeUser��5      $+��%Змінити користувача��6.   6L   5      .��5      � $
��auto��6   $
��auto��6   $	��297��6&   $	��300��65    � ColumnDefinitions 5   
   �� 5      $��50 �6   �� 5      .+�5   
    � -   5          �Name$ 	frameMain��5       $��1��6   $
��auto��63   $
��auto��6@     � NavigationUIVisibility$ Hidden=�6N   �� 5    
   .+�5!      �� -   5        	 ��Name$	 spLeft��5!   *   
 K� ZIndex$
 2��6   ���#2D3446$	��200��6O   $��
-150,0,0,0q�6[   ��5"      �� 5#       �� 
TargetType" ��6    �� Triggers 5$      P� 5%       P� Property �@J�IsMouseOver P� Value . . �5&   "   ��  �� Property � �� �� Value
 � � �6?   5'      :� 5(       :� RoutedEvent$ 
MouseEnter��6+   [�5)   "   �� 5*   &   .��5+   *   �� .��5,   .   t�  �� TargetProperty$ Margin�6A    t� From$ 
-150,0,0,0X�6d   	 t� To$ 0,0,0,0X�6v    g� DecelerationRatio$ .9Q�6�    g� Duration$ 0:0:01D�6�   5-   +   5.   '   51      :� 53      $ 
MouseLeave��6+   [�54   "   �� 55   &   .��56   *   �� .��57   .   t� $ Margin�6A   $ 0,0,0,0X�6d   $ 
-150,0,0,0X�6s   $ .9Q�6�   $ 0:0:01D�6�   58   +   59   '   5;      5=      .+�5@      ]� $��Center=�6   $��Right=�67   $	��200��6S   .+�5A      �� -   5         ��Name$ menuMessenger��5A      $��Повідомлення��63   $	��140��6J   $��Palatino Linotype)�6V   6u   5B      ]� 5C      $��Center=�6   $��Right=�67   $	��200��6S   .+�5D      �� -   5        $ menuFriends��5D      $��
Друзі��61   $	��140��6A   $��Palatino Linotype)�6M   6l   5E      ]� 5F      $��Center=�6   $��Right=�67   $	��200��6S   .+�5G      �� -	   5        $ menuStatistic��5G      $��Статистика��63   $	��140��6H   $��Palatino Linotype)�6T   6s   5H      5Q      5R      5S      5U      