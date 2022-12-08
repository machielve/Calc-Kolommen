If(Left([Code], 1) =="T"                                                            , "Transport", "")+
if(Left([Code], 1) =="A"                                                            , "Administratief", "")+
if(Left([Code], 1) =="B"                                                            , "Bewerkingen", "")+
If(Left([Code], 3) =="D10" OR Left([Code], 4)=="K002" OR Left([Code], 4)=="K003"    , "Kolommen", "")+
if(Left([Code], 3) =="D20"                                                          , "Koud gewalste liggers", "")+
If(Left([Code], 3) =="D25" OR Left([Code], 4)=="K001"                               , "Warm gewalste liggers", "")+
If(Left([Code], 3) =="D30" OR Left([Code], 4)=="M002"                               , "Vloerdelen", "")+
if(Left([Code], 3) =="D40"                                                          , "Trappen", "")+
if(Left([Code], 3) =="D50"                                                          , "Leuning", "")+
if(Left([Code], 3) =="D51"                                                          , "Hekwerk", "")+
if(Left([Code], 3) =="D55"                                                          , "Pallet opzet plaatsen", "")+
If(Left([Code], 3) =="D80"                                                          , "Montage", "")