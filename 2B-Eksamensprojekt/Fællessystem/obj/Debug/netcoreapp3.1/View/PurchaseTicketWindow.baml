   M S B A M L   `   `   `  ����H  DFællessystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Fællessystem.ViewFællessystem.View  5   	   -    'Fællessystem.View.PurchaseTicketWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Fællessystem.View     5   	   -   5        $��PurchaseTicket��5   	     � Title$  PurchaseTicket��5   	   $	��640��5	   	   $	��800��5
   	    � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5   	   .��5      �� .+�5   
   �  � RowDefinitions 5      �� 5      $��* �6    �� 5      $��2* �6    �� 5      $��* �6    5      �� 5   
   
���   � �� Orientation$ 
Horizontal=�5      .+�5      �� $��0��5      $	��800��5       $	��150��5!      $!��Images/FællesLogoWhite.png��5"       �� BitmapScalingMode$ HighQuality=�5#      5$      �� 5&   
   
���   �$	��375��5(      $	��800��5)      .+�5+      �  � ColumnDefinitions 5,      �� 5-      $��* �6'   �� 5.      $��* �6'   .+�51      �  52      �� 53      $��* �6(   �� 54      $��* �6(   .+�57      �� ���#9eeb47$��0��59      $��20q�5:      $��30(�5;      $��Fonts/#Raleway)�5<      $��Center=�5=      $
��Bold"�5>      .��6+   Vælg Billet5?      �� 5A      -   5        $��ComboTicketType��5D      $��0��5B      $��0��5C      $��Center=�5E      $	��155��5F      $��30��5G      $��10,8,0,0q�5H       �� MaxDropDownHeight$	 100��5I      	 �� Text$	 Vælg billettype��5J      $��0,20,0,0q�5K      ��5L      �� *TicketTypeVMs+
 �� SelectedItem
 5M      ��  �� Path$ SelectedTicketType���5N      �� 5O      .R�5P   "   �� $ 
Horizontal=�5Q   %   .+�5R   &   �� ��5S   *   `� 5T   .    �� StringFormat$  {0} - {1}kr.��5U   1   .1�5V   2   �� $ TicketTypeName�6:   �� 5W   2   $ TicketPrice�6:   5X   /   5Z   '   5[   #   5\      5^      �� 5a      ���#9eeb47$��1��5c      $��20q�5d      $��30(�5e      $��Fonts/#Raleway)�5f      $��Center=�5g      $
��Bold"�5h      .��6+   	Vælg Mad5i      �� 5k      -   5        $��ComboFoodChoice��5p      $��0��5n      $��1��5o      $��Center=�5q      $	��155��5r      $��30��5s      $��10,8,0,0q�5t      $	 100��5u      $	 	Vælg mad��5v      $��0,20,0,0q�5w      ��5l      �� *FoodChoiceVMs+
 5m      �� $ SelectedFoodChoice���5x      �� 5y      .R�5z   "   �� $ 
Horizontal=�6-   .+�5{   &   �� ��60   �� $ FoodChoiceName�5|   #   5}      5      5�      �� 5�      $��10q�5�      $��1��5�      $	��350��5�      .+�5�      �� ���#9eeb47$��10q�5�      $��30(�5�      $��Fonts/#Raleway)�5�      $
��Left=�5�      $
��Bold"�5�      .��6+   Vælg Tjans5�      	� 5�      -   5         	�Name$ TaskKitchen��5�      $��15q�5�      
�������$��Fonts/#Raleway)�5�      $��Center=�5�      $��30(�5�       d� 	IsChecked$
 TrueY�5�      .��6*   Køkkentjans5�      	� 5�      -   5        $ TaskGarbage��5�      $��15q�5�      
�������$��Fonts/#Raleway)�5�      $��Center=�5�      $��30(�5�      .��6'   Skraldesamler5�      	� 5�      -   5        $ 
TaskDishes��5�      $��15q�5�      
�������$��Fonts/#Raleway)�5�      $��Center=�5�      $��30(�5�      .��6'   
Opvasker5�      5�      5�      5�      �� 5�   
   
���   �.+�5�      �  5�      �� 5�      $��* �6'   �� 5�      $��* �6'   �� 5�      $��* �6'   .+�5�      �� -   5         ��Name$ Accept��5�      $��2��5�      $��20q�5�      $��30(�5�      $
��Bold"�5�         MordernButtonTemplate#��[  5�        ModernButtonStyleIsEnabled#��[ 5�      ��5�      �� $ 
ConfirmCmd���5�      ��  �� ElementName$ PurchaseTicket��.��6O   Betal5�      �� 5�      -   5        $ Decline��5�       �� IsCancel$
 True��5�      $��0��5�      $��20q�5�      $��30(�5�      $
��Bold"�5�      #��[  5�        ModernButtonStyle#��[ 5�      .��6@   	Tilbage5�      5�      5�      5�      5�      