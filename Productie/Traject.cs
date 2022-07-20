If([Artikel].[Voorraadtype]=="1"                                                                    , "Bestellen"       , "")+
If([Artikel].[Voorraadtype]=="4" AND [Zaagcode]<>"1"                                                , "Bestellen"       , "")+
If([Artikel].[Voorraadtype]=="4" AND [Zaagcode]=="1" AND [Artikel].[Artikeleenheid].[Soort] <>"3"   , "Voorraad"        , "")+
If([Artikel].[Voorraadtype]=="4" AND [Zaagcode]=="1" AND [Artikel].[Artikeleenheid].[Soort] =="3"   , "ALM productie"   , "")