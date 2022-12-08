SUMCONDITION([Detail_Bonregel artikel_Order].[Detail_Alle reserveringen_Bonregel artikel].[Inkooporderregel artikel].[Netto inkoopprijs], 

[Detail_Bonregel artikel_Order].[Detail_Alle reserveringen_Bonregel artikel].[Inkooporderregel artikel].[Levering compleet]==0)+


SUMCONDITION([Detail_Bonregel divers_Order].[Detail_Alle reserveringen_Bonregel divers].[Inkooporderregel divers].[Netto inkoopprijs], 

[Detail_Bonregel divers_Order].[Detail_Alle reserveringen_Bonregel divers].[Inkooporderregel divers].[Levering compleet]==0)+


SUMCONDITION([Detail_Bonregel uitbesteed werk_Order].[Detail_Alle reserveringen_Bonregel uitbesteed werk].[Inkooporderregel uitbesteed werk].[Netto inkoopprijs], 

[Detail_Bonregel uitbesteed werk_Order].[Detail_Alle reserveringen_Bonregel uitbesteed werk].[Inkooporderregel uitbesteed werk].[Levering compleet]==0)