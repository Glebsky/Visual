   M S B A M L   `   `   `  ����C  ?FbPoster, Version=1.0.0.1, Culture=neutral, PublicKeyToken=null#clr-namespace:FbPosterFbPoster  5   	       FbPoster.Options   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:FbPoster     5   	     � Title$  Options��5   	   $	��175��6   $	��255��6&   .��5	      �  J� RenderTransformOrigin$ 	0.5,0.691&�6   $��0,0,0,1q�6-    � RowDefinitions 5
   
   �� 5      $
��103* �6   �� 5      $	��33* �6   .+�5   
   �� -   5         ��Name$ label��5      $;��5Количество минут для таймера��6   $
��Left=�6F   $��	10,10,0,0q�6a   $	��Top=�6t   $	��181��6�   $��26��6�   �� 5   
   -   5         ��Name$ 
SecondsBox��5      $
��Left=�6&   $��23��6A   $��	10,36,0,0q�6M    �� TextWrapping$
 Wrap=�6`   $	��Top=�6t   $��49��6�   �� 5   
   -   5         ��Name$ IsTimerWorkCHK��5      $#��Включить таймер��6+   $
��Left=�6E   $��	10,64,0,0q�6`   $	��Top=�6s   $��21��6�   $	��227��6�    d� 	IsChecked$
 TrueY�6�   �� 5   
   -   5        $ OverWindowBox��5      $$��Поверх всех окон��6*   $
��Left=�6E   $��	10,85,0,0q�6`   $	��Top=�6s   $��21��6�   $	��227��6�   $��2��6�   �� 5   
   -   5         ��Name$ button��5      $��Отмена��6!   $
��Left=�62   $��10,5,0,0q�6M   $��1��6_   $	��Top=�6l   $��75��6�   	 �� IsCancel	 . $��25��6�   �� 5   
   -   5        $ AceptBtn��5      $��Применить��6#   $��Right=�67   $��0,5,10,0q�6S   $��1��6e   $��75��6r   
 �� 	IsDefault
 . $��25��6�   $	��Top=�6�   5      5      