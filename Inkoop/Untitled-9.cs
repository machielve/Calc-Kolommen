If(COUNT([Detail_Inkooporderregel artikel_Inkooporder].[Bon].[Order].[Ordernummer])>0, 
If  (MAX([Detail_Inkooporderregel artikel_Inkooporder].[Bon].[Order].[Ordernummer])==
    MIN([Detail_Inkooporderregel artikel_Inkooporder].[Bon].[Order].[Ordernummer]), 
MAX(ConvertIntToString([Detail_Inkooporderregel artikel_Inkooporder].[Bon].[Order].[Ordernummer])), "Divers"), "")