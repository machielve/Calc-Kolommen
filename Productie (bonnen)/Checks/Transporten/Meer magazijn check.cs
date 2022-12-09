If(
COUNTCONDITION([Detail_Materiaalstatus_Bon].[Materiaal ID], 
[Detail_Materiaalstatus_Bon].[Inkoopbestelling].[Leverancier].[Code]=="26009")>0 
AND 
COUNTCONDITION([Detail_Materiaalstatus_Bon].[Materiaal ID], 
[Detail_Materiaalstatus_Bon].[Code]=="T0011" AND 
[Detail_Materiaalstatus_Bon].[Besteld]==[$MaterialState.Waar])==0
, "Meer magazijn zonder transport", "")