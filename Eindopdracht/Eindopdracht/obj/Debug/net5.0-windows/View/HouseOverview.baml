   M S B A M L   `   `   `  ????G  CEindopdracht, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Eindopdracht.ViewEindopdracht.View  5      %    Eindopdracht.View.HouseOverview   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:Eindopdracht.View     5        N? Title$  HouseOverview??5	      .??5      ? ??5   
   ?? 5       ?? ImageSource$ /Background2.png??6    ? RowDefinitions 5   
   ?? 5      $
??Auto ?6   ?? 5      $??* ?6   ?? 5      $
??Auto ?6   .+?5   
   ]? .+?5       ? -   5          ?Name$ _NavigationFrame??5        ? NavigationUIVisibility$ Hidden=?6.   5      ?? 5   
   -   5        $??	HouseGrid??5      $??1??6$   $??4,178,12,13q?61   ??6G   ?? *	AllHouses+ ?? SelectedItem 6i   ?? *SelectedHouse+ ?? Mode$ TwoWay=? ?? View 5      ?? 5      -   5        grdTest??.P?5      ?? $??
House Name??6%    ?? Width$	 100??6f   	 ?? DisplayMemberBinding	 69   ?? *	HouseName+6f   ?? 5      $??House Description??6%   $	 200??6r   	 6@   ?? *HouseDescription+6r   ?? 5      $??
House Type??6%   $ 80??6d   	 69   ?? *	HouseType+6d   ?? 5      $??Landlord??6%   $	 120??67   
 ?? CellTemplate
 5      ?? 5       .R?5!   "   ?? ??5"   &   `? 5#   *    ?? StringFormat$ {0} {1}??67   .1?5$   .   ??  ?? Path$ Landlord.FirstName?66   ?? 5%   .   $ Landlord.LastName?66   5&   +   5(   #   5)      5+      ?? 5,      $??
Max Person??6%   $ 80??6d   	 69   ?? *	MaxPerson+6d   ?? 5-      $??Price??6%   $ 50??6[   	 64   ?? *Price+6[   ?? 5.      $
??City??6%   $	 100??6Y   	 63   ?? *City+6Y   ?? 5/      $??Country??6%   $	 100??6_   	 66   ?? *	Country+6_   50      52      ?? 53   
   -   5        $??btnUpdateHouse??53   j   $??Update??6   $??1??6"   $??28??6/   $
??Left=?6;   $??
176,20,0,0q?6V   $	??Top=?54      $	??114??6)    ? 	Resources 55       ?? 
TargetType ?? Property ?? Value??%_   '??       ?? 56      " ??6   .?57      ??  ?@??CornerRadius$ 10??65   58      59      5:      ?? 5;   
   -   5         ??Name$ btnDeleteHouse??5;   j   $??Delete??6   $??1??6"   $??28??6/   $
??Left=?6;   $??
316,20,0,0q?6V   $	??Top=?5<      $	??114??6%   ??5=      ?? $ DeleteHouseClick? 5>      ??%_   '??       ?? 5?      " ??6   .?5@      ??  ?@??CornerRadius$ 10??65   5A      5B      5C      ?? 5D   
   -   5        $ openAddHousePage??5D      $??	Add House??6+   $
??Left=?6?   $??	36,20,0,0q?6Z   $??1??6m   $	??Top=?6z   $??28??6?   $	??114??6?    5E      ??%_   '??       ?? 5F      " ??6   .?5G      ??  ?@??CornerRadius$ 10??65   5H      5I      5J      5K      5L      