if(COUNT([Detail_Pakbonnen ALM_Bon].[Pakbon id])
    

    ==0,"Geen pakbon aangemaakt",

    if(COUNT([Detail_Pakbonnen ALM_Bon].[Detail_Pakbonregel ALM artikel_Pakbon ALM].[Pakbonregel artikel id])

        ==0,"Geen pakbon regels aangemaakt",""
    )
)