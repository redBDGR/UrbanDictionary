   M S B A M L   `   `   `  ���� J  FUrbanDictionary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:UrbanDictionaryUrbanDictionary       UrbanDictionary.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     /localclr-namespace:UrbanDictionary     -     � Title$  UrbanDictionary�� � 
ResizeMode$ CanMinimize=�$��542.7��$��649.675�� � SizeToContent$ Height=�.���� .+��� $��10q�
�������$��1q����	#FFF3F3F3._��� $��10q�.+��  � ColumnDefinitions �� $
��413* ��� $
��209* �.+��� -    ��Name$ inputTextBox��$
��Left=�$��23�� �� TextWrapping$
 Wrap=�$�� ��$��Center=�$��14(�$��0����.  $	��390��$��
0, 0, 0, 0q�.����O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem �� 6sys&clr-namespace:System;assembly=mscorlib      �� 
TargetType" �� �� 	Resources    CueBannerBrush j� 
AlignmentX	 j� 
AlignmentY
 j� Stretch !� Visual��%U   &	        !� $
 Left=�$	 Center=�$

 None=� �� $��  Search��
������� �� Triggers P�  P� Property � �� �� Empty P� Value# Z . ���  �� Property � �� �� Value# [  P�  � �� Z� . ���  � ��# [  P�  �@J�IsKeyboardFocused . . ���  � ��
 �����.���� -    ��Name$ searchButton��$��1��$��Search��$��
10,0,0,-18q� �� 	IsDefault . �� $��
0, 5, 0, 5q�$��14(�.��Found Definitions:�� -    ��Name$ definitionsComboBox��$��
0, 0, 0, 0q�{�.  ��. $��Visible=�$��14(�$��0���� $��10, 0, 10, 10q�
�������$��1q����	#FFF3F3F3._��� $��10, 0, 10, 10q�.+��� $��14(�.��Definition:�� -    ��Name$ definitionTextBox��$
��Auto��$	��135��$
��0, 0q�" �� VerticalScrollBarVisibility$ Visible=� �� 
IsReadOnly .  �� IsReadOnlyCaretVisible .   �� IsDocumentEnabled . $��14(��� $��
0, 5, 0, 5q�$��14(�.��
Example:�� -   $ exampleTextBox��$
��Auto��$	��135��$
��0, 0q�$ Visible=� .  .   . $��14(�� $��	0,0,419,0q� �� �� .+��� $��
1, 0, 1, 1q�
�������$��0��
�������._��  �� �� .+��� -    ��Name$ 	likeImage��$��20��$��0��$��Images\Like.png���� -    ��Name$ 
likesLabel��$��1��$��14(�$��0���� $��
0, 0, 1, 1q�
�������$��1��
�������._��  �� �� .+��� -	   $ dislikeImage��$��20��$��0��$��Images\Like.png�� J� RenderTransformOrigin$ 0.5,0.5&�z�V� .~��� �� ��  �� Angle$	 180Q�T� �� -
   $ dislikesLabel��$��1��$��14(�$��0��