   M S B A M L   `   `   `  ����>  :NLH, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:NLHNLH  5   	       NLH.AjouterMedicin   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:NLH     5   	   -   5          � Title$  AjouterMedicin��5   	   $	��500��6    $	��500��6-   ���	#FF8CD5E0.��5	      � .+�5
   
   �� $!��LE NORTHERN LIGHTS HOSPITAL��6   $
��Left=�66   $��	106,5,0,0q�6Q   $	��Top=�6d   $��20(�6|   $��Showcard Gothic)�6�   ���	#FF0B1B666�   �� 5   
   $
��Left=�6   $��53��6+   $��	20,21,0,0q�67   $	��Top=�6J   $��46��6b   $��image/l2.png��6m    J� RenderTransformOrigin$ 1.264,0.535&�6�   �� 5   
   -   5         ��Name$ tbxNom��5      $
��Left=�6"   $��23��6=   $��156,115,0,0q�6I    �� TextWrapping$
 Wrap=�6^   $	��Top=�6r   $	��120��6�   �� 5   
   -   5        $ 	tbxPrenom��5      $
��Left=�6%   $��23��6@   $��156,160,0,0q�6L   $
 Wrap=�6a   $	��Top=�6u   $	��120��6�   �� 5   
   -   5        $ tbxspes��5      $
��Left=�6#   $��23��6>   $��156,206,0,0q�6J   $
 Wrap=�6_   $	��Top=�6s   $	��120��6�   $ -2.253,-1.683&�6�   �� 5   
   $
��Nom:��6   $
��Left=�6   $��
84,112,0,0q�6:   $	��Top=�6N   �� 5   
   $��Prenom:��6   $
��Left=�6"   $��
84,157,0,0q�6=   $	��Top=�6Q   �� 5   
   $��
Specialite��6   $
��Left=�6%   $��
84,206,0,0q�6@   $	��Top=�6T   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ datemed��5      $
��Left=�6$      AutoGenerateColumns .  $	��114��6[   $��
92,259,0,0q�6h   $	��Top=�6|   $	��315��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 	IdMedicin��6C   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *	IdMedicin+6C     5      $	 Nom��6=    6%   �� *Nom+6=     5      $ Prenom��6@    6%   �� *Prenom+6@     5      $ 
Specialite��6D    6%   �� *
Specialite+6D   5      �� 5    
   -   5        	 ��Name$	 
btnAjouter��5       $��Ajouter��6%   $
��Left=�67   $��32��6R   $��
20,406,0,0q�6^   $	��Top=�6r   $��99��6�   $ 
0.41,0.463&�6�   �� 5!   
   -   5        $	 
btnQuitter��5!      $��Quitter��6%   $
��Left=�67   $��32��6R   $��368,406,0,0q�6^   $	��Top=�6s   $��99��6�   6�   �� 5"   
   $
��Left=�6   $	��133��6+   $��
322,96,0,0q�68   $	��Top=�6L   $	��131��6d   $��image/doctor.png��6p   �� 5#   
   $�� Ajouter un Medicin��6   $
��Left=�6.   $��29��6I   $��
106,45,0,0q�6U   $	��Top=�6i   $	��145��6�   ���	#FF080B4B$
��Bold"�6�   $��14(�6�   $��Italic$�6�   �� 5$   
   -   5        $ ��Modifier/Supprimer Medicin��5$      $
��Left=�66   $��28��6Q   $��156,406,0,0q�6]   $	��Top=�6r   $	��161��6�   6�   5&      5'      