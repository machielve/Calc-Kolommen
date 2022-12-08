COUNTCONDITION([Order].[Detail_Documenten van order_Order].[Document].[Omschrijving], 
[Order].[Detail_Documenten van order_Order].[Document].[Omschrijving]==ConvertIntToString([Order].[Ordernummer])+
"-"+
ConvertIntToString([Bonnummer])+"-WB")