   M S B A M L   `   `   `  ����	  wpfui    
wpfui.open   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  OpenAI WPF App��5   	   $	��700��6    $
��1100��6-   .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5
   
   �� $��0��6   $
��Auto=�6$   .��5      �� -   5         ��Name$ ChatTextBox��5       �� 
IsReadOnly$
 True��6+   $��10q�6=   $
��Bold"�6I   5      �� 5      $+��%choose one button and Enter your Task��6   $
��Bold"�6B   $��Center=�6T   $��25(�6q   ���	#FF2F4F4F6   �� 5   
   $��1��6    �� Orientation$ 
Horizontal=�6"   $��10q�6;   .+�5      �� -   5        $ UserInputTextBox��5      $	��250��60   $	��100��6<   $��0,0,10,0q�6I   �� 5      -   5         ��Name$ button��5   &   $��Stress��6   $	��250��66   $	��100��6B   ���	#FF2F4F4F
�������$
��Bold"�6y   $��30(�6�   �� 5      -   5        $ button1��5   (   $��MakeMove��6   $	��250��69   $	��100��6E   ���	#FF2F4F4F
�������$
��Bold"�6|   $��30(�6�   �� 5      -   5        $ button2��5   %   $��Skill��6   $	��250��66   $	��100��6B   ���	#FF2F4F4F
�������$
��Bold"�6y   $��30(�6�   5      5      5      