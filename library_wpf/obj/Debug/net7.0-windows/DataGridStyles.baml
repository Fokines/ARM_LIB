   M S B A M L   `   `   `  ����b  ^PresentationFramework.Aero2, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35hKclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2Microsoft.Windows.Themes  5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   ColumnHeaderGripperStyle  �� 
TargetType �� Property �� Value �� 
TargetType �� Padding  DataGridRowStyle1)   #System.Windows.Controls.DataGridRow ��Name J� SnapsToDevicePixels �� CornerRadius?  9System.Windows.Controls.Primitives.SelectiveScrollingGrid � ColumnDefinitions	 � RowDefinitions?  9System.Windows.Controls.Primitives.DataGridCellsPresenter
    
ItemsPanelA  ;System.Windows.Controls.Primitives.DataGridDetailsPresenter    DetailsVisibility$   SelectiveScrollingOrientation;  5System.Windows.Controls.SelectiveScrollingOrientation   Vertical �� ConverterParameter&   System.Windows.Controls.DataGrid#   RowDetailsScrollingConverter �� 	Converter �� RelativeSource �� AncestorType:  4System.Windows.Controls.Primitives.DataGridRowHeader7  1System.Windows.Controls.DataGridHeadersVisibility
   Row!   HeadersVisibilityConverter  DataGridColumnHeaderStyle1=  7System.Windows.Controls.Primitives.DataGridColumnHeader3	   -Microsoft.Windows.Themes.DataGridHeaderBorder 	  	IsPressed J� IsMouseOver 	  	IsHovered   CanUserSort 	  IsClickable   SortDirection 	  SortDirection   SeparatorVisibility 	  SeparatorVisibility   SeparatorBrush 	  SeparatorBrush  n�Name  DataGridCellStyle1*
  $System.Windows.Controls.DataGridCell! �� TextAlignment" �� Path  FocusVisual# �� StrokeDashArray  TextBox.Static.Background$ �� Color  ComboBoxEditableTextBox% ��Name  ComboBox.Static.Background& �� EndPoint' �� 
StartPoint( � Color) � Offset  ComboBox.Static.Border 	 ComboBox.Static.Glyph '
 #ComboBox.Static.Editable.Background # ComboBox.Static.Editable.Border . *ComboBox.Static.Editable.Button.Background * &ComboBox.Static.Editable.Button.Border ! ComboBox.MouseOver.Background  ComboBox.MouseOver.Border  ComboBox.MouseOver.Glyph * &ComboBox.MouseOver.Editable.Background & "ComboBox.MouseOver.Editable.Border 1 -ComboBox.MouseOver.Editable.Button.Background - )ComboBox.MouseOver.Editable.Button.Border  ComboBox.Pressed.Background  ComboBox.Pressed.Border  ComboBox.Pressed.Glyph ( $ComboBox.Pressed.Editable.Background $  ComboBox.Pressed.Editable.Border / +ComboBox.Pressed.Editable.Button.Background + 'ComboBox.Pressed.Editable.Button.Border   ComboBox.Disabled.Background  ComboBox.Disabled.Border  ComboBox.Disabled.Glyph ) %ComboBox.Disabled.Editable.Background %  !ComboBox.Disabled.Editable.Border 0! ,ComboBox.Disabled.Editable.Button.Background ," (ComboBox.Disabled.Editable.Button.Border # ComboBoxToggleButton* F�Name+ �� Triggers, ^� 
Conditions- �� Binding. �� Value/ �� 
TargetName0 P� Property1 P� Value $ ComboBoxEditableTemplate2 �Name3 �Name4 � AllowsTransparency5   /Microsoft.Windows.Themes.SystemDropShadowChrome5  Name6   Color7 �� MaxDropDownHeight8 �� ElementName9 �� ClearTypeHint: ��Name; ��Name< ��Name-  'System.Windows.Input.KeyboardNavigation=   DirectionalNavigation> d�Name? d� 	IsChecked@ �� ModeA ��NameB �� 
IsReadOnlyC P� 
SourceNameD ]� 
ConditionsE �� Property % ComboBoxTemplateF ��Name#G �� SelectionBoxItemStringFormatH �� ContentStringFormatI �� SelectionBoxItemTemplateJ �� SelectionBoxItemK J� IsHitTestVisible & ComboBoxStyle1L �� TriggersM �� 
ResourceIdN �� TypeInTargetAssembly ' DataGridStyles5  /System.Windows.Controls.DataGridLengthConverterO   SelectAllCommand
P   AllG  ASystem.Windows.Controls.Primitives.DataGridColumnHeadersPresenterQ  NameR   ColumnS ��NameT �� CanContentScrollU ��NameV �� ScrollableHeightW � MaximumX �� OrientationY �� ViewportHeightZ �� ViewportSize*[ �� #ComputedVerticalScrollBarVisibility ( MyScrollBar\ � Value] �� ScrollableWidth^ �� ViewportWidth,_ �� %ComputedHorizontalScrollBarVisibility ) ScrollThumbs` �� RadiusXa �� RadiusYb ��Name * ScrollButtonsc ]�Named ]� Thumb�� 5      H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      :x,http://schemas.microsoft.com/winfx/2006/xaml     5      UthemeKclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2  5      %�O  &	        &	     &	 \    7   7   &	 B	    &	 u    &	 (    &	 K    &	     &	 �    &		 �    &	
 �    &	 !    &	 D    &	 i    &	 �    &	 *    &	 M    &	 p    &	 �    &	 �    &	 R    &	 u    &	     &	 4    &	 W    &	 z    &	 �    &	 9    &	 \    &	     &	 �    &	 �    &	  �    &	!     &	" 0    &	# U    7  7  7 	 7 
 7  7  7  7  7  7  7  7  7  7  7  7  7  7  7  7  7  7  7  7  7  7   7 ! 7 " &	$ �#    7 # 7  7  &	% -    7 # &	& Q6    7  7  7  7 % 7 $ (�� 9    5�     $"M DataGridSelectAllButtonStyle��"N  )&	' �:    &	) G    &	( �H    �� 5      "  n�6-   .�5   
   ��  � ��$ 8��6"   �� 5   
    � ��
 ���� 6'   �� 5   
    �@�Cursor$ SizeWE��6#   �� 5	   
    � �� 5
      �� 5      " n�6"   .R�5      �� #��z��6   # z��6G   5      5      5      �� 5      "    6&   .�5   
   ��  � ��
 ���� 6'   �� 5   
    � ��
 �   �6'   �� 5   
    � ��$ Inter)�6'   �� 5   
    � ��$ SemiBold"�6'   �� 5   
    � ��$ 0 2 0 0q�6#   �� 5   
    � ��$ 10(�6%   �� 5   
    � ��$ Normal$�6&   �� 5   
    � ��$
 Auto��6"   �� 5   
    � ��$
 Auto��6#   �� 5   
    �@J�SnapsToDevicePixels$
 true��60   �� 5   
    �@=�ErrorTemplate 65   Z� �� 5   
    �@  ValidationErrorTemplate 5      �� 5      .R�5       �� 
���   �$��0,0,0,0q�63   $��!��6D   $��Center=�6M   5!      5#      �� 5$   
    � �� 5%      �� 5&      "   6"   .R�5'      �� $ 
DGR_Border��6   
������ $��1q�5)      ���#CECECE$
 True��5+      $ 8��5,      ._�5-         5.      �� 5/   "   $
��Auto �63   �� 50   "   $��* �63   	 52      �� 53   "   $��* �60   �� 54   "   $
��Auto �60   .+�56        $��1��65   #��z
 57   5   # z 58   5     59      $��1��67   $��1��5:   7   #y�z 5<   7    5;   7   �� *AreRowDetailsFrozen+# Z # Z  �� "  5<   7     5=      $��2��60   $ Vertical=�5>   0   y�5?   0   �� *HeadersVisibility+# Z # Z  �� "  5@      5A      5B      5D      5E      �� 5F      "   6/   .�5G   
   ��  � ��$ Center=�65   �� 5H   
    � ��
 ���� 6'   �� 5I   
    � ��
 �   �6'   �� 5J   
    � ��$ 15 10 15 10q�6#   �� 5K   
    � �� 5L      �� 5M      "  6"   .R�5N      � .+�5O      	  #��z��65   #��z��5P   5   #��z��5Q   5   # z��5R   5   # z 5S   5   # z 5T   5   $ 0q�5U   5   # z 5V   5   # z 5W   5   # z 5X   5   ._�5Y      �� $��Center=�6/   $
��True��5Z   /   # z 5[   /   $��Center=�5\   /   5]      n� 5^      $  PART_LeftHeaderGripper��6    $
��Left=�5_       8��  5`       n� 5a      $  PART_RightHeaderGripper��6    $��Right=�5b       8�� 5c       5d      5e      5g      5h      �� 5i      "  
 6'   .�5j   
   ��  � ��
 ���� 6'   �� 5k   
    � ��
 �   �6'   �� 5l   
    � ��$ 0q�6,   �� 5m   
    � ��$ Center=�6.   �� 5n   
    �@�FocusVisualStyle 6-   Z� �� 5o   
    � ��$
 Wrap=�63   �� 5p   
    � ��$ 1q�6#   �� 5q   
    � �� 5r      �� 5s      " 
 6"   .R�5t      �� $
��Wrap=�5u      $! Center=�5v      $��Center=�5w      $��2q�5x      ��5t       ��  �� *TemplatedParent+$" Content.Text�5x      5y      5{      5|      �� 5}      .�5~   
   ��  � �� 5      �� 5�      .R�5�      �� $��2q�6    $	# 1 2R�6+   #��� ��6A   $
 true��6�   $��1��6�   5�      5�      5�      �� 5�      $$ 	#FFFFFFFF��68   �� 5�      "  ��6,   .�5�   
   ��  �@�OverridesDefaultStyle$
 true��62   �� 5�   
    �@J�	AllowDrop$
 true��6&   �� 5�   
    � ��$ 0��6%   �� 5�   
    � ��$ 0��6&   �� 5�   
    �@�FocusVisualStyle 6-   Z� �� 5�   
    �@��PanningMode$ VerticalFirst=�65   �� 5�   
    �@��IsFlicksEnabled$ False��63   �� 5�   
    � ��$ 9(�6%   �� 5�   
    � ��$ Inter)�6'   �� 5�   
    � ��$ Normal$�6&   �� 5�   
    � ��$ SemiBold"�6'   �� 5�   
    � �� 5�      �� 5�      " ��6"   .R�5�      �� $% PART_ContentHost��6#   
������ $|�false��6V   $��Hidden=�6h   $��Hidden=�6�   5�      5�      5�      �� 5�      $	& 0,1&�6=   $	' 0,0&�6L   .��5�   
   � $( 	#FFF0F0F0��6   $	) 0.0Q�6)   � 5�   
   $( 	#FFE5E5E5��6   $	) 1.0Q�6)   5�      �� 5�      $$ #CECECE��65   �� 5�      $$ 	#FF606060��64   �� 5�      $$ 	#FFFFFFFF��6B   �� 5�      $$ 	#FFABADB3��6>   �� 5�      $$ Transparent��6I   �� 5�      $$ Transparent��6E   �� 5�      $	& 0,1&�6@   $	' 0,0&�6O   .��5�   
   � $( 	#FFECF4FC��6   $	) 0.0Q�6)   � 5�   
   $( 	#FFDCECFC��6   $	) 1.0Q�6)   5�      �� 5�      $$ 	#FF7EB4EA��68   �� 5�      $$ 	#FF000000��67   �� 5�      $$ 	#FFFFFFFF��6E   �� 5�      $$ 	#FF7EB4EA��6A   �� 5�      $	& 0,1&�6P   $	' 0,0&�6_   .��5�   
   � $( 	#FFEBF4FC��6   $	) 0.0Q�6)   � 5�   
   $( 	#FFDCECFC��6   $	) 1.0Q�6)   5�      �� 5�      $$ 	#FF7EB4EA��6H   �� 5�      $	& 0,1&�6>   $	' 0,0&�6M   .��5�   
   � $( 	#FFDAECFC��6   $	) 0.0Q�6)   � 5�   
   $( 	#FFC4E0FC��6   $	) 1.0Q�6)   5�      �� 5�      $$ 	#FF569DE5��66   �� 5�      $$ 	#FF000000��65   �� 5�      $$ 	#FFFFFFFF��6C   �� 5�      $$ 	#FF569DE5��6?   �� 5�      $	& 0,1&�6N   $	' 0,0&�6]   .��5�   
   � $( 	#FFDAEBFC��6   $	) 0.0Q�6)   � 5�   
   $( 	#FFC4E0FC��6   $	) 1.0Q�6)   5�      �� 5�      $$ 	#FF569DE5��6F   �� 5�      $$ 	#FFF0F0F0��6;   �� 5�      $$ 	#FFD9D9D9��67   �� 5�      $$ 	#FFBFBFBF��66   �� 5�      $$ 	#FFFFFFFF��6D   �� 5�      $$ 	#FFBFBFBF��6@   �� 5�      $$ Transparent��6K   �� 5�      $$ Transparent��6G   �� 5�      "  d�6)   .�5�   
   ��  �@�OverridesDefaultStyle$
 true��62   �� 5�   
    � ��$ false��6&   �� 5�   
    � |�$ false��6&   �� 5�   
    �@��	ClickMode$ Press=�6&   �� 5�   
    � �� 5�      �� 5�      " d�6"   .R�5�      �� $ templateRoot��6   $ 5��63   8��  8�� #��z��6�   $
 true��6�   ._�5�      �� $ splitBorder��6!   
������ $��1q�6P   $��Right=�6d   $��0q�6�   $
 true��6�   #��� r�6�   ._�5�      F� $* arrow��6#   F����        ���( ��( јaQ     јaQ P����̰( � �    P����        8�� $��Center=�6�   $��0q�6�   $��Center=�6�   5�      5�      + 5�      ^� 5�      , 5�      �� 5�   "   - 6,   �� *
IsEditable+ �� " ��. true6�   �� 5�   "   - 6,   �� *IsMouseOver+ �� *Self+	. false6r   �� 5�   "   - 6,   �� *	IsPressed+ �� *Self+	. false6p   �� 5�   "   - 6,   �� *	IsEnabled+ �� *Self+. true6p   .0�5�      �� $/ templateRoot��6;   8   � ��6U   �� 5�      $/ templateRoot��6<   8   � ��6V   �� 5�      $/ splitBorder��6;   8   � ��6T   �� 5�      $/ splitBorder��6<   8   � ��6U   5�      P� 5�      0 �@J�IsMouseOver$
1 true��69   . �5�      �� $/ arrow��65   8   � ��6H   5�      ^� 5�      , 5�      �� 5�   "   - 6,   �� *IsMouseOver+ �� *Self+. true6r   �� 5�   "   - 6,   �� *
IsEditable+ �� " ��	. false6�   .0�5�      �� $/ templateRoot��6;   8   � ��6U   �� 5�      $/ templateRoot��6<   8 	  � ��6V   5�      ^� 5�      , 5�      �� 5�   "   - 6,   �� *IsMouseOver+ �� *Self+. true6r   �� 5�   "   - 6,   �� *
IsEditable+ �� " ��. true6�   .0�5�      �� $/ templateRoot��6;   8 
  � ��6U   �� 5�      $/ templateRoot��6<   8   � ��6V   �� 5�      $/ splitBorder��6;   8   � ��6T   �� 5�      $/ splitBorder��6<   8   � ��6U   5�      P� 5�      0 � ��$
1 true��67   . �5�      �� $/ arrow��65   8   � ��6H   5�      ^� 5�      , 5�      �� 5�   "   - 6,   �� *	IsPressed+ �� *Self+. true6p   �� 5�   "   - 6,   �� *
IsEditable+ �� " ��	. false6�   .0�5�      �� $/ templateRoot��6;   8   � ��6U   �� 5�      $/ templateRoot��6<   8   � ��6V   5      ^� 5     , 5     �� 5  "   - 6,   �� *	IsPressed+ �� *Self+. true6p   �� 5  "   - 6,   �� *
IsEditable+ �� " ��. true6�   .0�5     �� $/ templateRoot��6;   8   � ��6U   �� 5     $/ templateRoot��6<   8   � ��6V   �� 5     $/ splitBorder��6;   8   � ��6T   �� 5	     $/ splitBorder��6<   8   � ��6U   5
     P� 5     0 � {�$1 false��67   . �5     �� $/ arrow��65   8   � ��6H   5     ^� 5     , 5     �� 5  "   - 6,   �� *	IsEnabled+ �� *Self+	. false6p   �� 5  "   - 6,   �� *
IsEditable+ �� " ��	. false6�   .0�5     �� $/ templateRoot��6;   8   � ��6U   �� 5     $/ templateRoot��6<   8   � ��6V   5     ^� 5     , 5     �� 5  "   - 6,   �� *	IsEnabled+ �� *Self+	. false6p   �� 5  "   - 6,   �� *
IsEditable+ �� " ��. true6�   .0�5     �� $/ templateRoot��6;   8   � ��6U   �� 5     $/ templateRoot��6<   8   � ��6V   �� 5     $/ splitBorder��6;   8   � ��6T   �� 5     $/ splitBorder��6<   8   � ��6U   5     5!     5#     5$     �� 5%     " ��67   .R�5&  
   � $2 templateRoot��6   $
 true��6%    5'     �� 5(     $��* �6#   �� 5)     #��� r�6#   $��0 �6v   .+�5+     � $3 
PART_Popup��6   $
4 true��6(   $��2��6B   $��Bottom=�6�   #��� .�6�   ��6V   �� *IsDropDownOpen+ �� *TemplatedParent+.��5,       $5 shadow��6/   $6 Transparent��6?   #��z7 6�   ��6S   �� *ActualWidth+$8 templateRoot��._�5-     �� $ dropDownBorder��6   #��� ��65   #��� ��6{   $��1q�6�   ._�5.     �� $% DropDownScrollViewer��6'   .��5/     � $
2 grid��6#   $9 Enabled=�61   .+�50  "   �� $: canvas��6)   $
��Left=�69   $��0��6T   $	��Top=�6_   $��0��6w   .+�51  &   �� $; 
opaqueRect��60   ��6D   �� *
Background+$8 dropDownBorder����6|   �� *ActualHeight+$8 dropDownBorder����6�   �� *ActualWidth+$8 dropDownBorder��52  #   �� 53  "   $< ItemsPresenter��61   $= 	Contained=�6I   # z 6~   54     55     56     57     58     d� 59     $> toggleButton��6   #��z��61   #��z��6[   #��z��6�   $��2��6�   8��  ? 6�   �� *IsDropDownOpen+$@ TwoWay=� �� *TemplatedParent+62  �� 5:     $ border��6   8�� #��z��6]   ._�5;     �� $A PART_EditableTextBox��6   #��z��68   #��z��6�   8�� #��z��6)  B 6�   �� *
IsReadOnly+ �� *TemplatedParent+6)  5<     5=     + 5>  
   P� 5?     0 � {�$1 false��6+   . �5@     �� $/ border��6,    �@J�Opacity$
 0.56Q�6@   5A     P� 5B     0 �@J�IsKeyboardFocusWithin$
1 true��67   . �5C     ��  � ��
 �   �6/   5D     P� 5E     $C 
PART_Popup��6/   0 �@�HasDropShadow$
1 true��6G   . �5F     �� $/ shadow��6+    � ��$ 0,0,5,5q�6?   �� 5G     $/ shadow��6*    �@ Color$ 	#71000000��6>   5H     P� 5I     0 �@��HasItems$1 false��6*   . �5J     �� $/ dropDownBorder��6+    � ��$ 95��6G   5K     ]� 5L     D 5M     �� 5N     E �@��
IsGrouping$
. true��66   �� 5O     "E �@%�IsVirtualizingWhenGrouping$. false��6X   ./�5Q     ��  � ��$ false��6B   5R     P� 5S     $C DropDownScrollViewer��6?   0 � ��$1 false��6a   . �5T     �� $/ 
opaqueRect��6/    6G   �� *VerticalOffset+$8 DropDownScrollViewer�� �@��Top�� 5U     $/ 
opaqueRect��60    6H   �� *HorizontalOffset+$8 DropDownScrollViewer�� �@��Left5V     5X     �� 5Y     " ��6/   .R�5Z  
   � $2 templateRoot��6   $
 true��6%   $��20��6@    5[     �� 5\     $��* �6#   �� 5]     #��� r�6#   $��0 �6v   .+�5_     � $3 
PART_Popup��6   $
4 true��6(   $��2��6B   $��1q�6�   $��Bottom=�6�   #��� .�6�   ��6V   �� *IsDropDownOpen+$@ TwoWay=� �� *TemplatedParent+.��5`       $5 shadow��6/   $6 Transparent��6?   #��z7 6�   ��6S   �� *ActualWidth+$8 templateRoot��._�5a     �� $ dropDownBorder��6   #��� ��65   #��� ��6{   $��1q�6�   ._�5b     �� $% DropDownScrollViewer��6'   .��5c     � $
2 grid��6#   $9 Enabled=�61   .+�5d  "   �� $: canvas��6)   $
��Left=�69   $��0��6T   $	��Top=�6_   $��0��6w   .+�5e  &   �� $; 
opaqueRect��60   ��6D   �� *
Background+$8 dropDownBorder����6|   �� *ActualHeight+$8 dropDownBorder����6�   �� *ActualWidth+$8 dropDownBorder��5f  #   �� 5g  "   $< ItemsPresenter��61   $= 	Contained=�6I   # z 6~   5h     5i     5j     5k     5l     d� 5m     $> toggleButton��6   #��z��61   #��z��6[   #��z��6�   $��2��6�   8��  ? 6�   �� *IsDropDownOpen+$@ TwoWay=� �� *TemplatedParent+62  �� 5n     $F contentPresenter��6   #H zG 69   #��zI 6~   #��zJ 6�   #��z��6�   #��z��6)  $K false��6l  #��z��6�  # z 6�  #��z��6�  5o     + 5p  
   P� 5q     $C 
PART_Popup��6/   0 �@�HasDropShadow$
1 true��6G   . �5r     �� $/ shadow��6+    � ��$ 0,0,5,5q�6?   �� 5s     $/ shadow��6*    �@ Color$ 	#71000000��6>   5t     P� 5u     0 �@��HasItems$1 false��6*   . �5v     �� $/ dropDownBorder��6+    � ��$ 95��6G   5w     ]� 5x     D 5y     �� 5z     E �@��
IsGrouping$
. true��66   �� 5{     "E �@%�IsVirtualizingWhenGrouping$. false��6X   ./�5}     ��  � ��$ false��6B   5~     P� 5     $C DropDownScrollViewer��6?   0 � ��$1 false��6a   . �5�     �� $/ 
opaqueRect��6/    6G   �� *VerticalOffset+$8 DropDownScrollViewer�� �@��Top�� 5�     $/ 
opaqueRect��60    6H   �� *HorizontalOffset+$8 DropDownScrollViewer�� �@��Left5�     5�     �� 5�     "  ��6#   .�5�  
   ��  �@�FocusVisualStyle8   6-   �� 5�  
    � ��8  6'   �� 5�  
    � ��8  6(   �� 5�  
    � ��# � ��6'   �� 5�  
    � ��$ 1q�6,   �� 5�  
    � ��$
 Auto=�6G   �� 5�  
    � ��$
 Auto=�6E   �� 5�  
    � ��$ 6,3,5,3q�6$   �� 5�  
    � ��$
 true��6:   �� 5�  
    �@��PanningMode$
 Both=�65   �� 5�  
    �@��IsFlicksEnabled$ False��63   �� 5�  
    � ��8  6%   L 5�  
   P� 5�     0 �@��
IsEditable$
1 true��6,   . �5�     ��  � ��$ false��6.   �� 5�      � ��$ 2q�6,   �� 5�      � ��8  6-   5�     5�     �� 5�     "  ��6{   .�5�  
   ��  � �� 5�     �� 5�     " ��6"   .R�5�     � .+�5�     �� $; Border��6$   #��� ��5�  $   $
 True��5�  $   5�     + 5�     P� 5�     0 �@J�IsMouseOver$
1 True��69   . �5�     �� $/ Border��67   # � ��6K    � ��5�     P� 5�     0 � ��$
1 True��67   . �5�     �� $/ Border��65   # � ��6I    � ��5�     P� 5�     0 � {�$1 False��67   5�     5�     5�     5�     �� 5�     "   6#   .�5�  
   ��  � ��
 �   �6'   �� 5�  
    � ��$ 0q�6,   �� 5�  
     �@ RowDetailsVisibilityMode$ Visible=�65   �� 5�  
    � ��$
 True��6:   �� 5�  
    �@��PanningMode$
 Both=�65   �� 5�  
    �@��IsFlicksEnabled$ False��63   �� 5�  
    �@ AutoGenerateColumns$ False��60   �� 5�  
    �@ HeadersVisibility$ Column=�6.   �� 5�  
    �@ ColumnWidth$ * 6(   �� 5�  
    � ��$	 195��6#   �� 5�  
    � ��$ 9(�6%   �� 5�  
    � ��$ Inter)�6'   �� 5�  
    � ��$ Normal$�6&   �� 5�  
    � ��$ SemiBold"�6'   �� 5�  
    �@ GridLinesVisibility$
 None=�60   �� 5�  
    �@ SelectionMode$ Single=�6*   �� 5�  
    �@ SelectionUnit$ FullRow=�6*   �� 5�  
    �@ CanUserAddRows$ False��6+   �� 5�  
    �@ CanUserDeleteRows$ False��6.   �� 5�  
    �@ CanUserResizeRows$ False��6.   �� 5�  
    �@ CanUserReorderColumns$ False��62   �� 5�  
    �@ CanUserResizeColumns$ False��61   �� 5�  
    � �� 5�     �� 5�     "  6"   .R�5�     �� 
������ $��0q�5�     $ 0q�5�     $
 True��5�     $ 8��5�     ._�5�     �� $% DG_ScrollViewer��6+   $|�false��6D   ��5�  "   �� 5�  &   " ��66   .R�5�  *   �  5�  .   �� 5�  2   $
��Auto �6C   �� 5�  2   $��* �6C   �� 5�  2   $
��Auto �6C   	 5�  .   �� 5�  2   $
��Auto �6@   �� 5�  2   $��* �6@   �� 5�  2   $
��Auto �6@   .+�5�  .   �� #��ZO 65   $|�false��5�  1   ��5�  1   C� *�� $"M DataGridSelectAllButtonStyle��"N  +y�5�  1   �� *HeadersVisibility+# ZP # Z  �� "  ��5�  1   �� *CellsPanelHorizontalOffset+ �� "    5�  .   $!Q PART_ColumnHeadersPresenter��6M   $��1��5�  /   y�5�  /   �� *HeadersVisibility+# ZR # Z  �� "  �� 5�  .   $!S PART_ScrollContentPresenter��6E   #T z��5�  =   $��2��5�  =   $��1��5�  =   �� 5�  .   $U PART_VerticalScrollBar��68   $��2��5�  0   #W zV 5�  0   $X Vertical=�5�  0   $��1��5�  0   #Z zY 5�  0   #y�z[ 5�  0   #��� ( 5�  0   
������ \ 5�  0   �� *VerticalOffset+$@ OneWay=� �� *TemplatedParent+5�  8   � 5�  .   $��1��63   $��2��6C    5�  2   �� 5�  6   ��6G   �� **(NonFrozenColumnsViewportHorizontalOffset+ �� "  �� 5�  6   $��* �6G   .+�5�  2   �� $U PART_HorizontalScrollBar��6<   $��1��5�  4   #W z] 5�  4   $X 
Horizontal=�5�  4   #Z z^ 5  4   #y�z_ 5  4   \ 5   4   �� *HorizontalOffset+$@ OneWay=� �� *TemplatedParent+5  4   5  /   5  +   5  '   .��5     �� # z 6-   5     5	     5
     5     L 5  
   ]� 5     D 5     �� 5     E �@��
IsGrouping$
. true��66   �� 5     "E �@%�IsVirtualizingWhenGrouping$. false��6X   �� 5     E � ��
. �   �66   ./�5     ��  � ��$ false��6B   5     5     �� 5     "  n�6!   .�5  
   ��  � ��
 ���� 6'   �� 5  
    � ��$ 0q�6,   �� 5  
    � �� 5     �� 5     " n�6"   .R�5     � $
2 Grid��6   .+�5      �� $��
Rectangle1��6$   $��8��5!  $   $
��auto��5"  $   $��Stretch=�5#  $   $��Stretch=�5$  $   ���#007AFF$` 5��5&  $   $a 5��5'  $   5(     5)     5+     5,     �� 5-     "  ��6    .�5.  
   ��  � ��
 ���� 6'   �� 5/  
    � ��$ 12��6"   �� 50  
    �@�Cursor$
 Hand��6#   �� 51  
    � �� 52     �� 53     " ��6"   .R�54     � $2 GridRoot��6   #��� ��55     
������ 	 57     �� 58     $��12��6,   �� 59     $��0.00001* �6,   �� 5:     $��12��6,   .+�5=     �� $b DecreaseRepeat��6'   $��ScrollBar.LineUpCommand��5>  '   
���   �#��� * 5@  '   $��0q�5A  '   
������ .��5C     F� $* DecreaseArrow��6#   $��Center=�5D  #   $��Center=�5E  #   +�����g5     �    ��j ���j ��j ��g5     ���#007AFF5G  #   5H     ]� 5I     $c 
PART_Track��6    $��1��5J      $|�False��5K      $
��True��5L      d 5M     n� 5N  "   $  Thumb��6(   
������ #��� ) 5P  (   5R     �� 5S     $b IncreaseRepeat��6'   $��2��5T  '   $��ScrollBar.LineDownCommand��5U  '   
���   �#��� * 5W  '   $��0q�5X  '   
������ .��5Z     F� $* IncreaseArrow��6#   $��Center=�5[  #   $��Center=�5\  #   +�����g5 ��j ���j     �        ��g5 ��j ���#007AFF5^  #   5_     5`     5a     5c     5d     5e     