   M S B A M L   `   `   `  ����>  :NLH, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:NLHNLH  5   	       NLH.Paiement   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:NLH     5   	   -   5          � Title$  Paiement��5   	   $	��450��6   $	��800��6'   ���	#FF8CD5E0.��5	      � .+�5
   
   �� $
��Left=�6   $��53��6+   $��	59,20,0,0q�67   $	��Top=�6J   $��46��6b   $��image/l2.png��6m    J� RenderTransformOrigin$ 1.264,0.535&�6�   �� 5   
   $"��LE NORTHERN LIGHTS HOSPITAL ��6   $
��Left=�67   $��
199,20,0,0q�6R   $	��Top=�6f   $��20(�6~   $��Showcard Gothic)�6�   ���	#FF0B1B666�   �� 5   
   $��Paiement Facture��6   $
��Left=�6+   $��32��6F   $��
199,53,0,0q�6R   $	��Top=�6f   $	��172��6~   $��14(�6�   $
��Bold"�6�   $��Italic$�6�   ���	#FF05054D6�   �� 5   
   $
��Left=�6   $��72��6+   $��
691,20,0,0q�67   $	��Top=�6K   $��68��6c   $��image/add_patient.png��6n   $ 0.367,0.091&�6�   �� 5   
   $��Frais Chambre:��6   $
��Left=�6)   $��24��6D   $��
20,107,0,0q�6P   $	��Top=�6d   $	��114��6|   �� 5   
   -   5         ��Name$ txtFraisCham��5      $
��Left=�6(   $��25��6C   $��187,107,0,0q�6O    �� TextWrapping$
 Wrap=�6d   $	��Top=�6x   $	��120��6�   �� 5   
   $��Frais Commodite:��6   $
��Left=�6+   $��24��6F   $��
20,151,0,0q�6R   $	��Top=�6f   $	��114��6~   �� 5   
   -   5        $ txtFraisCommod��5      $
��Left=�6*   $��25��6E   $��187,151,0,0q�6Q   $
 Wrap=�6f   $	��Top=�6z   $	��120��6�   �� 5   
   $��Montant total Facture��6   $
��Left=�60   $��24��6K   $��
20,251,0,0q�6W   $	��Top=�6k   $	��132��6�   �� 5   
   -   5        $ txtFraisCham_Copy1��5      $
��Left=�6.   $��25��6I   $��187,251,0,0q�6U   $
 Wrap=�6j   $	��Top=�6~   $	��120��6�   �� 5   
   $��Nr d'Admission:��6   $
��Left=�6*   $��31��6E   $��
24,192,0,0q�6Q   $	��Top=�6e   $��96��6}   $ 0.801,-0.003&�6�   �� 5   
   -   5         ��Name$ comb1��5      $
��Left=�6"   $��27��6=   $��187,192,0,0q�6I   $	��Top=�6^   $	��120��6v   $ �� IsSynchronizedWithCurrentItem$
 TrueY�6�    �� DisplayMemberPath$ IdAdmission��6�   ��6�   �� 6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dateAd1��5      $
��Left=�6$      AutoGenerateColumns .  $	��127��6[   $��334,107,0,0q�6h   $	��Top=�6}   $	��425��6�   $ 0.443,0.948&�6�   	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 
IdPaiement��6D   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *
IdPaiement+6D     5      $
 FraisChambre��6F    6%   �� *FraisChambre+6F     5      $
 FraisComodite��6G    6%   �� *FraisComodite+6G     5      $
 IdAdmission��6E    6%   �� *IdAdmission+6E     5      $
 MontantFacture��6H    6%   �� *MontantFacture+6H   5"      �� 5#   
   -   5         ��Name$ btnCal��5#      $��Calculer��6!   $
��Left=�64   $��34��6O   $��
94,339,0,0q�6[   $	��Top=�6o   $	��131��6�   6�   5%      5&      