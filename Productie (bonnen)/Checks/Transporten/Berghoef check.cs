If(
COUNTCONDITION([Detail_Materiaalstatus_Bon].[Materiaal ID], 
[Detail_Materiaalstatus_Bon].[Inkoopbestelling].[Leverancier].[Code]=="2002")>0 AND 

COUNTCONDITION([Detail_Materiaalstatus_Bon].[Materiaal ID], 
[Detail_Materiaalstatus_Bon].[Code]=="T0005" AND 
[Detail_Materiaalstatus_Bon].[Besteld]==[$MaterialState.Waar])==0
, "Berghoef zonder transport", "")