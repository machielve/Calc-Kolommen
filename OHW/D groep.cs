If(Left([Code], 1) =="T"                                                            , "Transport", "")+
If(Left([Code], 1) =="A"                                                            , "Administratief", "")+
If(Left([Code], 1) =="B"                                                            , "Uitbesteed werk", "")+
If(Left([Code], 3) =="D10" OR Left([Code], 4)=="K002" OR Left([Code], 4)=="K003"    , "Kolommen", "")+
If(Left([Code], 3) =="D15"                                                          , "Schoring", "")+
If(Left([Code], 3) =="D20" OR Left([Code], 4)=="M001"                               , "Koud gewalste liggers", "")+
If(Left([Code], 3) =="D25" OR Left([Code], 4)=="K001"                               , "Warm gewalste liggers", "")+
If(Left([Code], 3) =="D30" OR Left([Code], 4)=="M002"                               , "Vloerdelen", "")+
If(Left([Code], 3) =="D40"                                                          , "Trappen", "")+
If(Left([Code], 3) =="D50"                                                          , "Leuning", "")+
If(Left([Code], 3) =="D51"                                                          , "Hekwerk", "")+
If(Left([Code], 3) =="D55"                                                          , "Pallet opzet plaatsen", "")+
If(Left([Code], 3) =="D80"                                                          , "Montage", "")