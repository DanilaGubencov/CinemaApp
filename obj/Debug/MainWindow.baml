   M S B A M L   `   `   `  ����D  @CinemaApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:CinemaApp	CinemaApp  5   	       CinemaApp.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:CinemaApp     5   	     � Title$>  8Панель управления кинотеатром��5   	   $	��740��6/   $
��1140��6<    � WindowStartupLocation$ CenterScreen=�5	   	    � 
ResizeMode$ NoResize=�5
   	    � 	Resources 5         SidebarGradient �� 
StartPoint �� EndPoint � Color � Offset  MainBgGradient  ButtonHoverGradient  ModernButtonStyle �� 
TargetType	 �� Property
 �� Value �� 
TargetType ��Name �� CornerRadius �� Padding �� Triggers P� Property P� Value �� 
TargetName3  -System.Windows.Media.Effects.DropShadowEffect   
BlurRadius   ShadowDepth   Color��%�  &	        &	 �     &	 (    &	 �    7  '�� �    �� 5   
   $	 0,0&�66   $	 1,1&�6G   .��5      � $ #1a162a��6   $ 0Q�6+   � 5      $ #2a1e3a��6   $ 1Q�6+   5      �� 5   
   $	 0,0&�65   $	 1,1&�6F   .��5      � $ #0f0c29��6   $ 0Q�6+   � 5      $ #302b63��6   $ 1Q�6+   5      �� 5   
   $	 0,0&�6:   $	 1,1&�6K   .��5      � $ #667eea��6   $ 0Q�6+   � 5      $ #764ba2��6   $ 1Q�6+   5      �� 5   
   " ��6*   .�5      �� 	 � ��

 ���� 6+   �� 5       	 � ��

 �����6+   �� 5!      	 � ��

 ���� 6,   �� 5"      	 � ��$
 0q�60   �� 5#      	 � ��$

 15,8q�6(   �� 5$      	 � ��$
 16(�6)   �� 5%      	 � ��$
 Medium"�6+   �� 5&      	 �@�Cursor$

 Hand��6'   �� 5'      	 � ��$

 Left=�6;   �� 5(      	 � ��
 5)      �� 5*      " ��6&   .R�5+      �� $ border��6!   #��z��5,   !   #��z��5-   !   #��z��5.   !   $ 5��5/   !   $ 15,10q�50   !   ._�51      �� #��z��6/   $��Center=�52   +   53       54      P� 55       �@J�IsMouseOver . . �56   "   �� $ border��6)   	 � ��
 �#3a2e5a6S   �� 57   "   	 � ��
 �#aaccff6?   �� 58   "   $ border��6)   	 �@J�Effect
 59   &     5:   *   $ 10Q�6;   $ 0Q�6K   $ 	#50667eea��6[   5<   #   5=      P� 5>       � �� . . �5?   "   �� $ border��6)   8
   	 � ��6S   �� 5@   "   	 � ��

 �����6?   5A      5C      5E      5F      �� 5H   
   " ��6   .�5I      �� 	 � ��

 �����6+   �� 5J      	 � ��$
 18(�6)   �� 5K      	 � ��$

 Bold"�6+   �� 5L      	 � ��$
 10q�6(   5M      5N      .��5P      � ��5Q   
   �� 5R      $	 0,0&�6"   $	 1,1&�63   .��5S      � $ #0f0c29��6   $ 0Q�6/   � 5T      $ #302b63��6   $ 1Q�6/   5U      .+�5Y   
   �� $	��220��6   #��[  6   $ 	0 15 15 0��6K   $��	0,0,920,0q�6d   ._�5Z      � .+�5[      �� $(��"/image/SnapBG.ai_1744548380185.png��6   $��UniformToFill=�5\       J� Opacity$	 0.2Q�5]      $��-50,-30,-50,0q�5^      $	��Top=�5_      $	��222��5`      �� 5b      $��Center=�6   $��10q�68   .+�5c      �� $��Меню��6    $��20(�5d       $
��Bold"�5e       ���#aaccff$��	15,0,0,20q�5g       �� 5i      -   5        $!��Список фильмов��5i      #��[ 5j      $��0,0,0,5q�5l      �� 5n      -   5        $!��Добавить фильм��5n      #��[ 5o      $��0,0,0,5q�5q      �� 5s      -   5        $-��'Список пользователей��5s      #��[ 5t      $��0,0,0,5q�5v      �� 5x      -   5        $��
Выйти��5x      #��[ 5y      $��0,30,0,0q�5{      ���#ff99995|      5}      5~      5       � 5�   
   -   5          �Name$ 	MainFrame��5�      
������ $��
230,50,0,2q�5�        � NavigationUIVisibility$ Hidden=�5�       J� Effect 5�        5�      $ 15Q�6#   $ 0Q�63   $ 	#40000000��6C   5�      �� 5�   
   ���#1a162a$��50��6&   $	��Top=�62   ._�5�      �� $)��#Кинотеатр 'Премиум'��6   
�������$��Center=�5�      $��Center=�5�      $��22(�5�      $
��Bold"�5�      5�      5�      5�      