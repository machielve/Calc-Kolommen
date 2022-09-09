IF(
(
COUNTCONDITION([Stuklijstregel artikel ID],   
[Artikel].[Detail_Artikelen per leverancier_Artikel].[Artikel type]==       "2" AND
[Artikel].[Detail_Artikelen per leverancier_Artikel].[Relatie]==            [Afwijkende leverancier] AND
[Artikel].[Detail_Artikelen per leverancier_Artikel].[Artikel]==            [Artikel] AND
[Artikel].[Detail_Artikelen per leverancier_Artikel].[Artikel].[Detail_Stuklijstregel artikel_Artikel].[Stuklijstregel artikel ID]==  [Stuklijstregel artikel ID])

+

COUNTCONDITION([Stuklijstregel artikel ID], 
[Artikel].[Detail_Artikelen per leverancier_Artikel].[Artikel type]==       "2" AND 
[Artikel].[Detail_Artikelen per leverancier_Artikel].[Relatie]==            [Artikel].[Hoofdleverancier].[Relatie] AND 
[Artikel].[Detail_Artikelen per leverancier_Artikel].[Artikel]==            [Artikel] AND 
[Artikel].[Detail_Artikelen per leverancier_Artikel].[Artikel].[Detail_Stuklijstregel artikel_Artikel].[Stuklijstregel artikel ID]==   [Stuklijstregel artikel ID] AND

IsEmpty([Afwijkende leverancier]))

-

COUNTCONDITION([Detail_Stuklijst artikel uitbesteed werk_KMB stuklijstregel artikel].[KMB stuklijstregel uitbesteed werk].[Stuklijstregel uitbesteed ID], 
Left([Detail_Stuklijst artikel uitbesteed werk_KMB stuklijstregel artikel].[KMB stuklijstregel uitbesteed werk].[Uitbesteed werk].[Code], 3)=="U10")

)>0,"Afwerking toevoegen","")


