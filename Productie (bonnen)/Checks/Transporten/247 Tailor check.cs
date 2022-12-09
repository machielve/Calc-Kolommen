If(
COUNTCONDITION([Detail_Materiaalstatus_Bon].[Materiaal ID], 
[Detail_Materiaalstatus_Bon].[Inkoopbestelling].[Leverancier].[Code]=="9097")>0 AND 

COUNTCONDITION([Detail_Materiaalstatus_Bon].[Materiaal ID], 
[Detail_Materiaalstatus_Bon].[Code]=="T0013" AND 
[Detail_Materiaalstatus_Bon].[Besteld]==[$MaterialState.Waar])==0
, "247 Tailorsteel zonder transport", "")