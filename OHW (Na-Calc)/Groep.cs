If(    
    IsEmpty([Artikel OHW-regel].[OHW-regel artikel]) AND 
    IsEmpty([Uitbesteed werk OHW-regel].[OHW-regel uitbesteed werk ID]), [@D groep], "")+
    
If(
    IsEmpty([Artikel OHW-regel].[OHW-regel artikel]) AND 
    IsEmpty([OHW-regel divers].[OHW-regel divers ID]), [@U groep], "")+
    
If(
    IsEmpty([OHW-regel divers].[OHW-regel divers ID]) AND 
    IsEmpty([Uitbesteed werk OHW-regel].[OHW-regel uitbesteed werk ID]), 
        [Artikel OHW-regel].[Artikel].[Artikelgroep].[Omschrijving], "")