IF(ConvertIntToString([Inkooporderregel artikel].[Inkooporderregel artikel id])<>"", ConvertIntToString(MAX([Inkooporderregel artikel].[Detail_Alle reserveringen_Inkooporderregel artikel].[Bonregel artikel].[Order].[Ordernummer])),"")+
IF(ConvertIntToString([Inkooporderregel divers].[Inkooporderregel divers id])<>"", ConvertIntToString(MAX([Inkooporderregel divers].[Detail_Alle reserveringen_Inkooporderregel divers].[Bonregel divers].[Order].[Ordernummer])),"")+
IF(ConvertIntToString([Inkooporderregel uitbesteed werk].[Inkooporderregel uitbesteed werk id])<>"", ConvertIntToString(MAX([Inkooporderregel uitbesteed werk].[Detail_Alle reserveringen_Inkooporderregel uitbesteed werk].[Bonregel uitbesteed werk].[Order].[Ordernummer])),"")+


