   M S B A M L   `   `   `  ����K  GRegistroCompleto, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:RegistroCompletoRegistroCompleto  5   	   !    RegistroCompleto.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:RegistroCompleto     5   	     � Title$  Registro Completo��5   	   $	��400��6#   $	��400��60   .��5	      � .+�5
      �� $��	10,5,10,0q�6   .+�5      ��  �� Orientation$ 
Horizontal=�6   $	��0,5q�6*   .+�5   	   �� $	��ID:��6   $
��Bold"�6   �� 5   	   -   5         ��Name$ 	IDTextBox��5      $
��48,0q�6$   $��0��62   $��75��6;   �� 5   	   -   5         ��Name$ BuscarButton��5      $	��5,0q�6(   $	��110��67   .��5   	   �� $ 
Horizontal=�6   .+�5      �� $��/buscar.png��6   $��20��61   $��20��6<   �� 5      $��Buscar��6   $
��Bold"�6.   5      5      5      �� 5   	   $ 
Horizontal=�6   $	��0,5q�6-   .+�5      �� $��Nombres:��6   $
��Bold"�6(   �� 5      -   5        $ NombresTextBox��5      $
��10,0q�6.   $	��240��6<   ��6H   �� *	Nombres+5   
   �� 5!      $ 
Horizontal=�6   $	��0,5q�6,   .+�5"      �� $��	Telefono:��6   $
��Bold"�6)   �� 5#      -   5        $ TelefonoTextBox��5#      $
��12,0q�6/   $	��240��6=   ��6I   �� *
Telefono+5$   
   �� 5&      $ 
Horizontal=�6   $	��0,5q�6,   .+�5'      �� $��Cedula:��6   $
��Bold"�6'   �� 5(      -   5        $ CedulaTextBox��5(      $
��20,0q�6-   $	��240��6;   ��6G   �� *Cedula+5)      �� 5+   	   $ 
Horizontal=�6   $	��0,5q�6-   .+�5,      �� $��
Direccion:��6   $
��Bold"�6*   �� 5-      -   5        $ DireccionTextBox��5-      $
��10,0q�60   $	��240��6>   ��6J   �� *	Direccion+5.   
   �� 50   	   $ 
Horizontal=�6   $	��0,5q�6-   .+�51      �� $��Fecha Nacimiento:��6   $
��Bold"�61   (  "System.Windows.Controls.DatePicker  52      -   5          Name$ FechaTextBox��52      $
��10,0q�6/   $	��193��6=      Text 6J   �� *FechaNacimiento+53   
   �� 56   
   $ 
Horizontal=�6   $
��0,15q�6.   .+�57      �� -   5        $ NuevoButton��57      $
��10,0q�6(   $��80��66   .��58      �� $ 
Horizontal=�6   .+�59      �� $��
/nuevo.png��6   $��20��60   $��20��6;   �� 5:      $��Nuevo��6   $
��Bold"�6-   5;      5<      �� 5>      -	   5        $ GuardarButton��5>      $
��10,0q�6+   $��80��69   .��5?      �� $ 
Horizontal=�6   .+�5@      �� $��/guardar.png��6   $��20��62   $��20��6=   �� 5A      $��Guardar��6   $
��Bold"�6/   5B      5C      �� 5E      -
   5        $ EliminarButton��5E      $
��10,0q�6,   $��80��6:   .��5F      �� $ 
Horizontal=�6   .+�5G      �� $��/eliminar.png��6   $��20��63   $��20��6>   �� 5H      $��Eliminar��6   $
��Bold"�60   5I      5J      5K      5L      5M      5N      