   M S B A M L   `   `   `  ����E  AOnBreak1.1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:OnBreak1._1OnBreak1._1  5   	   H DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullZ=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.MetroMahApps.Metro.Behaviours 5	   	   V;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5
   	        OnBreak1._1.ListaContratos   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:OnBreak1._1     5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   N
behaviours=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.Metro  5	   	   JControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro  5
   	   -   5        (  "MahApps.Metro.Controls.MetroWindow   Name$  listaContratos��5       � Title$ Lista de Contratos��5   	   $��560.844��6$   $��1182.95��65   $��0q�5   	      	GlowBrush
 �   � � Icon$3 -Imagenes/dark_logo_transparent_background.png��5      ���	#FF2C2A2A � 
ResizeMode$ NoResize=�6g    � WindowStartupLocation$ CenterScreen=�6}   .��5      � .+�5   
   � $��	0,0,932,0q�6   
���   �.+�5      �� -   5        $��btnAtras��5      $��	0,310,0,0q�6%   
���   �.��5      �� $��Center=�6   $	��248��65   $��Center=�6B   $	��240��6]   $-��'Imagenes/white_logo_dark_background.jpg��6i    J� Opacity$	 0.5Q�6�   6�   5      �� 5      $��Filtrar��6   $��Center=�6&   $��Center=�6A   $��36��6^   $��102,10,90,486q�6j   $��16(�6�   $��53��6�   6�   �� 5      -   5        $��btnQuitarfiltro��5      ���	#FF2C2A2A$��0,245,0,227q�6D      SquareButtonStyle#���   6Y   .��5      ]� $��Center=�6   $��Center=�67   $��23��6T   .+�5      �� $��70��6    $��23��6+   $��Center=�67   $��Center=�6R   Quitar Filtro6~   5      5      �� 5      -   5        $��btnBuscNumcont��5      ���	#FF2C2A2A$��
0,46,0,438q�6C   #���   6W   .��5      ]� $	��180��6   .+�5      �� -   5         ��Name$ imgBuscNumcont��5      $��Imagenes\IconoBuscar.png��64   $��27��6V   $��32��6b   6o   �� 5      $��Center=�6    $��Center=�6;   $��18��6X   $	��119��6d   Filtrar por Numero6�   5      5      �� 5      -   5        $��
btnBuscRut��5      ���	#FF2C2A2A$��
0,94,0,389q�6?   #���   6S   .��5       ]� $	��180��6   .+�5!      �� -   5        $ imgBuscadorrut��5!      $��Imagenes\IconoBuscar.png��64   $��27��6V   $��32��6b   6o   �� 5"      $��Center=�6    $��Center=�6;   $��19��6X   $	��122��6d   Filtrar por Rut6�   5#      5$      �� 5%      -   5        $��btnBusctipoe��5%      ���	#FF2C2A2A$��0,143,0,337q�6A   #���   6V    J� RenderTransformOrigin$ 0.5,0.5&�6�   .��5&      ]� $	��185��6   .+�5'      �� -	   5        $ imgBuscadortipoe��5'      $��Imagenes\IconoBuscar.png��66   $��27��6X   $��35��6d   6q   �� 5(      $��Center=�6    $��Center=�6;   Filtrar por Tipo Evento6q   5)      5*      �� 5+      -
   5        $��
btnBuscMod��5+      ���	#FF2C2A2A$��0,195,0,287q�6?   #���   6T   .��5,      ]� $��25��6   $	��220��6(   .+�5-      �� -   5        $ 
imgBuscmod��5-      $��Imagenes\IconoBuscar.png��60   $��27��6R   $��62��6^   $��0,0,0,-2q�6i   6}   �� 5.      $��Center=�6    $
��Left=�6;   Filtrar por Modalidad6m   5/      50      51      �� 52   
   -   5        	 ��Name$	 
txtNumCont��52      $
��Left=�6&   $��23��6A   $��
631,21,0,0q�6M   
 �� TextWrapping$

 Wrap=�6a   $	��Top=�6u   $	��204��6�   �� 53   
   $��Numero Contrato��6   $
��Left=�6*   $��
497,21,0,0q�6E   $	��Top=�6Y   $��12(�6q   �� 54   
   $��Rut Cliente��6   $
��Left=�6&   $��
497,65,0,0q�6A   $	��Top=�6U   �� 55   
   $��Tipo Evento��6   $
��Left=�6&   $��497,109,0,0q�6A   $	��Top=�6V   $ 0.544,1.324&�6n   �� 56   
   $��Modalidad Serv.��6   $
��Left=�6*   $��497,154,0,0q�6E   $	��Top=�6Z   $	��104��6r   �� 57   
   -   5        $	 
txtRutClie��57      $
��Left=�6&   $��23��6A   $��
631,65,0,0q�6M   $

 Wrap=�6a   $	��Top=�6u   $	��204��6�   �� 58   
   -   5         ��Name$ 	cbxTipEve��58      $
��Left=�6&   $��631,109,0,0q�6A   $	��Top=�6V   $	��204��6n   �� 59   
   -   5        $ cbxMod��59      $
��Left=�6#   $��631,154,0,0q�6>   $	��Top=�6S   $	��204��6k   &   System.Windows.Controls.DataGrid  5:   
   -   5        $��dtgContratos��5:   /      AutoGenerateColumns .  $��250,225,0,10q�6C   ��. ! �� IsDeferredScrollingEnabled .  $��Visible=�5;   C      Columns 5<      0  *System.Windows.Controls.DataGridTextColumn  5=      -   5        	dtgNumero��,  &System.Windows.Controls.DataGridColumn   Header$ ID��5=   8   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6D   ��  �� Path$ Numero�  5>      -   5        dtgCreacion��$ Creacion��5>   :      
IsReadOnly .  6L   �� $ Creacion�6n     5?      -   5        
dtgTermino��$ Termino��5?   9    .  6J   �� $ Termino�6k     5@      -   5        
dtgrut��$ Rut Cliente��5@   5    .  6J   �� $ 
RutCliente�6n     5A      -   5        dtgModalidad��$ 	Modalidad��5A   ;    .  6N   �� $ DescripcionModalidad�6|     5B      -   5        dtgTipo��$ 
TipoEvento��5B   6    .  6J   �� $ DescripcionTipoEvento�6y     5C      -   5        
dtgHoraini��$ Hora Inicio��5C   9    .  6N   �� $ FechaHoraInicio�6w     5D      -   5        
dtgHoraTer��$ Hora Termino��5D   9    .  6O   �� $ FechaHoraTermino�6y     5E      -   5        dtgAsis��$ 
Asistentes��5E   6    .  6J   �� $ 
Asistentes�6o     5F      -   5        dtgPersonal��$ Personal extra��5F   :    .  6R   �� $ PersonalAdicional�6}     5G      -   5        dtgVigencia��$ 
Es vigente��5G   :    .  6N   �� $ 	Realizado�6q     5H      -   5        dtgValor��$ Valor Total��5H   7    .  6L   �� $ ValorTotalContrato�6x     5I      -   5        
dtgObs��$ Observaciones��5I   5    .  6L   �� $ Observaciones�6s   5K      5L      5M      