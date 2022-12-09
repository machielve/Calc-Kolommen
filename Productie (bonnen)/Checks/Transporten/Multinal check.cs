If(
COUNTCONDITION([Detail_Materiaalstatus_Bon].[Materiaal ID], 
[Detail_Materiaalstatus_Bon].[Inkoopbestelling].[Leverancier].[Code]=="9161")>0 AND 

COUNTCONDITION([Detail_Materiaalstatus_Bon].[Materiaal ID], 
[Detail_Materiaalstatus_Bon].[Code]=="T0015" AND 
[Detail_Materiaalstatus_Bon].[Besteld]==[$MaterialState.Waar])==0
, "Multinal zonder transport", "")