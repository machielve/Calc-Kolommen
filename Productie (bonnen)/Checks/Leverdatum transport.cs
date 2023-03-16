MAXCONDITION([Detail_Materiaalstatus_Bon].[Inkoopbestelling].[Afgesproken leverdatum], 

Left([Detail_Materiaalstatus_Bon].[Code], 5)=="T0003" AND [Detail_Materiaalstatus_Bon].[Besteld]==[$MaterialState.Waar])