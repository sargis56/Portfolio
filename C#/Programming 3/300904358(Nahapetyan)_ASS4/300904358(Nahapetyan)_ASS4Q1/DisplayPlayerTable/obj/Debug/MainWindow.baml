   M S B A M L   `   `   `  ����M  IDisplayPlayerTable, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:DisplayPlayerTableDisplayPlayerTable  5   	   H DBaseballTable, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullD2clr-namespace:BaseballTable;assembly=BaseballTableBaseballTable 5   	   #    DisplayPlayerTable.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:DisplayPlayerTable     5   	   LBaseballTable2clr-namespace:BaseballTable;assembly=BaseballTable     5   	   -   5          � Title$  
MainWindow��5	   	   $	��350��6   $	��525��6)    � 	Resources 5
      (   "DisplayPlayerTable.BaseballDataSet   baseballDataSet  playersViewSource �� Source �� Source  playerViewSource��%u   &	        &	      7   &	 @       5   
   6    �� 5   
    69   �� *	Players+8   �� 5   
   6   5      .��5      �  � DataContext# [ 6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ playerDataGrid��5         AutoGenerateColumns .     EnableRowVirtualization . $��62,26,49.4,85.8q�6�      RowDetailsVisibilityMode$ VisibleWhenSelected=�6�   ��6f   �� # [ 	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        battingAverageColumn��,  &System.Windows.Controls.DataGridColumn
   Header$
 Batting Average��5   f      Width5  /System.Windows.Controls.DataGridLengthConverter$ SizeToHeader 6   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6C   �� *BattingAverage+6     5      -   5        firstNameColumn��$
 
First Name��5   \   $ SizeToHeader 6p    6>   �� *	FirstName+6p     5      -   5        lastNameColumn��$
 	Last Name��5   Z   $ SizeToHeader 6m    6=   �� *
LastName+6m     5      -   5        playerIDColumn��$
 	Player ID��5   Z   $ SizeToHeader 6m    6=   �� *
PlayerID+6m   5      �� 5   
   -   5         ��Name$ textBoxLastName��5      $
��Left=�6+   $��23��6F   $��131,254,0,0q�6R    �� TextWrapping$
 Wrap=�6g   $��Enter Last Name��6{   $	��Top=�6�   $	��120��6�   �� 5   
   -   5         ��Name$ labelLastName��5      $��
Last Name:��6'   $
��Left=�6<   $��
62,251,0,0q�6W   $	��Top=�6k   �� 5   
   -	   5         ��Name$ buttonSearch��5      $��Search��6'   $
��Left=�68   $��286,258,0,0q�6S   $	��Top=�6h   $��75��6�   6�   �� 5   
   -
   5        $ buttonRefresh��5      $��Refresh��6(   $
��Left=�6:   $��394,257,0,0q�6U   $	��Top=�6j   $��75��6�   6�   �� 5   
   -   5        $
 info��5      $W��QWords are case sensitive, you can search by entering the full name or parts of it��6   $
��Left=�6z   $��
35,285,0,0q�6�   $	��Top=�6�   $
��Bold"�6�   
���   �6�   5      5      