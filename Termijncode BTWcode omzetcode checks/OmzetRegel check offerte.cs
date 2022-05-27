if  (  MAX([Detail_Offerteregels stuklijst_Offerte].[Omzetcode].[Code])==MIN([Detail_Offerteregels stuklijst_Offerte].[Omzetcode].[Code]) AND   
        MAX([Detail_Offerteregels stuklijst_Offerte].[Omzetcode].[Code])==([Omzetcode].[Code]) AND 
        MIN([Detail_Offerteregels stuklijst_Offerte].[Omzetcode].[Code])==([Omzetcode].[Code]),
        "OmzetRegels correct",
        "OmzetRegels fout"
)
