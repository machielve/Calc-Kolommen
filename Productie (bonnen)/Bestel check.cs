If(
    
COUNTCONDITION(

[Detail_Materiaalstatus_Bon].[Materiaalstatus id], 

[Detail_Materiaalstatus_Bon].[Besteld]==[$MaterialState.Onwaar] AND [Detail_Materiaalstatus_Bon].[Voorraadtype]==[$InventoryKind.Niet voorraadhoudend])>0, "Niet alles besteld", "")