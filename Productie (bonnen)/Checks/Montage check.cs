IF(
COUNTCONDITION([Detail_Bonregel divers_Bon].[Bonregel divers id],
LEFT([Detail_Bonregel divers_Bon].[Diversen].[Code],2)=="D8" AND
[Productsoort].[Omschrijving]<>"Montage"
)>0,"Montage hoort op de montagebon te staan, niet de hoofdlevering","")