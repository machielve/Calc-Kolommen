If([Artikel].[Voorraadtype]=="1"                                                                    ,                                   "Bestellen", "")+
If([Artikel].[Voorraadtype]=="4" AND [Zaagcode]<>"1"                                                ,                                   "Bestellen", "")+
If([Artikel].[Voorraadtype]=="4" AND [Zaagcode]=="1" AND [Artikel].[Artikeleenheid].[Soort] <>"3"  AND [Magazijn].[Magazijn]==4 ,       "Externe voorraad BCB", "")+
If([Artikel].[Voorraadtype]=="4" AND [Zaagcode]=="1" AND [Artikel].[Artikeleenheid].[Soort] <>"3"  AND [Magazijn].[Magazijn]==2,        "Voorraad", "")+
If([Artikel].[Voorraadtype]=="4" AND [Zaagcode]=="1" AND [Artikel].[Artikeleenheid].[Soort] =="3"  AND [Aantal]<=[@vrije voorraad] ,    "Voorraad", "")+
If([Artikel].[Voorraadtype]=="4" AND [Zaagcode]=="1" AND [Artikel].[Artikeleenheid].[Soort] =="3"  AND [Aantal]>[@vrije voorraad] ,     "Productie ALM", "")

