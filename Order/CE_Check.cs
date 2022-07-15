COUNTCONDITION(
    [Detail_Documenten van order_Order].[Documenten van order ID], 
    
    [Detail_Documenten van order_Order].[Document].[Omschrijving]==
    ConvertIntToString([Detail_Documenten van order_Order].[Order].[Ordernummer])+"_ce-markering")