If([Artikel].[Voorraadtype]=="1"                                                                    ,                                   "Bestellen", "")+
If([Artikel].[Voorraadtype]=="4" AND [Zaagcode]<>"1"                                                ,                                   "Bestellen", "")+
If([Artikel].[Voorraadtype]=="4" AND [Zaagcode]=="1" AND [Artikel].[Artikeleenheid].[Soort] <>"3"   AND [Magazijn].[Magazijn]==4 ,       "Externe voorraad BCB", "")+
If([Artikel].[Voorraadtype]=="4" AND [Zaagcode]=="1" AND [Artikel].[Artikeleenheid].[Soort] <>"3"   AND [Magazijn].[Magazijn]==5 ,       "Externe voorraad L-Max", "")+

If([Artikel].[Voorraadtype]=="4" AND [Zaagcode]=="1" AND [Artikel].[Artikeleenheid].[Soort]<>"3" AND [Magazijn].[Magazijn]==2 
AND COUNTCONDITION([Detail_Bonregel artikel uitbesteed werk_KMB bonregel artikel].[Bonregel artikel uitbesteed werk id], [Detail_Bonregel artikel uitbesteed werk_KMB bonregel artikel].[KMB bonregel uitbesteed werk].[Uitbesteed werk].[Code]=="U1610")>0, "Productie ALM", "")+

If([Artikel].[Voorraadtype]=="4" AND [Zaagcode]=="1" AND [Artikel].[Artikeleenheid].[Soort] <>"3"   AND [Magazijn].[Magazijn]==2 
AND COUNTCONDITION([Detail_Bonregel artikel uitbesteed werk_KMB bonregel artikel].[Bonregel artikel uitbesteed werk id], [Detail_Bonregel artikel uitbesteed werk_KMB bonregel artikel].[KMB bonregel uitbesteed werk].[Uitbesteed werk].[Code]=="U1610")==0,        "Voorraad", "")+

If([Artikel].[Voorraadtype]=="4" AND [Zaagcode]=="1" AND [Artikel].[Artikeleenheid].[Soort] =="3"   AND [Aantal]<=[@vrije voorraad] ,    "Voorraad", "")+
If([Artikel].[Voorraadtype]=="4" AND [Zaagcode]=="1" AND [Artikel].[Artikeleenheid].[Soort] =="3"   AND [Aantal]>[@vrije voorraad] ,     "Productie ALM", "")

