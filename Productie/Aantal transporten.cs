COUNTCONDITION([Detail_Materiaalstatus_Bon].[Materiaal ID], 

[Detail_Materiaalstatus_Bon].[Besteld]==[$MaterialState.Waar] AND Left([Detail_Materiaalstatus_Bon].[Code], 5)=="T0003")