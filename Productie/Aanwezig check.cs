If(    
    COUNTCONDITION([Detail_Bonregel artikel_Bon].[bonregel id], 
        [Detail_Bonregel artikel_Bon].[Pakbon regel]==1 AND 
        [Detail_Bonregel artikel_Bon].[Bestelartikel inkoop klaar]==0 AND 
        [Detail_Bonregel artikel_Bon].[Artikel].[Voorraadtype]=="1")>0, "Pakbon regels niet ontvangen", "")