   M S B A M L   `   `   `  ????  马卡龙零售店!    马卡龙零售店.CheckOut   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5          ? SizeToContent$  WidthAndHeight=?5   	    ? WindowStartupLocation$ CenterScreen=?6(    ? 
ResizeMode$ NoResize=?6M   .??5      ]? .+?5   
   ? $??Right=?6    ? ColumnDefinitions 5      ?? 5      $??80 ?6#   ?? 5	      $??80 ?6#   ?? 5
      $??80 ?6#    ? RowDefinitions 5      ?? 5      $??80 ?6    ?? 5      $??80 ?6    ?? 5      $??80 ?6    ?? 5      $??80 ?6    .+?5      ?? -   5        $	??l_1??5      
????  ?$??1??61   6=   ?? 5      -   5        $	??l_2??5      
????  ?$??2??61   $??1??6=   6M   ?? 5      -   5        $	??l_3??5      
????  ?$??3??61   $??2??6=   6M   ?? 5      -   5        $	??l_4??5      
????  ?$??4??61   $??1??6=   6J   ?? 5      -   5        $	??l_5??5      
????  ?$??5??61   $??1??6=   $??1??6J   6Z   ?? 5      -   5        $	??l_6??5      
????  ?$??6??61   $??1??6=   $??2??6J   6Z   ?? 5      -   5        $	??l_7??5      
????  ?$??7??61   $??2??6=   6J   ?? 5      -	   5        $	??l_8??5      
????  ?$??8??61   $??2??6=   $??1??6J   6Z   ?? 5      -
   5        $	??l_9??5      
????  ?$??9??61   $??2??6=   $??2??6J   6Z   ?? 5      -   5        $??l_BackSpace??5      
????  ?$??清空??69   $??3??6F   6S   ?? 5      -   5        $	??l_0??5      
????  ?$??0??61   $??3??6=   $??1??6J   6Z   ?? 5      -   5        $??l_Commit??5      
????  ?$??确定??66   $??3??6C   $??2??6P   6`   5      ?? 5   
   $??Center=?6   .+?5       ? 
???????$??2q?6+    5!      ?? 5"      $	??100 ?6'   ?? 5#      $	??150 ?6'   ?? 5$      $	??100 ?6'   ?? 5%      $	??150 ?6'    5'      ?? 5(      $??50 ?6$   ?? 5)      $??50 ?6$   .+?5+      ?? $??消费金额??6   ?? 5,      -   5        $??	tb_Amount??5,      $
??0.00??6+   
???  ?? ?? 
IsReadOnly . $??1??6Z   ?? 5-      $??支付金额??6   $??2??6(   ?? 5.      -   5        $??tb_Pay??5.      $
??0.00??6(   
???  ?? . $??3??6W   ?? 5/      $??应付金额??6   $??1??6(   ?? 50      -   5        $??tb_Total??50      $
??0.00??6*   
???  ?? . $??1??6Y   $??1??6f   ?? 51      $??找零金额??6   $??1??6(   $??2??65   ?? 52      -   5        $??	tb_Change??52      $
??0.00??6+   
???  ?? . $??1??6Z   $??3??6g   53      ? 54      
????ح?$??2q?6*    55      ?? 56      $	??100 ?6'   ?? 57      $	??150 ?6'   ?? 58      $	??100 ?6'   ?? 59      $	??150 ?6'    5;      ?? 5<      $??50 ?6$   ?? 5=      $??50 ?6$   .+?5?      ?? $??现金支付??6   ?? 5@      -   5        $??tb_Pay_Cash??5@      
????  ?$
??0.00??6?   $??1??6K   ?? 5A      $??刷卡支付??6   $??2??6(   ?? 5B      -   5        $??tb_Pay_Bank??5B      
????  ?$
??0.00??6?   $??3??6K   ?? 5C      $??免单支付??6   $??1??6(   ?? 5D      -   5        $??tb_Pay_Exempt??5D      
????  ?$
??0.00??6A   $??1??6M   $??1??6Z   ?? 5E      $??代卷支付??6   $??1??6(   $??2??65   ?? 5F      -   5        $??tb_Pay_Coupon??5F      
????  ?$
??0.00??6A   $??1??6M   $??3??6Z   5H      ? 5I      -   5        $??gMember??5I      
???????$??2q?65    5J      ?? 5K      $	??100 ?6'   ?? 5L      $	??150 ?6'   ?? 5M      $	??100 ?6'   ?? 5N      $	??150 ?6'    5P      ?? 5Q      $??50 ?6$   ?? 5R      $??50 ?6$   .+?5T      ?? $??会员余额??6   ?? 5U      -   5        $??tb_Member_Balance??5U      
???  ??$
??0.00??6D   $??1??6P   ?? 5V      $??会员支付??6   $??2??6(   ?? 5W      -   5        $??tb_Pay_Member??5W      
????  ?$
??0.00??6A   $??3??6M   ?? 5X      $??会员结余??6   $??1??6(   ?? 5Y      -   5        $??tb_Member_Remain??5Y      
???  ??$
??0.00??6C   $??1??6O   $??1??6\   5Z      5[      5\      5]      