   M S B A M L   `   `   `  ����E  AOnBreak1.1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:OnBreak1._1OnBreak1._1  5   	   H DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullZ=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.MetroMahApps.Metro.Behaviours 5	   	   V;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5
   	        OnBreak1._1.AdminContratos   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:OnBreak1._1     5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   N
behaviours=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.Metro  5	   	   JControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro  5
   	   -   5        (  "MahApps.Metro.Controls.MetroWindow   Name$  AdminContrato1��5       � Title$+ %OnBreak - Administracion De Contratos��5   	   $��628.571��67   $��958.241��6H    � WindowStartupLocation$ CenterScreen=�6X   ���	#FF2C2A2A$��14(�6�    � Icon$3 -imagenes/dark_logo_transparent_background.png��6�    � 
ResizeMode$ NoResize=�6�   .��5      � -   5         �Name$ dpFechaCreacion��5      .+�5   
   �� $��Numero Contrato��6   $
��Left=�6*   $��
272,62,0,0q�6E   $	��Top=�6Y   �� 5   
   $��Rut Cliente��6   $
��Left=�6&   $��272,110,0,0q�6A   $	��Top=�6V   �� 5   
   $��Razón Social��6   $
��Left=�6'   $��272,161,0,0q�6B   $	��Top=�6W   �� 5   
   $��Tipo Evento��6   $
��Left=�6&   $��272,209,0,0q�6A   $	��Top=�6V   �� 5   
   $��Fecha Creación��6   $
��Left=�6)   $��273,262,0,0q�6D   $	��Top=�6Y    J� RenderTransformOrigin$ 0.489,0.535&�6q   �� 5   
   $��Fecha Termino��6   $
��Left=�6(   $��272,310,0,0q�6C   $	��Top=�6X   $ 0.185,0.683&�6p   �� 5   
   $��	Modalidad��6   $
��Left=�6$   $��273,367,0,0q�6?   $	��Top=�6T   �� 5   
   $��Fecha y hora inicio��6   $
��Left=�6.   $��285,428,0,0q�6I   $	��Top=�6^   �� 5   
   $��Fecha y hora termino��6   $
��Left=�6/   $��284,476,0,0q�6J   $	��Top=�6_   �� 5   
   $��Cantidad Asistentes��6   $
��Left=�6.   $��
644,67,0,0q�6I   $	��Top=�6]   �� 5   
   $��Personal adicional��6   $
��Left=�6-   $��644,115,0,0q�6H   $	��Top=�6]   �� 5   
   $��Vigente��6   $
��Left=�6"   $��644,167,0,0q�6=   $	��Top=�6R   �� 5   
   $��Total a Pagar��6   $
��Left=�6(   $��644,219,0,0q�6C   $	��Top=�6X   �� 5   
   $��Observaciones��6   $
��Left=�6(   $��643,270,0,0q�6C   $	��Top=�6X   �� 5   
   -   5         ��Name$ 
txtNumCont��5      $
��Left=�6&   $��23��6A   $��
422,65,0,0q�6M    �� TextWrapping$
 Wrap=�6a   $	��Top=�6u   $	��158��6�   	 �� IsReadOnlyCaretVisible	 . {�.  6�   �� 5   
   -   5        $ 
txtRutClie��5      $
��Left=�6&   $��23��6A   $��422,113,0,0q�6M   $
 Wrap=�6b   $	��Top=�6v   $	��158��6�   �� 5   
   -   5        $ txtRazonSocial��5      $
��Left=�6*   $��23��6E   $��422,164,0,0q�6Q   $
 Wrap=�6f   $	��Top=�6z   $	��158��6�   �� 5   
   -   5        
 ��Name$
 cbxTipoEvento��5      $
��Left=�6*   $��422,212,0,0q�6E   $	��Top=�6Z   $	��158��6r   6~   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ dpFechaCreacion1��5      $
��Left=�6/   $��422,262,0,0q�6J   $	��Top=�6_   $	��158��6w      SelectedDateFormat$ Short=�6�      IsTodayHighlighted .  6�     5    
   -   5        $ dpFechaTermino��5       $
��Left=�6-   $��422,313,0,0q�6H   $	��Top=�6]   $	��157��6u   �� 5!   
   -	   5        $
 cbxModalidad��5!      $
��Left=�6)   $��422,367,0,0q�6D   $	��Top=�6Y   $	��157��6q     5"   
   -
   5        $ 	dpHoraIni��5"      $
��Left=�6(   $��422,431,0,0q�6C   $	��Top=�6X   $	��158��6p     5#   
   -   5        $ 	dpHoraTer��5#      $
��Left=�6(   $��422,479,0,0q�6C   $	��Top=�6X   $	��158��6p   �� 5$   
   -   5        $ txtCantAsis��5$      $
��Left=�6'   $��23��6B   $��
781,70,0,0q�6N   $
 Wrap=�6b   $	��Top=�6v   $	��158��6�   �� 5%   
   -   5        $ txtPersonalAd��5%      $
��Left=�6)   $��23��6D   $��781,118,0,0q�6P   $
 Wrap=�6e   $	��Top=�6y   $	��158��6�   �� 5&   
   -   5        $ txtObs��5&      $
��Left=�6"   $	��192��6=   $��643,313,0,0q�6J   $
 Wrap=�6_   $	��Top=�6s   $	��295��6�   $ 
0.832,0.17&�6�   �� 5'   
   -   5         ��Name$ checkVigencia��5'      $��
Es Vigente��6*   $
��Left=�6?   $��781,176,0,0q�6Z   $	��Top=�6o   �� 5(   
   -   5        $ txtTotalPagar��5(      $
��Left=�6)   $��23��6D   $��781,222,0,0q�6P   $
 Wrap=�6e   $	��Top=�6y   $	��158��6�   ��6�   ��  �� Path$ 
ValorTotal�� 5)   
   $��	0,0,685,0q�6   
���   �.+�5*      �� -   5        $��btnBuscarrut��5*      ���	#FF2C2A2A$��0,140,0,386q�6A      SquareButtonStyle#���   6V   .��5+      ]� $	��184��6   .+�5,      �� -   5         ��Name$ imgBuscarrut��5,      $��imagenes\IconoBuscar.png��62   $��42��6T   $��42��6`   6m   �� 5-      $��Center=�6    $��Center=�6=   Buscar Cliente6h   5.      5/      �� 50      -   5        $��btnListarCont��50      ���	#FF2C2A2A$��
0,69,0,460q�6B   #���   6V   .��51      ]� $	��184��6   .+�52      �� -   5        $ imglistacont��52      $��imagenes\IconoLista.png��62   $��42��6S   $��42��6_   6l   �� 53      $��Center=�6    $��Center=�6=   Ver Lista Contratos6m   54      55      �� 56      -   5        $��btnBuscarnum��56      ���	#FF2C2A2A$��
0,-1,0,531q�6A   #���   6U   .��57      ]� $	��184��6   .+�58      �� -   5        $ imgBuscarnum��58      $��imagenes\IconoBuscar.png��62   $��42��6T   $��42��6`   6m   �� 59      $��Center=�6    $��Center=�6=   Buscar por Numero6k   5:      5;      �� 5<      -   5        $��btnModificar��5<      ���	#FF2C2A2A$��0,214,0,307q�6A   #���   6V   .��5=      ]� $	��184��6   .+�5>      �� -   5        $ imgModificar��5>      $!��imagenes\IconoModificar.png��62   $��42��6W   $��42��6c   6p   �� 5?      $��24��6    $��79��6,   $��18(�67   	Modificar6Q   5@      5A      �� 5B      -   5        $��
btnAgregar��5B      ���	#FF2C2A2A$��0,361,0,157q�6?   #���   6T   .��5C      ]� $	��184��6   .+�5D      �� -   5        $ 
imgAgregar��5D      $��imagenes\IconoGuardar.png��60   $��42��6S   $��42��6_   6l   �� 5E      $��Center=�6    $��Center=�6=   $��25��6X   $��65��6d   $��18(�6o   	Agregar6�   5F      5G      �� 5H      -   5        $��btnMenu��5H      ���	#FF2C2A2A$��	0,522,0,0q�6<   #���   6O   .��5I      ]� $	��184��6   .+�5J      �� -   5        $ imgMenu��5J      $��imagenes\IconoMenuPeq.png��6-   $��42��6P   $��42��6\   6i   �� 5K      $��Center=�6    $��Center=�6=   $��25��6X   $��65��6d   $��18(�6o   Menu6�   5L      5M      �� 5N      -   5        $��btnCalcular��5N      ���	#FF2C2A2A$��0,293,0,239q�6@   #���   6U   .��5O      ]� $	��184��6   .+�5P      �� -   5        $ imgcalc��5P      $ ��imagenes\IconoCalcular.png��6-   $��42��6Q   $��42��6]   6j   �� 5Q      $��Center=�6    $��Center=�6=   Calcular Valor total6n   5R      5S      �� 5T      -   5        $��btnTerminar��5T      ���	#FF2C2A2A$��
0,443,0,78q�6@   #���   6T   .��5U      ]� $	��184��6   .+�5V      �� -    5        $ imgterminar��5V      $ ��imagenes\IconoEliminar.png��61   $��42��6U   $��42��6a   6n   �� 5W      $��26��6    $	��106��6,   $��18(�68   $��Right=�6F   $��Center=�6b   
Terminar6�   5X      5Y      5Z      5[      5\      