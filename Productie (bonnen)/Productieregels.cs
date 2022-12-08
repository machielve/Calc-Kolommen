COUNTCONDITION(
[Detail_Materiaalstatus_Bon].[Materiaal ID], 

[Detail_Materiaalstatus_Bon].[Voorraadtype]<>"1" AND 
[Detail_Materiaalstatus_Bon].[Materiaaltype]=="1" AND 
[Detail_Materiaalstatus_Bon].[Artikelmagazijn].[Artikel].[Artikeleenheid].[Soort]=="3" AND
[Detail_Materiaalstatus_Bon].[Ontvangen]==[$MaterialState.OnWaar]
)