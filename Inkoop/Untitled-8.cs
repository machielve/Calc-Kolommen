If(COUNT([Detail_Inkooporderregel divers_Inkooporder].[Inkooporderregel divers id])>1, 

If(MAX(ConvertIntToString([Detail_Inkooporderregel divers_Inkooporder].[Bonregel divers].[Bon].[Order].[Ordernummer]))==
MIN(ConvertIntToString([Detail_Inkooporderregel divers_Inkooporder].[Bonregel divers].[Bon].[Order].[Ordernummer])), 

MAX(ConvertIntToString([Detail_Inkooporderregel divers_Inkooporder].[Bonregel divers].[Bon].[Order].[Ordernummer])), "Divers"), 

If(COUNT([Detail_Inkooporderregel divers_Inkooporder].[Inkooporderregel divers id])>0, 

MAX(ConvertIntToString([Detail_Inkooporderregel divers_Inkooporder].[Bonregel divers].[Bon].[Order].[Ordernummer])), ""))



