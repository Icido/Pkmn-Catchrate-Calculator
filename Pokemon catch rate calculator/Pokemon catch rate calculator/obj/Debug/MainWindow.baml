   M S B A M L   `   `   `  ����X  TPokemon catch rate calculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:Pokemon_catch_rate_calculatorPokemon_catch_rate_calculator  5   	   .    (Pokemon_catch_rate_calculator.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:Pokemon_catch_rate_calculator     5   	   -   5          �Name$  
WindowView��5   	    � Title$# Pokemon catch rate calculator��5	   	   $	��600��6/   $	��800��6<   .��5      � .+�5   
   �� $
��Left=�6   $��17��6/   $��	10,28,0,0q�6;   $
��Wrap=�6N   $��Pokemon��6b   $	��Top=�6q   $	��121��6�   �� 5   
   -   5        $��PkmnSelectCombo��5      $��
5,50,0,488q�6*   $
��Left=�6>   $	��252��6Y    �� DisplayMemberPath$ pkmnName��6�   ��6e   �� *PokemonList+ �� SelectedItem 6�   �� *PokemonClass+6�   �� 5   
   $��Name: ��6   $��5,150,525,390q�6"   �� 6:   �6>   �� *PokemonClass.pkmnName+6h   �� 5   
   $��Base Health: ��6   $��5,202,525,337q�6)   �� 6A   �6E   �� *PokemonClass.baseHealth+6q   �� 5   
   $��Catch Rate: ��6   $��5,255,525,284q�6(   �� 6@   �6D   �� *PokemonClass.catchRate+6o   �� 5   
   $
��Left=�6   $��17��6/   $��
262,28,0,0q�6;   $
��Wrap=�6O   $��Pokemon Level��6c   $	��Top=�6x   $	��125��6�   ]� 5   
   $	��Top=�6   $��262,50,279,0q�6,   .+�5      �� $��Right=�6t    �� TextAlignment$ Right=�6�   $��40��6�   ��6   ��  �� ElementName$ PkmnLevelSlider�� �� Path$ Value� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5      -   5        $��PkmnLevelSlider��5      $
��Left=�6,   $��21��6G   $	��Top=�6S   $	��190��6k    � Minimum$ 1Q�6w   	 � Maximum$		 100Q�6�   
 �� TickFrequency$
 1Q�6�    �� IsSnapToTickEnabled . 6�   5      �� 5   
   $
��Left=�6   $��17��6/   $��
520,28,0,0q�6;   $
��Wrap=�6O   $��	Ball Type��6c   $	��Top=�6t   $��91��6�   �� 5   
   -   5        $��BallSelectCombo��5      $��520,50,0,488q�6*   $
��Left=�6@   $	��262��6[   $ ballName��6�   ��6g   �� *
BallList+ 6�   �� *	BallClass+6�   �� 5   
   $��Name: ��6   $��520,150,10,390q�6"   �� 6;   �6?   �� *BallClass.ballName+6f   �� 5   
   $��Catch Bonus: ��6   $��520,202,10,337q�6)   �� 6B   �6F   �� *BallClass.catchBonus+6o   �� 5!   
   $
��Left=�6   $��17��6/   $��
262,88,0,0q�6;   $
��Wrap=�6O   $��Own Pokemon Level��6c   $	��Top=�6|   $	��125��6�   ]� 5"   
   -   5        $��PkmnDock��5"      $	��Top=�6$   $��262,110,279,0q�6<   $y�Hidden=�6S   .+�5#      �� $��Right=�6w   $ Right=�6�   $��40��6�   ��6   �� $ OwnPkmnLevelSlider��$ Value�$ PropertyChanged=�6�   �� 5$      -   5        $��OwnPkmnLevelSlider��5$      $
��Left=�6/   $��21��6J   $	��Top=�6V   $	��190��6n   $ 1Q�6z   $		 100Q�6�   $
 1Q�6�    . 6�   5%      �� 5'   
   -   5        $��CatchCalculator��5'      $��	Calculate��6(   $
��Left=�6<   $��66��6W   $��323,344,0,0q�6c   $	��Top=�6x   $	��118��6�   6�   �� 5)   
   $
��Left=�6   $��70��6/   $��	0,415,0,0q�6;   $
��Wrap=�6N   $��Full health, no sleep��6b   $	��Top=�6   $	��150��6�   �� 5*   
   $
��Left=�6   $��70��6/   $��179,415,0,0q�6;   $
��Wrap=�6P   $��Full health, sleep��6d   $	��Top=�6~   $	��150��6�   �� 5+   
   $
��Left=�6   $��70��6/   $��395,415,0,0q�6;   $
��Wrap=�6P   $��1 health, no sleep��6d   $	��Top=�6~   $	��150��6�   �� 5,   
   $
��Left=�6   $��70��6/   $��594,415,0,0q�6;   $
��Wrap=�6P   $��1 health, sleep��6d   $	��Top=�6{   $	��150��6�   �� 5/   
   -   5        $��CatchRateInitial��5/      $
��Left=�6,   $��70��6G   $��
10,490,0,0q�6S   $
��Wrap=�6g   $��0.00%��6{   $	��Top=�6�   $	��150��6�   �� 50   
   -	   5        $��CatchRateSleep��50      $
��Left=�6*   $��70��6E   $��179,490,0,0q�6Q   $
��Wrap=�6f   $��0.00%��6z   $	��Top=�6�   $	��150��6�   �� 51   
   -
   5        $��CatchRate1HP��51      $
��Left=�6(   $��70��6C   $��395,490,0,0q�6O   $
��Wrap=�6d   $��0.00%��6x   $	��Top=�6�   $	��150��6�   �� 52   
   -   5        $��CatchRate1HPSleep��52      $
��Left=�6-   $��70��6H   $��594,490,0,0q�6T   $
��Wrap=�6i   $��0.00%��6}   $	��Top=�6�   $	��150��6�   56      58      