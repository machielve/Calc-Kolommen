
SUMCONDITION([Detail_Stuklijstcalculatie artikelregel_Stuklijstcalculatie].[Prijs excl. opslag],
[Detail_Stuklijstcalculatie artikelregel_Stuklijstcalculatie].[Artikel].[Artikelgroep].[Code]=="3000"))+

SUMCONDITION([Detail_Stuklijstcalculatie diversregel_Stuklijstcalculatie].[Prijs excl. opslag],
Left([Detail_Stuklijstcalculatie diversregel_Stuklijstcalculatie].[Stuklijstregel divers].[Divers].[Code], 3) == "D30") +

SUMCONDITION([Detail_Stuklijstcalculatie diversregel_Stuklijstcalculatie].[Prijs excl. opslag],
Left([Detail_Stuklijstcalculatie diversregel_Stuklijstcalculatie].[Stuklijstregel divers].[Divers].[Code], 4) == "M003")