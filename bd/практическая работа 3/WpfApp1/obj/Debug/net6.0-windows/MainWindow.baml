   M S B A M L   `   `   `  ????B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     ? Title$-  'Практическая работа 3??5   	   $	??450??6'   $	??800??64   .??5	      ?  ? RowDefinitions 5
   
   ?? 5      6   ?? 5      6   ?? 5      6   ?? 5      6   ?? 5      6   ?? 5      6   ?? 5      6   ?? 5      6   ?? 5      6   ?? 5      6   ?? 5      6    ? ColumnDefinitions 5   
   ?? 5      $	??40* ?6   6-   ?? 5      $
??315* ?6   6.   ?? 5      $	??47* ?6   6-   ?? 5      $
??400* ?6   6.   .+?5   
   ?? $??1??6   $??Center=?6$   $??1??6A   $
??Wrap=?6N   $??Первое число??6b   $??Center=?6v    ?? TextAlignment$ Center=?6?   $??15(?6?   ?? 5    
   -   5         ??Name$ TextBox1??5       $??1??6H   $??2??6X    ?? TextWrapping$
 Wrap=?6e   $?? ??6y   ?? 5"   
   $??1??6   $??Center=?6$   $??5??6A   $
??Wrap=?6N   $??Второе число??6b   $??Center=?6v   $ Center=?6?   $??15(?6?   ?? 5#   
   -   5        $ TextBox2??5#      $??1??6G   $??6??6W   $
 Wrap=?6d   $?? ??6x   ?? 5%   
   $??1??6   $??Center=?6$   $??8??6A   $
??Wrap=?6N   $??Результат??6b   $??Center=?6s   $ Center=?6?   $??15(?6?   ?? 5&   
   -   5         ??Name$ resulttextblock??5&      $??1??6-   $??9??6=   $?? ??6J   $??Center=?6R   $??Center=?6o   $??15(?6?   	? 5(   
   -   5         	?Name$ addition??5(      $??3??6?   $??Сложение??6O   $??Center=?6b   $??Center=?6   $??3??6?   $??Center=?6?   $??Center=?6?   $??15(?6?   	? 5)   
   -   5        $ 
difference??5)      $??3??6C   $??Вычитание??6S   $??Center=?6g   $??Center=?6?   $??4??6?   $??Center=?6?   $??Center=?6?   $??15(?6?   	? 5*   
   -   5        $ multiplication??5*      $??3??6K   $??Умножение??6[   $??Center=?6o   $??Center=?6?   $??5??6?   $??Center=?6?   $??Center=?6?   $??15(?6?   	? 5+   
   -   5        $ division??5+      $??3??6?   $??Деление??6O   $??Center=?6a   $??Center=?6~   $??6??6?   $??Center=?6?   $??Center=?6?   $??15(?6?   	? 5,   
   -   5        $ remainsd??5,      $??3??6?   $(??"Остаток от деления??6O   $??Center=?6l   $??Center=?6?   $??7??6?   $??Center=?6?   $??Center=?6?   $??15(?6?   	? 5-   
   -	   5        $ degree??5-      $??3??6;   $,??&Возведение в степень??6K   $??Center=?6j   $??Center=?6?   $??8??6?   $??Center=?6?   $??Center=?6?   $??15(?6?   ?? 5/   
   
???   ?$??3q?6%   $??3??69   $??3??6I   $??6??6V    ?? CornerRadius$ 30??6g   50      51      