   M S B A M L   `   `   `  ���� C  ?Dark Hub, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:Dark_HubDark_Hub      Dark_Hub.InjectionWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     (localclr-namespace:Dark_Hub     -     �Name$  window�� � 
ResizeMode$ NoResize=� � Topmost .  � WindowStyle$
 None=� � AllowsTransparency .  � WindowStartupLocation$ CenterScreen=� � Title$ 
MainWindow��$��217.286��$��513.542�����	#FF13151B���	#FFBEBEBE � 	Resources    loading �� TargetProperty	 �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame
 O� KeyTime O� Value   EasingFunction/  )System.Windows.Media.Animation.CircleEase7  1System.Windows.Media.Animation.EasingFunctionBase   
EasingMode.  (System.Windows.Media.Animation.CubicEase  FocusVisual �� Property �� Value J� SnapsToDevicePixels �� StrokeDashArray  Button.Static.Background �� Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background 	 Button.Disabled.Border 
 Button.Disabled.Foreground  customButton �� 
TargetType �� 
TargetType ��Name ��Name �� Triggers P� Property P� Value N� EnterActions g� Duration g� FillBehavior g� RepeatBehavior	 �� To g� AutoReverse  N� ExitActions  ButtonStyle1! � 	Resources  Key" �� 
TargetName  Closing��%n	  &	        &	 �    &	     &	 2    &	 G    &	 \    &	 q    &	 �    &	 �    &		 �    &	
 �    &	 �    7  7  7  &	 n    7  7  &	 g    �� .��U� $ (UIElement.Opacity)�$
	 grid��.\�  $
 0��$ 0Q�  $
 0:0:0.5��$ 1Q�   $ 	EaseInOut=�U� $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.Y)�$	 grid1��.\�  $
 0��$ -52.026Q�  $
 0:0:0.5��$ -52.026Q�  $
 0:0:0.8��$ 0Q�   $ EaseOut=�U� $ (UIElement.Opacity)�$	 grid1��.\�  $
 0��$ 0Q�  $
 0:0:0.5��$ 0Q�  $
 0:0:0.8��$ 1Q��� .���  � �� �� .R��� $��2q� . #��� ��$��1��$	 1 2R��� $ 	#FFDDDDDD���� $ 	#FF707070���� $ 	#FFBEE6FD���� $ 	#FF3C7FB1���� $ 	#FFC4E5F6���� $ 	#FF2C628B���� $ 	#FFF4F4F4���� $ 	#FFADB2B5���� $ 	#FF838383���� " ��.���  �@�FocusVisualStyle8   ��  � ��8  ��  � ��8  ��  � ��# � ����  � ��$ 1q���  � ��$ Center=���  � ��$ Center=���  � ��$ 1q���  � �� �� " ��.R��� $ border��#��z�� . ���	#FF2D3034._��� $ contentPresenter��|�.  #��z��#��z����. # z #��z�� P�  �@J�IsMouseOver .  �� .���� .���� $ 0:0:0.15D�$ HoldEnd=�$ 1x��$ 	#FF3E4247X� .  $2 ,(Control.Background).(SolidColorBrush.Color)�  �� .���� .���� $ 0:0:0.15D�$ HoldEnd=�$ 1x��$ 	#FF2D3034X� .  $2 ,(Control.Background).(SolidColorBrush.Color)��� " ��.���  �@�FocusVisualStyle8   ��  � �� �	#FF1C1F27��  � ��8  ��  � ��# � ����  � ��$ 1q���  � ��$ Center=���  � ��$ Center=���  � ��$ 1q���  � �� �� " ��! ���� 	Hover .R��� $ border��#��z��#��z��#��z�� . ._��� $ contentPresenter��|�.  #��z��#��z����. # z #��z�� P�  �@��IsDefaulted . . ��� $" border��# � �� � ��P�  �@J�IsMouseOver .  �� .���� .���� $ 0:0:0.15D�$ HoldEnd=�$ 1x��$ 	#FF282C38X� .  $2 ,(Control.Background).(SolidColorBrush.Color)�  �� .���� .���� $ 0:0:0.15D�$ HoldEnd=�$ 1x��$ 	#FF1C1F27X� .  $2 ,(Control.Background).(SolidColorBrush.Color)��� .��U� $ (UIElement.Opacity)�$	 window��.\�  $
 0��$ 1Q�  $
 0:0:0.4��$ 0Q�.��� -   # �Name$
# grid��$ � ColumnDefinitions$ �� $
��245* ��� $
��269* �.+�� -   $# grid1��$��32��$	��Top=����	#FF1C1F27% J� RenderTransformOrigin$% 0.5,0.5&�$��2��z�V� .~��� �� �� T� .+��� $
��Left=�$��32��$
��Wrap=�$��Dark Hub��$	��Top=�$��82.121�����	#FF9C9C9C$��Segoe UI Emoji)�$��16(�& �� Padding$& 7,4,0,0q��� -   ' ��Name$' closeBtn��$	����$��Right=�$��33�����	#FFDADADA���	#FF1C1F27#��[ $��10(�$��Segoe MDL2 Assets)���Z� �� -   $' minimizeBTN��$��Segoe MDL2 Assets)�$	����$��0,0,34.5,0.189q����	#FFDADADA���	#FF1C1F27#��[ $��10(�$��Right=�$��32.668����Z� �� -   $' loginBtn��$��Inject��$��Center=�$��Bottom=�$��35�����	#FFB4B4B4���	#FF1C1F27#��[ $��14(�$	��170��$% 0.5,0.5&�$��172,0,172,8q�$��2����Z� � $��Center=�$	��117��$��Center=�$	��426�����	#FF1C1F27$��44,50q�$��2��.+��� -   ( ��Name$( ImageBox��) �� BitmapScalingMode$) HighQuality=�* �� EdgeMode$* Aliased=�$��0,10,26.667,10q�$��Right=�$��99.333��$
��Fill=��� -   + ��Name$+ UserName��$
��Left=�$��25.333��$
��Wrap=�$	��Top=�$��252.543�����	#FF9C9C9C$��Segoe UI Emoji)�$& 7,4,0,0q�$��	10,10,0,0q����	#FF272A34, �� TextAlignment$, Center=��� $�Username���� $�: ���� $�abvasd���� -	   $+ IDBOX��$
��Left=�$��25.333��$
��Wrap=�$	��Top=�$��252.543�����	#FF9C9C9C$��Segoe UI Emoji)�$& 7,4,0,0q�$��10,45.002,0,0q����	#FF272A34$, Center=��� $�ID : ���� $
��Bold"�$�	123456789���� -
   $+ 	statusBox��$
��Left=�$��25.333��$
��Wrap=�$	��Top=�$��252.543�����	#FF9C9C9C$��Segoe UI Emoji)�$& 7,4,0,0q�$��10,81.001,0,0q����	#FF272A34$, Center=�$!��Status : Awaiting Injection���� $
��Left=�$��33��$��102.405,174,0,0q�$
��Wrap=�$	��Top=�$	��157��
�������- J� Opacity$	- 0.4Q�$��Segoe UI Light)�$, Right=�$��1���� $	�UI ���� $�	By ffaded���� �� $�DLL Powered by Fluxus���� $
��Left=�$��18��$��
10,177,0,0q�$
��Wrap=�$	��Top=�$	��135��
�������$	- 0.4Q�$��Segoe UI Light)��� $ �https://discord.gg/darkhub��� -   $# ksGrid��$��Center=�$	��116��$��Center=�$	��427�����	#FF1C1F27$��44,53,43,48q�$��2��.+��� -   . ��Name$. textBox��$
��Left=�$��23��$��	10,54,0,0q�/ �� TextWrapping$
/ Wrap=�$	��Top=�$	��407�����	#FF13151B���	#FF13151B���	#FFA4A3A3�� -   $' loginBtn_Copy��$��
Verify Key��$��Center=�$��Bottom=�$��24�����	#FFB4B4B4���	#FF1C1F27#��[ $	��112��$% 0.5,0.5&�$��305,0,10,10q�$��10(���Z� �� -   $' loginBtn_Copy1��$��Get Key��$��Center=�$��Bottom=�$��24�����	#FFB4B4B4���	#FF1C1F27#��[ $	��112��$% 0.5,0.5&�$��12,0,303,10q�$��10(���Z� �� $
��Left=�$��33��$��	12,14,0,0q�$
��Wrap=�$	��Top=�$	��405��
�������$	- 0.4Q�$��Segoe UI Light)��� $���Nobody likes a keysystem, but going through this keysystem will fund DarkHub and help us out. We kindly ask you to complete this to support us.���� $
��Left=�$��18��$��
10,194,0,0q�$
��Wrap=�$	��Top=�$	��135��
�������$	- 0.4Q�$��Segoe UI Light)��� $�https://darkhub.xyz/��