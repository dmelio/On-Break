   M S B A M L   `   `   `  ����E  AOnBreak1.1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:OnBreak1._1OnBreak1._1  5   	   H DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullZ=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.MetroMahApps.Metro.Behaviours 5
   	   V;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5   	       OnBreak1._1.CenasWPF   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:OnBreak1._1     5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5	   	   N
behaviours=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.Metro  5
   	   JControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro  5   	   )  #MahApps.Metro.Controls.ButtonHelper    PreserveTextCase  .  � Title$ OnBreak - Cenas��5   	   $	��450��6!   $	��704��6.   $��0q�5   	   (  "MahApps.Metro.Controls.MetroWindow   	GlowBrush
 �   � � Icon$3 -Imagenes/dark_logo_transparent_background.png��5      ���	#FF2C2A2A � 
ResizeMode$ NoResize=�6g    � WindowStartupLocation$ CenterScreen=�6}   .��5      � $��0,0,-0.4,-20q�6   .+�5   
   � $��
0,0,498,23q�6   
���   �.+�5      �� -   5         ��Name$ btnCancelar��5      ���	#FF2C2A2A   SquareButtonStyle#���   6B   $��0,349,-0.4,0q�6n   $��Cancelar��6�   6�   �� 5      -   5        $ 
btnAceptar��5      ���	#FF2C2A2A#���   6A   $��-1,281,0.6,68q�6m   $��Aceptar y calcular��6�   6�   �� 5      $��	0,0,0,369q�6   $��Informacion��6'   $��Center=�6=   $��Center=�6X   $��16(�6u   6�   �� 5      $��54,172,72.6,213q�6   $��	Ejecutiva��6-   $��Center=�6A   $��Center=�6\   $��16(�6y   6�   �� 5      $��54,101,52.6,284q�6   $��Celebración��6-   $��Center=�6C   $��Center=�6^   $��16(�6{   6�   5      �� 5   
   -   5         ��Name$ cbxAmbientacion��5      $
��Left=�6,   $��
373,59,0,0q�6G   $	��Top=�6[   $	��193��6s   �� 5   
   $��Ambientacion��6   $
��Left=�6'   $��
243,59,0,0q�6B   $	��Top=�6V   �� 5   
   -   5         ��Name$ 	chkMusica��5      $��Musica Ambinetal��6&   $
��Left=�6A   $��373,104,0,0q�6\   $	��Top=�6q   �� 5   
   -   5        $ chkLocal��5      $��Local Onbreak��6%   $
��Left=�6=   $��373,146,0,0q�6X   $	��Top=�6m   �� 5   
   $��Valor Arriendo��6   $
��Left=�6)   $��243,188,0,0q�6D   $	��Top=�6Y   �� 5   
   -   5        	 ��Name$	 txtValorarriendo��5      $
��Left=�6,   $��23��6G   $��376,188,0,0q�6S   
 �� TextWrapping$

 Wrap=�6h   $	��Top=�6|   $	��190��6�   �� 5   
   $��	Modalidad��6   $
��Left=�6$   $��243,242,0,0q�6?   $	��Top=�6T   �� 5   
   $��Cantidad Asistentes��6   $
��Left=�6.   $��243,286,0,0q�6I   $	��Top=�6^   �� 5   
   $��Personal adicional��6   $
��Left=�6-   $��243,331,0,0q�6H   $	��Top=�6]   �� 5    
   $��Valor total��6   $
��Left=�6&   $��246,374,0,0q�6A   $	��Top=�6V    J� RenderTransformOrigin$ 0.225,-0.375&�6n   �� 5!   
   -   5        $ cbxModalidadCena��5!      $
��Left=�6-   $��376,242,0,0q�6H   $	��Top=�6]   $	��190��6u   6�   �� 5"   
   -   5        $	 txtCantAsis��5"      $
��Left=�6'   $��23��6B   $��378,288,0,0q�6N   $

 Wrap=�6c   $	��Top=�6w   $	��188��6�   �� 5#   
   -	   5        $	 	txtPerAdd��5#      $
��Left=�6%   $��23��6@   $��378,331,0,0q�6L   $

 Wrap=�6a   $	��Top=�6u   $	��188��6�   �� 5$   
   -
   5        $	 txtTotal��5$      $
��Left=�6$   $��23��6?   $��378,374,0,0q�6K   $

 Wrap=�6`   $	��Top=�6t   $	��188��6�   �� 5%   
   $��Personal Base:��6   $
��Left=�6)   $��571,331,0,0q�6D   $	��Top=�6Y   �� 5&   
   $��Valor Base(UF)��6   $
��Left=�6)   $��571,374,0,0q�6D   $	��Top=�6Y   �� 5'   
   -   5         ��Name$ lblPersonalBase��5'      $�� ��6)   $
��Left=�64   $��661,331,0,0q�6O   $	��Top=�6d   ���	#FFF7F7F7
���   �$��27��6�   �� 5(   
   -   5        $ lblValorBase��5(      $�� ��6&   $
��Left=�61   $��661,374,0,0q�6L   $	��Top=�6a   $��27��6y   ���	#FFF9F1F1���	#FF0503036�   �� 5)   
   $��Numero contrato��6   $
��Left=�6*   $��
243,12,0,0q�6E   $	��Top=�6Y   �� 5*   
   -   5        $	 	txtNumero��5*      $
��Left=�6%   $��23��6@   $��
373,12,0,0q�6L   $

 Wrap=�6`   $	��Top=�6t   $	��193��6�   {�.  6�   5+      5,      