   M S B A M L   `   `   `  ����>  :NLH, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:NLHNLH  5   	       NLH.GestionMed   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:NLH     5   	   -   5          � Title$  
GestionMed��5   	   $	��450��6   $	��700��6)   ���	#FF8CD5E0.��5	      � $��	-1,-2,1,2q�6   .+�5   
   �� $
��Left=�6   $	��114��6+   $��	30,72,0,0q�68   $	��Top=�6K   $	��201��6c   $��image/doctor.jpg��6o   �� 5   
   $7��1LE NORTHERN LIGHTS HOSPITAL - Gestion de Medicins��6   $
��Left=�6L   $��
116,10,0,0q�6g   $	��Top=�6{   $��20(�6�   $��Showcard Gothic)�6�   ���	#FF0B1B66$��2��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ datemed��5      $
��Left=�6$      AutoGenerateColumns .  $	��114��6[   $��
312,72,0,0q�6h   $	��Top=�6|   $	��291��6�   $��2��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 	IdMedicin��6C   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *	IdMedicin+6C     5      $	 Nom��6=    6%   �� *Nom+6=     5      $ Prenom��6@    6%   �� *Prenom+6@     5      $ 
Specialite��6D    6%   �� *
Specialite+6D   5      �� 5   
   -   5         ��Name$ tbxNom��5      $
��Left=�6"   $��23��6=   $��194,280,0,0q�6I    �� TextWrapping$
 Wrap=�6^   $	��Top=�6r   $	��120��6�   �� 5   
   -   5        $ 	tbxPrenom��5      $
��Left=�6%   $��23��6@   $��453,234,0,0q�6L   $
 Wrap=�6a   $	��Top=�6u   $	��120��6�   �� 5   
   -   5        $ tbxspes��5      $
��Left=�6#   $��23��6>   $��453,280,0,0q�6J   $
 Wrap=�6_   $	��Top=�6s   $	��120��6�   �� 5   
   $��ID Medicin:��6   $
��Left=�6&   $��
42,234,0,0q�6A   $	��Top=�6U   �� 5   
   $
��Nom:��6   $
��Left=�6   $��
42,277,0,0q�6:   $	��Top=�6N   �� 5   
   $��Prenom:��6   $
��Left=�6"   $��349,231,0,0q�6=   $	��Top=�6R   �� 5    
   $��
Specialite��6   $
��Left=�6%   $��349,280,0,0q�6@   $	��Top=�6U   �� 5!   
   -   5         ��Name$ btnMod��5!      $��Modifier��6!   $
��Left=�64   $��32��6O   $��
42,340,0,0q�6[   $	��Top=�6o   $��99��6�   	 J� RenderTransformOrigin$	 -0.462,0.484&�6�   �� 5"   
   -   5        $ btnSup��5"      $��	Suprimmer��6!   $
��Left=�65   $��32��6P   $��194,340,0,0q�6\   $	��Top=�6q   $��99��6�   $	 0.394,0.625&�6�   6�   �� 5#   
   -   5        $ 
btnQuitter��5#      $��Quitter��6%   $
��Left=�67   $��32��6R   $��570,340,0,0q�6^   $	��Top=�6s   $��99��6�   6�   �� 5$   
   $
��Left=�6   $��53��6+   $��	65,10,0,0q�67   $	��Top=�6J   $��46��6b   $��image/l2.png��6m   $	 1.264,0.535&�6�   �� 5%   
   -	   5        
 ��Name$
 comb1��5%      $
��Left=�6"   $��23��6=   $��194,234,0,0q�6I   $	��Top=�6^   $	��120��6v   $ �� IsSynchronizedWithCurrentItem$
 TrueY�6�    �� DisplayMemberPath$ 	IdMedicin��6�   ��6�   �� 6�   5'      5(      