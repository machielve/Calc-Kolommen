SUMCONDITION([Detail_Bonregel artikel_Order].[Kostprijs]*[Detail_Bonregel artikel_Order].[Aantal], 

[Detail_Bonregel artikel_Order].[Registratietraject]=="4" AND 
[Detail_Bonregel artikel_Order].[Voorraad afgehandeld]==0)