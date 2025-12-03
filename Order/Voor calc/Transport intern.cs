
SUMCONDITION([Detail_Stuklijstcalculatie diversregel_Stuklijstcalculatie].[Prijs excl. opslag],
Left([Detail_Stuklijstcalculatie diversregel_Stuklijstcalculatie].[Stuklijstregel divers].[Divers].[Code], 5) <> "T0003" AND
Left([Detail_Stuklijstcalculatie diversregel_Stuklijstcalculatie].[Stuklijstregel divers].[Divers].[Code], 1) == "T") +
[@Z_inkoop_op]