   M S B A M L   `   `   `  ����E  AOnBreak1.1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:OnBreak1._1OnBreak1._1  5   	   H DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullZ=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.MetroMahApps.Metro.Behaviours 5	   	   V;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5
   	       OnBreak1._1.AdminClie   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:OnBreak1._1     5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   N
behaviours=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.Metro  5	   	   JControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro  5
   	   -   5        (  "MahApps.Metro.Controls.MetroWindow   Name$  AdmClientes��5       � Title$* $OnBreak - Administracion de Clientes��5   	   $��525.699��66   $��648.329��6G    � WindowStartupLocation$ CenterScreen=�6W   ���	#FF2C2A2A$��14(�6�    � Icon$3 -imagenes/dark_logo_transparent_background.png��6�   .��5      � $��0,0,0,-1q�6   .+�5   
   � $��	0,0,360,0q�6   
���   �.+�5      �� -   5        $��	btnBuscar��5      ���	#FF2C2A2A$��	0,0,0,403q�6>      SquareButtonStyle#���   6Q   .��5      ]� $	��203��6   $��75��6(   .+�5      �� -   5         ��Name$ 	imgBuscar��5      $��imagenes\IconoBuscar.png��6/   $��64��6Q   $��65��6]   �� 5      $��Right=�6    $��Center=�6<   $��25��6W   $	��104��6c   $��18(�6o   $
��0,25q�6}   Buscar6�   5       � ToolTip 5      �� 5      .+�5      �� $
��Bold"�6$   Buscar6>   �� 5      $
��Bold"�6$   $��Oblique$�66   ^\Realiza busqueda de rut ingresado, si no ingresa rut despliega ventana con lista de clientes6�   5      5      �� 5      -   5        $��btnMenu��5      ���	#FF2C2A2A$��	0,351,0,0q�6<   #���   6O   .��5      ]� $	��210��6   $��75��6(   .+�5      �� $4��.Imagenes\white_logo_transparent_background.png��6   6V   �� 5      $��Center=�6    $��Center=�6=   $��24��6X   $	��123��6d   $��18(�6p   $��	0,26,0,25q�6~   Menu Principal6�   5       5      �� 5       .+�5!      �� $
��Bold"�6$   Menu6<   �� 5"      $
��Bold"�6$   $��Oblique$�66   Vuelve al menu principal6d   5#      5%      �� 5&      -   5        $��btnEliminar��5&      ���	#FF2C2A2A$��0,268,0,147q�6@   #���   6U   .��5'      ]� $	��203��6   $��75��6(   .+�5(      �� -   5        $ imgEliminar��5(      $ ��imagenes\IconoEliminar.png��61   $��64��6U   $��65��6a   6n   �� 5)      $��Right=�6    $��Center=�6<   $��25��6W   $	��101��6c   $��18(�6o   $
��0,25q�6}   
Eliminar6�   5*       5+      �� 5,      .+�5-      �� $
��Bold"�6$   
Eliminar6@   �� 5.      $
��Bold"�6$   $��Oblique$�66   20Elimina cliente correspondiente al rut ingresado6|   5/      51      �� 52      -   5        $��btnModificar��52      ���	#FF2C2A2A$��0,181,0,230q�6A   #���   6V   .��53      ]� $	��203��6   $��75��6(   .+�54      �� -   5        $ imgModificar��54      $!��imagenes\IconoModificar.png��62   $��64��6W   $��65��6c   6p   �� 55      $��Right=�6    $��Center=�6<   $��24��6W   $	��102��6c   $��18(�6o   $��	0,26,0,25q�6}   	Modificar6�   56       57      �� 58      .+�59      �� $
��Bold"�6$   	Modificar6A   �� 5:      $
��Bold"�6$   $��Oblique$�66   53Actualiza cliente con las modificaciones realizadas6   5;      5=      �� 5>      -	   5        $��
btnGuardar��5>      ���	#FF2C2A2A$��
0,95,0,317q�6?   #���   6S   .��5?      ]� $	��203��6   $��75��6(   .+�5@      �� -
   5        $ 
imgAgregar��5@      $��imagenes\IconoGuardar.png��60   $��64��6S   $��65��6_   6l   �� 5A      $��Right=�6    $��Center=�6<   $��24��6W   $	��100��6c   $��18(�6o   $��	0,26,0,25q�6}   	Agregar6�   5B       5C      �� 5D      .+�5E      �� $
��Bold"�6$   	Agregar6?   �� 5F      $
��Bold"�6$   $��Oblique$�66   ,*Permite Agregar cliente a la base de datos6v   5G      5I      5J      �� 5K   
   -   5         ��Name$ txtRut��5K      $
��Left=�6"   $��24��6=   $��
444,49,0,0q�6I    �� TextWrapping$
 Wrap=�6]   $	��Top=�6q   $	��155��6�   �� 5L   
   -   5        $ txtRazonSocial��5L      $
��Left=�6*   $��23��6E   $��444,100,0,0q�6Q   $
 Wrap=�6f   $	��Top=�6z   $	��155��6�   �� 5M   
   -   5        $ 	txtNombre��5M      $
��Left=�6%   $��24��6@   $��445,150,0,0q�6L   $
 Wrap=�6a   $	��Top=�6u   $	��155��6�   �� 5N   
   -   5        $ txtDireccion��5N      $
��Left=�6(   $��23��6C   $��444,199,0,0q�6O   $
 Wrap=�6d   $	��Top=�6x   $	��154��6�   �� 5O   
   -   5        $ txtMail��5O      $
��Left=�6#   $��23��6>   $��444,250,0,0q�6J   $
 Wrap=�6_   $	��Top=�6s   $	��154��6�   �� 5P   
   -   5        $ txtTelefono��5P      $
��Left=�6'   $��22��6B   $��445,302,0,0q�6N   $
 Wrap=�6c   $	��Top=�6w   $	��154��6�   �� 5Q   
   -   5         ��Name$ cbxActividad��5Q      $
��Left=�6)   $��445,409,0,0q�6D   $	��Top=�6Y   $	��154��6q   �� 5R   
   -   5        $ 
cbxTipoemp��5R      $
��Left=�6'   $��445,359,0,0q�6B   $	��Top=�6W   $	��154��6o   �� 5S   
   $	��Rut��6   $
��Left=�6   $��
350,49,0,0q�69   $	��Top=�6M   $��14(�6e   �� 5T   
   $��Razon Social��6   $
��Left=�6'   $��349,100,0,0q�6B   $	��Top=�6W   $��14(�6o   �� 5U   
   $��Nombre��6   $
��Left=�6!   $��349,147,0,0q�6<   $	��Top=�6Q   $��14(�6i   �� 5V   
   $��	Direccion��6   $
��Left=�6$   $��350,199,0,0q�6?   $	��Top=�6T   $��14(�6l   �� 5W   
   $��Telefono��6   $
��Left=�6#   $��350,302,0,0q�6>   $	��Top=�6S   $��14(�6k   �� 5X   
   $��	Actividad��6   $
��Left=�6$   $��349,356,0,0q�6?   $	��Top=�6T   	 J� RenderTransformOrigin$	 0.503,0.598&�6l   �� 5Y   
   $��Tipo Empresa��6   $
��Left=�6'   $��350,406,0,0q�6B   $	��Top=�6W   �� 5Z   
   $
��Mail��6   $
��Left=�6   $��350,250,0,0q�6:   $	��Top=�6O   5[      5\      