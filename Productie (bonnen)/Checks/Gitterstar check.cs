If(COUNTCONDITION([Detail_Materiaalstatus_Bon].[Materiaal ID],
 
Left([Detail_Materiaalstatus_Bon].[Inkoopbestelling].[Leverancier].[Code], 10)=="26174")>0 AND 
COUNTCONDITION([Detail_Materiaalstatus_Bon].[Materiaal ID], 
Left([Detail_Materiaalstatus_Bon].[Code], 5)=="T0006" AND 
[Detail_Materiaalstatus_Bon].[Besteld]==[$MaterialState.Waar])==0, "GitterStar zonder transport", "")