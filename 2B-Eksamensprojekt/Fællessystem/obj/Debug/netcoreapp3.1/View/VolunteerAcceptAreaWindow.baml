   M S B A M L   `   `   `  ����H  DFællessystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Fællessystem.ViewFællessystem.View  5      2    ,Fællessystem.View.VolunteerAcceptAreaWindow   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      2local clr-namespace:Fællessystem.View     5      -   5        $��AcceptVolunteer��5        � Title$  VolunteerAcceptArea��5	      $	��640��5
      $	��800��5       � WindowStyle$
 None=�5       � 
ResizeMode$ NoResize=�5       � WindowStartupLocation$ CenterScreen=�5      $��Raleway)�5      .��5      �� .+�5   
   �  � RowDefinitions 5      �� 5      $��* �6    �� 5      $��2* �6    �� 5      $��* �6    5      �� 5   
   
���   � �� Orientation$ 
Horizontal=�5      .+�5       �� $��0��5!      $	��800��5"      $	��150��5#      $!��Images/FællesLogoWhite.png��5$       �� BitmapScalingMode$ HighQuality=�5%      5&      �� 5)   
   
���   �$	��375��5+      $	��800��5,      .+�5.      �  � ColumnDefinitions 5/      �� 50      $��* �6'   �� 51      $��* �6'   .+�54      �� -   5        $��ComboFoodChoice��56      $��1��55      $��Center=�57      $	��155��58      $��30��59      $��10,8,0,0q�5:       �� MaxDropDownHeight$	 100��5;      	 �� Text$	 Vælg madtype��5<      $��0,20,0,0q�5=      
 �� SelectedIndex$
 0��5?      ��5>      �� *FoodChoiceVMs+��5A      �� 5B      .R�5C      �� $ 
Horizontal=�5D   !   .+�5F   "   �� ��5G   %   ��  �� Path$ FoodChoiceName�5H   #   5I      5J      5L      �� 5N      -   5         ��Name$ AreaListView��5Q      $��0��5P      $	��300��5R      $	��155��5S      $��Fonts/#Raleway)�5T      $��0,20,0,0q�5U      $��Center=�5V      ���#9eeb47$��12(�5X      ��5O      �� *AreaListVMs+ �� View 5Z      �� 5[      ! �� ColumnHeaderContainerStyle 5\      �� 5]   "    �� 
TargetType" ��5^   %   .�5_   &   ��  �� Property � {� �� Value$ False��6B   �� 5`   &    � ��$ Stretch=�6L   �� 5a   &    � ��
 ���� 6C   �� 5b   &    � ��$
 Bold"�6C   �� 5c   &    � ��$ 25(�6A   �� 5d   &    � ��
 ���� 6D   �� 5e   &    � ��
 �   �6O   �� 5f   &    � ��$ 0q�6H   5g   #   .P�5j      ��  �� Width$	 145��5k   !    �� DisplayMemberBinding 5l   !   �� *
AreaName+.��6K   	Område5m      5n      5p      5q      5r      �� 5t   
   
���   �.+�5v      �  5w      �� 5x      $��* �6'   �� 5y      $��* �6'   �� 5z      $��* �6'   .+�5}      �� -   5         ��Name$ Accept��5~      $��2��5         MordernButtonTemplate#��[  5�        ModernButtonStyleIsEnabled#��[ 5�      ��5�      �� $ 
ConfirmCmd���5�      ��  �� ElementName$ AcceptVolunteer��.��6P   	Godkend5�      �� 5�      -   5        $
 Back��5�       �� IsCancel$
 True��5�      $��0��5�      $��20q�5�      $��30(�5�      $
��Bold"�5�        ModernButtonStyle#��[ 5�      #��[  5�      .��6G   	Tilbage5�      5�      5�      5�      5�      