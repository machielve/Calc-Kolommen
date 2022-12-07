SUMCONDITION(
    
    [Detail_Offerteregels stuklijst_Offerte].[Stuklijst].[Detail_Stuklijstregel artikel_Stuklijst].[Aantal]*
    [Detail_Offerteregels stuklijst_Offerte].[Stuklijst].[Detail_Stuklijstregel artikel_Stuklijst].[Breedte]*
    [Detail_Offerteregels stuklijst_Offerte].[Stuklijst].[Detail_Stuklijstregel artikel_Stuklijst].[Lengte/hoogte], 
    
    Left([Detail_Offerteregels stuklijst_Offerte].[Stuklijst].[Detail_Stuklijstregel artikel_Stuklijst].[Stuklijst].[Stuklijstnummer], 7)=="S100218")