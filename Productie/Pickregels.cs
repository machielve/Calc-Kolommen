COUNTCONDITION(
[Detail_Materiaalstatus_Bon].[Materiaal ID], [Detail_Materiaalstatus_Bon].[Voorraadtype]<>"1" AND 
[Detail_Materiaalstatus_Bon].[Materiaaltype]=="1" AND [Detail_Materiaalstatus_Bon].[Besteld]==[$MaterialState.Waar]
)