
SUMCONDITION([Detail_Stuklijstcalculatie artikelregel_Stuklijstcalculatie].[Prijs excl. opslag],
[Detail_Stuklijstcalculatie artikelregel_Stuklijstcalculatie].[Artikel].[Artikelgroep].[Code]=="2000"))+

SUMCONDITION([Detail_Stuklijstcalculatie diversregel_Stuklijstcalculatie].[Prijs excl. opslag],
Left([Detail_Stuklijstcalculatie diversregel_Stuklijstcalculatie].[Stuklijstregel divers].[Divers].[Code], 3) == "D20") +

SUMCONDITION([Detail_Stuklijstcalculatie diversregel_Stuklijstcalculatie].[Prijs excl. opslag],
Left([Detail_Stuklijstcalculatie diversregel_Stuklijstcalculatie].[Stuklijstregel divers].[Divers].[Code], 4) == "M001") 
