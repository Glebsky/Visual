   M S B A M L   `   `   `  ���� C  ?FbPoster, Version=1.0.0.1, Culture=neutral, PublicKeyToken=null#clr-namespace:FbPosterFbPoster      FbPoster.MainWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     (localclr-namespace:FbPoster       � Title$  	FB Poster��$	��281��$	��395�����	#FFE9EBEE � 
ResizeMode$ CanMinimize=� � Icon$ FbPostericon.ico��.���  � RowDefinitions �� $
��251* � � ColumnDefinitions �� $
��208* ��� $
��181* �.+��� ���	#FF3B5998$��40�����	#FFD7D8DB$	��Top=�$��2�� �� StrokeMiterLimit$ 13Q�$��0�� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 10Q�   	Direction$	 278Q�	   Opacity$	 0.365Q�
   ShadowDepth$
 1Q��� -    ��Name$ image��$
��Left=�$��30��$��20,5,0,0q�$	��Top=�$��30��$��Resource/fbLogo.png��$
��Fill=��� -    ��Name$ label��$��	FB POSTER��$
��Left=�$��53,3,0,0q�$	��Top=�
�������$��18(�$
��Bold"�$��Verdana)�$��32��$	��122���� -    ��Name$ PostBack��
�������$��Right=�$��0,51,8,6q����	#FFD7D8DB$��0��$ 13Q�$	��190�� �� RadiusX$ 5�� �� RadiusY$ 5��   $ 6Q�$	 307Q�$		 0.3Q�$
 1Q��� -   $ StatBack��
�������$��	0,51,0,73q����	#FFD7D8DB$��0��$ 13Q�$ 5��$ 5��$��Center=�$	��161��$��1��   $ 6Q�$	 307Q�$		 0.3Q�$
 1Q��� -   $ 	TimerBack��
�������$��Center=�$��61��$��0,0,0,6q����	#FFD7D8DB$��0��$ 13Q�$��Bottom=�$	��161��$ 5��$ 5��$��1��   $ 6Q�$	 307Q�$		 0.3Q�$
 1Q��� -   $ label1��$��
Посты��$
��Left=�$��	15,49,0,0q�$	��Top=����	#FF162643$��Segoe UI Historic)�$��14(�$��29��$��50���� -   $ label1_Copy��$��Статистика��$
��Left=�$��	15,49,0,0q�$	��Top=����	#FF162643$��Segoe UI Historic)�$��14(�$��1��$��29��$��80���� -   $ label1_Copy2��$��Таймер��$
��Left=�$��	15,0,0,41q�$��Bottom=����	#FF162643$��Segoe UI Historic)�$��14(�$��1�� J� RenderTransformOrigin$ 0.479,0.319&�$��29��$��58���� -	    ��Name$ CopyLink��$)��#Скопировать ссылку��$��Center=�$��0,58,0,0q�$��Center=�$	��146��$��30�����	#FF4267B2
�������$��1��$
��Bold"��� -
   $ daylabel��$��День��$��	20,0,0,20q����	#FF162643$��Segoe UI Historic)�$��1��$��10(�$��51��$��23��$
��Left=�$��Center=��� -   $ LabelLink1_Copy1��$��Неделя��$
��Left=�$��	65,0,0,20q�$��Center=����	#FF162643$��Segoe UI Historic)�$��1��$��10(�$��51��$��23���� -   $ LabelLink1_Copy2��$��
Месяц��$
��Left=�$��
118,0,0,20q�$��Center=����	#FF162643$��Segoe UI Historic)�$��1��$��10(�$��51��$��23���� -   $ StatDay��$��День��$
��Left=�$��20,5,0,0q�$��Center=����	#FF162643$��Segoe UI Historic)�$��1��$��50��$
��Bold"�$��14(�$��30���� -   $ StatWeek��$��Неделя��$��66,114,0,108q�$��Center=����	#FF162643$��Segoe UI Historic)�$��1��$
��Bold"�$��14(�$��30��$
��Left=�$��50���� -   $ 	StatMonth��$��
Месяц��$
��Left=�$��	117,5,0,0q�$��Center=����	#FF162643$��Segoe UI Historic)�$��1��$��50��$
��Bold"�$��14(�$��30���� -    ��Name$ LinkBox��$��1��$��0,0,0,65q�$	��146��$��Center=�$��Center=�$��30��$��Center=�$��30���� -    ��Name$ stack��$��Center=�$��0,73,0,0q�$	��170��$	��Top=�$	��166��.+��� -   $ PostBox��$��30��$��0,0,0,5q�$��1q� �� SelectedIndex$ 0�����	#FF4586E4���	#FF8EB9E4$��16(�$��Center=�$	��170��$	��Top=��� -    ��Name$ PostMessage��$��Center=�$��86��$��0,0,0,2q� �� TextWrapping$
 Wrap=�$	��Top=�$	��170�����	#FF717FA6$��1q�$��10(��� -   $ PostButton4��$%��СКОПИРОВАТЬ ПОСТ��$��35�����	#FF4267B2
�������$��9(�$��0q�$��Center=�$	��170��$	��Top=�$
��Bold"��� -   $ 
TimerLable��$��10 : 00��$��Center=�$��0,0,0,5q�$��Bottom=����	#FFE42A2A$��Segoe UI Black)�$��30(�$��1��$ 
0.495,0.48&�$
��Bold"�$��50��$	��107���� -   $ 	TimerStop��$��1��$��Right=�$��26��$��0,7,67,0q�$	��Top=�$��26��$��Resource/stopTime.png�� � Cursor$
 Hand�� J� SnapsToDevicePixels . }�. $
��Fill=��� -   $ Preferences��$��1��$��Right=�$��0,7,30,0q�$��26��$��Resource/preferences.png��$
 Hand�� . }�. $	��Top=�$
��Fill=�$��26���� -   $ MiniBtn��$��1��$��Right=�$��26��$��	0,7,104,0q�$	��Top=�$��26��$��Resource/minimize.png��$
 Hand�� . }�. $
��Fill=��� -   $ LinkBtn��$��1��$��Right=�$��16��$��	0,54,14,0q�$	��Top=�$��16��$��Resource/link.png��$
 Hand��