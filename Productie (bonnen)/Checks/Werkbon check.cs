COUNTCONDITION([Order].[Detail_Documenten van order_Order].[Document].[Omschrijving], 

Left([Order].[Detail_Documenten van order_Order].[Document].[Omschrijving],9)
==
ConvertIntToString([Order].[Ordernummer])+"-"+ConvertIntToString([Bonnummer])+"-WB")