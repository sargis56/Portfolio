   M S B A M L   `   `   `  ����U  Q300904358(Nahapetyan)_ASS2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:_300904358_Nahapetyan__ASS2_300904358_Nahapetyan__ASS2  5   	   ,    &_300904358_Nahapetyan__ASS2.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:_300904358_Nahapetyan__ASS2     5   	     � Title$  
MainWindow��5   	   $��377.833��6   $	��525��6-   ���	#FFDAE336.��5	      � $��0,0,3.4,-16q�6   $	��364��6    $	��Top=�6-   .+�5
   
   �� -   5         ��Name$ comboBoxCategory��5
      $
��Left=�6-   $��	29,41,0,0q�6H   $	��Top=�6[   $	��120��6s   �� 5   
   -   5        $ comboBoxItemsBeverage��5      $
��Left=�62   $��
183,41,0,0q�6M   $	��Top=�6a   $	��120��6y   �� 5   
   -   5        $ comboBoxItemsAppetizer��5      $
��Left=�63   $��
183,41,0,0q�6N   $	��Top=�6b   $	��120��6z   �� 5   
   -   5        $ comboBoxItemsMainCourse��5      $
��Left=�64   $��
183,41,0,0q�6O   $	��Top=�6c   $	��120��6{   �� 5   
   -   5        $ comboBoxItemsDessert��5      $
��Left=�61   $��
183,41,0,0q�6L   $	��Top=�6`   $	��120��6x   �� 5   
   -   5         ��Name$ 	buttonDel��5      $��Delete��6$   $
��Left=�65   $��
425,41,0,0q�6P   $	��Top=�6d   $��75��6|   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dataGridItems��5         AutoGenerateColumns .  $��29,93,217,80.8q�6F   ���	#FF454547���	#FFE2FF00   RowValidationRules 5      ;  5System.Windows.Controls.NotifyDataErrorValidationRule  5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Item��6%      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 63   �� *	StoreItem+6Q     5      $ Price��6%    . 	 64   �� *Price+6N     5      $ Quantity��6%    .  	 67   �� *Qty+6O   5      �� 5   
   -   5        
 ��Name$
 labelCategory��5      $��Category��6'   $
��Left=�6:   $��	29,10,0,0q�6U   $	��Top=�6h   �� 5   
   -	   5        $
 	labelItem��5      $
��Item��6#   $
��Left=�62   $��
199,10,0,0q�6M   $	��Top=�6a   �� 5   
   -
   5        $ buttonOrder��5      $	��Add��6&   $
��Left=�64   $��
328,41,0,0q�6O   $	��Top=�6c   $��75��6{   6�   �� 5    
   -   5        $ buttonClearBill��5       $��
Clear Bill��6*   $
��Left=�6?   $��
388,96,0,0q�6Z   $	��Top=�6n   $��75��6�   6�   �� 5!   
   $
��Left=�6   $��42��6/   $��	0,300,0,0q�6;   $	��Top=�6N   $	��520��6f   ���	#FFDDDDDD.@�5"      �� -   5        $ logoBtn��5"      $��Right=�6=   .��5#      �� $��.\Images\cclogo.jpg��6   $��91��65   $��33��6@   5$      �� 5%      -   5        $
 	labelName��5%      $#��Sargis Nahapetyan (300904358)��6'   $
��Left=�6O   $��Bottom=�6j   5&      �� 5'   
   -   5        $
 labelTax��5'      $
��Tax:��6"   $
��Left=�61   $��365,176,0,0q�6L   $	��Top=�6a    J� RenderTransformOrigin$ 
0.76,0.516&�6y   �� 5(   
   -   5        $
 labelTaxOutput��5(      $��$0.00��6(   $
��Left=�68   $��408,176,0,0q�6S   $	��Top=�6h   $ 
0.76,0.516&�6�   �� 5)   
   -   5        $
 
labelTotal��5)      $��Total:��6$   $
��Left=�65   $��365,207,0,0q�6P   $	��Top=�6e   $ 
0.76,0.516&�6}   �� 5*   
   -   5        $
 labelTotalOutput��5*      $��$0.00��6*   $
��Left=�6:   $��408,207,0,0q�6U   $	��Top=�6j   $ 
0.76,0.516&�6�   �� 5,   
   -   5        $
 labelSubTotal��5,      $��	Subtotal:��6'   $
��Left=�6;   $��365,238,0,0q�6V   $	��Top=�6k   $ 
0.76,0.516&�6�   �� 5-   
   -   5        $
 labelSubTotalOutput��5-      $��$0.00.��6-   $
��Left=�6>   $��428,238,0,0q�6Y   $	��Top=�6n   $ 
0.76,0.516&�6�   �� 5.   
   -   5        $
 labelTaxPercent��5.      $��Tax %:��6)   $
��Left=�6:   $��365,151,0,0q�6U   $	��Top=�6j   $ 
0.76,0.516&�6�   �� 5/   
   -   5        $
 labelTaxPercentOutput��5/      $�� ��6/   $
��Left=�6:   $��408,151,0,0q�6U   $	��Top=�6j   $ 
0.76,0.516&�6�   50      51      