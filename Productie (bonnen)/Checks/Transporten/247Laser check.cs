If(
COUNTCONDITION([Detail_Materiaalstatus_Bon].[Materiaal ID], 
[Detail_Materiaalstatus_Bon].[Inkoopbestelling].[Leverancier].[Code]=="9128")>0 AND 

COUNTCONDITION([Detail_Materiaalstatus_Bon].[Materiaal ID], 
[Detail_Materiaalstatus_Bon].[Code]=="T0008" AND 
[Detail_Materiaalstatus_Bon].[Besteld]==[$MaterialState.Waar])==0
, "247 Lasersnijden zonder transport", "")