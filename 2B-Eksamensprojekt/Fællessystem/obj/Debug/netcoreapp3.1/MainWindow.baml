   M S B A M L   `   `   `  ����H  DFællessystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:FællessystemFællessystem  5   	       Fællessystem.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Fællessystem     5   	   -   5        $
��Main��5   	     � Title$  
MainWindow��5   	   $	��755��5	   	   $	��800��5
   	    � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5   	   .��5      ��  �� Orientation$ Vertical=�5   	   .+�5   
   �  � RowDefinitions 5      �� 5      $��* �6    �� 5      $��2* �6    �� 5      $��* �6    5      �� 5   
   
���   �$ Vertical=�5      .+�5       �� $��0��5!      $	��800��5"      $	��150��5#      $&�� View/Images/FællesLogoWhite.png��5$       �� BitmapScalingMode$ HighQuality=�5%      5&      �� 5(   
   .+�5)      �� -   5         ��Name$ 
BackGround��5*      $��1��5+      $	��375��5,      $	��800��5-      $
��Fill=�5.      $��0,0,0,0q�5/      $ ��View/Images/BackGround.png��50      51      �� 53   
   
���   �$	��230��55      .+�57      �  � ColumnDefinitions 58      �� 59      $��* �6'   �� 5:      $��* �6'   �� 5;      $��* �6'    5>      �� 5?      $��* �6$   �� 5@      $��* �6$   .+�5C      �� -   5        	 ��Name$	 btn_PruchaseTicket��5E      $��0��5D      $��20q�5F      $��30(�5G      
���   �$
��Bold"�5I         MordernButtonTemplate#��[  5J        ModernButtonStyleIsEnabled#��[ 5K      ��5L      �� 
 �� Path$
 PurchaseTicketCmd���5M      �� .��62   Køb Billet5N      �� 5P      -   5        $	 bt_Voulunteer��5R      $��1��5Q      $��20q�5S      $��30(�5T      
���   �$
��Bold"�5V      #��[  5W      #��[ 5X      ��5Y      �� $
 VolunteerCmd���5Z      �� .��62   Bliv Frivillig5[      �� 5]      -   5        $	 bt_Exit��5`      $��0��5^      $��2��5_      $��20q�5a      $��30(�5b      
���   �$
��Bold"�5d      #��[  5e        ModernButtonStyle#��[ 5f      ��5g      �� *
CloseCmd+��5h      ��  �� ElementName$
 Main��.��6C   Afslut5i      �� 5k      -   5        $	 btn_ViewMemberList��5n      $��2��5l      $��0��5m      $��20q�5o      $��30(�5p      
���   �$
��Bold"�5r      #��[  5s      #��[ 5t      ��5u      �� *ViewMemberListCmd+��5v      �� $
 Main��.��6E   	Medlemmer5w      5x      5y      5z      5{      