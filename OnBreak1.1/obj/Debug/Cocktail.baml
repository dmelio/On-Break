   M S B A M L   `   `   `  ����E  AOnBreak1.1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:OnBreak1._1OnBreak1._1  5   	   H DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullZ=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.MetroMahApps.Metro.Behaviours 5
   	   V;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5   	       OnBreak1._1.Cocktail   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:OnBreak1._1     5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5	   	   N
behaviours=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.Metro  5
   	   JControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro  5   	   )  #MahApps.Metro.Controls.ButtonHelper    PreserveTextCase  .  � Title$ OnBreak - Cocktail��5   	   $	��450��6$   $��734.203��61   $��0q�5   	   (  "MahApps.Metro.Controls.MetroWindow   	GlowBrush
 �   � � Icon$3 -Imagenes/dark_logo_transparent_background.png��5      ���	#FF2C2A2A � 
ResizeMode$ NoResize=�6g    � WindowStartupLocation$ CenterScreen=�6}   .��5      � .+�5   
   � $��	0,0,498,0q�6   
���   �.+�5      �� -   5         ��Name$ btnCancelar��5      ���	#FF2C2A2A   SquareButtonStyle#���   6B   $��-1,339,0,10q�6n   $��Cancelar��6�   6�   �� 5      -   5        $ 
btnAceptar��5      ���	#FF2C2A2A#���   6A   $��0,263,-1,86q�6m   $��Aceptar��6�   6�   �� 5      $��	0,0,0,369q�6   $��Informacion��6'   $��Center=�6=   $��Center=�6X   $��16(�6u   6�   �� 5      $��38,93,54,295q�6   $��Quick Cocktail��6*   $��Center=�6C   $��Center=�6^   $��16(�6{   6�   �� 5      $��38,176,33,212q�6   $��Ambient Cocktail��6+   $��Center=�6F   $��Center=�6a   $��16(�6~   6�   5      �� 5   
   $��Personal Base:��6   $
��Left=�6)   $��573,286,0,0q�6D   $	��Top=�6Y   �� 5   
   $��Valor Base(UF)��6   $
��Left=�6)   $��575,342,0,0q�6D   $	��Top=�6Y   �� 5   
   -   5         ��Name$ lblPersonalBase��5      $�� ��6)   $
��Left=�64   $��663,286,0,0q�6O   $	��Top=�6d   ���	#FFF7F7F7
���   �$��27��6�   �� 5   
   -   5        $ lblValorBase��5      $�� ��6&   $
��Left=�61   $��666,342,0,0q�6L   $	��Top=�6a   $��27��6y   ���	#FFF9F1F1���	#FF0503036�   �� 5   
   $��Ambientacion��6   $
��Left=�6'   $��
255,70,0,0q�6B   $	��Top=�6V   �� 5   
   -   5         ��Name$ 
cbxAmbient��5      $
��Left=�6'   $��
372,70,0,0q�6B   $	��Top=�6V   $	��189��6n   	� 5   
   -   5        	 	�Name$	 rbMusicaAmb��5      $��Musica Ambiental��6+   $
��Left=�6F   $��262,125,0,0q�6a   $	��Top=�6v   
 	� 	GroupName$
 MusicaCocktail��6�   	� 5   
   -   5        $	 rbMusicaClie��5      $��Musica Cliente��6,   $
��Left=�6E   $��420,125,0,0q�6`   $	��Top=�6u   $
 MusicaCocktail��6�   �� 5   
   $��	Modalidad��6   $
��Left=�6$   $��255,182,0,0q�6?   $	��Top=�6T   �� 5    
   $��Cantidad asistentes��6   $
��Left=�6.   $��255,235,0,0q�6I   $	��Top=�6^    J� RenderTransformOrigin$ 0.566,0.098&�6v   �� 5!   
   $��Personal Adicional��6   $
��Left=�6-   $��255,286,0,0q�6H   $	��Top=�6]   �� 5"   
   $��Valor total��6   $
��Left=�6&   $��255,342,0,0q�6A   $	��Top=�6V   $ 0.003,0.684&�6n   �� 5#   
   -   5        $ cbxMod��5#      $
��Left=�6#   $��372,181,0,0q�6>   $	��Top=�6S   $	��189��6k   6w   �� 5$   
   -	   5         ��Name$ txtCantAsis��5$      $
��Left=�6'   $��23��6B   $��372,235,0,0q�6N    �� TextWrapping$
 Wrap=�6c   $	��Top=�6w   $	��189��6�   �� 5%   
   -
   5        $ 	txtPerAdd��5%      $
��Left=�6%   $��23��6@   $��372,286,0,0q�6L   $
 Wrap=�6a   $	��Top=�6u   $	��189��6�   �� 5&   
   -   5        $ txttotal��5&      $
��Left=�6$   $��23��6?   $��372,342,0,0q�6K   $
 Wrap=�6`   $	��Top=�6t   $	��189��6�   �� 5'   
   $��Numero contrato��6   $
��Left=�6*   $��
255,14,0,0q�6E   $	��Top=�6Y   �� 5(   
   -   5        $ 	txtNumero��5(      $
��Left=�6%   $��23��6@   $��
372,16,0,0q�6L   $
 Wrap=�6`   $	��Top=�6t   $	��189��6�   5)      5*      