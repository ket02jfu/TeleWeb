   M S B A M L   `   `   `  ����C  ?teleWeb2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:teleWeb2teleWeb2  5   	       teleWeb2.SignInWindow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   "localclr-namespace:teleWeb2  5   	     N� Title$  SignInWindow��5
   	   .��5      � ���	#FF919191 � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!    � RowDefinitions 5   
   �� 5      $	��64* �6   6+   �� 5      $	��64* �6   6+   �� 5      $	��64* �6   6+   �� 5      $	��64* �6   6+   �� 5      $	��75* �6   6+   .+�5   
   �� $��1��6   $��73,35,137,47q�6$   $��1��6:   $��Teleweb Вход��6G   ���	#FF673AB7$��24(�6r   $
��Bold"�6�   $��34��6�   $��Center=�6�   $��
Bauhaus 93)�6�   $��2��6�   �� 5   
   $��1��6   $��1��6$   $��4��61   $��3��6B    K� ZIndex$ -1��6V   
������� �� RadiusY$ 30��6u    �� RadiusX$ 30��6�   $��50,0,50,113q�6�    J� Effect 5       3  -System.Windows.Media.Effects.DropShadowEffect  5!         
BlurRadius$ 10Q�6#      Color$ MediumPurple��63   	   ShadowDepth$	 0Q�6H   5#      �� 5$   
   -   5        
 ��Name$
 textBoxLogin��5$      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 
Логин��6(   $��1��6P   $��
73,3,73,77q�6`   $��2��6t   $��3��6�    %  !MaterialDesignFloatingHintTextBox#��[  6�   $��36��6�   $��Center=�6�   �� 5%   
   -   5        $
 passBox��5%      $ Пароль��6$   $��1��6L   $��2��6\   $��3��6i   $��
73,76,73,3q�6}   #��[  6�   $��37��6�   $��Center=�6�    J� RenderTransformOrigin$ 0.499,0.446&�6�   �� 5&   
   -   5         ��Name$ 	regButton��5&      $��
0,31,73,47q�6%   $��1��6:   $ 0.5,0.5&�6G   $��2��6g   ���	#FF6B51AE
�������$��20(�6�   $��38��6�   $��Center=�6�   $��Right=�6�   $	��148��6	  $��2��6,  ��6�   Z� .��6@  Регистрация6M  )  #MaterialDesignThemes.Wpf.TimePicker  5'   
   $��
0,66,73,10q�6$   $��Stretch=�68   $��20(�6T   $��3��6b   $��3��6r   $ 0.503,0.471&�6   �� 5(   
   -   5        $ 	SignInbtn��5(      $"��Войти в кабинет��6'   $��1��6A   $��
73,71,0,10q�6Q   $��3��6e   ���	#FF673AB7���	#FF673AB7$��15(�6�   $��35��6�   $��Center=�6�    � Cursor$
 Hand��6�   $
��Left=�6�   $	��296��6  $��2��6;  ��6�   Z� 6;  5+      5,      