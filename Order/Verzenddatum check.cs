If(COUNTCONDITION([Detail_Bonnen_Order].[Bon ID], [Detail_Bonnen_Order].[Productsoort].[Code]=="9999")>0 , "Voorbereiding bon",

If(COUNTCONDITION([Detail_Bonnen_Order].[Bon ID], [Detail_Bonnen_Order].[Productsoort].[Code]<>"9999")==0 , "Geen bonnen", 
If(COUNTCONDITION([Detail_Bonnen_Order].[Bon ID], [Detail_Bonnen_Order].[Verzenddatum bon]==[Verzenddatum]

AND

[Detail_Bonnen_Order].[Productsoort].[Code]<>"9999")==0, "Geen Levering op deze datum", "")))