   M S B A M L   `   `   `  ����G  CEx27WPFMVVM1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Ex27WPFMVVM1Ex27WPFMVVM1  5   	       Ex27WPFMVVM1.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Ex27WPFMVVM1     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� -   5        $��Label��5
      $
��Left=�6J   $��
170,77,0,0q�6e   $	��Top=�6y   ��6   �� *Text+ �� ElementName$ zugzug��6y   �� 5   
   -   5        $��zugzug��5      $
��Left=�6    $��
262,81,0,0q�6;    �� TextWrapping$
 Wrap=�6O   $��TextBox��6c   $	��Top=�6r   $	��120��6�   �� 5   
   -   5        $��tbLeft��5      $
��Left=�6!   $��170,158,0,0q�6<   $
 Wrap=�6Q   $��TextBox��6e   $	��Top=�6t   $	��120��6�   �� 5   
   -   5        $��tbRight��5      $
��Left=�6!   $��322,158,0,0q�6<   $
 Wrap=�6Q   $	��Top=�6�   $	��120��6�   ��6e   �� *Text+$ tbLeft�� �� Mode$ TwoWay=�6�   �� 5   
   -   5        $��Slider��5      $
��Left=�6   $��130,217,0,0q�6:   $	��Top=�6O   $	��200��6g    � Maximum$	 100Q�6s    � Value$ 0Q�6�   �� 5   
   -   5        $��tbSlider��5      $
��Left=�6"   $	��Top=�6=   $��360,220,0,0q�6U   $��40��6j   ��6u   ��  �� Path$ Value�$ Slider�� �� UpdateSourceTrigger$ PropertyChanged=��� 5   
   $
��Left=�65   $��180,279,0,0q�6P   $	��Top=�6e   ��6   �� $ MyLabelText�6e   �� 5   
   -   5        $��Update Label Text��5      $
��Left=�6-   $��290,265,0,0q�6H   $	��Top=�6]   6u   �� 5   
   $
��Left=�6   $��135,309,0,0q�6-   $
 Wrap=�6B   $	��Top=�6u   $	��120��6�   ��6V   �� *MyTextBoxText+6�   �� 5   
   -   5        $��Update TextBox Text��5      $
��Left=�6/   $��289,308,0,0q�6J   $	��Top=�6_   6w   �� 5   
   $
��Left=�6   $��170,363,0,0q�6/   $
��Wrap=�6D   $	��Top=�6�   $	��100��6�   ��6X   �� *MyTextBoxText+$ PropertyChanged=�6�   5       5!      