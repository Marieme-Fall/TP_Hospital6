   M S B A M L   `   `   `  ����>  :NLH, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:NLHNLH  5   	       NLH.MedicinPage   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:NLH     5   	   -   5          � Title$  MedicinPage��5   	   $	��450��6   $	��900��6*   ���	#FF8CD5E0.��5	      � .+�5
   
   �� $"��LE NORTHERN LIGHTS HOSPITAL ��6   $
��Left=�67   $��
199,20,0,0q�6R   $	��Top=�6f   $��20(�6~   $��Showcard Gothic)�6�   ���	#FF0B1B666�   �� 5   
   $��PAGE DE MEDICIN��6   $
��Left=�6*   $��32��6E   $��
199,53,0,0q�6Q   $	��Top=�6e   $	��172��6}   $��14(�6�   $
��Bold"�6�   $��Italic$�6�   ���	#FF05054D6�   �� 5   
   $
��Left=�6   $��53��6+   $��	36,32,0,0q�67   $	��Top=�6J   $��46��6b   $��image/l2.png��6m    J� RenderTransformOrigin$ 1.264,0.535&�6�   �� 5   
   $��Dossier d'admission:��6   $
��Left=�6/   $��31��6J   $��
27,128,0,0q�6V   $	��Top=�6j   $	��114��6�   $ 0.801,-0.003&�6�   �� 5   
   -   5         ��Name$ comb1��5      $
��Left=�6"   $��27��6=   $��156,128,0,0q�6I   $	��Top=�6^   $	��120��6v   $ �� IsSynchronizedWithCurrentItem$
 TrueY�6�    �� DisplayMemberPath$ IdAdmission��6�   ��6�   �� 6�   �� 5   
   $��Date d'admission:��6   $
��Left=�6,   $��27��6G   $��
27,180,0,0q�6S   $	��Top=�6g   $	��102��6   �� 5   
   $��Date de congé:��6   $
��Left=�6)   $��27��6D   $��
27,223,0,0q�6P   $	��Top=�6d   $	��114��6|   $ 0.466,0.982&�6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ dateCong��5      $
��Left=�6'   $��31��6B   $��156,223,0,0q�6N   $	��Top=�6c   $	��120��6{   �� 5   
   -   5         ��Name$ 
textDateAd��5      $
��Left=�6&   $��27��6A   $��156,180,0,0q�6M    �� TextWrapping$
 Wrap=�6b   $	��Top=�6v   $	��120��6�   �� 5   
   -   5         ��Name$ btnDon��5      $��Donner congé��6!   $
��Left=�68   $��38��6S   $��730,351,0,0q�6_   $	��Top=�6t   $	��126��6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5        	  Name$	 dateAd1��5      $
��Left=�6$   
   AutoGenerateColumns
 .  $	��127��6[   $��311,113,0,0q�6h   $	��Top=�6}   $	��571��6�   $ 0.443,0.948&�6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ IdAdmission��6E   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *IdAdmission+6E     5      $ ChirurgieProgramme��6L    6%   �� *ChirurgieProgramme+6L     5      $ DateAdmission��6G    6%   �� *DateAdmission+6G     5      $ DateChirurgie��6G    6%   �� *DateChirurgie+6G     5      $ 	DateConge��6C    6%   �� *	DateConge+6C     5      $ 	IdPatient��6C    6%   �� *	IdPatient+6C     5      $ 	NumeroLit��6C    6%   �� *	NumeroLit+6C   5       �� 5!   
   $��Numero Lit:��6   $
��Left=�6&   $��27��6A   $��
27,279,0,0q�6M   $	��Top=�6a   $	��102��6y   �� 5"   
   -   5        $ 	txtNumLit��5"      $
��Left=�6%   $��27��6@   $��156,279,0,0q�6L   $
 Wrap=�6a   $	��Top=�6u   $	��120��6�   �� 5#   
   $��Occupe:��6   $
��Left=�6"   $��27��6=   $��
27,328,0,0q�6I   $	��Top=�6]   $	��102��6u   �� 5$   
   -   5        $ txtOcupp��5$      $
��Left=�6$   $��27��6?   $��156,328,0,0q�6K   $
 Wrap=�6`   $	��Top=�6t   $	��120��6�   5&      5'      