If([Artikel].[Voorraadtype]=="1",                                                                                                   "Bestellen", "")+
If([Artikel].[Voorraadtype]=="4" AND [Zaagcode]<>"1",                                                                               "Bestellen", "")+
If([Artikel].[Voorraadtype]=="4" AND [Zaagcode]=="1" AND [Artikel].[Artikeleenheid].[Soort] <>"3"   AND [Magazijn].[Magazijn]==4,      "Uit voorraad bij BCB-Almacon", "")+
If([Artikel].[Voorraadtype]=="4" AND [Zaagcode]=="1" AND [Artikel].[Artikeleenheid].[Soort] <>"3"   AND [Magazijn].[Magazijn]==5,      "Uit voorraad bij Laser-Max", "")+

If([Artikel].[Voorraadtype]=="4" AND [Zaagcode]=="1" AND [Artikel].[Artikeleenheid].[Soort] <>"3"   AND [Magazijn].[Magazijn]==2 
AND COUNTCONDITION([Detail_Bonregel artikel uitbesteed werk_KMB bonregel artikel].[Bonregel artikel uitbesteed werk id], [Detail_Bonregel artikel uitbesteed werk_KMB bonregel artikel].[KMB bonregel uitbesteed werk].[Uitbesteed werk].[Code]=="U1610")>0,      "Productie aangestuurd door Almacon", "")+

If([Artikel].[Voorraadtype]=="4" AND [Zaagcode]=="1" AND [Artikel].[Artikeleenheid].[Soort] <>"3"   AND [Magazijn].[Magazijn]==2 
AND COUNTCONDITION([Detail_Bonregel artikel uitbesteed werk_KMB bonregel artikel].[Bonregel artikel uitbesteed werk id], [Detail_Bonregel artikel uitbesteed werk_KMB bonregel artikel].[KMB bonregel uitbesteed werk].[Uitbesteed werk].[Code]=="U1610")==0,      "Pakken uit magazijn Almacon", "")+

If([Artikel].[Voorraadtype]=="4" AND [Zaagcode]=="1" AND [Artikel].[Artikeleenheid].[Soort] =="3"   AND [Aantal]<=[@vrije voorraad],   "Pakken uit magazijn Almacon", "")+
If([Artikel].[Voorraadtype]=="4" AND [Zaagcode]=="1" AND [Artikel].[Artikeleenheid].[Soort] =="3"   AND [Aantal]>[@vrije voorraad],    "Productie aangestuurd door Almacon", "")
