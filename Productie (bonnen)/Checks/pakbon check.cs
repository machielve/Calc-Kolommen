If(SUMCONDITION([Detail_Bonregel artikel_Bon].[Aantal], 

[Detail_Bonregel artikel_Bon].[Pakbon regel]==1)>

SUM([Detail_Pakbonnen ALM_Bon].[Detail_Pakbonregel ALM artikel_Pakbon ALM].[Aantal]), "Nog niet alle pakbonregels zijn op een pakbon toegevoegd", "")