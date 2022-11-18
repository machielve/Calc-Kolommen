If(COUNTCONDITION(
[Detail_Materiaalstatus_Bon].[Materiaalstatus id], [Detail_Materiaalstatus_Bon].[Besteld]==[$MaterialState.Onwaar] AND 

[Detail_Materiaalstatus_Bon].[Voorraadtype]==[$InventoryKind.Voorraadhoudend]

)>0, "Voorraad nog pakken", "")