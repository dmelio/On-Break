   M S B A M L   `   `   `  ����E  AOnBreak1.1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:OnBreak1._1OnBreak1._1  5   	   H DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullZ=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.MetroMahApps.Metro.Behaviours 5	   	   V;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5
   	       OnBreak1._1.ListaClientes   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:OnBreak1._1     5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   N
behaviours=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.Metro  5	   	   JControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro  5
   	   -   5        (  "MahApps.Metro.Controls.MetroWindow   Name$  ListaCliente��5       � Title$ OnBreak - Lista Clientes��5   	   $	��540��6*   $��954.4��67   $��0q�5   	      	GlowBrush
 �   � � Icon$3 -Imagenes/dark_logo_transparent_background.png��5      ���	#FF2C2A2A � 
ResizeMode$ NoResize=�6g    � WindowStartupLocation$ CenterScreen=�6}   .��5      � $��0,0,-6,0q�6   .+�5   
   � $��	0,0,714,0q�6   
���   �.+�5      �� -   5         ��Name$ btnmenuprinc��5      $��	0,263,0,0q�6+   
���   �.��5      �� -   5         ��Name$ imgMenuPrinc��5      $��Center=�6.   $	��248��6K   $��Center=�6X   $	��240��6s   $-��'Imagenes/white_logo_dark_background.jpg��6    J� Opacity$	 0.5Q�6�   	 � ToolTip	 5      �� 5      .+�5      �� $
��Bold"�6$   	OnBreak6@   �� 5      $
��Bold"�6$   $��Oblique$�66   " Cierra ventana lista de clientes6l   5      5      �� 5      $��95,10,95,467q�6   $��Filtrar��6*   $��Center=�6<   $��Center=�6W   $��16(�6t   $��34��6�   6�   �� 5      -   5        $��btnBuscadorRut��5      ���	#FF2C2A2A$��
0,49,0,410q�6C      SquareButtonStyle#���   6W   .��5      ]� $��33��6   $	��195��6(   .+�5      �� -   5        $ imgBuscador��5   7   $��Center=�6   $��Imagenes\IconoBuscar.png��6L   $��43��6n   $��0,0,0,4q�6y   �� 5      $��Center=�6    $��14(�6;   Filtrar por rut6Z   5      	 5      �� 5       .+�5!      �� $
��Bold"�6$   Filtrar por RUT6G   �� 5"      $
��Bold"�6$   $��Oblique$�66   ><Filtra lista de clientes por rut ingresado en el campo "Rut"6�   5#      5%      �� 5&      -   5        $��btnFiltrarporte��5&      ���	#FF2C2A2A#���   6D   $��0,101,0,356q�6p   .��5'      ]� $��33��6   .+�5(      �� -   5        $ imgBuscadorte��5(   7   $��Center=�6   $��Imagenes\IconoBuscar.png��6N   $��43��6p   $��0,0,0,4q�6{   �� 5)      $��Center=�6    $��14(�6;   Filtrar por Tipo empresa6c   5*      	 5+      �� 5,      .+�5-      �� $
��Bold"�6$   Filtrar tipo Empresa6L   �� 5.      $
��Bold"�6$   $��Oblique$�66   sqFiltra lista de clientes y muestra solo las coincidencias con el tipo de empresa indicado en campo "Tipo Empresa"6�   5/      51      �� 52      -   5        $��btnFiltrarporAct��52      ���	#FF2C2A2A#���   6E   $��0,155,0,302q�6q   .��53      ]� $��33��6   $	��195��6(   .+�54      �� -	   5        $ imgBuscadoract��54   7   $��Center=�6   $��Imagenes\IconoBuscar.png��6O   $��43��6q   $��0,0,0,4q�6|   �� 55      $��Center=�6    $��14(�6;   Filtrar por Actividad6`   56      	 57      �� 58      .+�59      �� $
��Bold"�6$   Filtrar por Actividad6M   �� 5:      $
��Bold"�6$   $��Oblique$�66   jhFiltra lista de clientes y muestra solo las coincidencias con la Actividad indicada en campo "Actividad"6�   5;      5=      �� 5>      -
   5        $��btnQuitarfiltro��5>      ���	#FF2C2A2A$��0,209,0,248q�6D   #���   6Y   .��5?      ]� $��Center=�6   $��Center=�67   $��23��6T   .+�5@      �� $��80��6    $��23��6+   $��Center=�67   $��Center=�6R   $��14(�6o   Quitar Filtro6�   5A      	 5B      �� 5C      .+�5D      �� $
��Bold"�6$   Quitar filtro6E   �� 5E      $
��Bold"�6$   $��Oblique$�66   /-Se muestra lista completa sin aplicar filtros6y   5F      5H      5I      �� 5J   
   $	��Rut��6   $
��Left=�6   $��
405,34,0,0q�69   $	��Top=�6M   $��14(�6e   $	��170��6s   
 J� RenderTransformOrigin$
 0.5,0.5&�6   �� 5K   
   $��Tipo Empresa��6   $��Right=�6'   $��
0,83,455,0q�6C   $	��Top=�6W   $��14(�6o   �� 5L   
   $��	Actividad��6   $
��Left=�6$   $��405,141,0,0q�6?   $	��Top=�6T   $��14(�6l   �� 5M   
   -   5         ��Name$ txtBuscador��5M      $
��Left=�6'   $��32��6B   $��
504,31,0,0q�6N    �� TextWrapping$
 Wrap=�6b   $	��Top=�6v   $	��240��6�   �� 5N   
   -   5         ��Name$ cbxlistTipoEmp��5N      $
��Left=�6+   $��
504,83,0,0q�6F   $	��Top=�6Z   $	��240��6r   $��32��6~   	 5O      �� 5P      .+�5Q      �� $
��Bold"�6    Tipo Empresa6@   �� 5R      $
��Bold"�6    $��Oblique$�62   #!Seleccionar tipo empresa a buscar6i   5S      5U      �� 5V   
   -   5        $ 
cbxListAct��5V      $
��Left=�6'   $��504,137,0,0q�6B   $	��Top=�6W   $	��240��6o   $��32��6{   	 5W      �� 5X      .+�5Y      �� $
��Bold"�6    	Actividad6=   �� 5Z      $
��Bold"�6    $��Oblique$�62    Seleccionar Actividad a buscar6f   5[      5]      &   System.Windows.Controls.DataGrid  5^   
   -   5        $��dtgClientes��5^   /      AutoGenerateColumns .  $��240,206,10,10q�6B      Columns 5_      0  *System.Windows.Controls.DataGridTextColumn  5`      -   5        
dtgRutclie��,  &System.Windows.Controls.DataGridColumn   Header$ Rut Cliente��5`   9      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6r   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6N   ��  �� Path$ 
RutCliente�6r     5a      -   5        dtgRazonsocial��$ Razon Social��5a   =   $ * 6x      
IsReadOnly .  6S   �� $ RazonSocial�6�     5b      -   5        dtgNombreCont��$ Nombre��5b   <   $ * 6t    .  6L   �� $ NombreContacto�6~     5c      -   5        dtgMail��$ Correo��5c   6   $ * 6l    .  6F   �� $ MailContacto�6v     5d      -   5        dtgDireccion��$ 	Direccion��5d   ;   $ * 6q    .  6N   �� $ 	Direccion�6{     5e      -   5        dtgTelefono��$ Telefono��5e   :   $ * 6n    .  6L   �� $ Telefono�6x     5f      -   5        dtgActividad��$ 	Actividad��5f   ;   $ * 6{    .  6N   �� $ DescripcionTipoAct1�6�     5g      -   5        
dtgTipoEmp��$ Tipo Empresa��5g   9   $ * 6y    .  6O   �� $ DescripcionTipoe�6�   5i      5j      5k      