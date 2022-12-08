If(COUNTCONDITION([Detail_Materiaalstatus_Bon].[Materiaal ID], 

Left([Detail_Materiaalstatus_Bon].[Inkoopbestelling].[Leverancier].[Code], 9)=="26041")>0 AND 
COUNTCONDITION([Detail_Materiaalstatus_Bon].[Materiaal ID], 
Left([Detail_Materiaalstatus_Bon].[Code], 5)=="T0004" AND 
[Detail_Materiaalstatus_Bon].[Besteld]==[$MaterialState.Waar])==0, "Kampstaal zonder transport", "")