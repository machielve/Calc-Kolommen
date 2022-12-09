If(
COUNTCONDITION([Detail_Materiaalstatus_Bon].[Materiaal ID], 
[Detail_Materiaalstatus_Bon].[Voorraadtype]=="1" AND 
[Detail_Materiaalstatus_Bon].[Inkoopbestelling].[Leverancier].[Code]=="5")>0 
AND 
COUNTCONDITION([Detail_Materiaalstatus_Bon].[Materiaal ID], 
[Detail_Materiaalstatus_Bon].[Code]=="T0001" AND 
[Detail_Materiaalstatus_Bon].[Besteld]==[$MaterialState.Waar])==0
, "Welded zonder transport", "")