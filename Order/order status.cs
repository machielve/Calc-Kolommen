IF( COUNT([Detail_Bonnen_Order].[Bonnummer])==0,"Nieuw",
IF( (   COUNT([Detail_Bonregel artikel_Order].[Omschrijving])+
        COUNT([Detail_Bonregel bewerking_Order].[Omschrijving])+
        COUNT([Detail_Bonregel divers_Order].[Omschrijving])+
        COUNT([Detail_Bonregel uitbesteed werk_Order].[Omschrijving])



)==0,"Bon is leeg",

IF( COUNTCONDITION([Detail_Materiaalstatus_Order].[Materiaal ID],[Detail_Materiaalstatus_Order].[Gereserveerd]==[$MaterialState.Onwaar])>0, "Open behoefte",
IF( COUNT([Detail_Materiaalstatus_Order].[Materiaal ID])==
    COUNTCONDITION([Detail_Materiaalstatus_Order].[Materiaal ID],[Detail_Materiaalstatus_Order].[Besteld]==[$MaterialState.Waar]), "Alles Besteld",
IF( COUNT([Detail_Materiaalstatus_Order].[Materiaal ID])==
    COUNTCONDITION([Detail_Materiaalstatus_Order].[Materiaal ID],[Detail_Materiaalstatus_Order].[Ontvangen]==[$MaterialState.Waar]), "Alles ontvangen",
IF( COUNT([Detail_Materiaalstatus_Order].[Materiaal ID])==
    COUNTCONDITION([Detail_Materiaalstatus_Order].[Materiaal ID],[Detail_Materiaalstatus_Order].[Onderhanden werk]==[$MaterialState.Waar]), "Alles OHW","Bezig met bestellen"))))))                                



