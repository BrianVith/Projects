   M S B A M L   `   `   `  ����H  DFællessystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Fællessystem.ViewFællessystem.View  5   	   -    'Fællessystem.View.ViewMemberListWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Fællessystem.View     5   	   -   5        $��ViewMemberList��5   	     � Title$  ViewMemberListWindow��5   	   $	��768��5	   	   $
��1024��5
   	    � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5   	   .��5      �� 
���   �.+�5   
   �  � RowDefinitions 5      �� 5      $��* �6    �� 5      $��2* �6    �� 5      $��* �6    5      �� 5   
   
���   � �� Orientation$ 
Horizontal=�5      $��Center=�5      .+�5      �� $��0��6   $��Center=�5      $	��800��5       $	��150��5!      $!��Images/FællesLogoWhite.png��5"       �� BitmapScalingMode$ HighQuality=�5#      5%      �� 5(   
   
���   �$	��500��5)      $
��1024��5*      .+�5+      �  5-      �� 5.      $��* �6$   �� 5/      $��5* �6$   .+�52      � $��100,0,100,0q�6    � ColumnDefinitions 53      �� 54      $��* �6+   �� 55      $��* �6+   �� 56      $��* �6+   .+�59      �� $��0��5:      .+�5<      �� ���#9eeb47$��0��5>      $��10, 20, 10, 0q�5?      $��24(�5@      $��Fonts/#Raleway)�5A      $��Center=�5B      $
��Bold"�5C      .��6/   
Søg Rolle5D      �� 5F      -   5        $��ComboRoleType��5J      $��0��5I      $��Center=�5K      $	��155��5L      $��30��5M       �� MaxDropDownHeight$	 200��5N      	 �� Text$	 Vælg billettype��5O      $��10, 5, 10, 20q�5P      ��5G      �� *	RoleVMs+
 �� SelectedItem
 5H      ��  �� Path$ SelectedRole���5R      �� 5S   "   .R�5T   &   �� $ 
Horizontal=�5U   )   .+�5W   *   �� ��5X   -   �� $ RoleName�5Z   '   5[   #   5]      5^      �� 5`      $��1��5a      .+�5c      �� ���#9eeb47$��0��5e      $��10, 20, 10, 0q�5f      $��24(�5g      $��Fonts/#Raleway)�5h      $��Center=�5i      $
��Bold"�5j      .��6/   Billetter I År5k      �� 5m      -   5        $��ComboTicketFoodChoice��5q      $��0��5p      $��Center=�5r      $	��155��5s      $��30��5t      $	 200��5u      $	 Vælg billettype��5v      $��10, 5, 10, 20q�5w      ��5n      �� *TicketChoiceVMs+
 5o      �� $ SelectedTicketChoice���5y      �� 5z   "   .R�5{   &   �� $ 
Horizontal=�5|   )   .+�5~   *   �� ��5   -   �� $ TicketChoiceName�5�   '   5�   #   5�      5�      �� 5�      $��2��5�      .+�5�      �� ���#9eeb47$��0��5�      $��10, 20, 10, 0q�5�      $��24(�5�      $��Fonts/#Raleway)�5�      $��Center=�5�      $
��Bold"�5�      .��6/   	Madvalg5�      �� 5�      -   5        $��ComboFoodChoice��5�      $��0��5�      $��Center=�5�      $	��155��5�      $��30��5�      $	 200��5�      $	 Vælg billettype��5�      $��10, 5, 10, 20q�5�      ��5�      �� *FoodChoiceVMs+
 5�      �� $ SelectedFoodChoice���5�      �� 5�   "   .R�5�   &   �� $ 
Horizontal=�5�   )   .+�5�   *   �� ��5�   -   �� $ FoodChoiceName�5�   '   5�   #   5�      5�      5�      &   System.Windows.Controls.DataGrid  5�      -   5          Name$ dgMemberList��5�         
IsReadOnly$
 True��5�      $
��True��5�      $
��Auto=�5�      $��1��5�      $	��850��5�      $	��390��5�      $��10q�5�         AutoGenerateColumns$ False��5�      ��5�      �� *MemberListVMs+   Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,  &System.Windows.Controls.DataGridColumn   Header$ Medlemsnavn��6-   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6B   �� *
MemberName+  5�      $ Email��6-    6<   �� *Email+  5�      $ Tlf. nr.��6-    6?   �� *PhoneNumber+  5�      $ Rolle��6-    6<   �� *
RoleName+  5�      $ 	Billetnr.��6-    6@   �� *
TicketID+  5�      $ Fribilletnr.��6-    6C   �� *FreeTicketID+  5�      $ Madvalg��6-    6>   �� *FoodChoiceName+  5�      $ 
Billettype��6-    6A   �� *TicketTypeName+5�      5�      5�      �� 5�   
   
���   �.+�5�      �  5�      �� 5�      $��* �6'   �� 5�      $��* �6'   �� 5�      $��* �6'   .+�5�      �� -   5         ��Name$ Accept��5�      $��2��5�      $��20q�5�      $��30(�5�      $
��Bold"�5�         MordernButtonTemplate#��[  5�        ModernButtonStyleIsEnabled#��[ 5�      ��5�      �� $ 	SearchCmd���5�      �� .��62   Søg5�      �� 5�      -   5        $ Reset��5�      $��1��5�      $��20q�5�      $��30(�5�      $
��Bold"�5�      #��[  5�        ModernButtonStyle#��[ 5�      .��5�   )   	Nulstil5�      �� 5�      -   5        $
 Back��5�      $��0��5�      $��20q�5�      $��30(�5�      $
��Bold"�5�      #��[  5�      #��[ 5�      ��5�      �� $ CloseCmd���5�      ��  �� ElementName$ ViewMemberList��.��6O   	Tilbage5�      5�      5�      5�      5�      