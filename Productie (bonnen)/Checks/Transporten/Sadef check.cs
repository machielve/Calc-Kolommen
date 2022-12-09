If(COUNTCONDITION([Detail_Materiaalstatus_Bon].[Materiaal ID], 

[Detail_Materiaalstatus_Bon].[Inkoopbestelling].[Leverancier].[Code]=="19001")>0 AND 
COUNTCONDITION([Detail_Materiaalstatus_Bon].[Materiaal ID], 
[Detail_Materiaalstatus_Bon].[Code]=="T0002" AND 
[Detail_Materiaalstatus_Bon].[Besteld]==[$MaterialState.Waar])==0, "Sadef zonder transport", "")