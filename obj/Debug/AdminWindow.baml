   M S B A M L   `   `   `  ����D  @CinemaApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:CinemaApp	CinemaApp  5   	       CinemaApp.AdminWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:CinemaApp     5   	     � Title$5  /Администратор кинотеатра��5   	   $	��500��6*   $	��900��67    � WindowStartupLocation$ CenterScreen=�5	   	    � 
ResizeMode$ NoResize=�5
   	    � 	Resources 5      3  -System.Windows.Media.Effects.DropShadowEffect   ShadowEffect   
BlurRadius   ShadowDepth   Color  LightShadowEffect  MainGradient �� 
StartPoint �� EndPoint	 � Color
 � Offset  ButtonGradient  ButtonHoverGradient  ModernButtonStyle �� 
TargetType �� Property �� Value �� 
TargetType ��Name �� CornerRadius �� Triggers P� Property P� Value �� 
TargetName  ModernTextBox �� Padding ��Name  ModernPasswordBox��%�	  &	        &	 >     &	 |     &	     &	 �    &	 8    7  7  7  &	 �    &	       5   
   $ 15Q�60   $ 5Q�6@   $ 	#40000000��6P     5   
   $ 10Q�65   $ 2Q�6E   $ 	#40000000��6U   �� 5   
   $	 0,0&�63   $	 1,1&�6D   .��5      � $	 #2b5876��6   $
 0Q�6+   � 5      $	 #4e4376��6   $
 1Q�6+   5      �� 5   
   $	 0,0&�65   $	 1,1&�6F   .��5      � $	 #667eea��6   $
 0Q�6+   � 5      $	 #764ba2��6   $
 1Q�6+   5      �� 5   
   $	 0,0&�6:   $	 1,1&�6K   .��5      � $	 #764ba2��6   $
 0Q�6+   � 5      $	 #667eea��6   $
 1Q�6+   5      �� 5    
   " ��6*   .�5!      ��  � ��8   6+   �� 5"       � ��
 �����6+   �� 5#       � ��
 ���� 6,   �� 5$       � ��$ 0q�60   �� 5%       � ��$
 15,8q�6(   �� 5&       � ��$ 16(�6)   �� 5'       � ��$ SemiBold"�6+   �� 5(       �@�Cursor$
 Hand��6'   �� 5)       �@J�Effect8  6'   �� 5*       � �� 5+      �� 5,      " ��6&   .R�5-      �� $ border��6!   #��z��5.   !   #��z��5/   !   #��z��50   !   $ 8��51   !   ._�52      �� $��Center=�6/   $��Center=�53   /   54       55      P� 56       �@J�IsMouseOver . . �57   "   �� $ border��6)   8   � ��6S   �� 58   "    �@J�Effect 59   &     5:   *   $ 15Q�6;   $ 3Q�6K   $ 	#60000000��6[   5<   #   5=      P� 5>       � �� . . �5?   "   �� $ border��6)    �@J�Opacity$	 0.8Q�6P   5@      5B      5D      5E      �� 5G   
   " ��6   .�5H      ��  � �� �#1E1E2D6+   �� 5I       � ��
 �����6+   �� 5J       � �� �#667eea6,   �� 5K       � ��$ 0 0 0 2q�60   �� 5L       � ��$ 5q�6(   �� 5M       � ��$ 16(�6)   �� 5N       �@��
CaretBrush
 �����6+   �� 5O       � �� 5P      �� 5Q      " ��6&   .R�5R      �� #��z��6!   #��z��5S   !   #��z��5T   !   $ 4��5U   !   # z��5V   !   ._�5W      �� $ PART_ContentHost��6+   5X      5Y      5[      5\      �� 5^   
   " G�6   .�5_      ��  � �� �#1E1E2D6+   �� 5`       � ��
 �����6+   �� 5a       � �� �#667eea6,   �� 5b       � ��$ 0 0 0 2q�60   �� 5c       � ��$ 5q�6(   �� 5d       � ��$ 16(�6)   �� 5e       �@G�
CaretBrush
 �����6+   5f      5g      .��5i      � ��5j   
   �� 5k      $	 0,0&�6"   $	 1,1&�63   .��5l      � $	 #0f0c29��6   $
 0Q�6/   � 5m      $	 #302b63��6   $	
 0.5Q�6/   � 5n      $	 #24243e��6   $
 1Q�6/   5o      .+�5s   
   �� $��0��6   $	��350��6!   ���#1A1A2E$ 10��6B   $��30q�6T    J� Effect# [  5t      ._�5u      �� $��Center=�6   $��20q�64   .+�5v      �� $2��,Вход для администратора��6   $��24(�5w      $
��Bold"�5x      
�������$��0,0,0,30q�5z      $��Center=�5{      �� 5}      $��
Логин��6   $��16(�5~      ���#A0A0C0$��5,0,0,5q�5�      �� 5�      -   5         ��Name$ LoginTextBox��5�      #��[ 5�      $��50��5�      �� 5�      $��Пароль��6   $��16(�5�      ���#A0A0C0$��5,15,0,5q�5�      G� 5�      -   5         G�Name$ PasswordBox��5�      #��[ 5�      $��50��5�      �� 5�      -   5        $��
Войти��5�      #��[ 5�      $��0,30,0,0q�5�      $��45��5�      5�      �� 5�      $)��#Кинотеатр 'Премиум'��6   $��14(�5�      ���#606080$��0,40,0,0q�5�      $��Center=�5�      5�      5�      �� 5�   
   $��1��6   
������ $��0,0,30,0q�6:   ._�5�      � .+�5�      �� $(��"/image/SnapBG.ai_1744548380185.png��6   $��UniformToFill=�5�       J� Opacity$	 0.9Q�5�      �� 5�      ���	#80000000$ 10��60   ._�5�      �� $��Center=�6!   $��Center=�6<   $��20q�6Y   .+�5�      �� $&�� Добро пожаловать!��6$   $��28(�5�   $   $
��Bold"�5�   $   
�������$��0,0,0,10q�5�   $   �� 5�      $>��8Панель управления кинотеатром��6$   $��18(�5�   $   ���#CCCCCC$
��Wrap=�5�   $   $	��350��5�   $   $��Center=�5�   $    �� TextAlignment$ Center=�5�   $   5�      5�      5�      5�       � ColumnDefinitions 5�   
   �� 5�      $
��Auto �6   �� 5�      5�      5�      