SUMCONDITION(
[Detail_Bonregel artikel_Bon].[Detail_Alle reserveringen_Bonregel artikel].[Inkooporderregel artikel].[Netto inkoopprijs], 
[Detail_Bonregel artikel_Bon].[Detail_Alle reserveringen_Bonregel artikel].[Herkomst soort]=="2")+

SUMCONDITION(
[Detail_Bonregel divers_Bon].[Detail_Alle reserveringen_Bonregel divers].[Inkooporderregel divers].[Netto inkoopprijs], 
[Detail_Bonregel divers_Bon].[Detail_Alle reserveringen_Bonregel divers].[Herkomst soort]=="8")+

SUMCONDITION(
[Detail_Bonregel uitbesteed werk_Bon].[Detail_Alle reserveringen_Bonregel uitbesteed werk].[Inkooporderregel uitbesteed werk].[Netto inkoopprijs],
[Detail_Bonregel uitbesteed werk_Bon].[Detail_Alle reserveringen_Bonregel uitbesteed werk].[Herkomst soort]=="9")
