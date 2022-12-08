If(COUNTCONDITION([Detail_Materiaalstatus_Bon].[Materiaal ID], 

Left([Detail_Materiaalstatus_Bon].[Inkoopbestelling].[Leverancier].[Code], 8)=="2002")>0 

AND COUNTCONDITION([Detail_Materiaalstatus_Bon].[Materiaal ID], 

Left([Detail_Materiaalstatus_Bon].[Code], 5)=="T0005" AND 
        [Detail_Materiaalstatus_Bon].[Besteld]==[$MaterialState.Waar])==0, "Berghoef zonder transport", "")