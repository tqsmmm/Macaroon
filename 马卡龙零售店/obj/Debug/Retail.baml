   M S B A M L   `   `   `  ????  马卡龙零售店    马卡龙零售店.Retail   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -   5          N? 
FontFamily$  Microsoft YaHei)?5       N? FontSize$ 15(?6$   .??5      ]? .+?5	   
   ]? $	??350??6   .+?5
      ?? $??Bottom=?6   .+?5      ? -   5        $??gMember??5      
???????$??2q?6>    ? ColumnDefinitions 5      ?? 5      $	??100 ?6+   ?? 5       ? RowDefinitions 5      ?? 5      $??40 ?6(   ?? 5      $??40 ?6(   .+?5      ?? $??
Member.png??6   $??2??60   ?? 5      -   5        $??tb_Member_Code??5       $??Center=?66   $??1??6S   ?? 5      -   5        $??tb_Member_Balance??5       $??Center=?69   $
??0.00??6V   $??1??6b   $??1??6o   5      ? 5      -   5        $??gTotal??5      
??? ???$??2q?69    5      ?? 5      $	??100 ?6+   ?? 5       5      ?? 5      $??30 ?6(   ?? 5      $??30 ?6(   .+?5!      ?? $??消费金额??6    $??Center=?6,   ?? 5"      -   5        $??	tb_Amount??5"       $
??0.00??61   
???  ??$??Center=?6N   $??1??6k   ?? 5#      $??应付金额??6    $??Center=?6,   $??1??6I   ?? 5$      -   5        $??tb_Total??5$       $
??0.00??60   
???  ??$??Center=?6M   $??1??6j   $??1??6w   5%      5&      ? 5'      -   5        $??gHandle??5'      $??80??6"   
???  ??$??2q?6?   $	??Top=?6J    5(      ?? 5)      $	??100 ?6'   ?? 5*      ?? 5+      .+?5-      ?? $??
Handle.png??6   ?? 5.      -	   5        $??	tb_Handle??5.      $??会员办理??6-   $??Center=?69   $??1??6V   6f   ?? 5/      -
   5        $??tb_Save??5/      $??会员充值??6+   $??Center=?67   $??2??6T   6d   50      ?? 51      -   5        $??
lvSelected??51      ??. $??Disabled=?6f   
??? ? ???6)   ?? ??52      ?? 53      .R?54      ? 55      ??57      ?? 58      .R?59      ? 
??????? 5:      ?? 5;   "   $	??150 ?63   ?? 5<   "   $??70 ?63   ?? 5=   "   $??50 ?63   ?? 5>   "   $??80 ?63    5@      ?? 5A   "   $??50 ?60   .+?5C      ?? ??6(   ?? *Name+?? 5D      $??1??6?   ??6(   ?? *Price+6?   ?? 5E      $??2??6=   ??6(   ?? *Num+6=   ?? 5F      $??3??6@   ??6(   ?? *Amount+6@   5G      5H      5J      5K      ?? 5L   
   -   5        $??lvItems??5L      ??. $??Disabled=?6_   
????  ???6"   ?? ??5M      ?? 5N      .R?5O      ? 5P      ??5R      ?? 5S      .R?5T      ? 
??????? 5U      ?? 5V      $??90 ?6/   ?? 5W      $	??130 ?6/    5Y      ?? 5Z      $??50 ?6,   ?? 5[      $??40 ?6,   .+?5]      ?? $??2??69   ??6    ?? *Image+69   ?? 5^      $??1??6:   ??6$   ?? *Name+6:   ?? 5_      
??? E??$??Right=?6R   $??1??6n   $??1??6{   ??6;   ?? *Price+6{   5`      5a      5c      5d      5e      